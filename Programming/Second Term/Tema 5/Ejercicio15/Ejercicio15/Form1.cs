using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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
        void GetBigest(int[] array, out int bigest)
        {
            bigest = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > bigest)
                {
                    bigest = array[i];
                }
            }
        }
        void GetSmallest(int[] array, out int smallest)
        {
            smallest = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                }
            }
        }
        int CountIfRepeated(int[] array, int num1)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (num1 == array[i])
                {
                    counter++;
                }
            }
            counter--;
            return counter;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] numberList = new int[20];
            int bigest, smallest;

            AddToArray(numberList);
            GetBigest(numberList, out bigest);
            GetSmallest(numberList, out smallest);
            
            
            ShowArray(numberList);
            MessageBox.Show("El numero mas grande es: " + bigest + "\nSe reptite: " + CountIfRepeated(numberList, bigest) +
                "\nEl numero mas pequeño es: " + smallest + "\nSe repite: " + CountIfRepeated(numberList, smallest));

        }
    }
}
