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

        public void CheckNavButtons()
        {
            if (pos == maxRegistros - 1)
            {
                btnShowNextTeacher.Enabled = false;
                btnShowLastTeacher.Enabled = false;
                
            } else
            {
                btnShowNextTeacher.Enabled = true;
                btnShowLastTeacher.Enabled = true;
            }
            if (pos == 0)
            {
                btnShowPreviousTeacher.Enabled = false;
                btnShowFirstTeacher.Enabled = false;
            } else
            {
                btnShowPreviousTeacher.Enabled = true;
                btnShowFirstTeacher.Enabled = true;
            }
        }
        public List<int> EntryIsValid()
        {
            // Esta función validará a través del siguiente sistema de codigos.
            // -1 Ha fallado el DNI
            // -2 Ha fallado el Nombre
            // -3 Han fallado los apellidos
            // -4 Ha fallado el Telefono
            // -5 Ha fallado el Email
            List<int> validationCodes = new List<int>();

            if ((txtDNI.Text.Length < 9 && txtDNI.Text.Length > 10) || txtDNI.Text == string.Empty)
            {
                validationCodes.Add(-1);
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text == string.Empty)
            {
                validationCodes.Add(-2);
            }
            if (string.IsNullOrWhiteSpace(txtApellidos.Text) || txtApellidos.Text == string.Empty)
            {
                validationCodes.Add(-3);
            }
            if (txtTlf.Text.Length != 9)
            {
                validationCodes.Add(-4);
            }
            if (!txteMail.Text.Contains('@'))
            {
                validationCodes.Add(-5);
            }
            return validationCodes;
        }
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
            btnSaveNew.Enabled = false;


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
            lblEntryNumber.Text = (int)((pos + 1)) + " de " + maxRegistros;

            CheckNavButtons();

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

            btnSaveNew.Enabled = true;
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            // Validamos el nuevo registro
            List<int> IsValid = EntryIsValid();

            if (IsValid.Count > 0)
            {
                string errorMessage = "";
                if (IsValid.Contains(-1))
                {
                    errorMessage += "*DNI\n";
                }
                if (IsValid.Contains(-2))
                {
                    errorMessage += "*Nombre\n";
                }
                if (IsValid.Contains(-3))
                {
                    errorMessage += "*Apellidos\n";
                }
                if (IsValid.Contains(-4))
                {
                    errorMessage += "*Telefono\n";
                }
                if (IsValid.Contains(-5))
                {
                    errorMessage += "*Email\n";
                }
                MessageBox.Show(errorMessage);
            }
            else
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
                MostrarRegistro(pos);
                btnSaveNew.Enabled = false;
            }
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
            DialogResult wantToDelete;
            wantToDelete = MessageBox.Show("Are you sure that you want to delete this student?", " ", MessageBoxButtons.YesNo);
            if (wantToDelete == DialogResult.Yes)
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
                MessageBox.Show("Student Deleted");
            }
        }
        
    }
}
