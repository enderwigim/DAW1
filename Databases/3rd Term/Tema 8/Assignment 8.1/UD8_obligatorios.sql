USE JARDINERIA

				---------------------------
				--   UD8  -  PROC & FUNC -- 
				---------------------------
-------------------------------------------------------------------------------------------
-- NOTA: Recuerda cuidar la limpieza del código (tabulaciones, nombres de tablas en mayúscula,
--		nombres de variables en minúscula, poner comentarios sin excederse, código organizado y fácil de seguir, etc.)
-------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------
-- 1. Implementa un procedimiento llamado 'getNombreCliente' que devuelva el nombre de un cliente a partir de su código.
--		Parámetros de entrada:  codCliente INT
--		Parámetros de salida:   nombreCliente VARCHAR(50)
--		Tabla:                  CLIENTES
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--      Recuerda utilizar en el script:
--              EXEC @ret = getNombreCliente @codCliente, @nombreCliente OUTPUT
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE getNombreCliente(@codCliente INT,
										   @nombreCliente VARCHAR(50) OUTPUT)
AS
BEGIN
	BEGIN TRY

	-- Validación de parametros.
	IF @codCliente IS NULL
	BEGIN
		 PRINT 'El parametro @codCliente no puede ser nulo'
		RETURN -1
	END

	SELECT @nombreCliente = nombre_cliente
	  FROM CLIENTES
	 WHERE codCliente = @codCliente

	-- Validamos que existe el cliente.
	IF @nombreCliente IS NULL
	BEGIN
		 PRINT 'Ese cliente no existe'
		RETURN -2
	END
	END TRY
	BEGIN CATCH
		PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
					 ', DESCRIPCION: ', ERROR_MESSAGE(),
				  	 ', LINEA: ', ERROR_LINE(),
					 ', PROCEDURE: ', ERROR_PROCEDURE())
	END CATCH

END
-------------------------------------------------------------------------------------------
GO
DECLARE @codCliente INT = 1;
DECLARE @nombreCliente VARCHAR(50);
DECLARE @ret INT;

EXEC @ret = getNombreCliente @codCliente, @nombreCliente OUTPUT

IF @ret <> 0
	RETURN

PRINT CONCAT('El nombre del cliente ', @codCliente, ' es ', @nombreCliente)




-------------------------------------------------------------------------------------------
-- 2. Implementa un procedimiento llamado 'getPedidosPagosCliente' que devuelva el número de pedidos y de pagos a partir de un código de cliente.
--		Parámetros de entrada:  codCliente INT
--		Parámetros de salida:   numPedidos INT
--                              numPagos INT
--		Tabla:                  CLIENTES
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--      Recuerda utilizar en el script:
--              EXEC @ret = getPedidosPagosCliente @codCliente, @numPedidos OUTPUT, @numPagos OUTPUT
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE getPedidosPagosCliente(@codCliente INT,
												 @numPedidos INT OUTPUT,
												 @numPagos INT OUTPUT)
AS
BEGIN
	BEGIN TRY

	-- Validación del @codCliente
	IF @codCliente IS NULL
	BEGIN
		 PRINT 'El parametro @codCliente no puede ser nulo'
		RETURN -1
	END
	IF NOT EXISTS (SELECT *
			         FROM CLIENTES
			        WHERE codCliente = @codCliente)
	BEGIN
		 PRINT 'El cliente no existe'
		RETURN -2
	END

	-- Obtenemos el numero de pagos.
	SELECT @numPagos = COUNT(id_transaccion)
      FROM PAGOS
     WHERE codCliente = @codCliente

	-- Obtenemos el numero de pedidos
	SELECT @numPedidos = COUNT(codPedido)
      FROM PEDIDOS
     WHERE codCliente = @codCliente

	END TRY

	BEGIN CATCH
		PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
					 ', DESCRIPCION: ', ERROR_MESSAGE(),
				  	 ', LINEA: ', ERROR_LINE(),
					 ', PROCEDURE: ', ERROR_PROCEDURE())
	END CATCH

END
-------------------------------------------------------------------------------------------
GO
DECLARE @codCliente INT = 20000;
DECLARE @numPagos INT;
DECLARE @numPedidos INT;
DECLARE @ret INT;

