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
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Global Variables
        DataSet dataSetProfs;
        SqlDataAdapter dataAdapterProfs;
        private int pos;
        private int maxRegistros;
        private bool isANewEntry = false;
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
        
        // Buttons
        private void btnShowFirstTeacher_Click(object sender, EventArgs e)
        {
            UpdateIfWasChangedAndIsValid();
            pos = 0;
            MostrarRegistro(pos);
        }

        private void btnShowNextTeacher_Click(object sender, EventArgs e)
        {
            UpdateIfWasChangedAndIsValid();
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
            UpdateIfWasChangedAndIsValid();
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
            UpdateIfWasChangedAndIsValid();
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
            btnAddTeacher.Enabled = false;
            isANewEntry = true;
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
                errorMessage = "Los siguientes parametros son erroneos: \n" + errorMessage;
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

                isANewEntry = false;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRow(pos);
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult wantToDelete;
            wantToDelete = MessageBox.Show("Are you sure that you want to delete this teacher?", " ", MessageBoxButtons.YesNo);
            if (wantToDelete == DialogResult.Yes)
            {
                // Eliminamos el registro situado en la posición actual.
                dataSetProfs.Tables["Profesores"].Rows[pos].Delete();
                // Tenemos un registro menos
                maxRegistros--;
                if (maxRegistros >= 1)
                {
                    // Nos vamos al primer registro y lo mostramos
                    pos = 0;

                    // Reconectamos con el dataAdapter y actualizamos la BD
                    SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
                    dataAdapterProfs.Update(dataSetProfs, "Profesores");

                    MostrarRegistro(pos);
                    MessageBox.Show("Student Deleted");
                }
                else
                {
                    MostrarVacio();
                }
            }
        }

        private void btnLookBySurname_Click(object sender, EventArgs e)
        {
            string surname = Interaction.InputBox("What teacher do you want to look for?");
            int index = GetIndexBySurname(surname);
            if (index != -1)
            {
                MostrarRegistro(index);
            } else
            {
                MessageBox.Show("That teacher is not in the database");
            }
        }


        private void btnShowEveryTeacher_Click(object sender, EventArgs e)
        {
            string everyTeacher = GetEveryTeacher();
            MessageBox.Show("The teachers are: \n" + everyTeacher);

        }
        // TextBoxes
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (EntryIsValid().Count == 0)
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (EntryIsValid().Count == 0)
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txtTlf_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (EntryIsValid().Count == 0)
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (EntryIsValid().Count == 0)
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txteMail_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (EntryIsValid().Count == 0)
                {
                    btnUpdate.Enabled = true;
                }
            }
        }
    
        // Functions
        public bool checkIfChanges(int pos)
        {
            bool itChanged = false;
            DataRow entry = dataSetProfs.Tables["Profesores"].Rows[pos];

            if (txtDNI.Text != entry["DNI"].ToString())
            {
                itChanged = true;
            }
            if (txtNombre.Text != entry["Nombre"].ToString())
            {
                itChanged = true;
            }
            if (txtApellidos.Text != entry["Apellido"].ToString())
            {
                itChanged = true;
            }
            if (txtTlf.Text != entry["Tlf"].ToString())
            {
                itChanged = true;
            }
            if (txteMail.Text != entry["Email"].ToString())
            {
                itChanged = true;
            }
            return itChanged;
        }
        public void UpdateIfWasChangedAndIsValid()
        {
            if (EntryIsValid().Count == 0)
            {
                if (checkIfChanges(pos))
                {
                    DialogResult wantToUpdate = MessageBox.Show("Do you want to update this teacher data?", " ", MessageBoxButtons.YesNo);
                    if (wantToUpdate == DialogResult.Yes)
                    {
                        UpdateRow(pos);
                    }
                }
            }
            else
            {
                MessageBox.Show("Changes were detected, but as they are not valid, data wasnt updated");
            }
        }

        public string GetEveryTeacher()
        {


            string teacherList = "";
            for (int i = 0; i <= maxRegistros - 1; i++)
            {
                DataRow entry = dataSetProfs.Tables["Profesores"].Rows[i];
                teacherList += entry["Nombre"] + " " + entry["Apellido"] + "\n";
            }
            return teacherList;

        }
        public int GetIndexBySurname(string surname)
        {
            int rowIndex = -1;
            for (int i = 0; i <= maxRegistros - 1; i++)
            {
                DataRow entry = dataSetProfs.Tables["Profesores"].Rows[i];
                bool entryContainsSurname = entry["Apellido"].ToString().ToUpper().Contains(surname.ToUpper());
                if (entryContainsSurname)
                {
                    rowIndex = i;
                }
            }
            return rowIndex;
        }
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
            } 
            else
            {
                btnShowPreviousTeacher.Enabled = true;
                btnShowFirstTeacher.Enabled = true;
            }
        }
        public void CheckButtons()
        {
            if (maxRegistros >= 1)
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnShowEveryTeacher.Enabled = true;
                btnSaveNew.Enabled = false;
                btnLookBySurname.Enabled = true;
                btnAddTeacher.Enabled = true;
                btnUpdate.Enabled = false;
            } else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnSaveNew.Enabled = false;
                btnShowEveryTeacher.Enabled = false;
                btnLookBySurname.Enabled = false;
                btnShowNextTeacher.Enabled = false;
                btnShowLastTeacher.Enabled = false;
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
            CheckButtons();

        }
        public void MostrarVacio()
        {
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtTlf.Text = string.Empty;
            txteMail.Text = string.Empty;

            lblEntryNumber.Text = "0 de 0";

            CheckButtons();

        }
        public void UpdateRow(int pos)
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

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapterProfs);
            dataAdapterProfs.Update(dataSetProfs, "Profesores");
        }
        
    }

}
