using System;

namespace UtilidadesArray
{
    class MySort
    {
        
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 0, 98, 13, -5 };
            int[] arr2;


            UtilidadesArray utilidades = new UtilidadesArray();
            arr2 = utilidades.OrdenarArray(arr);
            
            Console.WriteLine("Ordenado:");

            foreach (int p in arr2)
                Console.Write(p + " ");

            Console.WriteLine();

            int elementoEncontrado = utilidades.BuscarElementoArray(arr2, 2);
            Console.WriteLine("Elemento encontrado (2): " + elementoEncontrado);

            elementoEncontrado = utilidades.BuscarElementoArray(arr2, 78);
            Console.WriteLine("Elemento encontrado (78): " + elementoEncontrado);

            Console.Read();
        }
    }
}