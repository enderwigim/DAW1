using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int exponente, baseExponente, resultado;

            resultado = 1;
            exponente = int.Parse(txtExponente.Text);
            baseExponente = int.Parse(txtBase.Text);

            for (int i = 1; i <= exponente; i++)
            {
                resultado *= baseExponente;
            }
            MessageBox.Show(resultado.ToString());
        }
    }
}
