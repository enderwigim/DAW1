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

namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arrayNumber = new int[5];

        void AddToList(int[] array)
        {
            int num;
            int i = 0;
            while (i < array.Length)
            {
                num = int.Parse(Interaction.InputBox("Add a positive number"));
                if (num > 0)
                {
                    array[i] = num;
                    i++;
                } else
                {
                    MessageBox.Show("You need to add positive a number");
                }
            }
                
            
        }
        string ShowArray(int[] array)
        {
            string arrayText = "";
            for (int i = 0; i < array.Length;  i++)
            {
                arrayText += array[i] + "\n";
            }
            return arrayText;
        } 
        void ReplaceRepeteated(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1;  j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        array[j] = -1;
                    } 
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddToList(arrayNumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = ShowArray(arrayNumber);
            MessageBox.Show(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReplaceRepeteated(arrayNumber);
        }
    }
}
