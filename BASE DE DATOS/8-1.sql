--Mostrar el numero de clientes (nombrar el nuevo campo NumClientes)
-- que tenemos en cada ciudad.
SELECT ciudad,
       COUNT(1) AS NumClientes
  FROM CLIENTES
 WHERE ciudad IN('Madrid', 'Barcelona')
 GROUP BY ciudad
 ORDER BY NumClientes DESC;