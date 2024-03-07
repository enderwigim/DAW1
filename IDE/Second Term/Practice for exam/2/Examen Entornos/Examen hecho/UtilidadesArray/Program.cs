using System;

namespace UtilidadesArray
{
    class MySort
    {
        static void Main(string[] args)
        {
            const int ELEMENTO1 = 2;
            const int ELEMENTO2 = 78;
            int[] arrayEntrada = { 78, 55, 45, 0, 98, 13, -5 };
            int[] arraySalida;

            UtilidadesArray utilidades = new UtilidadesArray();
            arraySalida = utilidades.OrdenarArray(arrayEntrada);

            Console.WriteLine("Ordenado:");

            foreach (int numero in arraySalida)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();

            int elementoEncontrado = utilidades.BuscarElementoArray(arraySalida, ELEMENTO1);
            Console.WriteLine($"Elemento encontrado ({ELEMENTO1}): " + elementoEncontrado);

            elementoEncontrado = utilidades.BuscarElementoArray(arraySalida, ELEMENTO2);
            Console.WriteLine($"Elemento encontrado ({ELEMENTO2}): " + elementoEncontrado);

            Console.Read();
        }
    }
}