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
                label2.Text = ("�п�J���ļƭ�");
                return;
            }
            switch (score)
            {
                case float n when (n <= 100 && n >= 90):
                    label2.Text = ("��");
                    break;

                case float n when (n <= 90 && n >= 80):
                    label2.Text = ("�A");
                    break;

                case float n when (n <= 80 && n >= 70):
                    label2.Text = ("��");
                    break;

                case float n when (n <= 70 && n >= 60):
                    label2.Text = ("�B");
                    break;

                case float n when (n <60):
                    label2.Text = ("�ɦ�");
                    break;

                default:
                    label2.Text = ("�п�J�j��0,�p��100���ƭ�");
                    break;
            }
        }
    }
}