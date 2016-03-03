using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31.Postcodeloterij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrekking_Click(object sender, EventArgs e)
        {
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Random index = new Random();
            Random cijfer = new Random();

            string letter = alfabet.Substring(index.Next(26),1)  + alfabet.Substring(index.Next(26),1);

            txtWin.Text = cijfer.Next(2020,2023) + letter;
        }
    }
}
