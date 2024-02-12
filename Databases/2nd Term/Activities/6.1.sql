USE JARDINERIA

---------------------------
-- Actividad. Jardinería --
---------------------------

-- 1. Inserta una nueva oficina en Alicante.
INSERT INTO OFICINAS (codOficina, ciudad, pais,
                      codPostal, telefono, linea_direccion1,
                      linea_direccion2)
VALUES ('ALC-ES', 'Alicante', 'España',
        '03007', '+34 93 3561182', 'C. Beato Francisco Castelló Aleu 23',
        '3B')

-- 2. Inserta un nuevo empleado para la oficina de Alicante que sea representante de ventas.
INSERT INTO EMPLEADOS (codEmpleado, nombre, apellido1, 
                       apellido2, tlf_extension_ofi, email,
                       puesto_cargo, salario, codOficina, 
                       codEmplJefe)
VALUES (32, 'Sergio', 'Ta',
        'Enojao', '3896', 'sergiotaenojado@gmail.com',
        'Representante Ventas', 1134.20, 'ALC-ES',
        1)

--3. Inserta un cliente que tenga como representante de ventas el empleado que creamos en el paso anterior.
INSERT INTO CLIENTES (codCliente, nombre_cliente, nombre_contacto,
                      apellido_contacto, telefono, email,
                      linea_direccion1, ciudad, pais, 
                      codPostal, codEmpl_ventas, limite_credito)
VALUES (39, 'Papeleria La Viña', 'Santiago', 
        'Lorenzano', '613704528','impresionespapeleria@gmail.com',
        'Prudencio La Viña 3', 'Alicante', 'España', 
        '03007', 32, 5000.20)



-- 4. Inserta un pedido que contenga al menos tres productos para el cliente que acabamos de crear.


INSERT INTO PEDIDOS (codPedido, fecha_pedido, fecha_esperada, 
                     codEstado, comentarios, codCliente)
VALUES (129, '2024-02-12', '2024-02-20',
        'E', 'Pago Pendiente', 39);

INSERT INTO DETALLE_PEDIDOS (codPedido, codProducto, cantidad,
                             precio_unidad, numeroLinea)
VALUES (129, 2, 40,
        14.00, 1);

INSERT INTO DETALLE_PEDIDOS (codPedido, codProducto, cantidad,
                             precio_unidad, numeroLinea)
VALUES (129, 208, 3,
        6.00, 2);

INSERT INTO DETALLE_PEDIDOS (codPedido, codProducto, cantidad,
                             precio_unidad, numeroLinea)
VALUES (129, 266, 3,
        21.00, 3);

-- Comprobación
SELECT *
  FROM PEDIDOS
 WHERE codCliente = 39;

 SELECT *
   FROM DETALLE_PEDIDOS
  WHERE codPedido = 129;
--5. Actualiza y/o borra el código del cliente que creamos en el paso anterior. ¿Ha sido posible
--actualizarlo o borrarlo? ¿Por qué? Averigua si hubo cambios en las tablas relacionadas.
DELETE FROM CLIENTES
 WHERE codCliente = 39;
 -- No puede borrarse, dado a que genera un conflicto con la tabla PEDIDO, que tiene una referencia en la cual el codCliente numero 39
 -- actua como FK de esa tabla.

--6. Actualiza la cantidad de unidades solicitadas en el pedido que has creado del siguiente modo:
-- para el 1er producto serán 3 unidades, para el producto 2 serán 2 unidades y el tercero 1 unidad.
UPDATE DETALLE_PEDIDOS
   SET cantidad = 3
 WHERE numeroLinea = 1
   AND codPedido = 129;

UPDATE DETALLE_PEDIDOS
   SET cantidad = 2
  WHERE numeroLinea = 2
    AND codPedido = 129;

UPDATE DETALLE_PEDIDOS
   SET cantidad = 1
 WHERE numeroLinea = 3
   AND codPedido = 129;

-- Comprobación.
  SELECT *
   FROM DETALLE_PEDIDOS
  WHERE codPedido = 129; 

--7. Modifica la fecha del pedido que hemos creado a la fecha y hora actuales.
UPDATE PEDIDOS
   SET fecha_pedido = GETDATE()
 WHERE codPedido = 129; 

-- Comprobación
SELECT *
  FROM PEDIDOS
 WHERE codCliente = 39;

--8. Incrementa en un 5% el precio de los productos que están incluidos en el pedido que has creado.
-- Recuerda que puede que tengas que redondear y/o utilizar la función CAST (XXX as FLOAT)
UPDATE DETALLE_PEDIDOS
   SET precio_unidad = precio_unidad*1.05
 WHERE codPedido = 129;


-- Comprobación.
  SELECT *
   FROM DETALLE_PEDIDOS
  WHERE codPedido = 129; 

SELECT precio_unidad,
       precio_unidad*1.05
  FROM DETALLE_PEDIDOS
  WHERE codPedido = 129;
