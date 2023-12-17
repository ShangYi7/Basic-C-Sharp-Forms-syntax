namespace _6_40_Textlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] code = new string[] { "C/C++", "Python", "VB", "PHP"};

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(code);
        }

        private void butYes_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
            listBox1.Items.Remove(listBox1.Text);
        }

        private void butNo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.Text);
            listBox2.Items.Remove(listBox2.Text);
        }
    }
}