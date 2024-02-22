using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class TeachersList
    {
        private List<Teacher> teacherList;


        public TeachersList()
        {
            teacherList = new List<Teacher>();
        }

        public bool IsEmpty()
        {
            bool IsEmpty = true;
            if (teacherList.Count != 0)
            {
                IsEmpty = false;
            }
            return IsEmpty;
        }

        public int GetIndexByDni(string dni)
        {
            int index = -1;
            for (int i = 0; i < teacherList.Count; i++)
            {
                if (teacherList[i].Dni == dni.ToUpper())
                {
                    index = i;
                }
            }
            return index;
        }

        public void AddTeacherToList(string name, string dni, string phoneNumber, string courseCode)
        {
            Teacher newTeacher = new Teacher(name, dni, phoneNumber, courseCode);
            teacherList.Add(newTeacher);
        }

        public bool DeleteTeacherFromList(string dni)
        {
            bool wasDeleted = false;
            int index = GetIndexByDni(dni);
            if (index != -1)
            {
                teacherList.RemoveAt(index);
                wasDeleted = true;
            }
            return wasDeleted;
        }

        public string ShowTeachers()
        {
            string everyTeacher = "";
            for (int i = 0; i < teacherList.Count; i++)
            {
                everyTeacher += teacherList[i].ShowTeacher() + "\n";
            }
            return everyTeacher;
        }

        public string ShowATeacher(string dni)
        {
            string teacherData = "That teacher doesn't exist";
            int index = GetIndexByDni(dni);
            if (index != -1)
            {
                teacherData = teacherList[index].ShowTeacher();
            }
            return teacherData;
        }

        public void OrderByName()
        {
            for (int i = 0; i < teacherList.Count - 1; i++)
            {
                for (int j = i + 1; j < teacherList.Count; j++)
                {
                    if (string.Compare(teacherList[i].Name, teacherList[j].Name) > 0)
                    {
                        Teacher changableTeacher = teacherList[i];
                        teacherList[i] = teacherList[j];
                        teacherList[j] = changableTeacher;
                    }
                }
            }
        }
    }
}
