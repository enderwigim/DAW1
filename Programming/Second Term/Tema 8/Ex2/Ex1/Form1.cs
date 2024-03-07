using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<Figure> figures = new List<Figure>();

        public void AddPositionsAndColor(out int x, out int y, out string color)
        {
            x = int.Parse(Interaction.InputBox("En que posición de x esta?"));
            y = int.Parse(Interaction.InputBox("En que posición de y esta?"));
            color = Interaction.InputBox("Cual es el color");
        }
        private void btnCreateSquare_Click(object sender, EventArgs e)
        {
            int x, y, height;
            string color;
            AddPositionsAndColor(out x, out y, out color);

            height = int.Parse(Interaction.InputBox("Que altura tiene?"));


            Square square = new Square(x, y, color, height);
            

            figures.Add(square);
            MessageBox.Show("Square added");

        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            int x, y, radius;
            string color;
            AddPositionsAndColor(out x, out y, out color);

            radius = int.Parse(Interaction.InputBox("Que altura tiene?"));
            Circle circle = new Circle(x, y, color, radius);

            figures.Add(circle);
            MessageBox.Show("Circle added");
        }

        private void btnShowEveryFigure_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < figures.Count; i++)
            {
                MessageBox.Show($"La figura {i + 1}:" +
                    $"\n{figures[i].ToString()}\n" +
                    $"Area: {figures[i].CalcArea()}");
            }
        }
    }
}
