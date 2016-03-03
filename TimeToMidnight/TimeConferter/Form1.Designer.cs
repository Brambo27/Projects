namespace TimeConferter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInUren = new System.Windows.Forms.TextBox();
            this.txtInMinuten = new System.Windows.Forms.TextBox();
            this.txtInSec = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUitUren = new System.Windows.Forms.TextBox();
            this.txtUitMinuten = new System.Windows.Forms.TextBox();
            this.txtUitSec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNu = new System.Windows.Forms.Button();
            this.txtNu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tijd:";
            // 
            // txtInUren
            // 
            this.txtInUren.Location = new System.Drawing.Point(292, 28);
            this.txtInUren.Name = "txtInUren";
            this.txtInUren.Size = new System.Drawing.Size(100, 22);
            this.txtInUren.TabIndex = 1;
            // 
            // txtInMinuten
            // 
            this.txtInMinuten.Location = new System.Drawing.Point(398, 28);
            this.txtInMinuten.Name = "txtInMinuten";
            this.txtInMinuten.Size = new System.Drawing.Size(100, 22);
            this.txtInMinuten.TabIndex = 2;
            // 
            // txtInSec
            // 
            this.txtInSec.Location = new System.Drawing.Point(504, 28);
            this.txtInSec.Name = "txtInSec";
            this.txtInSec.Size = new System.Drawing.Size(100, 22);
            this.txtInSec.TabIndex = 3;
            // 
            // btnBereken
            // 
            this.btnBereken.AutoSize = true;
            this.btnBereken.Location = new System.Drawing.Point(14, 82);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(215, 27);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "Bereken de tijd tot middernacht";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tijd tot middernacht:";
            // 
            // txtUitUren
            // 
            this.txtUitUren.Location = new System.Drawing.Point(292, 140);
            this.txtUitUren.Name = "txtUitUren";
            this.txtUitUren.Size = new System.Drawing.Size(100, 22);
            this.txtUitUren.TabIndex = 6;
            // 
            // txtUitMinuten
            // 
            this.txtUitMinuten.Location = new System.Drawing.Point(400, 140);
            this.txtUitMinuten.Name = "txtUitMinuten";
            this.txtUitMinuten.Size = new System.Drawing.Size(100, 22);
            this.txtUitMinuten.TabIndex = 7;
            // 
            // txtUitSec
            // 
            this.txtUitSec.Location = new System.Drawing.Point(506, 140);
            this.txtUitSec.Name = "txtUitSec";
            this.txtUitSec.Size = new System.Drawing.Size(100, 22);
            this.txtUitSec.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Uren";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Minuten";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seconden";
            // 
            // btnNu
            // 
            this.btnNu.Location = new System.Drawing.Point(642, 28);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(75, 23);
            this.btnNu.TabIndex = 12;
            this.btnNu.Text = "NU";
            this.btnNu.UseVisualStyleBackColor = true;
            this.btnNu.Click += new System.EventHandler(this.NU_Click);
            // 
            // txtNu
            // 
            this.txtNu.Location = new System.Drawing.Point(642, 68);
            this.txtNu.Name = "txtNu";
            this.txtNu.Size = new System.Drawing.Size(100, 22);
            this.txtNu.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 338);
            this.Controls.Add(this.txtNu);
            this.Controls.Add(this.btnNu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUitSec);
            this.Controls.Add(this.txtUitMinuten);
            this.Controls.Add(this.txtUitUren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtInSec);
            this.Controls.Add(this.txtInMinuten);
            this.Controls.Add(this.txtInUren);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInUren;
        private System.Windows.Forms.TextBox txtInMinuten;
        private System.Windows.Forms.TextBox txtInSec;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUitUren;
        private System.Windows.Forms.TextBox txtUitMinuten;
        private System.Windows.Forms.TextBox txtUitSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNu;
        private System.Windows.Forms.TextBox txtNu;
    }
}

