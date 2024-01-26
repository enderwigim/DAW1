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

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numberList = new int[10];
        void AddToArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = int.Parse(Interaction.InputBox("Introduce un numero"));
        }
        void ShowArray(int[] array)
        {
            string text = "La lista de numeros es: \n";
            for (int i = 0; i < array.Length; i++)
                text += array[i] + " ";

            MessageBox.Show(text);
        }
        
        bool NumberInArray(int[] array, int number)
        {
            bool isNumberInArray = false;
            for (int i = 0; i < array.Length && !isNumberInArray; i++)
            {
                if (array[i] == number)
                    isNumberInArray = true;

            }
            return isNumberInArray;
        }
        private void CreateArray(object sender, EventArgs e)
        {
            AddToArray(numberList);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int userNum = int.Parse(txtUserNum.Text);
            if (NumberInArray(numberList, userNum))
            {
                MessageBox.Show("El numero se encuentra en el array.");
            }
            else
            {
                MessageBox.Show("El numero no se encuentra en el array.");
            }
        }
    }
}
