namespace p3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Beige; //���textBox1 �C��
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("R:\\code\\program\\C#\\p3-2\\bin\\Debug\\4448.png_1200.png"); // ���I���Ϥ�
            BackgroundImageLayout = ImageLayout.Stretch; // �I���Ϥ�����
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("�з���", 50, FontStyle.Italic); // ��� label1 �̪��r�� (�r��, �j�p, �Ϊ�)
        }

    }
}


