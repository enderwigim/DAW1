USE JARDINERIA;
-- Variables
-- Locales @ y Globales @@

--Mirar las tablas
--EXEC sp_tables
-- Mirar los campos de una tabla
--EXEC sp_columns_TABLA


-- Declarar Variables
/*
DECLARE @codCategoria CHAR(2) = 'FR'
DECLARE @nombre VARCHAR(70) = 'Pera'

SELECT *
  FROM PRODUCTOS
 WHERE codCategoria = @codCategoria;
*/
-- Declarar variable con una consulta.

DECLARE @precioMin DECIMAL(9,2);
DECLARE @precioMax DECIMAL(9,2);

SET @precioMin = (SELECT TOP(1) precio_venta
                    FROM PRODUCTOS
                   ORDER BY precio_venta ASC)

SELECT @precioMin = MIN(precio_venta),
       @precioMax = MAX(precio_venta)
  FROM PRODUCTOS;

-- Practicar
-- Crear una variable "codCategoria" que devuelva el nombre
-- de la categoria que tenga mas products.
USE JARDINERIA
EXEC sp_columns CATEGORIA_PRODUCTOS

DECLARE @codCategoria CHAR(2);
DECLARE @nombreCategoria VARCHAR(50);


SELECT TOP(1) @codCategoria = cat.codCategoria,
       @nombreCategoria = cat.nombre
  FROM PRODUCTOS pro,
       CATEGORIA_PRODUCTOS cat
 WHERE pro.codCategoria = cat.codCategoria
 GROUP BY cat.codCategoria, cat.nombre
 ORDER BY COUNT(codProducto) DESC

PRINT CONCAT('La categoria con mas productos es: ', @codCategoria)
PRINT CONCAT('La categoria con mas productos es: ', @nombreCategoria)