EXEC @ret = getPedidosPagosCliente @codCliente, @numPedidos OUTPUT, @numPagos OUTPUT

IF @ret <> 0
	RETURN

PRINT CONCAT('El cliente', @codCLiente ,' ha realizado ', @numPagos, ' pagos y ', @numPedidos, ' pedidos.')



-------------------------------------------------------------------------------------------
-- 3. Implementa un procedimiento llamado 'crearCategoriaProducto' que inserte una nueva categoría de producto en la base de datos JARDINERIA.
--		Parámetros de entrada: codCategoria CHAR(2),
--							   nombre VARCHAR(50),
--                             descripcion_texto VARCHAR(MAX), 
--                             descripcion_html VARCHAR(MAX),
--                             imagen VARCHAR(256)

--		Parámetros de salida: <ninguno>
--		Tabla: CATEGORIA_PRODUCTOS
--		
--		# Se debe comprobar que todos los parámetros obligatorios están informados. Si falta alguno, devolver -1 y finalizar.
--		# Se debe comprobar que la categoría no exista previamente en la tabla. Si ya existe, imprimir mensaje indicándolo, devolver -1 y finalizar.
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--      Recuerda utilizar en el script:
--              EXEC @ret = crearCategoriaProducto ...
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------
EXEC sp_help CATEGORIA_PRODUCTOS
GO
CREATE OR ALTER PROCEDURE crearCategoriaProducto(@codCategoria CHAR(2),
												 @nombre VARCHAR(50),
							 		   			 @descripcion_texto VARCHAR(100),
									   			 @descripcion_html VARCHAR(100),
									   			 @imagen VARCHAR(256))
AS
BEGIN
	BEGIN TRY
		-- Validamos los datos codCategoria, el cual es el unico que no tiene caracter Nulleable
		DECLARE @salida VARCHAR(MAX) = '';

		IF @codCategoria IS NULL
		BEGIN
			PRINT '@codCategoria'
		END

		IF @nombre IS NULL
		BEGIN
			PRINT '@nombre'
		END

		IF @salida <> ''
		BEGIN
			   SET @salida = 'Falta/n el/los parametro/s: ' + @salida
			 PRINT (LEFT(@salida, LEN(@salida) - 1))
			RETURN -1
		END

		IF @nombre = '' OR LEN(@nombre) < 3
		BEGIN
			PRINT 'El parametro @nombre no puede estar vacio, o contener menos de 3 caracteres.'
		END

		IF EXISTS (SELECT *
					 FROM CATEGORIA_PRODUCTOS
				    WHERE codCategoria = @codCategoria)
		BEGIN
			 PRINT 'El parametro @codCategoria ya existe.'
			RETURN -3
		END

		INSERT INTO CATEGORIA_PRODUCTOS(codCategoria, nombre, descripcion_texto,
										descripcion_html, imagen)
		VALUES(@codCategoria, @nombre, @descripcion_texto,
			   @descripcion_html, @imagen)

	END TRY
	BEGIN CATCH
		PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
					 ', DESCRIPCION: ', ERROR_MESSAGE(),
				  	 ', LINEA: ', ERROR_LINE(),
					 ', PROCEDURE: ', ERROR_PROCEDURE())
	END CATCH
END


-- Implementacion

GO

DECLARE @codCategoria CHAR(2) = 'BR'
DECLARE @nombre VARCHAR(50)
DECLARE @descripcion_texto VARCHAR(100)
DECLARE @descripcion_html VARCHAR(100)
DECLARE @imagen VARCHAR(256)
DECLARE @ret INT

EXEC @ret = crearCategoriaProducto @codCategoria, 
								   @nombre,
								   @descripcion_texto,
								   @descripcion_html,
								   @imagen

IF @ret <> 0
	RETURN

PRINT 'Categoria creada!'


-------------------------------------------------------------------------------------------
-- 4. Implementa un procedimiento llamado 'acuseRecepcionPedidosCliente' que actualice la fecha de entrega de los pedidos
--      a la fecha del momento actual y su estado a 'Entregado' para el codCliente pasado por parámetro y solo para los 
--      pedidos que estén en estado 'Pendiente' y no tengan fecha de entrega.

--		Parámetros de entrada: codCliente INT
--		Parámetros de salida:  numPedidosAct INT
--		Tabla: PEDIDOS

