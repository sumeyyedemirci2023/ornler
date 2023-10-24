namespace sinav
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
            this.rbTek = new System.Windows.Forms.RadioButton();
            this.rbCift = new System.Windows.Forms.RadioButton();
            this.lstSayi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbTek
            // 
            this.rbTek.AutoSize = true;
            this.rbTek.Location = new System.Drawing.Point(171, 47);
            this.rbTek.Name = "rbTek";
            this.rbTek.Size = new System.Drawing.Size(46, 17);
            this.rbTek.TabIndex = 1;
            this.rbTek.TabStop = true;
            this.rbTek.Text = "TEK";
            this.rbTek.UseVisualStyleBackColor = true;
            // 
            // rbCift
            // 
            this.rbCift.AutoSize = true;
            this.rbCift.Location = new System.Drawing.Point(169, 104);
            this.rbCift.Name = "rbCift";
            this.rbCift.Size = new System.Drawing.Size(48, 17);
            this.rbCift.TabIndex = 2;
            this.rbCift.TabStop = true;
            this.rbCift.Text = "ÇİFT";
            this.rbCift.UseVisualStyleBackColor = true;
            // 
            // lstSayi
            // 
            this.lstSayi.FormattingEnabled = true;
            this.lstSayi.Location = new System.Drawing.Point(309, 23);
            this.lstSayi.Name = "lstSayi";
            this.lstSayi.Size = new System.Drawing.Size(120, 160);
            this.lstSayi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 227);
            this.Controls.Add(this.lstSayi);
            this.Controls.Add(this.rbCift);
            this.Controls.Add(this.rbTek);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbTek;
        private System.Windows.Forms.RadioButton rbCift;
        private System.Windows.Forms.ListBox lstSayi;
    }
}

