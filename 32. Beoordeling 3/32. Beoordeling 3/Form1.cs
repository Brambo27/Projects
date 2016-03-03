using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32.Beoordeling_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnOp1_Click(object sender, EventArgs e) 
//Opdracht 1. als ik in txtVeelVoudVan een getal zet moet ik de tafel van dat getal in listbox1 zetten tot het getal dat in txtVeelVoudMax
        {
            try { 
                int max = int.Parse(txtVeelVoudMax.Text) - int.Parse(txtVeelVoudVan.Text);
                int veelvoudvan = int.Parse(txtVeelVoudVan.Text);
                int veelvoudAntwoord = 0;
                for (int i = 0; veelvoudAntwoord <= max; i++)
                {
                    veelvoudAntwoord = veelvoudvan * i; 
                    listBox1.Items.Add(veelvoudAntwoord);
                }
            }
            catch (System.FormatException) // kijk of er getallen in de textboxen staan.
            {
                // error message
                MessageBox.Show("Voer in allebij de textvlakken een getal in!", "Error!" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
            catch (System.OverflowException)// kijk of het getal in de textboxen te groot is.
            {
                //error message
                MessageBox.Show("Te groot getal ingevoerd!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//Vul een zin in en laat zien hoeveel keer de letter "d" voor komt
        private void button2_Click(object sender, EventArgs e)
        {
            string zin = txtZin.Text;

            //Haal alle chars weg behalve "d" en maak geen onderschijd tussen hoofdletters en kleine letters.
            //Tel het aantal chars in de zin die overblijft en zet dat in de textbox
            txtAantalD.Text = Regex.Replace(zin, "[^d]", "", RegexOptions.IgnoreCase).Length + ""; 

        }

        private void button3_Click(object sender, EventArgs e)
//Maak een dobbelsteen simulator en vertel hoeveel keer 4 is gegooid
        {
        try {
                int gooien = int.Parse(txtAantalGooien.Text);
                Random dice = new Random(); //Maak een object met type random en de naam dice aan met classe Random (Geen idee hoe ik dit legit kan verwoorden).
                string randomString = "";
                for (int i = 0; gooien > i; i++) // loop tot gooien kleiner is dan i en increment i.
                {
                    randomString += dice.Next(1, 7).ToString(); // voeg elke keer een random nummer in string voormaat toe aan randomString.
                }
                randomString = Regex.Replace(randomString, "[^4]", ""); // Haal alles weg behalve 4
                txtAantal4.Text = randomString.Length + ""; // Tel de lengte van de string zonder alles behalve 4en en zet dat in de textbox
            }
            catch (System.FormatException) //kijk of er wel een getal is ingevoerd
            {       
                //error message
                MessageBox.Show("Voer een getal in!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            catch (System.OverflowException) //kijk of het getal te groot is
            {
                //error message
                MessageBox.Show("Dit getal is te groot!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                 
        }
    }
}
