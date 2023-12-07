using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jarra jarra = new Jarra();
            jarra.AumentarCapacidadMaxima(200);
            jarra.AumentarCantidad(100);
            Console.WriteLine(jarra.GetCapacidadMaxima());
            Console.WriteLine(jarra.GetCantidad());
            Console.WriteLine(jarra.GetPercentage());
            Console.ReadLine();

        }
    }
}
