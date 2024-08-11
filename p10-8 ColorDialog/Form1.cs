namespace ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //�]�wPic2~4��Click�ƥ�A�@��Pic1_Click��
            Pic2.Click += Pic1_Click;
            Pic3.Click += Pic1_Click;
            Pic4.Click += Pic1_Click;
        }

        private void Pic1_Click(object sender, EventArgs e)
        {
            PictureBox hitPic = (PictureBox)sender;   //���o���ӹϤ�����Q���U
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {   //�p�G���T�w�s�A�N�N�C��ȫ��w���Ϥ����
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