using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgaven_6a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {

            string tijd, uur;
            int u, um, m, mm, s, sm;
            tijd = txtTijd.Text;

            //metode replace vervangt een teken voor een ander teken. in dit geval word de ":" vervangen door "Niks"

            tijd = tijd.Replace(":", "");



            // metode substring haalt een stukje uit de string.
            // een string begint bij de index 0 dus niet bij 1.
            // het eerste getal geeft de index van de string en het tweede cijfer geeft het aantal karacters.
            uur = tijd.Substring(0, 2);

            //String uur omzetten naar int

            u = int.Parse(uur);
            um = 24 - u - 1;


            m = int.Parse(tijd.Substring(2, 2)); // Stukje van een string neemen en omzetten naar een int.
            mm = 60 - m - 1;


            s = int.Parse(tijd.Substring(4, 2));
            sm = 60 - s;


            txtTijdTotMn.Text = um + ":" + mm + ":" + sm;
            
            
        }

        private void btnNu_Click(object sender, EventArgs e)
        {

            string currentTime;
            currentTime = DateTime.Now.ToLongTimeString();

            txtTijd.Text = currentTime;
        }
    }
}
