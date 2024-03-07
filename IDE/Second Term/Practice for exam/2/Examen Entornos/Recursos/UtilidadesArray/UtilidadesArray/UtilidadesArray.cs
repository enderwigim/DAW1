using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadesArray
{

    public class UtilidadesArray
    {
        public int[] OrdenarArray(int[] array)
        {
            CheckArray(array);

            // Variables para almacenar el array una vez este ordenado
            int[] arrayOrdenado = new int[array.Length];

            //Recorremos el array
            for (int i = 0; i < array.Length; i++)
            {
                // El -1 es porque no queremos llegar al final ya que hacemos
                // un indiceActual + 1 y si fuéramos hasta el final, intentaríamos acceder a un valor fuera de los límites
                // del arreglo
                for (int j = 0; j < array.Length - 1; j++)
                {
                    // guardamos el indice del siguiente elemento
                    int indice = j + 1;

                    // Si el actual es mayor que el que le sigue a la derecha...
                    if (array[j] > array[indice])
                    {
                        // Guardamos en una variable temporal el resultado
                        int temporal = array[j];
                        array[j] = array[indice];
                        array[indice] = temporal;
                    }
                }
            }

            //Copiamos el array una vez ordenado en la variable designada para ello
            Array.Copy(array, arrayOrdenado, array.Length);

            return arrayOrdenado;
        }

        // El primer elemento es el array a buscar, el segundo el numero que buscamos
        public int BuscarElementoArray(int[] array, int num)
        {
            CheckArray(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                    return i;
            }
            return -1;
        }

        // El primer elemento es el array sobre el que buscamos
        private void CheckArray(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException("El array no puede ser nulo");
            else if (array.Length == 0)
                throw new ArgumentOutOfRangeException("El array no puede estar vacío");
        }
    }
}
