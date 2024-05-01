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
using Ex3.Models;

namespace Ex3
{
    public partial class SelectCharacter : Form
    {
        SqlDBHelper db = new SqlDBHelper();
        int pos = 0;
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
        public void ShowEntry()
        {
            Character entryCharacter = db.GetCharacter(pos);
            lblName.Text = entryCharacter.Name;
            lblFaction.Text = entryCharacter.Faction;
            lblClass.Text = entryCharacter.Class.ToString();
            lblLocation.Text = entryCharacter.Location;
            lblLevel.Text = entryCharacter.Level.ToString();
            ChangeEveryFont();
        }
        
        private void ViewCharacter_Load(object sender, EventArgs e)
        {
            ChangeEveryFont();
            ShowEntry();
        }

        private void btnChangeCharacters_Click(object sender, EventArgs e)
        {
            Form1 dbForm = new Form1(pos);
            dbForm.ShowDialog();
        }

        private void btnShowNext_Click(object sender, EventArgs e)
        {
            if (pos != db.AmmountOfCharacters - 1)
            {
                pos++;
            }
            else
            {
                pos = 0;
            }
            ShowEntry();
        }

        private void btnShowPrevious_Click(object sender, EventArgs e)
        {
            if (pos != 0)
            {
                pos--;
            }
            else
            {
                pos = db.AmmountOfCharacters - 1;
            }
            ShowEntry();
        }
    }
}
