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
        public int Dday
        {
            get { return day; }
            set 
            { 
               day = value; 
            }

        }
        public int Dmonth
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

        public bool DateIsValid()
        {
            bool isValid = false;
            if (this.month == 2)
            {
                if (day <= 29 && LeapYear(day))
                {
                    isValid = true;
                }
                else if (day <= 28)
                {
                    isValid = true;
                }
            }
            else if (month == 4 || month == 5 || month == 9 || month == 11)
            {
                if (day <= 30)
                {
                    isValid = true;
                }
            }
            else
            {
                if (day <= 31)
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

        public string GetDate()
        {
            string dateText = "";
            dateText += this.DYear + "/" + this.month + "/" + this.day + "\n";
            return dateText;
        }
    }
}