--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--
--      Ayuda: Recuerda utilizar:
--              EXEC @ret = acuseRecepcionPedidosCliente ...
--              IF @ret <> 0 ...
--
--	  * Ayuda para obtener el número de registros actualizados:
--		Se puede hacer una SELECT antes de ejecutar la sentencia de actualización o bien utilizar la variable @@ROWCOUNT
--
-------------------------------------------------------------------------------------------
USE JARDINERIA
GO
CREATE OR ALTER PROCEDURE acuseRecepcionPedidosCliente(@codCliente INT,
													   @numPedidosAct INT OUTPUT)
AS
BEGIN
	BEGIN TRY
		-- Validación de @codCliente
		IF @codCliente IS NULL
		BEGIN
 			 PRINT 'El parametro @codCliente no puede ser nulo'
			RETURN -1
		END

		IF NOT EXISTS (SELECT *
					     FROM CLIENTES
					    WHERE codCliente = @codCliente)
		BEGIN
			 PRINT 'El parametro @codCliente no existe en la base de datos'
			RETURN -2
		END

		UPDATE PEDIDOS
		   SET fecha_entrega = GETDATE(),
			   codEstado = 'E'
		 WHERE codCliente = @codCliente
		   AND fecha_entrega IS NULL
		   AND codEstado = 'P'
		
		SET @numPedidosAct = @@ROWCOUNT

		
		
	END TRY
	BEGIN CATCH
		PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
					 ', DESCRIPCION: ', ERROR_MESSAGE(),
				  	 ', LINEA: ', ERROR_LINE(),
					 ', PROCEDURE: ', ERROR_PROCEDURE())
	END CATCH
END


-- Implementación
GO
DECLARE @codCliente INT = 39
DECLARE @numPedidosAct INT;
DECLARE @ret INT;

EXEC @ret = acuseRecepcionPedidosCliente @codCliente, 
                                         @numPedidosAct OUTPUT

IF @ret <> 0
	RETURN
IF @numPedidosAct > 0
		PRINT 'Pedidos entregados'
	ELSE
		PRINT 'No habia pedidos a entregar'

-------------------------------------------------------------------------------------------
-- 5. Implementa un procedimiento llamado 'crearOficina' que inserte una nueva oficina en JARDINERIA.
--		Parámetros de entrada: codOficina CHAR(6)
--                             ciudad VARCHAR(40)
--                             pais VARCHAR(50)
--                             codigo_postal CHAR(5)
--                             telefono VARCHAR(15)
--                             linea_direccion1 VARCHAR(100)
--                             linea_direccion2 VARCHAR(100) (no obligatorio)

--		Parámetros de salida: <ninguno>
--		Tabla: OFICINAS
--		
--		# Se debe comprobar que todos los parámetros obligatorios están informados, sino devolver -1 y finalizar
--		# Se debe comprobar que el codOficina no exista previamente en la tabla, y si así fuera, 
--			imprimir un mensaje indicándolo y se devolverá -1
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--
--      Ayuda: Recuerda utilizar:
--              EXEC @ret = crearOficina ...
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE crearOficina  @codOficina CHAR(6),
                             			@ciudad VARCHAR(40),
                             			@pais VARCHAR(50),
                             		    @codigo_postal CHAR(5),
                             		    @telefono VARCHAR(15),
                             			@linea_direccion1 VARCHAR(100),
                             			@linea_direccion2 VARCHAR(100)
