using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool LeapYear(int num)
        {
            bool isLeap;
            if (num % 4 == 0)
            {   
                isLeap = true;
                if (num % 100 == 0 && num % 400 != 0)
                {
                    isLeap = false;
                }
                else
                {
                    isLeap = true;
                }
            }
            else
            {
                isLeap = false;
            }
            return isLeap;
        }
        bool FechaValida(int day, int month, bool isLeap)
        {
            bool fechaValida = false;
            if (month >= 1 && month <= 12)
            {
                if (month == 2)
                {
                    if (isLeap)
                    {
                        if (day >= 1 && day <= 29)
                        {
                            fechaValida = true;
                        }
                    }
                    else
                    {
                        if (day >= 1 && day <= 28)
                        {
                            fechaValida = true;
                        }
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day >= 1 && day <= 30)
                    {
                        fechaValida = true;
                    }
                }
                else
                {
                    if (day >= 1 && day <= 31)
                    {
                        fechaValida = true;
                    }
                }
            }
            return fechaValida;
        }
            
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int day, month, year;
            bool isLeap, fechaEsValida;

            day = int.Parse(txtDay.Text);
            month = int.Parse(txtMonth.Text);
            year = int.Parse(txtYear.Text);
            isLeap = LeapYear(year);

            fechaEsValida = FechaValida(day, month, isLeap);
            if (fechaEsValida)
            {
                MessageBox.Show("La fecha es valida.");
            }
            else
            {
                MessageBox.Show("La fecha no es valida.");
            }

            
        }
    }
}
