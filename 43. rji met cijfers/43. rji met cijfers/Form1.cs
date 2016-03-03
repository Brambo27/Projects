using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43.rji_met_cijfers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] getalRij = {2,4,6,8,10 };
            for (int i =0; i < 5; i++)
            {
                listBox1.Items.Add(getalRij[i]);
            }
        }

        private void btnOPgave44_Click(object sender, EventArgs e)
        {
            string[] woordenRij = { "html", "C#", "php", "java", "javasript" };
            listBox1.Items.Clear();
            for(int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(woordenRij[i]);
            }
        }

        private void btnOpgave44b_Click(object sender, EventArgs e)
        {
            int[] cijferRij = new int[4];
            for(int i = 0; i < 4; i++)
            {
                cijferRij[i] = int.Parse(InputBox.Input.Show("voer een getal in", "input gevraagd", ""));
            }
            Array.Sort(cijferRij);
            for(int i = 0; i < 4; i++)
            {
                listBox1.Items.Add(cijferRij[i]);
            }
        }
    }
}
