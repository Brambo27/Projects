namespace Verbruik_Auto
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
            this.btnBereken = new System.Windows.Forms.Button();
            this.lblBkilo = new System.Windows.Forms.Label();
            this.lblEkilo = new System.Windows.Forms.Label();
            this.lblLiter = new System.Windows.Forms.Label();
            this.lblKiloLiter = new System.Windows.Forms.Label();
            this.txtBkilo = new System.Windows.Forms.TextBox();
            this.txtEkilo = new System.Windows.Forms.TextBox();
            this.txtLiter = new System.Windows.Forms.TextBox();
            this.txtUitkomst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(189, 207);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 0;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblBkilo
            // 
            this.lblBkilo.AutoSize = true;
            this.lblBkilo.Location = new System.Drawing.Point(41, 55);
            this.lblBkilo.Name = "lblBkilo";
            this.lblBkilo.Size = new System.Drawing.Size(143, 17);
            this.lblBkilo.TabIndex = 1;
            this.lblBkilo.Text = "Begin-Kilometerstand";
            // 
            // lblEkilo
            // 
            this.lblEkilo.AutoSize = true;
            this.lblEkilo.Location = new System.Drawing.Point(41, 97);
            this.lblEkilo.Name = "lblEkilo";
            this.lblEkilo.Size = new System.Drawing.Size(135, 17);
            this.lblEkilo.TabIndex = 2;
            this.lblEkilo.Text = "Eind-Kilometerstand";
            // 
            // lblLiter
            // 
            this.lblLiter.AutoSize = true;
            this.lblLiter.Location = new System.Drawing.Point(41, 143);
            this.lblLiter.Name = "lblLiter";
            this.lblLiter.Size = new System.Drawing.Size(133, 17);
            this.lblLiter.TabIndex = 3;
            this.lblLiter.Text = "Aantal liters getankt";
            // 
            // lblKiloLiter
            // 
            this.lblKiloLiter.AutoSize = true;
            this.lblKiloLiter.Location = new System.Drawing.Point(41, 262);
            this.lblKiloLiter.Name = "lblKiloLiter";
            this.lblKiloLiter.Size = new System.Drawing.Size(161, 17);
            this.lblKiloLiter.TabIndex = 4;
            this.lblKiloLiter.Text = "Aantal kilometer per liter";
            // 
            // txtBkilo
            // 
            this.txtBkilo.Location = new System.Drawing.Point(262, 55);
            this.txtBkilo.Name = "txtBkilo";
            this.txtBkilo.Size = new System.Drawing.Size(100, 22);
            this.txtBkilo.TabIndex = 5;
            // 
            // txtEkilo
            // 
            this.txtEkilo.Location = new System.Drawing.Point(262, 97);
            this.txtEkilo.Name = "txtEkilo";
            this.txtEkilo.Size = new System.Drawing.Size(100, 22);
            this.txtEkilo.TabIndex = 6;
            // 
            // txtLiter
            // 
            this.txtLiter.Location = new System.Drawing.Point(262, 137);
            this.txtLiter.Name = "txtLiter";
            this.txtLiter.Size = new System.Drawing.Size(100, 22);
            this.txtLiter.TabIndex = 7;
            // 
            // txtUitkomst
            // 
            this.txtUitkomst.Location = new System.Drawing.Point(262, 256);
            this.txtUitkomst.Name = "txtUitkomst";
            this.txtUitkomst.Size = new System.Drawing.Size(100, 22);
            this.txtUitkomst.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 522);
            this.Controls.Add(this.txtUitkomst);
            this.Controls.Add(this.txtLiter);
            this.Controls.Add(this.txtEkilo);
            this.Controls.Add(this.txtBkilo);
            this.Controls.Add(this.lblKiloLiter);
            this.Controls.Add(this.lblLiter);
            this.Controls.Add(this.lblEkilo);
            this.Controls.Add(this.lblBkilo);
            this.Controls.Add(this.btnBereken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblBkilo;
        private System.Windows.Forms.Label lblEkilo;
        private System.Windows.Forms.Label lblLiter;
        private System.Windows.Forms.Label lblKiloLiter;
        private System.Windows.Forms.TextBox txtBkilo;
        private System.Windows.Forms.TextBox txtEkilo;
        private System.Windows.Forms.TextBox txtLiter;
        private System.Windows.Forms.TextBox txtUitkomst;
    }
}

