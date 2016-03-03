namespace ExtraOpgaveArray
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
            this.txtTelefoonNummer = new System.Windows.Forms.TextBox();
            this.btnBepalen = new System.Windows.Forms.Button();
            this.txtTelefoonText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefoonNummer
            // 
            this.txtTelefoonNummer.Location = new System.Drawing.Point(130, 12);
            this.txtTelefoonNummer.Name = "txtTelefoonNummer";
            this.txtTelefoonNummer.Size = new System.Drawing.Size(100, 22);
            this.txtTelefoonNummer.TabIndex = 0;
            // 
            // btnBepalen
            // 
            this.btnBepalen.Location = new System.Drawing.Point(145, 70);
            this.btnBepalen.Name = "btnBepalen";
            this.btnBepalen.Size = new System.Drawing.Size(75, 23);
            this.btnBepalen.TabIndex = 1;
            this.btnBepalen.Text = "Bepaal";
            this.btnBepalen.UseVisualStyleBackColor = true;
            this.btnBepalen.Click += new System.EventHandler(this.btnBepalen_Click);
            // 
            // txtTelefoonText
            // 
            this.txtTelefoonText.Location = new System.Drawing.Point(130, 131);
            this.txtTelefoonText.Name = "txtTelefoonText";
            this.txtTelefoonText.Size = new System.Drawing.Size(1043, 22);
            this.txtTelefoonText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefoon nummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefoon naar text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefoonText);
            this.Controls.Add(this.btnBepalen);
            this.Controls.Add(this.txtTelefoonNummer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefoonNummer;
        private System.Windows.Forms.Button btnBepalen;
        private System.Windows.Forms.TextBox txtTelefoonText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

