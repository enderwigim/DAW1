using Microsoft.VisualBasic;
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

namespace Ex8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> userTicket = new List<int>();
        List<int> primitivaTicket = new List<int>();
        
        string ShowList(List<int> list)
        {
            string text = "";
            for (int i = 0; i < list.Count; i++)
            {
                text += list[i] + "\n";
            }
            return text;
        }

        void AddToList(List<int> list)
        {
            if (list.Count != 0)
                list.Clear();
            int i = 1;
            int buyingNumber;
            while(i <= 6)
            {
                buyingNumber = int.Parse(Interaction.InputBox("Please, buy a number."));
                if (!userTicket.Contains(buyingNumber) && buyingNumber >= 1 && buyingNumber <= 49)
                {
                    list.Add(buyingNumber);
                    i++;
                    MessageBox.Show("Number bought!");
                }
                else
                {
                    MessageBox.Show("That number is wrong, please. Buy a correct number.");
                }
                
            }
        }
        int GenerateRandomNumber()
        {
            Random rnd = new Random();
            return (rnd.Next(1, 50));
        } 


        int CalculateGuessedNumbers (List<int> listPrimitiva, List<int> userList)
        {
            int guessedNumbers = 0;
            for (int i = 0; i < userList.Count; i++)
            {
                if (listPrimitiva.Contains(userList[i]))
                {
                    guessedNumbers++;
                }

                foreach (int num in listPrimitiva)
                {
                    if (userList[i] == num)
                    {
                        guessedNumbers++;
                    }
                }
            }
            return guessedNumbers;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (primitivaTicket.Count != 0 && userTicket.Count != 0)
            {
                int guessedNumbers = CalculateGuessedNumbers(primitivaTicket, userTicket);
                MessageBox.Show("You got " + guessedNumbers + " guessed.");

                if (guessedNumbers < 6)
                {
                    MessageBox.Show("Better Luck Next Time. Don't worry, we will enjoy your money.");
                }
                else
                {
                    MessageBox.Show("WOOOOW, YOU ARE A WINNER!");
                }
            }
            MessageBox.Show("You need to generate the Primitiva and buy your ticket to play.");
            
        }

        private void btnGeneratePrimitiva_Click(object sender, EventArgs e)
        {
            if (primitivaTicket.Count != 0)
            {
                primitivaTicket.Clear();
            }
            int randomNumber;
            int i = 1;
            while(i <= 6)
            {
                randomNumber = GenerateRandomNumber();
                if (!primitivaTicket.Contains(randomNumber))
                {
                    primitivaTicket.Add(randomNumber);
                    i++;
                }

            }
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            AddToList(userTicket);
        }

        private void btnGodMode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shhhh, this is cheating!");
            MessageBox.Show(ShowList(primitivaTicket));
        }
    }
}
