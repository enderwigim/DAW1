-- Ejercicio 1
CREATE DATABASE BIBLIOTECA;
USE BIBLIOTECA
GO
CREATE TABLE DUEÑOS (
  DNI 				CHAR(10),
  nombre 			VARCHAR(100) NOT NULL,
  direccion 		VARCHAR(100) NOT NULL
  
  CONSTRAINT PK_DUEÑOS PRIMARY KEY (DNI)
);
GO
CREATE TABLE COCHES (
  numbastidor 		CHAR(17),
  marca 			VARCHAR(100) NOT NULL,
  modelo 			VARCHAR(100) NOT NULL,
  DNI_dueño 		CHAR(10)
  
  CONSTRAINT PK_COCHES PRIMARY KEY (numbastidor),
  CONSTRAINT FK_COCHES_DUEÑOS FOREIGN KEY (DNI_dueño)
  	REFERENCES DUEÑOS(DNI)
);
GO
-- Ejercicio 2
CREATE TABLE PROVEEDORES (
  codProveedor 		INT,
  nombre 			VARCHAR(100),
  direccion 		VARCHAR(100)
  
  CONSTRAINT PK_PROVEEDORES PRIMARY KEY (codProveedor)
);
CREATE TABLE ARTICULOS (
  codArticulo 		INT,
  descripcion 		VARCHAR(1000),
  precio 			DECIMAL(5,2),
  existencias 		SMALLINT
  
  CONSTRAINT PK_ARTICULOS PRIMARY KEY (codArticulo)
);

CREATE TABLE SUMINISTROS (
  codProveedor 		INT,
  codArticulo		INT
  
  CONSTRAINT PK_SUMINISTROS PRIMARY KEY (codProveedor, codArticulo),
  CONSTRAINT FK_SUMINISTROS_PROVEEDORES FOREIGN KEY (codProveedor)
  	REFERENCES PROVEEDORES(codProveedor),
  CONSTRAINT FK_SUMINISTROS_ARTICULOS FOREIGN KEY (codArticulo)
    REFERENCES ARTICULOS(codArticulo)
);
-- Ejercicio 3

create TABLE LIBROS (
  ISBN 		CHAR(13),
  titulo 	VARCHAR(100) NOT NULL,
  precio 	DECIMAL(4,2) CHECK(precio <= 59) NOT NULL,
  
  CONSTRAINT PK_LIBROS PRIMARY KEY (ISBN),
  -- CONSTRAINT CHK_LIBROS_precio CHECK (precio < 59),
);
GO
CREATE TABLE SOCIOS (
  DNI 			CHAR(10),
  nombre 		VARCHAR(100) NOT NULL,
  apellido1 	VARCHAR(100) NOT NULL,
  apellido2 	VARCHAR(100),
  ciudad 		VARCHAR(100) DEFAULT 'Alicante'
  
  CONSTRAINT PK_SOCIOS PRIMARY KEY (DNI)
);
GO
/* INTO SOCIOS (DNI, nombre, apellido1)
VALUES ('Z0192920R', 'Santiago', 'Lorenzano')
*/

CREATE TABLE PRESTAMOS (
  idPrestamo 	INT IDENTITY,
  ISBN		 	CHAR(13) NOT NULL,
  DNI 			CHAR(10) NOT NULL,
  FechaPrestamo SMALLDATETIME NOT NULL,
  FechaDevol 	SMALLDATETIME
  
  CONSTRAINT PK_PRESTAMOS PRIMARY KEY (idPrestamo),
  CONSTRAINT FK_PRESTAMOS_ISBN FOREIGN KEY (ISBN)
  	REFERENCES LIBROS(ISBN)
);

ALTER TABLE PRESTAMOS
  ADD CONSTRAINT FK_PRESTAMOS_DNI FOREIGN KEY (DNI)
  		REFERENCES SOCIOS(DNI)
        
        
        


