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



/*
D) Crea un trigger que se active cuando se inserte un nuevo cliente y que en caso 
	de no tener un limite_credito > 10000 se impida su inserción.

   Crea un trigger que haga una copia de seguridad de la tabla FORMA_PAGO en la tabla
	HIST_FORMA_PAGO cuando se actualice o borre algún registro de esta tabla.
	La tabla HIST_FORMA_PAGO tendrá además la fecha de operación que corresponderá
	con la fecha en la que se ejecute el trigger. */
