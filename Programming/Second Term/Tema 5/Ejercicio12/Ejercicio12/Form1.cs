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

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] temp = new double[24];
        void AddToArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = double.Parse(Interaction.InputBox("Introduce un numero"));
        }
        void ShowArray(double[] array)
        {
            string text = "La lista de numeros es: \n";
            for (int i = 0; i < array.Length; i++)
                text += array[i] + " ";

            MessageBox.Show(text);
        }
        void CalcTmaxTminTaverage(double[] array, out double tMax, out double tMin, out double tAverage)
        {
            tMax = tMin = tAverage= array[0];
            for (int i = 1; i < array.Length;i++)
            {
                if (array[i] > tMax)
                {
                    tMax = array[i];
                }
                if (array[i] < tMin)
                {
                    tMin = array[i];
                }
                tAverage += array[i];
            }
            tAverage = Math.Round(tAverage / array.Length, 2);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AddToArray(temp);
            double tMax, tMin, tAverage;
            CalcTmaxTminTaverage(temp, out tMax, out tMin, out tAverage);
            ShowArray(temp);
            MessageBox.Show("La temperatura maxima es: " + tMax + "\nLa temperatura minima es: " + tMin + "\nLa media es: " + tAverage);
        }
    }
}
