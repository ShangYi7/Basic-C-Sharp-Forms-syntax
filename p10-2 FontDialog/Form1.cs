namespace FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtShow.Text = "舉手做環保";
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {   //如果按確定鈕，就將字型設定值指定給文字方塊
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtShow.Font = fontDialog1.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtShow.ForeColor = colorDialog1.Color;
            }
        }
    }
}