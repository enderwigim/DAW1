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

namespace Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> OriginalList1 = new List<int>();
        List<int> OriginalList2 = new List<int>();
        List<int> newList = new List<int>();


        void OrderList (List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        int numIntercambio = list[i];
                        list[i] = list[j];
                        list[j] = numIntercambio;
                    }
                }
            }
        }
        string ShowList (List<int> list)
        {
            string text = "";
            for (int i = 0; i < list.Count; i++)
            {
                text += list[i] + "\n";
            }
            return text;
        }
        void CopyIntoNewList(List<int> originalList1, List<int> originalList2, List<int> newList)
        {
            int i, j;
            i = j = 0;
            while (i < originalList1.Count && j < originalList2.Count)
            {
                
                if (originalList1[i] < originalList2[j])
                {   
                    if (!newList.Contains(originalList1[i]))
                    {
                        newList.Add(originalList1[i]);
                    }
                    
                    i++;
                }
                else
                {
                    if (!newList.Contains(originalList2[j]))
                    {
                        newList.Add(originalList2[j]);
                    }

                    j++;

                }
                
                
            }
            while (j < originalList2.Count)
            {
                if (!newList.Contains(originalList2[j]))
                {
                    newList.Add(originalList2[j]);
                }
                j++;
            };
            
            while (i < originalList1.Count)
            {
                if (!newList.Contains(originalList1[i]))
                {
                    newList.Add(originalList1[i]);
                }
                i++;
            };
            


        }
        void CopyIntoNewListAndRemove(List<int> originalList1, List<int> originalList2, List<int> newList)
        {
            int i, j;
            i = j = 0;
            while (i < originalList1.Count && j < originalList2.Count)
            {
                if (originalList1[i] > originalList2[j])
                {
                    if (!newList.Contains(originalList2[j]))
                    {
                        newList.Add(originalList1[i]);
                        originalList1.RemoveAt(i);
                    }
                    
                    
                    
                }
                else
                {
                    if (!newList.Contains(originalList2[j]))
                    {
                        newList.Add(originalList2[j]);
                        originalList1.RemoveAt(j);
                    }

                    
                    
                }
            }
            while (j < originalList2.Count)
            {
                newList.Add(originalList2[j]);
                originalList2.RemoveAt(j);
            };

            while (i < originalList1.Count)
            {
                if (!newList.Contains(originalList2[j]))
                { 
                    newList.Add(originalList1[i]);
                    originalList1.RemoveAt(i);
                }
            };



        }
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            DialogResult more = DialogResult.Yes;
            int value;

            while (more == DialogResult.Yes)
            {
                value = int.Parse(Interaction.InputBox("Please, enter a number to add it to the first list."));
                OriginalList1.Add(value);
                more = MessageBox.Show("Do you want to enter another value?", "Value", MessageBoxButtons.YesNo);
            }
            
            more = DialogResult.Yes;
            while (more == DialogResult.Yes)
            {
                value = int.Parse(Interaction.InputBox("Please, enter a number to add it to the second list."));
                OriginalList2.Add(value);
                more = MessageBox.Show("Do you want to enter another value?", "Value", MessageBoxButtons.YesNo);
            }
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            OrderList(OriginalList1);
            OrderList(OriginalList2);
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            DialogResult whatList = DialogResult.Yes;
            string text;
            whatList = MessageBox.Show("Do you want me to show you the first list?", "Value", MessageBoxButtons.YesNo);
            if (whatList == DialogResult.Yes)
            {
                text = ShowList(OriginalList1);
                MessageBox.Show(text);
            }
            
            whatList = MessageBox.Show("Do you want me to show you the second list?", "Value", MessageBoxButtons.YesNo);
            if (whatList == DialogResult.Yes)
            {
                text = ShowList(OriginalList2);
                MessageBox.Show(text);
            }
            

            whatList = MessageBox.Show("Do you want me to show you the new list?", "Value", MessageBoxButtons.YesNo);
            if (whatList == DialogResult.Yes)
            {
                text = ShowList(newList);
                MessageBox.Show(text);
            }
            

        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            CopyIntoNewList(OriginalList1, OriginalList2, newList);
        }

        private void btnCopyRemove_Click(object sender, EventArgs e)
        {
            CopyIntoNewListAndRemove(OriginalList1, OriginalList2, newList);
        }
    }
}
