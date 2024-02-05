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

namespace Ejercicio_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arrayNumber = new int[10];
        int[] arrayNumberUpsideDown = new int[10];
        string ShowArray(int[] array)
        {
            string arrayText = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayText += array[i] + "\n";
            }
            return arrayText;
        }

        void AddToArray(int[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Interaction.InputBox("Introduce a number."));
            }
        }
        void UpsideDownArray(int[] originalArray, int[] newArray)
        {
            for (int i = 0, j = originalArray.Length - 1; i <  originalArray.Length; i++, j--)
            {
                newArray[i] = originalArray[j];
            }
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            AddToArray(arrayNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpsideDownArray(arrayNumber, arrayNumberUpsideDown);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = ShowArray(arrayNumber);
            MessageBox.Show(text);
            text = ShowArray(arrayNumberUpsideDown);
            MessageBox.Show(text);
        }
    }
}
