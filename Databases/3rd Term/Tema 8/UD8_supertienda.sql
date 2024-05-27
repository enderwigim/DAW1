USE SUPERTIENDA
GO
				---------------------------
				--   UD8  -  PROC & FUNC -- 
				---------------------------
-------------------------------------------------------------------------------------------
-- NOTA: Recuerda cuidar la limpieza del código (tabulaciones, nombres de tablas en mayúscula,
--		nombres de variables en minúscula, poner comentarios sin excederse, código organizado y fácil de seguir, etc.)
--
--	Si alguna tabla fuera IDENTITY y haces una inserción, puedes obtener el id llamando a la función SCOPE_IDENTITY()
--
-------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------
-- 1. Implementa un procedimiento llamado 'crearCategoria' que inserte una nueva categoría de productos.
--		Parámetros de entrada: codCategoria, nombreCategoria
--		Parámetros de salida: <ninguno>
--		Tabla: CATEGORIAS
--		
--		# Se debe comprobar que todos los parámetros obligatorios están informados, sino devolver -1 y finalizar
--		# Se debe comprobar que el codCategoria no exista en la tabla, y si así fuera, 
--			imprimir un mensaje indicándolo, devolver -1 y finalizar
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una desde un script y comprobando la finalización del mismo
-------------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE crearCategoria @codCategoria CHAR(2),
                                         @nombreCategoria VARCHAR(100)
AS
BEGIN
  -- Validamos los parametros
  DECLARE @parametrosNulos VARCHAR(MAX) = ''
  IF @codCategoria IS NULL
    SET @parametrosNulos += '@codCategoria'
  
  IF @nombreCategoria IS NULL
    SET @parametrosNulos += '@nombreCategoria'
  
  IF @parametrosNulos <> ''
  BEGIN
    PRINT CONCAT('Los siguientes parametros no pueden ser nulos: ', @parametrosNulos)
    RETURN -1
  END

  IF EXISTS (SELECT *
               FROM CATEGORIAS
              WHERE @codCategoria = codCategoria)
  BEGIN
    PRINT 'Ese codCategoria ya existe'
    RETURN -2
  END

  INSERT INTO CATEGORIAS(codCategoria, nombre)
  VALUES(@codCategoria, @nombreCategoria)
END

------------------------------------------------------------------------------------------------
-- Implementamos
GO

DECLARE @codCategoria CHAR(2) = 'AA'
DECLARE @nombreCategoria VARCHAR(100) = 'Productos Argentinos'
DECLARE @ret INT

EXEC @ret = crearCategoria @codCategoria,
                           @nombreCategoria

IF @ret <> 0
  RETURN

PRINT 'Procedimiento terminado'
                                        



-------------------------------------------------------------------------------------------
-- 2. Implementa un procedimiento que cree una nueva subcategoría de producto.
--		Parámetros de entrada: codCategoria, nombreSubCategoria
--		Parámetros de salida: codSubCategoria
--		Tabla: SUBCATEGORIAS

--		# Se debe comprobar que todos los parámetros obligatorios están informados, sino devolver -1 y finalizar
--		# Se debe comprobar que el idCategoria SI existe en la tabla (sino no podemos crear la subcategoria)
--			Si no existiera, imprimir un mensaje indicándolo, devolver -1 y finalizar
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--		
--	  *Comprueba que el funcionamiento es correcto realizando una desde un script y comprobando la finalización del mismo
-------------------------------------------------------------------------------------------
EXEC sp_help SUBCATEGORIAS
-- Subcategoria maneja una PK IDENTITY
GO
CREATE OR ALTER PROCEDURE CrearSubcategoriaProducto (@codCategoria CHAR(2),
                                                     @nombreSubCategoria VARCHAR(100),
                                                     @codSubCategoria INT OUTPUT)
AS
BEGIN
      -- SETEAMOS @codSubCategoria a null
      SET @codSubCategoria = NULL

      --Validamos los parametros
      DECLARE @validationErrors VARCHAR(MAX) = ''

      -- Validamos que @codCategoria no sea null.
      IF @codCategoria IS NULL 
        OR LEN(@codCategoria) < 2
      BEGIN
        SET @validationErrors += ' @codCategoria,'
      END

      IF @nombreSubCategoria IS NULL
        SET @validationErrors += ' @nombreSubCategoria,'
      
      IF @validationErrors <> ''
      BEGIN
        SET @validationErrors = 'El formato de los siguientes parametros es erroneo:' + @validationErrors;
        -- Extraemos el ultimo caracter, que será una ,
        SET @validationErrors = LEFT(@validationErrors, LEN(@validationErrors) - 1) 
        PRINT @validationErrors
        RETURN -1
      END

      -- Validamos que @codCategoria exista.
      IF NOT EXISTS (SELECT *
                      FROM CATEGORIAS
                      WHERE UPPER(codCategoria) =  UPPER(@codCategoria))
      BEGIN
        PRINT '@codCategoria no existe en la base de datos.'
        RETURN -1
      END

      INSERT INTO SUBCATEGORIAS(codCategoria, nombre)
      VALUES(@codCategoria, @nombreSubCategoria)
      
      -- SETEAMOS @codSubCategoria
      SET @codSubCategoria = SCOPE_IDENTITY()

END

GO
DECLARE @ret INT;
DECLARE @nombre VARCHAR(100) = 'SebaCrack'
DECLARE @codCategoria CHAR(2) = 'al'
DECLARE @codSubCategoria INT = NULL

EXEC @ret = CrearSubcategoriaProducto @codCategoria, @nombre, @codSubCategoria OUTPUT

IF @ret <> 0
  RETURN

PRINT 'Procedimiento compleado con exito'
PRINT @codSubCategoria

