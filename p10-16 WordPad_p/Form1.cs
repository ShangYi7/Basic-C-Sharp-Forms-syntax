namespace WordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //����\��� [�ɮ�/�}��] �ɰ���
        private void MItmOpen_Click(object sender, EventArgs e)
        {
            String filename;
            openFileDialog1.Filter = "����� (*.rtf)|*.rtf|�Ҧ��ɮ� (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.DefaultExt = ".rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                RtxtNote.LoadFile(filename, RichTextBoxStreamType.RichText);
            }
        }
        //����\��� [�ɮ�/�s��] �ɰ���
        private void MItmSave_Click(object sender, EventArgs e)
        {
            String filename;
            saveFileDialog1.Filter = "����� (*.rtf)|*.rtf|�Ҧ��ɮ� (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.DefaultExt = ".rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                RtxtNote.SaveFile(filename, RichTextBoxStreamType.RichText);
            }
        }
        //����\��� [�ɮ�/����] �ɰ���
        private void MItmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //����\��� [�s��/�ƻs] �ɰ���
        private void MItmCopy_Click(object sender, EventArgs e)
        {
            RtxtNote.Copy();   //�N������d��ƻs��ŶKï
        }
        //����\��� [�s��/�K�W] �ɰ���
        private void MItmPaste_Click(object sender, EventArgs e)
        {
            RtxtNote.Paste();   //�N�ŶKï�����e�K��ثe�����J�I
        }
        //����\��� [�s��/�_��] �ɰ���
        private void �_��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtNote.Undo();
        }
        //����\��� [�s��/�M��] �ɰ���
        private void �M��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtNote.Clear();
        }
        // ����\��� [���زŸ�/�]�w] �ɰ���
        private void MItmSet_Click(object sender, EventArgs e)
        {
            RtxtNote.SelectionBullet = true;   //����d��]�w���زŸ�
        }
        //����\��� [���زŸ�/�������زŸ�] �ɰ���
        private void MItmCancel_Click(object sender, EventArgs e)
        {
            RtxtNote.SelectionBullet = false;  //����d��������زŸ�
        }
        //����\��� [�r��] �ɰ���
        private void MnuFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                RtxtNote.SelectionFont = fontDialog1.Font;
            }
        }
        //����\��� [�C��/�e����] �ɰ���
        private void MItmFColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                RtxtNote.SelectionColor = colorDialog1.Color;
            }
        }
        // ����\��� [�C��/�e����] �ɰ���
        private void MItmBColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                RtxtNote.SelectionBackColor = colorDialog1.Color;
            }
        }

        private void MItmClear_Click(object sender, EventArgs e)
        {
            RtxtNote.Clear();   //�ϥ�Clear��k�M�Ť��e
        }

        private void MItmCut_Click(object sender, EventArgs e)
        {
            RtxtNote.Cut();   //�N������d��ŤU��ŶKï
        }

        private void �ŤUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtNote.Cut();
        }

        private void �K�WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RtxtNote.Paste();   //�N�ŶKï�����e�K��ثe�����J�I
        }

        private void �r��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                RtxtNote.SelectionFont = fontDialog1.Font;
            }
        }
    }
}