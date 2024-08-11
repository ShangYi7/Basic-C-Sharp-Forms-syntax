using Microsoft.VisualBasic;
using System.IO;

namespace p11_10_FileInfo
{
    public partial class Form1 : Form
    {
        string msg, data;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("fuck.txt");
            FileStream fs = file.Create();              //建立檔案
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(@"F:\code\Program\C# Forms\p11-10 FileInfo\bin\Debug\net6.0-windows\fuck.txt");
            StreamWriter sw = fileInfo.CreateText();
            sw.WriteLine("好人一生平安");                   //新增文字
            sw.Flush();
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            char ch;
            string path = @"F:\code\Program\C# Forms\p11-10 FileInfo\bin\Debug\net6.0-windows\fuck.txt";
            StreamReader sr = new StreamReader(path);

            do
            { 
                ch = (char)sr.Read();
                if (sr.Peek() == -1)
                    break;
                msg += ch;
            } while (true);
            sr.Close();
            MessageBox.Show(msg);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data = "";
            string path = @"F:\code\Program\C# Forms\p11-10 FileInfo\bin\Debug\net6.0-windows\fuck.txt";
            StreamReader sr = new StreamReader(path);

            do
            {
                data = sr.ReadLine();
                if (data == null) break;
                msg += data + "\r\n";
                
            } while (true);
            sr.Close();
            MessageBox.Show(msg);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = @"F:\code\Program\C# Forms\p11-10 FileInfo\bin\Debug\net6.0-windows\fuck.txt";
            StreamReader sr = new StreamReader(path);

            msg=sr.ReadToEnd();
            MessageBox.Show(msg);
            sr.Close();
        }
    }
}