/*
CREACIÓN / MODIFICACIÓN DE TABLAS
Crea las siguientes tablas:
STREAMERS (codStreamer, nombre, apellidos, pais, edad)
PK: codStreamer (NO se incrementa automáticamente)
*/
CREATE DATABASE REPASO;
USE REPASO;
CREATE TABLE STREAMERS (
  codStreamer	INT,
  nombre		VARCHAR(100) NOT NULL,
  apellidos 	VARCHAR(100),
  pais			VARCHAR(100),
  edad			TINYINT NOT NULL
  
  CONSTRAINT PK_STREAMERS PRIMARY KEY (codStreamer)
  CONSTRAINT CH_STREAMERS_edad CHECK (edad BETWEEN 1 and 100)
);


/*
TEMATICAS (codTematica, nombre)
PK: codTematica (se incrementa automáticamente)
*/
CREATE TABLE TEMATICAS (
  codTematica 	INT IDENTITY(1,1),
  nombre 		VARCHAR(100) NOT NULL
  
  CONSTRAINT PK_TEMATICAS PRIMARY KEY (codTematica)
);
/*
STREAMERS_TEMATICAS (codStreamer, codTematica, idioma, medio, milesSeguidores)
PK: codStreamer, codTematica
FK: codStreamer  STREAMERS
FK: codTematica  TEMATICAS
*/
CREATE TABLE STREAMERS_TEMATICAS (
  codStreamer 		INT,
  codTematica 		INT,
  idioma 			VARCHAR(100) NOT NULL,
  medio 			VARCHAR(100) NOT NULL,
  -- INT O DECIMAL??????
  milesSeguidores  	INT NOT NULL
  
  CONSTRAINT PK_STREAMERS_TEMATICAS PRIMARY KEY (codStreamer, codTematica),
  CONSTRAINT FK_STREAMERS_TEMATICAS_STREAMERS FOREIGN KEY (codStreamer)
  	REFERENCES STREAMERS(codStreamer),
  CONSTRAINT FK_STREAMERS_TEMATICAS_TEMATICAS FOREIGN KEY (codTematica)
  	REFERENCES TEMATICAS(codTematica)
);
/*
GESTIÓN DE TABLAS
Inserta los siguientes STREAMERS:
-	Ibai Llanos de España
-	AuronPlay de España
-	Nate Gentile de España
-	Linus Tech Tips de Canadá
-	DYI Perks sin ningún país
-	Alexandre Chappel de Noruega
-	Tekendo de España
-	Caddac Tech de ningún país
*/
-- Que pasa con los apellidos????
INSERT INTO STREAMERS(codstreamer, nombre, apellidos, 
                      pais, edad)
VALUES (1, 'Ibai', 'Llanos', 'España', 33),
        (2, 'AuronPlay', null, 'España', 36),
         (3, 'Linus Tech Tips', null, 'Canada', 23),
          (4, 'DYI Perks', null, null, 45),
          (5, 'Alexandre', 'Chappel', 'Noruega', 35),
           (6, 'Tekendo', null, 'España', 40),
            (7, 'Caddac Tech', null, null, 45),
             (8, 'Nate', 'Genitle', 'España', 40)

             
--	Nate Gentile de España
/* INSERT INTO 1 A 1.
INSERT INTO STREAMERS(codstreamer, nombre, apellidos,
                     pais, edad)
VALUES (1, 'Ibai', 'Llanos', 
        'España', 33)
INSERT INTO STREAMERS(codstreamer, nombre,
                     pais, edad)
VALUES (2, 'AuronPlay', 
        'España', 36)
INSERT INTO STREAMERS(codstreamer, nombre,
                     pais, edad)
VALUES (3, 'Linus Tech Tips',
        'Canada', 23)
INSERT INTO STREAMERS(codstreamer, nombre, edad)
VALUES (4, 'DYI Perks', 45)
INSERT INTO STREAMERS(codstreamer, nombre, apellidos,
                      pais, edad)
VALUES (5, 'Alexandre', 'Chappel',
        'Noruega', 35)
INSERT INTO STREAMERS(codstreamer, nombre,
                      pais, edad)
VALUES (6, 'Tekendo',
        'España', 40)
INSERT INTO STREAMERS(codstreamer, nombre, edad)
VALUES (7, 'Caddac Tech', 45)

INSERT INTO STREAMERS(codstreamer, nombre, apellidos,
                      pais, edad)
VALUES (8, 'Nate', 'Genitle',
             'España', 40)
*/

