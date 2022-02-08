using System;
using System.Collections.Generic;
using System.ComponentModel;
using Discord.WebSocket;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace HeckCord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            label1.Location = new Point((this.ClientSize.Width / 2) - (label1.Width / 2), label1.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using ServiceProvider services1 = new ServiceCollection()
                    .AddSingleton<DiscordSocketClient>()
                    .BuildServiceProvider();

                DiscordSocketClient client1 = new DiscordSocketClient();

                client1 = services1.GetRequiredService<DiscordSocketClient>();

                await client1.LoginAsync(TokenType.User, textBox1.Text);

                await client1.StartAsync();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Invalid Token!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Invalid Token!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using ServiceProvider services = new ServiceCollection()
                .AddSingleton<DiscordSocketClient>()
                .BuildServiceProvider();

            DiscordSocketClient client = new DiscordSocketClient();

            client = services.GetRequiredService<DiscordSocketClient>();

            await client.LoginAsync(TokenType.User, textBox1.Text);
            await client.StartAsync();

            GlobalVars.client = client;
            GlobalVars.DiscordToken = textBox1.Text;

            Hide();
            new MainWindow().ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(Application.StartupPath + "\\htgyt.html", new string[] { "<!DOCTYPE html>", "<html>", "<body onload='window.open(\"https://www.youtube.com/watch?v=YEgFvgg7ZPI\", \"_self\")'></body></html>" });
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(Application.StartupPath + "\\htgyt.html")
            {
                UseShellExecute = true
            };
            p.Start();
            p.WaitForExit();
            Thread.Sleep(1000);
            File.Delete(Application.StartupPath + "\\htgyt.html");
        }
    }
}
