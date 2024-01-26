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

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void AddToArray(int[] array)
        {
            int num;
            for (int i = 0; i < array.Length; i++)
            {
                num = int.Parse(Interaction.InputBox("Ingrese num"));
                if (num > 0)
                    array[i] = num;
                
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

        void ReplaceRepeatedNumbers(int[] array, out int contador)
        {
            /*for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j] && array[j] != -1)
                    {
                        array[j] = -1;
                    }
                }
            }*/
            contador = 0;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i-1; j >=0; j--)
                {
                    if (array[i] == array[j])
                    {
                        array[i] = -1;
                        contador++;
                    }
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string text;
            int contadorNumNeg = 0;
            int[] number = new int[10];
            AddToArray(number);
            ReplaceRepeatedNumbers(number, out contadorNumNeg);
            text = ShowArray(number);
            MessageBox.Show(text);
            MessageBox.Show(contadorNumNeg.ToString());
        }
    }
}
