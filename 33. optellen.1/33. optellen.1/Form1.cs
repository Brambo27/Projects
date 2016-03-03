using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33.optellen._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTelOP_Click(object sender, EventArgs e)
        {
            int getal, som, tellen;
            som = 0;
            tellen = 0;
            getal = int.Parse(txtEersteGetal.Text);

            while(getal != 0)
            {
                som = som + getal;
                tellen++;
                getal = int.Parse(InputBox.Input.Show("Voer een getal in", "Invoer gevraagd", ""));

            }
            txtSom.Text = som + "";
            txtAantalGetallen.Text = tellen + "";
            
        }
        static private void btncancel_Click(object sender, EventArgs e)
        {

            Console.Write("Test");
        }
    }
}
