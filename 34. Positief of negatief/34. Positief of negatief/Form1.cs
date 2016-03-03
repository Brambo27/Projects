using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34.Positief_of_negatief
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(txtGetal.Text);
            int som = 0;
            while (getal != 0)
            {
                som = som + getal;
                getal = int.Parse(InputBox.Input.Show("Voer een getal in", "Invoer gevraagd", ""));
            }
            if (som < 0)
            {
                txtUitkomst.Text = "Negatief";
            }
            else
            {
                txtUitkomst.Text = "Positief";
            }
        }
    }
}
