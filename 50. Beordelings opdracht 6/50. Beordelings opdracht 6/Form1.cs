using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50.Beordelings_opdracht_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            string input = txtNederlandsEngels.Text.ToLower();
            
            string[] Nedrij = { "kat", "hond", "slang", "schildpad", "vogel"};
            string[] Engrij = { "cat", "dog", "snake", "turtle", "bird" };

            int i;
            for (i = 0; i < 5; i++)
            {
                if(input == Nedrij[i])
                {
                    string output = Engrij[i];
                    txtNederlandsEngels.Text = output;
                    i = 5;
                }
                
            }
            Console.Write(i);
            if (i == 5)
            {
                MessageBox.Show("Dit woord staat niet in het wordenboek!", "wordenBoek");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool gevonden = false;
            string input = (txtGebruikCode.Text );
            string[] code = { "00000" , "54321" , "12345", "11111", "22222", "56789" } ;

            for(int i = 0; i < code.Length; i++)
            {
                
                if(input == code[i])
                {
                    Console.Write("Test64");
                    gevonden = true;
                }
            }
            if (gevonden == true)
            {
                MessageBox.Show("U bent ingelogd!", "Login");
            }
            else
            {
                MessageBox.Show("Deze code is niet geldig", "Login");
            }    
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try {
                int input;
                List<int> list1 = new List<int>();
                int i = 0;

                do {
                    input = int.Parse((InputBox.Input.Show("Insert a number", "Input needed", "")));
                    list1.Add(input);
                    listBox1.Items.Add(input);
                    i++;
                }
                while (i != 10);
                list1.Sort();
                txtGrootste.Text = list1.Last() + "";
                txtKleinste.Text = list1.First() + "";
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Voer een geldig getal in", "FormatException Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Dit getal is te groot!", "OverFlowExeption Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        List<int> list2 = new List<int>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int input, i = 0;
            
            do
            {
                input = int.Parse((InputBox.Input.Show("Insert a number", "Input needed", "")));
                list2.Add(input);
                listBox2.Items.Add(input);
                i++;
            }
            while (i != 10);
        }

        private void txtSorteren_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            list2.Sort();
            foreach (int item in list2)
            {
                listBox2.Items.Add(item);
            }

        }
    }
}
