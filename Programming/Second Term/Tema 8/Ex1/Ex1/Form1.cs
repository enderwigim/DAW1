using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Figure figure;
        private void btnCreateSquare_Click(object sender, EventArgs e)
        {
            Square square = new Square(3, 4, "Red", 5);
            figure = square;

            MessageBox.Show(square.ToString());

        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(3, 4, "Blue", 3);
            figure = circle;
            MessageBox.Show(figure.ToString());
        }
    }
}
