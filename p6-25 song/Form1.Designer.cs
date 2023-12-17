namespace p6_25_song
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
            this.BtnName = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnSortno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnName
            // 
            this.BtnName.Location = new System.Drawing.Point(351, 70);
            this.BtnName.Name = "BtnName";
            this.BtnName.Size = new System.Drawing.Size(96, 37);
            this.BtnName.TabIndex = 1;
            this.BtnName.Text = "名字排序";
            this.BtnName.UseVisualStyleBackColor = true;
            this.BtnName.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(351, 156);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(96, 37);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "歌曲搜尋";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(333, 195);
            this.textBox2.TabIndex = 4;
            // 
            // BtnSortno
            // 
            this.BtnSortno.Location = new System.Drawing.Point(351, 27);
            this.BtnSortno.Name = "BtnSortno";
            this.BtnSortno.Size = new System.Drawing.Size(96, 37);
            this.BtnSortno.TabIndex = 5;
            this.BtnSortno.Text = "排名排序";
            this.BtnSortno.UseVisualStyleBackColor = true;
            this.BtnSortno.Click += new System.EventHandler(this.BtnSortno_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "歌曲搜尋";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSortno);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnName;
        private Button BtnSearch;
        private TextBox textBox1;
        private ListBox listBox1;
        private TextBox textBox2;
        private Button BtnSortno;
        private Button button2;
    }
}