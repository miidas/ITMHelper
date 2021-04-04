
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AlbumTextBox = new System.Windows.Forms.TextBox();
            this.ArtistTextBox = new System.Windows.Forms.TextBox();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.NowPlayingButton = new System.Windows.Forms.Button();
            this.ShowLyricsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(13, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TitleTextBox.Location = new System.Drawing.Point(16, 29);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(341, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // AlbumTextBox
            // 
            this.AlbumTextBox.Location = new System.Drawing.Point(16, 68);
            this.AlbumTextBox.Name = "AlbumTextBox";
            this.AlbumTextBox.ReadOnly = true;
            this.AlbumTextBox.Size = new System.Drawing.Size(341, 20);
            this.AlbumTextBox.TabIndex = 2;
            // 
            // ArtistTextBox
            // 
            this.ArtistTextBox.Location = new System.Drawing.Point(17, 107);
            this.ArtistTextBox.Name = "ArtistTextBox";
            this.ArtistTextBox.ReadOnly = true;
            this.ArtistTextBox.Size = new System.Drawing.Size(340, 20);
            this.ArtistTextBox.TabIndex = 3;
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Location = new System.Drawing.Point(13, 52);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(36, 13);
            this.AlbumLabel.TabIndex = 4;
            this.AlbumLabel.Text = "Album";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(14, 91);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(30, 13);
            this.ArtistLabel.TabIndex = 5;
            this.ArtistLabel.Text = "Artist";
            // 
            // NowPlayingButton
            // 
            this.NowPlayingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowPlayingButton.Location = new System.Drawing.Point(374, 29);
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
            this.ShowLyricsCheckBox.Location = new System.Drawing.Point(17, 134);
            this.ShowLyricsCheckBox.Name = "ShowLyricsCheckBox";
            this.ShowLyricsCheckBox.Size = new System.Drawing.Size(79, 17);
            this.ShowLyricsCheckBox.TabIndex = 7;
            this.ShowLyricsCheckBox.Text = "Show lyrics";
            this.ShowLyricsCheckBox.UseVisualStyleBackColor = true;
            this.ShowLyricsCheckBox.CheckedChanged += new System.EventHandler(this.ShowLyricsCheckBox_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 160);
            this.Controls.Add(this.ShowLyricsCheckBox);
            this.Controls.Add(this.NowPlayingButton);
            this.Controls.Add(this.ArtistLabel);
            this.Controls.Add(this.AlbumLabel);
            this.Controls.Add(this.ArtistTextBox);
            this.Controls.Add(this.AlbumTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "ITMHelper";
            this.Load += new System.EventHandler(this.Main_Load);
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
    }
}

