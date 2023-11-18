namespace p5_10_While
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
            int num, x = 2;
            bool result1;
            string msg;
            result1 = int.TryParse(textBox1.Text, out num);
            if (result1 == true)
            {
                msg = $"{num}是質數";
                while (x < num)
                {
                    if (num % x == 0)
                    {
                        msg = $"{num}不是質數";
                        break;
                    }
                    else
                    {
                        x++;
                    }
                }
                label1.Text = msg;
            }
            else
            {
                label1.Text = "請輸入正整數";
            }
            

        }
    }
}