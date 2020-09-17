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
            this.btnColorTspr = new System.Windows.Forms.Button();
            this.cldColorTspr = new System.Windows.Forms.ColorDialog();
            this.cbxScreenSizeTspr = new System.Windows.Forms.CheckBox();
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
            // btnColorTspr
            // 
            this.btnColorTspr.Location = new System.Drawing.Point(12, 41);
            this.btnColorTspr.Name = "btnColorTspr";
            this.btnColorTspr.Size = new System.Drawing.Size(181, 23);
            this.btnColorTspr.TabIndex = 2;
            this.btnColorTspr.Text = "Color";
            this.btnColorTspr.UseVisualStyleBackColor = true;
            this.btnColorTspr.Click += new System.EventHandler(this.btnColorTspr_Click);
            // 
            // cbxScreenSizeTspr
            // 
            this.cbxScreenSizeTspr.AutoSize = true;
            this.cbxScreenSizeTspr.Location = new System.Drawing.Point(200, 17);
            this.cbxScreenSizeTspr.Name = "cbxScreenSizeTspr";
            this.cbxScreenSizeTspr.Size = new System.Drawing.Size(15, 14);
            this.cbxScreenSizeTspr.TabIndex = 3;
            this.cbxScreenSizeTspr.UseVisualStyleBackColor = true;
            this.cbxScreenSizeTspr.CheckedChanged += new System.EventHandler(this.cbxScreenSizeTspr_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 72);
            this.Controls.Add(this.cbxScreenSizeTspr);
            this.Controls.Add(this.btnColorTspr);
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
        private System.Windows.Forms.Button btnColorTspr;
        private System.Windows.Forms.ColorDialog cldColorTspr;
        private System.Windows.Forms.CheckBox cbxScreenSizeTspr;
    }
}

