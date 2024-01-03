namespace p6_47_CheckedListBox
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
            this.components = new System.ComponentModel.Container();
            this.ClstBorrow = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnBorrow = new System.Windows.Forms.Button();
            this.ClstBooks = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ClstBorrow
            // 
            this.ClstBorrow.FormattingEnabled = true;
            this.ClstBorrow.Location = new System.Drawing.Point(221, 34);
            this.ClstBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.ClstBorrow.Name = "ClstBorrow";
            this.ClstBorrow.Size = new System.Drawing.Size(116, 76);
            this.ClstBorrow.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "借書：";
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(137, 88);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(71, 22);
            this.BtnReturn.TabIndex = 9;
            this.BtnReturn.Text = "<<取消<<";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnBorrow
            // 
            this.BtnBorrow.Location = new System.Drawing.Point(137, 34);
            this.BtnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBorrow.Name = "BtnBorrow";
            this.BtnBorrow.Size = new System.Drawing.Size(71, 22);
            this.BtnBorrow.TabIndex = 8;
            this.BtnBorrow.Text = ">>借閱>>";
            this.BtnBorrow.UseVisualStyleBackColor = true;
            this.BtnBorrow.Click += new System.EventHandler(this.BtnBorrow_Click);
            // 
            // ClstBooks
            // 
            this.ClstBooks.FormattingEnabled = true;
            this.ClstBooks.Location = new System.Drawing.Point(11, 34);
            this.ClstBooks.Margin = new System.Windows.Forms.Padding(2);
            this.ClstBooks.Name = "ClstBooks";
            this.ClstBooks.Size = new System.Drawing.Size(116, 76);
            this.ClstBooks.TabIndex = 7;
            this.ClstBooks.SelectedIndexChanged += new System.EventHandler(this.ClstBooks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "書目：";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClstBorrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnBorrow);
            this.Controls.Add(this.ClstBooks);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox ClstBorrow;
        private Label label2;
        private Button BtnReturn;
        private Button BtnBorrow;
        private CheckedListBox ClstBooks;
        private Label label1;
        private ToolTip toolTip1;
    }
}