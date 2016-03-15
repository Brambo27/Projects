using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20._0_of_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            // EN = 1 EN 1 : voorbeeld : 1 EN 0 = false, 1 EN 1 = true
            // OF = 1 OF 1 : voorbeeld : 1 OR 0 = true, 1 OR 1 = true, 0 OR 0 = false
            // XOF = 1 OF 1 = false, 0 OF 0 = false, 1 OF 0 = true, 0 OF 1 = true



        }


        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar1.Maximum = 50;
            progressBar2.Maximum = 50;
            if (chbInputA.Checked == true )
            {
                
                this.timer1.Start();
            }

            if (chbInputB.Checked == true)
            {
                this.timer2.Start();
            }


          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(3);
            if (progressBar1.Value == 50)
            {
                this.timer1.Stop();
                Schakeling();
           
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(3);
            if (progressBar2.Value == 50)
            {
                this.timer2.Stop();
            }

        }

        public int Schakeling()
        {
            string Aan = "C:/Users/bram/Documents/Visual Studio 2015/Projects/LICHT AAN.png";
            string Uit = "C:/Users/bram/Documents/Visual Studio 2015/Projects/LICHT UIT.png";
            Console.Write("Hello world");
            if (comboBox1.SelectedIndex == 0)
            {
                if (chbInputA.Checked == false || chbInputB.Checked == false)
                {
                    pictureBox1.Image = Image.FromFile(Uit);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(Aan);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (chbInputA.Checked == true || chbInputB.Checked == true)
                {
                    pictureBox1.Image = Image.FromFile(Aan);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(Uit);
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (chbInputA.Checked == chbInputB.Checked)
                {
                    pictureBox1.Image = Image.FromFile(Uit);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(Aan);
                }
            }

            else
            {

            }
            return(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar3.Value = 90;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar3.Value = 100;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Ding;

            Ding = (double)9 / 10;
            progressBar3.Value = 9 / 10 * 100;
            Console.Write(Ding);
        }
    }
}
