namespace _0921_標準體重
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double x1 = double.Parse(textBox1.Text); // textBox1 中的文字轉換成 double 儲存在 x1 中/The text in textBox1 is converted into double and stored in x1
            double sum = (x1 - 80) * 0.7;
            if (sum < 0)
            {
                MessageBox.Show("請出入正確的身高");
            }
            else
            {
                label1.Text = $"你的身高 {x1} cm, 你的標準體重 = {sum:F2}"; // 是用 $ 直接帶入變數運算 /Use $ to directly bring in variable operations
                                                                  // :F2  = 算到小數點第二位/Count to the second decimal place
                                                                  // f = float
            }
        }
    }
}