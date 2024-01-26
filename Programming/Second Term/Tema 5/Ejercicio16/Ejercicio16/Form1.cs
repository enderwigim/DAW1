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

namespace Ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numberList = new int[10];
        void AddToArray(int[] array)
        {
            int num;
            int i = 1;
            array[0] = int.Parse(Interaction.InputBox("Introduzca un numero"));
            while (i < array.Length)
            {
                num = int.Parse(Interaction.InputBox("Introduzca un numero"));
                if (!NumberInArray(array, num))
                {
                    array[i] = num;
                    i++;
                }
                else
                {
                    MessageBox.Show("El numero ya esta en el array");
                }
                
            }
        }
        void ShowArray(int[] array)
        {
            string text = "La lista de numeros es: \n";
            for (int i = 0; i < array.Length; i++)
                text += array[i] + " ";

            MessageBox.Show(text);
        }

        bool NumberInArray(int[] array, int number)
        {
            bool isNumberInArray = false;
            for (int i = 0; i < array.Length && !isNumberInArray; i++)
            {
                if (array[i] == number)
                    isNumberInArray = true;

            }
            return isNumberInArray;
        }
        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            AddToArray(numberList);
            ShowArray(numberList);
        }
    }
}
