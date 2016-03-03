namespace WindowsFormsApplication4
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
            this.txtBankNummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnControle = new System.Windows.Forms.Button();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBankNummer
            // 
            this.txtBankNummer.Location = new System.Drawing.Point(178, 12);
            this.txtBankNummer.Name = "txtBankNummer";
            this.txtBankNummer.Size = new System.Drawing.Size(100, 22);
            this.txtBankNummer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bankrekeningnummer";
            // 
            // btnControle
            // 
            this.btnControle.Location = new System.Drawing.Point(16, 73);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(75, 23);
            this.btnControle.TabIndex = 2;
            this.btnControle.Text = "Controle";
            this.btnControle.UseVisualStyleBackColor = true;
            this.btnControle.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(363, 73);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 22);
            this.txtTest.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 384);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.btnControle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBankNummer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBankNummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnControle;
        private System.Windows.Forms.TextBox txtTest;
    }
}

