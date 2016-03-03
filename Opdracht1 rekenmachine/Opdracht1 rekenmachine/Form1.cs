using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht1_rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double getal1, getal2, uitkomst;

        private void btnDelen_Click(object sender, EventArgs e)
        {
            getal1 = double.Parse(TxtGetal1.Text);
            getal2 = double.Parse(TxtGetal2.Text);
            uitkomst = getal1 / getal2;

            TxtUitkomst.Text = uitkomst.ToString();
        }

        private void btwKeer_Click(object sender, EventArgs e)
        {
            getal1 = double.Parse(TxtGetal1.Text);
            getal2 = double.Parse(TxtGetal2.Text);

            uitkomst = getal1 * getal2;

            TxtUitkomst.Text = uitkomst.ToString();
        }

        private void btwMod_Click(object sender, EventArgs e)
        {
            int getal1, getal2, uitkomst;

            getal1 = int.Parse(TxtGetal1.Text);
            getal2 = int.Parse(TxtGetal2.Text);

            uitkomst = getal1 % getal2;

            TxtUitkomst.Text = uitkomst.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

            // lees getal 1 (getal 1 uit tektvak getal 1 halen)
            getal1 =double.Parse(TxtGetal1.Text);
            getal2 =double.Parse(TxtGetal2.Text);

            uitkomst = getal1 + getal2;

            // schrijf Uitkomst
            TxtUitkomst.Text = uitkomst.ToString ();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

            getal1 = double.Parse(TxtGetal1.Text);
            getal2 = double.Parse(TxtGetal2.Text);

            uitkomst = getal1 - getal2;

            TxtUitkomst.Text = uitkomst.ToString();
        }
    }
}
