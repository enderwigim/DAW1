using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public abstract class Figure
    {
        protected int xPosition;
        protected int yPosition;
        private string color;

        public Figure(int xPosition, int yPosition, string color)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            Color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public abstract double CalcArea();



        public override string ToString()
        {
            return $"Position X: {xPosition} " +
                $"\nPosition Y: {yPosition} " +
                $"\nColor: {Color}";
        }
    }
}
