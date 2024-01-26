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

namespace Ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTablas_Click(object sender, EventArgs e)
        {
            int num, multiplicacion;
            string texto = "";

            for (int i = 1; i <= 10; i++)
            {
                texto = "Tabla del " + i + "\n";
                for (int j = 1; j <= 10; j++)
                {
                    multiplicacion = i * j;
                    texto += i + " * " + j + " = " + multiplicacion + "\n";
                }
                MessageBox.Show(texto);
            }
        }
    }
}
