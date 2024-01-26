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

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool validarNota (double nota)
        {
            bool validada = false;

            if (nota > 0 && nota <= 10)
            {
                validada = true;
            }
            return (validada);
        }
        double notaMedia (double n1, double n2, double n3)
        {
            double notaMedia = (n1 + n2 + n3) / 3;
            return notaMedia;
        }
        private void btnCalcularNota_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nMedia;


            nota1 = double.Parse(Interaction.InputBox("Ejercicio 8", "Ingrese la primera calificación"));
            nota2 = double.Parse(Interaction.InputBox("Ejercicio 8", "Ingrese la segunda calificación"));
            nota3 = double.Parse(Interaction.InputBox("Ejercicio 8", "Ingrese la ultima calificación"));

            if (validarNota(nota1) && validarNota(nota2) && validarNota(nota3))
            {
                nMedia = notaMedia(nota1, nota2, nota3);
                MessageBox.Show("La nota media del alumno es: " + nMedia);
            }
            else
            {
                MessageBox.Show("Ingrese correctamente las calificaciones");
            }


        }
    }
}
