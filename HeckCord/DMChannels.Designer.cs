
namespace HeckCord
{
    partial class DMChannels
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dmchannellist = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rightClickPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rightClickPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "DM Channels of {USR_NAME}";
            // 
            // dmchannellist
            // 
            this.dmchannellist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dmchannellist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.dmchannellist.ForeColor = System.Drawing.Color.White;
            this.dmchannellist.FormattingEnabled = true;
            this.dmchannellist.ItemHeight = 41;
            this.dmchannellist.Location = new System.Drawing.Point(1, 97);
            this.dmchannellist.Name = "dmchannellist";
            this.dmchannellist.Size = new System.Drawing.Size(300, 865);
            this.dmchannellist.TabIndex = 1;
            this.dmchannellist.DoubleClick += new System.EventHandler(this.dmchannellist_DoubleClick);
            this.dmchannellist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dmchannellist_MouseDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(308, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1107, 863);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // rightClickPanel
            // 
            this.rightClickPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.rightClickPanel.Controls.Add(this.button2);
            this.rightClickPanel.Controls.Add(this.button1);
            this.rightClickPanel.Location = new System.Drawing.Point(1207, 12);
            this.rightClickPanel.Name = "rightClickPanel";
            this.rightClickPanel.Size = new System.Drawing.Size(200, 318);
            this.rightClickPanel.TabIndex = 3;
            this.rightClickPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 109);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy pfp Url";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 134);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Creation Date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DMChannels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1419, 964);
            this.Controls.Add(this.rightClickPanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dmchannellist);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1451, 1052);
            this.Name = "DMChannels";
            this.Text = "DM Channels";
            this.Load += new System.EventHandler(this.DMChannels_Load);
            this.ClientSizeChanged += new System.EventHandler(this.DMChannels_ClientSizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DMChannels_MouseDown);
            this.rightClickPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox dmchannellist;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel rightClickPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}