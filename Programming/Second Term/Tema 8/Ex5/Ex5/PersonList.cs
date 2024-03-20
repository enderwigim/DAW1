using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public class PersonList
    {
        private List<Person> _people;
        public PersonList()
        {
            _people = new List<Person>();
        }

        public int GetIndexByDNI(string dni)
        {
            int index = -1;
            for (int i = 0; i < _people.Count; i++)
            {
                if (dni.ToUpper() == _people[i].DNI)
                {
                    index = i;
                }
            }
            return index;
        }
        public int GetTypeByIndex(int index)
        {
            int type = -1;
            if (_people[index].GetType() == typeof(Student))
            {
                type = 1;
            } else if (_people[index].GetType() == typeof(Teacher))
            {
                type = 2;
            }
            return type;
        } 
        public void DeleteByIndex(int index)
        {
            _people.RemoveAt(index);
        }

        public bool IsIDInList(string dni)
        {
            bool isInList = false;
            for (int i = 0; i < _people.Count; i++)
            {
                if (_people[i].DNI == dni.ToUpper())
                {
                    isInList = true;
                }
            }
            return isInList;
        }
        public bool IsEmpty()
        {
            bool isEmpty = true;
            if (_people.Count != 0)
            {
                isEmpty = false;
            }
            return isEmpty;
        }
        public void AddStudent(Student student)
        {
            _people.Add(student);
        }
        public string ShowEveryStudent()
        {
            string text = "";
            if (_people.Any(person => person.GetType() == typeof(Student)))
            {
                for (int i = 0; i < _people.Count; i++)
                {
                    if (_people[i].GetType() == typeof(Student))
                    {
                        text += $"Datos del estudiante" +
                            $"\n{_people[i].ShowData()}";
                    }
                }
            } else
            {
                text = "There's no student in the list";
            }
            return text;
        }
        public void AddTeacher(Teacher teacher)
        {
            _people.Add(teacher);
        }
    }

}
