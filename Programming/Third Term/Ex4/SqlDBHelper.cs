using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Microsoft.VisualBasic.Devices;
using System.Drawing;

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
            this.tableName = tableName;
            CreateConnection();

        }
        public void CreateConnection()
        {
            // This function will let us do the connection and reset the DataSet and DataAdapter in case of needing it.
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
                    entity = Course.CreateCourse(entry[0].ToString(), entry[1].ToString());

                }
            }
            return entity;
        }
        public bool UpdateRow(Entity entity, int pos)
        {
            // This boolean will not be activated just if the Primary Key is already in the database
            bool rowUpdated = false;
            int ammountOfPKs = 0;



            // We get the current entry
            DataRow entry = dataSet.Tables[tableName].Rows[pos];

            // If tableName is Profesores, we will UpdateTeacher. But if it is Students we will UpdateStudents
            if (tableName == "Profesores")
            {
                // We update the dataSet
                UpdateTeacher((Teacher)entity, ref entry);
                // With the dataSet updated we need to know if the ammountOfPK is more than 1
                ammountOfPKs = GetAmmountOfTimesIDInDataSet((Person)entity);
            }
            else if (tableName == "Alumnos")
            {

                UpdateStudent((Student)entity, ref entry);
                ammountOfPKs = GetAmmountOfTimesIDInDataSet((Person)entity);
            }
            else if (tableName == "Cursos")
            {
                UpdateCourse((Course)entity, ref entry);
                ammountOfPKs = GetAmmountOfTimesIDInDataSet((Course)entity);

            }
            // If the ammountOfPK is more than 1. That would mean that the PK is repeated in the dataSet. In that case,
            // we should not ReconnectToDB(), but reset the DataSet
            if (ammountOfPKs == 1)
            {
                rowUpdated = true;
                ReconnectToDB();
                return rowUpdated;
            }
            // We will need to update the DataSet, so we recreate the connection.
            CreateConnection();
            return rowUpdated;



        }
        public bool CreateRow(Entity entity)
        {
            bool wasCreated = false;

            // Cogemos el registro situado en la posición actual.
            DataRow entry = dataSet.Tables[tableName].NewRow();

            if (tableName == "Profesores")
            {
                if (!IsIDInDataBase((Teacher)entity) && 
                    !checkIfDNIExistInOtherTable("Alumnos", (Person)entity))
                {
                    UpdateTeacher((Teacher)entity, ref entry);

                }
                else
                {
                    return wasCreated;
                }
            }
            else if (tableName == "Alumnos")
            {
                if (!IsIDInDataBase(((Student)entity)) && 
                    !checkIfDNIExistInOtherTable("Profesores", (Person)entity))
                {
                    UpdateStudent((Student)entity, ref entry);
                }
                else
                {
                    return wasCreated;
                }
            }
            else if (tableName == "Cursos")
            {
                if (!IsIDInDataBase((Course)entity))
                {
                    UpdateCourse((Course)entity, ref entry);
                }
                else
                {
                    return wasCreated;
                }
            }

            dataSet.Tables[tableName].Rows.Add(entry);
            _ammountOfEntries++;

            ReconnectToDB();
            wasCreated = true;
            return wasCreated;



        }
        public void DeleteRow(int pos)
        {
            dataSet.Tables[tableName].Rows[pos].Delete();
            _ammountOfEntries--;

            ReconnectToDB();
        }
        public void UpdateTeacher(Teacher profesor, ref DataRow entry)
        {
            entry[0] = profesor.DNI;
            entry[1] = profesor.Name;
            entry[2] = profesor.Surname;
            entry[3] = profesor.Tlf;
            entry[4] = profesor.eMail;
        }
        public void UpdateStudent(Student student, ref DataRow entry)
        {
            entry[0] = student.DNI;
            entry[1] = student.Name;
            entry[2] = student.Surname;
            entry[3] = student.Address;
            entry[4] = student.Tlf;
        }
        public void UpdateCourse(Course course, ref DataRow entry)
        {
            entry[0] = course.ID;
            entry[1] = course.Name;
        }
        public void ReconnectToDB()
        {
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(dataSet, tableName);
        }
        public int LookBySurname(string surname)
        {
            int pos = -1;
            if (tableName != "Cursos")
            {
                for (int i = 0; i < _ammountOfEntries; i++)
                {
                    DataRow entry = dataSet.Tables[tableName].Rows[i];
                    if (entry[2].ToString().ToLower().Contains(surname.ToLower()))
                    {
                        pos = i;
                        return pos;
                    }

                }
            }

            return pos;
        }
        public string GetEveryName()
        {
            string everyName = "";
            if (tableName != "Cursos")
            {
                for (int i = 0; i < AmmountOfEntries; i++)
                {
                    Person person = (Person)GetEntry(i);
                    everyName += $"{person.Name} {person.Surname} \n";
                }

            }
            return everyName;
        }
        public bool IsIDInDataBase(Person person)
        {
            // This will let us check if the dni is in the db

            bool isInDB = false;

            for (int i = 0; i < AmmountOfEntries; i++)
            {
                DataRow entry = dataSet.Tables[tableName].Rows[i];
                if (entry[0].ToString() == person.DNI)
                {
                    isInDB = true;
                }
            }

            return isInDB;


        }
        public bool IsIDInDataBase(Course course)
        {
            // This will let us check if the id is in the db

            bool isInDB = false;
            for (int i = 0; i < AmmountOfEntries; i++)
            {
                DataRow entry = dataSet.Tables[tableName].Rows[i];
                if (entry[0].ToString() == course.ID)
                {
                    isInDB = true;
                }
            }
            return isInDB;
        }
        public int GetAmmountOfTimesIDInDataSet(Course course)
        {
            // This function will let us know if the ID of the course is more than once in the DataSet.
            // It's important to know this because this will check the current DataSet.
            int ammountOfTimes = 0;
            for (int i = 0; i < AmmountOfEntries; i++)
            {
                DataRow entry = dataSet.Tables[tableName].Rows[i];
                if (entry[0].ToString() == course.ID)
                {
                    ammountOfTimes++;
                }
            }
            return ammountOfTimes;
        }
        public int GetAmmountOfTimesIDInDataSet(Person person)
        {
            // This function will let us know if the DNI of the person is more than once in the DataSet.
            // It's important to know this because this will check the current DataSet.
            int ammountOfTimes = 0;
            for (int i = 0; i < AmmountOfEntries; i++)
            {
                DataRow entry = dataSet.Tables[tableName].Rows[i];
                if (entry[0].ToString() == person.DNI)
                {
                    ammountOfTimes++;
                }
            }
            return ammountOfTimes;
        }
        public bool checkIfDNIExistInOtherTable(string newTableName, Person person)
        {
            bool checkIfDNIExist;
            SqlDBHelper db = new SqlDBHelper(newTableName);
            checkIfDNIExist = db.IsIDInDataBase(person);
            
            return checkIfDNIExist;


        }
    }
}
