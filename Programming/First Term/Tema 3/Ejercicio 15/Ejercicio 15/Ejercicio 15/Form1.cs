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

namespace Ejercicio_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMayMen_Click(object sender, EventArgs e)
        {
            int num, mayor, menor;
            string textoMay, textoMen;

            num = int.Parse(Interaction.InputBox("Introduzca un número", "Ejercicio 15"));
            mayor = menor = num;

            textoMay = "Mayor: ";
            textoMen = "Menor: ";

            lblMayor.Text = textoMay + num;
            lblMenor.Text = textoMen + num;
            while (num > 0)
            {
                if (num > mayor)
                {
                    mayor = num;
                    lblMayor.Text = textoMay + mayor;
                }
                if (num < menor)
                {
                    menor = num;
                    lblMenor.Text = textoMen + menor;
                }    
                num = int.Parse(Interaction.InputBox("Introduzca un número", "Ejercicio 15"));
            }
        }
    }
}
