namespace p5_16_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            PicShow.SizeMode=PictureBoxSizeMode.StretchImage;
            PicShow.Image = pictureBox1.Image;
        }
        private void Stretch()
        {
            for (int h = 20; h <= 240; h += 10)
            {
                PicShow.Size = new Size(h, h);
                DateTime now = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - now).TotalSeconds < 0.05);
            }
        }
        private void Stretch1()
        {
            for (int h = 240; h >= 20; h -= 10)
            {
                PicShow.Size = new Size(h, h);
                DateTime now = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - now).TotalSeconds < 0.05);
            }
        }
        private void Stretch2()
        {
            for (int y = 20; y <= 240; y += 10)
            {
                PicShow.Size = new Size(240, y);
                DateTime now = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - now).TotalSeconds < 0.05);
            }
        }
        private void Stretch3()
        {
            for (int x = 20; x <= 240; x += 10)
            {
                PicShow.Size = new Size(x, 240);
                DateTime now = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - now).TotalSeconds < 0.05);
            }
        }
        private void Stretch4()
        {
            for (int y = 20; y <= 240; y += 10)

            {
                PicShow.Size = new Size(240, y);
                DateTime now = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - now).TotalSeconds < 0.05);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PicShow.Image = pictureBox1.Image;
            Stretch();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PicShow.Image = pictureBox2.Image;
            Stretch1();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PicShow.Image = pictureBox3.Image;
            Stretch2();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PicShow.Image = pictureBox4.Image;
            Stretch3();
        }
    }
}