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
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio09
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
        int[] ChangeArrayOrder(int[] array)
        {
            int[] newNumberArray = new int[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                newNumberArray[j] = array[i];
                j++;
            }
            return newNumberArray;
        }
        void ShowArray(int[] array)
        {
            string text = "La lista de numeros es: \n";
            for (int i = 0; i < array.Length; i++)
                text += array[i] + " ";

            MessageBox.Show(text);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] numberArray = new int[10];
            
            AddToArray(numberArray);
            numberArray = ChangeArrayOrder(numberArray);
            ShowArray(numberArray);

        }
    }
}
