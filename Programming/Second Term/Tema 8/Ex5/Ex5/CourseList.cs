using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public class CourseList
    {
        private List<Course> courses;

        public CourseList()
        {
            courses = new List<Course>();
        }
        // IsEmpty() checks if the list is empty.
        public bool IsEmpty()
        {
            bool isEmpty = true;
            if (courses.Count != 0)
            {
                isEmpty = false;
            }
            return isEmpty;
        }

        public int GetIndexByCode(string code)
        {
            int index = -1;
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Code == code.ToUpper())
                {
                    index = i;
                }
            }
            return index;
        }
        // Add methods
        public bool AddCourse(string name, string code)
        {
            bool wasAdded = false;
            int index = GetIndexByCode(code);
            Course newCourse = new Course();
            if (index == -1)
            {
                newCourse.Name = name;
                newCourse.Code = code.ToUpper();
                courses.Add(newCourse);
                wasAdded = true;

            }
            return wasAdded;
        }
        // Remove methods
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
        // Show methods
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
