namespace _6_40_Textlist
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.butYes = new System.Windows.Forms.Button();
            this.butNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(14, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 169);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(372, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 169);
            this.listBox2.TabIndex = 1;
            // 
            // butYes
            // 
            this.butYes.Location = new System.Drawing.Point(235, 38);
            this.butYes.Name = "butYes";
            this.butYes.Size = new System.Drawing.Size(99, 39);
            this.butYes.TabIndex = 2;
            this.butYes.Text = "選取";
            this.butYes.UseVisualStyleBackColor = true;
            this.butYes.Click += new System.EventHandler(this.butYes_Click);
            // 
            // butNo
            // 
            this.butNo.Location = new System.Drawing.Point(235, 168);
            this.butNo.Name = "butNo";
            this.butNo.Size = new System.Drawing.Size(99, 39);
            this.butNo.TabIndex = 3;
            this.butNo.Text = "取消";
            this.butNo.UseVisualStyleBackColor = true;
            this.butNo.Click += new System.EventHandler(this.butNo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butNo);
            this.Controls.Add(this.butYes);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button butYes;
        private Button butNo;
    }
}