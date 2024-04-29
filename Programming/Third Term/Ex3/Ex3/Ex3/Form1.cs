using Ex3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Global Variables
        SqlDBHelper db;
        private int pos;
        private bool isANewEntry = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new SqlDBHelper();
            pos = 0;

            ShowEntry(pos);
            //btnSaveNew.Enabled = false;

        }
        
        public int GetClass(string className)
        {
            // Return the class as an int so It can be added to the character to update the database
            // later.
            int @class = -1;
            string[] classArray = {
            "Paladin", 
            "DeathKnight",
            "Priest",
            "Mage",
            "Warlock",
            "Warrior",
            "Rogue",
            "Hunter",
            "Druid",
            "Shaman" 
            };
            for (int i = 0; i < classArray.Length; i++)
            {
                if (classArray[i].ToUpper() == className.ToUpper())
                {
                    @class = i;
                    return @class;
                }
            }
            return @class;
        }

        private void btnAddNeyCharacter_Click(object sender, EventArgs e)
        {
            txtClass.Text = string.Empty;
            txtFaction.Text = string.Empty;
            txtLevel.Text = string.Empty;
            txtName.Text = string.Empty;
            txtLocation.Text = string.Empty;
            btnCreateNew.Enabled = true;
            isANewEntry = true;
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            string name, faction, location, @class;
            int classNumber, level;

            name = txtName.Text;
            faction = txtFaction.Text;
            location = txtLocation.Text;
            @class = txtClass.Text;

            classNumber = GetClass(@class);
            if (string.IsNullOrEmpty(txtLevel.Text))
            {
                ErrorMessage();
                return;
            }
            level = int.Parse(txtLevel.Text);

            if (classNumber != -1)
            {
                Character newCharacter = Character.CreateCharacter(name, classNumber, faction, location, level);
                if (newCharacter != null)
                {
                    if (db.CreateRow(newCharacter))
                    {
                        pos = db.AmmountOfCharacters - 1;
                        ShowEntry(pos);
                        isANewEntry = false;
                    } else
                    {
                        MessageBox.Show("That character already exists");
                    }
                }
                else
                {
                    ErrorMessage();
                }
            } else
            {
                ErrorClass();
            }

        }

        private void btnShowNext_Click(object sender, EventArgs e)
        {
            UpdateIfWasChangedAndIsValid();
            if (pos != db.AmmountOfCharacters - 1)
            {
                pos++;
            }
            else
            {
                pos = 0;
            }
            ShowEntry(pos);
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
            ShowEntry(pos);
        }
        private void btnShowLast_Click(object sender, EventArgs e)
        {
            pos = db.AmmountOfCharacters - 1;
            ShowEntry(pos);
        }

        private void btnShowFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowEntry(pos);
        }
        private void btnDeleteChar_Click(object sender, EventArgs e)
        {
            DialogResult wantToDelete;
            wantToDelete = MessageBox.Show("Are you sure that you want to delete this character?", " ", MessageBoxButtons.YesNo);
            if (wantToDelete == DialogResult.Yes)
            {
                db.DeleteRow(pos);
                if (db.AmmountOfCharacters >= 1)
                {
                    // Nos vamos al primer registro y lo mostramos
                    pos = 0;

                    ShowEntry(pos);
                    MessageBox.Show("Character Deleted");
                }
                else
                {
                    ShowEmpty();
                }
            }
        }
        private void btnUpdateChar_Click(object sender, EventArgs e)
        {
            string name, faction, location, @class;
            int classNumber, level;

            name = txtName.Text;
            faction = txtFaction.Text;
            location = txtLocation.Text;
            @class = txtClass.Text;

            classNumber = GetClass(@class);
            level = int.Parse(txtLevel.Text);

            if (classNumber != -1)
            {
                Character newCharacter = Character.CreateCharacter(name, classNumber, faction, location, level);
                if (newCharacter != null)
                {
                    db.UpdateRow(newCharacter, pos);
                    pos = db.AmmountOfCharacters - 1;
                    ShowEntry(pos);
                }
                else
                {
                    ErrorMessage();
                }
            } else
            {
                ErrorClass();
            }
        }


        public void ShowEntry(int pos)
        {
            Character character = db.GetCharacter(pos);


            txtName.Text = character.Name;
            txtFaction.Text = character.Faction;
            txtClass.Text = character.Class.ToString();
            txtLocation.Text = character.Location;
            txtLevel.Text = character.Level.ToString();

            // lblEntryNumbers management.
            lblEntryNumber.Text = (int)((pos + 1)) + " de " + db.AmmountOfCharacters;
            CheckButtons();
            CheckNavButtons();
        }
        public void ShowEmpty()
        {
            txtName.Text = string.Empty;
            txtFaction.Text = string.Empty;
            txtClass.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtLevel.Text = string.Empty;
            lblEntryNumber.Text = "0 de 0";
        }
        public void CheckButtons()
        {
            // In case, the ammount of teachers isn't more than 1.
            if (db.AmmountOfCharacters >= 1)
            {
                btnDeleteChar.Enabled = true;
                btnUpdateChar.Enabled = true;
                //btnShowEveryTeacher.Enabled = true;
                btnCreateNew.Enabled = false;
                //btnLookBySurname.Enabled = true;
                btnAddNeyCharacter.Enabled = true;
            }
            else
            {
                btnDeleteChar.Enabled = false;
                btnCreateNew.Enabled = false;
                // btnShowEveryTeacher.Enabled = false;
                // btnLookBySurname.Enabled = false;
                btnShowNext.Enabled = false;
                btnShowLast.Enabled = false;
            }
            // We set the btnUpdate.Enable to false always so we can activate and deactivate it when a change was done.
            btnUpdateChar.Enabled = false;
            isANewEntry = false;
        }
        public void CheckNavButtons()
        {
            if (pos == db.AmmountOfCharacters - 1)
            {
                btnShowNext.Enabled = false;
                btnShowLast.Enabled = false;

            }
            else
            {
                btnShowNext.Enabled = true;
                btnShowLast.Enabled = true;
            }
            if (pos == 0)
            {
                btnShowPrevious.Enabled = false;
                btnShowFirst.Enabled = false;
            }
            else
            {
                btnShowPrevious.Enabled = true;
                btnShowFirst.Enabled = true;
            }
        }
        public void ErrorMessage()
        {
            MessageBox.Show("There was an error with the data introduced: \n" +
                            "Follow the next to do it properly\n" +
                            "Name: Ender\n" +
                            "Class: Paladin\n" +
                            "Faction: Alliance || Horde\n" +
                            "Location: StormWind\n" +
                            "Level: 80(MAX LEVEL)");
        }
        public void ErrorClass()
        {
            MessageBox.Show("The classes available are: \n" +
                "Paladin\nDeathKnight\nPriest\nMage\nWarlock\nWarrior\nRogue\nHunter\nDruid\nShaman");
        }
        public bool dataIsValid()
        {
            bool dataIsValid = false;
            string name = txtName.Text;
            string @class = txtClass.Text;

            string faction = txtFaction.Text;
            string location = txtLocation.Text;
            if (string.IsNullOrEmpty(txtLevel.Text)) 
                return dataIsValid;

            int level = int.Parse(txtLevel.Text);

            


            int classNum = GetClass(@class);


            if (classNum != -1)
            {
                Character character = Character.CreateCharacter(name, classNum, faction, location, level);
                if (character != null)
                    dataIsValid = true;
            }
            return dataIsValid;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (dataIsValid())
                {
                    btnUpdateChar.Enabled = true;
                }
            }
        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (dataIsValid())
                {
                    btnUpdateChar.Enabled = true;
                }
            }
        }

        private void txtFaction_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (dataIsValid())
                {
                    btnUpdateChar.Enabled = true;
                }
            }
        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (dataIsValid())
                {
                    btnUpdateChar.Enabled = true;
                }
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (dataIsValid())
                {
                    btnUpdateChar.Enabled = true;
                }
            }
        }
        public void UpdateIfWasChangedAndIsValid()
        {
            if (!isANewEntry)
            {
                if (dataIsValid())
                {
                    if (checkIfChanges(pos))
                    {
                        DialogResult wantToUpdate = MessageBox.Show("Do you want to update this character data?", " ", MessageBoxButtons.YesNo);
                        if (wantToUpdate == DialogResult.Yes)
                        {
                            btnUpdateChar.PerformClick();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Changes were detected, but as they are not valid, data wasnt updated");
                }
            }
        }
        public bool checkIfChanges(int pos)
        {
            bool itChanged = false;

            string name = txtName.Text;
            string @class = txtClass.Text;

            string faction = txtFaction.Text;
            string location = txtLocation.Text;
            int level = Convert.ToInt16(txtLevel.Text);



            int classNum = GetClass(@class);
            Character character = Character.CreateCharacter(name, classNum, faction, location, level);
            if (character != null)
            {
                if (db.CheckIfChanged(pos, character)) 
                {
                    itChanged = true;
                }
            }

            return itChanged;
        }
    }

}
