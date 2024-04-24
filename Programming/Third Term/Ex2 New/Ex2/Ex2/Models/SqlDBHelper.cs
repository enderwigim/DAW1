using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Ex2.Models
{
    public class SqlDBHelper
    {
        // Miembros para guardar el dataSet y el dataAdapter de profesores.
        private DataSet dataSetProfs;
        private SqlDataAdapter daProfesores;
        // Miembro para guardar el número de profesores.
        private int _ammountOfTeachers;
        // Propiedad de solo lectura.
        public int AmmountOfTeachers
        {
            get => _ammountOfTeachers;
        }
        // Constructor del objeto. 
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "AppData\\Instituto.mdf;";
            

            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=" + filePath + "Integrated Security=True");
            // Abrimos la conexión.
            con.Open();
            string cadenaSQL = "SELECT * From Profesores";
            daProfesores = new SqlDataAdapter(cadenaSQL, con);
            dataSetProfs = new DataSet();
            daProfesores.Fill(dataSetProfs, "Profesores");
            // Obtenemos el número de profesores
            _ammountOfTeachers = dataSetProfs.Tables["Profesores"].Rows.Count;
            // Cerramos la conexión.
            con.Close();

        }
        public Teacher GetProfesor(int pos)
        {
            Teacher profesor = null;
            // Objeto que nos permite recoger un registro de la tabla.
            DataRow entry;

            if (pos >= 0 && pos < _ammountOfTeachers)
            {
                // Cogemos el registro de la posición pos en la tabla Profesores
                entry = dataSetProfs.Tables["Profesores"].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y lo ponemos en el textBox correspondiente.

                profesor = Teacher.CreateTeacher(entry[0].ToString(), entry[1].ToString(), entry[2].ToString(),
                                                 entry[3].ToString(), entry[4].ToString());
            }
            return profesor;
        }
        public void UpdateRow(Teacher profesor, int pos)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dataSetProfs.Tables["Profesores"].Rows[pos];
            // Metemos los datos en el registro
            dRegistro[0] = profesor.dni;
            dRegistro[1] = profesor.Name;
            dRegistro[2] = profesor.Surname;
            dRegistro[3] = profesor.Tlf;
            dRegistro[4] = profesor.eMail;
            // Si quisieramos hacerlo por nombre de columna en vez de posición

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dataSetProfs, "Profesores");
        }
        public void CreateRow(Teacher profesor)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow entry = dataSetProfs.Tables["Profesores"].NewRow();
            // Metemos los datos en el registro
            entry[0] = profesor.dni;
            entry[1] = profesor.Name;
            entry[2] = profesor.Surname;
            entry[3] = profesor.Tlf;
            entry[4] = profesor.eMail;

            dataSetProfs.Tables["Profesores"].Rows.Add(entry);
            _ammountOfTeachers++;

            ReconnectToDB();
        }
        public void DeleteRow(int pos)
        {
            dataSetProfs.Tables["Profesores"].Rows[pos].Delete();
            _ammountOfTeachers--;

            ReconnectToDB();
        }
        public void ReconnectToDB()
        {
            // Reconectamos con el da y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daProfesores);
            daProfesores.Update(dataSetProfs, "Profesores");
        }
        public int LookBySurname(string surname)
        {
            int pos = -1;
            for (int i = 0; i < _ammountOfTeachers; i++)
            {
                DataRow entry = dataSetProfs.Tables["Profesores"].Rows[i];
                if (entry[2].ToString().ToLower().Contains(surname.ToLower()))
                {
                    pos = i;
                    return pos;
                }

            }
            return pos;
        }
        public string GetEveryTeacher()
        {
            string teacher = "";
            for (int i = 0; i < _ammountOfTeachers; i++)
            {
                DataRow entry = dataSetProfs.Tables["Profesores"].Rows[i];
                teacher += $"{entry[1]} {entry[2]}\n";
            }
            return teacher;
        }
    }
}
