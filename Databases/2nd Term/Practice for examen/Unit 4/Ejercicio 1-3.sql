CREATE DATABASE EJ3;
USE EJ3;


CREATE TABLE TEMAS(
  codTema INT,
  nombre VARCHAR(150) NOT NULL
  CONSTRAINT PK_TEMA PRIMARY KEY (codTema)
);

CREATE TABLE LIBROS(
  ISBN CHAR(13),
  titulo VARCHAR(150) NOT NULL,
  autor NVARCHAR(150),
  numEjemplares DECIMAL(3,00) NOT NULL,
  codTema INT
  CONSTRAINT PK_LIBRO PRIMARY KEY (ISBN),
  CONSTRAINT FK_TEMA_LIBRO FOREIGN KEY (codTema)
  	REFERENCES TEMA(codTema)
);

CREATE TABLE SOCIOS(
  DNI CHAR(10),
  nombre VARCHAR(100) NOT NULL,
  direccion VARCHAR(100) NOT NULL,
  fechaAlta SMALLDATETIME NOT NULL,
  fechaBaja SMALLDATETIME NULL,
  CONSTRAINT PK_SOCIO PRIMARY KEY (DNI)
);

CREATE TABLE TELEFONO_SOCIOS(
  DNI CHAR(10),
  telefono CHAR(9)
  CONSTRAINT PK_TELEFONO_SOCIO PRIMARY KEY (DNI, telefono),
  CONSTRAINT FK_TELEFONO_SOCIO_SOCIO FOREIGN KEY (DNI)
  	REFERENCES SOCIO(DNI)
);

CREATE TABLE PRESTAMOS(
  DNI CHAR(10),
  ISBN CHAR(13),
  fechaPrestamo SMALLDATETIME,
  fechaDevolucion SMALLDATETIME NULL
  CONSTRAINT PK_PRESTAMO PRIMARY KEY (DNI, ISBN, fechaPrestamo),
  CONSTRAINT FK_PRESTAMO_SOCIO FOREIGN KEY (DNI)
  	REFERENCES SOCIO(DNI),
  CONSTRAINT FK_PRESTAMO_LIBRO FOREIGN KEY (ISBN)
  	REFERENCES LIBROS(ISBN)
);