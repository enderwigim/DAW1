
/*
1.- Gestión de cursores (2 puntos)

Crea un script que itere por cada uno de los registros de la tabla OFICINAS

Para cada oficina deberá mostrarse una línea con la siguiente información:

“La oficina XXX, ubicada en la ciudad YYY, tiene un total de ZZZ empleados”

Siendo:
      XXX: el código de la oficina
      YYY: la ciudad de la oficina
      ZZZ: el número de empleados que trabajan en ella
*/
USE JARDINERIA
EXEC sp_help OFICINAS
DECLARE @codOficina CHAR(6)
DECLARE @ciudad VARCHAR(40)
DECLARE @cantidadEmpleados INT

-- Declaramos el primer cursor
DECLARE Cur_Oficina CURSOR FOR
SELECT codOficina,
       ciudad
  FROM OFICINAS

-- Abrimos el cursor.
OPEN Cur_Oficina

-- Obtenemos el primer valor.
FETCH NEXT FROM Cur_Oficina INTO @codOficina, @ciudad

-- En caso de que obtengamos algun valor, se mantiene abierto el siguiente bucle.
WHILE @@FETCH_STATUS = 0
BEGIN

      -- Seteamos el valor de @cantidadEmpleados
      SELECT @cantidadEmpleados = ISNULL(COUNT(codEmpleado), 0)
        FROM EMPLEADOS
       WHERE codOficina = @codOficina
      -- Imprimimos los datos.
      PRINT CONCAT('La oficina ', @codOficina, ', ubicada en la ciudad ', @ciudad, 
                   ', tiene un total de ', @cantidadEmpleados, ' empleados')
      -- Obtenemos el proximo valor.
      FETCH NEXT FROM Cur_Oficina INTO @codOficina, @ciudad
END


/*
Crear una función llamada cuentaProductosCategoria que reciba como parámetros un codCategoria, un minPrecio y un maxPrecio; 
y devuelva el número de productos incluidos en ella cuyo precio esté comprendido entre minPrecio y maxPrecio.

Crear una función llamada obtenerCostePedido que reciba como parámetro un codPedido y devuelva el coste total de dicho pedido 
(no se permite el uso del campo totalLinea, debe calcularse dentro de la función).

Implementa, también, dos SELECTs en las que pruebes el correcto funcionamiento de las 
funciones cuentaProductosCategoria y obtenerCostePedido.

*/
USE JARDINERIA
GO
-- Creamos la función
CREATE OR ALTER FUNCTION cuentaProductosCategoria (@codCategoria CHAR(2),
                                                   @minPrecio DECIMAL(9,2),
                                                   @maxPrecio DECIMAL(9,2))
RETURNS DECIMAL(13,0)
AS
BEGIN
      RETURN (SELECT ISNULL(COUNT(codProducto), 0)
                FROM PRODUCTOS
               WHERE precio_venta BETWEEN @minPrecio AND @maxPrecio
                 AND codCategoria = @codCategoria)
END
GO
-- Validamos el correcto funcionamiento de la función.
DECLARE @minPrecio DECIMAL(9,2) = 10.00
DECLARE @maxPrecio DECIMAL(9,2) = 1000.00
SELECT codCategoria, dbo.cuentaProductosCategoria(codCategoria, @minPrecio, @maxPrecio)
  FROM CATEGORIA_PRODUCTOS

GO
-- Dado a que el precio_unidad es un DECIMAL(9,2) devolveremos un
-- DECIMAL(11,2)
CREATE OR ALTER FUNCTION obtenerCostePedidos (@codPedido INT)
RETURNS DECIMAL(11,2)
AS BEGIN
      RETURN (SELECT ISNULL(SUM(precio_unidad*cantidad), 0)
                FROM DETALLE_PEDIDOS
               WHERE codPedido = @codPedido)
END
GO
-- Validamos el correcto funcionamiento de la función
SELECT codPedido,
       dbo.obtenerCostePedidos(codPedido) AS costePedido
  FROM PEDIDOS



/*
4.- Gestión de triggers (1 punto)

Crea un trigger llamado TR_CATEGORIA_PRODUCTOS que se active cuando se actualice 
o se elimine un registro de la tabla CATEGORIA_PRODUCTOS y cree automáticamente una 
copia de seguridad del registro modificado/borrado en otra tabla llamada HIST_CAT_PRODUCTOS
 que tenga la misma estructura que la tabla CATEGORIA_PRODUCTOS más otro campo llamado 
 fechaOperación de tipo fecha/hora. Este campo deberá rellenarse con la fecha del día.


*/
GO
-- Creamos la tabla HIST_CAT_PRODUCTOS
SELECT * 
  INTO HIST_CAT_PRODUCTOS
  FROM CATEGORIA_PRODUCTOS
 WHERE 1 = 0

-- Alteramos la tabla y agregamos el campo fechaOperacion
ALTER TABLE HIST_CAT_PRODUCTOS
  ADD fechaOperacion SMALLDATETIME

GO
CREATE OR ALTER TRIGGER TX_CATEGORIA_PRODUCTOS ON CATEGORIA_PRODUCTOS
AFTER DELETE, UPDATE
AS
BEGIN
      -- Insertamos los datos borrados en HIST_CAT_PRODUCTOS
      INSERT INTO HIST_CAT_PRODUCTOS
      SELECT *, GETDATE()
        FROM DELETED
END


UPDATE CATEGORIA_PRODUCTOS
   SET nombre = 'ORNAMENTALES'
 WHERE codCategoria = 'OR' 

SELECT *
  FROM CATEGORIA_PRODUCTOS

SELECT *
  FROM HIST_CAT_PRODUCTOS


