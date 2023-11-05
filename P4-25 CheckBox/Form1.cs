namespace P4_25_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true; //預設勾選/Default checked
            radioButton6.Checked = true; //預設勾選/Default checked
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int tool;
            string msg;
            tool = radioButton1.Checked ? 150 : radioButton2.Checked ? 120 : 100; // 假如勾選 radioButton1 tool 為 150否則後面做比較/If radioButton1 tool is checked, it will be 150, otherwise it will be compared later.
            msg = radioButton1.Checked ? "大碗" : radioButton2.Checked ? "中碗" : "小碗"; //
            msg += "拉麵\n\n湯頭濃度:";
            msg += radioButton4.Checked ? "濃郁" : radioButton6.Checked ? "中" : "清淡";
            if (checkBox4.Checked == true)
            {
                tool += 20;
                msg += "\n加點飲料";
            }
            if (checkBox5.Checked == true)
            {
                tool += 20;
                msg += "\n加點蛋";
            }
            if (checkBox6.Checked == true)
            {
                tool += 20;
                msg += "\n加點青菜";
            }
            msg += $"\n總價:{tool}元";
            MessageBox.Show(msg, "點菜單", MessageBoxButtons.OK);

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}