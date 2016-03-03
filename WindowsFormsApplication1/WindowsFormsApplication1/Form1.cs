using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form

    {
       
        double calculation = 0;
        public Form1()

        {
           
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            double width = double.Parse("0" + txtBreed.Text);
            double height = double.Parse("0" + txtHoogt.Text);
            double length = double.Parse("0" + txtLeng.Text);
            txtUitkomst.Text = "";


            switch (index)
            {
                case 0:
                    lblBreed.Text = "Breedte";
                    lblLeng.Text = "Lengte";
                    txtLeng.ReadOnly = false;
                    txtLeng.Text = "";
                    txtBreed.Text = "";
                    txtHoogt.Text = "";
                    // Cubus
                    break;
                case 1:
                    lblBreed.Text = "Radius";
                    lblLeng.Text = "";
                    txtLeng.ReadOnly = true;
                    txtLeng.Text = "";
                    txtBreed.Text = "";
                    txtHoogt.Text = "";
                    // Cilinder
                    break;
                case 2:
                    lblBreed.Text = "Breedte";
                    lblLeng.Text = "Lengte";
                    txtLeng.ReadOnly = false;
                    txtLeng.Text = "";
                    txtBreed.Text = "";
                    txtHoogt.Text = "";
                    // Piramide
                    break;
                case 3:
                    lblBreed.Text = "Radius";
                    lblLeng.Text = "";
                    txtLeng.ReadOnly = true;
                    txtLeng.Text = "";
                    txtBreed.Text = "";
                    txtHoogt.Text = "";
                    // Kegel
                    break;
            }
        }
        private void btnBereken_Click(object sender, EventArgs e)
        {
            try {
                int index = comboBox1.SelectedIndex;
                double width = double.Parse("0" + txtBreed.Text);
                double height = double.Parse("0" + txtHoogt.Text);
                double length = double.Parse("0" + txtLeng.Text);

                switch (index)
                {
                    case 0:
                        calculation = length * width * height;
                        // Cubus
                        break;
                    case 1:
                        calculation = 3.14159 * (width * width * height);
                        //Cilinder
                        break;
                    case 2:
                        calculation = (length * width * height) / 3;
                        //Piramide
                        break;
                    case 3:
                        calculation = (3.14159 * (width * width) * height) / 3;
                        //Kegel
                        break;


                }
                txtUitkomst.Text = "" + calculation;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Voer een geldig getal in!", "FormatException Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
