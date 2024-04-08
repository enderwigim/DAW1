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


