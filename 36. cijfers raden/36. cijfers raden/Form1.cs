using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36.cijfers_raden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int score = 50;

        private void button1_Click(object sender, EventArgs e)
        {
            int teller = 1, cijfer = int.Parse(textBox1.Text), teradencijfer = 2;
            int aantalpogingen = 0;

            while (teller <= 3)
            {
                if (cijfer == teradencijfer)
                {
                    aantalpogingen = teller;
                    teller = 5;
                }
                else
                {
                    if (teller == 3)
                    {
                        teller++;
                    }
                    else
                    {
                        cijfer = int.Parse(InputBox.Input.Show("voer een getal in", "invoer gevraagd", ""));
                        teller++;
                    }
                
                }
            }
            if (aantalpogingen == 1)
            {
                score += 10;
            }
            if (aantalpogingen == 2)
            {
                score += 5;
            }
            if (aantalpogingen == 3)
            {
                score += 3;
            }
            if (aantalpogingen == 0)
            {
                score -= 10;
            }
            txtScore.Text = score + "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int teller = 1, cijfer = int.Parse(textBox2.Text), teradencijfer = 5;
            int aantalpogingen = 0;

            while (teller <= 3)
            {
                if (cijfer == teradencijfer)
                {
                    aantalpogingen = teller;
                    teller = 5;
                }
                else
                {
                    if (teller == 3)
                    {
                        teller++;
                    }
                    else
                    {
                        cijfer = int.Parse(InputBox.Input.Show("voer een getal in", "invoer gevraagd", ""));
                        teller++;
                    }

                }
            }
            if (aantalpogingen == 0)
            {
                score -= 10;
            }
            if (aantalpogingen == 1)
            {
                score += 10;
            }
            if (aantalpogingen == 2)
            {
                score += 5;
            }
            if (aantalpogingen == 3)
            {
                score += 3;
            }
            txtScore.Text = score + "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int teller = 1, cijfer = int.Parse(textBox3.Text), teradencijfer = 7;
            int aantalpogingen = 0;

            while (teller <= 3)
            {
                if (cijfer == teradencijfer)
                {
                    aantalpogingen = teller;
                    teller = 5;
                }
                else
                {
                    if (teller == 3)
                    {
                        teller++;
                    }
                    else
                    {
                        cijfer = int.Parse(InputBox.Input.Show("voer een getal in", "invoer gevraagd", ""));
                        teller++;
                    }

                }
            }
            if (aantalpogingen == 0)
            {
                score -= 10;
            }
            if (aantalpogingen == 1)
            {
                score += 10;
            }
            if (aantalpogingen == 2)
            {
                score += 5;
            }
            if (aantalpogingen == 3)
            {
                score += 3;
            }
            txtScore.Text = score + "";

        }


    }
}
