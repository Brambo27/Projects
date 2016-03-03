using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galgje
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           

            int textLeng = txtWoord.TextLength;
            string zin = txtWoord.Text.Replace(" " , "_");


            if (zin.IndexOf("_", StringComparison.Ordinal) >=0)
            {
                galgje("_");
            }


            switch (textLeng)
            {
            

                case 1:
                    txt0.Visible = true;
                    break;
                case 2:
                    txt1.Visible = true;
                    goto case 1;
                case 3:
                    txt2.Visible = true;
                    goto case 2;
                case 4:
                    txt3.Visible = true;
                    goto case 3;
                case 5:
                    txt4.Visible = true;
                    goto case 4;
                case 6:
                    txt5.Visible = true;
                    goto case 5;
                case 7:
                    txt6.Visible = true;
                    goto case 6;
                case 8:
                    txt7.Visible = true;
                    goto case 7;
                case 9:
                    txt8.Visible = true;
                    goto case 8;
                case 10:
                    txt9.Visible = true;
                    goto case 9;
                    

            }
           

        }

        public int galgje(string button)
        {
            
            string zin = txtWoord.Text.Replace(" ", "_");
            
            int Index = zin.IndexOf(button, StringComparison.OrdinalIgnoreCase);
            string index = "";           
            Console.Write(Index);
            switch (Index)
            {
                case 0:
                    txt0.Text = button.ToUpper();
                    break;
                case 1:
                    txt1.Text = button;
                    break;
                case 2:
                    txt2.Text = button;
                    break;
                case 3:
                    txt3.Text = button;
                    break;
                case 4:
                    txt4.Text = button;
                    break;
                case 5:
                    txt5.Text = button;
                    break;
                case 6:
                    txt6.Text = button;
                    break;
                case 7:
                    txt7.Text = button;
                    break;
                case 8:
                    txt8.Text = button;
                    break;
                case 9:
                    txt9.Text = button;
                    break;
            }

            return (0);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            
            btnA.Visible = false;
            galgje("a"); 
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.Visible = false;
            galgje("b");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.Visible = false;
            galgje("c");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.Visible = false;
            galgje("d");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnE.Visible = false;
            galgje("e");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            btnF.Visible = false;
            galgje("f");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            btnG.Visible = false;
            galgje("g");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            btnH.Visible = false;
            galgje("h");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            btnI.Visible = false;
            galgje("i");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            btnJ.Visible = false;
            galgje("j");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            btnK.Visible = false;
            galgje("k");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            btnL.Visible = false;
            galgje("l");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Visible = false;
            galgje("m");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            btnN.Visible = false;
            galgje("n");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            btnO.Visible = false;
            galgje("o");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            btnP.Visible = false;
            galgje("p");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            btnQ.Visible = false;
            galgje("q");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Visible = false;
            galgje("r");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnS.Visible = false;
            galgje("s");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            btnT.Visible = false;
            galgje("t");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            btnU.Visible = false;
            galgje("u");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            btnV.Visible = false;
            galgje("v");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            btnW.Visible = false;
            galgje("w");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnX.Visible = false;
            galgje("x");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            btnY.Visible = false;
            galgje("y");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            btnZ.Visible = false;
            galgje("z");
        }
    }
}
