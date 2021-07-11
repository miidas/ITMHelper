using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMHelper
{
    public partial class ConfigForm : Form
    {
        private LayeredLyricsWindow previewLyricsWindow = null;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            fontColorPic.BackColor = ColorTranslator.FromHtml(AppConfig.FontColor);
            fontOutlineColorPic.BackColor = ColorTranslator.FromHtml(AppConfig.FontOutlineColor);
            fontOutlineWidth.Value = (decimal) AppConfig.FontOutlineWidth;
            fontOutlineWidth.ValueChanged += fontOutlineWidth_ValueChanged;
            displayIndex.Value = AppConfig.DisplayIndex;
            displayIndex.Maximum = Screen.AllScreens.Length - 1;
            displayIndex.ValueChanged += displayIndex_ValueChanged;
            displayXPos.Value = (decimal) AppConfig.DisplayPositionX;
            displayXPos.ValueChanged += displayXPos_ValueChanged;
            displayYPos.Value = (decimal) AppConfig.DisplayPositionY;
            displayYPos.ValueChanged += displayYPos_ValueChanged;

            this.previewLyricsWindow = new LayeredLyricsWindow("サンプルテキストです");
            this.previewLyricsWindow.Show();
        }

        private void fontColorPic_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = false;
            dialog.ShowHelp = true;
            dialog.Color = fontColorPic.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fontColorPic.BackColor = dialog.Color;
                AppConfig.FontColor = ColorTranslator.ToHtml(dialog.Color);
            }
        }

        private void fontOutlineColorPic_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = false;
            dialog.ShowHelp = true;
            dialog.Color = fontOutlineColorPic.BackColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fontOutlineColorPic.BackColor = dialog.Color;
                AppConfig.FontOutlineColor = ColorTranslator.ToHtml(dialog.Color);
                this.previewLyricsWindow.Redraw();
            }
        }

        private void fontSelectButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowEffects = false;
            dialog.Font = new Font(new FontFamily(AppConfig.FontFamily), AppConfig.FontSize, (FontStyle) AppConfig.FontStyle);

            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                AppConfig.FontFamily = dialog.Font.FontFamily.Name;
                AppConfig.FontSize = dialog.Font.Size;
                AppConfig.FontStyle = (int) dialog.Font.Style;
                this.previewLyricsWindow.Redraw();
            }
        }

        private void fontOutlineWidth_ValueChanged(object sender, EventArgs e)
        {
            AppConfig.FontOutlineWidth = (float) fontOutlineWidth.Value;
            this.previewLyricsWindow.Redraw();
        }

        private void displayIndex_ValueChanged(object sender, EventArgs e)
        {
            AppConfig.DisplayIndex = (int) displayIndex.Value;
            this.previewLyricsWindow.Redraw();
        }

        private void displayXPos_ValueChanged(object sender, EventArgs e)
        {
            AppConfig.DisplayPositionX = (float) displayXPos.Value;
            this.previewLyricsWindow.Redraw();
        }

        private void displayYPos_ValueChanged(object sender, EventArgs e)
        {
            AppConfig.DisplayPositionY = (float) displayYPos.Value;
            this.previewLyricsWindow.Redraw();
        }

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.previewLyricsWindow.Dispose();
        }
    }
}
