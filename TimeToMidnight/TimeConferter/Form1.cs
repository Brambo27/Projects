using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeConferter
{
    public partial class Form1 : Form
    {
        double UitkomstSec = 0;
        double UitkomstMin = 0;
        double UitkomstUur = 0;

        public Form1()
        {
            InitializeComponent();
            txtUitSec.ReadOnly = true;
            txtUitMinuten.ReadOnly = true;
            txtUitUren.ReadOnly = true;
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            double UrenIn = double.Parse("0" + txtInUren.Text);
            double MinutenIn = double.Parse("0" + txtInMinuten.Text);
            double SecIn = double.Parse("0" + txtInSec.Text);

            double UrenUit = double.Parse("0" + txtUitUren.Text);
            double MinutenUit = double.Parse("0" + txtUitMinuten.Text);
            double SecUit = double.Parse("0" + txtUitSec.Text);

            UitkomstSec = 60 - SecIn;
            UitkomstMin = 60 - MinutenIn - 1;
            UitkomstUur = 24 - UrenIn - 1;

            txtUitSec.Text = "" + UitkomstSec;
            txtUitMinuten.Text = "" + UitkomstMin;
            txtUitUren.Text = "" + UitkomstUur;





        }

        private void NU_Click(object sender, EventArgs e)

        {
            string currentTime;
           currentTime = DateTime.Now.ToLongTimeString();
            
            txtNu.Text = currentTime;
        }
    }
}
