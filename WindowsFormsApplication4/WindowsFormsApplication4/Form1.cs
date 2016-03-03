using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            string banknummer = txtBankNummer.Text;
            if (banknummer.Length == 9)
            {
                int rest;
                int cijfer1 = int.Parse(banknummer.Substring(0, 1));
                int cijfer2 = int.Parse(banknummer.Substring(1, 1));
                int cijfer3 = int.Parse(banknummer.Substring(2, 1));
                int cijfer4 = int.Parse(banknummer.Substring(3, 1));
                int cijfer5 = int.Parse(banknummer.Substring(4, 1));
                int cijfer6 = int.Parse(banknummer.Substring(5, 1));
                int cijfer7 = int.Parse(banknummer.Substring(6, 1));
                int cijfer8 = int.Parse(banknummer.Substring(7, 1));
                int cijfer9 = int.Parse(banknummer.Substring(8, 1));

                int opslag;
                opslag = cijfer1 * 9 + cijfer2 * 8 + cijfer3 * 7 + cijfer4 * 6 + cijfer5 * 5 + cijfer6 * 4 + cijfer7 * 3 + cijfer8 * 2 + cijfer9 * 1;

                rest = opslag % 11;

                if (rest == 0)
                {
                    MessageBox.Show("Dit rekeningnummer is geldig", "Rekeningnummer");
                }
                else
                {
                    MessageBox.Show("Dit rekeningnummer is ongeldig", "Rekeningnummer");
                }
            }
            else
            {

            }
        }
    }
}
