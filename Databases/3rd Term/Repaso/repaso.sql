/* A) Crea un procedimiento llamado crearPedidoActualizaPago que reciba como parámetros de entrada:
fecha_esperada, fecha_entrega, codEstado, comentarios, codCliente
 
 1º Validar los parámetros de entrada
 2º Insertar un pedido nuevo en la tabla PEDIDOS
 3º Actualizar la tabla PAGOS; el campo codPedido con el codPedido para los pedidos del cliente que no tengan
 codPedido */

USE JARDINERIA
EXEC sp_help PEDIDOS
EXEC sp_help PAGOS
SELECT *
  FROM PAGOS
GO
CREATE OR ALTER PROCEDURE crearPedidoActualizaPago(@fecha_esperada DATE,
                                                   @fecha_entrega DATE,
                                                   @codEstado CHAR(1),
                                                   @comentarios VARCHAR(500),
                                                   @codCliente INT)
AS
BEGIN
    BEGIN TRY
        -- Validamos los parametros.
        DECLARE @result VARCHAR(MAX) = '';
        IF @fecha_esperada IS NULL
            SET @result += ' @fecha_esperada,'
        IF @codEstado IS NULL
            SET @result += ' @codEstado,'
        -- Comentarios a la hora de hacer un pedido puede ser null.
        -- Lo mismo pasa con @fecha_entrega.
        IF NOT EXISTS (SELECT codCliente
                        FROM CLIENTES
                        WHERE codCliente = @codCliente)
            SET @result += ' @codCliente,'
        IF @result <> ''
            BEGIN
                -- Se imprimirá @result y se hara return de -1 en caso de que haya algun parametro null o
                -- codCLiente no exista.
                SET @result = 'The following data wasnt inserted correctly: ' + CHAR(10) + @result;
                PRINT @result;
                RETURN -1;
            END

        --Calculamos el proximo codPedido
        DECLARE @codPedido INT;
        SELECT @codPedido = MAX(codPedido) + 1
        FROM PEDIDOS
        BEGIN TRAN

        -- Insertamos el pedido
        INSERT INTO PEDIDOS(codPedido, fecha_esperada, fecha_entrega,
                            codEstado, comentarios, codCliente, fecha_pedido)
        VALUES(@codPedido, @fecha_esperada, @fecha_entrega,
            @codEstado, @comentarios, @codCliente, GETDATE())

        -- Updatemos el pago
        UPDATE PAGOS
        SET codPedido = @codPedido
        WHERE codCliente = @codCliente
        AND codPedido IS NULL 
        -- En caso de que hayan realizado los cambios correctamente, commit.
        COMMIT
    END TRY
    BEGIN CATCH
        ROLLBACK
        -- Mostramos la información del error
        PRINT CONCAT ('CODERROR: ', ERROR_NUMBER(),
                      ', DESCRIPCION: ', ERROR_MESSAGE(),
                      ', LINEA: ', ERROR_LINE())
        RETURN -1;

    END CATCH
END

GO
-- VALIDACIÓN
DECLARE @fecha_esperada DATE, @fecha_entrega DATE, @codEstado CHAR(1), @comentarios VARCHAR(500), @codCliente INT
SET @fecha_esperada = '2023-04-19'
SET @codEstado = 'P'
SET @comentarios = 'Muy buen pedido'
SET @codCliente = 27;

DECLARE @ret INT;
EXEC @ret = crearPedidoActualizaPago @fecha_esperada, @fecha_entrega, 
            @codEstado, @comentarios, @codCliente

IF @ret <> 0
BEGIN
    PRINT('No se ha creado el pedido')
    RETURN
END
PRINT('Se ha creado el pedido')

/* B) Crea una función llamada importePagosCliente que devuelva el importe de los pagos
	de un cliente pasado como parámetro. Llama a la función con la tabla CLIENTES.

   Crea otra función que devuelva los PAGOS cuyo importe sea inferior al importe de 
	los pagos del cliente.

   Crea otra función que devuelva cuánto suma el importe total vendido para un producto.
	Debes comprobarlo en la tabla DETALLE_PEDIDOS (cantidad y precio). */
exec sp_help PAGOS
GO



GO
CREATE OR ALTER FUNCTION importePagosCliente (@codCliente INT)
RETURNS DECIMAL(10,2)
AS
BEGIN 
    RETURN (SELECT ISNULL(SUM(importe_pago), 0)
              FROM PAGOS
             WHERE codCliente = @codCliente)
END

GO
CREATE OR ALTER FUNCTION GetPedidosImporteMenorAPagos(@codCliente INT)
RETURNS TABLE
AS
    RETURN (SELECT *
              FROM PAGOS 
             WHERE importe_pago < dbo.importePagosCliente(@codCLiente))

GO

CREATE OR ALTER FUNCTION GetImporteTotalVendido(@codProducto INT)
RETURNS DECIMAL(9,2)
AS
BEGIN
    RETURN (SELECT ISNULL(SUM(cantidad*precio_unidad), 0)
              FROM DETALLE_PEDIDOS
             WHERE codProducto = @codProducto)

END
GO

SELECT dbo.GetImporteTotalVendido(87)

/* C) Crea un cursor que itere por la tabla EMPLEADOS, muestre su código, nombre y el 
	número de clientes que tienen a su cargo (con doble cursor o con SELECT).

   Crea un cursor que itere por la tabla PRODUCTOS e indique la siguiente información:
	El producto XXX con referencia YYY aparece ZZZ veces en la tabla DETALLE_PEDIDOS. */
USE JARDINERIA
DECLARE @codEmpleado INT
DECLARE @nombre VARCHAR(100)

DECLARE Cur_Empleados CURSOR FOR
SELECT codEmpleado,
       nombre
  FROM EMPLEADOS

