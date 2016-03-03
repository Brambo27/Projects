namespace Kleur
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
            this.rdbWit = new System.Windows.Forms.RadioButton();
            this.rdbZwart = new System.Windows.Forms.RadioButton();
            this.rdbBlauw = new System.Windows.Forms.RadioButton();
            this.rdbRood = new System.Windows.Forms.RadioButton();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdbWit
            // 
            this.rdbWit.AutoSize = true;
            this.rdbWit.Checked = true;
            this.rdbWit.Location = new System.Drawing.Point(13, 26);
            this.rdbWit.Name = "rdbWit";
            this.rdbWit.Size = new System.Drawing.Size(49, 21);
            this.rdbWit.TabIndex = 0;
            this.rdbWit.TabStop = true;
            this.rdbWit.Text = "Wit";
            this.rdbWit.UseVisualStyleBackColor = true;
            this.rdbWit.CheckedChanged += new System.EventHandler(this.rdbWit_CheckedChanged);
            // 
            // rdbZwart
            // 
            this.rdbZwart.AutoSize = true;
            this.rdbZwart.Location = new System.Drawing.Point(13, 54);
            this.rdbZwart.Name = "rdbZwart";
            this.rdbZwart.Size = new System.Drawing.Size(64, 21);
            this.rdbZwart.TabIndex = 1;
            this.rdbZwart.Text = "Zwart";
            this.rdbZwart.UseVisualStyleBackColor = true;
            this.rdbZwart.CheckedChanged += new System.EventHandler(this.rdbZwart_CheckedChanged);
            // 
            // rdbBlauw
            // 
            this.rdbBlauw.AutoSize = true;
            this.rdbBlauw.Location = new System.Drawing.Point(13, 82);
            this.rdbBlauw.Name = "rdbBlauw";
            this.rdbBlauw.Size = new System.Drawing.Size(66, 21);
            this.rdbBlauw.TabIndex = 2;
            this.rdbBlauw.Text = "Blauw";
            this.rdbBlauw.UseVisualStyleBackColor = true;
            this.rdbBlauw.CheckedChanged += new System.EventHandler(this.rdbBlauw_CheckedChanged);
            // 
            // rdbRood
            // 
            this.rdbRood.AutoSize = true;
            this.rdbRood.Location = new System.Drawing.Point(13, 110);
            this.rdbRood.Name = "rdbRood";
            this.rdbRood.Size = new System.Drawing.Size(63, 21);
            this.rdbRood.TabIndex = 3;
            this.rdbRood.Text = "Rood";
            this.rdbRood.UseVisualStyleBackColor = true;
            this.rdbRood.CheckedChanged += new System.EventHandler(this.rdbRood_CheckedChanged);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(195, 26);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox.Size = new System.Drawing.Size(225, 406);
            this.txtBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 444);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.rdbRood);
            this.Controls.Add(this.rdbBlauw);
            this.Controls.Add(this.rdbZwart);
            this.Controls.Add(this.rdbWit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbWit;
        private System.Windows.Forms.RadioButton rdbZwart;
        private System.Windows.Forms.RadioButton rdbBlauw;
        private System.Windows.Forms.RadioButton rdbRood;
        private System.Windows.Forms.TextBox txtBox;
    }
}

