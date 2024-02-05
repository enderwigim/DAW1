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

        double[] Temps = new double[5];

        void ReadArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Interaction.InputBox("Add a number"));
            }
        }
        double GetMax(double[] array)
        {
            double max = 0;
            for (int i = 0; i  < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        double GetMin(double[] array)
        {
            double min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        double GetAVG(double[] array)
        {
            double sum = 0;
            double avg;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            avg = sum / array.Length;
            return avg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = "The max temp is: " + GetMax(Temps) + "\n";
            text += "The min temp is: " + GetMin(Temps) + "\n";
            text += "The avg temp is: " + GetAVG(Temps) + "\n";
            MessageBox.Show(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadArray(Temps);
        }
    }
}
