namespace RunWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool move_d = true;   // 記錄跑馬燈文字移動方向
        private void Form1_Load(object sender, EventArgs e)
        {
            TmrRun.Interval = 100;
            TmrRun.Enabled = true;
            toolStripTextBox1.Text = "好人一生平安";
        }

        private void TmrRun_Tick(object sender, EventArgs e)
        {
            if (move_d == true)      // true 由左向右移
            {
                LblMsg.Left += 10;
                if (LblMsg.Left >= this.Width) LblMsg.Left = -LblMsg.Width;
            }
            else                     //false 由左向右移
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
            LblMsg.ForeColor = Color.FromName(toolStripComboBox1.Text); //顏色
        }

        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblMsg.Font = new Font("LblMsg.Font.name", float.Parse(toolStripComboBox3.Text), LblMsg.Font.Style); //字體大小
        }

        private void toolStripComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LblMsg.Font = new Font(toolStripComboBox2.Text, LblMsg.Font.Size, LblMsg.Font.Style); // 字體
        }
    }
}