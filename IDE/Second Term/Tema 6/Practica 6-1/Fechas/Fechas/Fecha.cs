using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    internal class Fecha
    {
        private int dia;
        private int mes;
        private int anyo;

        //TODO validar los valores introducidos
        /// <summary>
        /// Constructor de Fecha sin parámetros
        /// Se establecen los valores a 1
        /// </summary>
        public Fecha()
        {
            fDia = 1;
            fMes = 1;
            fAnyo = 1;
        }

        public int fDia
        {
            get { return dia; }
            set { dia = value; }
        }
        public int fMes
        {
            get { return mes; }
            set { mes = value;}
        }
        public int fAnyo
        {
            get { return anyo; }
            set { anyo = value; }
        }

        /// <summary>
        /// Constructor de Fecha con 3 parámetros
        /// Si algún parámetro no es correcto se establece a 1
        /// </summary>
        /// <param name="mes">Mes</param>
        /// <param name="anyo">Anyo (entre 1 y 2500)</param>
        /// <param name="dia">Dia</param>
        /// <param name="bi">Indica si es bisiesto</param>
        public Fecha(int mes, int anyo, int dia, bool bi)
        {
            if (anyo >= 1 && anyo <= 2500)
            {
                fAnyo = anyo;
            }
            else
            {
                fAnyo = 1;
            }

            if (mes >= 1 && mes <= 12)
                fMes = mes;
            else
                fMes = 1;

            int diasMes = CalcDiasMes();
            if (dia >= 1 && dia <= diasMes)
                fDia = dia;
            else
                fDia = 1;
        }

        private int CalcDiasMes()
        {
            int diasMes = 0;

            if (fMes == 2)
            {
                if (this.EsBisiesto())
                    diasMes = 29;
                else
                    diasMes = 28;
            }
            else if (fMes == 4 || fMes == 6 || fMes == 9 || fMes == 11)
            {
                diasMes = 30;
            }
            else
            {
                diasMes = 31;
            }
            return diasMes;
        }

        public bool EsBisiesto()
        {
            bool bisiesto = false;
            if ((fAnyo % 400 == 0) || ((fAnyo % 4 == 0) && (fAnyo % 100 != 0)))
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
            return fDia + "/" + fMes + "/" + fAnyo;
        }
    }
}
