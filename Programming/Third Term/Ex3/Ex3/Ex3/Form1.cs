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
using static System.Net.WebRequestMethods;

namespace Ex3
{
    public partial class Form1 : Form
    {
        // Global Variables
        // Create a classArray and a classPosition to navigate through
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
        
        // Declare SqlDBHelper and it's position.
        SqlDBHelper db;
        private int pos;
        // A variable to know if we are working with a new entry
        private bool isANewEntry;
        // Constructor with a position added. That pos will come from the form that calls it.
        public Form1(int position)
        {
            InitializeComponent();
            pos = position;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new SqlDBHelper();

            isANewEntry = false;
            ShowEntry(pos);
            ManageClassImage();

        }
        public int FormPos()
        {
            return pos;
        }
        
        // CRUD BUTTONS
        // AddNewCharacter
        private void btnAddNewCharacter_Click(object sender, EventArgs e)
        {
            //Set every txt to Empty or to default value.
            txtFaction.Text = string.Empty;
            txtLevel.Text = "1";
            txtName.Text = string.Empty;
            txtLocation.Text = string.Empty;

            // We activate the class menu navigation 
            btnNextClass.Enabled = true;
            btnPreviousClass.Enabled = true;

            isANewEntry = true;
            
            CheckNavButtons();
            CheckCRUDbtns();
            // We deactivate this buttons so it can't be clicked twice.
            btnAddNewCharacter.Enabled = false;
            // We activate btnCreateNew manually for this case.
            btnCreateNew.Enabled = true;

            lblClassSelector.Text = classArray[classPosition];
            ManageClassImage();
            txtsReadOnlyFalse();
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
                        btnCreateNew.Enabled = false;
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
                    ShowEntry(pos);
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
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!isANewEntry)
            {
                if (dataIsValid())
                {
                    btnUpdateChar.Enabled = true;
                }
                else
                {
                    btnUpdateChar.Enabled = false;
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
                else
                {
                    btnUpdateChar.Enabled = false;
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
                else
                {
                    btnUpdateChar.Enabled = false;
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
                else
                {
                    btnUpdateChar.Enabled = false;
                }
            }
        }
        private void btnNextClass_Click(object sender, EventArgs e)
        {
            UpdateClassPosition();
            if (classPosition < classArray.Length - 1)
            {
                classPosition++;
            }
            else
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
            if (!isANewEntry)
            {
                if (dataIsValid())
                {
                    btnUpdateChar.Enabled = true;
                }
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

                // Allows the user to write in every textbox.
                txtsReadOnlyFalse();
                isANewEntry = false;
            } else
            {
                ShowEmpty();
            }
            
            CheckCRUDbtns();
            CheckNavButtons();
            UpdateClassPosition();
            ManageClassImage();
            
        }
        public void ShowEmpty()
        {
            txtName.Text = string.Empty;
            txtFaction.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtLevel.Text = string.Empty;
            lblClassSelector.Text = string.Empty;

            lblEntryNumber.Text = "0 de 0";
            // Let's turn every textbox to Read-Only.
            txtsReadOnlyTrue();
        }
        public void txtsReadOnlyTrue()
        {
            // Turns every textbox to Read-Only
            txtName.ReadOnly = true;
            txtFaction.ReadOnly = true;
            txtLocation.ReadOnly = true;
            txtLevel.ReadOnly = true;
        }
        public void txtsReadOnlyFalse()
        {
            // Allows the user to write in every text box.
            txtName.ReadOnly = false;
            txtFaction.ReadOnly = false;
            txtLocation.ReadOnly = false;
            txtLevel.ReadOnly = false;
        }
        public void CheckCRUDbtns()
        {
            // In case, the ammount of teachers is more than 1 and is not a new entry, the following buttons will be activated.
            btnDeleteChar.Enabled = (db.AmmountOfCharacters >= 1 && !isANewEntry);
            btnCreateNew.Enabled = (db.AmmountOfCharacters >= 1 && isANewEntry);
            btnAddNewCharacter.Enabled = (!isANewEntry);
            
            // We set the btnUpdate.Enable to false always so we can activate and deactivate it when a change was done.
            btnUpdateChar.Enabled = false;

        }
        public void CheckNavButtons()
        {
            btnShowNext.Enabled = (db.AmmountOfCharacters != 0 && pos < db.AmmountOfCharacters - 1 && !isANewEntry);
            btnShowPrevious.Enabled = (db.AmmountOfCharacters != 0 && pos > 0 && !isANewEntry);
            btnShowLast.Enabled = (db.AmmountOfCharacters != 0 && pos != db.AmmountOfCharacters - 1 && !isANewEntry);
            btnShowFirst.Enabled = (db.AmmountOfCharacters != 0 && pos != 0 && !isANewEntry);
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

            if (!CustomRegex.RegexLevel(txtLevel.Text))
            {
                return dataIsValid;
            }
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

       
        public void UpdateIfWasChangedAndIsValid()
        {
            if (!isANewEntry)
            {
                if (checkIfChanges(pos))
                {
                    if (dataIsValid())
                    {
                        DialogResult wantToUpdate = MessageBox.Show("Do you want to update this character data?", " ", MessageBoxButtons.YesNo);
                        if (wantToUpdate == DialogResult.Yes)
                        {
                            btnUpdateChar.Enabled = true;
                            btnUpdateChar.PerformClick();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Changes were detected, but as they are not valid, data wasnt updated");
                    }
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
            // If the db is not empty or isANewEntry. We will show a real class img.
            if (db.AmmountOfCharacters > 0 || isANewEntry)
            {
                string imgPath = @"..\\..\\img\\";
                imgPath = Path.GetFullPath(imgPath + lblClassSelector.Text.ToLower() + ".gif");
                characterImg.Image = Image.FromFile(imgPath);
            }
            else
            {
                // We will show a village img otherwise. And we will not loop through the classes.
                string imgPath = @"..\\..\\img\\villager.gif";
                imgPath = Path.GetFullPath(imgPath);
                characterImg.Image = Image.FromFile(imgPath);
                btnNextClass.Enabled = false;
                btnPreviousClass.Enabled = false;
            }


        }


        
        public void UpdateClassPosition()
        {
            // We need to update the classPostion before keep looping through it.
            for (int i = 0; i < classArray.Length; i++)
            {
                if (lblClassSelector.Text == classArray[i])
                {
                    classPosition = i;
                }
            }
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

    }

}
