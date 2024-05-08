CREATE DATABASE EJERCICIO1
GO
USE EJERCICIO1
GO

CREATE TABLE LIBROS(
    ISBN CHAR(13) NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    precio DECIMAL(4,2)
    CONSTRAINT PK_LIBROS PRIMARY KEY (ISBN)
)
GO
CREATE TABLE SOCIOS(
    DNI CHAR(10) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    ciudad VARCHAR(100) NOT NULL
    CONSTRAINT PK_SOCIOS PRIMARY KEY (DNI)
)
GO
CREATE TABLE PRESTAMOS(
    idPrestamo    INT,
    fechaPrestamo SMALLDATETIME NOT NULL,
    fechaDevol    SMALLDATETIME,
    ISBN          CHAR(13) NOT NULL,
    DNI           CHAR(10) NOT NULL
    CONSTRAINT PK_idPrestamo PRIMARY KEY (idPrestamo),
    CONSTRAINT FK_PRESTAMOS_LIBROS FOREIGN KEY (ISBN)
    REFERENCES LIBROS(ISBN),
    CONSTRAINT FK_PRESTAMOS_SOCIOS FOREIGN KEY (DNI)
    REFERENCES SOCIOS(DNI)
) 
GO
CREATE TABLE LIBROS_PERDIDOS(
    ISBN CHAR(13) NOT NULL,
    DNI CHAR(10) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    fechaBaja DATE NOT NULL
)
-- Insertamos datos de la tabla LIBROS
INSERT INTO LIBROS (ISBN, titulo, precio) 
VALUES ('9780521597180', 'El nombre del viento', 25.99);
INSERT INTO LIBROS (ISBN, titulo, precio) 
VALUES ('9780307743657', 'Ready Player One', 20.50);
INSERT INTO LIBROS (ISBN, titulo, precio) 
VALUES ('9788413140066', 'Cien años de soledad', 18.75);

-- Insertamos datos de la tabla SOCIOS
INSERT INTO SOCIOS (DNI, nombre, ciudad)
VALUES ('1234567890', 'Juan Pérez', 'Madrid');
INSERT INTO SOCIOS (DNI, nombre, ciudad) 
VALUES ('9876543210', 'María López', 'Barcelona');
INSERT INTO SOCIOS (DNI, nombre, ciudad)
VALUES ('1357924680', 'Carlos Martínez', 'Sevilla');

-- Insertamos datos de la tabla PRESTAMOS
INSERT INTO PRESTAMOS (idPrestamo, ISBN, DNI, fechaPrestamo, fechaDevol) 
VALUES (1, '9780521597180', '1234567890', '2024-04-15', NULL);
INSERT INTO PRESTAMOS (idPrestamo, ISBN, DNI, fechaPrestamo, fechaDevol) 
VALUES (2, '9780307743657', '9876543210', '2024-04-20', NULL);
INSERT INTO PRESTAMOS (idPrestamo, ISBN, DNI, fechaPrestamo, fechaDevol) 
VALUES (10, '9788413140066', '9876543210', '2024-04-25', '2024-05-05');


-- Creamos una tabla de socios historicos.
GO
SELECT *
  INTO SOCIOS_HISTORICO
  FROM SOCIOS
 WHERE 1 = 0
GO

CREATE OR ALTER TRIGGER TX_SOCIOS ON SOCIOS
INSTEAD OF DELETE
AS
BEGIN 
    BEGIN TRY
    -- Declaramos una variable que nos permita revisar
    -- Si hay transacciones abiertas.
    DECLARE @tranOpen BIT = 1;
    IF @@TRANCOUNT = 0
        SET @tranOpen = 0;
    -- Si no hay transacciones abiertas
    IF @tranOpen = 0
        BEGIN TRAN

    -- Insertamos en SOCIO_HISTORICO
    INSERT INTO SOCIOS_HISTORICO
    SELECT *
      FROM DELETED
    -- INSERTAMOS EN LIBROS_PERDIDOS AQUELLOS LIBROS QUE 
    -- SE ENCUENTREN PRESTADOS AL SOCIO ELIMINADO.
    INSERT INTO LIBROS_PERDIDOS
    SELECT p.ISBN,
           p.DNI, 
           s.nombre,
           GETDATE()
      FROM PRESTAMOS p,
           SOCIOS s,
           DELETED d
     WHERE p.DNI = s.DNI
       AND p.DNI = d.DNI
       AND p.fechaDevol IS NULL

    -- Borramos prestamos en los que el DNI se encuentre en
    -- DELETED
    DELETE FROM PRESTAMOS
     WHERE DNI IN (SELECT DNI
                     FROM DELETED)
    -- Borramos los socios
    DELETE FROM SOCIOS
     WHERE DNI IN (SELECT DNI
                     FROM DELETED)
    
    -- Si solo existe la transacción creada al inicio. COMMIT
    IF @tranOpen = 0
        COMMIT

    END TRY
    BEGIN CATCH
        PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
                    ', DESCRIPCION: ', ERROR_MESSAGE(),
                    ', LINEA: ', ERROR_LINE(),
                    ', PROCEDURE: ', ERROR_PROCEDURE())
        -- Si solo existe la transacción creada al inicio. ROLLBACK
        IF @tranOpen = 0
        ROLLBACK
    END CATCH


