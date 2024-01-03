namespace p7_6_ScrollPic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PicShow.SizeMode=PictureBoxSizeMode.StretchImage;
            PicShow.Height = 90; PicShow.Width = 90;
            PicShow.Image = Image.FromFile("pic1.png");
            TkbPic.Maximum = 4;TkbPic.Minimum = 1;
            VsbHeight.Maximum = 180; VsbHeight.Minimum = 1;
            HsbWidth.LargeChange = 1;
            HsbWidth.Value = PicShow.Width;
            toolTip1.SetToolTip(VsbHeight, $"{VsbHeight.Value}");
            toolTip1.SetToolTip(HsbWidth, $"{HsbWidth.Value}");
            toolTip1.SetToolTip(TkbPic, "�Ϥ�1");
            toolTip1.SetToolTip(PicShow, $"pic{TkbPic.Value}.png");
        }

        private void VsbHeight_Scroll(object sender, ScrollEventArgs e)
        {
            PicShow.Height=VsbHeight.Value;
            toolTip1.SetToolTip(VsbHeight, $"{VsbHeight.Value}");
        }

        private void HsbWidth_Scroll(object sender, ScrollEventArgs e)
        {
            PicShow.Width = HsbWidth.Value;// �]�Ϥ��e��=HsbWidth��Value��
            toolTip1.SetToolTip(HsbWidth, $"{HsbWidth.Value}");
        }

        private void TkbPic_Scroll(object sender, EventArgs e)
        {
            // ���ʷưʶb�ɰ���
            PicShow.Image = Image.FromFile($"pic{TkbPic.Value}.png");
            toolTip1.SetToolTip(TkbPic, $"�Ϥ�{TkbPic.Value}");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PicShow.Image = Image.FromFile($"pic{numericUpDown1.Value}.png");
            numericUpDown1.Maximum = 4;
            numericUpDown1.Minimum = 1;
        }
    }
}