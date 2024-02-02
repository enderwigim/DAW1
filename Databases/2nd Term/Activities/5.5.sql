		-----------------------------------------------------
		-- Ejercicio 5.5. Escribe las siguientes consultas
		--					utilizando la BD JARDINERIA
		-----------------------------------------------------

					--------------------------
					--		CONSULTAS	    --
					--------------------------

-----------------------------------
-- A) Consultas de conjuntos (4) --
-----------------------------------

-- 1. Devuelve los códigos de los clientes que realizaron pedidos en 2022 y los clientes que realizaron pagos por transferencia. Utiliza la unión.

SELECT codCliente
  FROM PEDIDOS
 WHERE YEAR(fecha_pedido) = '2022'
 UNION
SELECT codCliente
  FROM PAGOS
 WHERE codFormaPago = 'T';


-- 2. Devuelve los códigos de los clientes que realizaron pedidos en 2022 y que también realizaron algún pago por transferencia. Utiliza la intersección.
SELECT codCliente
  FROM PEDIDOS
 WHERE YEAR(fecha_pedido) = '2022'
INTERSECT
SELECT codCliente
  FROM PAGOS
 WHERE codFormaPago = 'T';

-- 3. Devuelve los códigos de los clientes que realizaron pedidos en 2022 PERO QUE NO los clientes que realizaron pagos por transferencia. Utiliza la diferencia.
SELECT codCliente
  FROM PEDIDOS
 WHERE YEAR(fecha_pedido) = '2022'
EXCEPT
SELECT codCliente
  FROM PAGOS
 WHERE codFormaPago = 'T';

-- 4. Propón el enunciado de una consulta de conjuntos y escribe la consulta SQL.
SELECT ;


----------------------------------
--    B) Subconsultas (20)      --
----------------------------------
-- Con operadores básicos de comparación

-- 1. Devuelve el nombre del cliente con mayor límite de crédito.
SELECT nombre_cliente
  FROM CLIENTES
 WHERE limite_credito = (SELECT MAX(limite_credito)
                           FROM CLIENTES);

-- 2. Devuelve el nombre del producto que tenga el precio de venta más caro.
SELECT nombre
  FROM PRODUCTOS
 WHERE precio_venta = (SELECT MAX(precio_venta)
                         FROM PRODUCTOS);

-- 3. Devuelve el producto que más unidades tiene en stock. Si salen varios, quédate solo con uno.
SELECT TOP(1) *
  FROM PRODUCTOS
 WHERE cantidad_en_stock = (SELECT MAX(cantidad_en_stock)
                              FROM PRODUCTOS);

-- 4. Devuelve el producto que menos unidades tiene en stock.
SELECT *
  FROM PRODUCTOS
 WHERE cantidad_en_stock = (SELECT MIN(cantidad_en_stock)
                              FROM PRODUCTOS);

-- 5. Devuelve el nombre, los apellidos y el email de los empleados que están a cargo de Alberto Soria.
SELECT *
  FROM EMPLEADOS
 WHERE codEmplJefe = (SELECT codEmpleado
                        FROM EMPLEADOS
                       WHERE LOWER(nombre) = 'alberto'
                         AND LOWER(apellido1) = 'soria');


-- 6. Propón el enunciado de una consulta de conjuntos y escribe la consulta SQL (puede ser de cualquier tipo, con IN, NOT IN, ALL, ANY, etc).
SELECT ;


--------------------------------------------------------------------
--  Subconsultas con ALL y ANY  --
--  IMPORTANTE: NO UTILIZAR MAX o MIN en las subconsultas
--------------------------------------------------------------------

-- 1. Devuelve el nombre del cliente con mayor límite de crédito.
SELECT nombre_cliente
  FROM CLIENTES
 WHERE limite_credito >= ALL (SELECT limite_credito
                                FROM CLIENTES);

-- 2. Devuelve el nombre del producto que tenga el precio de venta más caro.
SELECT nombre
  FROM PRODUCTOS
 WHERE precio_venta >= ALL (SELECT precio_venta
                              FROM PRODUCTOS);

-- 3. Devuelve el producto que menos unidades tiene en stock.
SELECT *
  FROM PRODUCTOS
 WHERE cantidad_en_stock <= ALL (SELECT cantidad_en_stock
                              FROM PRODUCTOS);


----------------------------------
-- Subconsultas con IN y NOT IN --
----------------------------------

-- 1. Devuelve un listado que muestre solamente los clientes que no han realizado ningún pago.
SELECT *
  FROM CLIENTES cl 
  WHERE cl.codCliente NOT IN (SELECT pg.codCliente
                                FROM PAGOS pg);


-- 2. Devuelve un listado que muestre solamente los clientes que han realizado algún pago.
SELECT *
  FROM CLIENTES cl 
  WHERE cl.codCliente IN (SELECT pg.codCliente
                                FROM PAGOS pg);

-- 3. Devuelve un listado de los productos que nunca han aparecido en un pedido.
SELECT *
  FROM PRODUCTOS
  WHERE codProducto NOT IN (SELECT codProducto
                              FROM DETALLE_PEDIDOS);


-- 4. Devuelve el nombre, apellidos, puesto y teléfono de la oficina de aquellos empleados que no sean representante de ventas de ningún cliente.
SELECT emp.codEmpleado, 
       emp.nombre, 
       emp.apellido1,
       emp.apellido2,
       emp.puesto_cargo,
       ofi.telefono
  FROM EMPLEADOS emp,
       OFICINAS ofi
  WHERE emp.codOficina = ofi.codOficina
    AND codEmpleado NOT IN (SELECT cl.codEmpl_ventas
                              FROM CLIENTES cl)



-- 5. Devuelve las oficinas donde trabajan alguno de los empleados.
SELECT ;
				   
-- 6. Devuelve un listado con los clientes que han realizado algún pedido pero no que hayan realizado ningún pago.
SELECT codCliente
 FROM CLIENTES 
 WHERE codCliente NOT IN (SELECT codCliente
                            FROM PAGOS)
   AND codCliente IN (SELECT codCliente
                        FROM PEDIDOS);

SELECT codCliente
 FROM CLIENTES 
 WHERE codCliente NOT IN (SELECT codCliente
                            FROM PAGOS)

SELECT codCliente
 FROM CLIENTES 
 WHERE codCliente IN (SELECT codCliente
                        FROM PEDIDOS);
------------------------------------------
-- Subconsultas con EXISTS y NOT EXISTS --
------------------------------------------

-- 1. Devuelve un listado que muestre solamente los clientes que no han realizado ningún pago.
SELECT ;

-- 2. Devuelve un listado que muestre solamente los clientes que han realizado algún pago.
SELECT ;

-- 3. Devuelve un listado de los productos que nunca han aparecido en un pedido.
SELECT ;

-- 4. Devuelve un listado de los productos que han aparecido en un pedido alguna vez.
SELECT ;


---------------------------
--		  Vistas		 --
---------------------------

-- 1. Crea una vista que devuelva los códigos de los clientes que realizaron pedidos en 2009 y los clientes que realizaron pagos por transferencia. Utiliza la unión.


-- 2. Escribe el código SQL para realizar una consulta a dicha vista


-- 3. Escribe el código SQL para eliminar dicha vista.

