namespace Gues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] pName = new string[] { "剪刀", "石頭", "布" };

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] arrBtn = new Button[3];
            arrBtn[0] = Btn1; arrBtn[1] = Btn2; arrBtn[2] = Btn3;
            for (int i = 0; i < 3; i++)
            {
                arrBtn[i].Text = pName[i]; // 設定文字內容
                arrBtn[i].Image = new Bitmap(arrBtn[i].Text + ".gif");  //顯示對應圖檔
                arrBtn[i].Click += MyClick;//共用MyClick事件
            }
            LblMsg.Text = "請按鈕出拳！";
        }
        // Btn1、Btn2、Btn3的Click事件共用事件
        private void MyClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int p = rnd.Next(0, 3);//產生0~2變數
            PicPC.Image = Image.FromFile(pName[p] + ".gif");// 顯示電腦出拳
            Button btnHit = (Button)sender;                 // 取得目前的按鈕
            //呼叫GetWinner方法來判斷誰獲勝
            LblMsg.Text = GetWinner(btnHit.Text, pName[p]);
        }
        // GetWinner方法可以傳回誰獲勝
        private string GetWinner(string user, string pc)
        {
            string msg = "";
            if (user == pc)
                msg = "雙方平手！";
            else if (user == "剪刀")
                msg = (pc == "石頭" ? "電腦獲勝！" : "你獲勝！");
            else if (user == "石頭")
                msg = (pc == "布" ? "電腦獲勝！" : "你獲勝！");
            else
                msg = (pc == "剪刀" ? "電腦獲勝！" : "你獲勝！");
            return msg;
        }
    }
}