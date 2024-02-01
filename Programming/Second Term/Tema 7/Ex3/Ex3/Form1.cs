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

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Date> dateList = new List<Date>();

        public bool DateIsValid(Date date)
        {
            bool isValid = false;
            if (date.DMonth == 2)
            {
                if (date.DDay <= 28)
                {
                    isValid = true;
                }
            }
            else if (date.DMonth == 4 || date.DMonth == 5 || date.DMonth == 9 || date.DMonth == 11)
            {
                if (date.DDay <= 30)
                {
                    isValid = true;
                }
            } else
            {
                if (date.DDay <= 31)
                {
                    isValid = true;

                }
            }
            return isValid;
        }
        public void AddDateToList()
        {
            Date newDate = new Date();
            newDate.DDay = int.Parse(Interaction.InputBox("Add a Day to this Date"));
            newDate.DMonth = int.Parse(Interaction.InputBox("Add a Month to this Date"));
            newDate.DYear = int.Parse(Interaction.InputBox("Add a Year to this Date"));
            if (DateIsValid(newDate))
            {
                dateList.Add(newDate);
            }
            else
            {
                MessageBox.Show("The Date is not Valid");
            }
        }
        private void btnReadDate_Click(object sender, EventArgs e)
        {
            AddDateToList();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateList[0].GetDate());
        }
    }
}
