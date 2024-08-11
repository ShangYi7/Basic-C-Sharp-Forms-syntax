namespace ColorDialog
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
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.Pic3 = new System.Windows.Forms.PictureBox();
            this.Pic4 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Pic5 = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic1
            // 
            this.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic1.Location = new System.Drawing.Point(186, 67);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(200, 200);
            this.Pic1.TabIndex = 0;
            this.Pic1.TabStop = false;
            this.Pic1.Click += new System.EventHandler(this.Pic1_Click);
            // 
            // Pic2
            // 
            this.Pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic2.Location = new System.Drawing.Point(211, 92);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(150, 150);
            this.Pic2.TabIndex = 0;
            this.Pic2.TabStop = false;
            // 
            // Pic3
            // 
            this.Pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic3.Location = new System.Drawing.Point(236, 117);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(100, 100);
            this.Pic3.TabIndex = 0;
            this.Pic3.TabStop = false;
            // 
            // Pic4
            // 
            this.Pic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic4.Location = new System.Drawing.Point(261, 142);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(50, 50);
            this.Pic4.TabIndex = 0;
            this.Pic4.TabStop = false;
            // 
            // Pic5
            // 
            this.Pic5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic5.Location = new System.Drawing.Point(499, 246);
            this.Pic5.Name = "Pic5";
            this.Pic5.Size = new System.Drawing.Size(100, 100);
            this.Pic5.TabIndex = 1;
            this.Pic5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pic4);
            this.Controls.Add(this.Pic3);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.Pic5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Pic1;
        private PictureBox Pic2;
        private PictureBox Pic3;
        private PictureBox Pic4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private PictureBox Pic5;
        private FontDialog fontDialog1;
        private Label label1;
    }
}