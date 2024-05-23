/*
1.- Disparador BIBILIOTECA
Necesitamos crear un trigger para cuando demos de baja un Socio en la biblioteca.
Deberemos comprobar si éste tiene algún libro sin devolver (fecha devolución nula), en caso 
de ser así, que inserte un registro en la tabla LIBROS_PERDIDOS (ISBN, DNI, nombre, 
fechaBaja), donde el campo fechaBaja corresponde con la fecha del sistema que tenga en 
ese momento el ordenador.

TABLAS NECESARIAS

LIBROS (ISBN, título, precio)
PK: ISBN

SOCIOS (DNI, nombre, ciudad)
PK: DNI

PRESTAMOS (idPrestamo, ISBN, DNI, FechaPrestamo, FechaDevol)
PK: idPrestamo
FK: ISBN → LIBROS
FK: DNI → SOCIOS
*/
GO
CREATE DATABASE BIBLIOTECA2
GO
USE BIBLIOTECA2

GO
CREATE TABLE LIBROS(
    ISBN CHAR(13),
    titulo VARCHAR(100) NOT NULL,
    precio DECIMAL(9,2) NOT NULL
    CONSTRAINT PK_LIBROS PRIMARY KEY (ISBN)
)
GO
CREATE TABLE SOCIOS (
    DNI CHAR(10),
    nombre VARCHAR(100) NOT NULL,
    ciudad VARCHAR(100)
    CONSTRAINT PK_SOCIOS PRIMARY KEY (DNI)
)
GO
CREATE TABLE PRESTAMOS(
    idPrestamo INT,
    ISBN CHAR(13),
    DNI CHAR(10),
    FechaPrestamo DATE,
    FechaDevol DATE
    CONSTRAINT PK_PRESTAMOS PRIMARY KEY (idPrestamo),
    CONSTRAINT FK_PRESTAMOS_LIBROS FOREIGN KEY (ISBN)
    REFERENCES LIBROS(ISBN),
    CONSTRAINT FK_PRESTAMOS_SOCIOS FOREIGN KEY (DNI)
    REFERENCES SOCIOS(DNI)
)
GO
CREATE TABLE LIBROS_PERDIDOS(
    ISBN CHAR(13), 
    DNI CHAR(10),
    nombre VARCHAR(100), 
    fechaBaja DATE
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

/*
1.- Disparador BIBILIOTECA
Necesitamos crear un trigger para cuando demos de baja un Socio en la biblioteca.
Deberemos comprobar si éste tiene algún libro sin devolver (fecha devolución nula), en caso 
de ser así, que inserte un registro en la tabla LIBROS_PERDIDOS (ISBN, DNI, nombre, 
fechaBaja), donde el campo fechaBaja corresponde con la fecha del sistema que tenga en 
ese momento el ordenador.
*/
GO
CREATE OR ALTER TRIGGER TX_SOCIOS ON SOCIOS
INSTEAD OF DELETE
AS
BEGIN
    BEGIN TRY
        -- Declaramos una variable que nos sirve para mirar si la transaccion esta abierta.
        -- 1 significará que ya habia una abierta
        DECLARE @tranOpen BIT = 1;
        -- Si el contador de transacción es 1 o mas que 1.
        IF @@TRANCOUNT = 0
            SET @tranOpen = 0
        
        --Si no hay transacción abierta, la abriremos.
        IF @tranOpen = 0
            BEGIN TRAN

        -- Insertamos los libros perdidos
        INSERT INTO LIBROS_PERDIDOS
        SELECT p.ISBN, 
               d.DNI, 
               d.nombre,
               GETDATE()
        FROM PRESTAMOS p,
             DELETED d
        WHERE d.DNI = p.DNI
        AND p.FechaDevol IS NULL
        -- Borramos los prestamos
        DELETE FROM PRESTAMOS
         WHERE DNI IN (SELECT DNI
                         FROM DELETED)
        -- Borramos los socios
        DELETE FROM SOCIOS
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
        IF @tranOpen = 0
            ROLLBACK
    END CATCH
END



  DELETE FROM SOCIOS
    WHERE DNI = '9876543210'
       OR DNI = '1234567890'
GO
USE master
GO
DROP DATABASE BIBLIOTECA2


GO
/*
Disparador SERVICIO TECNICO
Crear un disparador para que cuando demos de baja un Técnico se compruebe si la suma
del importe de las reparaciones de este técnico es mayor que 2500 €, y si lo cumple,
guardaremos sus datos personales en una tabla llamada TECNICOS_RESERVA con la
misma estructura que la tabla TECNICOS más un campo FechaBaja (con la fecha en la que
se realiza la baja, que será la fecha del sistema).
TABLAS NECESARIAS
TECNICOS (DNI, nombre, ciudad, salario)
PK: DNI
REPARACIONES (idReparacion, fecha, DNI_tecnico, concepto, importe)
PK: idReparacion
FK: DNI_tecnico → TECNICOS
*/
USE MASTER
CREATE DATABASE SERVICIOTECNICO
GO
USE SERVICIOTECNICO
GO
CREATE TABLE TECNICOS(
    DNI CHAR(10),
    nombre VARCHAR(100) NOT NULL,
    ciudad VARCHAR(100) NOT NULL,
    salario DECIMAL(7,2) NOT NULL,
    CONSTRAINT PK_TECNICOS PRIMARY KEY (DNI)
)
GO
CREATE TABLE REPARACIONES(
    idReparacion INT,
    fecha DATE NOT NULL,
    DNI_tecnico CHAR(10),
    concepto VARCHAR(200),
    importe DECIMAL(7,2) NOT NULL,
    CONSTRAINT PK_REPARACIONES PRIMARY KEY (idReparacion),
    CONSTRAINT FK_REPARACIONES_TECNICOS FOREIGN KEY (DNI_tecnico)
    REFERENCES TECNICOS(DNI)
)
-- Creamos la tabla tecnicos reserva
SELECT *
  INTO TECNICOS_RESERVA
  FROM TECNICOS

ALTER TABLE TECNICOS_RESERVA
  ADD fecha_baja DATE

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


/*
Crear un disparador para que cuando demos de baja un Técnico se compruebe si la suma
del importe de las reparaciones de este técnico es mayor que 2500 €, y si lo cumple,
guardaremos sus datos personales en una tabla llamada TECNICOS_RESERVA con la
misma estructura que la tabla TECNICOS más un campo FechaBaja (con la fecha en la que
se realiza la baja, que será la fecha del sistema).
*/
GO
CREATE OR ALTER TRIGGER TX_TECNICOS ON TECNICOS
INSTEAD OF DELETE
AS
BEGIN
    BEGIN TRY
        DECLARE @openTran BIT = 1;
        IF @@TRANCOUNT = 0
            SET @openTran = 0

        IF @openTran = 0
            BEGIN TRAN
        -- Seleccionamos los Datos de los tecnicos que hayan realizado al menos
        -- una sumatoria de importes mayor a 2500
        INSERT INTO TECNICOS_RESERVA(DNI, nombre, ciudad, salario, fecha_baja)
        SELECT DELETED.*, 
               GETDATE()
          FROM DELETED
         WHERE DNI IN (SELECT DNI_tecnico
                           FROM REPARACIONES
                          GROUP BY DNI_tecnico
                          HAVING SUM(importe) >= 2500)

        -- Realizamos un borrado en casacada
        DELETE FROM REPARACIONES
         WHERE DNI_tecnico IN (SELECT DNI
                                 FROM DELETED);

        DELETE FROM TECNICOS
         WHERE DNI IN (SELECT DNI
                         FROM DELETED);
        IF @openTran = 0
            COMMIT
        
    END TRY
    BEGIN CATCH
        PRINT CONCAT('ERROR: ', ERROR_MESSAGE(),
                     'LINE: ', ERROR_LINE(),
                     'PROCEDURE: ', ERROR_PROCEDURE(),
                     'NUMBER: ', ERROR_NUMBER())
        IF @openTran = 0
           ROLLBACK

    END CATCH
END


-- Validación
BEGIN TRY
    BEGIN TRAN
    DELETE FROM TECNICOS
     WHERE DNI = '12345678Z'
       AND DNI = '87654321X'
    COMMIT
END TRY
BEGIN CATCH
    ROLLBACK
END CATCH

SELECT *
  FROM TECNICOS

GO
USE master
DROP DATABASE SERVICIOTECNICO


/*

*/