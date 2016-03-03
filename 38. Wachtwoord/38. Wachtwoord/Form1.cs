using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38.Wachtwoord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtWachtwoord.PasswordChar = '*';
        }

        int beurt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string password = "Wachtwoord123";


            if (txtWachtwoord.Text == password)
            {
                MessageBox.Show("U bent ingelogt!");
            }
            else
            {
                MessageBox.Show("Wachtwoord ongeldig");
                beurt++;
                if (beurt == 3)
                {
                    
                    MessageBox.Show("U heeft het wachtwoord 3 keer fout ingevuld.");
                }
                
            }
        }
    }
}
