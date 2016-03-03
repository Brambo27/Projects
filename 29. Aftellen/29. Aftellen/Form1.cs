using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29.Aftellen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtGetal.TextLength > 0)
            {
                for (int getal = int.Parse(txtGetal.Text); getal > 0; getal--)
                {
                    listBox1.Items.Add(getal);
                }
            }
            else
            {
                MessageBox.Show("Voer een getal in!", "Error!");
            }
        }
    }
}