/*
3
*/
-- Crearemos un procedimiento para obtener una nueva id_transaccion
GO
CREATE OR ALTER PROCEDURE getNewIdTransaccion(@id_transaccion VARCHAR(15) OUTPUT)
AS
BEGIN
      -- Declaramos el codigo a usar.
      DECLARE @cod INT
      -- Declaramos la cantidad de caracteres que tendra nuestro id_transaccion
      DECLARE @count INT = 8
      -- Declaramos el formato de nuestro id_transaccion. Lo iniciaremos en 
      -- VARCHAR(15), pero luego lo devolveremos casteado como CHAR(15)
      SET @id_transaccion = 'ak-std-'
      -- Obtenemos el ultimo id_transaccion
      SELECT @cod = RIGHT(id_transaccion, 8) + 1
        FROM PAGOS
      WHILE @count > LEN(@cod)
      BEGIN
            SET @id_transaccion += '0'
            SET @count = @count - 1
      END
      SET @id_transaccion = @id_transaccion + CAST(@cod AS VARCHAR(8))

END



GO
CREATE OR ALTER PROCEDURE realizarPago(@codCliente INT,
                                       @codFormaPago CHAR(1),
                                       @importePago DECIMAL(9,2),
                                       @codPedido INT)
AS
BEGIN
      BEGIN TRY
            -- Declaramos una variable para analizar si debemos realizar una transaccion o no.
            DECLARE @openTran BIT = 1
            IF @@TRANCOUNT = 0
            BEGIN
                  SET @openTran = 0
                  BEGIN TRAN
            END

            -- Validación del correcto ingreso de los parametros.
            DECLARE @validationErrors VARCHAR(MAX) = ''
            IF @codCliente IS NULL 
            OR @codCliente <= 0
                  SET @validationErrors += ' @codCliente,'
            IF @codFormaPago IS NULL
                  SET @validationErrors += ' @codFormaPago,'
            IF @importePago IS NULL
                  SET @validationErrors += ' @importePago,'
            -- @codPedidos es nulleable segun como esta constituida la tabla.
            -- Si esto quisiera modificarse en el futuro, habria que activar la siguientes lineas:
                  /*
                  IF @codPedido IS NULL
                        SET @validationErrors = ' @codPedido'
                  */
            IF @validationErrors <> ''
            BEGIN
                  -- Seteamos el mensaje de salida.
                  SET @validationErrors = 'Los siguientes parametros no son validos' + @validationErrors
                  -- Quitamos la coma del final, mejorando el formato.
                  SET @validationErrors = LEFT(@validationErrors, LEN(@validationErrors) - 1) + '.'
                  PRINT @validationErrors
                  RETURN -1
            END

            -- Validamos que tanto codCliente y codPedido, si no es null, existan.
            IF NOT EXISTS (SELECT 1
                        FROM CLIENTES
                        WHERE codCliente = @codCliente)
            BEGIN
                  PRINT CONCAT('El @codCliente: ', @codCliente, ' no existe.')
                  RETURN -2
            END
            IF @codPedido IS NOT NULL
                  IF NOT EXISTS (SELECT 1
                              FROM PEDIDOS
                              WHERE codPedido = @codPedido)
                  BEGIN
                        PRINT CONCAT('El @codPedido: ', @codPedido, ' no existe.')
                        RETURN -3
                  END
            
            -- Comenzaremos obteniendo el @id_transaccion a partir del siguiente procedimiento.
            -- Lo he puesto en otro procedimiento para ahorrarnos tener demasiadas lineas de codigo
            -- en este procedimiento.
            DECLARE @id_transaccion VARCHAR(15)

            EXEC getNewIdTransaccion @id_transaccion OUTPUT
            
            -- Insertamos el PAGO.
            INSERT INTO PAGOS(codCliente, codFormaPago, importe_pago, codPedido, fechaHora_pago, id_transaccion)
            VALUES (@codCliente, @codFormaPago, @importePago, @codPedido, GETDATE(), CAST(@id_transaccion AS CHAR(15)))

            -- La actualización en PEDIDOS la realizaremos solo si @codPedido existe. Sino, no lo haremos.
            IF @codPedido IS NOT NULL
            BEGIN
                  -- Declaramos @comentario VARCHAR(500), respetando el comentario de la tabla Pedidos
                  DECLARE @comentario VARCHAR(500)

                  -- Seteamos @comentario
                  SELECT @comentario = ISNULL(comentarios, '')
                  FROM PEDIDOS
                  WHERE codPedido = @codPedido  

                  SET @comentario = @comentario + CHAR(10) + 'Pago Realizado.'
                  -- Update de pedidos
                  UPDATE PEDIDOS
                  SET codEstado = 'F',
                        comentarios = @comentario
                  WHERE codPedido = @codPedido
            END

            PRINT 'El pago se ha realizado correctamente.'

            IF @openTran = 0
                  COMMIT
      END TRY
      BEGIN CATCH
            PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
			       ', DESCRIPCION: ', ERROR_MESSAGE(),
				 ', LINEA: ', ERROR_LINE(),
		       	 ', PROCEDURE: ', ERROR_PROCEDURE())
            IF @openTran = 0
                  ROLLBACK
      END CATCH
END

--- Validamos
GO
DECLARE @ret INT
DECLARE @codCliente INT = 6
DECLARE @codFormaPago CHAR(1) = 'C'
DECLARE @importePago DECIMAL(9,2) = 1000.00
DECLARE @codPedido INT = 1

EXEC @ret = realizarPago @codCliente, @codFormaPago, @importePago, @codPedido

IF @ret <> 0
      RETURN

PRINT 'El procedimiento se ha realizado con exito.'

SELECT id_transaccion
  FROM PAGOS

