namespace p8_3_Random
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
            int[] num = new int[6];         // �}�Cnum�O��5�Ӿ�ƶü�
            Random rnd = new Random();  // �إ�rnd�üƪ���
            label1.Text = "";               // �M��LblMsg
            for (int i = 0; i <= 5; i++)
            {
                int r = rnd.Next(49) + 1;       // ����1~49�ü�
                bool same = false;          // �ˬd�üƬO�_���ơA�w�]��������
                foreach (int n in num)          // �v�@�ˬdnum�}�C����
                {
                    if (r == n) { same = true; break; } //�Y�ۦP�N�]same=true�����}�j��
                    if (n == 0) { same = false; break; }//�Y�O0��S�üƳ]same=false���}�j��
                }
                if (same == false)      // �Ysame=false
                    num[i] = r;         // �N�üƦs�J�}�C��
                else
                    i--;                    // i��1���s���Ͷü�
            }
            for (int i = 0; i <= 5; i++)        // �v�@��ܶü�
            {
                label1.Text += $"�� {i + 1} �Ӷü�: {num[i]}\n";
            }
        }
    }
}