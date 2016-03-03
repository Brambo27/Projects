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
            this.txtSecIn = new System.Windows.Forms.TextBox();
            this.txtUurUit = new System.Windows.Forms.TextBox();
            this.txtMinUit = new System.Windows.Forms.TextBox();
            this.txtSecUit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal Seconden";
            // 
            // txtSecIn
            // 
            this.txtSecIn.Location = new System.Drawing.Point(189, 30);
            this.txtSecIn.MaxLength = 999999999;
            this.txtSecIn.Name = "txtSecIn";
            this.txtSecIn.Size = new System.Drawing.Size(100, 22);
            this.txtSecIn.TabIndex = 1;
            this.txtSecIn.TextChanged += new System.EventHandler(this.SecIn_TextChanged);
            // 
            // txtUurUit
            // 
            this.txtUurUit.Location = new System.Drawing.Point(189, 111);
            this.txtUurUit.Name = "txtUurUit";
            this.txtUurUit.Size = new System.Drawing.Size(100, 22);
            this.txtUurUit.TabIndex = 2;
            // 
            // txtMinUit
            // 
            this.txtMinUit.Location = new System.Drawing.Point(189, 152);
            this.txtMinUit.Name = "txtMinUit";
            this.txtMinUit.Size = new System.Drawing.Size(100, 22);
            this.txtMinUit.TabIndex = 3;
            // 
            // txtSecUit
            // 
            this.txtSecUit.Location = new System.Drawing.Point(189, 196);
            this.txtSecUit.Name = "txtSecUit";
            this.txtSecUit.Size = new System.Drawing.Size(100, 22);
            this.txtSecUit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uren";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minuten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seconden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecUit);
            this.Controls.Add(this.txtMinUit);
            this.Controls.Add(this.txtUurUit);
            this.Controls.Add(this.txtSecIn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecIn;
        private System.Windows.Forms.TextBox txtUurUit;
        private System.Windows.Forms.TextBox txtMinUit;
        private System.Windows.Forms.TextBox txtSecUit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

