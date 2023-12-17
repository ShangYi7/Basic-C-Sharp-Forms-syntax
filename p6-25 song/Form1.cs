namespace p6_25_song
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < no.Length; i++)    //設定no陣列的初值
            {
                no[i] = i + 1;
            }
            button1_Click(sender, e);     // 執行button1_Click事件函式
        }

        // song字串陣列存放歌曲名稱
        string[] song = new string[] { "不為誰而作的歌", "餘波盪漾","後來的我們",
          "不該", "年輪說", "滿座", "關鍵詞", "天真有邪","獨善其身", "一次幸福的機會" };
        //singer字串陣列存放歌手姓名
        string[] singer = new string[] { "林俊傑", "田馥甄", "五月天", "周杰倫",
                 "楊丞琳", "李榮浩", "林俊傑", "林宥嘉","田馥甄", "蕭敬騰" };
        int[] no = new int[10];                // no整數陣列存放排名

        private void BtnSortno_Click(object sender, EventArgs e)
        {
            string[] no2 = new string[no.Length];
            no.CopyTo(no2, 0);
            Array.Sort(no, song);
            Array.Sort (no2, singer);
            string msg = "排名\t歌手\t歌曲\t"+Environment.NewLine;

        }

        private void button1_Click(object sender, EventArgs e)
        // 按 <依歌手名字排序> 鈕時
        {
            string[] singer2 = new string[singer.Length]; // 宣告字串陣列，大小和 singer 陣列相同
            singer.CopyTo(singer2, 0); 		// 將 singer 陣列的內容複製到 singer2 陣列
            Array.Sort(singer, no);  		// singer 陣列遞增排序，no 陣列同步調整
            Array.Sort(singer2, song);  	// singer2 陣列遞增排序，sone 陣列同步調整
            //需要兩個 Array.Sort ,因為只能用兩個陣列,所以複製一個相同的陣列,跟song同步

            string msg = "排名\t歌手\t歌曲" + Environment.NewLine;
            for (int i = 0; i < song.Length; i++)
            {
                msg += $"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
            }
            textBox2.Text = msg;  // 顯示資料內容
        }

        private void button2_Click(object sender, EventArgs e)
        //按 <依歌曲搜尋> 鈕時
        {
            string search = textBox1.Text;   // 取得使用者查詢的歌手姓名
            string msg = $"找不到{search}";  // 預設找不到
            int index = Array.IndexOf(song, search); // 第一筆符合的索引值
            if (index >= 0) //若有找到相符的資料
            {
                msg = "排名\t歌手\t歌曲" + Environment.NewLine;
                while (index >= 0)   // 當index >= 0繼續迴圈
                {   // 顯示資料內容
                    msg += $"{no[index]} \t {singer[index]} \t {song[index]}";
                    msg += Environment.NewLine;
                    // 從下一筆繼續搜尋
                    index = Array.IndexOf(song, search, index + 1);
                };
            }
            textBox2.Text = msg;  // 顯示資料內容
        }

\
    }
}