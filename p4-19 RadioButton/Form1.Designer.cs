namespace p4_19
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
            groupBox1 = new GroupBox();
            radiRMB = new RadioButton();
            radiJP = new RadioButton();
            radiUSD = new RadioButton();
            textBox1 = new TextBox();
            tool = new Label();
            But_confirm = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radiRMB);
            groupBox1.Controls.Add(radiJP);
            groupBox1.Controls.Add(radiUSD);
            groupBox1.Location = new Point(25, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(139, 106);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "貨幣種類";
            // 
            // radiRMB
            // 
            radiRMB.AutoSize = true;
            radiRMB.Location = new Point(8, 82);
            radiRMB.Name = "radiRMB";
            radiRMB.Size = new Size(49, 19);
            radiRMB.TabIndex = 2;
            radiRMB.TabStop = true;
            radiRMB.Text = "匪必";
            radiRMB.UseVisualStyleBackColor = true;
            radiRMB.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radiJP
            // 
            radiJP.AutoSize = true;
            radiJP.Location = new Point(8, 60);
            radiJP.Name = "radiJP";
            radiJP.Size = new Size(49, 19);
            radiJP.TabIndex = 1;
            radiJP.TabStop = true;
            radiJP.Text = "日幣";
            radiJP.UseVisualStyleBackColor = true;
            // 
            // radiUSD
            // 
            radiUSD.AutoSize = true;
            radiUSD.Location = new Point(8, 35);
            radiUSD.Name = "radiUSD";
            radiUSD.Size = new Size(49, 19);
            radiUSD.TabIndex = 0;
            radiUSD.TabStop = true;
            radiUSD.Text = "美金";
            radiUSD.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tool
            // 
            tool.AutoSize = true;
            tool.Location = new Point(25, 186);
            tool.Name = "tool";
            tool.Size = new Size(0, 15);
            tool.TabIndex = 2;
            tool.UseMnemonic = false;
            // 
            // But_confirm
            // 
            But_confirm.Location = new Point(197, 127);
            But_confirm.Name = "But_confirm";
            But_confirm.Size = new Size(132, 46);
            But_confirm.TabIndex = 3;
            But_confirm.Text = "確認";
            But_confirm.UseVisualStyleBackColor = true;
            But_confirm.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 22);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "台幣";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 22);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 5;
            label3.Text = "元";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 252);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(But_confirm);
            Controls.Add(tool);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radiRMB;
        private RadioButton radiJP;
        private RadioButton radiUSD;
        private TextBox textBox1;
        private Label tool;
        private Button But_confirm;
        private Label label2;
        private Label label3;
    }
}