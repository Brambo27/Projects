using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42.beoordeling_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                
                int som = 0;
                for (int input = int.Parse(txtGetallen1.Text); input > 0; input--)
                {

                    som = som + input;
                }
                txtGetallen2.Text = som + "";
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Dit getal is te groot", "OverflowException Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Vul een geldig getal in!", "FormatException Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                int getal = int.Parse(txtPriem.Text);

                if (Priem(getal) == 0)
                {
                    MessageBox.Show("Dit getal is geen priem getal", "Priem");
                }
                else
                {
                    MessageBox.Show("Dit is een priem getal", "Priem");
                }
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Dit getal is te groot", "OverflowException Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Vul een geldig getal in!", "FormatException Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public int Priem(int getal)
        {
            int i;
            for (i = 2; i <= getal - 1; i++)
            {
                if (getal % i == 0)
                {
                    return 0;
                }
            }
            if (i == getal)
            {
                return 1;
            }
            return 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string zin = txtPalindroom.Text;
            bool Palindroom = IsPalindrome(zin);
            if (Palindroom == true)
            {
                MessageBox.Show("Dit is een Palindroom");
            }
            if(Palindroom == false)
            {
                MessageBox.Show("Dit is geen Palindroom");
            }
        }

        public bool IsPalindrome(string zin)
        {
            char[] array = zin.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);
            return zin == backwards;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input;
            do
            {
                input = InputBox.Input.Show("Voer een getal in", "Input gevraagd", "");
                listBox1.Items.Add(input);
            }
            while (input != "0" && input != "");
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input;
            do
            {
                input = InputBox.Input.Show("Voer een getal in", "Input gevraagd", "");
                listBox2.Items.Add(input);
            }
            while (input != "0" && input != "");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.AddRange(listBox1.Items);
            listBox3.Items.AddRange(listBox2.Items);

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

           
            // K zo dus
            // String _inputString = txtSleutel.Text;
            // String _newString = "";
            // for (int i = 0; i < _inputString.Length; i++) {
            //    int asciiCode = (int)_inputString[i];
            //    _newString += (char)(asciiCode + 100 > 255 ? asciiCode - 155 : asciiCode + 100);
            // }
            // txtSleutel.Text = _newString;
             


            string inputString = txtSleutel.Text;
            string _string = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                char character = inputString[i];
                int j = (int)character;
                j += 100;

                char _char;
                if (j <= 255)
                { 
                    _char = (char)j;

                    
                }
                else 
                {
                    j -= 255;
                    _char = (char)j;
                }

                _string += _char;

            }

            txtSleutel.Text = _string;             
        }

        private void btnOntSleutel_Click(object sender, EventArgs e)
        {

            string inputString = txtSleutel.Text;
            string _string = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                char _char, character = inputString[i];
                int x = (int)character; 
                if (x <= 100)
                {
                    x += 155;
                    _char = (char)x;
                    
                   

                }
                else
                {
                    x -= 100;
                    _char = (char)x;
                    
                    
                }
                _string += _char; 
                
            }
            txtSleutel.Text = _string;
        }


        private void button7_Click_1(object sender, EventArgs e)
        {

            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random colorRandom = new Random();
            int colorInt1 = colorRandom.Next(1, 255);
            int colorInt2 = colorRandom.Next(1, 255);
            int colorInt3 = colorRandom.Next(1, 255);
            this.BackColor = Color.FromArgb(colorInt1, colorInt2, colorInt3);
        }
    }
}
