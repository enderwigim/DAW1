using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Este programa lee caracteres introducidos por teclado,
            los almacena en una cadena, calcula cuales son los
            mayores y menores atendiendo a la tabla ASCII * También 
            almacena el número de ellos que son mayúsculas
            */
            char minLetra = Char.MaxValue;
            char maxLetra = Char.MinValue;
            int numMayusculas = 0;
            bool salir = false;
            while (!salir)
            {
                //Leo una letra
                Console.WriteLine("Introduce una letra. Pulsa 0 si quieres salir: ");
                char letraAux = Console.ReadKey().KeyChar;
                Console.WriteLine("");
                Console.WriteLine("-------");
                if (letraAux == '0')
                    salir = true;
                else if (letraAux >= 'A' && letraAux <= 'z')
                {
                    //almaceno los menores y mayores. 
                    if (minLetra > letraAux)
                        minLetra = letraAux;
                    if (maxLetra < letraAux)
                        maxLetra = letraAux;
                    //Si la letra es mayusculas la contabiliza
                    //
                    if ((letraAux >= 'A') && (letraAux <= 'Z'))
                        numMayusculas++;
                }

            }
            //Escribe el resultado
            Console.WriteLine("el Char menor es : " + maxLetra);
            Console.WriteLine("el Char mayor es : " + minLetra);
            Console.WriteLine("Hay " + numMayusculas + " letras mayusculas ");
            Console.ReadKey();

        }
    }
}
