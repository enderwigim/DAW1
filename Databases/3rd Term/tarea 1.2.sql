USE JARDINERIA

						---------------------------
						-- EJERCICIOS UD7 - TSQL -- 
						---------------------------
-------------------------------------------------------------------------------------------
-- NOTA: Recuerda cuidar la limpieza del código (tabulaciones, nombres de tablas en mayúscula,
--		nombres de variables en minúscula, poner comentarios sin excederse, código organizado y fácil de seguir, etc.)
-------------------------------------------------------------------------------------------
-- 1. Crea un script que use un bucle para calcular la potencia de un número.
--		Tendremos dos variables: el número y la potencia
--
--		Ejemplo.
--		Número = 3		Potencia = 4		Resultado = 3*3*3*3 = 81
--
--		Si el número o la potencia son 0 o <0 devolverá el mensaje: “La operación no se puede realizar.
-------------------------------------------------------------------------------------------
/*
DECLARE @num INT = 4
DECLARE @power INT = 3
DECLARE @counter INT = 1
DECLARE @total INT = @num
DECLARE @totalVarChar VARCHAR(50) = CONCAT('Resultado = ', @num)

IF @num <> 0 AND @power <> 0
BEGIN
    WHILE @counter < @power 
    BEGIN
        SET @total *= @num
        SET @totalVarChar += CONCAT('*',@num)

        SET @counter += 1
    END
    PRINT CONCAT(@totalVarChar, ' = ', @total)
END 
ELSE
    PRINT 'La operación no se puede realizar'
*/
-------------------------------------------------------------------------------------------
-- 2. Crea un script que calcule las soluciones de una ecuación de segundo grado ax^2 + bx + c = 0
--
--	Debes crear variables para los valores a, b y c.
--  Al principio debe comprobarse que los tres valores son positivos, en otro caso, 
--		se devolverá el mensaje 'Cálculo no implementado'
--	
--	Consulta esta página para obtener la fórmula a implementar (recuerda que habrá DOS soluciones): 
--		http://recursostic.educacion.es/descartes/web/Descartes1/4a_eso/Ecuacion_de_segundo_grado/Ecua_seg.htm#solgen

--	Salida esperada para los valores: a=3, b=-4, c=1 --> sol1= 1 y sol2= 0.33
--	
--	NOTA: Si no sale lo mismo, te recomiendo revisar bien el orden de prioridad de los operadores... ()
-------------------------------------------------------------------------------------------
/*
DECLARE @a INT = 3
DECLARE @b INT = -4
DECLARE @c INT = 1
DECLARE @total1 DECIMAL(5,2)
DECLARE @total2 DECIMAL(5,2)

IF @a > 0 AND @c > 0
BEGIN
    SET @total1 = (@b * -1 + SQRT(@b * @b - 4 * @a * @c)) / (2 * @a)



    SET @total2 = (@b * -1 - SQRT(@b * @b - 4 * @a * @c)) / (2 * @a)

    PRINT CONCAT('sol1 = ', @total1, ' sol2 = ', @total2)
END
ELSE
    PRINT 'Ninguno de nuestros valores puede ser negativo.'
¨*/

-------------------------------------------------------------------------------------------
-- 3. Crea un script que calcule la serie de Fibonacci para un número dado.

-- La sucesión es: 1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597...
-- Si te fijas, se calcula sumando el número anterior al siguiente:
--	Ejemplo. Si se introduce el numero 3 significa que tendremos que hacer 3 iteraciones:
--			ini = 1
--			0+1 = 1
--			1+1 = 2
--			2+1 = 3
--			3+2 = 5
--			5+3 = 8
--			...
-- 
--	Ayuda: Quizás necesites guardar en algún sitio el valor actual de la serie antes de sumarlo...
-------------------------------------------------------------------------------------------
/*
-- Primero declaramos @i y luego @objetivo. Usaremos estos para controlar las iteraciones que haremos.
DECLARE @i INT = 0 
DECLARE @objective INT = 57

-- Declararemos un @total y luego utilizaremos dos auxiliares.
/*Utilizaremos BIGINT para extender un poco las posibilidades del programa.
Por ejemplo si queremos hacer 57 iteraciones, el programa seguira funcionando.*/
DECLARE @total BIGINT = 1
DECLARE @aux1 BIGINT = 0
DECLARE @aux2 BIGINT = 0

