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
    public partial class AddEquilaterTriangle : Form
    {
        private List<Shape> figures;
        public AddEquilaterTriangle(List<Shape> myFigures)
        {
            InitializeComponent();
            figures = myFigures;
        }

        private void btnAddTriangle_Click(object sender, EventArgs e)
        {
            double side;
            int xPosition, yPosition;
            string color;

            side = double.Parse(txtSide.Text);
            
            xPosition = int.Parse(txtPositionX.Text);
            yPosition = int.Parse(txtPositionY.Text);
            color = txtColor.Text;
            if (color != null && color != "")
            {
                if (side > 0)
                {
                    EquilateralTriangle newTriangle = new EquilateralTriangle(xPosition, yPosition, color, side);
                    figures.Add(newTriangle);
                    MessageBox.Show("Triangulo añadido");
                    ClearTxts();
                }
                else
                {
                    MessageBox.Show("El triangulo tiene que tener lados mayores a 0");
                }
            } else
            {
                MessageBox.Show("El triangulo no puede tener un color null o vacio.");
            }
        }
        public void ClearTxts()
        {
            txtColor.Text = string.Empty;
            txtPositionX.Text = string.Empty;
            txtPositionY.Text = string.Empty;
            txtSide.Text = string.Empty;
            
        }
    }
}
