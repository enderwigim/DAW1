using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Rectangle : Shape
    {
        private double recBase;
        private double height;

        public double RecBase
        {
            get { return recBase; }
            set { recBase = value; }
        } 
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Rectangle(int xPos, int yPos, string color, double recBase, double height) : base(xPos, yPos, color)
        {
            RecBase = recBase;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Math.Round(Height * RecBase, 2);
        }

        public override double CalculatePerimeter()
        {
            return Math.Round(Height * 2 + RecBase * 2, 2);
        }

        public override string SayMyName()
        {
            return "Soy un rectangulo";
        }
        public override string ToString()
        {
            return $"{SayMyName()} " +
                $"\nPosition X: {xPosition} " +
                $"\nPosition Y: {yPosition} " +
                $"\nColor: {Color}" +
                $"\nBase: {RecBase}" +
                $"\nHeight: {Height}" +
                $"\nPerimeter: {CalculatePerimeter()}" +
                $"\nArea: {CalculateArea()}\n\n";
        }
    }
}
