namespace ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //設定Pic2~4的Click事件，共用Pic1_Click事
            Pic2.Click += Pic1_Click;
            Pic3.Click += Pic1_Click;
            Pic4.Click += Pic1_Click;
        }

        private void Pic1_Click(object sender, EventArgs e)
        {
            PictureBox hitPic = (PictureBox)sender;   //取得哪個圖片方塊被按下
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {   //如果按確定鈕，就將顏色值指定給圖片方塊
                hitPic.BackColor = colorDialog1.Color;
                Pic5.BackColor = hitPic.BackColor;
            }

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
                label1.BackColor = hitPic.BackColor;
            }
        }
    }
}