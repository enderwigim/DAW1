using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(int xPosition, int yPosition, string color, double radio): base(xPosition, yPosition, color)
        {
            Radius = radio;
        }

        public override double CalcArea()
        {
            return Math.PI * (radius * radius);
        }

        public override string SayMyName()
        {
            return "Soy un circulo";
        }

        public override string ToString()
        {
            return $"Position X: {xPosition} " +
                $"\nPosition Y: {yPosition} " +
                $"\nColor: {Color}" +
                $"\nRadio: {Radius}";
        }
    }
}
