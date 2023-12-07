namespace p6_24_Split
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string mes="";
            string x = "abcdeabcdeabcdeabcdeabcde";
            string[] y = x.Split(new char[3] {'c','d','e'});

            foreach (string i in y)
            {
                mes += i+",,,,";
            }
            MessageBox.Show(mes);

        }
    }
}