-- Primero imprimimos el estado inicial
PRINT CONCAT('ini = ', @total)

-- Comenzamos las iteraciones
WHILE @i < @objective
BEGIN
    SET @aux2 = @aux1
    SET @aux1 = @total
    SET @total = @aux1 + @aux2

    PRINT CONCAT(@aux1, ' + ', @aux2, ' = ', @total)

    SET @i += 1
END

*/
-------------------------------------------------------------------------------------------
-- 4. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Obtén el nombre del cliente con código 3 y guárdalo en una variable
--		Obtén el número de pedidos realizados por dicho cliente y guárdalo en una variable
--		Muestra por pantalla el mensaje: 'El cliente XXXX ha realizado YYYY pedidos.'
--		
--		Resultado esperado: El cliente Gardening Associates ha realizado 9 pedidos.
--
--	    Reto opcional: Implementa el script utilizando una única consulta.
-------------------------------------------------------------------------------------------
/*
USE JARDINERIA;
EXEC sp_columns CLIENTES

-- Declaramos @codCliente para no tener que modificar las selects a futuro.
DECLARE @codCliente INT = 3
-- Declaramos las otras variables que vamos utilizar
DECLARE @nombreCliente VARCHAR(50)
DECLARE @cantPedidos SMALLINT

-- Seteamos la variable @nombreCliente
SELECT @nombreCliente = nombre_cliente
  FROM CLIENTES
 WHERE codCliente = @codCliente
-- Seteamos la variable @cantidadPedidos
SELECT @cantPedidos = COUNT(1)
  FROM PEDIDOS p,
       CLIENTES c
 WHERE c.codCliente = p.codCliente
   AND c.codCliente = @codCliente;

PRINT CONCAT('El cliente ', @nombreCliente, ' ha realizado ', @cantPedidos, ' pedidos.')
*/



-------------------------------------------------------------------------------------------
-- 5. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Obtén el nombre y los apellidos de todos los empleados de la empresa
--		Deberás mostrar cada uno de ellos línea a línea utilizando PRINT
--		
--		Salida esperada:
--			Magaña Perez, Marcos
--			López Martinez, Ruben
--			Soria Carrasco, Alberto
--			Solís Jerez, Maria
--			...
--
--		Reto opcional: Modifica el script anterior para que muestre sólo los que trabajen en la oficina de Londres
--		Salida esperada:
--			Johnson , Amy
--			Westfalls , Larry
--			Walton , John
-------------------------------------------------------------------------------------------
/*
DECLARE @i INT = 1
DECLARE @cantidadEmpleados INT

/* Dado a que en nombre completo almacenaremos apellido1, apellido2
y nombre, de VARCHAR(50) cada uno. Y se le sumaran 3 caracteres mas
utilizaremos un VARCHAR(103).
*/
DECLARE @nombreCompletoEmp VARCHAR(103)
-- Declaramos @codOficina por si lo queremos cambiar a futuro.
DECLARE @codOficina CHAR(6) = 'LON-UK'


-- Obtenemos la cantidad total de empleados
SELECT @cantidadEmpleados = COUNT(codEmpleado)
  FROM EMPLEADOS


WHILE @i <= @cantidadEmpleados
BEGIN
    SET @nombreCompletoEmp = NULL

    -- Asignamos a @nombreCompletoEmp los apellidos y el nombre de cada 
    -- empleado segun la posición del bucle
    SELECT @nombreCompletoEmp = CONCAT(apellido1, ' ', apellido2, ', ', nombre)
      FROM EMPLEADOS 
     WHERE codEmpleado = @i
       AND codOficina = @codOficina

    SET @i += 1
    IF @nombreCompletoEmp IS NOT NULL
        PRINT @nombreCompletoEmp
