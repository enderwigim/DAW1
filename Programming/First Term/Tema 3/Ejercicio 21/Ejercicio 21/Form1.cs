using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int num;
            string texto;


            num = int.Parse(txtNum.Text);
            texto = "";
            if (num >= 1 && num <= 15)
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        if (j < 10)
                        {
                            texto += j + ",";
                        }
                        else
                        {
                            texto += j + ".";
                        }

                    }
                    texto += "\n";
                }
                MessageBox.Show(texto);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int num, i, j;
            string texto;

            num = int.Parse(txtNum.Text);
            texto = "";
            i = j = 1;
            if (num >= 1 && num <= 15)
            {
                while (i <= num)
                {
                    while (j <= 10)
                    {
                        if (j < 10)
                        {
                            texto += j + ",";
                        }
                        else
                        {
                            texto += j + ".";
                        }
                        j++;
                    }
                    j = 1;
                    i++;
                    


                }

                MessageBox.Show(texto);
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int num, i, j;
            string texto;

            num = int.Parse(txtNum.Text);
            texto = "";
            i = j = 1;
            if (num >= 1 && num <= 15)
            {
                do
                {
                    do
                    {
                        if (j < 10)
                        {
                            texto += j + ",";
                        }
                        else
                        {
                            texto += j + ".";
                        }
                        j++;
                    } while (j <= 10);
                    j = 1;
                    i++;
                    texto += "\n";
                } while (i <= num);
                MessageBox.Show(texto);
                
            }
            }
    }
}
