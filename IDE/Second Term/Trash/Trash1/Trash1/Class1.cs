using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trash1
{
    internal class avion

    {
        private double altura;
        private double velocidad;
        private double combustible;
        private int orientacion;

        public avion(double altura, double velocidad, double combustible, int orientacion)
        {
            this.altura = altura;
            this.velocidad = velocidad;
            this.combustible = combustible;
            this.orientacion = orientacion;
        }

        public double Altura
        {
            get { return altura; }
        }

        public int Orientacion
        {
            get { return orientacion; }
        }

        public double Combustible
        {
            get { return combustible; }
        }

        //Metodo que sirve para virar el avion los grados indicados.
        public void Virar(int grados)
        {
            orientacion = (orientacion + grados) % 360;
            ConsumirCombustible((float)(grados * 0.1));
        }
        //Metodo que sirve para ascender los metros indicados
        private void Ascender(double metros)
        {
            altura = altura + metros;
            ConsumirCombustible((float)(metros * 0.3));
        }
        //Metodo que sirve para descender los metros indicados
        private void Descender(float metros)
        {
            altura = altura - metros;
            if (altura < 0)
                altura = 0;
        }
        private void ConsumirCombustible(float litros)
        {
            combustible = combustible - litros;
            if (combustible < 0)
                combustible = 0;
        }
    }
}
