namespace FontDialog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.BtnFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtShow
            // 
            this.TxtShow.Location = new System.Drawing.Point(12, 12);
            this.TxtShow.Multiline = true;
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.Size = new System.Drawing.Size(240, 60);
            this.TxtShow.TabIndex = 0;
            // 
            // BtnFont
            // 
            this.BtnFont.Location = new System.Drawing.Point(258, 49);
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Size = new System.Drawing.Size(75, 23);
            this.BtnFont.TabIndex = 1;
            this.BtnFont.Text = "字型";
            this.BtnFont.UseVisualStyleBackColor = true;
            this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "顏色";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 85);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnFont);
            this.Controls.Add(this.TxtShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtShow;
        private Button BtnFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private Button button1;
    }
}