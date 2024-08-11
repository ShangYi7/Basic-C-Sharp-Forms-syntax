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
                Name = "珍妮佛",
                Score = 0        // 設定Jennifer的Score值為0
            };
            Jennifer.ShowMsg();

            Student ShangYi = new()
            {
                Name = "ShangYi",
                Score = 60        // 設定ShangYi的Score值為60
            };
            ShangYi.ShowMsg();

            Student Bruce = new()
            {
                Name = "布魯斯",
                Score = 1000     //  設定Bruce的Score值為1000
            };
            Bruce.ShowMsg();
        }
    }
}