using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador;
            for (contador = 1; contador <= 10; contador++)
            {
                if (contador == 5)
                    continue;
                Console.Write("{0} ", contador);
            }
            System.Console.ReadLine();
        }
    }
}
