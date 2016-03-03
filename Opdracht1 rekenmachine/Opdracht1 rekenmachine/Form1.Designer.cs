namespace Opdracht1_rekenmachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnDelen = new System.Windows.Forms.Button();
            this.btwKeer = new System.Windows.Forms.Button();
            this.btwMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGetal1 = new System.Windows.Forms.TextBox();
            this.TxtUitkomst = new System.Windows.Forms.TextBox();
            this.TxtGetal2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 54);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(118, 54);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnDelen
            // 
            this.btnDelen.Location = new System.Drawing.Point(219, 54);
            this.btnDelen.Name = "btnDelen";
            this.btnDelen.Size = new System.Drawing.Size(75, 23);
            this.btnDelen.TabIndex = 2;
            this.btnDelen.Text = ":";
            this.btnDelen.UseVisualStyleBackColor = true;
            this.btnDelen.Click += new System.EventHandler(this.btnDelen_Click);
            // 
            // btwKeer
            // 
            this.btwKeer.Location = new System.Drawing.Point(318, 54);
            this.btwKeer.Name = "btwKeer";
            this.btwKeer.Size = new System.Drawing.Size(75, 23);
            this.btwKeer.TabIndex = 3;
            this.btwKeer.Text = "*";
            this.btwKeer.UseVisualStyleBackColor = true;
            this.btwKeer.Click += new System.EventHandler(this.btwKeer_Click);
            // 
            // btwMod
            // 
            this.btwMod.Location = new System.Drawing.Point(421, 54);
            this.btwMod.Name = "btwMod";
            this.btwMod.Size = new System.Drawing.Size(75, 23);
            this.btwMod.TabIndex = 4;
            this.btwMod.Text = "MOD";
            this.btwMod.UseVisualStyleBackColor = true;
            this.btwMod.Click += new System.EventHandler(this.btwMod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Getal 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Getal 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uitkomst";
            // 
            // TxtGetal1
            // 
            this.TxtGetal1.Location = new System.Drawing.Point(93, 105);
            this.TxtGetal1.Name = "TxtGetal1";
            this.TxtGetal1.Size = new System.Drawing.Size(100, 22);
            this.TxtGetal1.TabIndex = 8;
            // 
            // TxtUitkomst
            // 
            this.TxtUitkomst.Location = new System.Drawing.Point(93, 198);
            this.TxtUitkomst.Name = "TxtUitkomst";
            this.TxtUitkomst.Size = new System.Drawing.Size(100, 22);
            this.TxtUitkomst.TabIndex = 9;
            // 
            // TxtGetal2
            // 
            this.TxtGetal2.Location = new System.Drawing.Point(93, 151);
            this.TxtGetal2.Name = "TxtGetal2";
            this.TxtGetal2.Size = new System.Drawing.Size(100, 22);
            this.TxtGetal2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 541);
            this.Controls.Add(this.TxtGetal2);
            this.Controls.Add(this.TxtUitkomst);
            this.Controls.Add(this.TxtGetal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btwMod);
            this.Controls.Add(this.btwKeer);
            this.Controls.Add(this.btnDelen);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnDelen;
        private System.Windows.Forms.Button btwKeer;
        private System.Windows.Forms.Button btwMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGetal1;
        private System.Windows.Forms.TextBox TxtUitkomst;
        private System.Windows.Forms.TextBox TxtGetal2;
    }
}

