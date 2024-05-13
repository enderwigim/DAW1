USE JARDINERIA

DECLARE @contador INT = 1
DECLARE @max INT = (SELECT COUNT(1)
                      FROM OFICINAS) 

DECLARE @codOficina CHAR(6)

WHILE (@contador <= @max)
BEGIN
    IF @contador > 1
    BEGIN
        SELECT TOP(1) @codOficina = codOficina
          FROM OFICINAS
         WHERE codOficina > @codOficina
         ORDER BY codOficina ASC
        
    END
    ELSE 
    BEGIN
        SELECT TOP(1) @codOficina = codOficina
          FROM OFICINAS
         ORDER BY codOficina ASC
    END
        

    PRINT @codOficina
    SET @contador += 1
END
