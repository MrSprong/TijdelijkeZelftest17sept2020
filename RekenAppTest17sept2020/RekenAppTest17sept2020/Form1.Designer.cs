namespace RekenAppTest17sept2020
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
            this.btnGoTspr = new System.Windows.Forms.Button();
            this.txbTextTspr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoTspr
            // 
            this.btnGoTspr.Location = new System.Drawing.Point(12, 12);
            this.btnGoTspr.Name = "btnGoTspr";
            this.btnGoTspr.Size = new System.Drawing.Size(75, 23);
            this.btnGoTspr.TabIndex = 0;
            this.btnGoTspr.Text = "Go";
            this.btnGoTspr.UseVisualStyleBackColor = true;
            this.btnGoTspr.Click += new System.EventHandler(this.btnGoTspr_Click);
            // 
            // txbTextTspr
            // 
            this.txbTextTspr.Location = new System.Drawing.Point(93, 14);
            this.txbTextTspr.Name = "txbTextTspr";
            this.txbTextTspr.Size = new System.Drawing.Size(100, 20);
            this.txbTextTspr.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(354, 97);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbTextTspr);
            this.Controls.Add(this.btnGoTspr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoTspr;
        private System.Windows.Forms.TextBox txbTextTspr;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

