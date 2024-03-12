using Ex2;
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
    public partial class AddRectangle : Form
    {
        private List<Shape> figures;
        public AddRectangle(List<Shape> myFigures)
        {
            InitializeComponent();
            figures = myFigures;
        }

        private void btnAddSquare_Click(object sender, EventArgs e)
        {
            double recBase, height;
            int xPosition, yPosition;
            string color;

            recBase = double.Parse(txtBase.Text);
            height = double.Parse(txtHeight.Text);

            xPosition = int.Parse(txtPositionX.Text);
            yPosition = int.Parse(txtPositionY.Text);
            color = txtColor.Text;

            if (color != null && color != "")
            {
                if (recBase > 0)
                {
                    if (height > 0)
                    {
                        Rectangle newRec = new Rectangle(xPosition, yPosition, color, recBase, height);
                        figures.Add(newRec);
                        MessageBox.Show("Rectangle added!");
                    } else
                    {
                        MessageBox.Show("El rectangulo no puede tener una altura menor a 0");
                    }
                } else
                {
                    MessageBox.Show("El rectangulo no puede tener una base menor a 0");
                }
            } else
            {
                MessageBox.Show("El color no puede ser null, ni estar vacio.");
            }
        }
    }
}
