using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int INTENTOS = 5;
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            // Declaramos las variables. 
            bool loggedIn;
            string password, userName;
            int i;

            // Le damos valor a nuestras variables.
            i = 1;

            loggedIn = false;
            // Creamos los InputBox
            userName = Interaction.InputBox("Introduzca el nombre de usuario: ", "Ejercicio 30");
            password = Interaction.InputBox("Introduzca la contraseña: ", "Ejercicio 30");

            // Creamos un while que necesita que loggedIn sea falso y que i sea menor o igual a 4.
            while (i <= 4 && ! loggedIn) {

                // En caso de que el usuario ponga la clave y el username bien.
                if (userName == "root" && password == "1234")
                {
                    // Cambiamos la variable loggedIn a true. Cierra el bucle.
                    MessageBox.Show("Bienvenido");
                    loggedIn = true;
                }
                // En caso de que el usuario ponga la clave y el username mal.
                else
                {
                    // Si solo le queda el ultimo intento aparecera esto.
                    if (INTENTOS - i == 1)
                    {
                        MessageBox.Show("Error, introduzca bien los datos. Te queda " + INTENTOS + " intento.");
                    }
                    // Esto aparecera si le queda mas de un intento.
                    else
                    {
                        MessageBox.Show("Error, introduzca bien los datos. Te quedan " + INTENTOS + " intentos.");
                    }
                    // Volvemos a crear los InputBox.
                    userName = Interaction.InputBox("Introduzca el nombre de usuario: ", "Ejercicio 30");
                    password = Interaction.InputBox("Introduzca la contraseña: ", "Ejercicio 30");
                }
                // Aumentamos i y luego continuamos el bucle.
                i++;
            }
            /* Terminado el bucle, en caso de que el usuario haya puesto mal la clave y el usuario, mas de 5 veces. Le aparecera que
                no quedan mas intentos. */
            if (i == 5)
            {
                MessageBox.Show("Se ha superado el número de intentos permitido");
            }
        }
    }
}
