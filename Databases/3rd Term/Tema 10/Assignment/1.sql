-- Ejercicio 1
USE TIENDA
/*
SELECT *
  FROM PRODUCTO
EXEC sp_help PRODUCTO
*/
--Declaramos el @counter, que es el numero a través del que loopearemos.
-- y @max que sera su maximo.
DECLARE @counter INT, @max INT

SELECT @counter = MIN(codigo),
       @max = MAX(codigo)
  FROM PRODUCTO
-- Declaramos el nombre, aqui colocaremos el nombre del producto.
DECLARE @name VARCHAR(100)

-- Comenzamos el cursor
WHILE @counter <= @max
BEGIN
    -- Seteamos el nombre
    SELECT @name = nombre
      FROM PRODUCTO
     WHERE codigo = @counter

    PRINT @name
    SET @counter += 1
END

------------------------------
-------Segunda Opcion --------
------------------------------
GO
-- Declaramos el nombre del producto.
DECLARE @nombreProducto VARCHAR(100);

-- Declaramos el cursor.
DECLARE Cur_GetNombreProducto CURSOR FOR
 SELECT nombre
   FROM PRODUCTO
-- Comenzamos el cursor
OPEN Cur_GetNombreProducto

FETCH NEXT FROM Cur_GetNombreProducto INTO @nombreProducto
-- Comprobamos que haya obtenido algo.
WHILE @@FETCH_STATUS = 0
BEGIN
  -- Print del nombre del producto.
  PRINT @nombreProducto
  -- Obtenemos el siguiente.
  FETCH NEXT FROM Cur_GetNombreProducto INTO @nombreProducto
END

-- Cerramos el cursor.
CLOSE Cur_GetNombreProducto
DEALLOCATE Cur_GetNombreProducto

/*
Ejercicio 2
*/

GO
-- Declaramos el contador y el numero maximo. Los que utilizaremos
-- para el cursor.
DECLARE @counter INT, @max INT

-- Damos valores a @counter y @max.
SELECT @counter = MIN(codigo),
       @max = MAX(codigo)
  FROM PRODUCTO

-- Declaramos el nombre y el precio a obtener.
DECLARE @nombre VARCHAR(100)
DECLARE @precio DECIMAL(9,2)

WHILE @counter <= @max
BEGIN
    -- Damos valor a @nombre y @precio
    SELECT @nombre = nombre,
           @precio = precio
      FROM PRODUCTO
     WHERE codigo = @counter
    -- Print
    PRINT CONCAT('El producto ', @nombre, 'tiene un precio de ', @precio, '€')
    -- Modificamos el @counter.
    SET @counter += 1
END

------------------------------
-------Segunda Opcion --------
------------------------------
GO

-- Declaramos el nombre y el precio a obtener.
DECLARE @nombre VARCHAR(100), @precio DECIMAL(9,2)
-- Declaramos el cursor.
DECLARE Cur_GetProductoByPrecio CURSOR FOR
 SELECT nombre, precio
   FROM PRODUCTO

OPEN Cur_GetProductoByPrecio

FETCH NEXT FROM Cur_GetProductoByPrecio INTO @nombre, @precio
-- Revisamos que FETCH devuelva algo.
WHILE @@FETCH_STATUS = 0
BEGIN
  -- Print
  PRINT CONCAT('El producto ', @nombre, 'tiene un precio de ', @precio, '€')
  -- Obtenemos el siguiente valor.
  FETCH NEXT FROM Cur_GetProductoByPrecio INTO @nombre, @precio
END

/*
Ejercicio 3
*/
GO
USE TIENDA

-- Declaramos @codFabricante, @nombreFabricante
DECLARE @codFabricante INT, @nombreFabricante VARCHAR(100)
-- Declaramos el cursor.
DECLARE Cur_Fabricante CURSOR FOR
 SELECT codigo, nombre
   FROM  FABRICANTE

-- Abrimos el cursor.
OPEN Cur_Fabricante

