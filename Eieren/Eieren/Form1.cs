using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnBereken_Click(object sender, EventArgs e)
        {

            int eieren = int.Parse(txtEi.Text + "");
            txtGros.Text = eieren / 144 + "" ;
            eieren %= 144;
            txtDozijn.Text = eieren / 12 + "";
            txtOver.Text = eieren % 12 + "";







        }
    }
}
