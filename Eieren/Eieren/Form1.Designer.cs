namespace Eieren
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEi = new System.Windows.Forms.TextBox();
            this.txtGros = new System.Windows.Forms.TextBox();
            this.txtDozijn = new System.Windows.Forms.TextBox();
            this.txtOver = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoeveel eieren wil je hebben?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Het aantal eiren dat je ingegeven hebt:";
            // 
            // txtEi
            // 
            this.txtEi.Location = new System.Drawing.Point(217, 13);
            this.txtEi.Name = "txtEi";
            this.txtEi.Size = new System.Drawing.Size(100, 22);
            this.txtEi.TabIndex = 2;
            // 
            // txtGros
            // 
            this.txtGros.Location = new System.Drawing.Point(19, 181);
            this.txtGros.Name = "txtGros";
            this.txtGros.Size = new System.Drawing.Size(55, 22);
            this.txtGros.TabIndex = 3;
            
            // 
            // txtDozijn
            // 
            this.txtDozijn.Location = new System.Drawing.Point(19, 221);
            this.txtDozijn.Name = "txtDozijn";
            this.txtDozijn.Size = new System.Drawing.Size(55, 22);
            this.txtDozijn.TabIndex = 4;
            // 
            // txtOver
            // 
            this.txtOver.Location = new System.Drawing.Point(19, 260);
            this.txtOver.Name = "txtOver";
            this.txtOver.Size = new System.Drawing.Size(57, 22);
            this.txtOver.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dozijn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gros";
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Losse eieren";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(19, 66);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 9;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 365);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOver);
            this.Controls.Add(this.txtDozijn);
            this.Controls.Add(this.txtGros);
            this.Controls.Add(this.txtEi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEi;
        private System.Windows.Forms.TextBox txtGros;
        private System.Windows.Forms.TextBox txtDozijn;
        private System.Windows.Forms.TextBox txtOver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBereken;
    }
}

