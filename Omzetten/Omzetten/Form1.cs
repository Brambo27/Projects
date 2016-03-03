using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omzetten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            string LowerAchter = txtAchternaam.Text.ToLower();
            string LowerVoor = txtVoornaam.Text.ToLower();
            txtLogin.Text = LowerVoor + " " + LowerAchter;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string LowerAchter = txtAchternaam.Text.ToLower();
            string LowerVoor = txtVoornaam.Text.ToLower();
            txtLogin.Text = LowerVoor + "." + LowerAchter;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string LowerAchter = txtAchternaam.Text.ToLower();
            string LowerVoor = txtVoornaam.Text.ToLower();
            txtLogin.Text = LowerVoor + "." + LowerAchter;

            if (LowerAchter.Length == 0 || LowerVoor.Length == 0)
                {
                string title, message;

                message = "U dient een voornaam en achternaam te geven!";
                title = "Input error";
                MessageBox.Show(message, title);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string LowerAchter = txtAchternaam.Text.ToLower().TrimStart().TrimEnd();
            string LowerVoor = txtVoornaam.Text.ToLower().TrimStart().TrimEnd();
            txtLogin.Text = LowerVoor + "." + LowerAchter;

            if (LowerAchter.Length == 0 || LowerVoor.Length == 0)
            {
                string title, message;

                message = "U dient een voornaam en achternaam te geven!";
                title = "Input error";
                MessageBox.Show(message, title);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string LowerAchter = txtAchternaam.Text.ToLower().Replace(" ", ".");
            string LowerVoor = txtVoornaam.Text.ToLower().Replace(" ", ".");
            txtLogin.Text = LowerVoor + "." + LowerAchter;

            if (LowerAchter.Length == 0 || LowerVoor.Length == 0)
            {
                string title, message;

                message = "U dient een voornaam en achternaam te geven!";
                title = "Input error";
                MessageBox.Show(message, title);
            }
        }
    }
}

