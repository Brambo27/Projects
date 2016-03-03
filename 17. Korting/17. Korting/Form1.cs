using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17.Korting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAankoop_TextChanged(object sender, EventArgs e)
        {
            if (txtAankoop.Text.Length > 0)
            {
                int aankoop = int.Parse(txtAankoop.Text);
                double korting;

                if (aankoop > 1000)
                {
                    korting = 0.10;

                }
                else if (aankoop > 500)
                {
                    korting = 0.08;
                }
                else if (aankoop > 100)
                {
                    korting = 0.05;
                }
                else
                {
                    korting = 0;
                }

                txtEind.Text = aankoop - (aankoop * korting) + "";

            }
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
           
        }
    }
}
