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
            for (int i = 0; i < employees.Count && index == -1; i++)
            {
                if (employees[i].Nombre.ToLower() == name.ToLower())
                {
                    index = i;
                }
            }
            return index;
        }

        public bool NewEmployee(string name, int age)
        {
            bool newEmployeeAdded = false;

            Empleado new_employee = new Empleado();

            if (age > 0 && name != "")
            {
                new_employee.Nombre = name;
                new_employee.Edad = age;
                employees.Add(new_employee);
                newEmployeeAdded = true;
            }
            return newEmployeeAdded;

        }


        public string ShowEveryEmployee()
        {
            string text = "";
            for (int i = 0; i < employees.Count; i++)
            {
                text += employees[i].MostrarDatos() + "\n";
            }
            return text;
        }

        public string ShowAnEmployeeByName(string name)
        {
            string text = "";
            int index = GetIndexByName(name);
            if (index != -1)
            {
                text = employees[index].MostrarDatos();
            }
            return text;
        }

        public string ShowAnEmployeeByIndex(int index)
        {
            string text = "";
            if (index != -1)
            {
                text = employees[index].MostrarDatos();
            }
            return text;
        }
        public bool DeleteEmployee(string name)
        {
            bool wasDeleted = false;
            int index = GetIndexByName(name);
            if (index != -1)
            {
                employees.RemoveAt(index);
                wasDeleted = true;
            }
            return wasDeleted;
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

        public void OrderEmployeesByName()
        {
            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (string.Compare(employees[i].Nombre, employees[j].Nombre) > 0)
                    {
                        Empleado change_employee = employees[i];
                        employees[i] = employees[j];
                        employees[j] = change_employee;
                    }
                }
            }
        }

        public int CalcMaxSell()
        {
            double maxSell = 0;
            int indexMaxSeller = -1;
            for (int i = 0; i < employees.Count; i++)
            {
                double employeeSellAddition = employees[i].CalcSellAdditions();
                if (maxSell < employeeSellAddition)
                {
                    maxSell = employeeSellAddition;
                    indexMaxSeller = i;
                }
            }
            return indexMaxSeller;
        }

        public void OrderBySells()
        {
            
            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].CalcSellAdditions() < employees[j].CalcSellAdditions())
                    {
                        Empleado changeEmployee = employees[i];
                        employees[i] = employees[j];
                        employees[j] = changeEmployee;
                    }
                }
            }
        }

            public bool DeleteSells(int index)
            {
                bool sellsErased = false;
                if (index != -1)
                {
                    if(employees[index].DeleteSells())
                    {
                        sellsErased = true;
                    }
                    
                }
                return sellsErased;
            }
        }
    } 


