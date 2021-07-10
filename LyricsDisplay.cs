using Kfstorm.LrcParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMHelper
{
    class LyricsDisplay
    {
        private ILrcFile lrcFile = null;

        private LayeredLyricsWindow currentLyricsWindow = null;
        private LayeredLyricsWindow nextLyricsWindow = null;

        private bool EnableLyrics = true;
        private bool ForceUpdate = false;

        public void OnChangePlayerPosition(double position)
        {
            if (lrcFile == null) return;

            // Check if the mouse pointer is in the Window
            if (this.currentLyricsWindow != null)
            {
                if (this.currentLyricsWindow.ClientRectangle.Contains(currentLyricsWindow.PointToClient(Control.MousePosition)) || !this.EnableLyrics)
                {
                    this.currentLyricsWindow.Hide();
                    return;
                }
                else if (this.EnableLyrics && !this.currentLyricsWindow.Visible)
                {
                    this.currentLyricsWindow.Show();
                }
            }

            position += 1.0f; // TODO: Configure the time offset of lrc from settings 

            IOneLineLyric lineLyric = lrcFile.BeforeOrAt(TimeSpan.FromSeconds(position));
            IOneLineLyric lineLyric2 = null;

            if (lineLyric != null)
            {
                lineLyric2 = lrcFile.BeforeOrAt(lineLyric.Timestamp);
            }

            if (lineLyric == null || String.IsNullOrEmpty(lineLyric.Content))
            {
                if (this.currentLyricsWindow != null)
                {
                    this.currentLyricsWindow.Dispose();
                    this.currentLyricsWindow = null;
                }
            }
            else if (this.currentLyricsWindow == null || !String.Equals(lineLyric.Content, this.currentLyricsWindow.Text) || this.ForceUpdate)
            {
                if (this.currentLyricsWindow != null)
                {
                    this.currentLyricsWindow.Hide();
                }
                this.currentLyricsWindow = this.nextLyricsWindow;

                if (this.currentLyricsWindow == null) this.currentLyricsWindow = new LayeredLyricsWindow(lineLyric.Content);
                this.currentLyricsWindow.Show();

                if (lineLyric2 != null && !String.IsNullOrEmpty(lineLyric2.Content))
                {
                    this.nextLyricsWindow = new LayeredLyricsWindow(lineLyric2.Content);
                }

                this.ForceUpdate = false;
            }
        }

        public void HideLyrics()
        {
            this.EnableLyrics = false;
            if (this.currentLyricsWindow != null) this.currentLyricsWindow.Hide();
        }

        public void ShowLyrics()
        {
            this.EnableLyrics = true;
            this.ForceUpdate = true;
        }

        public void SetLrcFile(ILrcFile lrcFile)
        {
            this.lrcFile = lrcFile;
        }

        public void OnTrackChanged(object track)
        {
            if (this.currentLyricsWindow != null) this.currentLyricsWindow.Hide();
            this.nextLyricsWindow = null;
        }

        public void OnChangePlayerPositionByUser()
        {
            if (this.currentLyricsWindow != null) this.currentLyricsWindow.Hide();
            this.nextLyricsWindow = null;
        }
    }
}
