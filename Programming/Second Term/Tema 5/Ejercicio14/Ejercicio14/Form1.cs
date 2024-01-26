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

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void addToArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = double.Parse(Interaction.InputBox("Introduce un numero"));
        }
        void showArray(double[] array)
        {
            string text = "La lista de numeros es: \n";
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0)
                    text += array[i] + " ";

            MessageBox.Show(text);
        }
        double CalcAverage(double[] array)
        {
            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            average = average / (double)array.Length;
            return average;
        }
        void CalcBiggerOrEqual(double[] array, double[] biger,double average)
        { 
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > average)
                {
                    biger[j] = array[i];
                    j++;
                }
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] temp = new double[24];
            double[] biger = new double[24];
            addToArray(temp);
            CalcBiggerOrEqual(temp, biger, CalcAverage(temp));
            showArray(biger);

        }
    }
}
