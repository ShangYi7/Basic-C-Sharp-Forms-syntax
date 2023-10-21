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
            double x1;
            x1 = double.Parse(textBox1.Text);
            label1.Text = $"你的身高 {x1} cm, 你的標準體重 = {(x1 - 80) * 0.7:F2}";
        }
    }
}