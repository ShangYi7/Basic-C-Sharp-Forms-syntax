namespace p6_25_song
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < no.Length; i++)    //�]�wno�}�C�����
            {
                no[i] = i + 1;
            }
            button1_Click(sender, e);     // ����button1_Click�ƥ�禡
        }

        // song�r��}�C�s��q���W��
        string[] song = new string[] { "�����֦ӧ@���q", "�l�i���y","��Ӫ��ڭ�",
          "����", "�~����", "���y", "�����", "�ѯu����","�W���䨭", "�@�����֪����|" };
        //singer�r��}�C�s��q��m�W
        string[] singer = new string[] { "�L�T��", "���L��", "�����", "�P�N��",
                 "����Y", "���a�E", "�L�T��", "�L�ɹ�","���L��", "���q��" };
        int[] no = new int[10];                // no��ư}�C�s��ƦW

        private void BtnSortno_Click(object sender, EventArgs e)
        {
            string[] no2 = new string[no.Length];
            no.CopyTo(no2, 0);
            Array.Sort(no, song);
            Array.Sort (no2, singer);
            string msg = "�ƦW\t�q��\t�q��\t"+Environment.NewLine;

        }

        private void button1_Click(object sender, EventArgs e)
        // �� <�̺q��W�r�Ƨ�> �s��
        {
            string[] singer2 = new string[singer.Length]; // �ŧi�r��}�C�A�j�p�M singer �}�C�ۦP
            singer.CopyTo(singer2, 0); 		// �N singer �}�C�����e�ƻs�� singer2 �}�C
            Array.Sort(singer, no);  		// singer �}�C���W�ƧǡAno �}�C�P�B�վ�
            Array.Sort(singer2, song);  	// singer2 �}�C���W�ƧǡAsone �}�C�P�B�վ�
            //�ݭn��� Array.Sort ,�]���u��Ψ�Ӱ}�C,�ҥH�ƻs�@�ӬۦP���}�C,��song�P�B

            string msg = "�ƦW\t�q��\t�q��" + Environment.NewLine;
            for (int i = 0; i < song.Length; i++)
            {
                msg += $"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
            }
            textBox2.Text = msg;  // ��ܸ�Ƥ��e
        }

        private void button2_Click(object sender, EventArgs e)
        //�� <�̺q���j�M> �s��
        {
            string search = textBox1.Text;   // ���o�ϥΪ̬d�ߪ��q��m�W
            string msg = $"�䤣��{search}";  // �w�]�䤣��
            int index = Array.IndexOf(song, search); // �Ĥ@���ŦX�����ޭ�
            if (index >= 0) //�Y�����۲Ū����
            {
                msg = "�ƦW\t�q��\t�q��" + Environment.NewLine;
                while (index >= 0)   // ��index >= 0�~��j��
                {   // ��ܸ�Ƥ��e
                    msg += $"{no[index]} \t {singer[index]} \t {song[index]}";
                    msg += Environment.NewLine;
                    // �q�U�@���~��j�M
                    index = Array.IndexOf(song, search, index + 1);
                };
            }
            textBox2.Text = msg;  // ��ܸ�Ƥ��e
        }

\
    }
}