using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class EquilateralTriangle : Shape
    {
        private double side;
        private double height;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public double Height
        {
            get { return height; }
        }
        public EquilateralTriangle(int xPos, int yPos, string color, double side) : base(xPos, yPos, color)
        {
            Side = side;
            this.height = CalcHeight();
        }

        private double CalcHeight()
        {
            double height = ((Side * Math.Sqrt(3)) / 2);
            return height;
        }
        public override double CalcPerimeter()
        {
            return side * 3;
        }
        public override double CalcArea()
        {
            return (height * side) / 2;
        }
        public override string SayMyName()
        {
            return "Soy un triangulo equilatero";
        }
        public override string ToString()
        {
            return $"{SayMyName()} " +
                $"\nPosition X: {xPosition} " +
                $"\nPosition Y: {yPosition} " +
                $"\nColor: {Color}" +
                $"\nSide: {Side}" +
                $"\nHeight: {Height}" +
                $"\nPerimeter: {CalcPerimeter()}";
        }
    }
}
