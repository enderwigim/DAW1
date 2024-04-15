USE TIENDA

--Modificar fabricante
GO
CREATE OR ALTER PROCEDURE modifFabricante(@codFabricante INT,
                                          @nombre VARCHAR(50))
AS
BEGIN

    DECLARE @salida VARCHAR(200) = ''
    IF @codFabricante IS NULL
    BEGIN
        SET @salida = @salida + 'codFabricante, '
    END

    IF @nombre IS NULL
    BEGIN
        SET @salida = @salida + 'nombre,'
        
    END

    IF @salida <> ''
    BEGIN
        SET @salida = 'Falta/n el/los parametro/s: ' + @salida
        PRINT @salida
        RETURN -1
    END

    UPDATE FABRICANTE
       SET nombre = @nombre
     WHERE codigo = @codFabricante

    IF @@ROWCOUNT = 1
    BEGIN
        PRINT 'Se ha actualizado el FABRICANTE correctamente'  
    END
    ELSE
    BEGIN
        PRINT 'No se ha actualizado ninguna fila'
        RETURN -2
    END
END
-------------------------------------------------------------------
GO
DECLARE @codFabricante INT = 999
DECLARE @nombre VARCHAR(100) = 'Asus'
DECLARE @ret INT

EXEC @ret = modifFabricante @codFabricante,
                            @nombre

IF @ret <> 0
   RETURN

PRINT 'Procedimiento finalizado correctamente';





GO
CREATE OR ALTER PROCEDURE BorrarFabricante(@codFabricante INT)
AS
BEGIN

    DECLARE @salida VARCHAR(200) = ''
    IF @codFabricante IS NULL
    BEGIN
        SET @salida = @salida + 'codFabricante, '
    END


    IF @salida <> ''
    BEGIN
        SET @salida = 'Falta/n el/los parametro/s: ' + @salida
        PRINT @salida
        RETURN -1
    END

    DELETE FROM FABRICANTE
     WHERE codigo = @codFabricante 

    IF @@ROWCOUNT = 1
    BEGIN
        PRINT 'Se ha borrado el FABRICANTE correctamente'  
    END
    ELSE
    BEGIN
        PRINT 'No se ha borrado ninguna fila'
        RETURN -2
    END
END
-------------------------------------------------------------------
GO
DECLARE @codFabricante INT = 1
DECLARE @ret INT

EXEC @ret = BorrarFabricante @codFabricante

IF @ret <> 0
   RETURN

PRINT 'Procedimiento finalizado correctamente';

GO
CREATE OR ALTER PROCEDURE devolverFabricante(@codFabricante INT,
                                             @nombre VARCHAR(100) OUTPUT)
AS
BEGIN
    BEGIN TRY
        -- Validacion
        IF @codFabricante IS NULL
        BEGIN
            PRINT 'El codigo fabricante es nulo'
            RETURN -1
        END

        SELECT @nombre = nombre
        FROM FABRICANTE
        WHERE codigo = @codFabricante

        IF @nombre IS NULL
        BEGIN
            PRINT 'El fabricante no existe'
            RETURN -2
        END
    END TRY
    BEGIN CATCH
        PRINT 'ERROR'
    END CATCH
END
-------------------------------------------------------------------
GO
DECLARE @codFabricante INT = 1003
DECLARE @nombreFabricante VARCHAR(100)
DECLARE @ret INT

EXEC @ret = devolverFabricante @codFabricante,
                               @nombreFabricante OUTPUT

IF @ret <> 0
   RETURN

PRINT @nombreFabricante;