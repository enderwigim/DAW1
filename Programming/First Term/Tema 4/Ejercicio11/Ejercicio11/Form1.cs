using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool leapYear(int num)
        {
            bool isLeap;
            if (num % 4 == 0)
            {
                if (num % 100 == 0)
                {
                    if (num % 400 == 0)
                    {
                        isLeap = true;
                    }
                    else
                    {
                        isLeap = false;
                    }
                }
                else
                {
                    isLeap = true;
                }
            }
            else
            {
                isLeap = false;
            }
            return isLeap;
        }
        private void btnEsBisiesto_Click(object sender, EventArgs e)
        {
            int year;
            bool isLeap;

            year = int.Parse(txtYear.Text);
            isLeap = leapYear(year);
            if (isLeap)
            {
                MessageBox.Show("El año " + year + " es bisiesto.");
            }
            else
            {
                MessageBox.Show("El año " + year + " no es bisiesto.");
            }
            
        }
    }
}
