namespace CheckStu
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
            this.LblMsg = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMsg
            // 
            this.LblMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(33, 76);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(224, 32);
            this.LblMsg.TabIndex = 19;
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnOk.Location = new System.Drawing.Point(185, 28);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 24);
            this.BtnOk.TabIndex = 18;
            this.BtnOk.Text = "確定";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtId.Location = new System.Drawing.Point(81, 28);
            this.TxtId.MaxLength = 4;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(88, 25);
            this.TxtId.TabIndex = 17;
            this.TxtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtId_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "學號：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "學生姓名查詢";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblMsg;
        internal System.Windows.Forms.Button BtnOk;
        internal System.Windows.Forms.TextBox TxtId;
        internal System.Windows.Forms.Label label1;
    }
}