END

-- Verificación
BEGIN TRAN
BEGIN TRY
  DELETE FROM SOCIOS
    WHERE DNI = '9876543210'
       OR DNI = '1234567890'
    COMMIT
END TRY
BEGIN CATCH
    ROLLBACK
END CATCH

SELECT *
  FROM LIBROS_PERDIDOS


/*
 _________________________________________________
/             SERVICIO TÉCNICO TRIGGER             \
|                                                  |
|  Descripción:                                    |
|  Crear un disparador para que cuando demos de    |
|  baja un Técnico se compruebe si la suma del     |
|  importe de las reparaciones de este técnico     |
|  es mayor que 2500 €, y si lo cumple, guardaremos|
|  sus datos personales en una tabla llamada       |
|  TECNICOS_RESERVA con la misma estructura que    |
|  la tabla TECNICOS más un campo FechaBaja        |
|  (con la fecha en la que se realiza la baja,     |
|  que será la fecha del sistema).                 |
\__________________________________________________/
*/
CREATE DATABASE EJERCICIO2
GO
USE EJERCICIO2
GO
CREATE TABLE TECNICOS (
    DNI CHAR(10) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    ciudad VARCHAR(100) NOT NULL,
    salario DECIMAL(8,2) NOT NULL,
    CONSTRAINT PK_TECNICOS PRIMARY KEY (DNI)
)
GO
CREATE TABLE REPARACIONES(
    idReparacion INT NOT NULL,
    fecha SMALLDATETIME NOT NULL,
    DNI_tecnico CHAR(10) NOT NULL,
    concepto VARCHAR(1000) NOT NULL,
    importe DECIMAL(8,2) NOT NULL,
    CONSTRAINT PK_REPARACIONES PRIMARY KEY (idReparacion),
    CONSTRAINT FK_REPARACIONES_TECNICOS FOREIGN KEY (DNI_tecnico)
    REFERENCES TECNICOS(DNI)
    )

-- Creamos la tabla TECNICOS_RESERVA
SELECT *
  INTO TECNICOS_RESERVA
  FROM TECNICOS
WHERE 1 = 0
-- La alteramos para agregar el campo
ALTER TABLE TECNICOS_RESERVA
  ADD FechaBaja SMALLDATETIME

-- Creamos una tabla de REPARACIONES_HISTORICO
SELECT *
  INTO REPARACIONES_HISTORICO
  FROM REPARACIONES
WHERE 1 = 0

-- Insertamos los siguientes datos:
INSERT INTO TECNICOS (DNI, nombre, ciudad, salario) 
VALUES 
('87654321X', 'Juan Pérez', 'Madrid', 2500.00),
('12345678Z', 'María García', 'Barcelona', 2700.00),
('98765432Y', 'Pedro Rodríguez', 'Valencia', 2600.00);

-- Insertar datos de las reparaciones para el técnico Juan Pérez
INSERT INTO REPARACIONES (idReparacion, fecha, DNI_tecnico, concepto, importe) 
VALUES 
(1, '2024-05-01 08:00:00', '87654321X', 'Reparación de ordenador portátil', 120.00),
(2, '2024-05-02 10:30:00', '87654321X', 'Reparación de impresora', 80.00),
(3, '2024-05-03 13:45:00', '87654321X', 'Reparación de teléfono móvil', 90.00);

-- Insertar datos de las reparaciones para la técnica María García
INSERT INTO REPARACIONES (idReparacion, fecha, DNI_tecnico, concepto, importe) 
VALUES 
(4, '2024-05-01 09:15:00', '12345678Z', 'Reparación de televisión', 200.00),
(5, '2024-05-02 11:00:00', '12345678Z', 'Reparación de lavadora', 15000.00),
(6, '2024-05-03 14:30:00', '12345678Z', 'Reparación de frigorífico', 180.00);

-- Insertar datos de las reparaciones para el técnico Pedro Rodríguez
INSERT INTO REPARACIONES (idReparacion, fecha, DNI_tecnico, concepto, importe) 
VALUES 
(7, '2024-05-01 10:00:00', '98765432Y', 'Reparación de aire acondicionado', 300.00),
(8, '2024-05-02 12:00:00', '98765432Y', 'Reparación de calentador', 250.00),
(9, '2024-05-03 15:00:00', '98765432Y', 'Reparación de secadora', 18000.00);





