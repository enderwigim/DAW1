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
                MessageBox.Show("An error ocurred. The employee must have a name and an age");
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
        private void btnShowEmployeeData_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Whose information do you want to see?");
            string text = employeeList.ShowAnEmployeeByName(name);
            if (text != "")
            {
                MessageBox.Show(text);
            } else
            {
                MessageBox.Show("An error ocurred. Check if the employee's name was inserted correctly");
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

        private void btnDelete_Employee_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Who's going to be fired soon?");
            if (employeeList.DeleteEmployee(name))
            {
                MessageBox.Show("Fired!");
            } else
            {
                MessageBox.Show("An error ocurred. Check if the employee's name was inserted correctly.");
            }
        }

        private void btnOrderEmployees_Click(object sender, EventArgs e)
        {
            employeeList.OrderEmployeesByName();
            MessageBox.Show("Employees ordered by name.");

        }

        private void btnMostSellerEmployee_Click(object sender, EventArgs e)
        {
            int index = employeeList.CalcMaxSell();
            if (index != -1)
            {
                MessageBox.Show(employeeList.ShowAnEmployeeByIndex(index));
            }
            else
            {
                MessageBox.Show("An error ocurred. Check if sales were added.");
            }
            
        }

        private void btnDeleteSells_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("What's the name of the employee whose sales you want to delete");
            int index = employeeList.GetIndexByName(name);
            if (index != -1)
            {

                if (employeeList.DeleteSells(index))
                {
                    MessageBox.Show("Sells Deleted");
                } else
                {
                    MessageBox.Show("An error ocurred. That employee doesn't have any sell.");
                }
            }
            MessageBox.Show("That employee doesn't exist.");

        }

        private void btnOrdenarVentas_Click(object sender, EventArgs e)
        {
            employeeList.OrderBySells();
            MessageBox.Show("Employees ordered by sales.");
        }
    }
}
