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
    public partial class TypeOfShape : Form
    {
        private List<Shape> figures;
        public TypeOfShape(List<Shape> myFigures)
        {
            InitializeComponent();
            figures = myFigures;
        }

        private void btnTriangleEquilater_Click(object sender, EventArgs e)
        {
            AddEquilaterTriangle fAddEquilater = new AddEquilaterTriangle(figures);
            fAddEquilater.ShowDialog();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            AddRectangle fAddRectangle = new AddRectangle(figures);
            fAddRectangle.ShowDialog();
        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            AddCircle fCircle = new AddCircle(figures);
            fCircle.ShowDialog();
        }

        private void btnCreateSquare_Click(object sender, EventArgs e)
        {
            AddSquare fSquare = new AddSquare(figures);
            fSquare.ShowDialog();
        }

        private void btnCreateRegularHexagon_Click(object sender, EventArgs e)
        {
            AddRegularHexagon fHexagon = new AddRegularHexagon(figures);
            fHexagon.ShowDialog();
        }
    }
}
