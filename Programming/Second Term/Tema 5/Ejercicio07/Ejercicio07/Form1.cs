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

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void AddToArray(int[] array)
        {
            array[0] = int.Parse(Interaction.InputBox("Ingrese num"));
            int i = 1;
            int num;
            while (i < array.Length)
            {
                num = int.Parse(Interaction.InputBox("Ingrese num"));
                if (array[i - 1] < num)
                {
                    array[i] = num;
                    i++;
                }
                else
                {
                    MessageBox.Show("Dame uno mayor");
                }
            }
        }

        string ShowArray(int[] array)
        {
            string text;

            text = "La lista de numeros es: \n";
            for (int i = 0; i < array.Length; i++)
                text += array[i] + " ";

            return text;
        }
        bool IsGreater(int numAnterior, int numNuevo)
        {
            bool isGreater = false;
            if (numAnterior < numNuevo)
            {
                isGreater = true;
            }
            return isGreater;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string text;
            int[] numbers = new int[5];
            AddToArray(numbers);
            text = ShowArray(numbers);
            MessageBox.Show(text);


        }
    }
}
