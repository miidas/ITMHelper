﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kfstorm.LrcParser;

namespace ITMHelper
{
    class LyricsDisplayForm : Form
    {
        public string currentText = "ITMHelper";
        public ILrcFile lrcFile = null;

        private LyricsTextForm textForm;

        public LyricsDisplayForm()
        {
            this.BackColor = Color.Black;
            this.Opacity = 0.7;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Size = new Size(400, 50);
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.Location = new Point(
                (System.Windows.Forms.Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                System.Windows.Forms.Screen.GetBounds(this).Height - this.Height - 40 // Y offset
            );

            textForm = new LyricsTextForm();
            textForm.StartPosition = FormStartPosition.Manual;
            textForm.DesktopLocation = PointToScreen(new Point(0, 0));
            textForm.ClientSize = this.ClientSize;
            textForm.Owner = this;
            textForm.ShowInTaskbar = false;
            textForm.Show();
        }

        public void OnChangePlayerPosition(float position)
        {
            if (lrcFile == null) return;

            var lineLyric = lrcFile.BeforeOrAt(TimeSpan.FromSeconds(position));

            if (lineLyric == null || String.Equals(lineLyric.Content, this.currentText)) return;

            this.currentText = lineLyric.Content;

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