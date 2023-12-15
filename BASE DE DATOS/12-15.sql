USE JARDINERIA
/* Añadir 10 días a la FECHA ‘03/05/2023’ */
SELECT DATEADD(DAY, 10, '2023-05-03')

/* Añadir 2 años a la FECHA ‘29/10/2022’ */
SELECT DATEADD(YEAR, 2, '2022-10-29')

/* Diferencia de días entre las FECHAS: 10/02/2023 y 25/03/2023 */
SELECT DATEDIFF(DAY, '2023-02-10', '2023-03-25') AS DIAS
/* Obtener el valor del DÍA de la FECHA ACTUAL */
SELECT DAY(GETDATE()) AS DAY

/* Obtener el valor del MES de la FECHA ACTUAL */
SELECT MONTH(GETDATE()) AS MONTH

/* Obtener el valor del AÑO de la FECHA ACTUAL */
SELECT YEAR(GETDATE()) AS YEAR

 /*Obtener nombre del mes con letras de la fecha 19/03/2023 */
SELECT DATENAME(MONTH,'2023-03-19') AS MONTH;

/* Utilizando la función CHARINDEX() obtén la palabra 'news' de la frase 'No news is good news'
    Debes utilizar también la función LEFT y/o RIGHT
    Nota: Su equivalente en Oracle es la función INSTR()
*/

DECLARE @text VARCHAR(100)
    SET @text = 'news'
 SELECT RIGHT(LEFT('No news is good news.', CHARINDEX(@text, 'No news is good news.') + LEN(@text) - 1), LEN(@text))
-- Solución utilizando CHARINDEX y LEFT o RIGHT



-- Solución en la que NO se indican los 4 caracteres que queremos seleccionar con LEFT o RIGHT
-- Hay que obtenerlos de otro modo



/* Supón que tenemos una tabla llamada PIE_FIRMA que consta de dos campos (no se hará con la tabla, sino con strings)
    - fechaFirma DATE
    - lugarFirma VARCHAR(100)

    A partir de la siguiente SELECT, genera el siguiente pie de firma a este:
    'En Alicante, a 8 de junio de 2022'
 */

 SELECT CONCAT('En', 'Alicante', ' a ', DAY('2022-6-8'), 
               ' de ', DATENAME(MONTH, '2022-06-08'), ' de ',
               YEAR('2022-06-08'))

/* Utiliza la función ASCII() para obtener el valor ASCII de un carácter
    Para el carácter A debe devolver 65
*/
SELECT ASCII('-'), CHAR(65)


/* Investiga el uso de la función TRANSLATE() y haz un ejemplo de uso */
SELECT TRANSLATE('HELLO WORLD', 'HELO', 'WORL')


/* Investiga el uso de la función REPLICATE() y haz un ejemplo de uso */
SELECT REPLICATE('holi', 5)

/* Investiga el uso de la función SPACE() y haz un ejemplo de uso */

SELECT * FROM CLIENTES
SELECT codCliente, 
       nombre_cliente, 
       telefono, 
       limite_credito,
       ROUND(limite_credito/12, 2) AS limiteMensual
  FROM CLIENTES
 WHERE limite_credito > 2000 
 ORDER BY limite_credito DESC


 SELECT DISTINCT pais 
   FROM CLIENTES

SELECT TOP(5) codCliente, limite_credito
  FROM CLIENTES
 ORDER BY limite_credito ASC