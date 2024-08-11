namespace RndArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] arrRnd = new int[4];  // 宣告整數陣列arrRnd大小為4
            SetRndNum(arrRnd, 1, 49);   // 呼叫SetRndNum方法產生1~49的亂數
            ShowArray(ref arrRnd);      // 呼叫ShowArray方法來顯示陣列元素值
            Application.Exit();
        }
        
        // 根據陣列大小產生n1到n2範圍內的亂數值
        private void SetRndNum(int[] arrNum, int n1, int n2)
        {
            Random r = new Random();              // 建立r亂數物件
            for (int i = 0; i <= arrNum.Length - 1; i++)      // 逐一產生亂數
                arrNum[i] = r.Next(n1, n2 + 1);       // 產生n1~n2亂數
        }
        
        //顯示傳入整數陣列內的元素值
        private void ShowArray(ref int[] arr)
        {
            string msg = "";
            foreach (int a in arr)          // 逐一讀取陣列元素值
                msg += a.ToString() + " ,"; // 將元素值加入msg字串中
            MessageBox.Show(msg);
            
            msg = "";
            for (int i = 0; i <= 3; i++) 
            {
                msg += Convert.ToString(arr[i] + 10);
                msg += ",";
            }
            MessageBox.Show(msg);
        }
    }
}