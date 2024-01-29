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

namespace Exercise_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> TextList = new List<string>();
        void AddToList(List<string> list)
        {
            
            string text = Interaction.InputBox("Add a text to the list");
            list.Add(text);

            DialogResult more = MessageBox.Show("Do you want to enter a new value?", "Value", MessageBoxButtons.YesNo);
            while (more == DialogResult.Yes)
            {
                int i = 0;
                text = Interaction.InputBox("Add a text to the list");
                bool inserted = false;
                while (i < list.Count && !inserted)
                {
                    
                    if (string.Compare(text, list[0]) <= 0)
                    {
                        list.Insert(i, text);
                        inserted = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (!inserted)
                    list.Add(text);
                
                more = MessageBox.Show("Do you want to enter a new value?", "Value", MessageBoxButtons.YesNo);
            }
        }
        string ShowList(List<string> list)
        {
            string text = "";
            for(int i = 0; i < list.Count; i++)
            {
                text += list[i] + "\n";
            }
            return text;
        }
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            AddToList(TextList);
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowList(TextList));
        }
    }
}
