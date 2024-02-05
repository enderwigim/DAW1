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

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arrayNumber = new int[10];
        int[] arrayNumber2 = new int[10];
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
                }
                else
                {
                    MessageBox.Show("You need to add positive a number");
                }
            }
        }

        void ChangeOrder(int[] array1, int[] array2)
        {
            int num = array1[array1.Length - 1];
            for (int i = 0; i < arrayNumber.Length - 1; i++)
            {
                array2[i + 1] = array1[i];
            }
            array2[0] = num;
        }
        void ChangeArray(int[] array)
        {
            int num = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = arrayNumber[i - 1];
            }
            array[0] = num;
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
            AddToList(arrayNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeArray(arrayNumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowArray(arrayNumber));
            MessageBox.Show(ShowArray(arrayNumber2));
        }
    }
    }

