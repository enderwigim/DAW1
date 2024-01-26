using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> OriginalList = new List<int>();
        List<int> NewList1 = new List<int>();
        List<int> NewList2 = new List<int>();

        void CopyEvensInNewList(List<int> Oldlist, List<int> newList)
        {
            for (int i = 0;  i < Oldlist.Count; i++)
            {
                if (Oldlist[i] % 2 == 0)
                {
                    newList.Add(Oldlist[i]);
                }
            }
        }

        void RemoveEvensFromOldAndCopyInNew(List<int> Oldlist, List<int> newList)
        {
            for (int i = 0; i < Oldlist.Count; i++)
            {
                if (Oldlist[i] % 2 == 0)
                {
                    newList.Add(Oldlist[i]);
                    Oldlist.RemoveAt(i);
                }
            }
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

        private void btnShowNewList1_Click(object sender, EventArgs e)
        {
            CopyEvensInNewList(OriginalList, NewList1);
            MessageBox.Show(ShowList(NewList1));

        }

        private void btnShowList2_Click(object sender, EventArgs e)
        {
            RemoveEvensFromOldAndCopyInNew(OriginalList, NewList2);
            MessageBox.Show(ShowList(OriginalList));
            MessageBox.Show(ShowList(NewList2));
        }
    }
}
