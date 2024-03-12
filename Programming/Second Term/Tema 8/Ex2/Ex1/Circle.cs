using Ex2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Circle : Shape
    {
        private int radius;
        
        

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(int x, int y, string color, int height) : base(x, y, color)
        {
            Radius = height;
        }

        public override double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }
        public override double CalculatePerimeter()
        {
            return (Math.PI * 2) * Radius;
        }
        public override string SayMyName()
        {
            return "Soy un circulo";
        }

        public override string ToString()
        {
            return $"{SayMyName()} " +
                $"\nPosition X: {xPosition} " +
                $"\nPosition Y: {yPosition} " +
                $"\nColor: {Color}" +
                $"\nRadius: {Radius}" +
                $"\nPerimeter: {CalculatePerimeter()}";
        }
    }
}
