using Discord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeckCord
{
    public partial class DMChannels : Form
    {
        List<IDMChannel> dmChannels = new List<IDMChannel>();

        public DMChannels()
        {
            InitializeComponent();
        }

        private void DMChannels_ClientSizeChanged(object sender, EventArgs e)
        {
            label1.Location = new Point((ClientSize.Width / 2) - (label1.Width / 2), label1.Location.Y);
        }

        private void DMChannels_Load(object sender, EventArgs e)
        {
            dmchannellist.Items.Clear();
            foreach (var now in GlobalVars.client.DMChannels)
            {
                dmchannellist.Items.Add(now.Recipient.Username);
                dmChannels.Add(now);
            }
            label1.Text = label1.Text.Replace("{USR_NAME}", GlobalVars.client.CurrentUser.Username);
            DMChannels_ClientSizeChanged(sender, e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dmchannellist_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            IDMChannel channel = dmChannels[dmchannellist.Items.IndexOf(dmchannellist.SelectedItem)];
            List<IReadOnlyCollection<IMessage>> msgsraw = channel.GetMessagesAsync(limit: int.MaxValue).ToList().Result;
            foreach (IReadOnlyCollection<IMessage> now1 in msgsraw)
            {
                foreach (IMessage msg in now1.Reverse())
                {
                    richTextBox1.Text = richTextBox1.Text + "\n" + msg.Author + "\n" + msg.Content + "\n\n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button2Clickhandler().GetAwaiter().GetResult();
        }

        async Task Button2Clickhandler()
        {
            await dmChannels[dmchannellist.Items.IndexOf(dmchannellist.SelectedItem)].TriggerTypingAsync();
        }

        private void dmchannellist_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                rightClickPanel.Location = e.Location;
                rightClickPanel.Visible = true;
            }else if(e.Button == MouseButtons.Left)
            {
                if(e.X > rightClickPanel.Location.X && e.X < rightClickPanel.Location.X + rightClickPanel.Width)
                {
                    if (e.Y > rightClickPanel.Location.Y && e.Y < rightClickPanel.Location.Y + rightClickPanel.Height)
                    {

                    }else
                    {
                        rightClickPanel.Visible = false;
                    }
                }
                else
                {
                    rightClickPanel.Visible = false;
                }
            }
        }

        private void DMChannels_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X > rightClickPanel.Location.X && e.X < rightClickPanel.Location.X + rightClickPanel.Width)
                {
                    if (e.Y > rightClickPanel.Location.Y && e.Y < rightClickPanel.Location.Y + rightClickPanel.Height)
                    {

                    }
                    else
                    {
                        rightClickPanel.Visible = false;
                    }
                }
                else
                {
                    rightClickPanel.Visible = false;
                }
            }
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X > rightClickPanel.Location.X && e.X < rightClickPanel.Location.X + rightClickPanel.Width)
            {
                if (e.Y > rightClickPanel.Location.Y && e.Y < rightClickPanel.Location.Y + rightClickPanel.Height)
                {

                }
                else
                {
                    rightClickPanel.Visible = false;
                }
            }
            else
            {
                rightClickPanel.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(dmChannels[dmchannellist.SelectedIndex].Recipient.GetAvatarUrl());
            rightClickPanel.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(dmChannels[dmchannellist.SelectedIndex].Recipient.Username + "'s account got created at " + dmChannels[dmchannellist.SelectedIndex].Recipient.CreatedAt.ToString().Split(" +")[0].Split(" ")[0] + " at time of " + dmChannels[dmchannellist.SelectedIndex].Recipient.CreatedAt.ToString().Split(" +")[0].Split(" ")[1] + "!", "HeckCord - Creation Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
            rightClickPanel.Visible = false;
        }
    }
}
