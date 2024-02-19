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

        public int GetIndexByCode(string code)
        {
            int index = -1;
            for (int i = 0; i <  courses.Count; i++)
            {
                if (courses[i].Code == code)
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

        public void RemoveCourse(int index)
        {
            courses.RemoveAt(index);
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


