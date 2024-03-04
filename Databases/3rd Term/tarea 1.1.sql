USE JARDINERIA

						---------------------------
						-- EJERCICIOS UD7 - TSQL -- 
						---------------------------
-------------------------------------------------------------------------------------------
-- NOTA: Recuerda cuidar la limpieza del código (tabulaciones, nombres de tablas en mayúscula,
--		nombres de variables en minúscula, poner comentarios sin excederse, código organizado y fácil de seguir, etc.)
-------------------------------------------------------------------------------------------
-- ¡IMPORTANTE! Siempre que sea posible deberás utilizar variables 	(no es correcto indicar directamente el valor en una SELECT)
--  Esta práctica incorrecta se conoce como "hardcoding" y genera muchos problemas en el código y en su depuración
--  Aquí tenéis más información: https://es.wikipedia.org/wiki/Hard_code
-------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------
-- 1. Crea un script que obtenga el nombre de la gama que tenga más cantidad de productos diferentes
--
-- Salida: 'La gama que más productos tiene es Ornamentales'
-------------------------------------------------------------------------------------------


DECLARE @gamaConMasProductos varchar(100);

-- Obtenemos la gama con mas productos
SELECT @gamaConMasProductos = cat.nombre
  FROM PRODUCTOS pro,
       CATEGORIA_PRODUCTOS  cat
  WHERE pro.codCategoria = cat.codCategoria
 GROUP BY pro.codCategoria, cat.nombre
 ORDER BY COUNT(pro.codProducto) ASC

PRINT @gamaConMasProductos


-------------------------------------------------------------------------------------------
-- 2. Crea un script que obtenga el nombre del empleado con id 7 y el nombre de su jefe
--
-- Salida: 'El empleado Carlos Soria Jimenez tiene como jefe al empleado Alberto Soria Carrasco'
-------------------------------------------------------------------------------------------
EXEC sp_columns EMPLEADOS
/*
DECLARE @nombreEmpleado VARCHAR(150);
DECLARE @codEmpleado INT = 7
DECLARE @codigoJefe INT;
DECLARE @nombreJefe VARCHAR(150);

-- Obtenemos el nombre del empleado a través de su codigo, tambien el codigo de su jefe.
SELECT @nombreEmpleado = CONCAT(nombre, ' ', apellido1, ' ', apellido2),
       @codigoJefe = codEmplJefe
  FROM EMPLEADOS
 WHERE codEmpleado = @codEmpleado;

SELECT @nombreJefe = CONCAT(nombre, ' ', apellido1, ' ', apellido2)
  FROM EMPLEADOS
 WHERE codEmpleado = @codigoJefe

PRINT CONCAT('El empleado ', @nombreEmpleado, ' tiene como jefe al empleado ', @nombreJefe)
*/


DECLARE @codEmpleado INT = 7
DECLARE @nombreEmpleado VARCHAR(152)
DECLARE @nombreJefe VARCHAR(152)


SELECT @nombreEmpleado = CONCAT(e.nombre, ' ', e.apellido1, ' ', e.apellido2),
       @nombreJefe = CONCAT(j.nombre, ' ', j.apellido1, ' ', j.apellido2)
  FROM EMPLEADOS e,
       EMPLEADOS j
 WHERE e.codEmpleado = @codEmpleado
   AND e.codEmplJefe = j.codEmpleado

PRINT CONCAT('EMPL: ', @nombreEmpleado, CHAR(10),
             'JEFE: ', @nombreJefe) 

-------------------------------------------------------------------------------------------
-- 3. Crea un script que devuelva el número de pedidos realizados por el cliente 9
--
-- Salida: 'El cliente Naturagua ha realizado 5 pedido/s'
-------------------------------------------------------------------------------------------
EXEC sp_columns CLIENTES
/*
DECLARE @codCliente INT = 9;
DECLARE @nombreCliente VARCHAR(50);
DECLARE @cantidadPedidos INT;

-- Obtengo la cantidad de pedidos y el nombre del cliente.
SELECT @cantidadPedidos = COUNT(ped.codPedido),
       @nombreCliente = cli.nombre_cliente
  FROM PEDIDOS ped,
       CLIENTES cli
 WHERE cli.codCliente = ped.codCliente
   AND cli.codCliente = @codCliente
 GROUP BY ped.codCliente, cli.nombre_cliente

PRINT CONCAT('El cliente ', @nombreCliente, 'ha realizado ', @cantidadPedidos, ' pedido/s')
*/

-------------------------------------------------------------------------------------------
-- 4. Crea un script que dado un codPedido en una variable, obtenga la siguiente información:
--		nombre_cliente, Fecha pedido, estado
--
-- Salida: 'El pedido XXXX realizado por el cliente YYYYYYY se realizó el ZZ/ZZ/ZZZZ y su estado es EEEEEEEE
-------------------------------------------------------------------------------------------
EXEC sp_columns PEDIDOS
DECLARE @fecha CHAR(10);
DECLARE @codPedido INT;
DECLARE @codCliente INT;
DECLARE @nombreCliente VARCHAR(50);
DECLARE @codigoEstado CHAR(1);
DECLARE @nombreEstado VARCHAR(15);

--Obtenemos un pedido aleatorio}
SELECT TOP(1) 
       @codPedido = codPedido,
       @fecha = CONCAT(DAY(fecha_pedido), '/', MONTH(fecha_pedido), '/', YEAR(fecha_pedido)),
       @codigoEstado = codEstado,
       @codCliente = codCliente
  FROM PEDIDOS
 ORDER BY NEWID();

-- Obtenemos nombre del cliente.
SELECT @nombreCliente = nombre_cliente
  FROM CLIENTES
 WHERE codCliente = @codCliente

-- Obtenemos el nombre del estado.
SELECT @nombreEstado = descripcion
  FROM ESTADOS_PEDIDO

PRINT CONCAT('El pedido ', @codPedido, 
              ' realizado por el cliente ', @nombreCliente, 
              '. Se realizó el ', @fecha, 
              ' y su estado es', @nombreEstado)



-------------------------------------------------------------------------------------------
-- 5. Crea un script que dadas dos variables: porcentaje y gama
--		Incremente el precio de los productos de dicha gama en el porcentaje que se le pasa
--
-- Salida: 'Se ha aumentado el precio un XXXX% de la gama YYYY'
-------------------------------------------------------------------------------------------
DECLARE @porcentaje DECIMAL(3,2) = 1.20
DECLARE @gama CHAR(2) = 'OR'

UPDATE PRODUCTOS
   SET precio_venta *= @porcentaje 
 WHERE codCategoria = @gama

SELECT precio_venta FROM PRODUCTOS
  WHERE codCategoria = 'OR'
  ORDER BY precio_venta ASC

-------------------------------------------------------------------------------------------
-- 6. Crea un script que devuelva cuántos clientes han realizado algún pedido de
--   al menos 3 productos (siendo el número de productos una variable).
--	
-- Salida: 'Existen XXXX clientes en la BD que han realizado pedidos de al menos YYYY productos'
-------------------------------------------------------------------------------------------





-------------------------------------------------------------------------------------------
-- 7. Crea un script que a partir de una variable codCliente devuelva el nombre completo de su
-- 		representante de ventas y la ciudad de la oficina en la que trabaja.
--	
-- Salida: 'El cliente XXXX tiene como representante a YYYY y trabaja en la ciudad de ZZZZ'
-------------------------------------------------------------------------------------------



