using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 2;
            int s = 0;
            int n;
            n = Int32.Parse(Console.ReadLine());
            while (j <= n / 2)
            {
                if (n % j == 0)
                {
                    s = s + 1;

                }
                j = j + 1;
            }
                

            if (s == 0)
                Console.Write(n + "es primo");
            else
                Console.Write(n + "no es primo");
        }
    }
}

