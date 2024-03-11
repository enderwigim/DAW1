using Ex2;
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
        
        List<Shape> figures = new List<Shape>();

        public void AddPositionsAndColor(out int x, out int y, out string color)
        {
            x = int.Parse(Interaction.InputBox("En que posición de x esta?"));
            y = int.Parse(Interaction.InputBox("En que posición de y esta?"));
            color = Interaction.InputBox("Cual es el color");
        }
        private void btnCreateSquare_Click(object sender, EventArgs e)
        {
            /*
            int x, y, height;
            string color;
            AddPositionsAndColor(out x, out y, out color);

            height = int.Parse(Interaction.InputBox("Que altura tiene?"));


            Square square = new Square(x, y, color, height);
            

            figures.Add(square);
            MessageBox.Show("Square added");
            */
            AddSquare fSquare = new AddSquare(figures);
            fSquare.ShowDialog();
            

        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            /*
            int x, y, radius;
            string color;
            AddPositionsAndColor(out x, out y, out color);

            radius = int.Parse(Interaction.InputBox("Que radio tiene?"));
            Circle circle = new Circle(x, y, color, radius);

            figures.Add(circle);
            MessageBox.Show("Circle added");
            */
            AddCircle fCircle = new AddCircle(figures);
            fCircle.ShowDialog();
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

        private void btnShowCircles_Click(object sender, EventArgs e)
        {
            string text = "Datos de los circulos \n\n";
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i].GetType() == typeof(Circle))
                {
                    text += figures[i].SayMyName() + "\n";
                    text += $"La figura {i + 1}:" +
                        $"\n{figures[i].ToString()}\n" +
                        $"Area: {figures[i].CalcArea()}\n\n";
                }
                
            }
            MessageBox.Show(text);
        }

        private void btnShowSquares_Click(object sender, EventArgs e)
        {
            string text = "Datos de los cuadrados: \n\n";
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i].GetType() == typeof(Square))
                {
                    text += figures[i].SayMyName() + "\n";
                    text += $"La figura {i + 1}:" +
                        $"\n{figures[i].ToString()}\n" +
                        $"Area: {figures[i].CalcArea()}\n";
                }

            }
            MessageBox.Show(text);
        }

        private void btnCreateTriangle_Click(object sender, EventArgs e)
        {
            TypeOfTriangle fTypeOfTriangle = new TypeOfTriangle(figures);
            fTypeOfTriangle.ShowDialog();
        }
    }
}
