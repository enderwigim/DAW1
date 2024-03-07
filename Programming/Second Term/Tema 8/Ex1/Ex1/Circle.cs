using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Circle : Figure
    {
        private double radio;

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public Circle(int xPosition, int yPosition, string color, double radio): base(xPosition, yPosition, color)
        {
            Radio = radio;
        }

        public override double CalcArea()
        {
            return Math.PI * (radio * radio);
        }
        public override string ToString()
        {
            return $"Position X: {xPosition} " +
                $"\nPosition Y: {yPosition} " +
                $"\nColor: {Color}" +
                $"\nRadio: {Radio}";
        }
    }
}
