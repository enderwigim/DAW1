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
        
        private void btnShowEveryFigure_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                for (int i = 0; i < figures.Count; i++)
                {
                    MessageBox.Show($"La figura Nº{i + 1}:\n" +
                        $"\n{figures[i].ToString()}\n");
                }
            } else
            {
                MessageBox.Show("No hay ninguna figura agregada a la lista.");
            }
        }
        private void btnCreateShape_click(object sender, EventArgs e)
        {
            TypeOfShape fTypeOfShape = new TypeOfShape(figures);
            fTypeOfShape.ShowDialog();
        }

        private void btnShowCircles_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                if (figures.Any(figure => figure.GetType() == typeof(Circle)))
                {
                    string text = "Datos de los circulos \n\n";
                    for (int i = 0; i < figures.Count; i++)
                    {
                        if (figures[i].GetType() == typeof(Circle))
                        {
                            text += $"La figura {i + 1}:" +
                                $"\n{figures[i].ToString()}\n";
                        }
                    }
                    MessageBox.Show(text);
                }
                else
                {
                    MessageBox.Show("No hay ningun circulo en la lista.");
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna figura en la lista");
            }
        }

        private void btnShowSquares_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                if (figures.Any(figure => figure.GetType() == typeof(Square)))
                {
                    string text = "Datos de los cuadrados: \n\n";
                    for (int i = 0; i < figures.Count; i++)
                    {
                        if (figures[i].GetType() == typeof(Square))
                        {
                            text += $"La figura {i + 1}:" +
                                $"\n{figures[i].ToString()}\n";
                        }
                    }
                    MessageBox.Show(text);
                }
                else
                {
                    MessageBox.Show("No hay ningun Cuadrado en la lista.");
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna figura en la lista.");
            }
        }


        private void btnShowTriangles_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                if (figures.Any(figure => figure.GetType() == typeof(EquilateralTriangle)))
                {
                    string text = "Datos de los triangulos \n\n";
                    for (int i = 0; i < figures.Count; i++)
                    {
                        if (figures[i].GetType() == typeof(EquilateralTriangle))
                        {
                            text += $"La figura {i + 1}:" +
                                $"\n{figures[i].ToString()}\n";
                        }
                    }
                    MessageBox.Show(text);

                }
                else
                {
                    MessageBox.Show("No hay ningun Triangulo Equilatero en la lista.");
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna figura en la lista.");
            }
        }

        private void btnShowRectangles_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                if (figures.Any(figure => figure.GetType() == typeof(Rectangle)))
                {
                    string text = "Datos de los Rectangulos \n\n";
                    for (int i = 0; i < figures.Count; i++)
                    {
                        if (figures[i].GetType() == typeof(Rectangle))
                        {
                            text += $"La figura {i + 1}:" +
                                $"\n{figures[i].ToString()}\n";
                        }

                    }
                    MessageBox.Show(text);
                }
                else
                {
                    MessageBox.Show("No hay ningun Rectangulo en la lista.");
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna figura en la lista.");
            }
        }

        private void btnRegularHexagon_Click(object sender, EventArgs e)
        {
            if (figures.Count > 0)
            {
                // Este if lo que hace es tomar la lista figures,
                // si alguno cumple el requirimiento de ser un tipo RegularHexagon, el if es true.
                if (figures.Any(figure => figure.GetType() == typeof(RegularHexagon)))
                {
                    string text = "Datos de los Hexagonos Regulares \n\n";
                    for (int i = 0; i < figures.Count; i++)
                    {
                        if (figures[i].GetType() == typeof(RegularHexagon))
                        {
                            text += $"La figura {i + 1}:" +
                                $"\n{figures[i].ToString()}\n";
                        }

                    }
                    MessageBox.Show(text);
                }
                else
                {
                    MessageBox.Show("No hay ningun Hexagono Regular en la lista.");
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna figura en la lista.");
            }
        }

        public bool ObjectIsInList(Object test)
        {
            bool isInList = false;
            for (int i = 0; i < figures.Count; i++) 
            {
                if (figures[i].GetType() == test.GetType())
                {
                    isInList = true;
                }
            }
            return isInList;

        }
    }
}
