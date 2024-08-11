using System.Media;              //引用System. Media命名空間
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ListenTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 共用欄位成員變數
        string pathName;      	//檔案路徑與檔名
        int testNum,score=0;    //存放亂數出來的數值
        SoundPlayer player;    	//宣告播放器物件
        string[] ary = new string[] {"orange", "mango", "tomato", "strawberry","apple", "banana", "watermelon", "pear"};

        // 啟始狀態
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
            TxtInput.Focus();                //將游標移到輸入文字方塊
            LblMsg1.Text = "";
            Random rnd = new Random();   //產生亂數物件rnd
            testNum = rnd.Next(1, 9);       //產生1~8的亂數
            pathName = $"fruit{testNum}.wav";        //合併成數字語音檔
            player = new SoundPlayer(pathName);      //播放數字語音檔
            player.Load();
            player.Play();
            BtnPlay.Enabled = false;         //播放按鈕無效
            BtnReplay.Enabled = true;        //重聽按鈕有效
            BtnCheck.Enabled = true;     	//對答按鈕有效
            LblMsg3.Text = ary[testNum - 1];
        }

        private void BtnReplay_Click(object sender, EventArgs e)
        {
            player.Play();
            TxtInput.Focus();           //將游標移到輸入文字方塊
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            
            if ((TxtInput.Text).ToLower() == ary[testNum - 1])  // 對答案
            { 
                LblMsg1.Text = "答對了!";
                LblMsg2.Text = $"分數加十分{score += 10}";
                pictureBox1.Image = Properties.Resources.main;
            }
            else
            {
                LblMsg1.Text = "答錯了!";
                LblMsg2.Text = $"分數扣十分{score -= 10}";
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