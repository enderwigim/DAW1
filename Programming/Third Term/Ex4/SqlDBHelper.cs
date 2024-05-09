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
        private string tableName;
        // Propiedad de solo lectura.
        public int AmmountOfEntries
        {
            get => _ammountOfEntries;
        }
        // Constructor del objeto. 
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper(string tableName)
        {
            string filePath = Path.GetFullPath(@"..\\..\\AppData\\Instituto.mdf;");
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=" + filePath + "Integrated Security=True");

            // Abrimos la conexión.
            con.Open();
            string cadenaSQL = "SELECT * From " + tableName;
            dataAdapter = new SqlDataAdapter(cadenaSQL, con);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, tableName);
            // Obtenemos el número de profesores
            _ammountOfEntries = dataSet.Tables[tableName].Rows.Count;
            // Cerramos la conexión.
            con.Close();
            this.tableName = tableName;

        }
        public Entity GetEntry(int pos)
        {
            // As everything is an Entity
            Entity entity = null;

            DataRow entry;

            if (pos >= 0 && pos < _ammountOfEntries)
            {
                
                entry = dataSet.Tables[tableName].Rows[pos];
                
                // If attribute tableName is Profesores, we will create a Teacher, but if it's Alumnos 
                // we will get a Student
                if (tableName == "Profesores")
                {
                    entity = Teacher.CreateTeacher(entry[0].ToString(), entry[1].ToString(), entry[2].ToString(),
                                                 entry[3].ToString(), entry[4].ToString());
                }
                else if (tableName == "Alumnos")
                {
                    entity = Student.CreateStudent(entry[0].ToString(), entry[1].ToString(), entry[2].ToString(),
                                                 entry[3].ToString(), entry[4].ToString());
                }
                else if (tableName == "Cursos")
                {

                }
            }
            return entity;
        }
        public void UpdateRow(Entity entity, int pos)
        {
            // We get the current entry
            DataRow entry = dataSet.Tables[tableName].Rows[pos];
            // If tableName is Profesores, we will UpdateTeacher. But if it is Students we will UpdateStudents
            if (tableName == "Profesores")
            {
                UpdateTeacher((Teacher)entity, ref entry);
            }

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataSet, tableName);
        }
        public void UpdateTeacher(Teacher profesor, ref DataRow entry)
        {
            entry[0] = profesor.DNI;
            entry[1] = profesor.Name;
            entry[2] = profesor.Surname;
            entry[3] = profesor.Tlf;
            entry[4] = profesor.eMail;
        }
    }
}
