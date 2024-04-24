using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex3.Models
{
    public class SqlDBHelper
    {
        // Attributes to save character's DataSet and DataAdapter.
        private DataSet dataSetProfs;
        private SqlDataAdapter daProfesores;
        // Attributes to save ammount of characters.
        private int _ammountOfCharacters;
        // Propiedad de solo lectura.
        public int AmmountOfCharacters
        {
            get => _ammountOfCharacters;
        }
        // Constructor del objeto. 
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper()
        {
            string filePath = Path.GetFullPath(@"..\\..\\AppData\\WowCharacters.mdf;");


            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=" + filePath + "Integrated Security=True");
            // Abrimos la conexión.
            con.Open();
            string cadenaSQL = "SELECT * From Characters";
            daProfesores = new SqlDataAdapter(cadenaSQL, con);
            dataSetProfs = new DataSet();
            daProfesores.Fill(dataSetProfs, "Characters");
            // Obtenemos el número de profesores
            _ammountOfCharacters = dataSetProfs.Tables["Characters"].Rows.Count;
            // Cerramos la conexión.
            con.Close();

        }
    }
}
