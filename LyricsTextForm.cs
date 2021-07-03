using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
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

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;

            // Draw lyrics
            using (GraphicsPath gp = new GraphicsPath())
            {
                StringFormat sf = new StringFormat();

                Pen drawPen = new Pen(Color.Blue, 3.0F);
                Brush fillBrush = new SolidBrush(Color.White);
             
                gp.AddString("o", new FontFamily("MS Gothic"), (int)FontStyle.Regular, e.Graphics.DpiY * 28 / 72f, new Point(0, 0), sf);
                RectangleF spaceBound = gp.GetBounds();
                gp.Reset();

                gp.AddString(str, new FontFamily("MS Gothic"), (int)FontStyle.Regular, e.Graphics.DpiY * 28 / 72f, new Point(0, 0), sf);

                RectangleF rect = gp.GetBounds();

                this.Width = (int) Math.Round(rect.Width + spaceBound.Width * 5.15);
                this.Height = (int) Math.Round(rect.Height + spaceBound.Height);

                var lp = new Point(
                    (Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                    form.Location.Y
                );

                this.Location = lp;
                form.Location = lp;
                form.Width = this.Width;
                form.Height = this.Height;

                Matrix matrix = new Matrix();
                matrix.Translate(-rect.X, -rect.Y);
                matrix.Translate((this.Width - rect.Width) / 2, (this.Height - rect.Height) / 2);
                gp.Transform(matrix);

                e.Graphics.DrawPath(drawPen, gp);
                e.Graphics.FillPath(fillBrush, gp);

                drawPen.Dispose();
                fillBrush.Dispose();
            } 
        }
    }
}