-- Ejercicio 4
--1
INSERT INTO DUEÑOS (DNI, nombre, direccion)
VALUES ('Z0192921R', 'Sebastian', 'Virgen Del Puig')
--2
INSERT INTO COCHES(numbastidor, marca, modelo, DNI_dueño)
VALUES ('Z123456789123', 'Citroen', 'C2', 'Z0192920R')


--3
UPDATE DUEÑOS
   SET nombre = 'Alvaro Perez'
 WHERE DNI = 'Z0192920R'
-- 4 Ya es citroen, lo cambiaremos a FIAT 500
UPDATE COCHES
   SET marca = 'FIAT',
   	   modelo = '500'
 WHERE numbastidor = 'Z123456789123'
 
-- 5
DELETE FROM COCHES
 WHERE numbastidor = 'Z123456789123'
-- 6
DELETE FROM DUEÑOS
 WHERE DNI = 'Z0192920R'
 
 -- Ejercicio 5
 
 --1
 INSERT INTO PROVEEDORES(codProveedor, nombre, direccion)
 VALUES (1, 'Jose Carlos', 'Star Wars 23');

 
 --2
 INSERT INTO ARTICULOS(codArticulo, descripcion, 
                       precio, existencias)
 VALUES (1, 'Articulo Bueno, bonito y barato',
         99.99, 100)

 INSERT INTO ARTICULOS(codArticulo, descripcion, 
                       precio, existencias)
 VALUES (2, 'Articulo malo, feo y caro',
         1.10, 3)

--3
INSERT INTO SUMINISTROS
VALUES (1, 1)
--4
UPDATE PROVEEDORES
   SET direccion = 'Virgen del Puig 23'
 WHERE codproveedor = 1
    OR LOWER(LEFT(nombre,1)) = 'p'
   
/*   
SELECT *
  FROM PROVEEDORES
 WHERE codproveedor = 1
    OR LOWER(LEFT(nombre,1)) = 'p'
*/

--5
UPDATE ARTICULOS
   SET precio = precio * 1.20
 WHERE codarticulo = 1
    OR precio < 20;
/*
SELECT * 
  FROM ARTICULOS
 WHERE codarticulo = 1
    OR precio < 20;
*/

--6
DELETE FROM SUMINISTROS
 WHERE codproveedor = 1
   AND codarticulo = 1
   
   
   
-- Ejercicio 6

--1
INSERT INTO LIBROS(ISBN, titulo, precio)
VALUES ('9788441425132', 'Prohibido Suicidarse en primavera', 9.50)

/* INSERT INTO LIBROS(ISBN, titulo, precio)
VALUES ('9788441425131', 'holaN', 9.50)
*/

--2
INSERT INTO SOCIOS(DNI, nombre, apellido1)
VALUES('Z0192920R', 'Santiago', 'Lorenzano')
--3
INSERT INTO PRESTAMOS(ISBN, DNI, FechaPrestamo)
VALUES ('9788441425132', 'Z0192920R', GETDATE())
--4
UPDATE PRESTAMOS
   SET fechaDevol = '2021-06-05'
 WHERE idPrestamo = 1
 
/*
SELECT * FROM PRESTAMOS
*/
--5
UPDATE LIBROS
   SET precio = 20
 WHERE LOWER(RIGHT(titulo, 1)) = 'n'
/*
SELECT *
  FROM LIBROS
 WHERE LOWER(RIGHT(titulo, 1)) = 'n'
 */
 
 --6
 UPDATE SOCIOS
    SET ciudad = 'Valencia'
  WHERE LOWER(ciudad) = 'alicante'

/*
 SELECT *
   FROM SOCIOS
  WHERE LOWER(ciudad) = 'alicante'
 */
 
 --7
 DELETE FROM PRESTAMOS
  WHERE FechaDevol >= '2021-06-05'
 /*
 SELECT *
   FROM PRESTAMOS
  WHERE FechaDevol >= '2021-06-05'
 */