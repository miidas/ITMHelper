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

            //e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            Font myFont = new System.Drawing.Font("MS Gothic", 34, FontStyle.Regular);
            SizeF stringSize = e.Graphics.MeasureString(str, myFont);

            this.Width = (int) stringSize.Width;

            gp.AddString(str, new FontFamily("MS Gothic"),
                (int)FontStyle.Regular, 34,
                new Point(this.Width / 2, (this.Height / 2) + 2), sf);

            var lp = new Point(
                (System.Windows.Forms.Screen.GetBounds(this).Width / 2) - (this.Width / 2),
                form.Location.Y
            );

            this.Location = lp;
            form.Location = lp;
            form.Width = this.Width;

            //パスの線分を描画
            Pen drawPen = new Pen(Color.Blue, 3.0F);

            e.Graphics.DrawPath(drawPen, gp);

            //塗る
            Brush fillBrush = new SolidBrush(Color.White);

            e.Graphics.FillPath(fillBrush, gp);

            drawPen.Dispose();
            fillBrush.Dispose();
        }
    }
}
