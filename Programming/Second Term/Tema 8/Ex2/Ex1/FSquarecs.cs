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

namespace Ex1
{
    public partial class AddSquare : Form
    {
        private List<Shape> figures;
        public AddSquare(List<Shape> myFigures)
        {
            InitializeComponent();
            figures = myFigures;
        }

        private void btnAddSquare_Click(object sender, EventArgs e)
        {
            int x, y, height;
            string color;


            x = int.Parse(txtPositionX.Text);
            y = int.Parse(txtPositionY.Text);
            height = int.Parse(txtHeight.Text);
            color = txtColor.Text;
            if (x > 0 && y > 0)
            {
                if (height > 0)
                {
                    if (color != "")
                    {
                        Square square = new Square(x, y, color, height);
                        figures.Add(square);
                        ClearTxts();
                        MessageBox.Show("Square added!");
                    }
                }
                else
                {
                    MessageBox.Show("La altura no puede ser negativo.");
                }
            }
            else
            {
                MessageBox.Show("Esas posiciones no son correctas.");
            }
        }
        public void ClearTxts()
        {
            txtColor.Text = string.Empty;
            txtPositionX.Text = string.Empty;
            txtPositionY.Text = string.Empty;
            txtHeight.Text = string.Empty;
        }
    }
}
