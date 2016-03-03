using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19.Kaartje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLeef_TextChanged(object sender, EventArgs e)
        {
            if (txtLeef.Text.Length >= 1)
            {
                int leeftijd = int.Parse(txtLeef.Text);

                if (leeftijd > 64)
                {
                    txtPrijs.Text = "€"+12;
                }

                else if (leeftijd < 13)
                {
                    txtPrijs.Text = "€"+15;
                }
                else
                {
                    txtPrijs.Text = "€"+20;
                }
            }
            else
            {
                txtPrijs.Text = "€";
            }
        }
    }
}
