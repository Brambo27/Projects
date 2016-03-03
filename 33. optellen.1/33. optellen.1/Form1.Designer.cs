namespace _33.optellen._1
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
            this.btnTelOP = new System.Windows.Forms.Button();
            this.txtEersteGetal = new System.Windows.Forms.TextBox();
            this.txtAantalGetallen = new System.Windows.Forms.TextBox();
            this.txtSom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTelOP
            // 
            this.btnTelOP.Location = new System.Drawing.Point(106, 149);
            this.btnTelOP.Name = "btnTelOP";
            this.btnTelOP.Size = new System.Drawing.Size(75, 23);
            this.btnTelOP.TabIndex = 0;
            this.btnTelOP.Text = "Tel op";
            this.btnTelOP.UseVisualStyleBackColor = true;
            this.btnTelOP.Click += new System.EventHandler(this.btnTelOP_Click);
            // 
            // txtEersteGetal
            // 
            this.txtEersteGetal.Location = new System.Drawing.Point(287, 50);
            this.txtEersteGetal.Name = "txtEersteGetal";
            this.txtEersteGetal.Size = new System.Drawing.Size(100, 22);
            this.txtEersteGetal.TabIndex = 1;
            // 
            // txtAantalGetallen
            // 
            this.txtAantalGetallen.Location = new System.Drawing.Point(189, 258);
            this.txtAantalGetallen.Name = "txtAantalGetallen";
            this.txtAantalGetallen.Size = new System.Drawing.Size(100, 22);
            this.txtAantalGetallen.TabIndex = 2;
            // 
            // txtSom
            // 
            this.txtSom.Location = new System.Drawing.Point(189, 287);
            this.txtSom.Name = "txtSom";
            this.txtSom.Size = new System.Drawing.Size(100, 22);
            this.txtSom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eerste getal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aantal getallen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Som";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 434);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSom);
            this.Controls.Add(this.txtAantalGetallen);
            this.Controls.Add(this.txtEersteGetal);
            this.Controls.Add(this.btnTelOP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTelOP;
        private System.Windows.Forms.TextBox txtEersteGetal;
        private System.Windows.Forms.TextBox txtAantalGetallen;
        private System.Windows.Forms.TextBox txtSom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

