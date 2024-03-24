using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public void OrderStudents()
        {
            for (int i = 0; i < _people.Count - 1; i++)
            {
                for (int j = i + 1; j < _people.Count; j++)
                {
                    if (_people[i].GetType() == typeof(Student) && _people[j].GetType() == typeof(Student))
                    {
                        if (string.Compare(_people[i].Name, _people[j].Name) > 0)
                        {
                            Student auxStudent = (Student)_people[i];
                            _people[i] = _people[j];
                            _people[j] = auxStudent;
                        }
                    }
                }
            }
        }
        public string ShowOneStudentByName(string name)
        {
            string text = "That DNI isn't in the list";
            for (int i = 0; i < _people.Count; i++)
            {
                if (_people[i].Name.ToLower() == name.ToLower())
                {
                    text = "That DNI is not from a student";
                    if (GetTypeByIndex(i) == 1)
                    {
                        text = _people[i].ShowData();
                    }
                }

            }
            return text;
        }
        public int AddGradeToStudent(string dni, int grade)
        {
            /*
             * Devolveremos un validationCode con el que controlaremos si se ha agregado la nota o no.
             * validationCode = -1 SI NO SE ENCUENTRA EN LA LISTA
             * validationCode = -2  SI NO ES ALUMNO
             * validationCode = 1 Si se realiza con exito.
             */
            int validationCode = -1;
            int index = GetIndexByDNI(dni);
            if (index != -1)
            {
                validationCode = -2;
                if (GetTypeByIndex(index) == 1)
                {
                    ((Student)_people[index]).AddGrades(grade);
                    validationCode = 1;
                }
            }
            return validationCode;
        }
        public int RemoveGradeToStudent(string dni)
        {
            /*
            * Devolveremos un validationCode con el que controlaremos si se ha agregado la nota o no.
            * validationCode = -1 SI NO SE ENCUENTRA EN LA LISTA
            * validationCode = -2  SI NO ES ALUMNO
            * validationCode = 1 Si se realiza con exito.
            */
            int validationCode = -1;
            int index = GetIndexByDNI(dni);
            if (index != -1)
            {
                validationCode = -2;
                if (GetTypeByIndex(index) == 1)
                {
                    ((Student)_people[index]).DeleteGrades();
                    validationCode = 1;
                }
            }
            return validationCode;


        }
        public string ShowStudentsAVGMore5()
        {
            string studentText = "There's no students in the list";
            if (_people.Any(person => person.GetType() == typeof(Student)))
            {
                studentText = "";
                for (int i = 0; i < _people.Count; i++)
                {
                    if (((Student)_people[i]).IsAVGUpperThan5())
                    {
                        studentText += _people[i].Name + " \n";
                    }
                }
            }
            return studentText;
        }
        public string ShowStudentsAVGLess5()
        {
            string studentText = "There's no students in the list";
            if (_people.Any(person => person.GetType() == typeof(Student)))
            {
                studentText = "";
                for (int i = 0; i < _people.Count; i++)
                {
                    if (!((Student)_people[i]).IsAVGUpperThan5())
                    {
                        studentText += _people[i].Name + " \n";
                    }
                }
            }
            return studentText;
        }
        public string ShowEveryStudentInCourse(string courseCode)
        {
            string studentsInCourse = "";
            for (int i = 0; i < _people.Count; i++)
            {
                if (((Student)_people[i]).CourseCode == courseCode.ToUpper())
                {
                    studentsInCourse += _people[i].Name + "\n";
                }
            }
            return studentsInCourse;
        }

        public void AddTeacher(Teacher teacher)
        {
            _people.Add(teacher);
        }

        public int DeleteTeacher(string dni)
        {
            int validationCode = -1;
            if (_people.Any(person => person.GetType() == typeof(Teacher)))
            {
                validationCode = -2;
                int index = GetIndexByDNI(dni);
                if (index != -1)
                {
                    validationCode = -3;
                    if (GetTypeByIndex(index) == 2)
                    {
                        _people.RemoveAt(index);
                        validationCode = 1;
                    }
                }

            }
            return validationCode;
        }

        public bool isEmailInList(string email)
        {
            bool isEmailInList = false;
            for (int i = 0; i < _people.Count; i++)
            {
                if (_people[i].GetType() == typeof(Teacher))
                {
                    if (((Teacher)_people[i]).Email == email)
                    {
                        isEmailInList = true;
                    }

                }
            }
            return isEmailInList;
        }
        public string ShowTeachers()
        {
            string everyTeacher = "";
            for (int i = 0; i < _people.Count; i++)
            {
                everyTeacher += _people[i].ShowData() + "\n";
            }
            return everyTeacher;
        }
        public string ShowATeacher(string dni)
        {
            string teacherData = "That teacher doesn't exist";
            int index = GetIndexByDNI(dni);
            if (index != -1)
            {
                teacherData = _people[index].ShowData();
            }
            return teacherData;
        }
        public void OrderTeachers()
        {
            for (int i = 0; i < _people.Count - 1; i++)
            {
                for (int j = i + 1; j < _people.Count; j++)
                {
                    if (_people[i].GetType() == typeof(Teacher) && _people[j].GetType() == typeof(Teacher))
                    {
                        if (string.Compare(_people[i].Name, _people[j].Name) > 0)
                        {
                            Teacher auxStudent = (Teacher)_people[i];
                            _people[i] = _people[j];
                            _people[j] = auxStudent;
                        }
                    }
                }
            }
        }
        public int AddTeachersSubject(string dni, string subjectName)
        {
            // ValidationCode =
            // -1 = No hay Teacher en _people
            // -2 = Ese DNI no esta en la lista
            // -3 = Ese DNI no es de un profesor
            // -4 = El profesor ya tiene esa materia ingresada.
            int validationCode = -1;
            if (_people.Any(person => person.GetType() == typeof(Teacher)))
            {
                validationCode = -2;
                int index = GetIndexByDNI(dni);
                if (index != -1)
                {
                    validationCode = -3;
                    if (GetTypeByIndex(index) == 2)
                    {
                        validationCode = -4;
                        if (((Teacher)_people[index]).AddSubject(subjectName))
                        {
                            validationCode = 1;
                        }
                    }
                }
            }
            return validationCode;
        }
        public int RemoveEverySubject(string dni)
        {
            // ValidationCode =
            // -1 = No hay Teacher en _people
            // -2 = Ese DNI no esta en la lista
            // -3 = Ese DNI no es de un profesor
            int validationCode = -1;
            if (_people.Any(person => person.GetType() == typeof(Teacher)))
            {
                validationCode = -2;
                int index = GetIndexByDNI(dni);
                if (index != -1)
                {
                    validationCode = -3;
                    if (GetTypeByIndex(index) == 2)
                    {
                        ((Teacher)_people[index]).RemoveSubjects();
                        validationCode = 1;
                    }
                }
            }
            return validationCode;
        }
        public int RemoveASubject(string subject, string dni)
        {
            // ValidationCode =
            // -1 = No hay Teacher en _people
            // -2 = Ese DNI no esta en la lista
            // -3 = Ese DNI no es de un profesor
            // -4 = Esa materia no es impartida por el profesor
            int validationCode = -1;
            if (_people.Any(person => person.GetType() == typeof(Teacher)))
            {
                int index = GetIndexByDNI(dni);
                validationCode = -2;
                if (index != -1)
                {
                    validationCode = -3;
                    if (GetTypeByIndex(index) == 2)
                    {
                        validationCode = -4;
                        if (((Teacher)_people[index]).RemoveJustOneSubject(subject))
                        {
                            validationCode = 1;
                        }
                    }
                }
            }
            return validationCode;
        }
        public string ShowTeachersBySubject(string subject)
        {
            string teachersText = "";
            for (int i = 0; i < _people.Count; i++)
            {
                if (_people[i].GetType() == typeof(Teacher))
                {
                    if (((Teacher)_people[i]).HasSubject(subject))
                        teachersText += _people[i].Name + "\n";

                }
            }
            return teachersText;
        }
    }

}
