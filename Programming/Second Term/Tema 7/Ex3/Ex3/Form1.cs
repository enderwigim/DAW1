using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Date> dateList = new List<Date>();

        
        public void AddDateToList()
        {
            Date newDate = new Date();
            newDate.day = int.Parse(Interaction.InputBox("Add a Day to this Date"));
            newDate.month = int.Parse(Interaction.InputBox("Add a Month to this Date"));
            newDate.DYear = int.Parse(Interaction.InputBox("Add a Year to this Date"));
            if (newDate.DateIsValid())
            {
                dateList.Add(newDate);
            }
            else
            {
                MessageBox.Show("The Date is not Valid");
            }
        }
        public bool isDatePrevious(Date firstDate, Date newDate)
        {
            bool isDatePrevious = true;
            if (firstDate.DYear > newDate.DYear)
            {
                isDatePrevious = false;
            }
            else if (firstDate.DYear == newDate.DYear)
            {
                if (firstDate.month > newDate.month)
                {
                    isDatePrevious = false;
                }
                else if (firstDate.day == newDate.day)
                {
                    if (firstDate.day > newDate.day)
                    {
                        isDatePrevious = false;
                    }
                }
            }
            return isDatePrevious;
        }

        public void OrderList(List<Date> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (! isDatePrevious(list[i], list[j]) )
                    {
                        Date changeDate = list[i];
                        list[i] = list[j];
                        list[j] = changeDate;
                    }
                }
            }
        }
        public string ShowList(List<Date> dates)
        {
            string text = "";
            for (int i = 0; i < dateList.Count; i++)
            {
                text += dateList[i].GetDate();
            }
            return text;
        }

        private void btnReadDate_Click(object sender, EventArgs e)
        {
            DialogResult moreDates = DialogResult.Yes;
            while (moreDates == DialogResult.Yes)
            {
                AddDateToList();
                moreDates = MessageBox.Show("Do you want to add a new date?", "" ,MessageBoxButtons.YesNo);
            }
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            string text = "";
            text = ShowList(dateList);
            MessageBox.Show(text);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderList(dateList);
        }
    }
}
