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

namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numberArray = new int[10];
        bool isRepeated(int[] array, int num)
        {
            bool isRepeated = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    isRepeated = true;
                }
            }
            return isRepeated;
        }
        void AddToArray(int[] array)
        {
            int num;
            int i = 0;
            while(i < array.Length)
            {
                num = int.Parse(Interaction.InputBox("Add a number"));
                if (!isRepeated(numberArray, num))
                {
                    array[i] = num;
                    i++;
                }
                else
                {
                    MessageBox.Show("That name is already in the array");
                }
            }
            
                
            
        }
        string ShowArray(int[] array)
        {
            string arrayText = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayText += array[i] + "\n";
            }
            return arrayText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToArray(numberArray);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = ShowArray(numberArray);
            MessageBox.Show(text);
        }
    }
}
