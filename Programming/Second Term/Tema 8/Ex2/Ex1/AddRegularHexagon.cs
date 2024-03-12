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
    public partial class AddRegularHexagon : Form
    {
        List<Shape> figures;
        public AddRegularHexagon(List<Shape> myFigures)
        {
            InitializeComponent();
            figures = myFigures;
        }

        private void btnAddHexagon_Click(object sender, EventArgs e)
        {
            double side;
            int xPosition, yPosition;
            string color;

            side = double.Parse(txtTriangleSide.Text);


            xPosition = int.Parse(txtPositionX.Text);
            yPosition = int.Parse(txtPositionY.Text);
            color = txtColor.Text;

            if (color != "" && color != null)
            {
                if (side > 0)
                {
                    RegularHexagon newHexagon = new RegularHexagon(xPosition, yPosition, color, side);
                    figures.Add(newHexagon);
                    MessageBox.Show("Hexagon Added");
                }
                else
                {
                    MessageBox.Show("El lado de uno de los triangulos no puede ser menor a 0.");
                }
            }
            else
            {
                MessageBox.Show("El color no puede ser nulo o estar vacio.");
            }
        }
    }
}
