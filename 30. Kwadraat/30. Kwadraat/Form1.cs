using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30.Kwadraat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBepaal_Click(object sender, EventArgs e)
        {
            if (txt1.TextLength > 0)
            {

                for (int aantal = int.Parse(txt1.Text), i = 0; i <= aantal; i++)
                {
                    listBox1.Items.Add("Het kwadraat van" + i + " is" + (i * i));
                }
            }
            else
            {
                MessageBox.Show("Vul een getal in!", "Error!");
            }
        }
    }
}
