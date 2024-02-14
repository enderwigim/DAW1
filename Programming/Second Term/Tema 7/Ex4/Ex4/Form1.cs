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

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListEmp employeeList = new ListEmp();
        

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            string newEmployeeName;
            int newEmployeeAge;

            newEmployeeName = Interaction.InputBox("What's your employees name");
            newEmployeeAge = int.Parse(Interaction.InputBox("What's your employees age?"));
            if (employeeList.NewEmployee(newEmployeeName, newEmployeeAge))
            {
                MessageBox.Show("The employee was Added.");
            }
            else
            {
                MessageBox.Show("An error ocurred.");
            }
            
        }

        private void btnShowEmployeeList_Click(object sender, EventArgs e)
        {
            string text = "";
            text = employeeList.ShowEveryEmployee();
            if (text == "")
            {
                MessageBox.Show("The list is still empty");
            } else
            {
                MessageBox.Show(text);
            }
        }

        private void btnBirthDay_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Who is our birthday boy???");
            if (employeeList.HappyBirthDay(name))
            {
                MessageBox.Show("Happy Birthday to " + name);
            } else
            {
                MessageBox.Show("An error ocurred. Check if the employee's name was inserted correctly.");
            }
            
        }

        private void btnAddSell_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Who did make a big sale????");
            double sale = double.Parse(Interaction.InputBox("What's the sale ammount"));
            if (employeeList.AddSell(name, sale))
            {
                MessageBox.Show("The sale was added correctly.");
            }
            else
            {
                MessageBox.Show("An error ocurred. Check if the employee's name was inserted correctly.");
            }
        }
    }
}
