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
    idPrestamo    INT ,
    ISBN          CHAR(13) NOT NULL,
    DNI           CHAR(10) NOT NULL,
    fechaPrestamo DATE NOT NULL,
    fechaDevol    DATE 
    CONSTRAINT PK_idPrestamo PRIMARY KEY,
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
VALUES (1, '9780521597180', '1234567890', '2024-04-15', '2024-05-10');
INSERT INTO PRESTAMOS (idPrestamo, ISBN, DNI, fechaPrestamo, fechaDevol) 
VALUES (2, '9780307743657', '9876543210', '2024-04-20', NULL);
INSERT INTO PRESTAMOS (idPrestamo, ISBN, DNI, fechaPrestamo, fechaDevol) VALUES (3, '9788413140066', '9876543210', '2024-04-25', '2024-05-05');




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
-- PREGUNTAAAAAAR
    BEGIN TRY
    -- Si no hay transacciones abiertas
    IF @@TRANCOUNT = 0
        BEGIN TRAN

    -- Declaramos el DNI borrado
    DECLARE @DNIBorrado CHAR(10)
    SELECT @DNIBorrado = DNI
      FROM DELETED

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
     WHERE p.DNI = d.DNI
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
    IF @@TRANCOUNT = 1
        COMMIT

    END TRY
    BEGIN CATCH
        PRINT CONCAT('CODERROR: ', ERROR_NUMBER(),
                    ', DESCRIPCION: ', ERROR_MESSAGE(),
                    ', LINEA: ', ERROR_LINE(),
                    ', PROCEDURE: ', ERROR_PROCEDURE())
        -- Si solo existe la transacción creada al inicio. ROLLBACK
        IF @@TRANCOUNT = 1
        ROLLBACK
    END CATCH


END

BEGIN TRAN
BEGIN TRY
  DELETE FROM SOCIOS
    WHERE DNI = '9876543210'
    COMMIT
END TRY
BEGIN CATCH
    ROLLBACK
END CATCH



