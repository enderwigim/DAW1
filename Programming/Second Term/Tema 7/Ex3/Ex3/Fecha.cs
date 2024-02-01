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

        public int DDay
        {
            get { return day; }
            set 
            { 
                if (value > 0 && value <= 31)
                {
                    day = value;
                } 
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
            dateText += this.DYear + "/" + this.DMonth + "/" + this.DDay;
            return dateText;
        }
    }
}
