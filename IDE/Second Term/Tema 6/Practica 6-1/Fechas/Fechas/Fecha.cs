using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    internal class Fecha
    {
        // Miembros de la clase.
        private int dia;
        private int mes;
        private int anyo;
        // Getters & Setters de la clase.
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int Mes
        {
            get { return mes; }
            set { mes = value;}
        }
        public int Anyo
        {
            get { return anyo; }
            set { anyo = value; }
        }

        //TODO validar los valores introducidos
        /// <summary>
        /// Constructor de Fecha sin parámetros
        /// Se establecen los valores a 1
        /// </summary>
        public Fecha()
        {
            Dia = 1;
            Mes = 1;
            Anyo = 1;
        }


        /// <summary>
        /// Constructor de Fecha con 3 parámetros
        /// Si algún parámetro no es correcto se establece a 1
        /// </summary>
        /// <param name="mes">Mes</param>
        /// <param name="anyo">Anyo (entre 1 y 2500)</param>
        /// <param name="dia">Dia</param>
        public Fecha(int mes, int anyo, int dia)
        {
            // Asigna los valores maximos que puede tomar Anyo en este constructor.
            if (anyo >= 1 && anyo <= 2500)
            {
                Anyo = anyo;
            }
            else
            {
                Anyo = 1;
            }
            // Asigna los valores maximos que puede tomar Mes en este constructor.
            if (mes >= 1 && mes <= 12)
                Mes = mes;
            else
                Mes = 1;

            // Asigna los valores maximos que puede tomar Dia en este constructor.
            int diasMes = CalcDiasMes();
            if (dia >= 1 && dia <= diasMes)
                Dia = dia;
            else
                Dia = 1;
        }

        // Calcula los dias maximos en base al mes.
        private int CalcDiasMes()
        {
            int diasMes = 0;

            if (Mes == 2)
            {
                if (CalcEsBisiesto())
                    diasMes = 29;
                else
                    diasMes = 28;
            }
            else if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
            {
                diasMes = 30;
            }
            else
            {
                diasMes = 31;
            }
            return diasMes;
        }

        // Calcula si el año es bisiesto.
        public bool CalcEsBisiesto()
        {
            bool bisiesto = false;
            if ((Anyo % 400 == 0) || ((Anyo % 4 == 0) && (Anyo % 100 != 0)))
                bisiesto = true;
            else bisiesto = false;
            return bisiesto;
        }


        /// <summary>
        /// Devuelve un string con la fecha en formato dia/mes/anyo
        /// </summary>
        /// <remarks> la palabra clave override indica que se  sobreescribe el metodo ToString</remarks>
        /// <returns>un string con la fecha en formato dia/mes/anyo</returns> public override string
        override
        public string ToString()
        {
            return Dia + "/" + Mes + "/" + Anyo;
        }
    }
}