AS
BEGIN
	BEGIN TRY
		DECLARE @salida VARCHAR(MAX) = '';
		-- Validamos en caso de que sea nulo.
		IF @codOficina IS NULL
			SET @salida += '@codOficina, '
		IF @ciudad IS NULL
			SET @salida += '@ciudad, '
		IF @pais IS NULL
			SET @salida += '@pais, '
		IF @codigo_postal IS NULL
			SET @salida += '@codigo_postal, '
		IF @telefono IS NULL
			SET @salida += '@telefono, '
		IF @linea_direccion1 IS NULL
			SET @salida += '@linea_direccion1, '

		IF @salida <> ''
		BEGIN
				   SET @salida = 'Falta/n el/los parametro/s: ' + @salida
				 PRINT (LEFT(@salida, LEN(@salida) - 1))
				RETURN -1
		END

		-- Validamos si la PK existe
		IF EXISTS (SELECT *
					 FROM OFICINAS
					WHERE codOficina = @codOficina)
		BEGIN
			 PRINT '@codOficina ya existe'
			RETURN -1
		END

		INSERT INTO OFICINAS(codOficina, ciudad, pais,
							codPostal, telefono, linea_direccion1,
							linea_direccion2)
		VALUES (@codOficina, @ciudad, @pais,
				@codigo_postal, @telefono, @linea_direccion1,
				@linea_direccion2)
	END TRY

	BEGIN CATCH
		PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
					 ', DESCRIPCION: ', ERROR_MESSAGE(),
				  	 ', LINEA: ', ERROR_LINE(),
					 ', PROCEDURE: ', ERROR_PROCEDURE())
	END CATCH
END


--Implementación
GO
DECLARE @codOficina CHAR(6) = 'BS-AR'
DECLARE @ciudad VARCHAR(40) = 'Buenos Aires'
DECLARE @pais VARCHAR(50) = 'Argentina'
DECLARE @codigo_postal CHAR(5) = '1810'
DECLARE @telefono VARCHAR(15) = '1167617915'
DECLARE @linea_direccion1 VARCHAR(100) = 'Plaza 25 de Mayo'
DECLARE @linea_direccion2 VARCHAR(100)
DECLARE @ret INT

EXEC @ret = crearOficina @codOficina,
						 @ciudad,
						 @pais,
						 @codigo_postal,
						 @telefono,
						 @linea_direccion1,
						 @linea_direccion2
IF @ret <> 0
	RETURN
PRINT 'Oficina Creada!'


-------------------------------------------------------------------------------------------
-- 6. Implementa un procedimiento llamado 'cambioJefes' que actualice el jefe/a de los empleados/as del
--      que tuvieran inicialmente (ant_codEmplJefe) al nuevo/a (des_codEmplJefe)
--    NOTA: Es un proceso que ocurre si alguien asciende de categoría.

--		Parámetros de entrada: ant_codEmplJefe INT
--                             des_codEmplJefe INT

--		Parámetros de salida: numEmpleados INT (número de empleados que han actualizado su jefe)
--		Tabla: EMPLEADOS

--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--
--      Ayuda: Recuerda utilizar:
--              EXEC @ret = cambioJefes ...
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------
GO
-- Version 1 CON NULL
CREATE OR ALTER PROCEDURE cambioJefe @ant_codEmplJefe INT,
									 @des_codEmplJefe INT,
									 @reemplazaJefeSN CHAR(1),
									 @numEmpleados INT OUTPUT
AS
BEGIN
	BEGIN TRY
		-- Validación sobre los parametros.
		-- Si existen los paramentros.
		DECLARE @codEmplJefeNotExists VARCHAR(MAX) = ''

		IF NOT EXISTS (SELECT *
						 FROM EMPLEADOS
						WHERE codEmpleado = @ant_codEmplJefe)
			SET @codEmplJefeNotExists += CONCAT(@ant_codEmplJefe, ', ')

		IF NOT EXISTS (SELECT *
						 FROM EMPLEADOS
						WHERE codEmpleado = @des_codEmplJefe)
			SET @codEmplJefeNotExists += CONCAT(@des_codEmplJefe, ', ')
		
		IF @codEmplJefeNotExists <> ''
		BEGIN
			   SET @codEmplJefeNotExists = 'Falta/n el/los parametro/s: ' + @codEmplJefeNotExists
			 PRINT (LEFT(@codEmplJefeNotExists, LEN(@codEmplJefeNotExists) - 1))
			RETURN -1
		END

		IF NOT EXISTS (SELECT *
						 FROM EMPLEADOS
						WHERE codEmplJefe = @ant_codEmplJefe)
		BEGIN
			 PRINT 'Ese empleado no es jefe de nadie.'
			RETURN -2
		END

		BEGIN TRAN
			IF LOWER(@reemplazaJefeSN) = 's'
			BEGIN
				UPDATE EMPLEADOS
				   SET codEmplJefe = NULL
				 WHERE codEmpleado = @des_codEmplJefe
				
				SET @numEmpleados = @@ROWCOUNT

				UPDATE EMPLEADOS
				   SET codEmplJefe = @des_codEmplJefe
				 WHERE codEmpleado = @ant_codEmplJefe 
				
				SET @numEmpleados += @@ROWCOUNT
			END
			ELSE
			BEGIN
				UPDATE EMPLEADOS
				   SET codEmplJefe = NULL
				 WHERE codEmpleado = @des_codEmplJefe
				
				SET @numEmpleados = @@ROWCOUNT
			END

			UPDATE EMPLEADOS
			   SET codEmplJefe = @des_codEmplJefe
			 WHERE codEmplJefe = @ant_codEmplJefe
			
			SET @numEmpleados += @@ROWCOUNT;

			COMMIT

	END TRY
	BEGIN CATCH 
		ROLLBACK
		PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
					 ', DESCRIPCION: ', ERROR_MESSAGE(),
				  	 ', LINEA: ', ERROR_LINE(),
					 ', PROCEDURE: ', ERROR_PROCEDURE())
	END CATCH
