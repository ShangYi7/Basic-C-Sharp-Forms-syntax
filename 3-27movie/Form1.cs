namespace _3_27movie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // p3- 30
            string Cola_how_much = Microsoft.VisualBasic.Interaction.InputBox("輸入可樂金額:", "可樂金額", "25"); // "提示" "標題" "預設值"
            string SARS_how_much = Microsoft.VisualBasic.Interaction.InputBox("輸入沙士金額:", "沙士金額", "25");
            textBox1.Text = SARS_how_much;
            textBox2.Text = Cola_how_much;
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //計算氣水多少錢
        {
            try
            {
                int sum3;
                sum3 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox1.Text);
                label9_SARS_Yuan.Text = Convert.ToString(sum3);
            }
            catch
            {
                textBox3.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sum3, sum4;
                sum3 = Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox1.Text);
                sum4 = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox4.Text);
                label10_Cola_Yuan.Text = Convert.ToString(sum4);
                total.Text = Convert.ToString(sum3 + sum4);
            }
            catch
            {
                textBox3.Clear();
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            DialogResult dr; //p3-30
            dr = MessageBox.Show("MessageBox.Show 測試,值輸出在 output 中", "MessageBox.Show", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            //                   "提示"   "標題"  "需要那些按鈕"                "Icon 圖片"   
            if (dr == DialogResult.Yes) // dr == DialogResult.Yes 時觸發
            {
                output.Text = "6666666";
            }
            else if (dr == DialogResult.No) // 判斷句中 可以有很多else if
            {
                output.Text = "77777777";
            }
            else // dr == DialogResult.Cancel 時觸發
            {
                output.Text = "22222";
            }
        }
    }
}