using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class ListEmp
    {
        // Atributos
        private List<Empleado> employees;

        public ListEmp()
        {
            employees = new List<Empleado>();
        }

        public int GetIndexByName(string name)
        {
            int index = -1;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Nombre.ToLower() == name.ToLower())
                {
                    index = i;
                }
            }
            return index;
        }
        
        public void NewEmployee(string name, int age)
        {
            Empleado new_employee = new Empleado();
            new_employee.Nombre = name;
            new_employee.Edad = age;
            employees.Add(new_employee);
        }

        public string ShowEveryEmployee()
        {
            string text = "";
            for (int i = 0;  i < employees.Count; i++)
            {
                text += employees[i].MostrarDatos() + "\n";
            }
            return text;
        }

        public bool HappyBirthDay(string name)
        {
            bool wasAdded = false;
            int index = GetIndexByName(name);
            if (index != -1)
            {
                employees[index].CumpleAnyos();
                wasAdded = true;
            }
            return wasAdded;
            
        }
        public bool AddSell(string name, double sale)
        {
            bool wasAdded = false;
            int index = GetIndexByName(name);
            if (index != -1)
            {
                employees[index].AnyadirVenta(sale);
                wasAdded = true;
            }
            return wasAdded;
        }

    }
}
