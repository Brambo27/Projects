using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verbruik_Auto
{
    public partial class Form1 : Form
    {
        double Uitkomst = 0;
        public Form1()

        {
            InitializeComponent();
           
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {

            double EindKilo = double.Parse("0" + txtEkilo.Text);
            double Liter = double.Parse("0" + txtLiter.Text);
            double BeginKilo = double.Parse("0" + txtBkilo.Text);
            

            Uitkomst = Liter/(EindKilo - BeginKilo);
            txtUitkomst.Text = Uitkomst + "";
        }
    }
}
