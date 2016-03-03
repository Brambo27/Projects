using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39.Pincode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int saldo = 100000000;
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int geld = int.Parse(txtGeld.Text);
                string pincode = "0805";

                if (txtPin.Text == pincode)
                {
                    if (saldo > geld)
                    {
                        saldo -= geld;

                        string message = string.Format("Uw nieuwe saldo is {0}", saldo);

                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show("Je hebt niet genoeg geld op je rekening staan!");
                    }
                }
                else
                {
                    MessageBox.Show("Deze pincode is ongeldig");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Voer een bedrag in!", "FormatException Error!" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }

}