END

-- Implementación 
GO
DECLARE @ret INT
DECLARE @ant_codEmplJefe INT = 1
DECLARE @des_codEmplJefe INT = 7;
DECLARE @reemplazaJefeSN CHAR(1) = 'N';
DECLARE @numEmpleados INT

EXEC @ret = cambioJefe @ant_codEmplJefe,
					   @des_codEmplJefe,
					   @reemplazaJefeSN,
					   @numEmpleados OUTPUT

IF @ret <> 0
	RETURN


PRINT CONCAT(@numEmpleados, ' empleados han sidos actualizado');

--Versión sin NULL

GO
CREATE OR ALTER PROCEDURE cambioJefe @ant_codEmplJefe INT,
									 @des_codEmplJefe INT,
									 @reemplazaJefeSN CHAR(1),
									 @numEmpleados INT OUTPUT
AS
BEGIN
	BEGIN TRY
		-- Validación sobre los parametros.
		-- Si existen los paramentros.
		DECLARE @codEmplJefeNotExists VARCHAR(MAX) = ''

		IF NOT EXISTS (SELECT *
						FROM EMPLEADOS
						WHERE codEmpleado = @ant_codEmplJefe)
			SET @codEmplJefeNotExists += CONCAT(@ant_codEmplJefe, ', ')

		IF NOT EXISTS (SELECT *
						FROM EMPLEADOS
						WHERE codEmpleado = @des_codEmplJefe)
			SET @codEmplJefeNotExists += CONCAT(@des_codEmplJefe, ', ')
		
		IF @codEmplJefeNotExists <> ''
		BEGIN
			SET @codEmplJefeNotExists = 'Falta/n el/los parametro/s: ' + @codEmplJefeNotExists
			PRINT (LEFT(@codEmplJefeNotExists, LEN(@codEmplJefeNotExists) - 1))
			RETURN -1
		END

		IF NOT EXISTS (SELECT *
						FROM EMPLEADOS
						WHERE codEmplJefe = @ant_codEmplJefe)
		BEGIN
			PRINT 'Ese empleado no es jefe de nadie.'
			RETURN -2
		END

		BEGIN TRAN
			IF LOWER(@reemplazaJefeSN) = 's'
			BEGIN
				UPDATE EMPLEADOS
				SET codEmplJefe = codEmpleado
				WHERE codEmpleado = @des_codEmplJefe
				
				SET @numEmpleados = @@ROWCOUNT

				UPDATE EMPLEADOS
				SET codEmplJefe = @des_codEmplJefe
				WHERE codEmpleado = @ant_codEmplJefe 
				
				SET @numEmpleados += @@ROWCOUNT
			END
			ELSE
			BEGIN
				UPDATE EMPLEADOS
				SET codEmplJefe = codEmpleado
				WHERE codEmpleado = @des_codEmplJefe
				
				SET @numEmpleados = @@ROWCOUNT
			END

			UPDATE EMPLEADOS
			SET codEmplJefe = @des_codEmplJefe
			WHERE codEmplJefe = @ant_codEmplJefe
			SET @numEmpleados += @@ROWCOUNT;
			
			COMMIT

	END TRY
	BEGIN CATCH 
		ROLLBACK
		PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
					 ', DESCRIPCION: ', ERROR_MESSAGE(),
				  	 ', LINEA: ', ERROR_LINE(),
					 ', PROCEDURE: ', ERROR_PROCEDURE())
	END CATCH
