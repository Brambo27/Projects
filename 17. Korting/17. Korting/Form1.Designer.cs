namespace _17.Korting
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
            this.txtAankoop = new System.Windows.Forms.TextBox();
            this.txtEind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAankoop
            // 
            this.txtAankoop.Location = new System.Drawing.Point(143, 13);
            this.txtAankoop.Name = "txtAankoop";
            this.txtAankoop.Size = new System.Drawing.Size(100, 22);
            this.txtAankoop.TabIndex = 0;
            this.txtAankoop.TextChanged += new System.EventHandler(this.txtAankoop_TextChanged);
            // 
            // txtEind
            // 
            this.txtEind.Location = new System.Drawing.Point(143, 105);
            this.txtEind.Name = "txtEind";
            this.txtEind.Size = new System.Drawing.Size(100, 22);
            this.txtEind.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aankoopbedrag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Werkelijke prijs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEind);
            this.Controls.Add(this.txtAankoop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAankoop;
        private System.Windows.Forms.TextBox txtEind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

