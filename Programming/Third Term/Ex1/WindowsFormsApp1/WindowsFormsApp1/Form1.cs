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



            // Cerramos la conexion
            con.Close();
        }
    }
}
