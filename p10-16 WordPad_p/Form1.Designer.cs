namespace WordPad
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmCut = new System.Windows.Forms.ToolStripMenuItem();
            this.復原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.項目符號ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmFColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MItmBColor = new System.Windows.Forms.ToolStripMenuItem();
            this.RtxtNote = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.剪下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMain.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MnuMain
            // 
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.編輯ToolStripMenuItem,
            this.項目符號ToolStripMenuItem,
            this.MnuFont,
            this.顏色ToolStripMenuItem1});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(465, 24);
            this.MnuMain.TabIndex = 0;
            this.MnuMain.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItmOpen,
            this.MItmSave,
            this.MItmClear,
            this.MItmExit});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // MItmOpen
            // 
            this.MItmOpen.Name = "MItmOpen";
            this.MItmOpen.Size = new System.Drawing.Size(98, 22);
            this.MItmOpen.Text = "開檔";
            this.MItmOpen.Click += new System.EventHandler(this.MItmOpen_Click);
            // 
            // MItmSave
            // 
            this.MItmSave.Name = "MItmSave";
            this.MItmSave.Size = new System.Drawing.Size(98, 22);
            this.MItmSave.Text = "存檔";
            this.MItmSave.Click += new System.EventHandler(this.MItmSave_Click);
            // 
            // MItmClear
            // 
            this.MItmClear.Name = "MItmClear";
            this.MItmClear.Size = new System.Drawing.Size(98, 22);
            this.MItmClear.Text = "清除";
            this.MItmClear.Click += new System.EventHandler(this.MItmClear_Click);
            // 
            // MItmExit
            // 
            this.MItmExit.Name = "MItmExit";
            this.MItmExit.Size = new System.Drawing.Size(98, 22);
            this.MItmExit.Text = "結束";
            this.MItmExit.Click += new System.EventHandler(this.MItmExit_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItmCopy,
            this.MItmPaste,
            this.MItmCut,
            this.復原ToolStripMenuItem,
            this.清除ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // MItmCopy
            // 
            this.MItmCopy.Name = "MItmCopy";
            this.MItmCopy.Size = new System.Drawing.Size(180, 22);
            this.MItmCopy.Text = "複製";
            this.MItmCopy.Click += new System.EventHandler(this.MItmCopy_Click);
            // 
            // MItmPaste
            // 
            this.MItmPaste.Name = "MItmPaste";
            this.MItmPaste.Size = new System.Drawing.Size(180, 22);
            this.MItmPaste.Text = "貼上";
            this.MItmPaste.Click += new System.EventHandler(this.MItmPaste_Click);
            // 
            // MItmCut
            // 
            this.MItmCut.Name = "MItmCut";
            this.MItmCut.Size = new System.Drawing.Size(180, 22);
            this.MItmCut.Text = "剪下";
            this.MItmCut.Click += new System.EventHandler(this.MItmCut_Click);
            // 
            // 復原ToolStripMenuItem
            // 
            this.復原ToolStripMenuItem.Name = "復原ToolStripMenuItem";
            this.復原ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.復原ToolStripMenuItem.Text = "復原";
            this.復原ToolStripMenuItem.Click += new System.EventHandler(this.復原ToolStripMenuItem_Click);
            // 
            // 清除ToolStripMenuItem
            // 
            this.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            this.清除ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.清除ToolStripMenuItem.Text = "清除";
            this.清除ToolStripMenuItem.Click += new System.EventHandler(this.清除ToolStripMenuItem_Click);
            // 
            // 項目符號ToolStripMenuItem
            // 
            this.項目符號ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItmSet,
            this.MItmCancel});
            this.項目符號ToolStripMenuItem.Name = "項目符號ToolStripMenuItem";
            this.項目符號ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.項目符號ToolStripMenuItem.Text = "項目符號";
            // 
            // MItmSet
            // 
            this.MItmSet.Name = "MItmSet";
            this.MItmSet.Size = new System.Drawing.Size(98, 22);
            this.MItmSet.Text = "設定";
            this.MItmSet.Click += new System.EventHandler(this.MItmSet_Click);
            // 
            // MItmCancel
            // 
            this.MItmCancel.Name = "MItmCancel";
            this.MItmCancel.Size = new System.Drawing.Size(98, 22);
            this.MItmCancel.Text = "取消";
            this.MItmCancel.Click += new System.EventHandler(this.MItmCancel_Click);
            // 
            // MnuFont
            // 
            this.MnuFont.Name = "MnuFont";
            this.MnuFont.Size = new System.Drawing.Size(43, 20);
            this.MnuFont.Text = "字型";
            this.MnuFont.Click += new System.EventHandler(this.MnuFont_Click);
            // 
            // 顏色ToolStripMenuItem1
            // 
            this.顏色ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItmFColor,
            this.MItmBColor});
            this.顏色ToolStripMenuItem1.Name = "顏色ToolStripMenuItem1";
            this.顏色ToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.顏色ToolStripMenuItem1.Text = "顏色";
            // 
            // MItmFColor
            // 
            this.MItmFColor.Name = "MItmFColor";
            this.MItmFColor.Size = new System.Drawing.Size(110, 22);
            this.MItmFColor.Text = "前景色";
            this.MItmFColor.Click += new System.EventHandler(this.MItmFColor_Click);
            // 
            // MItmBColor
            // 
            this.MItmBColor.Name = "MItmBColor";
            this.MItmBColor.Size = new System.Drawing.Size(110, 22);
            this.MItmBColor.Text = "背景色";
            this.MItmBColor.Click += new System.EventHandler(this.MItmBColor_Click);
            // 
            // RtxtNote
            // 
            this.RtxtNote.ContextMenuStrip = this.contextMenuStrip1;
            this.RtxtNote.Location = new System.Drawing.Point(0, 27);
            this.RtxtNote.Name = "RtxtNote";
            this.RtxtNote.Size = new System.Drawing.Size(465, 329);
            this.RtxtNote.TabIndex = 1;
            this.RtxtNote.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪下ToolStripMenuItem,
            this.貼上ToolStripMenuItem,
            this.字型ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // 剪下ToolStripMenuItem
            // 
            this.剪下ToolStripMenuItem.Name = "剪下ToolStripMenuItem";
            this.剪下ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.剪下ToolStripMenuItem.Text = "剪下";
            this.剪下ToolStripMenuItem.Click += new System.EventHandler(this.剪下ToolStripMenuItem_Click);
            // 
            // 貼上ToolStripMenuItem
            // 
            this.貼上ToolStripMenuItem.Name = "貼上ToolStripMenuItem";
            this.貼上ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.貼上ToolStripMenuItem.Text = "貼上";
            this.貼上ToolStripMenuItem.Click += new System.EventHandler(this.貼上ToolStripMenuItem_Click);
            // 
            // 字型ToolStripMenuItem
            // 
            this.字型ToolStripMenuItem.Name = "字型ToolStripMenuItem";
            this.字型ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.字型ToolStripMenuItem.Text = "字型";
            this.字型ToolStripMenuItem.Click += new System.EventHandler(this.字型ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 368);
            this.Controls.Add(this.RtxtNote);
            this.Controls.Add(this.MnuMain);
            this.MainMenuStrip = this.MnuMain;
            this.Name = "Form1";
            this.Text = "WordPad";
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private MenuStrip MnuMain;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem MItmOpen;
        private ToolStripMenuItem MItmSave;
        private ToolStripMenuItem MItmExit;
        private ToolStripMenuItem 編輯ToolStripMenuItem;
        private ToolStripMenuItem MItmCopy;
        private ToolStripMenuItem MItmPaste;
        private ToolStripMenuItem 項目符號ToolStripMenuItem;
        private ToolStripMenuItem MItmSet;
        private ToolStripMenuItem MItmCancel;
        private ToolStripMenuItem MnuFont;
        private ToolStripMenuItem 顏色ToolStripMenuItem1;
        private ToolStripMenuItem MItmFColor;
        private ToolStripMenuItem MItmBColor;
        private RichTextBox RtxtNote;
        private ToolStripMenuItem MItmClear;
        private ToolStripMenuItem MItmCut;
        private ToolStripMenuItem 復原ToolStripMenuItem;
        private ToolStripMenuItem 清除ToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 剪下ToolStripMenuItem;
        private ToolStripMenuItem 貼上ToolStripMenuItem;
        private ToolStripMenuItem 字型ToolStripMenuItem;
    }
}