/*
Inserta los siguientes TEMAS:
-	Informática
-	Tecnología en general
-	Gaming
-	Variado
-	Bricolaje
-	Viajes
-	Humor
*/
INSERT INTO TEMATICAS(nombre)
VALUES ('Informática'),
		('Tecnología en general'),
         ('Gaming'),
          ('Variado'),
           ('Bricolaje'),
            ('Viajes'),
             ('Humor')

/*

Inserta las siguientes TEMATICAS de STREAMERS:
STREAMER	TEMATICA	idioma	medio	milesSeguidores
AuronPlay	Gaming	Español	YouTube	29200
Ibai Llanos	Variado	Español	Twitch	12800
AuronPlay	Variado	Español	Twitch	14900
Nate Gentile	Informática	Español	YouTube	2450
Linus Tech Tips	Informática	Inglés	YouTube	15200
DYI Perks	Bricolaje	Inglés	YouTube	4140
Alexandre Chappel	Bricolaje	Inglés	YouTube	370
Caddac Tech	Informática	Inglés	YouTube	3
*/

INSERT INTO STREAMERS_TEMATICAS(codstreamer, codtematica, idioma, medio, milesseguidores)
VALUES (2, 3, 'Español', 'Youtube', 29200),
         (1, 4, 'Español','Twitch', 12800),
          (2, 4, 'Español','Twitch', 14900),
            (8, 1, 'Español','Youtube', 2450),
             (3, 1, 'Ingles','Youtube', 15200),
              (4, 5, 'Ingles','Youtube', 4140),
                (5, 5, 'Ingles','Youtube', 370),
                  (7, 1, 'Ingles','Youtube', 3)


-----------------
--  CONSULTAS  --
-----------------
-- 01. Nombre de las temáticas que tenemos almacenadas, ordenadas alfabéticamente.
SELECT nombre
  FROM TEMATICAS
 ORDER BY nombre asc
-- 02. Cantidad de streamers cuyo país es "España".
SELECT COUNT(1) AS Streamers_Españoles
  FROM STREAMERS
 WHERE LOWER(pais) = 'españa';
-- 03, 04, 05. Nombres de streamers cuya segunda letra no sea una "B" (quizá en minúsculas), de 3 formas distintas.
SELECT *
  FROM STREAMERS
 WHERE RIGHT(LEFT(nombre, 2),1) NOT IN ('b', 'B')
 
SELECT *
  FROM STREAMERS
 WHERE LOWER(nombre) NOT LIKE '_b%'
 
SELECT *
  FROM STREAMERS
 WHERE LOWER(SUBSTRING(nombre, 2, 1)) <> 'b'
-- 06. Media de suscriptores para los canales cuyo idioma es "Español".
SELECT CAST(AVG(milesseguidores) AS float) as MediaSubcriptores
  FROM STREAMERS_TEMATICAS
 WHERE LOWER(idioma) = 'español'
-- 07. Media de seguidores para los canales cuyo streamer es del país "España".
SELECT CAST(AVG(milesseguidores) AS float) AS MediaSubscriptores
  FROM STREAMERS s,
       STREAMERS_TEMATICAS st
 WHERE s.codStreamer = st.codStreamer
   AND LOWER(pais) = 'españa'
