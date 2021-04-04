using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kfstorm.LrcParser;

namespace ITMHelper
{
    public partial class Main : Form
    {
        iTunesHelper ith = new iTunesHelper();

        Timer TickTimer; // for getting the player position
        Timer InfoTimer; // for getting some informations

        LyricsDisplayForm displayForm;

        private long prevPlayerPosition = 0L;
        private long prevTimerCount = 0;
        private long prevTimerDivider = 0;

        private int prevPlayerState = -1;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            TickTimer = new Timer();
            TickTimer.Interval = 55; // Call the event handler every 55 ms
            TickTimer.Tick += new EventHandler(Main_Tick);
            TickTimer.Start();

            InfoTimer = new Timer();
            InfoTimer.Interval = 250; // Call the event handler every 250 ms
            InfoTimer.Tick += new EventHandler(Main_Info);
            InfoTimer.Start();

            displayForm = new LyricsDisplayForm();
            displayForm.ShowInTaskbar = false;
            displayForm.Show();

            this.ActiveControl = NowPlayingButton; // Setting the focus on NowPlaying button
        }

        dynamic prevTrack;

        private void Main_TrackChanged(dynamic currentTrack)
        {
            if (currentTrack != null)
            {
                // Clear current displayed text
                displayForm.currentText = "";
                displayForm.RefreshText();

                this.TitleTextBox.Text = currentTrack.Name;
                this.AlbumTextBox.Text = currentTrack.Album;
                this.ArtistTextBox.Text = currentTrack.Artist;

                var lyricsDir = System.Environment.CurrentDirectory + "\\Lyrics";
                if (Directory.Exists(lyricsDir))
                {
                    try
                    {
                        var lrcText = System.IO.File.ReadAllText($"{lyricsDir}\\{currentTrack.Name} - {currentTrack.Artist}.lrc");
                        displayForm.lrcFile = LrcFile.FromText(lrcText);

                    }
                    catch (FileNotFoundException ex)
                    {
                        // Do nothing
                    }
                }
            }
            else
            {
                this.TitleTextBox.Text = "";
                this.AlbumTextBox.Text = "";
                this.ArtistTextBox.Text = "";
            }
        }

        private void Main_Info(object sender, EventArgs e)
        {
            var currentTrack = ith.getCurrentTrack();

            if ((prevTrack == null && currentTrack != null) || (prevTrack != null && currentTrack == null)
                || ((prevTrack != null && currentTrack != null) && !String.Equals(currentTrack.Name, prevTrack.Name)))
            {
                Main_TrackChanged(currentTrack);
                prevTrack = currentTrack;
            }

            if (ShowLyricsCheckBox.Checked)
            {
                var playerState = ith.getPlayerState();
                if (playerState != prevPlayerState)
                {
                    Main_PlayerStateChanged(playerState);
                    prevPlayerState = playerState;
                }
            }
        }

        private void Main_PlayerStateChanged(int playerState)
        {
            if (playerState == 0x00) // ITPlayerStateStopped  
            {
                displayForm.HideLyrics();
            }
            else if (playerState == 0x01) // ITPlayerStatePlaying
            {
                displayForm.ShowLyrics();
            }
        }

        private void Main_Tick(object sender, EventArgs e)
        {
            // Need to use another timer or rethink the time synchronization algorithm...
            var position = ith.getPlayerPosition();
            if (position != null)
            {
                prevTimerCount++;

                if (prevTimerDivider != 0)
                {
                    if (position - prevPlayerPosition == 1)
                    {
                        displayForm.OnChangePlayerPosition(position);
                    }
                    else
                    {
                        displayForm.OnChangePlayerPosition(position + (1.0f / prevTimerDivider) * prevTimerCount);
                    }
                }

                if (position != prevPlayerPosition)
                {
                    if (position - prevPlayerPosition == 1)
                    {
                        prevTimerDivider = prevTimerCount;
                    }
                    prevPlayerPosition = position;
                    prevTimerCount = 0;
                }
            }
        }

        private void NowPlayingButton_Click(object sender, EventArgs e)
        {
            var tweetText = $"#Nowplaying {this.TitleTextBox.Text} - {this.ArtistTextBox.Text} ({this.AlbumTextBox.Text})";
            System.Diagnostics.Process.Start("https://twitter.com/intent/tweet?text=" + System.Net.WebUtility.UrlEncode(tweetText));
        }

        private void ShowLyricsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowLyricsCheckBox.Checked)
            {
                prevPlayerState = -1; // Reset the player state
            }
            else
            {
                displayForm.HideLyrics();
            }
        }
    }
}
