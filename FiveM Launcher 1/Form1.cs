using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveM_Launcher_1
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Discord_link_Click(object sender, EventArgs e)
        {

            string DiscordLink = "https://discord.gg/pP23btXXcA"; //Your Discord link
            try
            {
                System.Diagnostics.Process.Start(DiscordLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法開啟連結:" + DiscordLink + "錯誤" + ex.Message);
            }
        }

        private void Join_Server_Click(object sender, EventArgs e)
        {
            
            try
            {
                System.Diagnostics.Process.Start($"https://cfx.re/join/za8zpd");
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤" + ex.Message);
            }
        }
    }
}
