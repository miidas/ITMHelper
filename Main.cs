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

        LyricsDisplay lyricsDisplay;

        private int prevPlayerState = -1;
        private int playerState = -1;

        private long prevPlayerPosition = -1L;
        private double prevPos = 0.0;
        private DateTime? prevDate;

        private string lrcPath = null;

        private object prevTrack;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var lyricsDir = System.Environment.CurrentDirectory + "\\Lyrics";
            if (!Directory.Exists(lyricsDir))
            {
                Directory.CreateDirectory(lyricsDir);
            }

            TickTimer = new Timer();
            TickTimer.Interval = 55; // Call the event handler every 55 ms
            TickTimer.Tick += new EventHandler(Main_Tick);
            TickTimer.Start();

            InfoTimer = new Timer();
            InfoTimer.Interval = 250; // Call the event handler every 250 ms
            InfoTimer.Tick += new EventHandler(Main_Info);
            InfoTimer.Start();

            lyricsDisplay = new LyricsDisplay();

            this.ActiveControl = NowPlayingButton; // Setting the focus on NowPlaying button

            System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.RealTime; // Change app priority?
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            ith.Dispose();
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
                lyricsDisplay.OnTrackChanged(currentTrackObj);

                // Clear current player position
                this.prevDate = null;

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

                    var lrcFile = LrcFile.FromText(lrcText);
                    lyricsDisplay.SetLrcFile(lrcFile);
                }
                catch (Exception ex) // TODO
                {
                    lyricsDisplay.SetLrcFile(null);
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

            try
            {
                if ((prevTrack == null && currentTrack != null) || (prevTrack != null && currentTrack == null)
                    || ((prevTrack != null && currentTrack != null) && ((dynamic)currentTrack).TrackDatabaseID != ((dynamic)prevTrack).TrackDatabaseID))
                {
                    Main_TrackChanged(currentTrack);
                    prevTrack = currentTrack;
                }
            }
            catch (COMException ex) // TODO
            {
                //
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
                lyricsDisplay.HideLyrics();
            }
            else if (playerState == 0x01) // ITPlayerStatePlaying
            {
                lyricsDisplay.ShowLyrics();
            }
            this.playerState = playerState;
        }

        private void Main_Tick(object sender, EventArgs e)
        {
            if (playerState == 0x00) return; // ITPlayerStateStopped

            var position = (dynamic) ith.getPlayerPosition();
            if (position != null)
            {
                if (this.prevDate.HasValue)
                {
                    // Need to implement the step/slew mode like ntp
                    var pos = position - (position - prevPlayerPosition) + DateTime.Now.Subtract(this.prevDate.Value).TotalSeconds;
                    if (pos < prevPos)
                    {
                        //Console.WriteLine($"Wooosh! PS:{prevPos}, CP:{position}");
                    }
                    else
                    {
                        lyricsDisplay.OnChangePlayerPosition(pos);
                    }
                    prevPos = position;
                }

                if (position != prevPlayerPosition)
                {
                    if (position - prevPlayerPosition == 1)
                    {
                        this.prevDate = DateTime.Now;
                    }
                    else
                    {
                        this.prevPos = 0;
                        this.prevDate = null;
                        lyricsDisplay.OnChangePlayerPositionByUser();
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
                lyricsDisplay.HideLyrics();
            }
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
            lyricsDisplay.HideLyrics();
            var form = new ConfigForm();
            form.FormClosed += (cs, ce) => {
                lyricsDisplay.ClearLyrics(); // Clear cache
                lyricsDisplay.ShowLyrics();
            };
            form.ShowDialog(this);
        }
    }
}
