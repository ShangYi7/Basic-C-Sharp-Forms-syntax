namespace Tank
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PicFire = new System.Windows.Forms.PictureBox();
            this.PicTank = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTank)).BeginInit();
            this.SuspendLayout();
            // 
            // PicFire
            // 
            this.PicFire.BackColor = System.Drawing.SystemColors.Control;
            this.PicFire.Location = new System.Drawing.Point(227, 205);
            this.PicFire.Name = "PicFire";
            this.PicFire.Size = new System.Drawing.Size(50, 50);
            this.PicFire.TabIndex = 6;
            this.PicFire.TabStop = false;
            // 
            // PicTank
            // 
            this.PicTank.Location = new System.Drawing.Point(54, 107);
            this.PicTank.Name = "PicTank";
            this.PicTank.Size = new System.Drawing.Size(60, 60);
            this.PicTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTank.TabIndex = 5;
            this.PicTank.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PicFire);
            this.Controls.Add(this.PicTank);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PicFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicFire;
        private System.Windows.Forms.PictureBox PicTank;
    }
}

