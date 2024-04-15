using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet dataSetProfs;
        SqlDataAdapter dataAdapterProfs;
        private int pos;
        private int maxRegistros;
        private void Form1_Load(object sender, EventArgs e)
        {
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sanlor2\\Desktop\\Repos\\1Daw\\1daw\\Programming\\Third Term\\Ex1\\WindowsFormsApp1\\WindowsFormsApp1\\App_Data\\Instituto.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(cadenaConexion);
            // Abrimos la conexión.
            con.Open();

            string cadenaSQL = "SELECT * From Profesores";
            dataAdapterProfs = new SqlDataAdapter(cadenaSQL, con);
            dataSetProfs = new DataSet();
            dataAdapterProfs.Fill(dataSetProfs, "Profesores");

            pos = 0;
            maxRegistros = dataSetProfs.Tables["Profesores"].Rows.Count;
            MostrarRegistro(pos);

            // Cerramos la conexion
            con.Close();
        }
        public void MostrarRegistro(int pos)
        {
            // Objeto que nos permite recoger un registro de la tabla.
            DataRow dRegistro;
            // Cogemos el registro de la posición pos en la tabla Profesores
            dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
            // Cogemos el valor de cada una de las columnas del registro
            // y lo ponemos en el textBox correspondiente.

            txtDNI.Text = dRegistro[0].ToString();
            txtNombre.Text = dRegistro[1].ToString();
            txtApellidos.Text = dRegistro[2].ToString();
            txtTlf.Text = dRegistro[3].ToString();
            txteMail.Text = dRegistro[4].ToString();
            lblEntryNumber.Text = (int)(pos++) + " de " + maxRegistros; 

        }

        private void btnShowFirstTeacher_Click(object sender, EventArgs e)
        {
            
            pos = 0;
            MostrarRegistro(pos);
        }

        private void btnShowNextTeacher_Click(object sender, EventArgs e)
        {
            if (pos != maxRegistros - 1)
            {
                pos++;
            }
            else
            {
                pos = 0;
            }
            MostrarRegistro(pos);
        }

        private void btnShowPreviousTeacher_Click(object sender, EventArgs e)
        {
            if (pos != 0)
            {
                pos--;
            }
            else
            {
                pos = maxRegistros - 1;
            }
            MostrarRegistro(pos);
            
        }

        private void btnShowLastTeacher_Click(object sender, EventArgs e)
        {
            pos = maxRegistros - 1;
            MostrarRegistro(pos);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTlf.Clear();
            txteMail.Clear();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dataSetProfs.Tables["Profesores"].NewRow();
            // Metemos los datos en el nuevo registro
            dRegistro[0] = txtDNI.Text;
            dRegistro[1] = txtNombre.Text;
            dRegistro[2] = txtApellidos.Text;
            dRegistro[3] = txtTlf.Text;
            dRegistro[4] = txteMail.Text;

            // Añadimos el registro al Dataset
            dataSetProfs.Tables["Profesores"].Rows.Add(dRegistro);
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
            dataAdapterProfs.Update(dataSetProfs, "Profesores");
            // Actualizamos el número de registros y la posición en la tabla
            maxRegistros++;
            pos = maxRegistros - 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
            // Metemos los datos en el registro
            dRegistro[0] = txtDNI.Text;
            dRegistro[1] = txtNombre.Text;
            dRegistro[2] = txtApellidos.Text;
            dRegistro[3] = txtTlf.Text;
            dRegistro[4] = txteMail.Text;
            // Si quisieramos hacerlo por nombre de columna en vez de posición
            /* dRegistro["DNI"] = txtDNI.Text;
            dRegistro["Nombre"] = txtNombre.Text;
            dRegistro["Apellido"] = txtApellidos.Text;
            dRegistro["Tlf"] = txtTlf.Text;
            dRegistro["EMail"] = txteMail.Text;*/
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
            dataAdapterProfs.Update(dataSetProfs, "Profesores");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Eliminamos el registro situado en la posición actual.
            dataSetProfs.Tables["Profesores"].Rows[pos].Delete();
            // Tenemos un registro menos
            maxRegistros--;
            // Nos vamos al primer registro y lo mostramos
            pos = 0;
            MostrarRegistro(pos);
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
            dataAdapterProfs.Update(dataSetProfs, "Profesores");
        }
    }
}
