using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase GestionCompras
            GestionCompras gestionCompras = new GestionCompras();

            // Realizar algunas compras
            gestionCompras.RegistrarCompra("ProductoA", 10);
            gestionCompras.RegistrarCompra("ProductoB", 5);
            gestionCompras.RegistrarCompra("ProductoA", 8); // Incrementa la cantidad de ProductoA

            // Imprimir el inventario después de las compras
            gestionCompras.ImprimirInventario();

            // Realizar devoluciones
            try
            {
                gestionCompras.RegistrarDevolucion("ProductoC", 3); // Intentar devolver un producto que no está en el inventario
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            gestionCompras.RegistrarDevolucion("ProductoA", 5); // Devolver parte de ProductoA

            // Imprimir el inventario después de las devoluciones
            gestionCompras.ImprimirInventario();

            Console.ReadLine();
        }
    }
}
