using System.Media;              //�ޥ�System. Media�R�W�Ŷ�
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ListenTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // �@����즨���ܼ�
        string pathName;      	//�ɮ׸��|�P�ɦW
        int testNum,score=0;    //�s��üƥX�Ӫ��ƭ�
        SoundPlayer player;    	//�ŧi���񾹪���
        string[] ary = new string[] {"orange", "mango", "tomato", "strawberry","apple", "banana", "watermelon", "pear"};

        // �ҩl���A
        private void start()
        {
            BtnPlay.Enabled = true;
            BtnReplay.Enabled = false;
            BtnCheck.Enabled = false;
            TxtInput.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblMsg1.Text = "";
            LblMsg2.Text = "";
            start();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            TxtInput.Enabled = true;
            TxtInput.Text = "";
            TxtInput.Focus();                //�N��в����J��r���
            LblMsg1.Text = "";
            Random rnd = new Random();   //���Ͷüƪ���rnd
            testNum = rnd.Next(1, 9);       //����1~8���ü�
            pathName = $"fruit{testNum}.wav";        //�X�֦��Ʀr�y����
            player = new SoundPlayer(pathName);      //����Ʀr�y����
            player.Load();
            player.Play();
            BtnPlay.Enabled = false;         //������s�L��
            BtnReplay.Enabled = true;        //��ť���s����
            BtnCheck.Enabled = true;     	//�ﵪ���s����
            LblMsg3.Text = ary[testNum - 1];
        }

        private void BtnReplay_Click(object sender, EventArgs e)
        {
            player.Play();
            TxtInput.Focus();           //�N��в����J��r���
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            
            if ((TxtInput.Text).ToLower() == ary[testNum - 1])  // �ﵪ��
            { 
                LblMsg1.Text = "����F!";
                LblMsg2.Text = $"���ƥ[�Q��{score += 10}";
                pictureBox1.Image = Properties.Resources.main;
            }
            else
            {
                LblMsg1.Text = "�����F!";
                LblMsg2.Text = $"���Ʀ��Q��{score -= 10}";
                pictureBox1.Image = Properties.Resources.main__1_;
            }
            start();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}