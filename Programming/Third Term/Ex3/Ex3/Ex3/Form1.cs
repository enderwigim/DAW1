using Ex3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        string[] classArray = {
            "Paladin",
            "DeathKnight",
            "Priest",
            "Mage",
            "Warlock",
            "Warrior",
            "Rogue",
            "Hunter"
            };
        int classPosition = 0;
        // Global Variables
        SqlDBHelper db;
        private int pos;
        private bool isANewEntry = false;
        public Form1(int position)
        {
            InitializeComponent();
            pos = position;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new SqlDBHelper();

            ShowEntry(pos);
            ManageClassImage();
            //btnSaveNew.Enabled = false;

        }
        
        public int GetClass(string className)
        {
            // Return the class as an int so It can be added to the character to update the database
            // later.
            int @class = -1;
            
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

            txtFaction.Text = string.Empty;
            txtLevel.Text = string.Empty;
            txtName.Text = string.Empty;
            txtLocation.Text = string.Empty;

            btnAddNewCharacter.Enabled = false;
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
            @class = lblClassSelector.Text;

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
            UpdateIfWasChangedAndIsValid();
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
            UpdateIfWasChangedAndIsValid();
            pos = db.AmmountOfCharacters - 1;
            ShowEntry(pos);
        }

        private void btnShowFirst_Click(object sender, EventArgs e)
        {
            UpdateIfWasChangedAndIsValid();
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
            @class = lblClassSelector.Text;

            classNumber = GetClass(@class);
            level = int.Parse(txtLevel.Text);

            if (classNumber != -1)
            {
                Character newCharacter = Character.CreateCharacter(name, classNumber, faction, location, level);
                if (newCharacter != null)
                {
                    db.UpdateRow(newCharacter, pos);
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

            if (character != null) {
                txtName.Text = character.Name;
                txtFaction.Text = character.Faction;
                lblClassSelector.Text = character.Class.ToString();
                txtLocation.Text = character.Location;
                txtLevel.Text = character.Level.ToString();


                // lblEntryNumbers management.
                lblEntryNumber.Text = (int)((pos + 1)) + " de " + db.AmmountOfCharacters;
                CheckButtons();
                CheckNavButtons();
                ManageClassImage();
            } else
            {
                ShowEmpty();
            }
            
        }
        public void ShowEmpty()
        {
            txtName.Text = string.Empty;
            txtFaction.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtLevel.Text = string.Empty;
            lblEntryNumber.Text = "0 de 0";
        }
        public void CheckButtons()
        {
            // In case, the ammount of teachers is more than 1.
            if (db.AmmountOfCharacters >= 1)
            {
                btnDeleteChar.Enabled = true;
                btnCreateNew.Enabled = false;
                btnAddNewCharacter.Enabled = true;
            }
            else
            {
                btnDeleteChar.Enabled = false;
                btnCreateNew.Enabled = false;
                btnShowNext.Enabled = false;
                btnShowLast.Enabled = false;
            }
            // We set the btnUpdate.Enable to false always so we can activate and deactivate it when a change was done.
            btnUpdateChar.Enabled = false;
            isANewEntry = false;
        }
        public void CheckNavButtons()
        {
            btnShowNext.Enabled = (db.AmmountOfCharacters != 0 && pos < db.AmmountOfCharacters - 1);
            btnShowPrevious.Enabled = (db.AmmountOfCharacters != 0 && pos > 0);
            btnShowLast.Enabled = (db.AmmountOfCharacters != 0 && pos != db.AmmountOfCharacters - 1);
            btnShowFirst.Enabled = (db.AmmountOfCharacters != 0 && pos != 0);
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
            string @class = lblClassSelector.Text;

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
                            btnUpdateChar.Enabled = true;
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
            string @class = lblClassSelector.Text;

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
        public void ManageClassImage()
        {
            string imgPath = @"..\\..\\img\\";
            imgPath = Path.GetFullPath(imgPath + lblClassSelector.Text.ToLower() + ".gif");
            characterImg.Image = Image.FromFile(imgPath);
        }

        private void btnNextClass_Click(object sender, EventArgs e)
        {
            UpdateClassPosition();
            if (classPosition < classArray.Length - 1)
            {
                classPosition++;
            } else
            {
                classPosition = 0;
            }
            lblClassSelector.Text = classArray[classPosition];
            ManageClassImage();
            // Necesitamos vereficar si la data es valida. En caso de que lo sea. Despues de tocar el boton, el usuario podra 
            // updatear el boton.
            if (!isANewEntry)
            {
                if (dataIsValid())
                {
                    btnUpdateChar.Enabled = true;
                }
            }
        }

        private void btnPreviousClass_Click(object sender, EventArgs e)
        {
            UpdateClassPosition();
            if (classPosition > 0)
            {
                classPosition--;
            }
            else
            {
                classPosition = classArray.Length - 1;
            }
            lblClassSelector.Text = classArray[classPosition];
            ManageClassImage();
        }
        public void UpdateClassPosition()
        {
            // Tenemos esto para updatear la posición del array. Asi podremos seguir cambiando entre unos y otros.
            for (int i = 0; i < classArray.Length; i++)
            {
                if (lblClassSelector.Text == classArray[i])
                {
                    classPosition = i;
                }
            }
        }
    }

}
