﻿namespace _16.Loon
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
            this.txtOmzet = new System.Windows.Forms.TextBox();
            this.txtLoon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOmzet
            // 
            this.txtOmzet.Location = new System.Drawing.Point(194, 12);
            this.txtOmzet.Name = "txtOmzet";
            this.txtOmzet.Size = new System.Drawing.Size(100, 22);
            this.txtOmzet.TabIndex = 0;
            this.txtOmzet.TextChanged += new System.EventHandler(this.txtOmzet_TextChanged);
            // 
            // txtLoon
            // 
            this.txtLoon.Location = new System.Drawing.Point(194, 175);
            this.txtLoon.Name = "txtLoon";
            this.txtLoon.Size = new System.Drawing.Size(100, 22);
            this.txtLoon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Omzet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoon);
            this.Controls.Add(this.txtOmzet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOmzet;
        private System.Windows.Forms.TextBox txtLoon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