END

-- Implementación 
GO
DECLARE @ret INT
DECLARE @ant_codEmplJefe INT = 1
DECLARE @des_codEmplJefe INT = 7;
DECLARE @reemplazaJefeSN CHAR(1) = 'N';
DECLARE @numEmpleados INT

EXEC @ret = cambioJefe @ant_codEmplJefe,
					   @des_codEmplJefe,
					   @reemplazaJefeSN,
					   @numEmpleados OUTPUT

IF @ret <> 0
	RETURN


PRINT CONCAT(@numEmpleados, ' empleados han sido actualizados');

-------------------------------------------------------------------------------------------
-- 7. Implementa una función llamada getCostePedidos que reciba como parámetro un codCliente y devuelva
--		el coste de todos los pedidos realizados por dicho cliente.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO


GO
CREATE OR ALTER FUNCTION getCostePedido(@codPedido INT)
RETURNS DECIMAL(11,2)
AS
BEGIN
	RETURN (SELECT ISNULL(SUM(cantidad*precio_unidad), 0)
	          FROM DETALLE_PEDIDOS
			 WHERE codPedido = @codPedido)
END

GO

CREATE OR ALTER FUNCTION getCostePedidos(@codCLiente INT)
RETURNS DECIMAL(11,2)
AS
BEGIN	
	RETURN (SELECT SUM(dbo.getCostePedido(codPedido))
	  	      FROM PEDIDOS
	 		 WHERE codCliente = @codCLiente)
	
END
GO
DECLARE @codCliente INT = 9
SELECT dbo.getCostePedidos(@codCLiente);




-------------------------------------------------------------------------------------------
-- 8. Implementa una función llamada numEmpleadosOfic que reciba como parámetro un codOficina y devuelva
--		el número de empleados que trabajan en ella
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER FUNCTION numEmpleadosOfic(@codOficina CHAR(6))
RETURNS DECIMAL(4,0)
AS
BEGIN
	-- Revisamos si la oficina existe. Sino devolverá nulo.
	IF NOT EXISTS(SELECT *
	                FROM OFICINAS
				   WHERE codOficina = @codOficina)
		RETURN NULL
	RETURN (SELECT COUNT(codEmpleado)
	          FROM EMPLEADOS
	         WHERE codOficina = @codOficina)
END

--Implementación
GO
DECLARE @codOficina CHAR(6) = 'VAL-ES'
SELECT dbo.numEmpleadosOfic(@codOficina)



-------------------------------------------------------------------------------------------
-- 9. Implementa una función llamada clientePagos_SN que reciba como parámetro un codCliente y devuelva
--		'S' si ha realizado pagos y 'N' si no ha realizado ningún pago.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER FUNCTION clientePagos_SN(@codCliente INT)
RETURNS CHAR(1)
AS
BEGIN
	-- Revisamos si el cliente existe
	IF NOT EXISTS (SELECT *
	                 FROM CLIENTES
					WHERE codCliente = @codCliente)
		RETURN NULL
	-- En caso de que exista. Revisamos si tiene pagos o no.
	IF EXISTS(SELECT *
	            FROM PAGOS
	           WHERE codCliente = @codCliente)
		RETURN 'S'
	RETURN 'N'
END

-- Implementación
GO
DECLARE @codCliente INT = 2;
SELECT dbo.clientePagos_SN(@codCliente)


-------------------------------------------------------------------------------------------
-- 10. Implementa una función llamada pedidosPendientesAnyo que reciba como parámetros 'estado' y 'anyo'
--	    y devuelva una TABLA con los pedidos pendientes del año 2009 (estos datos deben ponerse directamente en la SELECT, NO son dinámicos)

--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER FUNCTION pedidosPendientesAnyo (@codEstado CHAR(1),
                                                @anyo CHAR(4))
RETURNS TABLE
AS
	RETURN SELECT *
	         FROM PEDIDOS
	        WHERE codEstado = @codEstado
	          AND @anyo = YEAR(fecha_pedido)


-- Implementación
GO
SELECT *
  FROM dbo.pedidosPendientesAnyo('P', '2009')