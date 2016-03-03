using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int Getal1 = int.Parse(txtGetal1.Text); // Haalt de value uit elke textbox en stop ze in een int zodat ze vergeleken kunnen worden
            int Getal2 = int.Parse(txtGetal2.Text);
            int Getal3 = int.Parse(txtGetal3.Text);
            int Opslag = 0;

            if (Getal1 > Getal2 && Getal1 > Getal3) // Als getal1 groter is dan getal2 en getal3 = opslag getal 1
            {
                Opslag = Getal1;
            }

            else if (Getal2 > Getal1 && Getal2 > Getal3) // Als getal2 groter is dan Getal1 en Getal3 = Opslag getal 2
            {
                Opslag = Getal2;
            }

            else                        // Als de bovenstaande statments niet waar zijn = Opslag Getal3
            {
                Opslag = Getal3;
            }

            messageBox(Opslag); // Voer de methode messageBox uit en geeft de waarde van "Opslag" mee.
        }

           public int messageBox(int Opslag)
            {
            string message, title; 

            message = Opslag + ""; // + "" zorgt er voor dat we niet lastig hoefen te doen met de varaibles converten.

            title = "Het grootste getal is"; // dit is de title van de message box
            MessageBox.Show(message, title); // MessageBox word gemaakt met "title" als title en "message" als inhoud
            return (0);
            }

        private void btn2_Click(object sender, EventArgs e)
        {
            int korting, prijsInc;
            int kaartjes = int.Parse(txtAantalTickets.Text);
            int prijsEx = int.Parse(txtPrijsTicket.Text.Remove(0,1)); // .Remove(0,1) verwijderd 1 carakter vanaf het 0de punt zodat het "€" niet in de weg zit tijdens het rekenen.

            korting = kaartjes / 10; // hier kijken we hoeveel kaartjes we gratis krijgen 20kaartjes / 10 = 2 kaartjes gratis
            prijsInc = (kaartjes - korting) * prijsEx;

            txtKosten.Text = "€" + prijsInc;
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string message, title;
            double evenOrOdd = double.Parse(txtEvenOnEven.Text);
            if (evenOrOdd % 2 == 0)
            {
                

                message = "Dit getal is even";
                title = "even of oneven";

                MessageBox.Show(message, title);
            }
            else
            {
                message = "Dit getal is oneven";
                title = "even of oneven";

                MessageBox.Show(message, title);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string message;
            string bankNummer;
            long banknummerEersteTien, banknummerLaatsteTwee;

            bankNummer = txtBank.Text;
            bankNummer =bankNummer.Replace("-","");

            if (bankNummer.Length < 12)
            {
                
                MessageBox.Show("Dit banknummer is te klein");
            }
            else
            {
                banknummerEersteTien = long.Parse(bankNummer.Substring(0, 10));
                banknummerLaatsteTwee = long.Parse(bankNummer.Substring(10, 2));



                if (banknummerEersteTien % 97 == banknummerLaatsteTwee)
                {
                    message = "Dit banknummer is geldig";
                    MessageBox.Show(message, "banknummer");
                }

                else
                {
                    message = "Dit banknummer is ongeldig";
                    MessageBox.Show(message, "banknummer");
                }
            }


        }
    }
}
