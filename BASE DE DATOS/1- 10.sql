USE JARDINERIA;

-- Mostrar numero de articulos de cada categoria. Mostrar
-- solo los que superan 40
SELECT codCategoria, 
       COUNT(codProducto) AS cantidadProductos
  FROM PRODUCTOS
 GROUP BY codCategoria
 HAVING COUNT(codProducto) > 40
 ORDER BY cantidadProductos ASC

-- Numero de pagos por cliente. Mostrando aquellos que tengan 
--Un importe mayor de 1000.
 SELECT codCliente, COUNT(id_transaccion) as cantPagos
   FROM PAGOS
  WHERE importe_pago > 1000 
  GROUP BY codCliente
  HAVING COUNT(id_transaccion) > 2


-- Numero pedidos
SELECT codCliente, 
       COUNT(codPedido) AS cantPedidos
 FROM PEDIDOS
 GROUP BY codCliente
 ORDER BY cantPedidos DESC

-- Cuanto suman todos sus pagos y cuantos hizo.
 SELECT codCliente,
        SUM(importe_pago) AS importeTotal,
        COUNT(*) AS numPagos
  FROM PAGOS
 GROUP BY codCliente
 ORDER BY importeTotal DESC