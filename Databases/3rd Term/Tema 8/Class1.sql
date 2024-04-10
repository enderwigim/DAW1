USE JARDINERIA;
-- Create @ret


GO
-- How to create a procedure
CREATE OR ALTER PROCEDURE saludo
AS
BEGIN
    PRINT 'Hello world!'
    RETURN 0
END

----------------------------------------------------------------
EXEC saludo

GO
-- How to add parameters
CREATE OR ALTER PROCEDURE dimeNumero (@num INT)
AS
BEGIN
    PRINT CONCAT('El numero es: ', @num)
    RETURN 0
END

-----------------------------------------------------------------
/*
DECLARE @numero INT = 5;
DECLARE @ret INT
EXEC @ret = dimeNumero @numero

IF @ret <> 0
    RETURN


PRINT 'Llamo al siguiente Procedure'
*/


GO
-- How to add multiple parameters by default YOU SHOULDN'T USE IT!!!!!!!
CREATE OR ALTER PROCEDURE dimeNumeroSaluda (@num INT = 9,
                                            @saludo VARCHAR(50) = 'Soy Sergio')
AS
BEGIN
    PRINT CONCAT('El numero es: ', @num, CHAR(10), @saludo)
    RETURN -1
END

-----------------------------------------------------------------
DECLARE @numero INT = 5;
DECLARE @saludito VARCHAR(50) = 'Mi nombre es Abel, y soy Dios';
DECLARE @ret INT
EXEC @ret = dimeNumeroSaluda @numero, @saludito

IF @ret <> -1
    RETURN


PRINT 'Llamo al siguiente Procedure'


-- With OUTPUT
GO
CREATE OR ALTER PROCEDURE multiplica (@numero1 INT,
                                      @numero2 INT,
                                      @resultado INT OUTPUT)
AS
BEGIN
    SET @resultado = @numero1 * @numero2
END

-----------------------------------------------------------------
DECLARE @num1 INT = 4, @num2 INT = 2, @result INT
DECLARE @ret INT
EXEC @ret = multiplica @num1, @num2, @result OUTPUT

PRINT @result
IF @ret <> 0
    RETURN 

PRINT 'Llamo al siguiente Procedure'




-- Procedimiento que devuelve el nombre del cliente que se le
-- pasa como parametro
GO
CREATE OR ALTER PROCEDURE printNombreCli (@codCliente INT,
                                          @nombreCli VARCHAR(50) OUTPUT)
AS
BEGIN
    

    -- Obtengo el nombre del cliente
    SELECT @nombreCli = nombre_cliente
      FROM CLIENTES
     WHERE codCliente = @codCliente
    /*
    IF @nombreCli IS NOT NULL
        PRINT CONCAT('El nombre del cliente es: ', @nombreCli)
    ELSE 
        BEGIN
            PRINT CONCAT('El cliente ', @codCliente, ' no existe.')
            RETURN -1
        END
    */
    IF @nombreCli IS NULL
    BEGIN
        PRINT CONCAT('El cliente ', @codCliente, ' no existe.')
        RETURN -1
    END
END

-----------------------------------------------------------
DECLARE @ret INT
declare @nomCli VARCHAR(50)
DECLARE @codCli INT = 2


EXEC @ret = printNombreCli @codCli, @nomCli OUTPUT
IF @ret <> 0
    RETURN

PRINT CONCAT('El nombre del cliente es: ', @nomCli)
PRINT 'EXEC siguiente procedure...'

GO
USE TIENDA
GO
-- Procedimiento que cree un nuevo fabricante
CREATE OR ALTER PROCEDURE crearFabricante (@nombreFabricante varchar(100),
                                           @codFabricante int OUTPUT)
AS
BEGIN

    BEGIN TRY
        -- Validacion
        IF @nombreFabricante IS NULL
        BEGIN
            PRINT 'El parametro nombre es obligatorio'
            RETURN -1
        END

        
        INSERT INTO FABRICANTE(nombre)
        VALUES(@nombreFabricante)
        
        SET @codFabricante = SCOPE_IDENTITY()
        
    END TRY
    BEGIN CATCH
        PRINT CONCAT('ERROR=', ERROR_NUMBER(),
                     ' LINEA=', ERROR_LINE(),
                     ' DESC=', ERROR_MESSAGE()
                     )
    END CATCH
END
GO
----------------------------------------------------------------------------
DECLARE @nombre VARCHAR(100) = 'Apple';
DECLARE @codFabricante INT;
DECLARE @ret INT

EXEC @ret = crearFabricante @nombre,
                            @codFabricante OUTPUT   

IF @ret <> 0
    RETURN

PRINT CONCAT('El nuevo fabricante es el: ', @codFabricante)
GO
-- Procedimineto que reciba un codigo de fabricante y devuelva su nombre
CREATE OR ALTER PROCEDURE GetName(@codFabricante INT, 
                                  @nombreFabricante VARCHAR(100) OUTPUT)
AS
BEGIN 
    SELECT @nombreFabricante = nombre
      FROM FABRICANTE
     WHERE codigo = @codFabricante

    IF @nombreFabricante IS NULL
        PRINT('El fabricante no existe')
        RETURN -1
END


----------------------------------------------------------------------------
GO
DECLARE @ret INT;
DECLARE @codFabricante INT = 1002;
DECLARE @nombreFabricante VARCHAR(100);

EXEC @ret = GetName @codFabricante, 
                    @nombreFabricante OUTPUT

IF @ret <> 0
    RETURN

PRINT CONCAT('El fabricante es ', @nombreFabricante)
-- Procedimiento que modifique el nombre del fabricante a partir de su codigo

-- Procedimiento que elimine un fabircante a partir de su codigo.