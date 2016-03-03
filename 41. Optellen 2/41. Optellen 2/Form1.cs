using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41.Optellen_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int getal, teller = -1, som = 0;

            do
            {
                getal = int.Parse(InputBox.Input.Show("voer een getal in", "input gevraagd", ""));
                som = som + getal;
                teller++;
            }
            while (getal != 0);

            txtOpgeteld.Text = teller + "";
            txtSom.Text = som + "";
        }
    }
}
