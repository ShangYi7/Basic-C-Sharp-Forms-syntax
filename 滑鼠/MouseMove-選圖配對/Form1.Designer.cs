namespace MouseMove
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
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.lb2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            this.SuspendLayout();
            // 
            // pic2
            // 
            this.pic2.Image = global::MouseMove.Properties.Resources.cat1;
            this.pic2.Location = new System.Drawing.Point(380, 227);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(60, 60);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::MouseMove.Properties.Resources.水庫;
            this.pic1.Location = new System.Drawing.Point(380, 100);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(60, 60);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 4;
            this.pic1.TabStop = false;
            // 
            // image1
            // 
            this.image1.Image = global::MouseMove.Properties.Resources.cat1;
            this.image1.Location = new System.Drawing.Point(112, 100);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(60, 60);
            this.image1.TabIndex = 3;
            this.image1.TabStop = false;
            this.image1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.image1_MouseDoubleClick);
            this.image1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.image1_MouseDown);
            this.image1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.image1_MouseMove);
            this.image1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.image1_MouseUp);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(217, 349);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(33, 12);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "label1";
            // 
            // p4
            // 
            this.p4.Image = global::MouseMove.Properties.Resources.水庫;
            this.p4.Location = new System.Drawing.Point(112, 245);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(60, 60);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 7;
            this.p4.TabStop = false;
            this.p4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.p4_MouseDoubleClick);
            this.p4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p4_MouseDown);
            this.p4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p4_MouseMove);
            this.p4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p4_MouseUp);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(200, 29);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(20, 12);
            this.lb2.TabIndex = 8;
            this.lb2.Text = "lb2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 477);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.image1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.Label lb2;
    }
}