OPEN Cur_Empleados

FETCH NEXT FROM Cur_Empleados INTO @codEmpleado, @nombre

WHILE @@FETCH_STATUS = 0
BEGIN
    DECLARE @cantEmpleados INT = 0
    SELECT @cantEmpleados = COUNT(1)
      FROM CLIENTES
     WHERE codEmpl_ventas = @codEmpleado

    PRINT CONCAT('ID: ', @codEmpleado, CHAR(10),
                 'Nombre: ', @nombre, CHAR(10),
                 'Cantidad de Clientes: ', @cantEmpleados, CHAR(10))
    
    FETCH NEXT FROM Cur_Empleados INTO @codEmpleado, @nombre
END

CLOSE Cur_Empleados
DEALLOCATE Cur_Empleados

SELECT COUNT(codCliente)
  FROM CLIENTES
 WHERE codEmpl_ventas = 17

/*
 Crea un cursor que itere por la tabla PRODUCTOS e indique la siguiente información:
	El producto XXX con referencia YYY aparece ZZZ veces en la tabla DETALLE_PEDIDOS. */
EXEC sp_help PRODUCTOS
USE JARDINERIA
GO
DECLARE @nombre VARCHAR(100)
DECLARE @codProducto INT
DECLARE @apariciones INT

DECLARE Cur_Productos CURSOR FOR
SELECT codProducto,
       nombre
  FROM PRODUCTOS

OPEN Cur_Productos

FETCH NEXT FROM Cur_Productos INTO @codProducto, @nombre

WHILE @@FETCH_STATUS = 0
BEGIN
    SELECT @apariciones = ISNULL(COUNT(codProducto), 0)
      FROM DETALLE_PEDIDOS
     WHERE codProducto = @codProducto

     PRINT CONCAT('El producto ', @nombre ,' con referencia ',
                  @codProducto,' aparece ', @apariciones ,
                  ' veces en la tabla DETALLE_PEDIDOS.', CHAR(10))

    FETCH NEXT FROM Cur_Productos INTO @codProducto, @nombre
END

CLOSE Cur_Productos
DEALLOCATE Cur_Productos
/*
D) Crea un trigger que se active cuando se inserte un nuevo cliente y que en caso 
	de no tener un limite_credito > 10000 se impida su inserción.

   Crea un trigger que haga una copia de seguridad de la tabla FORMA_PAGO en la tabla
	HIST_FORMA_PAGO cuando se actualice o borre algún registro de esta tabla.
	La tabla HIST_FORMA_PAGO tendrá además la fecha de operación que corresponderá
	con la fecha en la que se ejecute el trigger. */
USE JARDINERIA
GO
CREATE OR ALTER TRIGGER TX_CLIENTE ON CLIENTES
INSTEAD OF INSERT
AS
BEGIN
    BEGIN TRY
        -- Declaramos una variable @openTran
        DECLARE @openTran BIT = 1
        -- Si no hay transacciones, comenzaremos una y setearemos nuestra variable a 0
        IF @@TRANCOUNT = 0
        BEGIN
            SET @openTran = 0
            BEGIN TRAN
        END
        -- Insertaremos solamente los clientes que tengan un limite_credito > 10000
        INSERT INTO CLIENTES
        SELECT INSERTED.*
        FROM INSERTED
        WHERE limite_credito > 10000;

        IF @openTran = 0
            COMMIT
    END TRY
    BEGIN CATCH
        PRINT CONCAT('ERROR: ', ERROR_NUMBER(), CHAR(10),
                     'LINE: ', ERROR_LINE(), CHAR(10),
                     'PROCEDURE: ', ERROR_PROCEDURE(), CHAR(10),
                     'NUMBER: ', ERROR_NUMBER(), CHAR(10))
        IF @openTran = 0
            ROLLBACK
    END CATCH
END
GO


DECLARE @nuevoCliente INT;
SET @nuevoCliente = ISNULL((SELECT MAX(codCliente)
                              FROM CLIENTES), 0) + 1

INSERT INTO CLIENTES
VALUES (@nuevoCliente, 'Santi', 'Pls', 'Copion', '696969696', null, 'Argentina', null, 'Alicante', null, null, null, 15000),
       (@nuevoCliente + 1, 'Pedro', 'Gómez', 'López', '666666666', null, 'España', null, 'Madrid', null, null, null, 8000),
       (@nuevoCliente + 2, 'María', 'Fernández', 'García', '555555555', null, 'España', null, 'Barcelona', null, null, null, 12000),
       (@nuevoCliente + 3, 'Laura', 'Martínez', 'Rodríguez', '777777777', null, 'España', null, 'Valencia', null, null, null, 9500);

/*
D) Crea un trigger que se active cuando se inserte un nuevo cliente y que en caso 
	de no tener un limite_credito > 10000 se impida su inserción.

   Crea un trigger que haga una copia de seguridad de la tabla FORMA_PAGO en la tabla
	HIST_FORMA_PAGO cuando se actualice o borre algún registro de esta tabla.
	La tabla HIST_FORMA_PAGO tendrá además la fecha de operación que corresponderá
	con la fecha en la que se ejecute el trigger. */
GO 

SELECT *
  INTO HIST_FORMA_PAGO
  FROM FORMA_PAGO
 WHERE 1 = 0

ALTER TABLE HIST_FORMA_PAGO
  ADD fecha_operacion DATE
GO
GO
CREATE OR ALTER TRIGGER TX_FORMA_PAGO ON FORMA_PAGO
AFTER UPDATE, DELETE
AS
BEGIN
    -- Agregamos lo cambiado en al historico
    INSERT INTO HIST_FORMA_PAGO
    SELECT *, GETDATE()
      FROM DELETED
END
GO
