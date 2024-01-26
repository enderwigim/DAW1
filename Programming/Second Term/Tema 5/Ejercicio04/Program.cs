using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string[] nameA = new string[5];
            bool finished = false;
            bool founded = false;
            for (int i = 0; i < nameA.Length; i++)
            {
                Console.WriteLine("Ingrese un nombre");
                nameA[i] = Console.ReadLine();
            }
            while (!finished)
            {
                Console.WriteLine("Consultame un nombre");
                userInput = Console.ReadLine();
                if (userInput == "fin")
                {
                    finished = true;
                }
                else
                {
                    for (int i = 0; i < nameA.Length && !founded ; i++)
                    {
                        if (userInput == nameA[i])
                        {
                            Console.WriteLine("El nombre {0}, se encuentra presente", nameA[i]);
                            founded = true;
                        }
                    }
                    if (!founded)
                    {
                        Console.WriteLine("El nombre {0}, no se encuentra", userInput);
                    }
                }
                founded = false;
                
            }
            
        }
    }
}
