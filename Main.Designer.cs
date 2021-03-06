
namespace ITMHelper
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AlbumTextBox = new System.Windows.Forms.TextBox();
            this.ArtistTextBox = new System.Windows.Forms.TextBox();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.NowPlayingButton = new System.Windows.Forms.Button();
            this.ShowLyricsCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLrcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutITMHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.notifyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(8, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TitleTextBox.Location = new System.Drawing.Point(11, 40);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(341, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // AlbumTextBox
            // 
            this.AlbumTextBox.Location = new System.Drawing.Point(11, 79);
            this.AlbumTextBox.Name = "AlbumTextBox";
            this.AlbumTextBox.ReadOnly = true;
            this.AlbumTextBox.Size = new System.Drawing.Size(341, 20);
            this.AlbumTextBox.TabIndex = 2;
            // 
            // ArtistTextBox
            // 
            this.ArtistTextBox.Location = new System.Drawing.Point(12, 118);
            this.ArtistTextBox.Name = "ArtistTextBox";
            this.ArtistTextBox.ReadOnly = true;
            this.ArtistTextBox.Size = new System.Drawing.Size(340, 20);
            this.ArtistTextBox.TabIndex = 3;
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Location = new System.Drawing.Point(8, 63);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(36, 13);
            this.AlbumLabel.TabIndex = 4;
            this.AlbumLabel.Text = "Album";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(9, 102);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(30, 13);
            this.ArtistLabel.TabIndex = 5;
            this.ArtistLabel.Text = "Artist";
            // 
            // NowPlayingButton
            // 
            this.NowPlayingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowPlayingButton.Location = new System.Drawing.Point(382, 39);
            this.NowPlayingButton.Name = "NowPlayingButton";
            this.NowPlayingButton.Size = new System.Drawing.Size(164, 98);
            this.NowPlayingButton.TabIndex = 6;
            this.NowPlayingButton.Text = "NowPlaying";
            this.NowPlayingButton.UseVisualStyleBackColor = true;
            this.NowPlayingButton.Click += new System.EventHandler(this.NowPlayingButton_Click);
            // 
            // ShowLyricsCheckBox
            // 
            this.ShowLyricsCheckBox.AutoSize = true;
            this.ShowLyricsCheckBox.Checked = true;
            this.ShowLyricsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowLyricsCheckBox.Location = new System.Drawing.Point(12, 144);
            this.ShowLyricsCheckBox.Name = "ShowLyricsCheckBox";
            this.ShowLyricsCheckBox.Size = new System.Drawing.Size(79, 17);
            this.ShowLyricsCheckBox.TabIndex = 7;
            this.ShowLyricsCheckBox.Text = "Show lyrics";
            this.ShowLyricsCheckBox.UseVisualStyleBackColor = true;
            this.ShowLyricsCheckBox.CheckedChanged += new System.EventHandler(this.ShowLyricsCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editLrcToolStripMenuItem,
            this.configToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editLrcToolStripMenuItem
            // 
            this.editLrcToolStripMenuItem.Name = "editLrcToolStripMenuItem";
            this.editLrcToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.editLrcToolStripMenuItem.Text = "Edit lrc";
            this.editLrcToolStripMenuItem.Click += new System.EventHandler(this.editLrcToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.configToolStripMenuItem.Text = "Preference";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutITMHelperToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutITMHelperToolStripMenuItem
            // 
            this.aboutITMHelperToolStripMenuItem.Name = "aboutITMHelperToolStripMenuItem";
            this.aboutITMHelperToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aboutITMHelperToolStripMenuItem.Text = "About ITMHelper";
            this.aboutITMHelperToolStripMenuItem.Click += new System.EventHandler(this.aboutITMHelperToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyMenuStrip;
            this.notifyIcon.Text = "ITMHelper";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // notifyMenuStrip
            // 
            this.notifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.exitMenuItem});
            this.notifyMenuStrip.Name = "notifyMenuStrip";
            this.notifyMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 168);
            this.Controls.Add(this.ShowLyricsCheckBox);
            this.Controls.Add(this.NowPlayingButton);
            this.Controls.Add(this.ArtistLabel);
            this.Controls.Add(this.AlbumLabel);
            this.Controls.Add(this.ArtistTextBox);
            this.Controls.Add(this.AlbumTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "ITMHelper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.notifyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox AlbumTextBox;
        private System.Windows.Forms.TextBox ArtistTextBox;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Button NowPlayingButton;
        private System.Windows.Forms.CheckBox ShowLyricsCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLrcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutITMHelperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    }
}