-- Obtenemos el primer valor
FETCH NEXT FROM Cur_Fabricante INTO @codFabricante, @nombreFabricante
-- Mientras hayamos obtenido algo.
WHILE @@FETCH_STATUS = 0
BEGIN
  -- Preparamos el siguiente Cursor
  DECLARE Cur_PrecioProductos CURSOR FOR
   SELECT precio
     FROM PRODUCTO
    WHERE codigo = @codFabricante
  -- Declaramos el precio y el valor acumulado.
  DECLARE @precio DECIMAL(10,2), @acumulado DECIMAL(11,2)
  SET @acumulado = 0
  -- Abrimos el segundo cursor.
  OPEN Cur_PrecioProductos
  FETCH NEXT FROM Cur_PrecioProductos INTO @precio
  -- Operamos con el segundo cursor.
  WHILE @@FETCH_STATUS = 0
  BEGIN
    SET @acumulado = @acumulado + @precio
  
    -- Obtenemos el siguiente valor.
    FETCH NEXT FROM Cur_PrecioProductos INTO @precio
  END
  -- Cerramos el segundo cursor.
  CLOSE Cur_PrecioProductos;
  DEALLOCATE Cur_PrecioProductos;
  -- Imprimos los datos de cada fabricante
  PRINT CONCAT('Fabricante: ', @nombreFabricante, ' tiene un total de',
  @acumulado, '€ en productos')  
  -- Obtenemos el siguiente fabricante.
  FETCH NEXT FROM Cur_Fabricante INTO @codFabricante, @nombreFabricante

END
-- Cerramos el primer cursor.
CLOSE Cur_Fabricante;
DEALLOCATE Cur_Fabricante;

------------------------------
-------Segunda Opcion --------
------------------------------
GO
USE TIENDA
-- Declaramos el nombre del fabricante y seteamos nuestro contador
-- y valor maximo para nuestro cursor.
DECLARE @nombreFabricante VARCHAR(100)
DECLARE @contFab INT
DECLARE @maxFab INT

SELECT @contFab = MIN(codigo),
       @maxFab = MAX(codigo)
  FROM FABRICANTE

-- Empezamos el cursor.
WHILE @contFab <= @maxFab
BEGIN
  -- Declaramos 2 variables. @precio para manejar el precio de cada producto
  -- @acumulado para manejar el total acumulado por cliente. Por cada inicio
  -- en el contador. Lo tendremos seteado a 0 cada vez que iniciamos con un
  -- cliente nuevo.
  DECLARE @precio DECIMAL(10,2)
  DECLARE @acumulado DECIMAL(11,2) = 0

  -- Preparamos las variables para el proximo bucle.
  DECLARE @contProd INT = 0
  DECLARE @maxProd INT
  SELECT @maxProd = (COUNT(codigo) - 1)
    FROM PRODUCTO
   WHERE codigo_fabricante = @contFab
  -- Comenzamos el segundo bucle.
  WHILE @contProd <= @maxProd
  BEGIN
    -- Seteamos el valor precio
    SELECT @precio = precio
      FROM PRODUCTO
     WHERE codigo_fabricante = @contFab
     ORDER BY codigo
     OFFSET @contProd ROWS
     FETCH NEXT 1 ROWS ONLY

    SET @acumulado += @precio;

    SET @contProd += 1
  END

  -- Reseteamos el nombre de nuestro fabricante a null.
  SET @nombreFabricante = NULL 
  -- Obtenemos el nombre de nuestro fabricante:
  SELECT @nombreFabricante = nombre
    FROM FABRICANTE
   WHERE codigo = @contFab
  -- Imprimiremos solo si nuestro fabricante no es null
  IF @nombreFabricante IS NOT NULL
    PRINT CONCAT('Fabricante: ', @nombreFabricante, ' tiene un total de ',
    @acumulado, '€ en productos')  
  SET @contFab += 1 
END


/*
Ejercicio 04
*/
USE JARDINERIA
EXEC sp_help EMPLEADOS
-- Declaramos las variables.
DECLARE @nombre VARCHAR(50),
        @apellido1 VARCHAR(50), 
        @apellido2 VARCHAR(50),
        @email VARCHAR(100)

-- Declaramos el contador y el maximo que utilizaremos en el cursor.
DECLARE @counter INT, @max INT
SELECT @counter = MIN(codEmpleado),
       @max = MAX(codEmpleado)
  FROM EMPLEADOS

