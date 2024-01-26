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

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void AddToArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Interaction.InputBox("Dame un numero para el vector"));
            }
        }

        bool CompareArray(int[] array1, int[] array2)
        {
            bool iguales = true;
            for (int i = 0; i < array1.Length && iguales; i++)
            {
                if (array1[i] != array2[i])
                {
                    iguales = false;
                }
            }
            return iguales;
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] array1 = new int[2];
            int[] array2 = new int[2];

            AddToArray(array1);
            AddToArray(array2);
            
            if (CompareArray(array1, array2))
            {
                MessageBox.Show("Son iguales");
            }
        }
    }
}
