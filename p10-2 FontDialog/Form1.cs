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
            TxtShow.Text = "�|�ⰵ���O";
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {   //�p�G���T�w�s�A�N�N�r���]�w�ȫ��w����r���
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