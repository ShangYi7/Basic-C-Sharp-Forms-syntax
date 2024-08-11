namespace KeyPress2
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
            this.TxtRed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLowercase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt0To9 = new System.Windows.Forms.TextBox();
            this.TxtClear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtRed
            // 
            this.TxtRed.Location = new System.Drawing.Point(41, 24);
            this.TxtRed.Multiline = true;
            this.TxtRed.Name = "TxtRed";
            this.TxtRed.Size = new System.Drawing.Size(200, 30);
            this.TxtRed.TabIndex = 2;
            this.TxtRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRed_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "按 Ctrl + R 文字設為紅色";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "只能輸入小寫英文字母";
            // 
            // TxtLowercase
            // 
            this.TxtLowercase.Location = new System.Drawing.Point(41, 149);
            this.TxtLowercase.Multiline = true;
            this.TxtLowercase.Name = "TxtLowercase";
            this.TxtLowercase.Size = new System.Drawing.Size(200, 30);
            this.TxtLowercase.TabIndex = 4;
            this.TxtLowercase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLowercase_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "只能輸入0~9字元";
            // 
            // Txt0To9
            // 
            this.Txt0To9.Location = new System.Drawing.Point(41, 87);
            this.Txt0To9.Multiline = true;
            this.Txt0To9.Name = "Txt0To9";
            this.Txt0To9.Size = new System.Drawing.Size(200, 30);
            this.Txt0To9.TabIndex = 5;
            this.Txt0To9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt0To9_KeyPress);
            // 
            // TxtClear
            // 
            this.TxtClear.Location = new System.Drawing.Point(41, 216);
            this.TxtClear.Multiline = true;
            this.TxtClear.Name = "TxtClear";
            this.TxtClear.Size = new System.Drawing.Size(200, 30);
            this.TxtClear.TabIndex = 4;
            this.TxtClear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClear_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "按 Enter 鍵清除文字";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtLowercase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt0To9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLowercase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt0To9;
        private System.Windows.Forms.TextBox TxtClear;
        private System.Windows.Forms.Label label4;
    }
}

