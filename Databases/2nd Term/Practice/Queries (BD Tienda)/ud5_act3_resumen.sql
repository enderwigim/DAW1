-------------------------------------------------------------------------
-- Ejercicios Refuerzo 3. Obtén las siguientes consultas con funciones --
-------------------------------------------------------------------------

			-----------------------------------------
			--		   CONSULTAS RESUMEN		   --
			-----------------------------------------
			--     GROUP BY / HAVING			   --
			--	   COUNT, MIN, MAX, AVG, SUM	   --
			-----------------------------------------

-- 1. Calcula el número total de productos que hay en la tabla productos.

SELECT COUNT(1) AS cantidadTotal
  FROM PRODUCTO

-- 2. Calcula el número total de fabricantes que hay en la tabla fabricante.
SELECT COUNT(1) AS cantidadFabricantes
  FROM FABRICANTE

-- 3. Calcula el número de valores distintos de identificador de fabricante aparecen en la tabla productos.
SELECT codigo_fabricante,
	   COUNT(1) AS cantidadPorFabricante
  FROM PRODUCTO
  GROUP BY codigo_fabricante

-- 4. Calcula la media del precio de todos los productos.
SELECT AVG(precio) AS mediaPrecio
  FROM PRODUCTO

-- 5. Calcula el precio más barato de todos los productos.
SELECT MIN(precio) AS masBarato
  FROM PRODUCTO

-- 6. Calcula el precio más caro de todos los productos.
SELECT MAX(precio) AS masBarato
  FROM PRODUCTO

-- 7. Lista el nombre y el precio del producto más barato.
SELECT nombre,
	   precio
  FROM PRODUCTO
  WHERE precio = (SELECT MIN(precio)
  					FROM PRODUCTO)
-- 8. Lista el nombre y el precio del producto más caro.
SELECT nombre,
	   precio
  FROM PRODUCTO
  WHERE precio = (SELECT MAX(precio)
  					FROM PRODUCTO)

-- 9. Calcula la suma de los precios de todos los productos.
SELECT SUM(precio) AS SumaPrecios
  FROM PRODUCTO;

-- 10. Calcula el número de productos que tiene el fabricante Asus.
SELECT COUNT(1) AS CantidadProductosAsus
  FROM PRODUCTO pro,
       FABRICANTE fb
  WHERE fb.codigo = pro.codigo_fabricante
    AND fb.nombre = 'Asus'
  GROUP BY fb.codigo

-- 11. Calcula la media del precio de todos los productos del fabricante Asus.
SELECT AVG(pro.precio) AS mediaPrecio
  FROM PRODUCTO pro,
       FABRICANTE fb
  WHERE fb.codigo = pro.codigo_fabricante
    AND fb.nombre = 'Asus'
  GROUP BY fb.codigo

-- 12. Calcula el precio más barato de todos los productos del fabricante Asus.
SELECT MIN(pro.precio) AS precioMin
  FROM PRODUCTO pro,
       FABRICANTE fb
  WHERE fb.codigo = pro.codigo_fabricante
    AND fb.nombre = 'Asus'
  GROUP BY fb.codigo


-- 13. Calcula el precio más caro de todos los productos del fabricante Asus.
SELECT MAX(pro.precio) AS precioMax
  FROM PRODUCTO pro,
       FABRICANTE fb
  WHERE fb.codigo = pro.codigo_fabricante
    AND fb.nombre = 'Asus'
  GROUP BY fb.codigo


-- 14. Calcula la suma de todos los productos del fabricante Asus.
SELECT SUM(pro.precio) AS precioSuma
  FROM PRODUCTO pro,
       FABRICANTE fb
  WHERE fb.codigo = pro.codigo_fabricante
    AND fb.nombre = 'Asus'
  GROUP BY fb.codigo

-- 15. Muestra el precio máximo, precio mínimo, precio medio y el número total de productos que tiene el fabricante Crucial.
SELECT MAX(pro.precio) AS MAX,
	   MIN(pro.precio) AS MIN,
	   AVG(pro.precio) AS AVG,
	   COUNT(1) AS cantidad
  FROM PRODUCTO pro,
       FABRICANTE fb
 WHERE fb.codigo = pro.codigo_fabricante
   AND fb.nombre = 'Crucial'

-- 16. Muestra el número total de productos que tiene cada uno de los fabricantes. El listado también debe
--		incluir los fabricantes que no tienen ningún producto. El resultado mostrará dos columnas, una con el
--		nombre del fabricante y otra con el número de productos que tiene. Ordene el resultado descendentemente por el número de productos.
SELECT fb.nombre,
       COUNT(1) AS cantidadProductos
  FROM FABRICANTE fb
  LEFT JOIN PRODUCTO pro
    ON fb.codigo = pro.codigo_fabricante
  GROUP BY fb.codigo, fb.nombre




-- 17. Muestra el precio máximo, precio mínimo y precio medio de los productos de cada uno de los fabricantes.
--		El resultado mostrará el nombre del fabricante junto con los datos que se solicitan.
SELECT fb.nombre,
       MAX(precio) AS Maximo,
	   MIN(precio) AS Minimo,
	   AVG(precio) AS Media
  FROM FABRICANTE fb
  LEFT JOIN PRODUCTO pro
    ON fb.codigo = pro.codigo_fabricante
  GROUP BY fb.codigo, fb.nombre



-- 18. Muestra el precio máximo, precio mínimo, precio medio y el número total de productos de los fabricantes
--		que tienen un precio medio superior a 200€. No es necesario mostrar el nombre del fabricante, con el
--		identificador del fabricante es suficiente.
SELECT fb.codigo,
       MAX(precio) AS Maximo,
	   MIN(precio) AS Minimo,
	   AVG(precio) AS Media,
	   COUNT(1) AS cantidadProductos
  FROM FABRICANTE fb
  LEFT JOIN PRODUCTO pro
    ON fb.codigo = pro.codigo_fabricante
  GROUP BY fb.codigo, fb.nombre
  HAVING AVG(precio) > 200

