using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.Loon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtOmzet_TextChanged(object sender, EventArgs e)
        {
            if (txtOmzet.Text.Length > 0)
            {
                double omzet = double.Parse(txtOmzet.Text);
                if (omzet > 25000)
                {
                    double extra = omzet * 0.15;
                    txtLoon.Text = 1400 + extra + "";

                }
                else
                {
                    txtLoon.Text = 1400 + "";
                }
            }
            else
            {

            }
        }
    }
}
