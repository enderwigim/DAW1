using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class CourseList
    {
        private List<Course> courses;

        public CourseList()
        {
            courses = new List<Course>();
        }

        public bool isEmpty()
        {
            bool isEmpty = false;
            if (courses.Count != 0)
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        public int GetIndexByCode(string code)
        {
            int index = -1;
            for (int i = 0; i <  courses.Count; i++)
            {
                if (courses[i].Code.ToLower() == code.ToLower())
                {
                    index = i;
                }
            }
            return index;
        }

        public bool AddCourse(string name, string code)
        {
            bool wasAdded = false;
            int index = GetIndexByCode(code);
            Course newCourse = new Course();
            if (index == -1)
            {
                newCourse.Name = name;
                newCourse.Code = code;
                courses.Add(newCourse);
                wasAdded = true;

            }
            return wasAdded;
        }

        public bool RemoveCourse(string code)
        {
            bool wasRemoved = false;
            int index = GetIndexByCode(code);
            if (index != -1)
            {
                courses.RemoveAt(index);
                wasRemoved = true;
            }
            return wasRemoved;
        }

        public string ShowEveryCourse()
        {
            string text = "";
            for (int i = 0; i < courses.Count; i++)
            {
                text += courses[i].ToString();
            }
            return text;
        }
        
    }
}


