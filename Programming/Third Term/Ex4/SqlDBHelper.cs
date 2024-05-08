using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex4
{
    public class SqlDBHelper
    {

        // Miembros para guardar el dataSet y el dataAdapter de profesores.
        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;
        // Miembro para guardar el número de profesores.
        private int _ammountOfEntries;
        // Propiedad de solo lectura.
        public int AmmountOfEntries
        {
            get => _ammountOfEntries;
        }
        // Constructor del objeto. 
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper()
        {
            string filePath = Path.GetFullPath(@"..\\..\\AppData\\Character.mdf;");
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=" + filePath + "Integrated Security=True");

            // Abrimos la conexión.
            con.Open();
            string cadenaSQL = "SELECT * From Profesores";
            dataAdapter = new SqlDataAdapter(cadenaSQL, con);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Profesores");
            // Obtenemos el número de profesores
            _ammountOfEntries = dataSet.Tables["Profesores"].Rows.Count;
            // Cerramos la conexión.
            con.Close();

        }
    }
}
