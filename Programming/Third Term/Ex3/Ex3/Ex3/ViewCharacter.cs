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
using System.Runtime.InteropServices;

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
        // Form buttons
        private void ViewCharacter_Load(object sender, EventArgs e)
        {
            ChangeEveryFont();
            ShowEntry();
        }
        

        private void btnChangeCharacters_Click(object sender, EventArgs e)
        {
            Form1 dbForm = new Form1(pos);
            dbForm.ShowDialog();
            pos = dbForm.FormPos();
            db.RefreshDB();
            //pos = 0;
            ShowEntry();
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
        // Form functions
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
            if (entryCharacter != null)
            {
                lblName.Text = entryCharacter.Name;
                lblFaction.Text = entryCharacter.Faction;
                lblClass.Text = entryCharacter.Class.ToString();
                lblLocation.Text = entryCharacter.Location;
                lblLevel.Text = entryCharacter.Level.ToString();
            }
            else
            {
                lblName.Text = "Future Aventurer";
                lblClass.Text = "Villager";
                lblFaction.Text = "Unknown";
                lblLevel.Text = "0";
                lblLocation.Text = "Create a character and start your adventure!";
                pos = 0;
            }

            ManageButtons();
            ChangeEveryFont();
            ManageFactionImage();
            ManageClassImage();
        }
        public void ManageFactionImage()
        {
            // With this, we will manage the faction image that our program will show
            string imgPath = @"..\\..\\img\\";
            // If faction = Horde, we will show that icon
            if (lblFaction.Text.ToLower() == "horde")
            {
                imgPath = Path.GetFullPath(imgPath + lblFaction.Text.ToLower() + ".png");
            }
            else if (lblFaction.Text.ToLower() == "alliance") // Else, show alliance icon
            {
                imgPath = Path.GetFullPath(imgPath + lblFaction.Text.ToLower() + ".png");
            }
            else
            {
                // If those two option doesnt fit. No image will be shown
                factionImg.Image = null;
                return;
            }
            factionImg.Image = Image.FromFile(imgPath);
        }

        public void ManageClassImage()
        {
            // This will manage the class image shown
            string imgPath = @"..\\..\\img\\";
            imgPath = Path.GetFullPath(imgPath + lblClass.Text.ToLower() + ".gif");
            characterImg.Image = Image.FromFile(imgPath);
        }
        public void ManageButtons()
        {
            btnShowNext.Enabled = (db.AmmountOfCharacters != 0 && pos < db.AmmountOfCharacters - 1);
            btnShowPrevious.Enabled = (db.AmmountOfCharacters != 0 && pos > 0);
            if (db.AmmountOfCharacters == 0)
            {
                btnChangeCharacters.Text = "CREATE";
            }
            else
            {
                btnChangeCharacters.Text = "EDIT";
            }
        }
    }
}
