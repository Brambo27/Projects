namespace Opgaven_6a
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
            this.txtTijd = new System.Windows.Forms.TextBox();
            this.txtTijdTotMn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.btnNu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tijd";
            // 
            // txtTijd
            // 
            this.txtTijd.Location = new System.Drawing.Point(210, 28);
            this.txtTijd.Name = "txtTijd";
            this.txtTijd.Size = new System.Drawing.Size(100, 22);
            this.txtTijd.TabIndex = 1;
            // 
            // txtTijdTotMn
            // 
            this.txtTijdTotMn.Location = new System.Drawing.Point(210, 176);
            this.txtTijdTotMn.Name = "txtTijdTotMn";
            this.txtTijdTotMn.Size = new System.Drawing.Size(100, 22);
            this.txtTijdTotMn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tijd tot mn";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(96, 104);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // btnNu
            // 
            this.btnNu.Location = new System.Drawing.Point(352, 26);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(75, 23);
            this.btnNu.TabIndex = 5;
            this.btnNu.Text = "NU";
            this.btnNu.UseVisualStyleBackColor = true;
            this.btnNu.Click += new System.EventHandler(this.btnNu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 335);
            this.Controls.Add(this.btnNu);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTijdTotMn);
            this.Controls.Add(this.txtTijd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTijd;
        private System.Windows.Forms.TextBox txtTijdTotMn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Button btnNu;
    }
}

