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
            employeeList.NewEmployee(newEmployeeName, newEmployeeAge);
        }

        private void btnShowEmployeeList_Click(object sender, EventArgs e)
        {
            string text;
            MessageBox.Show(employeeList.ShowEveryEmployee());
        }

        private void btnBirthDay_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Who is our birthday boy???");
            employeeList.HappyBirthDay(name);
        }

        private void btnAddSell_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Who did make a big sale????");
            double sale = double.Parse(Interaction.InputBox("Who did make a big sale????"));
            employeeList.AddSell(name, sale);
        }
    }
}
