using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Extra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            int num;
            string text;

            num = int.Parse(txtNum.Text);
            text = "";
            for(int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    text += "*";
                }
                text += "\n";
            }
            lblAsterisco1.Text = text;

        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            int num, contador;
            string text;

            num = int.Parse(txtNum.Text);
            
            text = "";
            contador = num;
            for (int i = 1; i <= num; i++)
            {
                
                for (int j = 1; j <= num; j++)
                {
                    
                    if (j < contador)
                    {
                        text += " ";
                    }
                    else
                    {
                        text += "*";
                    }
                    
                }
                contador--;
                text += "\n";
                
            }
            lblAsterisco2.Text = text;
        }
    }
}
