-- 1. Lista el nombre de todos los productos que hay en la tabla producto.
SELECT codigo, 
       nombre
  FROM PRODUCTO

-- 2. Lista los nombres y los precios de todos los productos de la tabla producto.
SELECT codigo,
       nombre,
       precio
  FROM PRODUCTO

-- 3. Lista todas las columnas de la tabla producto.
SELECT *
  FROM PRODUCTO

-- 4. Lista los nombres y los precios de todos los productos de la tabla producto, convirtiendo los nombres a may�scula.
SELECT UPPER(nombre),
       precio
  FROM PRODUCTO

-- 5. Lista los nombres y los precios de todos los productos de la tabla producto, convirtiendo los nombres a min�scula.
SELECT LOWER(nombre),
       precio
  FROM PRODUCTO

-- 6. Lista el nombre de todos los fabricantes en una columna, y en otra columna obtenga en may�sculas los dos primeros caracteres del nombre del fabricante.
SELECT nombre,
       LEFT(UPPER(nombre), 2) AS mayusculas
  FROM PRODUCTO

-- Opción 2
SELECT nombre,
       CONCAT(LEFT(UPPER(nombre), 2), RIGHT(nombre, LEN(nombre) - 2))
  FROM PRODUCTO

-- 7. Lista los nombres y los precios de todos los productos de la tabla producto, redondeando el valor del precio al primer decimal.
SELECT nombre,
       ROUND(precio, 1)
  FROM PRODUCTO

-- 8. Lista los nombres y los precios de todos los productos de la tabla producto, truncando el valor del precio para mostrarlo sin ninguna cifra decimal.
SELECT nombre,
       FLOOR(ROUND(precio, 1))
  FROM PRODUCTO

-- 9. Lista los nombres de los fabricantes ordenados de forma ascendente.
SELECT nombre
  FROM FABRICANTE
ORDER BY nombre ASC

-- 10. Lista los nombres de los fabricantes ordenados de forma descendente.
SELECT nombre
  FROM FABRICANTE
ORDER BY nombre DESC

-- 11. Lista los nombres de los productos ordenados en primer lugar por el nombre de forma ascendente y en segundo lugar por el precio de forma descendente.
SELECT nombre
  FROM PRODUCTO
ORDER BY nombre ASC, precio DESC

-- 12. Devuelve una lista con las 5 primeras filas de la tabla fabricante.
SELECT TOP(5) *
  FROM FABRICANTE


-- 13. Lista el nombre de todos los productos del fabricante cuyo c�digo de fabricante es igual a 2.
SELECT nombre,
       codigo_fabricante
  FROM PRODUCTO
 WHERE codigo_fabricante = 2

-- 14. Lista el nombre de los productos que tienen un precio menor o igual a 120�.
SELECT nombre,
       precio
  FROM PRODUCTO
 WHERE precio <= 120

-- 15. Lista el nombre de los productos que tienen un precio mayor o igual a 400�.
SELECT nombre
  FROM PRODUCTO
 WHERE precio >= 400


-- 16. Lista el nombre de los productos que no tienen un precio mayor o igual a 400�.

SELECT nombre
  FROM PRODUCTO
 WHERE precio <= 400


-- 17. Lista todos los productos que tengan un precio entre 80� y 300�. Sin utilizar el operador BETWEEN.

SELECT *
  FROM PRODUCTO
 WHERE precio > 80 
   AND precio < 300 
 ORDER BY precio ASC

-- 18. Lista todos los productos que tengan un precio entre 60� y 200�. Utilizando el operador BETWEEN.

SELECT *
  FROM PRODUCTO
 WHERE precio BETWEEN 60 
   AND 200
 ORDER BY precio ASC

-- 19. Lista todos los productos donde el c�digo de fabricante sea 1, 3 o 5. Sin utilizar el operador IN.
SELECT *
  FROM PRODUCTO
 WHERE codigo_fabricante = 1 
    OR codigo_fabricante = 3 
    OR codigo_fabricante = 5
 ORDER BY codigo_fabricante ASC

-- 20. Lista todos los productos donde el c�digo de fabricante sea 1, 3 o 5. Utilizando el operador IN.
SELECT *
  FROM PRODUCTO
 WHERE codigo_fabricante IN(1, 3, 5)
 ORDER BY codigo_fabricante ASC

-- 21. Lista el nombre y el precio de los productos en c�ntimos (Habr� que multiplicar por 100 el valor del precio).
--		Crea un alias para la columna que contiene el precio que se llame c�ntimos.
SELECT nombre,
       precio,
       FLOOR(ROUND((precio * 100), 1)) AS centimos
  FROM PRODUCTO
 ORDER BY centimos ASC     

-- 22. Lista los nombres de los fabricantes cuyo nombre empiece por la letra S.
SELECT nombre
  FROM FABRICANTE
 WHERE UPPER(LEFT(nombre, 1)) = 'S' 
-- 23. Lista los nombres de los fabricantes cuyo nombre termine por la vocal e.
SELECT nombre
  FROM FABRICANTE
 WHERE UPPER(RIGHT(nombre, 1)) = 'E'

-- 24. Lista los nombres de los fabricantes cuyo nombre contenga el car�cter w.
SELECT nombre
  FROM FABRICANTE
 WHERE LOWER(nombre) LIKE '%w%'

-- 25. Lista los nombres de los fabricantes cuyo nombre sea de 4 caracteres.
SELECT nombre
  FROM FABRICANTE
 WHERE LEN(nombre) = 4

-- 26. Devuelve una lista con el nombre de todos los productos que contienen la cadena Port�til en el nombre.
SELECT nombre
  FROM PRODUCTO
 WHERE LOWER(nombre) LIKE '%portátil%'

-- 27. Devuelve una lista con el nombre de todos los productos que contienen la cadena Monitor en el nombre y tienen un precio inferior a 215 �.
SELECT nombre
  FROM PRODUCTO
 WHERE LOWER(nombre) LIKE '%monitor%'
   AND precio < 215

-- 28. Lista el nombre y el precio de todos los productos que tengan un precio mayor o igual a 180�. Ordene el resultado en primer lugar por el precio (en orden descendente) y en segundo lugar por el nombre (en orden ascendente).
SELECT nombre,
       precio
  FROM PRODUCTO
 WHERE precio >= 180
 ORDER BY precio DESC, nombre ASC