using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.Te_snel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            int Max = int.Parse(txtMax.Text);
            int Snel = int.Parse(txtSnel.Text);
            int teSnel = Snel - Max;
            txtBoete.Text = teSnel * 10 + 25 + "";
        }
    }
}
