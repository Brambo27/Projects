using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kleur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbWit_CheckedChanged(object sender, EventArgs e)
        {
            txtBox.BackColor = Color.White;
            txtBox.ForeColor = Color.Black;
        }

        private void rdbZwart_CheckedChanged(object sender, EventArgs e)
        {
            txtBox.BackColor = Color.Black;
            txtBox.ForeColor = Color.White;
        
        }

        private void rdbBlauw_CheckedChanged(object sender, EventArgs e)
        {
            txtBox.BackColor = Color.Blue;
            txtBox.ForeColor = Color.Red;
        
        }

        private void rdbRood_CheckedChanged(object sender, EventArgs e)
        {
            txtBox.BackColor = Color.Red;
            txtBox.ForeColor = Color.Blue;
        }
    }
}
