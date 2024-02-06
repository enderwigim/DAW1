using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPropio1
{
    internal class Program
    {
        public class Class
        {
            public bool isPrime(int num)
            {
                bool isPrime = true;

                for (int i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                    }
                }
                return isPrime;
            }

            public void ShowArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
       
        static void Main(string[] args)
        {
            Class c = new Class();
            int num;
            int[] numberArray = new int[10];
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write("Add a number");
                num = int.Parse(Console.ReadLine());
                if (c.isPrime(num))
                {
                    numberArray[i] = num;
                }
            }
            c.ShowArray(numberArray);
            Console.ReadLine();
            
        }
    }
}
