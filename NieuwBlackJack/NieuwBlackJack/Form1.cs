using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NieuwBlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool speler, bank;
        int kolom, rij, xGame = 12, xBank = 12, puntenSpeler, puntenBank, uitDeLoop = 0;
        string waarde, soort;
        System.Media.SoundPlayer win = new System.Media.SoundPlayer(@"e:\HOERAAAAAAA.wav");
        System.Media.SoundPlayer loss = new System.Media.SoundPlayer(@"e:\Aww_Sound_Effect.wav");

        int[,] kaartArray = new int[4, 14];
        Random r = new Random();
        


        void spelSchudden()
        {
            //Vullen van de rij met 1en
            for (int i = 0; i <= 3; i++)
            {
                for (int x = 0; x <= 13; x++)
                {
                    kaartArray[i, x] = 1;
                }
            }
        }

        void geefKaart(bool speler, bool bank)
        {
            //Random een kaart
            do
            {
                rij = r.Next(0, 4);
                kolom = r.Next(1, 14);
            }
            while (kaartArray[rij, kolom] == 0);
            kaartArray[rij, kolom] = 0;
            switch (rij)
            {
                case 0:
                    soort = "s";
                    break;
                case 1:
                    soort = "c";
                    break;
                case 2:
                    soort = "d";
                    break;
                case 3:
                    soort = "h";
                    break;
            }
            switch (kolom)
            {
                case 1:
                    waarde = "a";
                    break;
                case 2:
                    waarde = kolom + "";
                    break;
                case 3:
                    waarde = kolom + "";
                    break;
                case 4:
                    waarde = kolom + "";
                    break;
                case 5:
                    waarde = kolom + "";
                    break;
                case 6:
                    waarde = kolom + "";
                    break;
                case 7:
                    waarde = kolom + "";
                    break;
                case 8:
                    waarde = kolom + "";
                    break;
                case 9:
                    waarde = kolom + "";
                    break;
                case 10:
                    waarde = kolom + "";
                    break;
                case 11:
                    waarde = "j";
                    break;
                case 12:
                    waarde = "q";
                    break;
                case 13:
                    waarde = "k";
                    break;
            }
            
            if (speler == true)
            {

                Image img = Image.FromFile("C:/cards/" + waarde + soort + ".gif");
                PictureBox kaart = new PictureBox();
                kaart.Parent = this;
                kaart.Size = new Size(100, 75);
                kaart.Location = new Point(xGame, 50);
                kaart.SizeMode = PictureBoxSizeMode.AutoSize;
                kaart.Image = img;
                xGame += 75;

                switch (kolom)
                {
                    case 11:
                        puntenSpeler += 10;
                        break;
                    case 12:
                        puntenSpeler += 10;
                        break;
                    case 13:
                        puntenSpeler += 10;
                        break;
                    default:
                        puntenSpeler += kolom;
                        break;
                }
            }
            if (bank == true)
            {
                Image img = Image.FromFile("C:/cards/" + waarde + soort + ".gif");
                PictureBox kaart = new PictureBox();
                kaart.Parent = this;
                kaart.Size = new Size(100, 75);
                kaart.Location = new Point(xBank, 200);
                kaart.SizeMode = PictureBoxSizeMode.AutoSize;
                kaart.Image = img;
                xBank += 75;

                switch (kolom)
                {
                    case 11: puntenBank += 10;
                        break;
                    case 12: puntenBank += 10;
                        break;
                    case 13: puntenBank += 10;
                        break;
                    default: puntenBank += kolom;
                        break;
                }
                
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            spelSchudden();
            
            geefKaart(true, false);
            geefKaart(true, false);
            

            geefKaart(false, true);
            label2.Text = puntenSpeler + "";
            label3.Text = puntenBank + "";
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            geefKaart(true, false);

            
            label2.Text = puntenSpeler + "";
            
            if (puntenSpeler > 21)
            {
                loss.Play();
                DialogResult result = MessageBox.Show("De waarde van de kaarten is groter dan 21!\r\nKlik op Cancel om aftesluiten", "Verloren!", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                if (result == DialogResult.Retry)
                {
                    btnRestart.PerformClick();
                }
                
            }
            if (puntenSpeler == 21)
            {
                
                win.Play();
                DialogResult result = MessageBox.Show("Je hebt 21, je hebt gewonnen!\r\nKlik op anuleren om aftesluiten", "Gewonnen!", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                if (result == DialogResult.Retry)
                {
                    btnRestart.PerformClick();

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uitDeLoop = 0;

            Console.Write(uitDeLoop);
            do              
                {


                    geefKaart(false, true);
                    label3.Text = puntenBank + "";


                    if (puntenBank > 21)
                    {
                        win.Play();
                        DialogResult result = MessageBox.Show("Je hebt gewonnen!\r\nKlik op anuleren om aftesluiten", "Gewonnen!", MessageBoxButtons.RetryCancel);
                        if (result == DialogResult.Cancel)
                        {
                            Application.Exit();
                        }
                        if (result == DialogResult.Retry)
                        {
                            btnRestart.PerformClick();

                        }
                    uitDeLoop = 1;
                    }
                    if (puntenBank == 21)
                    {
                    loss.Play();
                    DialogResult result = MessageBox.Show("De bank heeft 21!\r\nKlik op Cancel om aftesluiten", "Verloren!", MessageBoxButtons.RetryCancel);
                        if (result == DialogResult.Cancel)
                        {
                            Application.Exit();
                        }
                        if (result == DialogResult.Retry)
                        {
                            btnRestart.PerformClick();
                        }
                    uitDeLoop = 1;
                    }
                    if (puntenBank > puntenSpeler)
                    {
                    loss.Play();
                    DialogResult result = MessageBox.Show("De Bank heeft meer punten!\r\nKlik op Cancel om aftesluiten", "Verloren!", MessageBoxButtons.RetryCancel);
                        if (result == DialogResult.Cancel)
                        {
                            Application.Exit();
                        }
                        if (result == DialogResult.Retry)
                        {
                            btnRestart.PerformClick();
                        }
                    uitDeLoop = 1;
                    }
                }
            while (uitDeLoop == 0);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            for (int ix = this.Controls.Count - 1; ix >= 0; ix--)
                if (this.Controls[ix] is PictureBox) this.Controls[ix].Dispose();
            xBank = 12;
            xGame = 12;
            button1.Enabled = true;
            puntenBank = 0;
            puntenSpeler = 0;
            label2.Text = puntenSpeler + "";
            label3.Text = puntenBank + "";
            

        }

    }
}
