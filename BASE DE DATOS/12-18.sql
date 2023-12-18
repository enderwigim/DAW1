SELECT *
  FROM CLIENTES
 WHERE (limite_credito BETWEEN 10000 AND 20000
   AND ciudad = 'Barcelona')
   OR (codCliente%2) <> 0
 ORDER BY limite_credito ASC

 SELECT linea_direccion2, *
   FROM CLIENTES
  WHERE linea_direccion2 IS NOT NULL

SELECT *
  FROM PRODUCTOS
where UPPER(nombre) LIKE UPPER('%ciruelo%')
