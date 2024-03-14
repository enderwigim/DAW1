using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ex2
{
    public class RegularHexagon : Shape
    {
        private double _triangleside;
        private double _apothem;

        public double TriangleSide
        {
            get { return _triangleside; }
            set { _triangleside = value; }
        }

        public RegularHexagon(int xPos, int yPos, string color, double side) : base(xPos, yPos, color)
        {
            TriangleSide = side;
            this._apothem = CalculateApothem();
        }

        private double CalculateApothem()
        {
            double total;
            double halfSide = TriangleSide / 2;
            total = Math.Sqrt((halfSide * halfSide) - (TriangleSide * TriangleSide));
            return total;
        }
        public override double CalculatePerimeter()
        {
            return Math.Round(6 * TriangleSide, 2);
        }
        public override double CalculateArea()
        {
            return Math.Round((CalculatePerimeter() * this._apothem) / 2, 2);
        }
        public override string SayMyName()
        {
            return "Soy un cuadrado";
        }

        public override string ToString()
        {
            return $"{SayMyName()} " +
                $"\nPosition X: {xPosition} " +
                $"\nPosition Y: {yPosition} " +
                $"\nColor: {Color}" +
                $"\nSide: {TriangleSide}" +
                $"\nPerimeter: {CalculatePerimeter()}" +
                $"\nArea: {CalculateArea()}\n\n";
        }
    }
}
