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
        private DataSet dataSetChars;
        private SqlDataAdapter daCharacters;
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
            string filePath = Path.GetFullPath(@"..\\..\\AppData\\Character.mdf;");


            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=" + filePath + "Integrated Security=True");
            // Abrimos la conexión.
            con.Open();
            string cadenaSQL = "SELECT * From character";
            daCharacters = new SqlDataAdapter(cadenaSQL, con);
            dataSetChars = new DataSet();
            daCharacters.Fill(dataSetChars, "character");
            // Obtenemos el número de profesores
            _ammountOfCharacters = dataSetChars.Tables["character"].Rows.Count;
            // Cerramos la conexión.
            con.Close();

        }
        public Character GetCharacter(int pos)
        {
            Character character = null;
            // Objeto que nos permite recoger un registro de la tabla.
            DataRow entry;

            if (pos >= 0 && pos < _ammountOfCharacters)
            {
                // Cogemos el registro de la posición pos en la tabla character
                entry = dataSetChars.Tables["character"].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y lo ponemos en el textBox correspondiente.

                character = Character.CreateCharacter(entry[0].ToString(), Convert.ToInt16(entry[1]), entry[2].ToString(),
                                                 entry[3].ToString(), Convert.ToInt16(entry[4]));
            }
            return character;
        }
        public void UpdateRow(Character character, int pos)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dataSetChars.Tables["character"].Rows[pos];
            // Metemos los datos en el registro
            dRegistro[0] = character.Name;
            dRegistro[1] = character.Class;
            dRegistro[2] = character.Faction;
            dRegistro[3] = character.Location;
            dRegistro[4] = character.Level;
            // Si quisieramos hacerlo por nombre de columna en vez de posición

            ReconnectToDB();   
        }
        public void CreateRow(Character character)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow entry = dataSetChars.Tables["character"].NewRow();
            // Metemos los datos en el registro
            entry[0] = character.Name;
            entry[1] = character.Class;
            entry[2] = character.Faction;
            entry[3] = character.Location;
            entry[4] = character.Level;

            dataSetChars.Tables["character"].Rows.Add(entry);
            _ammountOfCharacters++;

            ReconnectToDB();
        }
        public void DeleteRow(int pos)
        {
            dataSetChars.Tables["character"].Rows[pos].Delete();
            _ammountOfCharacters--;

            ReconnectToDB();
        }
        public void ReconnectToDB()
        {
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daCharacters);
            daCharacters.Update(dataSetChars, "character");
        }
    }
}
