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

        // IsEmpty() checks if the list is empty.
        public bool IsEmpty()
        {
            bool isEmpty = true;
            if (students.Count != 0)
            {
                isEmpty = false;
            }
            return isEmpty;
        }
        // IsIDInList() will check if there's a student with that ID.
        public bool IsIDInList(string dni)
        {
            bool isInList = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Dni == dni)
                {
                    isInList = true;
                }
            }
            return isInList;
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
        // Add to list methods.
        public void AddStudentToList(Student new_student)
        {
            students.Add(new_student);
        }

        public void AddGradeToStudent(int index, double grade)
        {
            if (index != -1)
            {
                students[index].AddGrade(grade);
            }
            
        }

        // Remove Methods.
        public bool DeleteGradesFromStudent(string dni)
        {
            bool gradeAdded = false;
            int index = GetIndexByDNI(dni);
            if (index != -1)
            {
                students[index].DeleteGrades();
                gradeAdded = true;
            }
            return gradeAdded;
        }

        public void RemoveStudentFromList(int index)
        {
            students.RemoveAt(index);
        }

        // Show Methods
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
                if (students[i].CourseCode == courseCode.ToUpper())
                {
                    studentsInCourse += students[i].Name + "\n";
                }
            }
            return studentsInCourse;
        }

        public string ShowStudentsAVGMore5()
        {
            string studentText = "The students with AVG more than 5 are: \n";
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].IsAVGUpperThan5())
                {
                    studentText += students[i].Name + " \n";
                }
            }
            return studentText;
        }

        public string ShowStudentsAVGLess5()
        {
            string studentText = "The students with AVG less than 5 are: \n";
            for (int i = 0; i < students.Count; i++)
            {
                if (!students[i].IsAVGUpperThan5())
                {
                    studentText += students[i].Name + " \n";
                }
            }
            return studentText;
        }

        // Order List Methods
        public bool OrderByName()
        {
            bool isOrder = false;
            if (students.Count > 1)
            {
                for (int i = 0; i < students.Count - 1; i++)
                {
                    for (int j = i+1; j < students.Count; j++)
                    {
                        if (string.Compare(students[i].Name, students[j].Name) > 0)
                        {
                            Student changableStudent = students[i];
                            students[i] = students[j];
                            students[j] = changableStudent;
                        }
                    }
                }
                isOrder = true;
            }
            return isOrder;
        }


    }

}
