using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Ex3.Models
{
    public class SqlDBHelper
    {
        // Attributes to save character's DataSet and DataAdapter.
        private DataSet dataSetChars;
        private SqlDataAdapter daCharacters;
        // Attributes to save ammount of characters.
        private int _ammountOfCharacters;
        
        
        public int AmmountOfCharacters
        {
            get => _ammountOfCharacters;
        }
        


        public SqlDBHelper()
        {
            RefreshDB();

        }
        public void RefreshDB()
        {
            // This function creates the connections and update the dataSet and dataAdapter.
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
            DataRow entry = dataSetChars.Tables["character"].Rows[pos];
            // Metemos los datos en el registro
            entry[0] = character.Name;
            entry[1] = character.Class;
            entry[2] = character.Faction;
            entry[3] = character.Location;
            entry[4] = character.Level;
            // Si quisieramos hacerlo por nombre de columna en vez de posición

            ReconnectToDB();   
        }
        public bool CreateRow(Character character)
        {
            bool wasCreated = false;
            try
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
                wasCreated = true;
                return wasCreated;
            } catch
            {
                return wasCreated;
            }
            
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
        public bool CheckIfChanged(int pos, Character newCharacter)
        {
            bool itChanged = true;
            DataRow entry = dataSetChars.Tables["character"].Rows[pos];
            // Metemos los datos en el registro
            if (entry[0].ToString() == newCharacter.Name && Convert.ToInt16(entry[1]) == (int)newCharacter.Class && entry[2].ToString() == newCharacter.Faction && entry[3].ToString() == newCharacter.Location
                && Convert.ToInt16(entry[4]) == newCharacter.Level)
                itChanged = false;
            return itChanged;
        }
    }
}
