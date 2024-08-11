namespace Gues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] pName = new string[] { "�ŤM", "���Y", "��" };

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] arrBtn = new Button[3];
            arrBtn[0] = Btn1; arrBtn[1] = Btn2; arrBtn[2] = Btn3;
            for (int i = 0; i < 3; i++)
            {
                arrBtn[i].Text = pName[i]; // �]�w��r���e
                arrBtn[i].Image = new Bitmap(arrBtn[i].Text + ".gif");  //��ܹ�������
                arrBtn[i].Click += MyClick;//�@��MyClick�ƥ�
            }
            LblMsg.Text = "�Ы��s�X���I";
        }
        // Btn1�BBtn2�BBtn3��Click�ƥ�@�Ψƥ�
        private void MyClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int p = rnd.Next(0, 3);//����0~2�ܼ�
            PicPC.Image = Image.FromFile(pName[p] + ".gif");// ��ܹq���X��
            Button btnHit = (Button)sender;                 // ���o�ثe�����s
            //�I�sGetWinner��k�ӧP�_�����
            LblMsg.Text = GetWinner(btnHit.Text, pName[p]);
        }
        // GetWinner��k�i�H�Ǧ^�����
        private string GetWinner(string user, string pc)
        {
            string msg = "";
            if (user == pc)
                msg = "���襭��I";
            else if (user == "�ŤM")
                msg = (pc == "���Y" ? "�q����ӡI" : "�A��ӡI");
            else if (user == "���Y")
                msg = (pc == "��" ? "�q����ӡI" : "�A��ӡI");
            else
                msg = (pc == "�ŤM" ? "�q����ӡI" : "�A��ӡI");
            return msg;
        }
    }
}