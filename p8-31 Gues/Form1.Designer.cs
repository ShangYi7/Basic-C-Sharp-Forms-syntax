namespace Gues
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PicPC = new System.Windows.Forms.PictureBox();
            this.LblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicPC)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(15, 12);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(70, 70);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "button1";
            this.Btn1.UseVisualStyleBackColor = true;
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(91, 12);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(70, 70);
            this.Btn2.TabIndex = 0;
            this.Btn2.Text = "button2";
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(167, 12);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(70, 70);
            this.Btn3.TabIndex = 0;
            this.Btn3.Text = "button3";
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "電腦：";
            // 
            // PicPC
            // 
            this.PicPC.Location = new System.Drawing.Point(56, 88);
            this.PicPC.Name = "PicPC";
            this.PicPC.Size = new System.Drawing.Size(70, 70);
            this.PicPC.TabIndex = 2;
            this.PicPC.TabStop = false;
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMsg.Location = new System.Drawing.Point(133, 94);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(54, 20);
            this.LblMsg.TabIndex = 3;
            this.LblMsg.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 165);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.PicPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Name = "Form1";
            this.Text = "猜拳遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Label label1;
        private PictureBox PicPC;
        private Label LblMsg;
    }
}