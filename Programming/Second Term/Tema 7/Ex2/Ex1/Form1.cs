using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> population = new List<Person>();
        public void AddInfo(Person person)
        {

            person.PName = Interaction.InputBox("Add Name");
            person.PAge = int.Parse(Interaction.InputBox("How old?"));
            person.PPhone = Interaction.InputBox("Add Phone");
            person.PGender = char.Parse(Interaction.InputBox("Add Gender"));

            DialogResult marry = MessageBox.Show("Marry?", "?", MessageBoxButtons.YesNo);
            if (marry == DialogResult.Yes)
            {
                person.PMarry = true;
            }
            else
            {
                person.PMarry = false;
            }

        }

        public string GetEveryPerson(List<Person> people)
        {
            string fullText = "";
            if (people.Count != 0)
            {
                foreach (Person person in people)
                {
                    fullText += person.GetPerson() + "\n";
                }

            }
            else
            {
                fullText = "There's no people in this population. Add one";
            }
            return fullText;
            
        }

        public int GetPersonId(List<Person> people, string name)
        {
            int index = -1;
            for(int i = 0; i < people.Count; i++)
            {
                if (name.ToLower() == people[i].PName.ToLower())
                {
                    index = i;
                }
            }
            return index;
        }


        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();
            AddInfo(newPerson);
            population.Add(newPerson);
            
        }

        private void btnShowPerson_Click(object sender, EventArgs e)
        {
            int index = int.Parse(Interaction.InputBox("What's the index of the person?"));

            MessageBox.Show(population[index].GetPerson());
        }

        private void btnShowEveryone_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetEveryPerson(population));
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string personName = Interaction.InputBox("Introduce the name of the person that you are looking for.");
            int personIndex = GetPersonId(population, personName);
            if (personIndex >= 0)
            {
                MessageBox.Show($"{personName} index is: {personIndex}");
            }
            else
            {
                MessageBox.Show("That person does not live in this population");
            }
        }
    }
}
