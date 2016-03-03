namespace WindowsFormsApplication2
{
    partial class Berekeningen
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.txtHoog = new System.Windows.Forms.TextBox();
            this.txtUitkomst = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Balk",
            "Cilinder",
            "Piramide",
            "Kegel"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.btnBereken_Click);
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(288, 206);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 1;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(133, 179);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(100, 22);
            this.txtBreed.TabIndex = 2;
            // 
            // txtLeng
            // 
            this.txtLeng.Location = new System.Drawing.Point(133, 207);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(100, 22);
            this.txtLeng.TabIndex = 3;
            // 
            // txtHoog
            // 
            this.txtHoog.Location = new System.Drawing.Point(133, 235);
            this.txtHoog.Name = "txtHoog";
            this.txtHoog.Size = new System.Drawing.Size(100, 22);
            this.txtHoog.TabIndex = 4;
            // 
            // txtUitkomst
            // 
            this.txtUitkomst.Location = new System.Drawing.Point(410, 207);
            this.txtUitkomst.Name = "txtUitkomst";
            this.txtUitkomst.Size = new System.Drawing.Size(100, 22);
            this.txtUitkomst.TabIndex = 5;
            // 
            // Berekeningen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 457);
            this.Controls.Add(this.txtUitkomst);
            this.Controls.Add(this.txtHoog);
            this.Controls.Add(this.txtLeng);
            this.Controls.Add(this.txtBreed);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.comboBox1);
            this.Name = "Berekeningen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.TextBox txtHoog;
        private System.Windows.Forms.TextBox txtUitkomst;
    }
}

