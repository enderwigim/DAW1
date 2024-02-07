using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] classArray = new double[] { 1.71, 1.65, 1.55 };
        double AVG(double[] array)
        {
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            avg = avg / array.Length;
            return avg;
        }

        void GreaterAndLowerCounter(double[] array, out int greater, out int lower) 
        {
            greater = lower = 0;

            for (int i = 0; i < array.Length; i++) 
            { 
                if (array[i] > AVG(array))
                {
                    greater++;
                } else
                {
                    lower++;
                }
            }
        }

        bool AllSmall(double[] array)
        {
            bool isEveryoneSmall = true;
            for (int i = 0; i < array.Length && isEveryoneSmall; i++)
            {
                if (array[i] > 1.70)
                {
                    isEveryoneSmall = false;
                }
            }
            return isEveryoneSmall;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int greater, lower;
            GreaterAndLowerCounter(classArray, out greater, out lower);
            MessageBox.Show("The guys that are taller than avg are: " + greater);
            MessageBox.Show("The guys that are smaller than avg are: " + lower);
            if (AllSmall(classArray))
            {
                MessageBox.Show("Son todos chaparritos");
            }
            else
            {
                MessageBox.Show("No son chaparritos");
            }
        }
    }
}
