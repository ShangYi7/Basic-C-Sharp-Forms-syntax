namespace Linq01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.BtnAsc = new System.Windows.Forms.Button();
            this.btnDesc = new System.Windows.Forms.Button();
            this.BtnPass = new System.Windows.Forms.Button();
            this.BtnFail = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始資料";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "結果";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(40, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 284);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(338, 130);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(243, 284);
            this.listBox2.TabIndex = 3;
            // 
            // BtnAsc
            // 
            this.BtnAsc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAsc.Location = new System.Drawing.Point(629, 130);
            this.BtnAsc.Name = "BtnAsc";
            this.BtnAsc.Size = new System.Drawing.Size(173, 59);
            this.BtnAsc.TabIndex = 4;
            this.BtnAsc.Text = "遞增排序";
            this.BtnAsc.UseVisualStyleBackColor = true;
            this.BtnAsc.Click += new System.EventHandler(this.BtnAsc_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDesc.Location = new System.Drawing.Point(629, 195);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(173, 59);
            this.btnDesc.TabIndex = 5;
            this.btnDesc.Text = "遞減排序";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // BtnPass
            // 
            this.BtnPass.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPass.Location = new System.Drawing.Point(629, 260);
            this.BtnPass.Name = "BtnPass";
            this.BtnPass.Size = new System.Drawing.Size(173, 59);
            this.BtnPass.TabIndex = 6;
            this.BtnPass.Text = "及格分數";
            this.BtnPass.UseVisualStyleBackColor = true;
            this.BtnPass.Click += new System.EventHandler(this.BtnPass_Click);
            // 
            // BtnFail
            // 
            this.BtnFail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFail.Location = new System.Drawing.Point(629, 325);
            this.BtnFail.Name = "BtnFail";
            this.BtnFail.Size = new System.Drawing.Size(173, 59);
            this.BtnFail.TabIndex = 7;
            this.BtnFail.Text = "不及格分數";
            this.BtnFail.UseVisualStyleBackColor = true;
            this.BtnFail.Click += new System.EventHandler(this.BtnFail_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(629, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "平均";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(629, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 59);
            this.button2.TabIndex = 9;
            this.button2.Text = "最大";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(629, 520);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 59);
            this.button3.TabIndex = 10;
            this.button3.Text = "最小";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnFail);
            this.Controls.Add(this.BtnPass);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.BtnAsc);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button BtnAsc;
        private Button btnDesc;
        private Button BtnPass;
        private Button BtnFail;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}