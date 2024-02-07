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

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] array = new string[2];
        string[] array2 = new string[] {"pedro", "pedro", "santiago", "santiago", "sebas"};

        bool isRepeatedTwice(string[] array, string name)
        {
            bool isRepeatedTwice = false;
            int counter = 0;
            for (int i = 0; i < array.Length && !isRepeatedTwice; i++)
            {
                if (array[i] == name)
                {
                    counter++;
                    if (counter >= 2)
                    {
                        isRepeatedTwice = true;
                    }
                }
            }

            return isRepeatedTwice;
        }
        void AddToArray(string[] array1, string[] array2) 
        {
            int i = 0;
            string new_name;
            while(i < array1.Length)
            {
                new_name = Interaction.InputBox("Introduce un nombre");
                if (isRepeatedTwice(array2, new_name))
                {
                    array1[i] = new_name;
                    i++;
                }
                else
                {
                    MessageBox.Show("Error, la palabra no estaba repetida");
                    i = 0;
                }
            }
        }

        string ShowArray(string[] array1)
        {
            string text = "";
            for(int i = 0; i < array1.Length; i++)
            {
                text += array1[i] + "\n";
            }
            return text;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddToArray(array, array2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowArray(array));
        }
    }
}
