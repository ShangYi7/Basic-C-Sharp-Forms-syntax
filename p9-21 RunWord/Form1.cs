namespace RunWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool move_d = true;   // �O���]���O��r���ʤ�V
        private void Form1_Load(object sender, EventArgs e)
        {
            TmrRun.Interval = 100;
            TmrRun.Enabled = true;
            toolStripTextBox1.Text = "�n�H�@�ͥ��w";
        }

        private void TmrRun_Tick(object sender, EventArgs e)
        {
            if (move_d == true)      // true �ѥ��V�k��
            {
                LblMsg.Left += 10;
                if (LblMsg.Left >= this.Width) LblMsg.Left = -LblMsg.Width;
            }
            else                     //false �ѥ��V�k��
            {
                LblMsg.Left -= 10;
                if (LblMsg.Left <= -LblMsg.Width) LblMsg.Left = this.Width;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            move_d = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            move_d = true;
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            LblMsg.Text = toolStripTextBox1.Text;
        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblMsg.ForeColor = Color.FromName(toolStripComboBox1.Text); //�C��
        }

        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("LblMsg.Font.name", float.Parse(toolStripComboBox3.Text), LblMsg.Font.Style); //�r��j�p
        }

        private void toolStripComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LblMsg.Font = new Font(toolStripComboBox2.Text, LblMsg.Font.Size, LblMsg.Font.Style); // �r��
        }
    }
}