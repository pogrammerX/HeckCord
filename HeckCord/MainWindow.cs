using Discord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeckCord
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button2Clickhandler().GetAwaiter().GetResult();
        }

        async Task Button2Clickhandler()
        {
            await GlobalVars.client.SetGameAsync(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DMChannels().Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            while(GlobalVars.client.CurrentUser == null)
            {
                Thread.Sleep(1);
                Application.DoEvents();
            }
            new WebClient().DownloadFile(GlobalVars.client.CurrentUser.GetAvatarUrl(), Application.StartupPath + "\\pfp.png");
            userpfp.Image = new Bitmap(Application.StartupPath + "\\pfp.png");
            label1.Text = GlobalVars.client.CurrentUser.Username + "#" + GlobalVars.client.CurrentUser.Discriminator;
        }
    }
}
