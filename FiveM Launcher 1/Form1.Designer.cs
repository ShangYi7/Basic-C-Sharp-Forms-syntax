namespace FiveM_Launcher_1
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Discord_link = new System.Windows.Forms.Button();
            this.Join_Server = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 308);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Discord_link
            // 
            this.Discord_link.Location = new System.Drawing.Point(12, 341);
            this.Discord_link.Name = "Discord_link";
            this.Discord_link.Size = new System.Drawing.Size(129, 46);
            this.Discord_link.TabIndex = 1;
            this.Discord_link.Text = "Discord";
            this.Discord_link.UseVisualStyleBackColor = true;
            this.Discord_link.Click += new System.EventHandler(this.Discord_link_Click);
            // 
            // Join_Server
            // 
            this.Join_Server.Location = new System.Drawing.Point(633, 341);
            this.Join_Server.Name = "Join_Server";
            this.Join_Server.Size = new System.Drawing.Size(129, 46);
            this.Join_Server.TabIndex = 2;
            this.Join_Server.Text = "Fivem";
            this.Join_Server.UseVisualStyleBackColor = true;
            this.Join_Server.Click += new System.EventHandler(this.Join_Server_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 399);
            this.Controls.Add(this.Join_Server);
            this.Controls.Add(this.Discord_link);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Y.A.X.S Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Discord_link;
        private System.Windows.Forms.Button Join_Server;
    }
}