-- Comenzamos el cursor.
WHILE @counter <= @max
BEGIN
  -- seteamos las variables
  SELECT @nombre = nombre,
         @apellido1 = apellido1,
         @apellido2 = apellido2,
         @email = email
    FROM EMPLEADOS
   WHERE @counter = codEmpleado
  -- print de los datos.
   PRINT CONCAT('Datos del empleado ID-', @counter, CHAR(10),
                'nombre: ', @nombre, CHAR(10),
                'apellido1: ', @apellido1, CHAR(10),
                'apellido2: ', @apellido2, CHAR(10),
                'email: ', @email, CHAR(10))
   -- modificamos el contador.
   SET @counter += 1

END

------------------------------
-------Segunda Opcion --------
------------------------------
GO
-- Declaramos las variables.
DECLARE @nombre VARCHAR(50),
        @apellido1 VARCHAR(50), 
        @apellido2 VARCHAR(50),
        @email VARCHAR(100),
        @codEmpleado INT
-- Declaramos cursor.
DECLARE Cur_GetDatosEmpleado CURSOR FOR
SELECT nombre,
       apellido1,
       apellido2,
       email,
       codEmpleado
  FROM EMPLEADOS
-- Abrimos el cursor.
OPEN Cur_GetDatosEmpleado 
-- Obtenemos los datos del cursor.
FETCH NEXT FROM Cur_GetDatosEmpleado INTO @nombre, @apellido1, @apellido2, @email, @codEmpleado

-- Mientras sigamos obteniendo datos del cursor.
WHILE @@FETCH_STATUS = 0
BEGIN
  -- Imprimimos
  PRINT CONCAT('Datos del empleado ID-', @codEmpleado, CHAR(10),
                'nombre: ', @nombre, CHAR(10),
                'apellido1: ', @apellido1, CHAR(10),
                'apellido2: ', @apellido2, CHAR(10),
                'email: ', @email, CHAR(10))
  -- Obtenemos el siguiente valor.
  FETCH NEXT FROM Cur_GetDatosEmpleado INTO @nombre, @apellido1, @apellido2, @email, @codEmpleado

END
-- Cerramos el cursor.
CLOSE Cur_GetDatosEmpleado
DEALLOCATE Cur_GetDatosEmpleado

/*
Ejercicio 05
*/
GO
-- Declaramos el @codPedido.
DECLARE @codPedido INT

-- Declaramos el cursor.
DECLARE Cur_Pedido CURSOR FOR
SELECT codPedido
  FROM PEDIDOS

-- Abrimos el cursor.
OPEN Cur_Pedido 

-- Obtenemos el primer valor.
FETCH NEXT FROM Cur_Pedido INTO @codPedido
-- While sigamos obteniendo valores.
WHILE @@FETCH_STATUS = 0
BEGIN
  -- Gestionamos el cursor secundario
  DECLARE @acumulado DECIMAL(12,2), @importe DECIMAL(11,2);
  SET @acumulado = 0;
  -- Declaramos el cursor.
  DECLARE Cur_DetallePedidos CURSOR FOR
   SELECT cantidad * precio_unidad
     FROM DETALLE_PEDIDOS
    WHERE codPedido = @codPedido;
  -- Abrimos el segundo cursor.
  OPEN Cur_DetallePedidos;
  -- Obtenemos el primer valor del segundo cursor.
  FETCH NEXT FROM Cur_DetallePedidos INTO @importe
  -- While sigamos obteniendo datos.
  WHILE @@FETCH_STATUS = 0
  BEGIN
    -- Seteamos @acumulado
    SET @acumulado = @acumulado + @importe;
    -- Obtenemos el siguiente valor.
    FETCH NEXT FROM Cur_DetallePedidos INTO @importe;
  END
  -- Cerramos el cursor.
  CLOSE Cur_DetallePedidos
  DEALLOCATE Cur_DetallePedidos

  -- Print los datos.
  PRINT CONCAT('Nº Pedido ', @codPedido , 'tiene un coste total de ', @acumulado, '€')
  -- Obtenemos los datos del siguiente cursor.
  FETCH NEXT FROM Cur_Pedido INTO @codPedido;
END

CLOSE Cur_Pedido
DEALLOCATE Cur_Pedido
