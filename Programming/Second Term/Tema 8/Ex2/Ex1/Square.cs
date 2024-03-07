using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Square: Figure
    {
        private int height;

        public int Height 
        { 
            get {  return height; } 
            set {  height = value; } 
        }

        public Square(int x, int y, string color, int height) : base(x, y, color)
        {
            Height = height;
        }

        public override double CalcArea()
        {
            return Math.Pow(Height, Height);
        }

        public override string ToString()
        {
            return $"Position X: {xPosition} " +
                $"\nPosition Y: {yPosition} " +
                $"\nColor: {Color}" +
                $"\nHeight: {Height}";
        }
    }
}
