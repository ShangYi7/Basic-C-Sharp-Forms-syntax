namespace ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg.Text = "�ܪ��K�K�A�����H�H";
            LblMsg.ForeColor = Color.Red;            // �]�e���⬰����
            LblMsg.Font = new Font("�ө���", 16, FontStyle.Bold);
            ����ToolStripMenuItem.Checked = true;   // �w�]���鶵�سQ�Ŀ�
            ����ToolStripMenuItem1.Checked = true;  // �w�]���鶵�سQ�Ŀ�
        }

        private void �ө���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // �]�r�����ө���B�j�p��16�B��r���˦�
            LblMsg.Font = new Font("�ө���", 16, LblMsg.Font.Style);
        }

        private void �з���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("�з���", 16, LblMsg.Font.Style);
        }
        private void �L�n������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("�L�n������", 16, LblMsg.Font.Style);
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font(LblMsg.Font, LblMsg.Font.Style ^ FontStyle.Bold);
            ����ToolStripMenuItem.Checked = !(����ToolStripMenuItem.Checked);
            ����ToolStripMenuItem1.Checked = !(����ToolStripMenuItem1.Checked);
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font(LblMsg.Font, LblMsg.Font.Style ^ FontStyle.Italic);
            ����ToolStripMenuItem.Checked = !(����ToolStripMenuItem.Checked);
            ����ToolStripMenuItem1.Checked = !(����ToolStripMenuItem1.Checked);
        }

        private void �[���uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font(LblMsg.Font, LblMsg.Font.Style ^ FontStyle.Underline);
            �[���uToolStripMenuItem.Checked = !(�[���uToolStripMenuItem.Checked);
            �[���uToolStripMenuItem1.Checked = !(�[���uToolStripMenuItem1.Checked);
        }

        private void �j�pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("LblMsg.Font.name", 12, LblMsg.Font.Style);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("LblMsg.Font.name", 24, LblMsg.Font.Style);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("LblMsg.Font.name", 36, LblMsg.Font.Style);
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.ForeColor = Color.Red;
        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.ForeColor = Color.Green;
        }

        private void �¦�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LblMsg.ForeColor = Color.Black;
        }

        private void �r��ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void �C��ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LblMsg.ForeColor = Color.Black;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("LblMsg.Font.name", 12, LblMsg.Font.Style);
        }

        private void �¦�ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LblMsg.Font = new Font("LblMsg.Font.name", 12, LblMsg.Font.Style);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("LblMsg.Font.name", 12, LblMsg.Font.Style);
        }
    }
}