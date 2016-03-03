using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_TM_27_ListBox_cijfers
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn22_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            for (int listWaarde = 1; listWaarde <= 45; listWaarde++)
            
                listBox1.Items.Add(listWaarde);
            
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 15; i <=50; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 2; i <=80; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 120; i >= 20; i -= 10)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(txtTafel.TextLength > 0)
            {
                for (int i = 1; i < 101; i++)
                {
                    int tavel = int.Parse(txtTafel.Text);
                    int uitkomst;

                    uitkomst = i * tavel;
                    listBox1.Items.Add(i + " keer " + tavel + " is " + uitkomst);
                }
            }
            else
            {
                MessageBox.Show("Voer een getal in!", "Error!");
            }
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i =0; i <= 10000; i++)
            {
                char letter = (char)i;
                listBox1.Items.Add(letter);

            }
            
        }
    }
}