-- 08. Nombre de cada streamer y medio en el que habla, para aquellos que tienen entre 5.000 y 15.000 miles de seguidores, usando BETWEEN.
SELECT s.nombre,
       st.medio
  FROM STREAMERS s,
       STREAMERS_TEMATICAS st
 WHERE s.codStreamer = st.codStreamer
   AND milesseguidores BETWEEN 5000 AND 15000
-- 09. Nombre de cada streamer y medio en el que habla, para aquellos que tienen entre 5.000 y 15.000 miles de seguidores, sin usar BETWEEN.
SELECT s.nombre,
       st.medio
  FROM STREAMERS s,
       STREAMERS_TEMATICAS st
 WHERE s.codStreamer = st.codStreamer
   AND milesseguidores > 5000
   AND milesseguidores < 15000
-- 10. Nombre de cada temática y nombre de los idiomas en que tenemos canales de esa temática 
--(quizá ninguno), sin duplicados.
SELECT DISTINCT t.nombre,
	   st.idioma
  FROM TEMATICAS t,
       STREAMERS_TEMATICAS st
 WHERE t.codTematica = st.codStreamer
 ORDER BY idioma ASC
-- 11. Nombre de cada streamer, nombre de la temática de la que habla y del medio en el que habla de esa temática, usando INNER JOIN.
SELECT s.nombre,
       t.nombre,
       st.medio
  FROM STREAMERS_TEMATICAS st
 INNER JOIN TEMATICAS t
 	ON t.codTematica = st.codTematica
 INNER JOIN STREAMERS s
    ON s.codStreamer = st.codStreamer
    
-- 12. Nombre de cada streamer, nombre de la temática de la que habla y del medio en el que habla de esa temática, usando WHERE.
SELECT s.nombre,
       t.nombre,
       st.medio
  FROM STREAMERS s,
       STREAMERS_TEMATICAS st,
       TEMATICAS t
 WHERE s.codStreamer = st.codStreamer
   AND t.codTematica = st.codTematica
-- 13. Nombre de cada streamer, del medio en el que habla y de la temática de la que habla en ese medio, incluso si de algún streamer no tenemos dato del medio o de la temática.
SELECT s.nombre,
       st.medio,
       t.nombre AS tematica
  FROM STREAMERS_TEMATICAS st
  LEFT JOIN STREAMERS s
    ON s.codStreamer = st.codStreamer
  LEFT JOIN TEMATICAS t
    ON t.codTematica = st.codTematica
-- 14. Nombre de cada medio y cantidad de canales que tenemos anotados en él, ordenado alfabéticamente por el nombre del medio.
 SELECT medio,
        COUNT(codstreamer)
   FROM STREAMERS_TEMATICAS
  GROUP BY medio
-- 15, 16, 17, 18. Medio en el que se emite el canal de más seguidores, de 4 formas distintas.
SELECT medio
  FROM STREAMERS_TEMATICAS
 WHERE milesSeguidores >= ALL (SELECT milesSeguidores
                                    FROM STREAMERS_TEMATICAS)
-- 19. Categorías de las que tenemos 2 o más canales.

-- 20. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando COUNT.

-- 21. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando IN / NOT IN.

-- 22. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando ALL / ANY.

-- 23. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando EXISTS / NOT EXISTS.

-- 24. Tres primeras letras de cada país y tres primeras letras de cada idioma, en una misma lista.

-- 25, 26, 27, 28. Tres primeras letras de países que coincidan con las tres primeras letras de un idioma, sin duplicados, de cuatro formas distintas.

-- 29. Nombre de streamer, nombre de medio y nombre de temática, para los canales que están por encima de la media de suscriptores.

-- 30. Nombre de streamer y medio, para los canales que hablan de la temática "Bricolaje".

-- 31. Crea una tabla de "juegos". Para cada juego querremos un código (clave primaria), un nombre (hasta 20 letras, no nulo) y una referencia al streamer que más habla de él (clave ajena a la tabla "streamers").

-- 32. Añade a la tabla de juegos la restricción de que el código debe ser 1000 o superior.

