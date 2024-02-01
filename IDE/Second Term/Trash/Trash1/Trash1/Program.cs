using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trash1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            avion sergio = new avion(100, 20, 300, 35);
            Console.WriteLine(sergio.Orientacion);
            // sergio.Ascender(); Will fail as the method is private.
            sergio.Virar(70);
            // sergio.Virar(); Will succeed as the method is public.
            Console.WriteLine(sergio.Orientacion);
            Console.Read();
        }
    }
}
