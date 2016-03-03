namespace EuroBiljetten
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
            this.txtInvoer = new System.Windows.Forms.TextBox();
            this.lblGeld = new System.Windows.Forms.Label();
            this.txtVijftig = new System.Windows.Forms.TextBox();
            this.txtTwintig = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtVijf = new System.Windows.Forms.TextBox();
            this.txtOver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInvoer
            // 
            this.txtInvoer.Location = new System.Drawing.Point(234, 10);
            this.txtInvoer.Name = "txtInvoer";
            this.txtInvoer.Size = new System.Drawing.Size(100, 22);
            this.txtInvoer.TabIndex = 0;
            this.txtInvoer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblGeld
            // 
            this.lblGeld.AutoSize = true;
            this.lblGeld.Location = new System.Drawing.Point(12, 13);
            this.lblGeld.Name = "lblGeld";
            this.lblGeld.Size = new System.Drawing.Size(183, 17);
            this.lblGeld.TabIndex = 1;
            this.lblGeld.Text = "Voer bedrag onder €200 in.";
            // 
            // txtVijftig
            // 
            this.txtVijftig.Location = new System.Drawing.Point(234, 109);
            this.txtVijftig.Name = "txtVijftig";
            this.txtVijftig.Size = new System.Drawing.Size(100, 22);
            this.txtVijftig.TabIndex = 2;
            // 
            // txtTwintig
            // 
            this.txtTwintig.Location = new System.Drawing.Point(234, 138);
            this.txtTwintig.Name = "txtTwintig";
            this.txtTwintig.Size = new System.Drawing.Size(100, 22);
            this.txtTwintig.TabIndex = 3;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(234, 167);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(100, 22);
            this.txtTien.TabIndex = 4;
            // 
            // txtVijf
            // 
            this.txtVijf.Location = new System.Drawing.Point(234, 196);
            this.txtVijf.Name = "txtVijf";
            this.txtVijf.Size = new System.Drawing.Size(100, 22);
            this.txtVijf.TabIndex = 5;
            // 
            // txtOver
            // 
            this.txtOver.Location = new System.Drawing.Point(234, 255);
            this.txtOver.Name = "txtOver";
            this.txtOver.Size = new System.Drawing.Size(100, 22);
            this.txtOver.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "€50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "€20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "€10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "€5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Geld over:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 355);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOver);
            this.Controls.Add(this.txtVijf);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.txtTwintig);
            this.Controls.Add(this.txtVijftig);
            this.Controls.Add(this.lblGeld);
            this.Controls.Add(this.txtInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoer;
        private System.Windows.Forms.Label lblGeld;
        private System.Windows.Forms.TextBox txtVijftig;
        private System.Windows.Forms.TextBox txtTwintig;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtVijf;
        private System.Windows.Forms.TextBox txtOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

