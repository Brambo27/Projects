using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keuze_4.Boter__kaas_en_eieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool beurtRondje = true;
        int getal1 = 0, getal2 = 0, getal3 = 0, getal4 = 0, getal5 = 0, getal6 = 0, getal7 = 0, getal8 = 0, getal9 = 0, getal10 = 100, gameOver;
        string gewonnen;

        private void label1_Click(object sender, EventArgs e)
        {
            
            if (getal1 == 0)
            {

                
                boterKaasEieren(1);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            if (getal2 == 0)
            {

                
                boterKaasEieren(2);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            if (getal3 == 0)
            {

                
                boterKaasEieren(3);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            if (getal4 == 0)
            {

                
                boterKaasEieren(4);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            if (getal5 == 0)
            {

                
                boterKaasEieren(5);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            if (getal6 == 0)
            {

               
                boterKaasEieren(6);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            if (getal7 == 0)
            {

                
                boterKaasEieren(7);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            if (getal8 == 0)
            {

                
                boterKaasEieren(8);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
            if (getal9 == 0)
            {

               
                boterKaasEieren(9);
            }
        }

        void boterKaasEieren(int vakje)
        {
            if (beurtRondje == true)
            {
                switch (vakje)
                {
                    case 1:
                        label1.Text = "O";
                        getal1 = 1;
                        break;
                    case 2:
                        label2.Text = "O";
                        getal2 = 1;
                        break;
                    case 3:
                        label3.Text = "O";
                        getal3 = 1;
                        break;
                    case 4:
                        label4.Text = "O";
                        getal4 = 1;
                        break;
                    case 5:
                        label5.Text = "O";
                        getal5 = 1;
                        break;
                    case 6:
                        label6.Text = "O";
                        getal6 = 1;
                        break;
                    case 7:
                        label7.Text = "O";
                        getal7 = 1;
                        break;
                    case 8:
                        label8.Text = "O";
                        getal8 = 1;
                        break;
                    case 9:
                        label9.Text = "O";
                        getal9 = 1;
                        break;
                }
                getal10 = 3;
                gewonnen = "Rondje";
            }
            if (beurtRondje == false)
            {
                switch (vakje)
                {
                    case 1:
                        label1.Text = "X";
                        getal1 = 10;
                        break;         
                    case 2:            
                        label2.Text = "X";
                        getal2 = 10;
                        break;         
                    case 3:            
                        label3.Text = "X";
                        getal3 = 10;
                        break;         
                    case 4:            
                        label4.Text = "X";
                        getal4 = 10;
                        break;         
                    case 5:            
                        label5.Text = "X";
                        getal5 = 10;
                        break;         
                    case 6:            
                        label6.Text = "X";
                        getal6 = 10;
                        break;         
                    case 7:            
                        label7.Text = "X";
                        getal7 = 10;
                        break;         
                    case 8:            
                        label8.Text = "X";
                        getal8 = 10;
                        break;
                    case 9:
                        label9.Text = "X";
                        getal9 = 10;
                        break;

                        
                }
                getal10 = 30;
                gewonnen = "Kruisje";
            }
            beurtRondje = !beurtRondje;
            gameOver++;
            if (getal1 + getal2 + getal3 == getal10 || getal4 + getal5 + getal6 == getal10 || getal7 + getal8 + getal9 == getal10 || getal1 + getal4 + getal7 == getal10 || getal2 + getal5 + getal8 == getal10 || getal3 + getal6 + getal9 == getal10 || getal1 + getal5 + getal9 == getal10 || getal3 + getal5 + getal7 == getal10)
            {
                MessageBox.Show(gewonnen + " heeft gewonnen!", "Einde");
            }
            else if (gameOver == 9)
            {
                MessageBox.Show("GELIJKSPEL", "GELIJKSPEL");
            }



        }


    }
}
