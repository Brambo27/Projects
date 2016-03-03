using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52.Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int kolom, rij, pressed, kaartNummer = 1, waarde = 0 ,dealerWaarde = 0;
        int[,] kaartArray = new int[4, 13];
        bool found = false;

        private void btnStand_Click(object sender, EventArgs e)
        {
            geefKaartDealer();
            Console.Write(dealerWaarde);
            if (dealerWaarde > 21)
            {
                DialogResult result = MessageBox.Show("Je hebt gewonnen!\r\nKlik op Cansel om aftesluiten", "Gewonnen!", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                if (result == DialogResult.Retry)
                {
                    Application.Restart();
                }
            }
        }

        Random random = new Random();

        private void btnHit_Click(object sender, EventArgs e)
        {
            geefKaart();
            Console.Write(waarde);
            if (waarde > 21)
            {
                
                DialogResult result = MessageBox.Show("De waarde van de kaarten is groter dan 21!\r\nKlik op Cancel om aftesluiten", "Verloren!", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                if (result == DialogResult.Retry)
                {
                    Application.Restart();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Player cards
            geefKaart();
            geefKaart();

            //Dealer cards
            geefKaartDealer();
            geefKaartDealer();
            

            if (pressed == 0)
            {


               


                pressed++;
            }
            else
            {
                MessageBox.Show("De game is al bezig!", "Kon niet starten");
            }
        }
        public int geefKaart()
        {
            if (kaartNummer == 1)
            {
                
                for (int i = 0; found == false; i++)
                {
                    kolom = random.Next(0, 3);
                    rij = random.Next(0, 13);  

                    if (kaartArray[kolom, rij] == 0)
                    {
                        found = true;
                        kaartArray[kolom, rij] = 1;
                        
                        switch (kolom)
                        {
                            case 0:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox1.Load("/Cards/ac.gif");
                                        break;
                                    case 1:
                                        pictureBox1.Load("/Cards/2c.gif"); waarde += 2;
                                        break;
                                    case 2:
                                        pictureBox1.Load("/Cards/3c.gif"); waarde += 3;
                                        break;
                                    case 3:
                                        pictureBox1.Load("/Cards/4c.gif"); waarde += 4;
                                        break;
                                    case 4:
                                        pictureBox1.Load("/Cards/5c.gif"); waarde += 5;
                                        break;
                                    case 5:
                                        pictureBox1.Load("/Cards/6c.gif"); waarde += 6;
                                        break;
                                    case 6:
                                        pictureBox1.Load("/Cards/7c.gif"); waarde += 7;
                                        break;
                                    case 7:
                                        pictureBox1.Load("/Cards/8c.gif"); waarde += 8;
                                        break;
                                    case 8:
                                        pictureBox1.Load("/Cards/9c.gif"); waarde += 9;
                                        break;
                                    case 9:
                                        pictureBox1.Load("/Cards/10c.gif"); waarde += 10;
                                        break;
                                    case 10:
                                        pictureBox1.Load("/Cards/jc.gif"); waarde += 10;
                                        break;
                                    case 11:
                                        pictureBox1.Load("/Cards/qc.gif"); waarde += 10;
                                        break;
                                    case 12:
                                        pictureBox1.Load("/Cards/kc.gif"); waarde += 10;
                                        break;

                                }
                                break;
                            case 1:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox1.Load("/Cards/ad.gif");
                                        break;
                                    case 1:
                                        pictureBox1.Load("/Cards/2d.gif"); waarde += 2;
                                        break;
                                    case 2:
                                        pictureBox1.Load("/Cards/3d.gif"); waarde += 3;
                                        break;
                                    case 3:
                                        pictureBox1.Load("/Cards/4d.gif"); waarde += 4;
                                        break;
                                    case 4:
                                        pictureBox1.Load("/Cards/5d.gif"); waarde += 5;
                                        break;
                                    case 5:
                                        pictureBox1.Load("/Cards/6d.gif"); waarde += 6;
                                        break;
                                    case 6:
                                        pictureBox1.Load("/Cards/7d.gif"); waarde += 7;
                                        break;
                                    case 7:
                                        pictureBox1.Load("/Cards/8d.gif"); waarde += 8;
                                        break;
                                    case 8:
                                        pictureBox1.Load("/Cards/9d.gif"); waarde += 9;
                                        break;
                                    case 9:
                                        pictureBox1.Load("/Cards/10d.gif"); waarde += 10;
                                        break;
                                    case 10:
                                        pictureBox1.Load("/Cards/jd.gif"); waarde += 10;
                                        break;
                                    case 11:
                                        pictureBox1.Load("/Cards/qd.gif"); waarde += 10;
                                        break;
                                    case 12:
                                        pictureBox1.Load("/Cards/kd.gif"); waarde += 10;
                                        break;

                                }
                                break;
                            case 2:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox1.Load("/Cards/ah.gif");
                                        break;
                                    case 1:
                                        pictureBox1.Load("/Cards/2h.gif"); waarde += 2;
                                        break;
                                    case 2:
                                        pictureBox1.Load("/Cards/3h.gif"); waarde += 3;
                                        break;
                                    case 3:
                                        pictureBox1.Load("/Cards/4h.gif"); waarde += 4;
                                        break;
                                    case 4:
                                        pictureBox1.Load("/Cards/5h.gif"); waarde += 5;
                                        break;
                                    case 5:
                                        pictureBox1.Load("/Cards/6h.gif"); waarde += 6;
                                        break;
                                    case 6:
                                        pictureBox1.Load("/Cards/7h.gif"); waarde += 7;
                                        break;
                                    case 7:
                                        pictureBox1.Load("/Cards/8h.gif"); waarde += 8;
                                        break;
                                    case 8:
                                        pictureBox1.Load("/Cards/9h.gif"); waarde += 9;
                                        break;
                                    case 9:
                                        pictureBox1.Load("/Cards/10h.gif"); waarde += 10;
                                        break;
                                    case 10:
                                        pictureBox1.Load("/Cards/jh.gif"); waarde += 10;
                                        break;
                                    case 11:
                                        pictureBox1.Load("/Cards/qh.gif"); waarde += 10;
                                        break;
                                    case 12:
                                        pictureBox1.Load("/Cards/kh.gif"); waarde += 10;
                                        break;

                                }
                                break;
                            case 3:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox1.Load("/Cards/as.gif");
                                        break;
                                    case 1:
                                        pictureBox1.Load("/Cards/2s.gif"); waarde += 2;
                                        break;
                                    case 2:
                                        pictureBox1.Load("/Cards/3s.gif"); waarde += 3;
                                        break;
                                    case 3:
                                        pictureBox1.Load("/Cards/4s.gif"); waarde += 4;
                                        break;
                                    case 4:
                                        pictureBox1.Load("/Cards/5s.gif"); waarde += 5;
                                        break;
                                    case 5:
                                        pictureBox1.Load("/Cards/6s.gif"); waarde += 6;
                                        break;
                                    case 6:
                                        pictureBox1.Load("/Cards/7s.gif"); waarde += 7;
                                        break;
                                    case 7:
                                        pictureBox1.Load("/Cards/8s.gif"); waarde += 8;
                                        break;
                                    case 8:
                                        pictureBox1.Load("/Cards/9s.gif"); waarde += 9;
                                        break;
                                    case 9:
                                        pictureBox1.Load("/Cards/10s.gif"); waarde += 10;
                                        break;
                                    case 10:
                                        pictureBox1.Load("/Cards/js.gif"); waarde += 10;
                                        break;
                                    case 11:
                                        pictureBox1.Load("/Cards/qs.gif"); waarde += 10;
                                        break;
                                    case 12:
                                        pictureBox1.Load("/Cards/ks.gif"); waarde += 10;
                                        break;

                                }
                                break;
                        }
                    }
                }
                found = false;
                
            }
            if (kaartNummer == 2)
            {
                
                for (int i = 0; found == false; i++)
                {
                    kolom = random.Next(0, 3);
                    rij = random.Next(0, 13); 
                    if (kaartArray[kolom, rij] == 0)
                    {
                        found = true;
                        kaartArray[kolom, rij] = 1;
                        
                        switch (kolom)
                        {
                            case 0:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox2.Load("/Cards/ac.gif");
                                        break;
                                    case 1:
                                        pictureBox2.Load("/Cards/2c.gif"); waarde += 2;
                                        break;
                                    case 2:
                                        pictureBox2.Load("/Cards/3c.gif"); waarde += 3;
                                        break;
                                    case 3:
                                        pictureBox2.Load("/Cards/4c.gif"); waarde += 4;
                                        break;
                                    case 4:
                                        pictureBox2.Load("/Cards/5c.gif"); waarde += 5;
                                        break;
                                    case 5:
                                        pictureBox2.Load("/Cards/6c.gif"); waarde += 6;
                                        break;
                                    case 6:
                                        pictureBox2.Load("/Cards/7c.gif"); waarde += 7; 
                                        break;
                                    case 7:
                                        pictureBox2.Load("/Cards/8c.gif"); waarde += 8; 
                                        break;
                                    case 8:
                                        pictureBox2.Load("/Cards/9c.gif"); waarde += 9;
                                        break;
                                    case 9:
                                        pictureBox2.Load("/Cards/10c.gif"); waarde += 10; 
                                        break;
                                    case 10:
                                        pictureBox2.Load("/Cards/jc.gif"); waarde += 10;
                                        break;
                                    case 11:
                                        pictureBox2.Load("/Cards/qc.gif"); waarde += 10;
                                        break;
                                    case 12:
                                        pictureBox2.Load("/Cards/kc.gif"); waarde += 10;
                                        break;

                                }
                                break;
                            case 1:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox2.Load("/Cards/ad.gif");
                                        break;
                                    case 1:
                                        pictureBox2.Load("/Cards/2d.gif"); waarde += 2;
                                        break;
                                    case 2:
                                        pictureBox2.Load("/Cards/3d.gif"); waarde += 3;
                                        break;
                                    case 3:
                                        pictureBox2.Load("/Cards/4d.gif"); waarde += 4;
                                        break;
                                    case 4:
                                        pictureBox2.Load("/Cards/5d.gif"); waarde += 5;
                                        break;
                                    case 5:
                                        pictureBox2.Load("/Cards/6d.gif"); waarde += 6;
                                        break;
                                    case 6:
                                        pictureBox2.Load("/Cards/7d.gif"); waarde += 7;
                                        break;
                                    case 7:
                                        pictureBox2.Load("/Cards/8d.gif"); waarde += 8;
                                        break;
                                    case 8:
                                        pictureBox2.Load("/Cards/9d.gif"); waarde += 9;
                                        break;
                                    case 9:
                                        pictureBox2.Load("/Cards/10d.gif"); waarde += 10;
                                        break;
                                    case 10:
                                        pictureBox2.Load("/Cards/jd.gif"); waarde += 10;
                                        break;
                                    case 11:
                                        pictureBox2.Load("/Cards/qd.gif"); waarde += 10;
                                        break;
                                    case 12:
                                        pictureBox2.Load("/Cards/kd.gif"); waarde += 10;
                                        break;

                                }
                                break;
                            case 2:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox2.Load("/Cards/ah.gif");
                                        break;
                                    case 1:
                                        pictureBox2.Load("/Cards/2h.gif"); waarde += 2;
                                        break;
                                    case 2:
                                        pictureBox2.Load("/Cards/3h.gif"); waarde += 3;
                                        break;
                                    case 3:
                                        pictureBox2.Load("/Cards/4h.gif"); waarde += 4;
                                        break;
                                    case 4:
                                        pictureBox2.Load("/Cards/5h.gif"); waarde += 5;
                                        break;
                                    case 5:
                                        pictureBox2.Load("/Cards/6h.gif"); waarde += 6;
                                        break;
                                    case 6:
                                        pictureBox2.Load("/Cards/7h.gif"); waarde += 7;
                                        break;
                                    case 7:
                                        pictureBox2.Load("/Cards/8h.gif"); waarde += 8;
                                        break;
                                    case 8:
                                        pictureBox2.Load("/Cards/9h.gif"); waarde += 9;
                                        break;
                                    case 9:
                                        pictureBox2.Load("/Cards/10h.gif"); waarde += 10;
                                        break;
                                    case 10:
                                        pictureBox2.Load("/Cards/jh.gif"); waarde += 10;
                                        break;
                                    case 11:
                                        pictureBox2.Load("/Cards/qh.gif"); waarde += 10;
                                        break;
                                    case 12:
                                        pictureBox2.Load("/Cards/kh.gif"); waarde += 10;
                                        break;

                                }
                                break;
                            case 3:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox2.Load("/Cards/as.gif");
                                        break;
                                    case 1:
                                        pictureBox2.Load("/Cards/2s.gif"); waarde += 2;
                                        break;
                                    case 2:
                                        pictureBox2.Load("/Cards/3s.gif");
                                        break;
                                    case 3:
                                        pictureBox2.Load("/Cards/4s.gif"); waarde += 4;
                                        break;
                                    case 4:
                                        pictureBox2.Load("/Cards/5s.gif"); waarde += 5;
                                        break;
                                    case 5:
                                        pictureBox2.Load("/Cards/6s.gif"); waarde += 6;
                                        break;
                                    case 6:
                                        pictureBox2.Load("/Cards/7s.gif"); waarde += 7;
                                        break;
                                    case 7:
                                        pictureBox2.Load("/Cards/8s.gif"); waarde += 8;
                                        break;
                                    case 8:
                                        pictureBox2.Load("/Cards/9s.gif"); waarde += 9;
                                        break;
                                    case 9:
                                        pictureBox2.Load("/Cards/10s.gif"); waarde += 10;
                                        break;
                                    case 10:
                                        pictureBox2.Load("/Cards/js.gif"); waarde += 10;
                                        break;
                                    case 11:
                                        pictureBox2.Load("/Cards/qs.gif"); waarde += 10;
                                        break;
                                    case 12:
                                        pictureBox2.Load("/Cards/ks.gif"); waarde += 10;
                                        break;

                                }
                                break;
                        }
                    }
                }
                found = false;
            }
                if (kaartNummer == 5)
                {
                    for (int i = 0; found == false; i++)
                    {
                        kolom = random.Next(0, 3);
                        rij = random.Next(0, 13);

                        if (kaartArray[kolom, rij] == 0)
                        {
                            found = true;
                            kaartArray[kolom, rij] = 1;

                            switch (kolom)
                            {
                                case 0:
                                    switch (rij)
                                    {
                                        case 0:
                                            pictureBox5.Load("/Cards/ac.gif");
                                            break;
                                        case 1:
                                            pictureBox5.Load("/Cards/2c.gif"); waarde += 2;
                                            break;
                                        case 2:
                                            pictureBox5.Load("/Cards/3c.gif"); waarde += 3;
                                            break;
                                        case 3:
                                            pictureBox5.Load("/Cards/4c.gif"); waarde += 4;
                                            break;
                                        case 4:
                                            pictureBox5.Load("/Cards/5c.gif"); waarde += 5;
                                            break;
                                        case 5:
                                            pictureBox5.Load("/Cards/6c.gif"); waarde += 6;
                                            break;
                                        case 6:
                                            pictureBox5.Load("/Cards/7c.gif"); waarde += 7;
                                            break;
                                        case 7:
                                            pictureBox5.Load("/Cards/8c.gif"); waarde += 8;
                                            break;
                                        case 8:
                                            pictureBox5.Load("/Cards/9c.gif"); waarde += 9;
                                            break;
                                        case 9:
                                            pictureBox5.Load("/Cards/10c.gif"); waarde += 10;
                                            break;
                                        case 10:
                                            pictureBox5.Load("/Cards/jc.gif"); waarde += 10; 
                                            break;
                                        case 11:
                                            pictureBox5.Load("/Cards/qc.gif"); waarde += 10;
                                            break;
                                        case 12:
                                            pictureBox5.Load("/Cards/kc.gif"); waarde += 10;
                                            break;

                                    }
                                    break;
                                case 1:
                                    switch (rij)
                                    {
                                        case 0:
                                            pictureBox5.Load("/Cards/ad.gif");
                                            break;
                                        case 1:
                                            pictureBox5.Load("/Cards/2d.gif"); waarde += 2;
                                            break;
                                        case 2:
                                            pictureBox5.Load("/Cards/3d.gif"); waarde += 3;
                                            break;
                                        case 3:
                                            pictureBox5.Load("/Cards/4d.gif"); waarde += 4;
                                            break;
                                        case 4:
                                            pictureBox5.Load("/Cards/5d.gif"); waarde += 5;
                                            break;
                                        case 5:
                                            pictureBox5.Load("/Cards/6d.gif"); waarde += 6;
                                            break;
                                        case 6:
                                            pictureBox5.Load("/Cards/7d.gif"); waarde += 7;
                                            break;
                                        case 7:
                                            pictureBox5.Load("/Cards/8d.gif"); waarde += 8;
                                            break;
                                        case 8:
                                            pictureBox5.Load("/Cards/9d.gif"); waarde += 9;
                                            break;
                                        case 9:
                                            pictureBox5.Load("/Cards/10d.gif"); waarde += 10;
                                            break;
                                        case 10:
                                            pictureBox5.Load("/Cards/jd.gif"); waarde += 10;
                                            break;
                                        case 11:
                                            pictureBox5.Load("/Cards/qd.gif"); waarde += 10;
                                            break;
                                        case 12:
                                            pictureBox5.Load("/Cards/kd.gif"); waarde += 10;
                                            break;

                                    }
                                    break;
                                case 2:
                                    switch (rij)
                                    {
                                        case 0:
                                            pictureBox5.Load("/Cards/ah.gif");
                                            break;
                                        case 1:
                                            pictureBox5.Load("/Cards/2h.gif"); waarde += 2;
                                            break;
                                        case 2:
                                            pictureBox5.Load("/Cards/3h.gif"); waarde += 3;
                                            break;
                                        case 3:
                                            pictureBox5.Load("/Cards/4h.gif"); waarde += 4;
                                            break;
                                        case 4:
                                            pictureBox5.Load("/Cards/5h.gif"); waarde += 5;
                                            break;
                                        case 5:
                                            pictureBox5.Load("/Cards/6h.gif"); waarde += 6;
                                            break;
                                        case 6:
                                            pictureBox5.Load("/Cards/7h.gif"); waarde += 7;
                                            break;
                                        case 7:
                                            pictureBox5.Load("/Cards/8h.gif"); waarde += 8;
                                            break;
                                        case 8:
                                            pictureBox5.Load("/Cards/9h.gif"); waarde += 9;
                                            break;
                                        case 9:
                                            pictureBox5.Load("/Cards/10h.gif"); waarde += 10;
                                            break;
                                        case 10:
                                            pictureBox5.Load("/Cards/jh.gif"); waarde += 10;
                                            break;
                                        case 11:
                                            pictureBox5.Load("/Cards/qh.gif"); waarde += 10;
                                            break;
                                        case 12:
                                            pictureBox5.Load("/Cards/kh.gif"); waarde += 10;
                                            break;

                                    }
                                    break;
                                case 3:
                                    switch (rij)
                                    {
                                        case 0:
                                            pictureBox5.Load("/Cards/as.gif");
                                            break;
                                        case 1:
                                            pictureBox5.Load("/Cards/2s.gif"); waarde += 2;
                                            break;
                                        case 2:
                                            pictureBox5.Load("/Cards/3s.gif"); waarde += 3;
                                            break;
                                        case 3:
                                            pictureBox5.Load("/Cards/4s.gif"); waarde += 4;
                                            break;
                                        case 4:
                                            pictureBox5.Load("/Cards/5s.gif"); waarde += 5;
                                            break;
                                        case 5:
                                            pictureBox5.Load("/Cards/6s.gif"); waarde += 6;
                                            break;
                                        case 6:
                                            pictureBox5.Load("/Cards/7s.gif"); waarde += 7;
                                            break;
                                        case 7:
                                            pictureBox5.Load("/Cards/8s.gif"); waarde += 8;
                                            break;
                                        case 8:
                                            pictureBox5.Load("/Cards/9s.gif"); waarde += 9;
                                            break;
                                        case 9:
                                            pictureBox5.Load("/Cards/10s.gif"); waarde += 10;
                                            break;
                                        case 10:
                                            pictureBox5.Load("/Cards/js.gif"); waarde += 10;
                                            break;
                                        case 11:
                                            pictureBox5.Load("/Cards/qs.gif"); waarde += 10;
                                            break;
                                        case 12:
                                            pictureBox5.Load("/Cards/ks.gif"); waarde += 10;
                                            break;

                                    }
                                    break;
                            }
                        }
                    }
                    found = false;

                }
            
            if (kaartNummer == 4)
            {

            }
            kaartNummer++;
            return (0);
        }
        public int geefKaartDealer()
        {
            if (kaartNummer == 3) {
                for (int i = 0; found == false; i++)
                {
                    kolom = random.Next(0, 3);
                    rij = random.Next(0, 13);

                    if (kaartArray[kolom, rij] == 0)
                    {
                        found = true;
                        kaartArray[kolom, rij] = 1;

                        switch (kolom)
                        {
                            case 0:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox3.Load("/Cards/ac.gif");
                                        break;
                                    case 1:
                                        pictureBox3.Load("/Cards/2c.gif"); dealerWaarde += 2;
                                        break;
                                    case 2:
                                        pictureBox3.Load("/Cards/3c.gif"); dealerWaarde += 3;
                                        break;
                                    case 3:
                                        pictureBox3.Load("/Cards/4c.gif"); dealerWaarde += 4;
                                        break;
                                    case 4:
                                        pictureBox3.Load("/Cards/5c.gif"); dealerWaarde += 5;
                                        break;
                                    case 5:
                                        pictureBox3.Load("/Cards/6c.gif"); dealerWaarde += 6;
                                        break;
                                    case 6:
                                        pictureBox3.Load("/Cards/7c.gif"); dealerWaarde += 7;
                                        break;
                                    case 7:
                                        pictureBox3.Load("/Cards/8c.gif"); dealerWaarde += 8;
                                        break;
                                    case 8:
                                        pictureBox3.Load("/Cards/9c.gif"); dealerWaarde += 9;
                                        break;
                                    case 9:
                                        pictureBox3.Load("/Cards/10c.gif"); dealerWaarde += 10;
                                        break;
                                    case 10:
                                        pictureBox3.Load("/Cards/jc.gif"); dealerWaarde += 10;
                                        break;
                                    case 11:
                                        pictureBox3.Load("/Cards/qc.gif"); dealerWaarde += 10;
                                        break;
                                    case 12:
                                        pictureBox3.Load("/Cards/kc.gif"); dealerWaarde += 10;
                                        break;

                                }
                                break;
                            case 1:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox3.Load("/Cards/ad.gif");
                                        break;
                                    case 1:
                                        pictureBox3.Load("/Cards/2d.gif"); dealerWaarde += 2;
                                        break;
                                    case 2:
                                        pictureBox3.Load("/Cards/3d.gif"); dealerWaarde += 3;
                                        break;
                                    case 3:
                                        pictureBox3.Load("/Cards/4d.gif"); dealerWaarde += 4;
                                        break;
                                    case 4:
                                        pictureBox3.Load("/Cards/5d.gif"); dealerWaarde += 5;
                                        break;
                                    case 5:
                                        pictureBox3.Load("/Cards/6d.gif"); dealerWaarde += 6;
                                        break;
                                    case 6:
                                        pictureBox3.Load("/Cards/7d.gif"); dealerWaarde += 7;
                                        break;
                                    case 7:
                                        pictureBox3.Load("/Cards/8d.gif"); dealerWaarde += 8;
                                        break;
                                    case 8:
                                        pictureBox3.Load("/Cards/9d.gif"); dealerWaarde += 9;
                                        break;
                                    case 9:
                                        pictureBox3.Load("/Cards/10d.gif"); dealerWaarde += 10;
                                        break;
                                    case 10:
                                        pictureBox3.Load("/Cards/jd.gif"); dealerWaarde += 10;
                                        break;
                                    case 11:
                                        pictureBox3.Load("/Cards/qd.gif"); dealerWaarde += 10;
                                        break;
                                    case 12:
                                        pictureBox3.Load("/Cards/kd.gif"); dealerWaarde += 10;
                                        break;

                                }
                                break;
                            case 2:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox3.Load("/Cards/ah.gif");
                                        break;
                                    case 1:
                                        pictureBox3.Load("/Cards/2h.gif"); dealerWaarde += 2;
                                        break;
                                    case 2:
                                        pictureBox3.Load("/Cards/3h.gif"); dealerWaarde += 3;
                                        break;
                                    case 3:
                                        pictureBox3.Load("/Cards/4h.gif"); dealerWaarde += 4;
                                        break;
                                    case 4:
                                        pictureBox3.Load("/Cards/5h.gif"); dealerWaarde += 5;
                                        break;
                                    case 5:
                                        pictureBox3.Load("/Cards/6h.gif"); dealerWaarde += 6;
                                        break;
                                    case 6:
                                        pictureBox3.Load("/Cards/7h.gif"); dealerWaarde += 7;
                                        break;
                                    case 7:
                                        pictureBox3.Load("/Cards/8h.gif"); dealerWaarde += 8;
                                        break;
                                    case 8:
                                        pictureBox3.Load("/Cards/9h.gif"); dealerWaarde += 9;
                                        break;
                                    case 9:
                                        pictureBox3.Load("/Cards/10h.gif"); dealerWaarde += 10;
                                        break;
                                    case 10:
                                        pictureBox3.Load("/Cards/jh.gif"); dealerWaarde += 10;
                                        break;
                                    case 11:
                                        pictureBox3.Load("/Cards/qh.gif"); dealerWaarde += 10;
                                        break;
                                    case 12:
                                        pictureBox3.Load("/Cards/kh.gif"); dealerWaarde += 10;
                                        break;

                                }
                                break;
                            case 3:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox3.Load("/Cards/as.gif");
                                        break;
                                    case 1:
                                        pictureBox3.Load("/Cards/2s.gif"); dealerWaarde += 2;
                                        break;
                                    case 2:
                                        pictureBox3.Load("/Cards/3s.gif"); dealerWaarde += 3;
                                        break;
                                    case 3:
                                        pictureBox3.Load("/Cards/4s.gif"); dealerWaarde += 4;
                                        break;
                                    case 4:
                                        pictureBox3.Load("/Cards/5s.gif"); dealerWaarde += 5;
                                        break;
                                    case 5:
                                        pictureBox3.Load("/Cards/6s.gif"); dealerWaarde += 6;
                                        break;
                                    case 6:
                                        pictureBox3.Load("/Cards/7s.gif"); dealerWaarde += 7;
                                        break;
                                    case 7:
                                        pictureBox3.Load("/Cards/8s.gif"); dealerWaarde += 8;
                                        break;
                                    case 8:
                                        pictureBox3.Load("/Cards/9s.gif"); dealerWaarde += 9;
                                        break;
                                    case 9:
                                        pictureBox3.Load("/Cards/10s.gif"); dealerWaarde += 10;
                                        break;
                                    case 10:
                                        pictureBox3.Load("/Cards/js.gif"); dealerWaarde += 10;
                                        break;
                                    case 11:
                                        pictureBox3.Load("/Cards/qs.gif"); dealerWaarde += 10;
                                        break;
                                    case 12:
                                        pictureBox3.Load("/Cards/ks.gif"); dealerWaarde += 10;
                                        break;

                                }
                                break;
                        }
                    }
                }
                found = false;
                
            }
            if (kaartNummer == 4)
            {
                for (int i = 0; found == false; i++)
                {
                    kolom = random.Next(0, 3);
                    rij = random.Next(0, 13);

                    if (kaartArray[kolom, rij] == 0)
                    {
                        found = true;
                        kaartArray[kolom, rij] = 1;

                        switch (kolom)
                        {
                            case 0:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox4.Load("/Cards/ac.gif");
                                        break;
                                    case 1:
                                        pictureBox4.Load("/Cards/2c.gif"); dealerWaarde += 2;
                                        break;
                                    case 2:
                                        pictureBox4.Load("/Cards/3c.gif"); dealerWaarde += 3;
                                        break;
                                    case 3:
                                        pictureBox4.Load("/Cards/4c.gif"); dealerWaarde += 4;
                                        break;
                                    case 4:
                                        pictureBox4.Load("/Cards/5c.gif"); dealerWaarde += 5;
                                        break;
                                    case 5:
                                        pictureBox4.Load("/Cards/6c.gif"); dealerWaarde += 6;
                                        break;
                                    case 6:
                                        pictureBox4.Load("/Cards/7c.gif"); dealerWaarde += 7;
                                        break;
                                    case 7:
                                        pictureBox4.Load("/Cards/8c.gif"); dealerWaarde += 8;
                                        break;
                                    case 8:
                                        pictureBox4.Load("/Cards/9c.gif"); dealerWaarde += 9;
                                        break;
                                    case 9:
                                        pictureBox4.Load("/Cards/10c.gif"); dealerWaarde += 10;
                                        break;
                                    case 10:
                                        pictureBox4.Load("/Cards/jc.gif"); dealerWaarde += 10;
                                        break;
                                    case 11:
                                        pictureBox4.Load("/Cards/qc.gif"); dealerWaarde += 10;
                                        break;
                                    case 12:
                                        pictureBox4.Load("/Cards/kc.gif"); dealerWaarde += 10;
                                        break;

                                }
                                break;
                            case 1:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox4.Load("/Cards/ad.gif");
                                        break;
                                    case 1:
                                        pictureBox4.Load("/Cards/2d.gif"); dealerWaarde += 2;
                                        break;
                                    case 2:
                                        pictureBox4.Load("/Cards/3d.gif"); dealerWaarde += 3;
                                        break;
                                    case 3:
                                        pictureBox4.Load("/Cards/4d.gif"); dealerWaarde += 4;
                                        break;
                                    case 4:
                                        pictureBox4.Load("/Cards/5d.gif"); dealerWaarde += 5;
                                        break;
                                    case 5:
                                        pictureBox4.Load("/Cards/6d.gif"); dealerWaarde += 6;
                                        break;
                                    case 6:
                                        pictureBox4.Load("/Cards/7d.gif"); dealerWaarde += 7;
                                        break;
                                    case 7:
                                        pictureBox4.Load("/Cards/8d.gif"); dealerWaarde += 8;
                                        break;
                                    case 8:
                                        pictureBox4.Load("/Cards/9d.gif"); dealerWaarde += 9;
                                        break;
                                    case 9:
                                        pictureBox4.Load("/Cards/10d.gif"); dealerWaarde += 10;
                                        break;
                                    case 10:
                                        pictureBox4.Load("/Cards/jd.gif"); dealerWaarde += 10;
                                        break;
                                    case 11:
                                        pictureBox4.Load("/Cards/qd.gif"); dealerWaarde += 10;
                                        break;
                                    case 12:
                                        pictureBox4.Load("/Cards/kd.gif"); dealerWaarde += 10;
                                        break;

                                }
                                break;
                            case 2:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox4.Load("/Cards/ah.gif");
                                        break;
                                    case 1:
                                        pictureBox4.Load("/Cards/2h.gif"); dealerWaarde += 2;
                                        break;
                                    case 2:
                                        pictureBox4.Load("/Cards/3h.gif"); dealerWaarde += 3;
                                        break;
                                    case 3:
                                        pictureBox4.Load("/Cards/4h.gif"); dealerWaarde += 4;
                                        break;
                                    case 4:
                                        pictureBox4.Load("/Cards/5h.gif"); dealerWaarde += 5;
                                        break;
                                    case 5:
                                        pictureBox4.Load("/Cards/6h.gif"); dealerWaarde += 6;
                                        break;
                                    case 6:
                                        pictureBox4.Load("/Cards/7h.gif"); dealerWaarde += 7;
                                        break;
                                    case 7:
                                        pictureBox4.Load("/Cards/8h.gif"); dealerWaarde += 8;
                                        break;
                                    case 8:
                                        pictureBox4.Load("/Cards/9h.gif"); dealerWaarde += 9;
                                        break;
                                    case 9:
                                        pictureBox4.Load("/Cards/10h.gif"); dealerWaarde += 10;
                                        break;
                                    case 10:
                                        pictureBox4.Load("/Cards/jh.gif"); dealerWaarde += 10;
                                        break;
                                    case 11:
                                        pictureBox4.Load("/Cards/qh.gif"); dealerWaarde += 10;
                                        break;
                                    case 12:
                                        pictureBox4.Load("/Cards/kh.gif"); dealerWaarde += 10;
                                        break;

                                }
                                break;
                            case 3:
                                switch (rij)
                                {
                                    case 0:
                                        pictureBox4.Load("/Cards/as.gif");
                                        break;
                                    case 1:
                                        pictureBox4.Load("/Cards/2s.gif"); dealerWaarde += 2;
                                        break;
                                    case 2:
                                        pictureBox4.Load("/Cards/3s.gif"); dealerWaarde += 3;
                                        break;
                                    case 3:
                                        pictureBox4.Load("/Cards/4s.gif"); dealerWaarde += 4;
                                        break;
                                    case 4:
                                        pictureBox4.Load("/Cards/5s.gif"); dealerWaarde += 5;
                                        break;
                                    case 5:
                                        pictureBox4.Load("/Cards/6s.gif"); dealerWaarde += 6;
                                        break;
                                    case 6:
                                        pictureBox4.Load("/Cards/7s.gif"); dealerWaarde += 7;
                                        break;
                                    case 7:
                                        pictureBox4.Load("/Cards/8s.gif"); dealerWaarde += 8;
                                        break;
                                    case 8:
                                        pictureBox4.Load("/Cards/9s.gif"); dealerWaarde += 9;
                                        break;
                                    case 9:
                                        pictureBox4.Load("/Cards/10s.gif"); dealerWaarde += 10;
                                        break;
                                    case 10:
                                        pictureBox4.Load("/Cards/js.gif"); dealerWaarde += 10;
                                        break;
                                    case 11:
                                        pictureBox4.Load("/Cards/qs.gif"); dealerWaarde += 10;
                                        break;
                                    case 12:
                                        pictureBox4.Load("/Cards/ks.gif"); dealerWaarde += 10;
                                        break;

                                }
                                break;
                        }
                    }
                }
                found = false;

            }
            kaartNummer++;
            return (0);
        }
        
    }
}
