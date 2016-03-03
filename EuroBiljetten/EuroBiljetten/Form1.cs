using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroBiljetten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
            int berekening = int.Parse(txtInvoer.Text);
            

            txtVijftig.Text = berekening / 50 + "";
            berekening %= 50;
            txtTwintig.Text = berekening / 20 + "";
            berekening %= 20;
            txtTien.Text = berekening / 10 + "";
            berekening %= 10;
            txtVijf.Text = berekening / 5 + "";
            txtOver.Text = berekening % 5 + "";




        }
    }
}
