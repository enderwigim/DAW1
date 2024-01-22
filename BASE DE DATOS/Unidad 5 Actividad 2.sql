		-----------------------------------------------------
		-- Ejercicio 5.4. Escribe las siguientes consultas
		--					utilizando la BD JARDINERIA
		-----------------------------------------------------

					--------------------------
					--		CONSULTAS	    --
					--------------------------

---------------------------------------
-- A) Consultas sobre una tabla (16) --
---------------------------------------
USE JARDINERIA;
-- 1. Devuelve un listado con el código de oficina y la ciudad donde hay oficinas.
SELECT codOficina, 
       ciudad
  FROM OFICINAS;

-- 2. Devuelve un listado con la ciudad y el teléfono de las oficinas del país España.
SELECT codOficina,
       ciudad,
       telefono
  FROM OFICINAS
 WHERE pais = 'España';

-- 3. Devuelve un listado con el nombre, apellidos y email de los empleados cuyo jefe tiene un código de jefe igual a 7.
SELECT nombre,
       apellido1,
	   apellido2,
	   email
  FROM EMPLEADOS
 WHERE codEmplJefe = 7;

-- 4. Devuelve el nombre del puesto, nombre, apellidos y email del empleado que NO tiene ningún jefe/a
SELECT puesto_cargo,
       nombre,
	   apellido1,
	   apellido2,
	   email
  FROM EMPLEADOS
 WHERE codEmplJefe IS NULL;

-- 5. Devuelve un listado con el nombre, apellidos y puesto de aquellos empleados que no sean representantes de ventas.

SELECT nombre,
       apellido1,
	   apellido2,
	   puesto_cargo
  FROM EMPLEADOS
 WHERE LOWER(puesto_cargo) = 'representante ventas';

-- 6. Devuelve un listado con el nombre de los todos los clientes españoles.
SELECT nombre_cliente
  FROM CLIENTES
 WHERE LOWER(pais) = 'spain';

-- 7. Devuelve un listado con los distintos estados por los que puede pasar un pedido.
SELECT DISTINCT codEstado
  FROM PEDIDOS

-- 8. Devuelve un listado con el código de cliente de aquellos clientes que realizaron algún pago en 2023.
-- Ten en cuenta que deberás eliminar aquellos códigos de cliente que aparezcan repetidos.
SELECT DISTINCT codCliente
  FROM PAGOS
 WHERE YEAR(fechaHora_pago) = 2023;

-- 9. Devuelve un listado con el código de pedido, código de cliente, fecha esperada y fecha de entrega de los pedidos que no han sido entregados a tiempo.
SELECT codPedido,
       codCliente,
	   fecha_esperada,
	   fecha_entrega,
	   DATEDIFF(DAY,fecha_esperada, fecha_entrega) AS dias_diferencia
  FROM PEDIDOS
 WHERE DATEDIFF(DAY,fecha_esperada, fecha_entrega) > 0;

-- 10. Devuelve un listado con el código de pedido, código de cliente, fecha esperada y fecha de entrega de los 
-- pedidos cuya fecha de entrega ha sido al menos dos días antes de la fecha esperada.
-- Utilizando la función DATEADD

SELECT codPedido,
       codCliente,
	   fecha_esperada,
	   fecha_entrega,
	   DATEADD(DAY, -2, fecha_esperada)
  FROM PEDIDOS
 WHERE fecha_entrega <= DATEADD(DAY, -2, fecha_esperada) ;

-- 11. Misma consulta pero utilizando la función DATEDIFF

SELECT codPedido,
       codCliente,
	   fecha_esperada,
	   fecha_entrega,
	   DATEDIFF(DAY,fecha_esperada, fecha_entrega) AS dias_diferencia
  FROM PEDIDOS
 WHERE DATEDIFF(DAY,fecha_esperada, fecha_entrega) <= -2;

-- 12. Devuelve un listado de todos los pedidos que fueron rechazados en 2022
SELECT codPedido, 
       codEstado,
	   fecha_pedido
  FROM PEDIDOS
 WHERE YEAR(fecha_pedido) = 2022;

-- 13. Devuelve un listado de todos los pedidos que han sido entregados en el mes de enero de cualquier año
SELECT codPedido,
       fecha_pedido,
	   fecha_esperada,
	   fecha_entrega,
	   codEstado,
	   comentarios
  FROM PEDIDOS
 WHERE MONTH(fecha_entrega) = 1;

-- 14. Devuelve un listado con todos los pagos que se realizaron en el año 2022 mediante Paypal. Ordena el resultado de mayor a menor
SELECT codCliente, id_transaccion
  FROM PAGOS
  WHERE codFormaPago = 'P' AND YEAR(fechaHora_pago) = 2022;

-- 15. Devuelve un listado con todas las formas de pago que aparecen en la tabla PAGOS. Ten en cuenta que no deben aparecer formas de pago repetidas.
SELECT DISTINCT codFormaPago
  FROM PAGOS;

