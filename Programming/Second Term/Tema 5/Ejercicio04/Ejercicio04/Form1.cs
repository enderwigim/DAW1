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
using Microsoft.VisualBasic;

namespace Ejercicio04
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
            {
                array[i] = int.Parse(Interaction.InputBox("Ingrese num"));
            }
        }

        string ShowArray(int[] array)
        {
            string text;

            text = "La lista de numeros es: \n";
            for (int i = 0; i < array.Length; i++)
            {
                text += array[i] + "\n";
            }
            return text;
        }
        void ReplaceNegatives(int[] array, out int negativeAmmount)
        {
            negativeAmmount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = 0;
                }
                else
                    negativeAmmount++;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string text;
            int negatives;
            int[] numberArray = new int[10];

            AddToArray(numberArray);
            ReplaceNegatives(numberArray, out negatives);
            text = ShowArray(numberArray);

            MessageBox.Show(text + "\nThere were " + negatives +" negative numbers in the array");
        }
    }
}
