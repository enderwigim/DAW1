-------------------------------------------------------------------------
-- Ejercicios Refuerzo 2. Obtén las siguientes consultas con funciones --
-------------------------------------------------------------------------

			-----------------------------------------
			--		   CONSULTAS MULTITABLA	       --
			-----------------------------------------


-- 1. Devuelve una lista con el nombre del producto, precio y nombre de fabricante de todos los productos de la BD.
USE TIENDA
SELECT pr.nombre,
       pr.precio,
	   fr.nombre
  FROM PRODUCTO pr,
       FABRICANTE fr
 WHERE pr.codigo_fabricante = fr.codigo;


-- 2. Devuelve una lista con el nombre del producto, precio y nombre de fabricante de todos los productos de la BD.
--		Ordena el resultado por el nombre del fabricante, por orden alfabético.
SELECT pr.nombre,
       pr.precio,
	   fr.nombre
  FROM PRODUCTO pr,
       FABRICANTE fr
 WHERE pr.codigo_fabricante = fr.codigo
 ORDER BY fr.nombre ASC


-- 3. Devuelve una lista con el identificador del producto, nombre del producto, identificador del fabricante y 
--		nombre del fabricante, de todos los productos de la base de datos.
SELECT pr.codigo, 
	   pr.nombre,
	   fb.codigo, 
	   fb.nombre
  FROM PRODUCTO pr,
       FABRICANTE fb
 WHERE pr.codigo_fabricante = fb.codigo;

-- 4. Devuelve el nombre del producto, su precio y el nombre de su fabricante, del producto más barato.
SELECT TOP(1) pro.nombre,
	   pro.precio,
	   fb.nombre AS nombreFabricante
  FROM PRODUCTO pro,
  	   FABRICANTE fb
  WHERE pro.codigo_fabricante = fb.codigo
  ORDER BY pro.precio ASC; 

-- 5. Devuelve el nombre del producto, su precio y el nombre de su fabricante, del producto más caro.
SELECT pro.nombre,
	   pro.precio,
	   fb.nombre AS nombreFabricante
  FROM PRODUCTO pro,
	   FABRICANTE fb
  WHERE pro.codigo_fabricante = fb.codigo
    AND pro.precio >= ALL (SELECT precio
							 FROM PRODUCTO);

-- 6. Devuelve una lista de todos los productos del fabricante Lenovo.
SELECT pro.codigo, 
       pro.nombre, 
       pro.precio, 
       fb.codigo AS codigoFabricante
  FROM PRODUCTO pro,
	   FABRICANTE fb
 WHERE pro.codigo_fabricante = fb.codigo
   AND LOWER(fb.nombre) = 'lenovo';


-- 7. Devuelve una lista de todos los productos del fabricante Crucial que tengan un precio mayor que 200€.
SELECT pro.codigo,
       pro.nombre,
       pro.precio,
       fb.codigo AS codigoFabricante
  FROM PRODUCTO pro,
       FABRICANTE fb
  WHERE pro.codigo_fabricante = fb.codigo
    AND LOWER(fb.nombre) = 'crucial'
	AND pro.precio > 200;


-- 8. Devuelve un listado con todos los productos de los fabricantes Asus, Hewlett-Packardy Seagate. Sin utilizar el operador IN.
/*SELECT *
  FROM PRODUCTO pro
  JOIN FABRICANTE fb
    ON fb.codigo = pro.codigo_fabricante
  WHERE LOWER(fb.nombre) = 'asus'
	 OR LOWER(fb.nombre) = 'hewlett-packardy'
	 OR LOWER(fb.nombre) = 'seagate'
*/

SELECT *
FROM PRODUCTO
WHERE codigo_fabricante = 1
   OR codigo_fabricante = 3
   OR codigo_fabricante = 5;


-- 9. Devuelve un listado con todos los productos de los fabricantes Asus, Hewlett-Packardy Seagate. Utilizando el operador IN.
SELECT *
  FROM PRODUCTO pro,
       FABRICANTE fb
  WHERE pro.codigo_fabricante = fb.codigo
    AND fb.codigo IN (1, 3, 5)

-- 10. Devuelve un listado con el nombre y el precio de todos los productos de los fabricantes cuyo nombre termine por la vocal e.
SELECT *
  FROM PRODUCTO pro,
       FABRICANTE fb
 WHERE fb.codigo = pro.codigo_fabricante
   AND fb.nombre LIKE '%e'


-- 11. Devuelve un listado con el nombre y el precio de todos los productos cuyo nombre de fabricante contenga el carácter w en su nombre.
SELECT pro.nombre,
       pro.precio
  FROM PRODUCTO pro,
       FABRICANTE fb
 WHERE fb.codigo = pro.codigo_fabricante
   AND fb.nombre LIKE '%w%'

-- 12. Devuelve un listado con el nombre de producto, precio y nombre de fabricante, de todos los productos
--		que tengan un precio mayor o igual a 180€. Ordene el resultado en primer lugar por el precio (en orden
--		descendente) y en segundo lugar por el nombre (en orden ascendente)
SELECT *
  FROM PRODUCTO pro,
       FABRICANTE fb
 WHERE fb.codigo = pro.codigo_fabricante
   AND pro.precio >= 180
 ORDER BY pro.precio DESC, pro.nombre DESC
-- 13. Devuelve un listado con el identificador y el nombre de fabricante, solamente de aquellos fabricantes que tienen productos asociados en la BD
SELECT *
  FROM FABRICANTE
 WHERE codigo IN (SELECT codigo_fabricante
                    FROM PRODUCTO)

								-----------------------------------
								-- Uso de LEFT JOIN / RIGHT JOIN --
								-----------------------------------

-- 14. Devuelve un listado de todos los fabricantes que existen en la base de datos, junto con los productos que
--		tiene cada uno de ellos. El listado deberá mostrar también aquellos fabricantes que no tienen productos asociados.
SELECT fb.codigo AS CodFabricante,
       fb.nombre,
       COUNT(pro.codigo) AS cantidadElementos
  FROM FABRICANTE fb
  LEFT JOIN PRODUCTO pro
    ON pro.codigo_fabricante = fb.codigo
  GROUP BY fb.codigo, fb.nombre


SELECT *
  FROM FABRICANTE fb
  LEFT JOIN PRODUCTO pro
    ON pro.codigo_fabricante = fb.codigo


-- 15. Devuelve un listado donde sólo aparezcan aquellos fabricantes que no tienen ningún producto asociado.
SELECT fb.codigo AS CodFabricante,
       fb.nombre,
       COUNT(pro.codigo) AS cantidadElementos
  FROM FABRICANTE fb
  LEFT JOIN PRODUCTO pro
    ON pro.codigo_fabricante = fb.codigo
  GROUP BY fb.codigo, fb.nombre
  HAVING COUNT(pro.codigo) = 0;


-- 16. ¿Pueden existir productos que no estén relacionados con un fabricante? Justifica tu respuesta.
-- No, la tabla codigo_fabricante es NOT NULL.
