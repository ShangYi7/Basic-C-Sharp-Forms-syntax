using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 連連看改
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sizex = 5, sizey = 5, correct = 0, error = 0, se = 0;
        int[,] imup, imdo;
        int[,,] imupxy, imdoxy;
        double timer = 0;
        bool[,] pitb1, pitb2;
        PictureBox[,] p1, p2;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "連連看改";
            groupBox1.Text = "圖片";
            groupBox1.Location = new Point(5, 5);
            groupBox1.Size = new Size(1200, 700);
            groupBox1.Font = new Font("標楷體", 12, new FontStyle());
            label1.Location = new Point(groupBox1.Left + groupBox1.Width + 20, groupBox1.Top + 50);
            label1.Font = new Font("標楷體", 12, new FontStyle());
            label1.Text = "輸入 X 軸圖片數量(不能大於 " + sizex.ToString() + " ):";
            label2.Location = new Point(label1.Left, label1.Top + 30);
            label2.Font = new Font("標楷體", 12, new FontStyle());
            label2.Text = "輸入 Y 軸圖片數量(不能大於 " + sizey.ToString() + " ):";
            label3.Location = new Point(label1.Left, label1.Top + 120);
            label3.Font = new Font("標楷體", 15, new FontStyle());
            label3.Text = "信息:";
            label4.Location = new Point(label3.Left, label3.Top + 50);
            label4.Font = new Font("標楷體", 15, new FontStyle());
            label4.Text = "正確次數: " + correct + " 次 ， 錯誤次數: " + error + " 次。";
            label5.Location = new Point(label4.Left, label4.Top + 50);
            label5.Font = new Font("標楷體", 15, new FontStyle());
            label5.Text = "滑動失誤: " + se + " 次。";
            label6.Location = new Point(label5.Left, label5.Top + 50);
            label6.Font = new Font("標楷體", 12, new FontStyle());
            label6.Text = "經過秒數: " + timer.ToString("f2") + " 秒";
            textBox1.Location = new Point(label6.Left, label6.Top + 50);
            textBox1.Font = new Font("標楷體", 15, new FontStyle());
            textBox1.Text = "功能附註:\r\n1.在圖片上按住滑鼠左鍵不放可以拖曳左方和右方之圖片。\r\n\r\n2.圖片只可在GroupBox控制項內移動。\r\n\r\n3.若移動到正確位置後放開滑鼠左鍵，則正確次數加一。\r\n\r\n4.若移動到錯誤位置後放開滑鼠左鍵，則錯誤次數加一。\r\n\r\n5.若移動到非圖片位置後放開滑鼠左鍵，則滑動錯誤次數加一。\r\n\r\n6.右上方的兩個數字鈕控制項分別對應X軸的圖片數量及Y軸的圖片數量。\r\n\r\n7.右上方的兩個數字鈕控制項皆只可以輸入1 ~ " + sizex.ToString() + "之間的值。\r\n\r\n8.右上方的兩個數字鈕控制項接受 Delect 鍵 、 Backspace 鍵 、 方向上鍵 、 方向下鍵。\r\n\r\n9.右上方的兩個數字鈕控制項可按 Enter 鍵來對圖片進行重置。\r\n\r\n10.數字鈕控制項只接受上述幾點有提到之按鈕，其餘按鈕一概不接受。\r\n\r\n11.按 重置 按鈕可重洗圖片。\r\n\r\n12.若數字鈕控制項內容為空時，其內部數字預設為刪除前之數值。\r\n\r\n13.會記錄從開始到過關的時間。";
            textBox1.Size = new Size(460, 300);
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.ReadOnly = true;
            numericUpDown1.Location = new Point(label1.Left + label1.Width + 20, label1.Top);
            numericUpDown1.Font = new Font("標楷體", 12, new FontStyle());
            numericUpDown1.Size = new Size(50, 300);
            numericUpDown1.Text = sizex.ToString();
            numericUpDown1.Maximum = sizex;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Increment = 1;
            numericUpDown1.KeyPress += NumericUpDown_KeyPress;
            numericUpDown2.Location = new Point(label2.Left + label2.Width + 20, label2.Top);
            numericUpDown2.Font = new Font("標楷體", 12, new FontStyle());
            numericUpDown2.Size = new Size(50, 300);
            numericUpDown2.Text = sizey.ToString();
            numericUpDown2.Maximum = sizey;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Increment = 1;
            numericUpDown2.KeyPress += NumericUpDown_KeyPress;
            button1.Location = new Point(numericUpDown2.Left, numericUpDown2.Top + numericUpDown2.Height + 10);
            button1.Font = new Font("標楷體", 12, new FontStyle());
            button1.Text = "重置";
            button1.AutoSize = true;
            timer1.Interval = 10;
            rest(this);
        }
        
        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < sizex; i++)
            {
                for (int j = 0; j < sizey; j++)
                {
                    if ((PictureBox)sender == p1[i, j])
                    {
                        pitb1[i, j] = true;
                        return;
                    }
                    else if ((PictureBox)sender == p2[i, j])
                    {
                        pitb2[i, j] = true;
                        return;
                    }
                }
            }
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < sizex; i++)
            {
                for (int j = 0; j < sizey; j++)
                {
                    if (pitb1[i, j] && p1[i, j].Image != null)
                    {
                        if (p1[i, j].Left < groupBox1.Left)
                        {
                            p1[i, j].Left = groupBox1.Left;
                            return;
                        }
                        else if (p1[i, j].Left + p1[i, j].Width > groupBox1.Left + groupBox1.Width)
                        {
                            p1[i, j].Left = groupBox1.Left + groupBox1.Width - p1[i, j].Width;
                            return;
                        }
                        if (p1[i, j].Top < groupBox1.Top)
                        {
                            p1[i, j].Top = groupBox1.Top;
                            return;
                        }
                        else if (p1[i, j].Top + p1[i, j].Height > groupBox1.Top + groupBox1.Height)
                        {
                            p1[i, j].Top = groupBox1.Top + groupBox1.Height - p1[i, j].Height;
                            return;
                        }
                        p1[i, j].Left += e.X - p1[i, j].Width / 2;
                        p1[i, j].Top += e.Y - p1[i, j].Height / 2;
                    }
                    else if (pitb2[i, j] && p2[i, j].Image != null)
                    {
                        if (p2[i, j].Left < groupBox1.Left)
                        {
                            p2[i, j].Left = groupBox1.Left;
                            return;
                        }
                        else if (p2[i, j].Left + p2[i, j].Width > groupBox1.Left + groupBox1.Width)
                        {
                            p2[i, j].Left = groupBox1.Left + groupBox1.Width - p2[i, j].Width;
                            return;
                        }
                        if (p2[i, j].Top < groupBox1.Top)
                        {
                            p2[i, j].Top = groupBox1.Top;
                            return;
                        }
                        else if (p2[i, j].Top + p2[i, j].Height > groupBox1.Top + groupBox1.Height)
                        {
                            p2[i, j].Top = groupBox1.Top + groupBox1.Height - p2[i, j].Height;
                            return;
                        }
                        p2[i, j].Left += e.X - p2[i, j].Width / 2;
                        p2[i, j].Top += e.Y - p2[i, j].Height / 2;
                    }
                }
            }
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            int ii = 0, jj = 0;
            bool tb = false, cb1 = false, cb2 = false, bp12 = false;
            for (int i = 0; i < sizex; i++)
            {
                for (int j = 0; j < sizey; j++)
                {
                    if ((PictureBox)sender == p1[i, j])
                    {
                        ii = i;
                        jj = j;
                        cb1 = true;
                        cb2 = true;
                        bp12 = true;
                        pitb1[i, j] = false;
                        for (int k = 0; k < sizex; k++)
                        {
                            for (int l = 0; l < sizey; l++)
                            {
                                if (((p1[i, j].Left + p1[i, j].Width / 2) - p2[k, l].Left < p2[k, l].Width) && ((p1[i, j].Left + p1[i, j].Width / 2) - p2[k, l].Left > 0) && ((p1[i, j].Top + p1[i, j].Height / 2) - p2[k, l].Top < p2[k, l].Height) && ((p1[i, j].Top + p1[i, j].Height / 2) - p2[k, l].Top > 0))
                                {
                                    if (imup[i, j] == imdo[k, l])
                                    {
                                        correct++;
                                        p1[i, j].Image = null;
                                        p1[i, j].Location = new Point(groupBox1.Left + groupBox1.Width, groupBox1.Top);
                                        p2[k, l].Image = null;
                                        p2[k, l].Location = new Point(groupBox1.Left + groupBox1.Width, groupBox1.Top);
                                        label4.Text = "正確次數: " + correct + " 次 ， 錯誤次數: " + error + " 次。";
                                        if (correct == sizex * sizey)
                                        {
                                            timer1.Enabled = false;
                                            label3.Text = "信息:恭喜過關!共歷時 " + timer.ToString("f2") + " 秒";
                                        }
                                        else
                                        {
                                            label3.Text = "信息:正確!";
                                        }
                                        return;
                                    }
                                    else
                                        tb = true;
                                }
                            }
                        }
                    }
                    else if ((PictureBox)sender == p2[i, j])
                    {
                        ii = i;
                        jj = j;
                        cb1 = true;
                        cb2 = true;
                        pitb2[i, j] = false;
                        for (int k = 0; k < sizex; k++)
                        {
                            for (int l = 0; l < sizey; l++)
                            {
                                if (((p2[i, j].Left + p2[i, j].Width / 2) - p1[k, l].Left < p1[k, l].Width) && ((p2[i, j].Left + p2[i, j].Width / 2) - p1[k, l].Left > 0) && ((p2[i, j].Top + p2[i, j].Height / 2) - p1[k, l].Top < p1[k, l].Height) && ((p2[i, j].Top + p2[i, j].Height / 2) - p1[k, l].Top > 0))
                                {
                                    if (imup[k, l] == imdo[i, j])
                                    {
                                        correct++;
                                        p1[k, l].Image = null;
                                        p1[k, l].Location = new Point(groupBox1.Left + groupBox1.Width, groupBox1.Top);
                                        p2[i, j].Image = null;
                                        p2[i, j].Location = new Point(groupBox1.Left + groupBox1.Width, groupBox1.Top);
                                        label4.Text = "正確次數: " + correct + " 次 ， 錯誤次數: " + error + " 次。";
                                        if (correct == sizex * sizey)
                                        {
                                            timer1.Enabled = false;
                                            label3.Text = "信息:恭喜過關!共歷時 " + timer.ToString("f2") + " 秒";
                                        }
                                        else
                                        {
                                            label3.Text = "信息:正確!";
                                        }
                                        return;
                                    }
                                    else
                                        tb = true;
                                }
                            }
                        }
                    }
                    if (cb2)
                        break;
                }
                if (cb1)
                    break;
            }
            if (tb)
            {
                error++;
                label3.Text = "信息:錯誤!";
            }
            else
            {
                se++;
                label3.Text = "信息:請正確滑動游標!";
            }
            if (bp12)
                ((PictureBox)sender).Location = new Point(imupxy[ii, jj, 0], imupxy[ii, jj, 1]);
            else
                ((PictureBox)sender).Location = new Point(imdoxy[ii, jj, 0], imdoxy[ii, jj, 1]);
            label4.Text = "正確次數: " + correct + " 次 ， 錯誤次數: " + error + " 次。";
            label5.Text = "滑動失誤: " + se + " 次。";
        }

        private void Two_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rest(button1);
        }

        private void NumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Delete || e.KeyChar == (char)ConsoleKey.Backspace || e.KeyChar == (char)ConsoleKey.UpArrow || e.KeyChar == (char)ConsoleKey.DownArrow) 
            {
            }
            else if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                rest(button1);
                e.Handled = true;
            }
            else if (e.KeyChar < 49 || e.KeyChar > 51)
            {
                e.Handled = true;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += 0.01;
            label6.Text = "經過秒數: " + timer.ToString("f2") + " 秒";
        }

        private void rest(object sender)
        {
            if (sender == button1)
                for (int i = 0; i < sizex; i++)
                {
                    for (int j = 0; j < sizey; j++)
                    {
                        p1[i, j].Image = null;
                        p2[i, j].Image = null;
                    }
                }
            if (!int.TryParse(numericUpDown1.Value.ToString(), out sizex) || !int.TryParse(numericUpDown2.Value.ToString(), out sizey))
            {
                label3.Text = "信息:請在文字方塊內輸入正常數值!";
                return;
            }
            int t1 = 0;
            bool b = true, bb = true;
            Random r = new Random();
            correct = 0;
            error = 0;
            se = 0;
            timer = 0;
            imup = new int[sizex, sizey];
            imdo = new int[sizex, sizey];
            imupxy = new int[sizex, sizey, 2];
            imdoxy = new int[sizex, sizey, 2];
            pitb1 = new bool[sizex, sizey];
            pitb2 = new bool[sizex, sizey];
            label3.Text = "信息:";
            label4.Text = "正確次數: " + correct + " 次 ， 錯誤次數: " + error + " 次。";
            label5.Text = "滑動失誤: " + se + " 次。";
            timer1.Enabled = true;
            if (sender == this)
            {
                p1 = new PictureBox[sizex, sizey];
                p2 = new PictureBox[sizex, sizey];
                p1[0, 0] = new PictureBox() { Location = new Point(groupBox1.Location.X + 10, groupBox1.Location.Y + 20), Size = new Size(100, 100), SizeMode = PictureBoxSizeMode.StretchImage };
                p2[0, 0] = new PictureBox() { Location = new Point(p1[0, 0].Location.X + 600, p1[0, 0].Location.Y), Size = p1[0, 0].Size, SizeMode = p1[0, 0].SizeMode };
                for (int i = 0; i < sizex; i++)
                {
                    for (int j = 0; j < sizey; j++)
                    {
                        if (i != 0 || j != 0)
                        {
                            p1[i, j] = new PictureBox() { Location = new Point(p1[0, 0].Location.X + i * (p1[0, 0].Width + 5), p1[0, 0].Location.Y + j * (p1[0, 0].Height + 5)), Size = p1[0, 0].Size, SizeMode = p1[0, 0].SizeMode };
                        }
                        imupxy[i, j, 0] = p1[i, j].Left;
                        imupxy[i, j, 1] = p1[i, j].Top;
                        p1[i, j].MouseDown += Mouse_Down;
                        p1[i, j].MouseMove += Mouse_Move;
                        p1[i, j].MouseUp += Mouse_Up;
                        p1[i, j].DoubleClick += Two_Click;
                        groupBox1.Controls.Add(p1[i, j]);
                    }
                }
                for (int i = 0; i < sizex; i++)
                {
                    for (int j = 0; j < sizey; j++)
                    {
                        if (i != 0 || j != 0)
                        {
                            p2[i, j] = new PictureBox() { Location = new Point(p2[0, 0].Location.X + i * (p2[0, 0].Width + 5), p2[0, 0].Location.Y + j * (p2[0, 0].Height + 5)), Size = p2[0, 0].Size, SizeMode = p2[0, 0].SizeMode };
                        }
                        imdoxy[i, j, 0] = p2[i, j].Left;
                        imdoxy[i, j, 1] = p2[i, j].Top;
                        p2[i, j].MouseDown += Mouse_Down;
                        p2[i, j].MouseMove += Mouse_Move;
                        p2[i, j].MouseUp += Mouse_Up;
                        p2[i, j].DoubleClick += Two_Click;
                        groupBox1.Controls.Add(p2[i, j]);
                    }
                }
            }
            else
            {
                p1[0, 0].Location = new Point(groupBox1.Location.X + 10, groupBox1.Location.Y + 20);
                p2[0, 0].Location = new Point(p1[0, 0].Location.X + 600, p1[0, 0].Location.Y);
                for (int i = 0; i < sizex; i++)
                {
                    for (int j = 0; j < sizey; j++)
                    {
                        if (i != 0 || j != 0)
                        {
                            p1[i, j].Location = new Point(p1[0, 0].Location.X + i * (p1[0, 0].Width + 5), p1[0, 0].Location.Y + j * (p1[0, 0].Height + 5));
                            p2[i, j].Location = new Point(p2[0, 0].Location.X + i * (p2[0, 0].Width + 5), p2[0, 0].Location.Y + j * (p2[0, 0].Height + 5));
                        }
                        imupxy[i, j, 0] = p1[i, j].Left;
                        imupxy[i, j, 1] = p1[i, j].Top;
                        imdoxy[i, j, 0] = p2[i, j].Left;
                        imdoxy[i, j, 1] = p2[i, j].Top;
                    }
                }
            }
            for (int i = 0; i < sizex; i++)
            {
                for (int j = 0; j < sizey; j++)
                {
                    do
                    {
                        t1 = r.Next(0, imageList1.Images.Count);
                        b = true;
                        foreach (var item in imup)
                        {
                            if (t1 == item)
                            {
                                b = false;
                            }
                        }
                    } while (!b);
                    imup[i, j] = t1;
                    p1[i, j].Image = imageList1.Images[t1];
                }
            }
            for (int i = 0; i < sizex; i++)
            {
                for (int j = 0; j < sizey; j++)
                {
                    do
                    {
                        t1 = r.Next(0, imageList1.Images.Count);
                        b = true;
                        bb = false;
                        foreach (var item in imup)
                        {
                            if (t1 == item)
                            {
                                bb = true;
                                break;
                            }
                        }
                        foreach (var item in imdo)
                        {
                            if (t1 == item)
                            {
                                b = false;
                                break;
                            }
                        }
                    } while (!b || !bb);
                    imdo[i, j] = t1;
                    p2[i, j].Image = imageList2.Images[t1];
                }
            }
        }
    }
}

