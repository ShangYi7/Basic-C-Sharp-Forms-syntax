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
            
            int x1 = int.Parse(textBox1.Text);
            int x2 = int.Parse(textBox2.Text);
            label1.Text = $"�R�T�� {x1} �~, �R�F�h{x2} �~, �`�@ {x1 * 20 + x2 * 25}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}