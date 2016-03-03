using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40.Hoger_Lager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        { int teradenGetal, getal = int.Parse(txtInput.Text), teller = 1;
            
            teradenGetal = r.Next(1, 1001);
            while (getal != teradenGetal)
            {
                if (getal < teradenGetal)
                {
                    MessageBox.Show("Je moet hoger!");
                }
                if (getal > teradenGetal)
                {
                    MessageBox.Show("Je moet lager!");
                }
                teller++;
                getal = int.Parse(InputBox.Input.Show("Vul een getal in!", "Input gevraagd", ""));
            }

            string message = string.Format("Je hebt het getal in {0} keer geraden", teller);
            MessageBox.Show(message);

        }      
    }
}
