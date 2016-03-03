namespace WindowsFormsApplication1
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
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblHoog = new System.Windows.Forms.Label();
            this.lblLeng = new System.Windows.Forms.Label();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtHoogt = new System.Windows.Forms.TextBox();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.txtUitkomst = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(337, 187);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 0;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(67, 151);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(50, 17);
            this.lblBreed.TabIndex = 1;
            this.lblBreed.Text = "Breete";
            // 
            // lblHoog
            // 
            this.lblHoog.AutoSize = true;
            this.lblHoog.Location = new System.Drawing.Point(67, 190);
            this.lblHoog.Name = "lblHoog";
            this.lblHoog.Size = new System.Drawing.Size(54, 17);
            this.lblHoog.TabIndex = 2;
            this.lblHoog.Text = "Hoogte";
            // 
            // lblLeng
            // 
            this.lblLeng.AutoSize = true;
            this.lblLeng.Location = new System.Drawing.Point(67, 228);
            this.lblLeng.Name = "lblLeng";
            this.lblLeng.Size = new System.Drawing.Size(52, 17);
            this.lblLeng.TabIndex = 3;
            this.lblLeng.Text = "Lengte";
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(168, 151);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(100, 22);
            this.txtBreed.TabIndex = 4;
            // 
            // txtHoogt
            // 
            this.txtHoogt.Location = new System.Drawing.Point(168, 185);
            this.txtHoogt.Name = "txtHoogt";
            this.txtHoogt.Size = new System.Drawing.Size(100, 22);
            this.txtHoogt.TabIndex = 5;
            // 
            // txtLeng
            // 
            this.txtLeng.Location = new System.Drawing.Point(168, 223);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(100, 22);
            this.txtLeng.TabIndex = 6;
            // 
            // txtUitkomst
            // 
            this.txtUitkomst.Location = new System.Drawing.Point(500, 188);
            this.txtUitkomst.Name = "txtUitkomst";
            this.txtUitkomst.ReadOnly = true;
            this.txtUitkomst.Size = new System.Drawing.Size(100, 22);
            this.txtUitkomst.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Balk",
            "Cilinder",
            "Piramide",
            "Kegel"});
            this.comboBox1.Location = new System.Drawing.Point(70, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 470);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtUitkomst);
            this.Controls.Add(this.txtLeng);
            this.Controls.Add(this.txtHoogt);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.lblLeng);
            this.Controls.Add(this.lblHoog);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.btnBereken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblHoog;
        private System.Windows.Forms.Label lblLeng;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.TextBox txtHoogt;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.TextBox txtUitkomst;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