-- 16. Devuelve un listado con todos los productos que pertenecen a la categoría Ornamentales y que tienen más de 100 unidades en stock.
-- El listado deberá estar ordenado por su precio de venta, mostrando en primer lugar los de mayor precio.
SELECT codProducto, nombre, codCategoria, precio_venta
  FROM PRODUCTOS
 WHERE codCategoria = 'OR'
 ORDER BY precio_venta DESC;

-- 17. Devuelve un listado con todos los clientes que sean de la ciudad de Madrid y cuyo representante de ventas tenga el código de empleado 11 o 30
SELECT *
  FROM CLIENTES
 WHERE ciudad = 'Madrid'
   AND codEmpl_ventas IN (11, 30);

----------------------------------------------------------------
-- B) Consultas de agrupación o de funciones de agregado (18) --
----------------------------------------------------------------

-- 18. ¿Cuántos empleados hay en la compañía?
SELECT COUNT(codEmpleado) AS cantidadEmpleados
  FROM EMPLEADOS;

-- 19. ¿Cuántos clientes tiene cada país?
SELECT COUNT(1) AS cantidadClientes,
       pais
  FROM CLIENTES
  GROUP BY pais;

-- 20. ¿Cuál fue el pago medio de 2022?
SELECT AVG(importe_pago) AS pagoMedio
  FROM PAGOS
 WHERE YEAR(fechaHora_pago) = 2022;

-- 21. ¿Cuántos pedidos hay en cada estado? Ordena el resultado de forma descendente por el número de pedidos.
SELECT codEstado,
       COUNT(1) AS cantidadPedidos
  FROM PEDIDOS
 GROUP BY codEstado;

-- 22. Calcula el precio de venta del producto más caro y más barato en una misma consulta.
SELECT MAX(precio_venta) AS precioMAX,
       MIN(precio_venta) AS precioMIN
  FROM PRODUCTOS;


-- 23. ¿Cuántos clientes tiene la ciudad de Madrid?
SELECT COUNT(1) AS cantidadClientes
  FROM CLIENTES
  WHERE LOWER(ciudad) = 'madrid';

-- 24. ¿Calcula cuántos clientes tiene cada una de las ciudades que empiezan por M?
SELECT ciudad,
       COUNT(1) AS cantidadClientes
  FROM CLIENTES
 WHERE LEFT(ciudad, 1) = 'M'
 GROUP BY ciudad
 ORDER BY cantidadClientes DESC;

-- 25. Devuelve el código de los representantes de ventas y el número de clientes al que atiende cada uno.
SELECT codEmpl_ventas,
       COUNT(codCliente) AS clientesAtentidos
  FROM CLIENTES
 GROUP BY codEmpl_ventas
 ORDER BY clientesAtentidos DESC;


-- 26. Calcula el número de clientes que no tiene asignado representante de ventas.
SELECT COUNT(1)
  FROM CLIENTES
 WHERE codEmpl_ventas IS NULL

-- 27. Calcula el número de productos diferentes que hay en cada uno de los pedidos.
SELECT codPedido,
       COUNT(1) AS cantidadProductos
  FROM DETALLE_PEDIDOS
 GROUP BY codPedido;



-- 28. Calcula la suma de la cantidad total de todos los productos que aparecen en cada uno de los pedidos
SELECT codPedido,
       SUM(cantidad) AS cantidadProductos
  FROM DETALLE_PEDIDOS
 GROUP BY codPedido;

-- 29. Devuelve un listado de los 20 productos más vendidos y el número total de unidades que se han vendido de cada uno.
-- El listado deberá estar ordenado por el número total de unidades vendidas.
SELECT TOP(20)  codProducto,
       SUM(cantidad) AS productosVendidos
  FROM DETALLE_PEDIDOS
 GROUP BY codProducto
 ORDER BY productosVendidos DESC;

-- 30. Obtener el número de empleados por oficina, siempre que el número de empleados sea mayor que 4.
SELECT codOficina,
       COUNT(codEmpleado) AS cantidadEmpleados
  FROM EMPLEADOS
 GROUP BY codOficina
 HAVING COUNT(codEmpleado) > 4;

-- 31. Obtener los clientes que hayan realizado más de dos pagos de mínimo 1000 euros.
-- Mostrar también el número de pagos realizados.

SELECT codCliente,
       MIN(importe_pago) AS minPago,
       COUNT(id_transaccion) AS cantidadTransacciones
  FROM PAGOS
 WHERE importe_pago >= 1000
 GROUP BY codCliente
 HAVING COUNT(id_transaccion) > 2

----------------------------------------------------------------
--				C) Consultas multitabla (10)				  --
----------------------------------------------------------------

-- 32. Obtén los nombres de los productos, la cantidad y el precio para los productos incluidos en los pedidos 3 y 5. Ordénalo por número de pedido y número de producto ascendentemente.
SELECT  ped.codPedido, 
        prod.codProducto,
        prod.nombre, 
        prod.precio_venta,
        detPed.cantidad
  FROM PEDIDOS ped,
       PRODUCTOS prod,
       DETALLE_PEDIDOS detPed
 WHERE ped.codPedido = detPed.codPedido 
   AND detPed.codProducto = prod.codProducto
   AND ped.codPedido IN(3, 5)
 ORDER BY ped.codPedido, prod.codProducto ASC;


