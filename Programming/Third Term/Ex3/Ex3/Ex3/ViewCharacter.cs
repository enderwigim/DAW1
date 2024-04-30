using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace Ex3
{
    public partial class SelectCharacter : Form
    {
        public SelectCharacter()
        {
            InitializeComponent();
        }
        public void ChangeEveryFont()
        {
            /* THIS WILL CHANGE EVERY FONT TO A CUSTOM ONE */
            PrivateFontCollection pfc = new PrivateFontCollection();
            string fontPath = Path.GetFullPath(@"..\\..\\font\\Alkhemikal.ttf");
            pfc.AddFontFile(fontPath);
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
        }

        private void ViewCharacter_Load(object sender, EventArgs e)
        {
            ChangeEveryFont();
        }
    }
}
