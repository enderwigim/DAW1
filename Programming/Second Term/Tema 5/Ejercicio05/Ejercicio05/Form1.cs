using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio05
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

        void SumUpArrays(int[] array1, int[] array2, int[] array3) 
        {
            int addition;
            for(int i = 0; i < array1.Length; i++)
            {
                addition = array1[i] + array2[i];
                array3[i] = addition;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string text;
            int[] numberArray1 = new int[10];
            int[] numberArray2 = new int[10];
            int[] numberArray3 = new int[10];

            AddToArray(numberArray1);
            AddToArray(numberArray2);

            SumUpArrays(numberArray1, numberArray2, numberArray3);
            text = ShowArray(numberArray3);

            MessageBox.Show(text);


        }
    }
}
