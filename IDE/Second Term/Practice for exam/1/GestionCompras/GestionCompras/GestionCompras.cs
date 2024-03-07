using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    public class GestionCompras
    {
        // Listas para almacenar productos y cantidades en inventario
        private List<string> productos;
        private List<int> cantidades;

        // Constructor de la clase
        public GestionCompras()
        {
            productos = new List<string>();
            cantidades = new List<int>();
        }

        // Método para registrar una compra
        public void RegistrarCompra(string producto, int cantidad)
        {
            // Validar que la cantidad no sea negativa
            if (cantidad < 0)
            {
                throw new ArgumentOutOfRangeException("La cantidad de la compra no puede ser negativa.");
            }

            // Buscar el índice del producto en la lista
            int index = productos.IndexOf(producto);

            // Si el producto no existe, agregarlo a las listas
            if (index == -1)
            {
                productos.Add(producto);
                cantidades.Add(cantidad);
            }
            // Si el producto ya existe, incrementar la cantidad
            else
            {
                cantidades[index] += cantidad;
            }
        }

        // Método para registrar una devolución
        public void RegistrarDevolucion(string producto, int cantidad)
        {
            // Validar que la cantidad no sea negativa
            if (cantidad < 0)
            {
                throw new ArgumentOutOfRangeException("La cantidad de la devolución no puede ser negativa.");
            }

            // Buscar el índice del producto en la lista
            int index = productos.IndexOf(producto);

            // Si el producto no existe, lanzar una excepción
            if (index == -1)
            {
                throw new InvalidOperationException("El producto no existe en el inventario.");
            }
            // Si el producto existe, verificar y actualizar la cantidad
            else
            {
                // Si la cantidad de devolución es mayor al inventario actual, lanzar una excepción
                if (cantidad > cantidades[index])
                {
                    throw new ArgumentOutOfRangeException("La cantidad de devolución no puede ser mayor al inventario actual.");
                }

                // Actualizar la cantidad en el inventario
                cantidades[index] -= cantidad;
            }
        }

        // Método para obtener la cantidad en inventario de un producto
        public int ObtenerInventario(string producto)
        {
            // Buscar el índice del producto en la lista
            int index = productos.IndexOf(producto);

            // Si el producto existe, devolver la cantidad; de lo contrario, devolver 0
            if (index != -1)
            {
                return cantidades[index];
            }
            else
            {
                return 0;
            }
        }

        // Método para imprimir el inventario
        public void ImprimirInventario()
        {
            Console.WriteLine("Inventario actual:");
            Console.WriteLine("=================");

            // Iterar sobre todos los productos en el inventario y mostrar sus cantidades
            foreach (var producto in productos)
            {
                int cantidad = ObtenerInventario(producto);
                Console.WriteLine($"{producto}: {cantidad} unidades");
            }

            Console.WriteLine("=================\n");
        }
    }
}
