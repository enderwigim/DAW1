using Ex3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Global Variables
        SqlDBHelper db;
        private int pos;
        private bool isANewEntry = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new SqlDBHelper();
            pos = 0;

            //ShowEntry(pos);

            //btnSaveNew.Enabled = false;

        }
    }
}
