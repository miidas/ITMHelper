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

        private string currentText = null;

        private bool EnableLyrics = true;

        public void OnChangePlayerPosition(double position)
        {
            if (lrcFile == null) return;

            // Check if the mouse pointer is in the Window
            if (this.currentLyricsWindow != null)
            {
                if (this.EnableLyrics)
                {
                    if (this.currentLyricsWindow.ClientRectangle.Contains(currentLyricsWindow.PointToClient(Control.MousePosition)))
                    {
                        this.currentLyricsWindow.Hide();
                        return;
                    }
                    if (!this.currentLyricsWindow.Visible)
                    {
                        this.currentLyricsWindow.Show();
                    }
                }
                else
                {
                    this.currentLyricsWindow.Hide();
                }
            }

            position += 1.0f; // TODO: Configure the time offset of lrc from settings 

            IOneLineLyric lineLyric = lrcFile.BeforeOrAt(TimeSpan.FromSeconds(position));

            if (lineLyric == null) return;

            IOneLineLyric lineLyric2 = lrcFile.After(lineLyric.Timestamp);

            if (this.currentLyricsWindow != null)
            {
                if (String.Equals(lineLyric.Content, this.currentText)) return;
                this.currentLyricsWindow.Hide();
                this.currentLyricsWindow = null;
            }

            this.currentText = lineLyric.Content;

            if (String.IsNullOrEmpty(lineLyric.Content))
            {
                if (this.nextLyricsWindow == null && 
                    lineLyric2 != null && !String.IsNullOrEmpty(lineLyric2.Content))
                {
                    this.nextLyricsWindow = new LayeredLyricsWindow(lineLyric2.Content);
                }
            }
            else
            {
                if (this.nextLyricsWindow != null)
                {
                    this.currentLyricsWindow = this.nextLyricsWindow;
                    this.nextLyricsWindow = null;
                }
                else
                {
                    this.currentLyricsWindow = new LayeredLyricsWindow(currentText);
                }

                if (this.EnableLyrics)
                {
                    this.currentLyricsWindow.Show();
                }

                if (lineLyric2 != null && !String.IsNullOrEmpty(lineLyric2.Content))
                {
                    this.nextLyricsWindow = new LayeredLyricsWindow(lineLyric2.Content);
                }
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
        }

        public void SetLrcFile(ILrcFile lrcFile)
        {
            this.lrcFile = lrcFile;
        }

        public void OnTrackChanged(object track)
        {
            this.ClearLyrics();
        }

        public void OnChangePlayerPositionByUser()
        {
            this.ClearLyrics();
        }

        public void ClearLyrics()
        {
            if (this.currentLyricsWindow != null)
            {
                this.currentLyricsWindow.Hide();
                this.currentLyricsWindow = null;
            }
            this.nextLyricsWindow = null;
            this.currentText = null;
        }
    }
}
