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
    public partial class TypeOfTriangle : Form
    {
        private List<Shape> figures;
        public TypeOfTriangle(List<Shape> myFigures)
        {
            InitializeComponent();
            figures = myFigures;
        }

        private void btnTriangleEquilater_Click(object sender, EventArgs e)
        {
            AddEquilaterTriangle fAddEquilater = new AddEquilaterTriangle(figures);
            fAddEquilater.ShowDialog();
        }
    }
}
