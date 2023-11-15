using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media;
            int[] numero = new int[4];
            int[] numerosOrden = new int[4];
            numero[0] = 100; 
            numero[1] = 50;
            numero[2] = 200;
            numero[3] = 150;

            for (int i = 0; i < numero.Length; i++)
            {
                for (int j = 0; j < numero.Length; j++)
                {
                    if (numero[i] < numero[j])
                    {
                        numerosOrden[].(numerosOrden[j]);
                    }
                }
            }
            Console.ReadLine();

            /* while (i < 4)
            {
                Console.WriteLine("Introduce un numero");
                numero[i] = int.Parse(Console.ReadLine());
                i++;
            }
            */





        }
    }
}