DELETE FROM SUBCATEGORIAS
  WHERE codSubcategoria = 1006

SELECT *
  FROM SUBCATEGORIAS

-------------------------------------------------------------------------------------------
-- 3. Implementa un procedimiento que cree un nuevo producto en la base de datos.
--		Parámetros de entrada: nombre, precioUnitario, IVA e codSubCategoria
--		Parámetros de salida: codProducto creado
--		Tabla: PRODUCTOS
--		
--		# Se debe comprobar que todos los parámetros *obligatorios* están informados, sino devolver -1 y finalizar
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--		
--	  * Comprueba que el funcionamiento es correcto realizando una desde un script y comprobando la finalización del mismo
-------------------------------------------------------------------------------------------



-------------------------------------------------------------------------------------------
-- 4. Implementa un procedimiento que cree una nueva valoración de un cliente a un producto
--		Parámetros de entrada: codCliente, codProducto, estrellas, fechaValoracion y comentario
--		Parámetros de salida: <ninguno>
--		Tabla: VALORACIONES_PRODUCTOS
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros, transacciones si fueran necesarias, etc.
--	
--	 
--	  * Comprueba que el funcionamiento es correcto realizando una desde un script y comprobando la finalización del mismo
-------------------------------------------------------------------------------------------



-------------------------------------------------------------------------------------------
-- 5. Implementa un procedimiento que cree un nuevo pedido
--		Parámetros de entrada: codCliente, codVendedor, codTransportista, costeEnvio, recogidaTiendaSN
--		Parámetros de salida: codPedido
--		Tabla: PEDIDOS
--		
--		# Se debe comprobar que los parámetros codCliente e codVendedor están informados, sino devolver -1 y finalizar
--		# El resto de campos de la tabla que no se pasan como parámetro de entrada se informarán a cero en la sentencia INSERT
--		# NO hace falta comprobar que el codCliente y el codVendedor existan. Si no existieran, fallará la sentencia INSERT
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--		
--	  * Comprueba que el funcionamiento es correcto realizando una desde un script y comprobando la finalización del mismo
-------------------------------------------------------------------------------------------




-------------------------------------------------------------------------------------------
-- 6. Implementa un procedimiento crearLineaPedido que cree una nueva línea de pedido
--		Parámetros de entrada: codPedido, codProducto y unidades
--		Parámetros de salida: <ninguno>
--		Tabla: LINEAS_PEDIDOS
--		
--		# El precio del producto (campo 'precioCompra') debes obtenerlo previamente de la tabla PRODUCTOS
--		# El campo totalLinea es un campo derivado (se actualiza automáticamente), por lo que NO hay que indicarlo en la INSERT.
--		# Se debe comprobar que los parámetros codPedido, codProducto y unidades están informados, sino devolver -1 y finalizar
--		# NO hace falta comprobar que el codPedido y el codProducto existan. Si no existieran, fallará la sentencia INSERT
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--		
--	  * Comprueba que el funcionamiento es correcto realizando una desde un script y comprobando la finalización del mismo
-------------------------------------------------------------------------------------------



-------------------------------------------------------------------------------------------
-- 7. Implementa un script que utilice los procedimientos crearPedido y crearLineaPedido y 
--		que cree un nuevo pedido y que el pedido tenga dentro 2 productos cualesquiera.
--	
--	Recuerda la utilización de TRY/CATCH y transacciones.
--		Ejemplo. Si se llega a crear el pedido y falla la creación de una de las líneas,
--			deberá retroceder los cambios al estado inicial (ROLLBACK)
--
--  Ayuda 1: Considera quitar las transacciones de dentro de los procedimientos.
--  Ayuda 2: Utiliza una transacción que se inicie en el script de llamada
--     y que el COMMIT se haga al final
-------------------------------------------------------------------------------------------




-------------------------------------------------------------------------------------------
--8. Implementa una función llamada getNumPedidos que reciba como parámetro un idCliente y devuelva
--		el número de pedidos realizados por dicho cliente.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
--
--  Ayuda: recuerda incluir el prefijo dbo. al llamar a la función
--   En las funciones nunca debes indicar un valor directamente (es decir, "hardcodeado")
-------------------------------------------------------------------------------------------
GO

CREATE OR ALTER FUNCTION getNumPedidos (@codCliente INT)
RETURNS DECIMAL(10,0)
AS
BEGIN
    RETURN (SELECT ISNULL(COUNT(codPedido), 0)
              FROM PEDIDOS
             WHERE codCliente = @codCliente)
    
END

SELECT codCliente,
       dbo.getNumPedidos(codCliente) AS Cantidad_Pedidos 
  FROM CLIENTES



-------------------------------------------------------------------------------------------
-- 9. Implementa una función llamada getCostePedidos que reciba como parámetro un idCliente y devuelva
--		el coste de todos los pedidos realizados por dicho cliente.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
SELECT codCliente, <llamada a tu funcion>
  FROM CLIENTES;


-------------------------------------------------------------------------------------------
-- 10. Implementa una función llamada ventasTotalesVendedor que reciba como parámetro un idVendedor y devuelva
--		el importe vendido por dicho vendedor.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
SELECT codVendedor, <llamada a tu funcion>
  FROM VENDEDORES;




-------------------------------------------------------------------------------------------
-- 11. Ampliación Describe el funcionamiento e implementa un procedimiento que incluya 
--	TRY/CATCH y transacciones utilizando la BD TIENDA_DB.
-------------------------------------------------------------------------------------------


-------------------------------------------------------------------------------------------
-- 12. Ampliación Describe el funcionamiento e implementa una función que utilice
--	alguna de las tablas de la BD TIENDA_DB.
-------------------------------------------------------------------------------------------

