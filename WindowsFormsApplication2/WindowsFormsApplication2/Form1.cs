using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Berekeningen : Form
    {

        double Leng, Breed, Hoog, Uitkomst;

        public Berekeningen()

        {

            InitializeComponent();
            comboBox1.SelectedItem = "Balk";
            
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {

            Breed = double.Parse(txtBreed.Text);
            Leng = double.Parse(txtLeng.Text);
            Hoog = double.Parse(txtHoog.Text);
            Uitkomst = Leng * Breed * Hoog;
            txtUitkomst.Text = Uitkomst.ToString();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtLeng_TextChanged(object sender, EventArgs e)
        {




        }

        private void txtBreed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
