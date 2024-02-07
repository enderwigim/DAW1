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

namespace Test3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numberList = new List<int>();
        bool isGreater(int num1, int num2)
        {
            bool result = true;
            if (num2 > num1)
            {
                result = false;
            }
            return result;
        }


        void AddNumber(List<int> numList)
        {
            DialogResult more = DialogResult.Yes;
            int num = int.Parse(Interaction.InputBox("Add number"));
            numList.Add(num);
            more = MessageBox.Show("Do you want to add a new number", "", MessageBoxButtons.YesNo);
            while (more == DialogResult.Yes)
            {
                num = int.Parse(Interaction.InputBox("Add number"));
                if (isGreater(num, numList[numList.Count - 1]) && !numList.Contains(num))
                {
                    numList.Add(num);
                }
                else
                {
                    if (numList.Contains(num))
                    {
                        MessageBox.Show("The numbers is in the list.");
                    } else
                    {
                        MessageBox.Show("The number isn't greater than the previous one");
                    }
                    
                }
                more = MessageBox.Show("Do you want to add a new number", "", MessageBoxButtons.YesNo);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddNumber(numberList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                MessageBox.Show(numberList[i].ToString());
            }
        }
    }
}
