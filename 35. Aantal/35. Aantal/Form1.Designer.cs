namespace _35.Aantal
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
            this.txtGetal = new System.Windows.Forms.TextBox();
            this.txtUitkomst = new System.Windows.Forms.TextBox();
            this.btnGroot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGetal
            // 
            this.txtGetal.Location = new System.Drawing.Point(13, 13);
            this.txtGetal.Name = "txtGetal";
            this.txtGetal.Size = new System.Drawing.Size(100, 22);
            this.txtGetal.TabIndex = 0;
            // 
            // txtUitkomst
            // 
            this.txtUitkomst.Location = new System.Drawing.Point(13, 99);
            this.txtUitkomst.Name = "txtUitkomst";
            this.txtUitkomst.Size = new System.Drawing.Size(100, 22);
            this.txtUitkomst.TabIndex = 1;
            // 
            // btnGroot
            // 
            this.btnGroot.Location = new System.Drawing.Point(12, 41);
            this.btnGroot.Name = "btnGroot";
            this.btnGroot.Size = new System.Drawing.Size(100, 52);
            this.btnGroot.TabIndex = 2;
            this.btnGroot.Text = "IK BEN GROOT";
            this.btnGroot.UseVisualStyleBackColor = true;
            this.btnGroot.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 409);
            this.Controls.Add(this.btnGroot);
            this.Controls.Add(this.txtUitkomst);
            this.Controls.Add(this.txtGetal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetal;
        private System.Windows.Forms.TextBox txtUitkomst;
        private System.Windows.Forms.Button btnGroot;
    }
}

