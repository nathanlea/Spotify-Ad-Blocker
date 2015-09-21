namespace EZBlocker
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MuteButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.WebsiteLink = new System.Windows.Forms.LinkLabel();
            this.Heartbeat = new System.Windows.Forms.Timer(this.components);
            this.SpotifyMuteCheckbox = new System.Windows.Forms.CheckBox();
            this.VolumeMixerButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.BlockBannersCheckbox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrackName = new System.Windows.Forms.Label();
            this.AlbumName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MuteButton
            // 
            this.MuteButton.Location = new System.Drawing.Point(8, 342);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(111, 21);
            this.MuteButton.TabIndex = 3;
            this.MuteButton.Text = "Mute/UnMute Spotify";
            this.MuteButton.UseVisualStyleBackColor = true;
            this.MuteButton.Visible = false;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.BalloonTipClicked += new System.EventHandler(this.NotifyIcon_BalloonTipClicked);
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // WebsiteLink
            // 
            this.WebsiteLink.AutoSize = true;
            this.WebsiteLink.Location = new System.Drawing.Point(125, 353);
            this.WebsiteLink.Name = "WebsiteLink";
            this.WebsiteLink.Size = new System.Drawing.Size(84, 13);
            this.WebsiteLink.TabIndex = 5;
            this.WebsiteLink.TabStop = true;
            this.WebsiteLink.Text = "About/Info/FAQ";
            this.WebsiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebsiteLink_LinkClicked);
            // 
            // Heartbeat
            // 
            this.Heartbeat.Enabled = true;
            this.Heartbeat.Interval = 295000;
            this.Heartbeat.Tick += new System.EventHandler(this.Heartbeat_Tick);
            // 
            // SpotifyMuteCheckbox
            // 
            this.SpotifyMuteCheckbox.AutoSize = true;
            this.SpotifyMuteCheckbox.Checked = true;
            this.SpotifyMuteCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SpotifyMuteCheckbox.Location = new System.Drawing.Point(5, 191);
            this.SpotifyMuteCheckbox.Name = "SpotifyMuteCheckbox";
            this.SpotifyMuteCheckbox.Size = new System.Drawing.Size(109, 17);
            this.SpotifyMuteCheckbox.TabIndex = 6;
            this.SpotifyMuteCheckbox.Text = "Mute Only Spotify";
            this.SpotifyMuteCheckbox.UseVisualStyleBackColor = true;
            this.SpotifyMuteCheckbox.CheckedChanged += new System.EventHandler(this.SpotifyMuteCheckBox_CheckedChanged);
            // 
            // VolumeMixerButton
            // 
            this.VolumeMixerButton.Location = new System.Drawing.Point(12, 315);
            this.VolumeMixerButton.Name = "VolumeMixerButton";
            this.VolumeMixerButton.Size = new System.Drawing.Size(111, 21);
            this.VolumeMixerButton.TabIndex = 7;
            this.VolumeMixerButton.Text = "Open Volume Mixer";
            this.VolumeMixerButton.UseVisualStyleBackColor = true;
            this.VolumeMixerButton.Click += new System.EventHandler(this.VolumeMixerButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(3, 148);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(36, 13);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Artist: ";
            // 
            // BlockBannersCheckbox
            // 
            this.BlockBannersCheckbox.AutoSize = true;
            this.BlockBannersCheckbox.Checked = true;
            this.BlockBannersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlockBannersCheckbox.Location = new System.Drawing.Point(108, 191);
            this.BlockBannersCheckbox.Name = "BlockBannersCheckbox";
            this.BlockBannersCheckbox.Size = new System.Drawing.Size(95, 17);
            this.BlockBannersCheckbox.TabIndex = 10;
            this.BlockBannersCheckbox.Text = "Block Banners";
            this.BlockBannersCheckbox.UseVisualStyleBackColor = true;
            this.BlockBannersCheckbox.CheckedChanged += new System.EventHandler(this.SkipAdsCheckbox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 142);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TrackName
            // 
            this.TrackName.AutoSize = true;
            this.TrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackName.ForeColor = System.Drawing.Color.White;
            this.TrackName.Location = new System.Drawing.Point(3, 161);
            this.TrackName.Name = "TrackName";
            this.TrackName.Size = new System.Drawing.Size(41, 13);
            this.TrackName.TabIndex = 12;
            this.TrackName.Text = "Track: ";
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSize = true;
            this.AlbumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumName.ForeColor = System.Drawing.Color.White;
            this.AlbumName.Location = new System.Drawing.Point(3, 174);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(42, 13);
            this.AlbumName.TabIndex = 13;
            this.AlbumName.Text = "Album: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(200, 190);
            this.Controls.Add(this.AlbumName);
            this.Controls.Add(this.TrackName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BlockBannersCheckbox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.VolumeMixerButton);
            this.Controls.Add(this.SpotifyMuteCheckbox);
            this.Controls.Add(this.WebsiteLink);
            this.Controls.Add(this.MuteButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.RightToLeftLayout = true;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Form_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MuteButton;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.LinkLabel WebsiteLink;
        private System.Windows.Forms.Timer Heartbeat;
        private System.Windows.Forms.CheckBox SpotifyMuteCheckbox;
        private System.Windows.Forms.Button VolumeMixerButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.CheckBox BlockBannersCheckbox;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TrackName;
        private System.Windows.Forms.Label AlbumName;
    }
}

