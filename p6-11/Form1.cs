using Microsoft.VisualBasic;

namespace p6_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] stu = new string[] { "A001", "A002", "A003", "A004" };  //�s��ǥ;Ǹ�
            string[] sub = new string[] { "�p��", "�{�]", "�M�D" };  //�s���ئW��
            int[,] score = new int[,] { { 82, 84, 90 }, { 85, 92, 87 }, { 80, 73, 82 }, { 62, 68, 84 } };
            int[] sum = new int[4] { 0, 0, 0, 0 };
            for (int y = 0; y <= score.GetUpperBound(0); y++)
            {
                for (int x = 0; x <= score.GetUpperBound(1); x++)
                    sum[y] += score[y, x];
            }
            string msg = "�Ǹ�\t";
            foreach (string s in stu)
                msg += s + "\t";
            msg += "\n";
            for (int y = 0; y <= sub.GetUpperBound(0); y++)
            {
                msg += sub[y] + "\t";
                for (int x = 0; x <= stu.GetUpperBound(0); x++)
                    msg += $"{score[x, y]}\t";
                msg += "\n";
            }
            msg += "�`��\t";
            foreach (int i in sum)
                msg += $"{i}\t";
            msg += "\n";
            MessageBox.Show(msg, "���Z��");
            Application.Exit();
        }
    }
}