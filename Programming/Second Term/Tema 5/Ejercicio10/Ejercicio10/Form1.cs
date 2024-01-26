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

namespace Ejercicio10
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

        void MoveToTheRight(int[] array)
        {
            /*
            int[] newArray = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newArray[i] = array[(array.Length - 1) - i];
            }
            return newArray;
            */
            int num = array[array.Length -1];
            
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = num;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] numberArray = new int[] { 1, 2, 3, 4, 20, 30, 40 };
            MoveToTheRight(numberArray);
            ShowArray(numberArray);
        }
    }
}