-- 33. Añade 3 datos de ejemplo en la tabla de juegos. Para uno indicarás todos los campos, para otro no indicarás el streamer, ayudándote de NULL, y para el tercero no indicarás el streamer porque no detallarás todos los nombres de los campos.

-- 34. Borra el segundo dato de ejemplo que has añadido en la tabla de juegos, a partir de su código.


-- 35. Muestra el nombre de cada juego junto al nombre del streamer que más habla de él, si existe. Los datos aparecerán ordenados por nombre de juego y, en caso de coincidir éste, por nombre de streamer.

-- 36. Modifica el último dato de ejemplo que has añadido en la tabla de juegos, para que sí tenga asociado un streamer que hable de él.

-- 37. Crea una tabla "juegosStreamers", volcando en ella el nombre de cada juego (con el alias "juego") y el nombre del streamer que habla de él (con el alias "streamer").

-- 38. Añade a la tabla "juegosStreamers" un campo "fechaPrueba".

-- 39. Pon la fecha de hoy (prefijada, sin usar GetDate) en el campo "fechaPrueba" de todos los registros de la tabla "juegosStreamers".

-- 40. Muestra juego, streamer y fecha de ayer (día anterior al valor del campo "fechaPrueba") para todos los registros de la tabla "juegosStreamers".

-- 41. Muestra todos los datos de los registros de la tabla "juegosStreamers" que sean del año actual de 2 formas distintas (por ejemplo, usando comodines o funciones de cadenas).

-- 42. Elimina la columna "streamer" de la tabla "juegosStreamers".

-- 43. Vacía la tabla de "juegosStreamers", conservando su estructura.

-- 44. Elimina por completo la tabla de "juegosStreamers".

-- 45. Borra los canales del streamer "Caddac Tech".

-- 46. Muestra la diferencia entre el canal con más seguidores y la media, mostrada en millones de seguidores. Usa el alias "diferenciaMillones".

-- 47. Medios en los que tienen canales los creadores de código "ill", "ng" y "ltt", sin duplicados, usando IN (pero no en una subconsulta).

-- 48. Medios en los que tienen canales los creadores de código "ill", "ng" y "ltt", sin duplicados, sin usar IN.

-- 49. Nombre de streamer y nombre del medio en el que habla, para aquellos de los que no conocemos el país.

-- 50. Nombre del streamer y medio de los canales que sean del mismo medio que el canal de Ibai Llanos que tiene 12800 miles de seguidores (puede aparecer el propio Ibai Llanos).

-- 51. Nombre del streamer y medio de los canales que sean del mismo medio que el canal de Ibai Llanos que tiene 12800 miles de seguidores (sin incluir a Ibai Llanos).

-- 52. Nombre de cada streamer, medio y temática, incluso si para algún streamer no aparece ningún canal o para alguna temática no aparece ningún canal.

-- 53. Nombre de medio y nombre de cada temática, como parte de una única lista (quizá desordenada).

-- 54. Nombre de medio y nombre de cada temática, como parte de una única lista ordenada alfabéticamente.

-- 55. Nombre de medio y cantidad media de suscriptores en ese medio, para los que están por encima de la media de suscriptores de los canales.

-- 56. Nombre de los streamers que emiten en YouTube y que o bien hablan en español o bien sus miles de seguidores están por encima de 12.000.

-- 57. Añade información ficticia sobre ti: datos como streamer, temática sobre la que supuestamente y medio en el que hablas sobre ella, sin indicar cantidad de seguidores. Crea una consulta que muestre todos esos datos a partir de tu código.

-- 58. Muestra el nombre de cada streamer, medio en el que emite y cantidad de seguidores, en millones, redondeados a 1 decimal.

-- 59. Muestra el nombre de cada streamer y el país de origen. Si no se sabe este dato, deberá aparecer "(País desconocido)".

-- 60. Muestra, para cada streamer, su nombre, el medio en el que emite (precedido por "Emite en: ") y el idioma de su canal (precedido por "Idioma: ")