--9. Vuelve a dejar el precio de dichos productos como estaba anteriormente.
UPDATE DETALLE_PEDIDOS
   SET precio_unidad = precio_unidad/1.05
 WHERE codPedido = 129;


 -- Comprobación.
  SELECT *
   FROM DETALLE_PEDIDOS
  WHERE codPedido = 129; 

SELECT precio_unidad,
       precio_unidad/1.05
  FROM DETALLE_PEDIDOS
  WHERE codPedido = 129;

--10. ¿Cuál sería la secuencia de borrado de registros de tablas hasta que finalmente se pueda borrar la oficina de Alicante que creamos en el ejercicio 1? Una vez tengas el script, comprueba que se puede eliminar.
DELETE FROM DETALLE_PEDIDOS
  WHERE codPedido = 129;

DELETE FROM PEDIDOS
 WHERE codPedido = 129;

DELETE FROM CLIENTES
 WHERE codCliente = 39;

DELETE FROM EMPLEADOS
 WHERE codEmpleado = 32;

DELETE FROM OFICINAS
 WHERE codOficina = 'ALC-ES'; 

--11. Incrementa en un 20% el precio de los productos que NO estén incluidos en ningún pedido.
-- Recuerda que puede que tengas que redondear y/o utilizar la función CAST (XXX as FLOAT)
UPDATE PRODUCTOS
   SET precio_venta = precio_venta*1.20
 WHERE codProducto IN (SELECT codProducto
                         FROM DETALLE_PEDIDOS);


SELECT precio_venta, precio_venta/1.20
  FROM PRODUCTOS
 WHERE codProducto IN (SELECT codProducto
                         FROM DETALLE_PEDIDOS)


--12. Vuelve a dejar el precio de los productos como estaba anteriormente.
UPDATE PRODUCTOS
   SET precio_venta = precio_venta/1.20
 WHERE codProducto IN (SELECT codProducto
                         FROM DETALLE_PEDIDOS);

SELECT precio_venta, precio_venta/1.20
  FROM PRODUCTOS
 WHERE codProducto IN (SELECT codProducto
                         FROM DETALLE_PEDIDOS)

--13. Elimina los clientes que no hayan realizado ningún pago.
DELETE FROM CLIENTES
  WHERE codCliente NOT IN (SELECT codCliente
                        FROM PAGOS);


SELECT *
  FROM CLIENTES
 WHERE codCliente NOT IN (SELECT codCliente
                        FROM PAGOS);




--14. Elimina los clientes que no hayan realizado un mínimo de 2 pedidos (NOTA: al ejecutar la sentencia fallará por la integridad referencial, es decir, porque hay tablas que tiene relacionado el idCliente como FK).
DELETE FROM CLIENTES
 WHERE codCliente IN (SELECT codCliente
                        FROM PEDIDOS
                       GROUP BY codCliente
                      HAVING COUNT(1) > 2);


SELECT codCliente
  FROM CLIENTES
 WHERE codCliente IN (SELECT codCliente
                        FROM PEDIDOS
                       GROUP BY codCliente
                      HAVING COUNT(1) > 2);







--15. Borra los pagos del cliente con menor límite de crédito.
DELETE FROM PAGOS
 WHERE codCliente = (SELECT TOP(1) codCliente
                          FROM CLIENTES
                          ORDER BY limite_credito ASC)

SELECT *
  FROM PAGOS
 WHERE codCliente = (SELECT TOP(1) codCliente
                          FROM CLIENTES
                          ORDER BY limite_credito ASC)


--16. Actualiza la ciudad a Alicante para aquellos clientes que tengan un límite de crédito inferior a TODOS los precios de los productos de la categoría Ornamentales (puede que no haya ninguno).



--17. Actualiza la ciudad a Madrid para aquellos clientes que tengan un límite de crédito mensual inferior a ALGUNO de los precios de los productos de la categoría Ornamentales.



--18. Establece a 0 el límite de crédito del cliente que menos unidades pedidas del producto OR-179.



--19. Modifica la tabla detalle_pedido para insertar un campo numérico llamado IVA. Establece el
--valor de ese campo a 18 para aquellos registros cuyo pedido tenga fecha a partir de Enero de
--2009. A continuación, actualiza el resto de pedidos estableciendo el IVA al 21.



--20. Modifica la tabla detalle_pedido para incorporar un campo numérico llamado total_linea y
--actualiza todos sus registros para calcular su valor con la fórmula:
--total_linea = precio_unidad*cantidad * (1 + (iva/100));


--21. Crea una tabla llamada HISTORICO_CLIENTES que tenga la misma estructura que CLIENTES y además un campo llamado fechaAlta de tipo DATE.
--Deberás insertar en una única sentencia los clientes cuyo nombre contenga la letra ‘s’ e informar el campo fechaAlta como la fecha/hora del momento en el que se inserta.


--22. Actualiza a NULL los campos region, pais y codigo_postal en la tabla CLIENTES para todos los registros. Utiliza una sentencia de actualización en la que se actualicen estos 3 campos a partir de los datos existentes en la tabla HISTORICO_CLIENTES. Comprueba que los datos se han trasladado correctamente.


