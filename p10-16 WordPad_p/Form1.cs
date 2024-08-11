namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //執行功能表 [檔案/開檔] 時執行
        private void MItmOpen_Click(object sender, EventArgs e)
        {
            String filename;
            openFileDialog1.Filter = "文書檔 (*.rtf)|*.rtf|所有檔案 (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.DefaultExt = ".rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                RtxtNote.LoadFile(filename, RichTextBoxStreamType.RichText);
            }
        }
        //執行功能表 [檔案/存檔] 時執行
        private void MItmSave_Click(object sender, EventArgs e)
        {
            String filename;
            saveFileDialog1.Filter = "文書檔 (*.rtf)|*.rtf|所有檔案 (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.DefaultExt = ".rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                RtxtNote.SaveFile(filename, RichTextBoxStreamType.RichText);
            }
        }
        //執行功能表 [檔案/結束] 時執行
        private void MItmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //執行功能表 [編輯/複製] 時執行
        private void MItmCopy_Click(object sender, EventArgs e)
        {
            RtxtNote.Copy();   //將選取的範圍複製到剪貼簿
        }
        //執行功能表 [編輯/貼上] 時執行
        private void MItmPaste_Click(object sender, EventArgs e)
        {
            RtxtNote.Paste();   //將剪貼簿的內容貼到目前的插入點
        }
        //執行功能表 [編輯/復原] 時執行
        private void 復原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtNote.Undo();
        }
        //執行功能表 [編輯/清除] 時執行
        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtNote.Clear();
        }
        // 執行功能表的 [項目符號/設定] 時執行
        private void MItmSet_Click(object sender, EventArgs e)
        {
            RtxtNote.SelectionBullet = true;   //選取範圍設定項目符號
        }
        //執行功能表的 [項目符號/取消項目符號] 時執行
        private void MItmCancel_Click(object sender, EventArgs e)
        {
            RtxtNote.SelectionBullet = false;  //選取範圍取消項目符號
        }
        //執行功能表的 [字型] 時執行
        private void MnuFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                RtxtNote.SelectionFont = fontDialog1.Font;
            }
        }
        //執行功能表的 [顏色/前景色] 時執行
        private void MItmFColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                RtxtNote.SelectionColor = colorDialog1.Color;
            }
        }
        // 執行功能表的 [顏色/前景色] 時執行
        private void MItmBColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                RtxtNote.SelectionBackColor = colorDialog1.Color;
            }
        }

        private void MItmClear_Click(object sender, EventArgs e)
        {
            RtxtNote.Clear();   //使用Clear方法清空內容
        }

        private void MItmCut_Click(object sender, EventArgs e)
        {
            RtxtNote.Cut();   //將選取的範圍剪下到剪貼簿
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtNote.Cut();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtNote.Paste();   //將剪貼簿的內容貼到目前的插入點
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                RtxtNote.SelectionFont = fontDialog1.Font;
            }
        }
    }
}