GO
-- Creamos el TRIGGER
CREATE OR ALTER TRIGGER TX_TECNICOS ON TECNICOS
INSTEAD OF DELETE
AS
BEGIN
    BEGIN TRY
        -- Declaramos una variable para saber si hay un TRAN abierto
        DECLARE @tranOpen BIT = 1;
        IF @@TRANCOUNT = 0
            SET @tranOpen = 0

        -- Revisamos que no haya transacciones abiertas
        IF @tranOpen = 0
            BEGIN TRAN

        -- Guardamos los tecnicos que hayan superado 2500 euros en reparaciones.
        INSERT INTO TECNICOS_RESERVA
        SELECT DELETED.*,
               GETDATE()
          FROM DELETED
         WHERE DNI IN (SELECT DNI_tecnico
                         FROM REPARACIONES
                        GROUP BY DNI_tecnico
                       HAVING SUM(importe) > 2500)
        
        -- Tambien guardamos las reparaciones en las que hayan aparecido esos tecnicos.
        INSERT INTO REPARACIONES_HISTORICO
        SELECT r.*
        FROM REPARACIONES r,
            DELETED del
        WHERE del.DNI = r.DNI_tecnico

        -- Realizamos un borrado en cascada.
        DELETE FROM REPARACIONES
        WHERE DNI_tecnico IN (SELECT DNI
                                FROM DELETED)

        DELETE FROM TECNICOS
        WHERE DNI IN (SELECT DNI
                        FROM DELETED)
        IF @tranOpen = 0
            COMMIT

        END TRY
        BEGIN CATCH
            PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
                    ', DESCRIPCION: ', ERROR_MESSAGE(),
                    ', LINEA: ', ERROR_LINE(),
                    ', PROCEDURE: ', ERROR_PROCEDURE())
            -- Si solo existe la transacción creada al inicio. ROLLBACK
            IF @tranOpen = 0
            ROLLBACK
        END CATCH
END

-- Validaciones
BEGIN TRAN
BEGIN TRY
  DELETE FROM TECNICOS
    WHERE DNI = '87654321X'
       OR DNI = '98765432Y'
    COMMIT
END TRY
BEGIN CATCH
    ROLLBACK
END CATCH

SELECT *
  FROM TECNICOS_RESERVA

SELECT *
  FROM REPARACIONES_HISTORICO

SELECT * 
  FROM REPARACIONES
  
GO
USE master 
DROP DATABASE EJERCICIO2 
/*
 _______________________________________________________________
/--           Crear un disparador para que cuando demos de baja  --\
|             un Proveedor se realice lo siguiente:               |
|                                                                 |
|  - Comprobar si ese proveedor suministra algún artículo cuyo    |
|    Stock sea igual a 0, y si es así, que añada a la tabla      |
|    ARTICULOS_INEXISTENTES esos artículos (la tabla              |
|    ARTICULOS_INEXISTENTES tendrá los mismos campos que la tabla |
|    ARTICULOS más la fecha de inserción (fecha del sistema) y el |
|    nombre del proveedor que se da de baja).                    |
\_________________________________________________________________/
*/

USE master
CREATE DATABASE EJERCICIO3
GO
USE EJERCICIO3

GO
CREATE TABLE ALMACENES(
  codAlmacen INT NOT NULL,
  descripcion VARCHAR(1000) NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  ciudad VARCHAR(100) NOT NULL
  CONSTRAINT PK_ALMACENES PRIMARY KEY (codAlmacen)
)
CREATE TABLE PROVEEDORES(
  codProveedor INT NOT NULL,
  nombre VARCHAR(100) NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  ciudad VARCHAR(100) NOT NULL,
  deuda DECIMAL(9,2) NOT NULL,
  tipo CHAR(2) NOT NULL
  CONSTRAINT PK_PROVEEDORES PRIMARY KEY (codProveedor)
  CONSTRAINT DEFAULT_TIPO DEFAULT 'MI'
)
CREATE TABLE ARTICULOS(
  codArticulo INT NOT NULL,
  nombre VARCHAR(100) NOT NULL,
  stock DECIMAL(7,0) NOT NULL,
  pvp DECIMAL(9,2) NOT NULL,
  precio_compra DECIMAL(9,2) NOT NULL,
  codAlmacen INT NOT NULL,
  codProveedor INT NOT NULL,
  CONSTRAINT PK_ARTICULOS PRIMARY KEY (codArticulo),
  CONSTRAINT FK_ARTICULOS_PROVEEDORES FOREIGN KEY (codProveedor)
  REFERENCES PROVEEDORES(codProveedor),
  CONSTRAINT FK_ARTICULOS_ALMACENES FOREIGN KEY (codAlmacen)
  REFERENCES ALMACENES(codAlmacen)
)

SELECT *
  INTO ARTICULOS_INEXISTENTES
  FROM ARTICULOS
 WHERE 1 = 0

ALTER TABLE ARTICULOS_INEXISTENTES
  ADD fechaInsercion  DATE,
      nombreProveedor VARCHAR(100)

GO
CREATE OR ALTER TRIGGER TX_PROVEEDORES ON PROVEEDORES
INSTEAD OF DELETE
AS
BEGIN
  
END