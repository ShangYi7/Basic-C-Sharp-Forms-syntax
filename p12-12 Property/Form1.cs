using static System.Formats.Asn1.AsnWriter;

namespace Property
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student Jennifer = new Student()
            {
                Name = "�ég��",
                Score = 0        // �]�wJennifer��Score�Ȭ�0
            };
            Jennifer.ShowMsg();

            Student ShangYi = new()
            {
                Name = "ShangYi",
                Score = 60        // �]�wShangYi��Score�Ȭ�60
            };
            ShangYi.ShowMsg();

            Student Bruce = new()
            {
                Name = "���|��",
                Score = 1000     //  �]�wBruce��Score�Ȭ�1000
            };
            Bruce.ShowMsg();
        }
    }
}