END
*/
-------------------------------------------------------------------------------------------
-- 6. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Reutilizando el script del ejercicio 4, agrega la siguiente información a la salida:
--			Número de pedidos realizados por cada cliente
--			NOTA: Realízalo utilizando una consulta específica para obtener el número de pedidos de cada cliente.

--		Salida esperada:
--			El cliente GoldFish Garden ha realizado 11 pedidos.
--			El cliente Gardening Associates ha realizado 9 pedidos.
--			El cliente Gerudo Valley ha realizado 5 pedidos.
--			El cliente Tendo Garden ha realizado 5 pedidos.
--			El cliente Lasas S.A. ha realizado 0 pedidos.
--			...
--
--		Reto opcional:
--		Muestra también el coste total de todos los pedidos para cada cliente.
--
--		Salida esperada:
--			El cliente GoldFish Garden ha realizado 11 pedidos por un coste total de 10365.00.
--			El cliente Gardening Associates ha realizado 9 pedidos por un coste total de 13726.00.
--			El cliente Gerudo Valley ha realizado 5 pedidos por un coste total de 81849.00.
--			El cliente Tendo Garden ha realizado 5 pedidos por un coste total de 23794.00.
--			El cliente Lasas S.A. ha realizado 0 pedidos por un coste total de 0.00.
--			...
-------------------------------------------------------------------------------------------
/*

USE JARDINERIA;
EXEC sp_columns CLIENTES

DECLARE @i INT = 1
DECLARE @cantidadClientes INT
-- Declaramos las otras variables que vamos utilizar
DECLARE @nombreCliente VARCHAR(50)
DECLARE @cantPedidos SMALLINT
DECLARE @totalPagado DECIMAL(9,2)

-- Obtenemos la cantidad de clientes
SELECT @cantidadClientes = COUNT(codCliente)
  FROM CLIENTES;

WHILE @i < @cantidadClientes
BEGIN

    SET @nombreCliente = NULL
    SET @cantPedidos = 0
    SET @totalPagado = 0.00
-- Seteamos la variable @nombreCliente
    SELECT @nombreCliente = nombre_cliente
    FROM CLIENTES
    WHERE codCliente = @i

    -- Seteamos la variable @cantidadPedidos
    SELECT @cantPedidos = COUNT(1)
    FROM PEDIDOS p,
        CLIENTES c
    WHERE c.codCliente = p.codCliente
    AND c.codCliente = @i

    SELECT @totalPagado = ISNULL(SUM(dp.precio_unidad * dp.cantidad), 0.00) 
    FROM CLIENTES c,
        PEDIDOS p,
        DETALLE_PEDIDOS dp
    WHERE c.codCliente = p.codCliente
        AND p.codPedido = dp.codPedido
        AND c.codCliente = @i

    IF @nombreCliente IS NOT NULL
    BEGIN
        PRINT CONCAT('El cliente ', @nombreCliente, ' ha realizado ', @cantPedidos,
         ' pedidos. Por un coste total de ', @totalPagado, '.')
    END
    SET @i += 1
END

*/
-------------------------------------------------------------------------------------------
-- 7. Utilizando la BD JARDINERIA, crea un script que realice las siguientes operaciones:
--	Importante: debes utilizar TRY/CATCH y Transacciones si fueran necesarias.

