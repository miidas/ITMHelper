using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMHelper
{
    class LyricsTextForm : Form
    {
        public LyricsTextForm()
        {
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var form = this.Owner as LyricsDisplayForm;
            string str = form.currentText;

            if (String.IsNullOrEmpty(str))
            {
                form.Hide();
                return;
            }

            if (!form.Visible)
            {
                form.Show();
            }

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;

            // Draw lyrics
            GraphicsPath gp = new GraphicsPath();

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            gp.AddString(str, new FontFamily("MS Gothic"), (int)FontStyle.Regular, 34, new Point(0, 0), sf);

            this.Width = (int) Math.Round(gp.GetBounds().Width) + 80; // TODO: fix

            gp.Reset();

            gp.AddString(str, new FontFamily("MS Gothic"), (int)FontStyle.Regular, 34, new Point((int) Math.Round((this.Width / 2) * 1.00), (int) Math.Round((this.Height / 2) * 1.1)), sf);

            var lp = new Point(
                (System.Windows.Forms.Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                form.Location.Y
            );

            this.Location = lp;
            form.Location = lp;
            form.Width = this.Width;

            Pen drawPen = new Pen(Color.Blue, 3.0F);
            Brush fillBrush = new SolidBrush(Color.White);

            e.Graphics.DrawPath(drawPen, gp);
            e.Graphics.FillPath(fillBrush, gp);

            drawPen.Dispose();
            fillBrush.Dispose();
        }
    }
}
