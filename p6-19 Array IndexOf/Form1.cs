using static System.Formats.Asn1.AsnWriter;

namespace p6_19_Array_IndexOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, index;
            string msg;
            
            string[] stu = new string[] { "黑", "e04", "呵呵", "段", "八七" };
            int[] score = new int[] { 95, 100, 100, 92, 100 };

            if (int.TryParse(textBox1.Text, out x))
            {
                index = Array.IndexOf(score, x);
                if(index > -1)
                {
                    msg = $"{x}分數學生: ";
                    while(index > -1)
                    {
                        msg+=stu[index]+",";
                        index = Array.IndexOf(score,x,index+1);
                    }
                }
                else
                {
                    msg = "搜尋不到";
                }
            }
            else
            {
                msg = "輸入正整數";
            }
            MessageBox.Show(msg);
        }
    }
}