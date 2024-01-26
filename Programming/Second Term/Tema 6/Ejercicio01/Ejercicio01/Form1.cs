using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numbers = new List<int>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Ejercicio 1", "Inserte un numero"));
            numbers.Add(num);
            MessageBox.Show("Succeded");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int num, position;

            num = int.Parse(Interaction.InputBox("Ejercicio 1", "Elija un numero"));
            position = int.Parse(Interaction.InputBox("Ejercicio 1", "Elija una posición"));
            if (position <= numbers.Count)
            {
                numbers.Insert(position, num);
                MessageBox.Show("Succeded");
            }
            else
            {
                MessageBox.Show("Failed, the position inserted wasn't valid");
            }
            
        }
        private void btnShowList_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (int num in numbers)
            {
                text += num + "\n";
            }
            if (text != "")
            {
                MessageBox.Show(text);
            }
            else
            {
                MessageBox.Show("The list is empty");
            }
        }

        private void btnShowFirstPosition_Click(object sender, EventArgs e)
        {
            int num, index;

            num = int.Parse(Interaction.InputBox("Ejercicio 1", "Please, choose a number"));
            index = numbers.IndexOf(num);
            if (index < 0)
            {
                MessageBox.Show("That number is not in the list.");
            }
            else
            {
                MessageBox.Show("The position where your number is: " + index);
            }         
        }

        private void btnShowPositionOfValues_Click(object sender, EventArgs e)
        {
            int num;
            string positions = "";
            if (numbers.Count != 0)
            {
                num = int.Parse(Interaction.InputBox("Ejercicio 1", "Please, choose a number"));
                if (numbers.Contains(num))
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == num)
                        {
                            positions += i + "\n";
                        }
                    }
                    MessageBox.Show(positions);

                }
            }
            else
            {
                MessageBox.Show("The list is empty.");
            }
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            int num;
            int firstPosition;
            if (numbers.Count != 0)
            {
                num = int.Parse(Interaction.InputBox("Select a button to remove"));
                if (numbers.Contains(num))
                {
                    firstPosition = numbers.IndexOf(num);
                    numbers.RemoveAt(firstPosition);
                }
                    
                
            }
            
            try
            {
                numbers.RemoveAt(0);
                MessageBox.Show("Succeded");
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("An error ocurred " + ex.ToString());
            }
            
        }

        private void btnRemoveValues_Click(object sender, EventArgs e)
        {
            int num, index;

            num = int.Parse(Interaction.InputBox("Ejercicio 1", "Please, choose a number"));
            if (numbers.Contains(num))
            {
                index = 0;

                while (index < numbers.Count)
                {
                    if (numbers[index] == num)
                    {
                        numbers.RemoveAt(index);
                        index--;
                    }
                    index++;
                }
                MessageBox.Show("The value was removed from the list.");
            }
            MessageBox.Show("The value wasn't in the list.");
            

        }

        private void btnRemovePosition_Click(object sender, EventArgs e)
        {
            int position;

            try
            {
                position = int.Parse(Interaction.InputBox("Ejercicio 1", "Please, select a position to erase"));
                numbers.RemoveAt(position);
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("An error ocurred " + ex.ToString());
            }

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            numbers.Sort();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numbers.Clear();
        }
    }
}
