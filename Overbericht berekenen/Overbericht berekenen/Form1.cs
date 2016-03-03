using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overbericht_berekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Checks the value of the text.
            
            double cm = double.Parse("0" + txtLeng.Text);
            double kg = double.Parse("0" + txtKg.Text);
            double Bmi;
            if (txtLeng.Text.Length <=3||txtKg.Text.Length <= 1)
            {

                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "Je hebt geen goede lengte of breete in gevoerd";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);


            }
            else if (txtLeng.Text.Length == 4 && txtKg.Text.Length >= 2) 
            {
                Bmi = kg / (cm*cm);
                txtBmi.Text = "" + Bmi;

                if (Bmi > 25)
                {
                    string message = "Je hebt overgewicht!";
                    string caption = "Resultaat";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                }
                else if (Bmi < 25)
                {
                    string message = "Je hebt geen overgewicht!";
                    string caption = "Resultaat";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                }
                }
            }

        

        }

       
    }

