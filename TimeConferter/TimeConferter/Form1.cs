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

        public Form1()
        {
            InitializeComponent();
            txtUurUit.ReadOnly = true;
            txtMinUit.ReadOnly = true;
            txtSecUit.ReadOnly = true;
        }

        private void SecIn_TextChanged(object sender, EventArgs e)
        {
            
            int seconds = 0;
            Int32.TryParse(txtSecIn.Text, out seconds);

            txtUurUit.Text = "" + secondsToHours(seconds);   // Zet de uitkomst van de methode secondesToHours in Text vlak "txtUurUit" en geef de waarde van seconds mee.
            txtMinUit.Text = "" + secondsToMinutes(seconds); // Zet de uitkomst van de methode SecondsToMinutesMinusHours in text vlak "txtMinUit" en geef de waarde van seconds mee.
            txtSecUit.Text = "" + secondsToSeconds(seconds); // Zet de uitkomst van de methode secondsToSeconds in text vlak ""txtSecUit" en geef de waarde van seconds mee.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       
        
        public int secondsToHours(int seconds)
        {
            int hours = seconds / 3600; // Calculate hours, rest seconds will be ignored because it's an integer
            return hours; // Return hours
        }

        public int secondsToMinutes(int seconds) 
        {
          
            int hoursInSeconds = secondsToHours(seconds) * 3600; // Calculate hours into secondes
            int totalSecondsMinusHours = seconds - hoursInSeconds; // Subtract hours(In secondes) from Total secondes 
            int minutes = totalSecondsMinusHours / 60; // Calculate minutes by dividing total secondes(Minus hours) door 60 

            return minutes; // Return minutes
        }

        public int secondsToSeconds(int seconds)
        {
            int calculatedSeconds = seconds - secondsToMinutes(seconds) * 60 - secondsToHours(seconds) * 3600;
            return calculatedSeconds;
        }
        
    }
}
