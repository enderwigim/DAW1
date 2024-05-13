-- Ejercicio 1
USE TIENDA
/*
SELECT *
  FROM PRODUCTO
EXEC sp_help PRODUCTO
*/
DECLARE @counter INT, @max INT

SELECT @counter = MIN(codigo),
       @max = MAX(codigo)
  FROM PRODUCTO
DECLARE @name VARCHAR(100)

WHILE @counter <= @max
BEGIN

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

DECLARE @nombreProducto VARCHAR(100);

DECLARE Cur_GetNombreProducto CURSOR FOR
 SELECT nombre
   FROM PRODUCTO

OPEN Cur_GetNombreProducto

FETCH NEXT FROM Cur_GetNombreProducto INTO @nombreProducto

WHILE @@FETCH_STATUS = 0
BEGIN
  PRINT @nombreProducto
  FETCH NEXT FROM Cur_GetNombreProducto INTO @nombreProducto
END

CLOSE Cur_GetNombreProducto
DEALLOCATE Cur_GetNombreProducto

/*
Ejercicio 2
*/

GO
DECLARE @counter INT, @max INT

SELECT @counter = MIN(codigo),
       @max = MAX(codigo)
  FROM PRODUCTO
DECLARE @nombre VARCHAR(100)
DECLARE @precio DECIMAL(9,2)

WHILE @counter <= @max
BEGIN

    SELECT @nombre = nombre,
           @precio = precio
      FROM PRODUCTO
     WHERE codigo = @counter

    PRINT CONCAT('El producto ', @nombre, 'tiene un precio de ', @precio, '€')
    SET @counter += 1
END

------------------------------
-------Segunda Opcion --------
------------------------------
GO
DECLARE @nombre VARCHAR(100), @precio DECIMAL(9,2)

DECLARE Cur_GetProductoByPrecio CURSOR FOR
 SELECT nombre, precio
   FROM PRODUCTO

OPEN Cur_GetProductoByPrecio

FETCH NEXT FROM Cur_GetProductoByPrecio INTO @nombre, @precio

WHILE @@FETCH_STATUS = 0
BEGIN
  PRINT CONCAT('El producto ', @nombre, 'tiene un precio de ', @precio, '€')
  FETCH NEXT FROM Cur_GetProductoByPrecio INTO @nombre, @precio
END

/*
Ejercicio 3
*/
GO
USE TIENDA

DECLARE @codFabricante INT, @nombreFabricante VARCHAR(100)
DECLARE Cur_Fabricante CURSOR FOR
 SELECT codigo, nombre
   FROM  FABRICANTE

OPEN Cur_Fabricante

FETCH NEXT FROM Cur_Fabricante INTO @codFabricante, @nombreFabricante

WHILE @@FETCH_STATUS = 0
BEGIN
  -- Preparamos el siguiente Cursor
  DECLARE Cur_PrecioProductos CURSOR FOR
   SELECT precio
     FROM PRODUCTO
    WHERE codigo = @codFabricante

  DECLARE @precio DECIMAL(10,2), @acumulado DECIMAL(10,2)
  SET @acumulado = 0

  OPEN Cur_PrecioProductos
  FETCH NEXT FROM Cur_PrecioProductos INTO @precio
  -- Operamos con el cursor interno
  WHILE @@FETCH_STATUS = 0
  BEGIN
    SET @acumulado = @acumulado + @precio
    FETCH NEXT FROM Cur_PrecioProductos INTO @precio
  END

  CLOSE Cur_PrecioProductos;
  DEALLOCATE Cur_PrecioProductos;

  PRINT CONCAT('Fabricante: ', @nombreFabricante, ' tiene un total de',
  @acumulado, '€ en productos')  

  FETCH NEXT FROM Cur_Fabricante INTO @codFabricante, @nombreFabricante

END

CLOSE Cur_Fabricante;
DEALLOCATE Cur_Fabricante;


/*
Ejercicio 04
*/
USE JARDINERIA
EXEC sp_help EMPLEADOS
DECLARE @nombre VARCHAR(50),
        @apellido1 VARCHAR(50), 
        @apellido2 VARCHAR(50),
        @email VARCHAR(100)

DECLARE @counter INT, @max INT
SELECT @counter = MIN(codEmpleado),
       @max = MAX(codEmpleado)
  FROM EMPLEADOS

WHILE @counter <= @max
BEGIN
  SELECT @nombre = nombre,
         @apellido1 = apellido1,
         @apellido2 = apellido2,
         @email = email
    FROM EMPLEADOS
   WHERE @counter = codEmpleado

   PRINT CONCAT('Datos del empleado ID-', @counter, CHAR(10),
                'nombre: ', @nombre, CHAR(10),
                'apellido1: ', @apellido1, CHAR(10),
                'apellido2: ', @apellido2, CHAR(10),
                'email: ', @email, CHAR(10))
   
   SET @counter += 1

END

------------------------------
-------Segunda Opcion --------
------------------------------
GO
DECLARE @nombre VARCHAR(50),
        @apellido1 VARCHAR(50), 
        @apellido2 VARCHAR(50),
        @email VARCHAR(100),
        @codEmpleado INT

DECLARE Cur_GetDatosEmpleado CURSOR FOR
SELECT nombre,
       apellido1,
       apellido2,
       email,
       codEmpleado
  FROM EMPLEADOS

OPEN Cur_GetDatosEmpleado 
FETCH NEXT FROM Cur_GetDatosEmpleado INTO @nombre, @apellido1, @apellido2, @email, @codEmpleado

WHILE @@FETCH_STATUS = 0
BEGIN
  PRINT CONCAT('Datos del empleado ID-', @codEmpleado, CHAR(10),
                'nombre: ', @nombre, CHAR(10),
                'apellido1: ', @apellido1, CHAR(10),
                'apellido2: ', @apellido2, CHAR(10),
                'email: ', @email, CHAR(10))
  FETCH NEXT FROM Cur_GetDatosEmpleado INTO @nombre, @apellido1, @apellido2, @email, @codEmpleado

END

CLOSE Cur_GetDatosEmpleado
DEALLOCATE Cur_GetDatosEmpleado
/*
Ejercicio 05
*/
GO
DECLARE @codPedido INT

DECLARE Cur_Pedido CURSOR FOR
SELECT codPedido
  FROM PEDIDOS

OPEN Cur_Pedido 

FETCH NEXT FROM Cur_Pedido INTO @codPedido
WHILE @@FETCH_STATUS = 0
BEGIN
  -- Gestionamos el cursor secundario
  DECLARE @acumulado DECIMAL(12,2), @importe DECIMAL(11,2);
  SET @acumulado = 0;

  DECLARE Cur_DetallePedidos CURSOR FOR
   SELECT cantidad * precio_unidad
     FROM DETALLE_PEDIDOS
    WHERE codPedido = @codPedido;
  
  OPEN Cur_DetallePedidos;

  FETCH NEXT FROM Cur_DetallePedidos INTO @importe
  WHILE @@FETCH_STATUS = 0
  BEGIN
      SET @acumulado = @acumulado + @importe;
    FETCH NEXT FROM Cur_DetallePedidos INTO @importe;
  END

  CLOSE Cur_DetallePedidos
  DEALLOCATE Cur_DetallePedidos


  PRINT CONCAT('Nº Pedido', @codPedido , 'tiene un coste total de ', @acumulado, '€')

  FETCH NEXT FROM Cur_Pedido INTO @codPedido;
END

CLOSE Cur_Pedido
DEALLOCATE Cur_Pedido
