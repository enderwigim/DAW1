using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numberArray = new int[10];
        void AddToArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = int.Parse(Interaction.InputBox("Introduce un numero"));
        }
        void ShowArray(int[] array)
        {
            string text = "La lista de numeros es: \n";
            for (int i = 0; i < array.Length; i++)
                text += array[i] + " ";

            MessageBox.Show(text);
        }
        void orderArray(int[] array)
        {
            int numIntercambio;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        numIntercambio = array[i];
                        array[i] = array[j];
                        array[j] = numIntercambio;
                    }
                }
            }
        }
        int encontrarNumero(int[] array, int n1)
        {
            int posicion = -1;
            bool encontrado = false;

            for (int i = 0; i < array.Length && !encontrado ; i++)
            {
                if (array[i] == n1)
                {
                    posicion = i;
                }
            }
            return posicion;

        }

        private void btnIntroducirVector_Click(object sender, EventArgs e)
        {
            AddToArray(numberArray);
        }
        


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Introduce un numero a buscar"));
            int posicion = encontrarNumero(numberArray, num);


            if (posicion >= 0)
            {
                MessageBox.Show("El numero se encuentra y es la posición: " + posicion);
            }
            else
            {
                MessageBox.Show("El numero no se encuentra en el array");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            orderArray(numberArray);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ShowArray(numberArray);
        }
    }
}
