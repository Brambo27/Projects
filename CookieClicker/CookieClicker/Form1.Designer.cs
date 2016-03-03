namespace CookieClicker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnUpgrade1 = new System.Windows.Forms.Button();
            this.lblUpgrade1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 200);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cookies:";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Enabled = false;
            this.btnUpgrade.Location = new System.Drawing.Point(12, 12);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(213, 23);
            this.btnUpgrade.TabIndex = 3;
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(231, 15);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(120, 17);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost: 100 cookies";
            // 
            // btnUpgrade1
            // 
            this.btnUpgrade1.Location = new System.Drawing.Point(12, 42);
            this.btnUpgrade1.Name = "btnUpgrade1";
            this.btnUpgrade1.Size = new System.Drawing.Size(213, 23);
            this.btnUpgrade1.TabIndex = 5;
            this.btnUpgrade1.UseVisualStyleBackColor = true;
            this.btnUpgrade1.Click += new System.EventHandler(this.btnUpgrade1_Click);
            // 
            // lblUpgrade1
            // 
            this.lblUpgrade1.AutoSize = true;
            this.lblUpgrade1.Location = new System.Drawing.Point(231, 45);
            this.lblUpgrade1.Name = "lblUpgrade1";
            this.lblUpgrade1.Size = new System.Drawing.Size(112, 17);
            this.lblUpgrade1.TabIndex = 6;
            this.lblUpgrade1.Text = "Cost: 10 cookies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 558);
            this.Controls.Add(this.lblUpgrade1);
            this.Controls.Add(this.btnUpgrade1);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnUpgrade1;
        private System.Windows.Forms.Label lblUpgrade1;
    }
}

