using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kfstorm.LrcParser;
using System.Drawing.Drawing2D;

namespace ITMHelper
{
    class LyricsDisplayForm : Form
    {
        public string currentText = "";
        public ILrcFile lrcFile = null;

        private LyricsTextForm textForm;

        public LyricsDisplayForm()
        {
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;
            this.Opacity = 0.7;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(400, 50);
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.Location = new Point(
                (Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                Screen.GetBounds(this).Height - this.Height - ((int)(Screen.GetBounds(this).Height * 0.037)) // Y offset
            );

            textForm = new LyricsTextForm();
            textForm.StartPosition = FormStartPosition.Manual;
            textForm.DesktopLocation = PointToScreen(new Point(0, 0));
            textForm.ClientSize = this.ClientSize;
            textForm.Owner = this;
            textForm.ShowInTaskbar = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0)), this.ClientRectangle);
        }

        //double prevPos = 0; // for debug
        public void OnChangePlayerPosition(double position)
        {
            /*if (position < prevPos)
            {
                Console.WriteLine($"Wooosh! PS:{prevPos}, CP:{position}");
            }
            Console.WriteLine($"POS: {position}, DIFF: {position - prevPos}");
            prevPos = position;*/

            if (lrcFile == null) return;

            // Check if the mouse pointer is in ClientRectangle
            if (this.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                ClearText();
                return;
            }

            position += 1.0f;

            var lineLyric = lrcFile.BeforeOrAt(TimeSpan.FromSeconds(position));

            if (lineLyric == null || lineLyric.Content == null)
            {
                ClearText();
            }
            else if (!String.Equals(lineLyric.Content, this.currentText))
            {
                this.currentText = lineLyric.Content;
                RefreshText();
            }
        }

        public void ClearText()
        {
            this.currentText = "";
            this.RefreshText();
        }

        public void RefreshText()
        {
            textForm.Refresh();
        }

        public void HideLyrics()
        {
            currentText = "";
            this.Hide();
            textForm.Hide();
        }
        public void ShowLyrics()
        {
            this.Show();
            textForm.Show();
        }
    }
}