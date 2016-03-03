namespace _41.Optellen_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSom = new System.Windows.Forms.TextBox();
            this.txtOpgeteld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 162);
            this.button1.TabIndex = 0;
            this.button1.Text = "Optellen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSom
            // 
            this.txtSom.Location = new System.Drawing.Point(203, 284);
            this.txtSom.Name = "txtSom";
            this.txtSom.Size = new System.Drawing.Size(100, 22);
            this.txtSom.TabIndex = 1;
            // 
            // txtOpgeteld
            // 
            this.txtOpgeteld.Location = new System.Drawing.Point(345, 284);
            this.txtOpgeteld.Name = "txtOpgeteld";
            this.txtOpgeteld.Size = new System.Drawing.Size(100, 22);
            this.txtOpgeteld.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Som";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aantal getallen opgeteld";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpgeteld);
            this.Controls.Add(this.txtSom);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSom;
        private System.Windows.Forms.TextBox txtOpgeteld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

