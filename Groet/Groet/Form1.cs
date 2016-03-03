using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           int tijd; 
            txtNu.Text = DateTime.Now.ToString();

            tijd = int.Parse(DateTime.Now.ToString("t").Substring(0, 2));

            TextBox(tijd); //Voer de methode uit en geef de waarde van "tijd" mee

            // 0 tot 12 = morgen
            // 12 tot 14 = middag
            // 14 tot 18 = namiddag
            // 18 tot 23 = avond

        }
        public int TextBox(int tijd) //Methode TextBox met de int tijd gedevinjeerd
        {
            string message, title;

            if (tijd >= 0 && tijd < 12) // tijd is tussen de 0 en 12 = morgen
            {
                message = "Goede morgen!";
                title = "Goede morgen!";
                
            }

            else if (tijd >= 12 && tijd < 14) // tijd is tussen de 12 en 14 = middag
            {
                message = "Goede middag!";
                title = "Goede middag!";
                
            }

            else if (tijd >= 14 && tijd < 18) // tijd is tussen de 14 en 18 = namiddag 
            {
                message = "Goede namiddag!";
                title = "Goede namiddag!";
                
            }
            else // de rest(Tussen 18 en 24) is avond
            {
                message = "Goede avond!";
                title = "Goede avond!";
            }
            MessageBox.Show(message, title);

            return (0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
