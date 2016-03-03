using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace CookieClicker
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
            btnUpgrade.Text = nextCookiesPerClick + " cookies per click";
            lblCost.Text = "Cost = " + currentUpgradeCost + "";
            
        }
        private static System.Timers.Timer aTimer;
        int cookies = 0;
        int upgrade = 1;
        int nextUpgradeCost = 50, currentUpgradeCost = 50;
        int currentCookiesPerClick= 1;
        int nextCookiesPerClick = 2;


        private void Form1_Click(object sender, EventArgs e)
        {
            cookie();
            checkUpgrade();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cookie();
            checkUpgrade();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cookies -= nextUpgradeCost;
            upgrade1();
            btnUpgrade.Enabled = false;
            label1.Text = cookies + "";
            upgrade++;

        }

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        private void btnUpgrade1_Click(object sender, EventArgs e)
        {
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1350;
            myTimer.Start();
        }



   private void TimerEventProcessor(...)
        {
            label1.Text = "...";
        }

        void checkUpgrade()
        {
            if (cookies >= nextUpgradeCost)
            {
                btnUpgrade.Enabled = true;
                
            }
        }
        void cookie()
        {
            cookies += currentCookiesPerClick;
            label1.Text = cookies + "";
        }
        void upgrade1()
        {
            btnUpgrade.Text = nextUpgrade()+" cookies per click";
            lblCost.Text = "Cost: " + nextCost();
            

        }
        int nextCost()
        {
            currentUpgradeCost = nextUpgradeCost;
            nextUpgradeCost = Convert.ToInt32(50 * (Math.Pow(1.15, upgrade)));
            return (nextUpgradeCost);
        }



        int nextUpgrade()
        {
            currentCookiesPerClick = nextCookiesPerClick;
            nextCookiesPerClick *= 2;
            return (nextCookiesPerClick);
        }

    }
}
