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
using System.Diagnostics;
using System.Runtime.InteropServices;
using Kfstorm.LrcParser;

namespace ITMHelper
{
    public partial class Main : Form
    {
        iTunesHelper ith = new iTunesHelper();

        Timer TickTimer; // for getting the player position
        Timer InfoTimer; // for getting some informations

        LyricsDisplayForm displayForm;

        private int prevPlayerState = -1;

        private long prevPlayerPosition = -1L;
        private DateTime? prevDate;

        private string lrcPath = null;

        private object prevTrack;

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

            this.ActiveControl = NowPlayingButton; // Setting the focus on NowPlaying button

            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.RealTime; // Change app priority?
        }

        public void Main_ReloadLyrics()
        {
            var currentTrack = ith.getCurrentTrack();
            Main_TrackChanged(currentTrack);
        }

        private void Main_TrackChanged(object currentTrackObj)
        {
            if (currentTrackObj != null)
            {
                // Clear current displayed text
                displayForm.currentText = "";
                displayForm.RefreshText();

                var currentTrack = (dynamic) currentTrackObj;

                try
                {
                    this.TitleTextBox.Text = currentTrack.Name;
                    this.AlbumTextBox.Text = currentTrack.Album;
                    this.ArtistTextBox.Text = currentTrack.Artist;
                }
                catch (COMException ex)
                {
                    return;
                }

                var lyricsDir = System.Environment.CurrentDirectory + "\\Lyrics";
                if (Directory.Exists(lyricsDir))
                {
                    try
                    {
                        // Use escaped filename instead of TrackDatabaseID for readability
                        this.lrcPath = $"{lyricsDir}\\" 
                            + String.Join(
                                "_", 
                                $"{currentTrack.Name} - {currentTrack.Artist}.lrc"
                                .Split(System.IO.Path.GetInvalidFileNameChars(), StringSplitOptions.RemoveEmptyEntries)
                                )
                            .TrimEnd('.');
                        var lrcText = System.IO.File.ReadAllText(this.lrcPath);

                        displayForm.lrcFile = LrcFile.FromText(lrcText);
                        //displayForm.ShowLyrics();
                    }
                    catch (Exception ex) // TODO
                    {
                        displayForm.lrcFile = null;
                        //displayForm.HideLyrics();
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

            if (prevTrack != null && !ith.IsTrackInLibrary(prevTrack))
            {
                prevTrack = null;
            }

            if ((prevTrack == null && currentTrack != null) || (prevTrack != null && currentTrack == null)
                || ((prevTrack != null && currentTrack != null) && ((dynamic)currentTrack).TrackDatabaseID != ((dynamic)prevTrack).TrackDatabaseID))
            {
                Main_TrackChanged(currentTrack);
                prevTrack = currentTrack;
            }

            if (ShowLyricsCheckBox.Checked)
            {
                var playerState = (dynamic) ith.getPlayerState();
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
            var position = (dynamic) ith.getPlayerPosition();
            if (position != null)
            {
                if (this.prevDate.HasValue)
                {
                    // Need to implement the step/slew mode like ntp
                    displayForm.OnChangePlayerPosition(position - (position - prevPlayerPosition) + DateTime.Now.Subtract(this.prevDate.Value).TotalSeconds);
                }

                if (position != prevPlayerPosition)
                {
                    if (position - prevPlayerPosition == 1)
                    {
                        this.prevDate = DateTime.Now;
                    }
                    else
                    {
                        this.prevDate = null;
                    }
                    prevPlayerPosition = position;
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

        private void DelayTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutITMHelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ITMHelper Version {Application.ProductVersion}\niTunes Version {ith.getVersion()}", "About ITMHelper");
        }

        private void editLrcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentTrack = ith.getCurrentTrack();
            if (currentTrack != null)
            {
                var editForm = new LyricsEditForm(this.lrcPath);
                editForm.ShowDialog(this);
            }
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ConfigForm();
            form.setChangeConfigCallback(() => {
                displayForm.ReloadConfig();
            });
            form.ShowDialog(this);
        }
    }
}
