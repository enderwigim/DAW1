using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 0;
            month = 0;
            year = 0;
        }

        public bool DateIsValid()
        {
            bool isValid = false;
            if (this.DMonth == 2)
            {
                if (this.DDay <= 29 && LeapYear(this.DDay))
                {
                    isValid = true;
                } else if (this.DDay <= 28)
                {
                    isValid = true;
                }
            }
            else if (this.DMonth == 4 || this.DMonth == 5 || this.DMonth == 9 || this.DMonth == 11)
            {
                if (this.DDay <= 30)
                {
                    isValid = true;
                }
            }
            else
            {
                if (this.DDay <= 31)
                {
                    isValid = true;

                }
            }
            return isValid;
        }
        private bool LeapYear(int num)
        {
            // Declaramos una variable booleana. Le agregamos un valor falso inicial.
            bool isLeap = false;
            if (num % 4 == 0)
            // En caso de que sea divisible por 4.
            {
                // Seteamos inicialmente nuestra variable a true.
                isLeap = true;
                if (num % 100 == 0 && num % 400 != 0)
                // En el caso de que esto se cumpla. isLeap volverá a false.
                {
                    isLeap = false;
                }
            }
            return isLeap;
        }
        public int DDay
        {
            get { return day; }
            set 
            { 
               day = value; 
            }
        }
        public int DMonth
        {
            get { return month; }
            set
            {
                if (value > 0 && value < 12)
                {
                    month = value;
                }
            }
        }
        public int DYear
        {
            get { return year; }
            set { year = value; }
        }

        public string GetDate()
        {
            string dateText = "";
            dateText += this.DYear + "/" + this.DMonth + "/" + this.DDay + "\n";
            return dateText;
        }
    }
}
