namespace _0921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int x1 = int.Parse(textBox1.Text); // textBox1 中的文字傳換成 int 儲存在 x1 中/The text in textBox1 is converted into int and stored in x1
            int x2 = int.Parse(textBox2.Text);
            label1.Text = $"買汽水 {x1} 瓶, 買沙士{x2} 瓶, 總共 {x1 * 20 + x2 * 25}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}