using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21.Beoordeling2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                int getal1 = int.Parse(txtOptel1.Text);
                int getal2 = int.Parse(txtOptel2.Text);
                txtOptelUitkomst.Text = getal1 + getal2 + "";
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Je moet een getal invullen!", "Error!");
                txtOptel1.Text = "";
                txtOptel2.Text = "";
                txtOptelUitkomst.Text = "";
                txtOptel1.Select();
            }
        }

        private void btnVergelijkBereken_Click(object sender, EventArgs e)
        {
            try {
                int eerste = int.Parse(txtVergelijk1.Text);
                int tweede = int.Parse(txtVergelijk2.Text);
                if (eerste > tweede)
                {
                    txtBeoordeel.Text = "Eerste > Tweede";
                }
                if (tweede > eerste)
                {
                    txtBeoordeel.Text = "Tweede > Eerste";
                }
                if (eerste == tweede)
                {
                    txtBeoordeel.Text = "Eerste = Tweede";
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Voer een getal in!", "Error!");
                txtBeoordeel.Text = "";
                txtVergelijk1.Text = "";
                txtVergelijk2.Text = "";
                txtVergelijk1.Focus();
            }
        }

        private void btnBerekenMaand_Click(object sender, EventArgs e)
        {
            try {
                byte maandNr = byte.Parse(txtMaandInNummer.Text);

                switch (maandNr)
                {
                    case 1:
                        txtMaand.Text = "Januari";
                        break;
                    case 2:
                        txtMaand.Text = "Februari";
                        break;
                    case 3:
                        txtMaand.Text = "Maart";
                        break;
                    case 4:
                        txtMaand.Text = "April";
                        break;
                    case 5:
                        txtMaand.Text = "Mei";
                        break;
                    case 6:
                        txtMaand.Text = "Juni";
                        break;
                    case 7:
                        txtMaand.Text = "Juli";
                        break;
                    case 8:
                        txtMaand.Text = "Augustus";
                        break;
                    case 9:
                        txtMaand.Text = "September";
                        break;
                    case 10:
                        txtMaand.Text = "Oktober";
                        break;
                    case 11:
                        txtMaand.Text = "November";
                        break;
                    case 12:
                        txtMaand.Text = "December";
                        break;
                    default:
                        MessageBox.Show("Voer een geldig getal in. (1 t/m 12)");

                        break;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Voer een getal in!", "Error!");
                txtMaand.Text = "";
                txtMaandInNummer.Text = "";
                txtMaandInNummer.Focus();
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Dit getal is te groot!", "Error!");
                txtMaand.Text = "";
                txtMaandInNummer.Text = "";
                txtMaandInNummer.Focus();
            }
        }

        private void btnOntleeden_Click(object sender, EventArgs e)
        {
            switch (txtOntleedTotaal.Text.Length)
            {
                case 1:
                    txtEenheid.Text = txtOntleedTotaal.Text.Substring(3, 1);
                    break;
                case 2:
                    txtTiental.Text = txtOntleedTotaal.Text.Substring(2, 1);
                    goto case 1;
                case 3:
                    txtHonderdtal.Text = txtOntleedTotaal.Text.Substring(1, 1);
                    goto case 2;
                case 4:
                    txtDuizendtal.Text = txtOntleedTotaal.Text.Substring(0, 1);
                    goto case 3;
            }
        }

        private void btnSamenVoegen_Click(object sender, EventArgs e)
        {
           if (txtEenheid.Text.Length == 0)
            {
                txtEenheid.Text = "0";
            }
           if (txtTiental.Text.Length == 0)
            {
                txtTiental.Text = "0";
            }
           if (txtHonderdtal.TextLength == 0)
            {
                txtHonderdtal.Text = "0";
            }
           if (txtDuizendtal.TextLength == 0)
            {
                txtDuizendtal.Text = "0";
            }
            int duizendtal = int.Parse(txtDuizendtal.Text)*1000;
            int honderdtal = int.Parse(txtHonderdtal.Text)*100;
            int tiental = int.Parse(txtTiental.Text)*10;
            int eenheid = int.Parse(txtEenheid.Text);


            txtOntleedTotaal.Text = duizendtal + honderdtal + tiental + eenheid + "";
           
        }

        private void btnGetalNaarText_Click(object sender, EventArgs e)
        {
        
        }

        public int eenheid(int eenheid)
        {
            string eenheidTxt;
            switch (eenheid)
            {
                case 1:
                    eenheidTxt = "Een";
                    break;
                case 2:
                    eenheidTxt = "Twee";
                    break;
                case 3:
                    eenheidTxt = "Drie";
                    break;
                case 4:
                    eenheidTxt = "Vier";
                    break;
                case 5:
                    eenheidTxt = "Vijf";
                    break;
                
            }
                
                    
                
            return (0);
        }


    }
}
