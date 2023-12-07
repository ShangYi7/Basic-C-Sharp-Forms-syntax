namespace Bulls_and_Cows
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            max = new Label();
            min = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 35);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "最大值";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 64);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "最小值";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 2;
            // 
            // max
            // 
            max.AutoSize = true;
            max.Location = new Point(140, 35);
            max.Name = "max";
            max.Size = new Size(28, 15);
            max.TabIndex = 3;
            max.Text = "100";
            // 
            // min
            // 
            min.AutoSize = true;
            min.Location = new Point(140, 64);
            min.Name = "min";
            min.Size = new Size(14, 15);
            min.TabIndex = 4;
            min.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 136);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Error/Ans:";
            // 
            // button1
            // 
            button1.Location = new Point(60, 129);
            button1.Name = "button1";
            button1.Size = new Size(88, 24);
            button1.TabIndex = 6;
            button1.Text = "確定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(60, 159);
            button2.Name = "button2";
            button2.Size = new Size(88, 24);
            button2.TabIndex = 7;
            button2.Text = "開始/重新";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 192);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(min);
            Controls.Add(max);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label max;
        private Label min;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}