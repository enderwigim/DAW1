using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool LeapYear(int num)
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
        bool FechaValida(int day, int month, int year)
        {
            // Declaramos 2 booleanos, isLeap para saber si es año biciesto y fechaValida para saber si
            // la fecha es valida. Las seteamos inicialmente a false.
            bool isLeap, fechaValida;
            isLeap = fechaValida = false;
            if (month >= 1 && month <= 12)
            // Si el mes es mayor o igual a 1 y menor o igual a 12.
            {
                // En caso de que mes sea igual a 2
                if (month == 2)
                {
                    // Calculamos si estamos frente a un año biciesto con nuestra funcion
                    isLeap = LeapYear(year);
                    if (isLeap)
                    // En caso de que estemos frente a un año biciesto
                    {
                        if (day >= 1 && day <= 29)
                        {
                            fechaValida = true;
                        }
                    }
                    else
                    // En caso de que no estemos frente a un año biciesto
                    {
                        if (day >= 1 && day <= 28)
                        {
                            fechaValida = true;
                        }
                    }
                }
                
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                // Vemos todos los casos con los meses que solo tienen 30 dias.
                {
                    if (day >= 1 && day <= 30)
                    {
                        fechaValida = true;
                    }
                }
                else
                // Hacemos un else, viene toooodos los otros meses. Los cuales tienen 31 dias.
                {
                    if (day >= 1 && day <= 31)
                    { 
                        fechaValida = true;
                    }
                }
            }
            return fechaValida;
        }
        void nextDate(ref int day, ref int month, ref int year)
        {
            // Creamos un booleano el cual será la condición de nuestro while.
            bool validDate = false;
            while (!validDate)
            {
                // Suma un 1 a la variable day.
                day++;
                if (day > 31)
                // Si la variable day es > 31, day volverá a 1 y le sumaremos uno a month.
                {

                    day = 1;
                    month++;
                    
                    if (month > 12)
                    // Si month es mayor a 12, day y month volverán a 1 y le sumaremos 1 a year.
                    {

                        day = 1;
                        month = 1;
                        year++;
                    }
                }
                // Revisamos si validDate pasa a ser true con nuestra función Fechavalida.
                // En caso de que la fecha sea valida y exista, nos devolverá true y terminará el bucle.
                validDate = FechaValida(day, month, year);
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaramos las variables
            int day, month, year;
            bool validDate;

            // Le asignamos valor a las variables dia, año y mes. No nos vamos a centrar en si son numeros
            // validos, puesto a que lo revisaremos con una función mas tarde.
            day = int.Parse(txtDay.Text);
            month = int.Parse(txtMonth.Text);
            year = int.Parse(txtYear.Text);
            // Revisamos si la fecha es valida con nuestra función. Y le asignamos el resultado a nuestro
            // booleano.
            validDate = FechaValida(day, month, year);

            
            if (validDate)
            {
                // Si la fecha es valida, utilizaremos la función que nos permite calcular el proximo dia.
                nextDate(ref day, ref month, ref year);
                // Luego usamos un MessageBox para mostrar el dia siguiente.
                MessageBox.Show("La fecha siguiente a la ingresada será: " + day + "/" + month + "/" + year);
            }
            // En caso de que la fecha no sea valida, pondremos un MessageBox diciendole al usuario
            // que no es valido.
            else
                MessageBox.Show("La fecha ingresada, no es valida");


        }
    }
}
