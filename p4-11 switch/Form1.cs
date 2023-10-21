namespace p4_11_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            float score;
            if (!float.TryParse(textBox1.Text, out score))
            {
                label2.Text = ("請輸入有效數值");
                return;
            }
            switch (score)
            {
                case float n when (n <= 100 && n >= 90):
                    label2.Text = ("甲");
                    break;

                case float n when (n <= 90 && n >= 80):
                    label2.Text = ("乙");
                    break;

                case float n when (n <= 80 && n >= 70):
                    label2.Text = ("丙");
                    break;

                case float n when (n <= 70 && n >= 60):
                    label2.Text = ("丁");
                    break;

                case float n when (n <60):
                    label2.Text = ("補考");
                    break;

                default:
                    label2.Text = ("請輸入大於0,小於100的數值");
                    break;
            }
        }
    }
}