-- 19. Muestra el nombre de cada fabricante, junto con el precio máximo, precio mínimo, precio medio y el
--		número total de productos de los fabricantes que tienen un precio medio superior a 200€. Es necesario
--		mostrar el nombre del fabricante
SELECT fb.nombre,
       MAX(precio) AS Maximo,
	   MIN(precio) AS Minimo,
	   AVG(precio) AS Media,
	   COUNT(1) AS cantidadProductos
  FROM FABRICANTE fb
  LEFT JOIN PRODUCTO pro
    ON fb.codigo = pro.codigo_fabricante
  GROUP BY fb.codigo, fb.nombre
  HAVING AVG(precio) > 200



-- 20. Calcula el número de productos que tienen un precio mayor o igual a 180€.
SELECT COUNT(1) AS productosCaros
  FROM PRODUCTO
 WHERE precio >= 180

-- 21. Calcula el número de productos que tiene cada fabricante con un precio mayor o igual a 180€.
SELECT fb.nombre, 
	   COUNT(1) AS productosCaros
  FROM PRODUCTO pro,
       FABRICANTE fb
  WHERE pro.codigo_fabricante = fb.codigo
    AND precio >= 180
  GROUP BY fb.nombre


-- 22. Lista el precio medio los productos de cada fabricante, mostrando solamente el identificador del fabricante.
SELECT codigo_fabricante,
	   AVG(precio)
  FROM PRODUCTO
 GROUP BY codigo_fabricante

-- 23. Lista el precio medio los productos de cada fabricante, mostrando solamente el nombre del fabricante.
SELECT fb.nombre,
	   AVG(pro.precio) AS precioMedio
  FROM PRODUCTO pro,
       FABRICANTE fb
 WHERE pro.codigo_fabricante = fb.codigo
 GROUP BY fb.nombre

-- 24. Lista los nombres de los fabricantes cuyos productos tienen un precio medio mayor o igual a 150€.
SELECT fb.nombre,
	   AVG(pro.precio) AS precioMedio
  FROM PRODUCTO pro,
       FABRICANTE fb
 WHERE pro.codigo_fabricante = fb.codigo
 GROUP BY fb.nombre
 HAVING AVG(pro.precio) >= 150


-- 25. Devuelve un listado con los nombres de los fabricantes que tienen 2 o más productos.
SELECT fb.nombre,
       COUNT(1) as cantidadProductos
  FROM PRODUCTO pro,
	   FABRICANTE fb
 WHERE pro.codigo_fabricante = fb.codigo
 GROUP BY fb.nombre
HAVING COUNT(1) >= 2; 

-- 26. Devuelve un listado con los nombres de los fabricantes y el número de productos que tiene cada uno con
--		un precio superior o igual a 220 €. No es necesario mostrar el nombre de los fabricantes que no tienen
--		productos que cumplan la condición

-- Resultado esperado:
-- -------------------
--	nombre   | total
-- -------------------
--  Lenovo   |   2
--  Asus     |   1
--  Crucial  |   1
-- -------------------
--
SELECT fb.nombre,
       COUNT(1) as cantidadProductos
  FROM PRODUCTO pro,
	   FABRICANTE fb
 WHERE pro.codigo_fabricante = fb.codigo
   AND pro.precio >= 220
 GROUP BY fb.nombre
 ORDER BY COUNT(1) DESC

-- 27. Devuelve un listado con los nombres de los fabricantes y el número de productos que tiene cada uno con
--		un precio superior o igual a 220 €. El listado debe mostrar el nombre de todos los fabricantes, es decir, si
--		hay algún fabricante que no tiene productos con un precio superior o igual a 220€ deberá aparecer en el
--		listado con un valor igual a 0 en el número de productos

-- Resultado esperado:
-- ----------------------------
--	nombre				| total
-- ----------------------------
--  Lenovo				|  2
--  Crucial				|  1
--  Asus				|  1
--  Huawei				|  0
--  Samsung				|  0
--  Gigabyte			|  0
--  Hewlett-Packard		|  0
--  Xiaomi				|  0
--  Seagate				|  0
SELECT fb.nombre,
       COUNT(pro.precio) as cantidadProductos
  FROM FABRICANTE fb
  LEFT JOIN PRODUCTO pro
    ON pro.codigo_fabricante = fb.codigo
   AND pro.precio >= 220
 GROUP BY fb.nombre
 ORDER BY cantidadProductos DESC


-- 28. Devuelve un listado con los nombres de los fabricantes donde la suma del precio de todos sus productos sea superior a 1000 €
SELECT fb.nombre,
       SUM(pro.precio)
  FROM PRODUCTO pro,
       FABRICANTE fb
 WHERE pro.codigo_fabricante = fb.codigo
  GROUP BY fb.nombre
  HAVING SUM(pro.precio) > 1000

-- 29. Devuelve un listado con el nombre del producto más caro que tiene cada fabricante. El resultado debe
--		tener tres columnas: nombre del producto, precio y nombre del fabricante. El resultado tiene que estar
--		ordenado alfabéticamente de menor a mayor por el nombre del fabricante
SELECT pro.nombre,
	   pro.precio,
	   fb.nombre AS nombreFabricante
  FROM PRODUCTO pro,
       FABRICANTE fb
 WHERE pro.codigo_fabricante = fb.codigo
   AND pro.precio IN (SELECT MAX(precio)
                        FROM PRODUCTO
			           GROUP BY codigo_fabricante)
 ORDER BY fb.nombre ASC

