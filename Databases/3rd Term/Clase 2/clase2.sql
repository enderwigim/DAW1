/*
WHILE COND1 OR (COND2 AND COND3)
BEGIN
    -- Codigo
END
*/

/* Simular un for
DECLARE @i INT = 0

WHILE (@i <= 10)
BEGIN

    PRINT @i

    SET @i += 1

    CONTINUE
END
*/

-- Implementar un bucle que cuente desde el 1 al 30 y muestre los numeros
-- divisibles entre 0.
/*
DECLARE @i INT = 1

WHILE @i <= 30
BEGIN
    IF @i%5 = 0
        PRINT @i 
    SET @i += 1
END
*/

-- Implementa un bucle que cuenta desde le 1 al 200 y que muestre 
-- El primer numero divisible por 7 que no sea 7. 
/*
DECLARE @i INT = 1

WHILE @i <= 200
BEGIN
    IF (@i % 7 = 0 AND @i <> 7)
    BEGIN
        PRINT @i
        BREAK
    END
    SET @i += 1
END
*/


-- Uno que muestre los nombres de todos los clientes.
/*
DECLARE @minCodCliente INT = 1
DECLARE @maxCodCliente INT
DECLARE @nombreCliente VARCHAR(50)

-- Asigno inicio y final del bucle
SELECT  @minCodCliente = MIN(codCliente),
        @maxCodCliente = MAX(codCliente)
  FROM CLIENTES

WHILE (@minCodCliente <= @maxCodCliente)
BEGIN
    SET @nombreCliente = NULL

    SELECT @nombreCliente = nombre_cliente
      FROM CLIENTES
     WHERE codCliente = @minCodCliente
    
    IF @nombreCliente IS NOT NULL
        PRINT @nombreCliente

    SET @minCodCliente += 1
END
*/

