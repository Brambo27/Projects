using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _51.Quizmaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();


            int winst = 0;
            
            
            for (int x = 0; x < 1000000; x++)
            {
                int antwoordINT = random.Next(1, 4);
                int i;
                int keuzeINT = random.Next(1, 4);

                for (i = 0; i < 2; i++)
                {

                    
                    if (antwoordINT != keuzeINT)
                    {

                        switch (keuzeINT)
                        {
                            case 1:
                                keuzeINT++;
                                break;
                            case 2:
                                keuzeINT++;
                                break;
                            case 3:
                                keuzeINT-=2;
                                break;
                        }
                    }
                    else
                    {
                        i = 3;
                    }

                    
                }
                
                if (i == 4)
                {
                    winst++;
                }
                
            }
            
            txtUitkomst.Text = winst + "";

        }
    }
}
