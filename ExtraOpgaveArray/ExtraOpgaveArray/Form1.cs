using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraOpgaveArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBepalen_Click(object sender, EventArgs e)
        {
            int index;
            string telefoonText = "", telefoonNummer;

            string[] telefoonRij = {"Nul", "Een", "Twee", "Drie", "Vier", "Vijf", "Zes", "Zeven", "Acht", "Negen"};
            telefoonNummer = txtTelefoonNummer.Text;
            for (int i = 0; i < 10; i++)
            {
                index = int.Parse(telefoonNummer.Substring(i, 1));
                telefoonText += telefoonRij[index];
            }
            txtTelefoonText.Text = telefoonText;

        }
    }
}
