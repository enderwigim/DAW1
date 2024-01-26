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

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> OriginalList = new List<int>();
        List<int> NewList = new List<int>();

        bool isPrimeNumber(int number)
        {
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }

        string ShowList(List<int> listToShow)
        {
            string text = "";

            for (int i = 0; i < listToShow.Count; i++)
            {
                text += listToShow[i] + "\n";
            }
            return text;
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            DialogResult more = DialogResult.Yes;
            int value;

            while (more == DialogResult.Yes)
            {
                value = int.Parse(Interaction.InputBox("Please, enter a number to add it to the list."));
                OriginalList.Add(value);
                more = MessageBox.Show("Do you want to enter another value?", "Value", MessageBoxButtons.YesNo);
            }
        }

        private void btnCopyPrime_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OriginalList.Count; i++)
            {
                if (isPrimeNumber(OriginalList[i]))
                {
                    NewList.Add(OriginalList[i]);
                }
            }
        }

        private void btnRemovePrime_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OriginalList.Count; i++)
            {
                if (isPrimeNumber(OriginalList[i]))
                {
                    NewList.Add(OriginalList[i]);
                    OriginalList.RemoveAt(i);
                }
            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            DialogResult whatList = DialogResult.Yes;
            string text;
            whatList = MessageBox.Show("Do you want me to show you the first list?", "Value", MessageBoxButtons.YesNo);
            if (whatList == DialogResult.Yes)
            {
                text = ShowList(OriginalList);
                MessageBox.Show(text);
            }
            else
            {
                whatList = MessageBox.Show("Do you want me to show you the new list?", "Value", MessageBoxButtons.YesNo);
                if (whatList == DialogResult.Yes)
                {
                    text = ShowList(NewList);
                    MessageBox.Show(text);
                }
            }
           
        }
    }
}