-- 33. Obtén un listado con los nombres de los clientes que han realizado algún pago. Deben aparecer los campos nombre cliente, fecha de pago y total ordenado ascendentemente por cliente y fecha.
SELECT cl.nombre_cliente,
       COUNT(pg.id_transaccion) AS cantidadTransacciones
  FROM PAGOS pg,
       CLIENTES cl
  WHERE pg.codCliente = cl.codCliente
  GROUP BY cl.nombre_cliente

SELECT cl.nombre_cliente,
       COUNT(pg.id_transaccion) AS cantidadTransacciones
  FROM PAGOS pg 
 INNER JOIN CLIENTES cl
    ON pg.codCliente = cl.codCliente
 GROUP BY cl.nombre_cliente
-- 34. Obtén un listado con el nombre de cada cliente y el nombre y apellido de su representante de ventas.
SELECT cl.nombre_cliente,
       emp.nombre AS nombreRep,
       emp.apellido1 AS apellido1Rep,
       emp.apellido2 AS apellido2Rep
  FROM CLIENTES cl,
       EMPLEADOS emp
  WHERE cl.codEmpl_ventas = emp.codEmpleado;


-- EL INNER JOIN FUNCIONA EN ESTE CASO SOLO PORQUE CADA CLIENTE TIENE ASOCIADO UN REPRESENTANTE DE VENTAS.
SELECT cl.nombre_cliente,
       emp.nombre AS nombreRep,
       emp.apellido1 AS apellido1Rep,
       emp.apellido2 AS apellido2Rep
  FROM CLIENTES cl
 INNER JOIN EMPLEADOS emp
    ON cl.codEmpl_ventas = emp.codEmpleado; 

-- EL RESULTADO SERIA DISTINTO SI HUBIERA UN CLIENTE SIN UN REPRESENTANTE????????
-- INSERTAREMOS UN CLIENTE PARA LUEGO BORRARLO
/*
INSERT INTO CLIENTES (
  codCliente, 
  nombre_cliente, 
  nombre_contacto,
  apellido_contacto,
  telefono,
  linea_direccion1,
  ciudad)
VALUES (
  39,
  'Pedrito',
  'Test',
  'Testito',
  '613403222',
  'Santi 123',
  'Roma')
*/
-- AL HACER ESTO SE NOTA LA DIFERENCIA. El primer select muestra a todos, al que tiene y al que no
-- El inner join no lo hace. Voy a testear el LEFT ahora.
SELECT cl.nombre_cliente,
       emp.nombre AS nombreRep,
       emp.apellido1 AS apellido1Rep,
       emp.apellido2 AS apellido2Rep
  FROM CLIENTES cl
  LEFT JOIN EMPLEADOS emp
    ON cl.codEmpl_ventas = emp.codEmpleado; 
-- EN ESTE CASO SI FUNCIONA. Ahora voy a borrar el registro.
/*
DELETE FROM CLIENTES
 WHERE codCliente = 39
*/
-- 35. Muestra el nombre de los clientes que hayan realizado pagos junto con el nombre de sus representantes de ventas. Solo deben aparecer una vez.
SELECT DISTINCT cl.nombre_cliente,
       emp.nombre AS nombreRepresentante
  FROM CLIENTES cl,
       EMPLEADOS emp,
       PAGOS pg
 WHERE cl.codEmpl_ventas = emp.codEmpleado 
   AND cl.codCliente = pg.codCliente


-- 36. Devuelve el nombre de los clientes que han hecho pedidos y el nombre de sus representantes junto con la ciudad de la oficina a la que pertenece el representante.
SELECT cl.nombre_cliente,
       emp.nombre AS nombreRepresentante,
       ofi.ciudad AS ciudadOficina,
       ped.codPedido
  FROM PEDIDOS ped,
       EMPLEADOS emp,
       OFICINAS ofi,
       CLIENTES cl  
  WHERE ped.codCliente = cl.codCliente
    AND cl.codEmpl_ventas = emp.codEmpleado
    AND emp.codOficina = ofi.codOficina 

       



SELECT * FROM OFICINAS

-- 37. Lista la dirección de las oficinas que tengan clientes en Fuenlabrada.
SELECT ;

-- 38. Devuelve un listado con el nombre de los empleados junto con el nombre de sus jefes (debes utilizar dos alias para la tabla EMPLEADOS).
SELECT ;

-- 39. Devuelve el nombre de los clientes a los que no se les ha entregado a tiempo un pedido. Si se han retrasado varios pedidos, el cliente solo debe aparecer una vez.
SELECT ;

-- 40. Muestra el nombre de los clientes y el número de pagos que han realizado.
-- Deben aparecer todos, independientemente de si han realizado un pago o no.
SELECT ;

-- 41. Muestra el nombre de los clientes y el número de pedidos que han sido Entregados.
-- Deben aparecer todos, independientemente de si han realizado un pedido o no.
SELECT ;


