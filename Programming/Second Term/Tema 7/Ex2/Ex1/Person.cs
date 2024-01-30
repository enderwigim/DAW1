using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public class Person
    {
        private string name;
        private int age;
        private string phone;
        private char gender;
        private bool marry_status;

        public Person()
        {
            name = "";
            age = 0;

        }


        public string GetPerson()
        {
            string personText = "";
            personText += "Name: " + PName + "\n";
            personText += "Age: " + PAge + "\n";
            personText += "Phone: " + PPhone + "\n";
            personText += "Gender: " + PGender + "\n";
            if (PMarry)
            {
                personText += "Marry: Yes" + "\n";
            }
            else
            {
                personText += "Marry: No";
            }

            return personText;
        }




        public string PName
        {
            get { return name; }
            set { name = value; }

        }
        public int PAge
        {
            get { return age; } 
            set 
            { 
                if (value > 0 && value <= 100)
                {
                    age = value;
                }
                
            }
        }
        public string PPhone
        {
            get { return  phone; }
            set { phone = value; }
        }
        public char PGender
        {
            get { return gender; }
            set 
            { 
                if (value == 'M' || value == 'N')
                {
                    gender = value;
                }  
            }
        }
        public bool PMarry 
        {
            get { return marry_status; }
            set { marry_status = value; }
        }
    }
}