--		Crea una nueva oficina (datos inventados)
--		Crea un nuevo empleado con datos inventados (el codEmpleado a insertar debes obtenerlo automáticamente)
--		Crea un nuevo cliente (datos inventados) (el codCliente a insertar debes obtenerlo automáticamente)
--		Asigna como representante de ventas el cliente anterior
-------------------------------------------------------------------------------------------
/*
-- Activamos transacciones
SET IMPLICIT_TRANSACTIONS OFF

DECLARE @nuevoCodEmpleado INT
DECLARE @nuevoCodCliente INT
DECLARE @error INT


BEGIN TRY
    BEGIN TRAN
        -- Insertamos la nueva oficina
        INSERT INTO OFICINAS (codOficina, ciudad, pais,
                                codPostal, telefono, linea_direccion1)
        VALUES('BUE-AR', 'Buenos Aires', 'Argentina', 
                '12345', '+54 1161677915', 'Yapeyú 493')

        -- Obtengo el Maximo codEmpleado y le sumo 1, será el codigo de nuestro nuevo empleado
        SELECT @nuevoCodEmpleado = ISNULL(MAX(codEmpleado), 0) + 1
        FROM EMPLEADOS

        INSERT INTO EMPLEADOS (codEmpleado, nombre, apellido1,
                                tlf_extension_ofi, email,puesto_cargo, 
                                salario, codOficina)
        VALUES (@nuevoCodEmpleado, 'Santiago', 'Lorenzano',
                '12345', 'santiagolorenzano@gmail.com', 'representante',
                 1000, 'BUE-AR')


        -- Obtengo el Maximo codCliente y le sumo 1, será el codigo de nuestro nuevo cliente
        SELECT @nuevoCodCliente = ISNULL(MAX(codCliente), 0) + 1
        FROM CLIENTES

        INSERT INTO CLIENTES (codCliente, nombre_cliente, nombre_contacto,
                            apellido_contacto, telefono, email,
                            linea_direccion1, ciudad, pais,
                            codPostal, codEmpl_ventas, limite_credito)
        VALUES (@nuevoCodCliente, 'Sergio', 'SergioCrack',
                'Diez', '1234', 'sergioesargentino@gmail.com',
                'Marcha de San Lorenzo 123', 'Buenos Aires', 'Argentina',
                '1876', @nuevoCodEmpleado, 10000)
    COMMIT
    PRINT 'Datos actualizados'        
END TRY
BEGIN CATCH
    PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
                ', DESCRIPTION: ', ERROR_MESSAGE(),
                ', LINE: ', ERROR_LINE())
END CATCH
exec sp_columns CLIENTES

DELETE FROM OFICINAS
  WHERE codOficina = 'BUE-AR'

SELECT *
  FROM EMPLEADOS
  */
-------------------------------------------------------------------------------------------
-- 8. Utilizando la BD JARDINERIA, crea un script que realice las siguientes operaciones:
--	Importante: debes utilizar TRY/CATCH y Transacciones si fueran necesarias.
--
--		Debes eliminar la oficina, el empleado y el cliente creados en el apartado anterior.
--		Debes crear variables con los identificadores de clave primaria para eliminar
--			todos los datos de cada una de las tablas en una sola ejecución
-------------------------------------------------------------------------------------------




-------------------------------------------------------------------------------------------
-- 9. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Crea un nuevo cliente (invéntate los datos). No debes indicar directamente el código, 
--			sino buscar cuál le tocaría con una SELECT y guardarlo en una variable.

--		Crea un nuevo pedido para dicho cliente (fechaPedido será la fecha actual, fecha esperada 10 días 
--				después de la fecha de pedido, fecha entrega y comentarios a NULL y estado PENDIENTE)
--			Dicho pedido debe constar de dos productos (los códigos de producto se declaran como variables y se utilizan después)
--			El precio de cada producto debes obtenerlo utilizando SELECT antes de insertarlo en DETALLE_PEDIDOS,
--			de tal manera que, si modificamos los códigos de producto, el script seguirá funcionando.
--			La cantidad de los productos comprados puede ser la que tú quieras.

--		Recuerda que debes utilizar TRANSACCIONES (si fueran necesarias) y TRY/CATCH

--		Reto opcional:
--			Crea también un nuevo pago para dicho cliente cuyo importe coincida con lo que cuesta el pedido completo
--				Puedes indicar directamente el idtransaccion como 'ak-std-000026', aunque es mejor que lo obtengas dinámicante
--				utilizando funciones de SQL Server (piensa que los 6 últimos caracteres son números...)
--				Forma de pago debe ser: 'PayPal' y Fechapago la del día
-------------------------------------------------------------------------------------------


