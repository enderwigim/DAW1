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

namespace Ejercicio1
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
                text += array[i];
   
            return text;
        }
        double CalcMediaArray(int[] array)
        {
            double media = 0;
            for (int i = 0; i < array.Length; i++)
            {
                media += array[i];
            }
            media = (double)media / array.Length;
            return media;
        }
        int CalcMenor(int[] array)
        {
            int minimum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minimum)
                {
                    minimum = array[i];
                }
            }
            return minimum;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string text;
            int minimum;
            double media;
            int[] numberList = new int[10];

            AddToArray(numberList);
            text = ShowArray(numberList);
            media = CalcMediaArray(numberList);
            minimum = CalcMenor(numberList);
            MessageBox.Show(minimum.ToString());
            
        }
    }
}
