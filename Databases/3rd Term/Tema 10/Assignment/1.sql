-- Ejercicio 1
USE TIENDA
/*
SELECT *
  FROM PRODUCTO
EXEC sp_help PRODUCTO
*/
DECLARE @counter INT, @max INT

SELECT @counter = MIN(codigo),
       @max = MAX(codigo)
  FROM PRODUCTO
DECLARE @name VARCHAR(100)

WHILE @counter <= @max
BEGIN

    SELECT @name = nombre
      FROM PRODUCTO
     WHERE codigo = @counter

    PRINT @name
    SET @counter += 1
END

/*
Ejercicio 2
*/

GO
DECLARE @counter INT, @max INT

SELECT @counter = MIN(codigo),
       @max = MAX(codigo)
  FROM PRODUCTO
DECLARE @name VARCHAR(100)
DECLARE @precio DECIMAL(9,2)

WHILE @counter <= @max
BEGIN

    SELECT @name = nombre,
           @precio = precio
      FROM PRODUCTO
     WHERE codigo = @counter

    PRINT CONCAT('El producto ', @name, 'tiene un precio de ', @precio, '€')
    SET @counter += 1
END

/*
Ejercicio 3
*/
GO
USE TIENDA

DECLARE @codFabricante INT, @nombreFabricante VARCHAR(100)
DECLARE Cur_Fabricante CURSOR FOR
 SELECT codigo, nombre
   FROM  FABRICANTE

OPEN Cur_Fabricante

FETCH NEXT FROM Cur_Fabricante INTO @codFabricante, @nombreFabricante

WHILE @@FETCH_STATUS = 0
BEGIN
  -- Preparamos el siguiente Cursor
  DECLARE Cur_PrecioProductos CURSOR FOR
   SELECT precio
     FROM PRODUCTO
    WHERE codigo = @codFabricante

  DECLARE @precio DECIMAL(10,2), @acumulado DECIMAL(10,2)
  SET @acumulado = 0

  OPEN Cur_PrecioProductos
  FETCH NEXT FROM Cur_PrecioProductos INTO @precio
  -- Operamos con el cursor interno
  WHILE @@FETCH_STATUS = 0
  BEGIN
    SET @acumulado = @acumulado + @precio
    FETCH NEXT FROM Cur_PrecioProductos INTO @precio
  END

  CLOSE Cur_PrecioProductos;
  DEALLOCATE Cur_PrecioProductos;

  PRINT CONCAT('Fabricante: ', @nombreFabricante, ' tiene un total de',
  @acumulado, '€ en productos')  

  FETCH NEXT FROM Cur_Fabricante INTO @codFabricante, @nombreFabricante

END

CLOSE Cur_Fabricante;
DEALLOCATE Cur_Fabricante;