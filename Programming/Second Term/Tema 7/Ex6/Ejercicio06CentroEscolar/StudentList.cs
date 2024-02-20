using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class StudentList
    {
        private List<Student> students;

        public StudentList()
        {
            students = new List<Student>();
        }

        public bool isEmpty()
        {
            bool isEmpty = false;
            if (students.Count != 0)
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        public int GetIndexByDNI(string dni)
        {
            int index = -1;
            for (int i = 0; i <  students.Count; i++)
            {
                if (dni.ToUpper() == students[i].Dni)
                {
                    index = i;
                }
            }
            return index;
        }
        public void AddStudentToList(Student new_student)
        {
            students.Add(new_student);
        }
        public void RemoveStudentFromList(int index)
        {
            students.RemoveAt(index);
        }

        public string ShowStudentAtIndex(int index)
        {
            string studentInfo = students[index].ShowStudent();
            return studentInfo;
        }
        public string ShowEveryStudent()
        {
            string text = "";
            for (int i = 0; i < students.Count; i++)
            {
                text += students[i].ShowStudent();
            }
            return text;
        }

        public string ShowEveryStudentInCourse(string courseCode)
        {
            string studentsInCourse = "";
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].CourseCode == courseCode)
                {
                    studentsInCourse = students[i].Name + "\n";
                }
            }
            return studentsInCourse;
        }
    }

}
