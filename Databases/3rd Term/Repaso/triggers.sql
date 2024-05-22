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

USE master
GO
DROP DATABASE BIBLIOTECA2