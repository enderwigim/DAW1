--Mostrar el numero de clientes (nombrar el nuevo campo NumClientes)
-- que tenemos en cada ciudad.
SELECT ciudad,
       COUNT(1) AS NumClientes
  FROM CLIENTES
 WHERE ciudad IN('Madrid', 'Barcelona')
 GROUP BY ciudad
 ORDER BY NumClientes DESC;

/*Mostrar el pedido y el importe total (ImpTotal) de todas las líneas de cada pedido.
En la tabla DETALLE_PEDIDOS tenemos el codPedido, y la cantidad y precio_unidad de cada 
artículo del pedido. Deberemos sumar Cantidad * precio_unidad de cada línea y luego sumarlas 
todas.*/

 SELECT *
   FROM PEDIDOS;

SELECT codPedido,
       SUM(cantidad * precio_unidad) AS ImpTotal
  FROM DETALLE_PEDIDOS
  GROUP BY codPedido
  ORDER BY ImpTotal ASC;

-- Mostrar  el numero de articulos (NumArticulos) de cada Gama
--cuyos PrecioVenta mayor que 20Euros.


SELECT codCategoria, COUNT(1)
  FROM PRODUCTOS
 WHERE precio_venta > 20
 GROUP BY codCategoria
 ORDER BY codCategoria ASC