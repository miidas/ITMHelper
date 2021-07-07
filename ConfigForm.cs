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
        private onChangeConfig onChangeConfigCallback;

        public ConfigForm()
        {
            InitializeComponent();

            fontColorPic.BackColor = ColorTranslator.FromHtml(AppConfig.FontColor);
            fontOutlineColorPic.BackColor = ColorTranslator.FromHtml(AppConfig.FontOutlineColor);
            fontOutlineWidth.Value = (decimal) AppConfig.FontOutlineWidth;
        }

        public delegate void onChangeConfig();

        public void setChangeConfigCallback(onChangeConfig onChangeConfigCallback)
        {
            this.onChangeConfigCallback = onChangeConfigCallback;
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
                onChangeConfigCallback();
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
                onChangeConfigCallback();
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
                onChangeConfigCallback();
            }
        }

        private void fontOutlineWidth_ValueChanged(object sender, EventArgs e)
        {
            if (onChangeConfigCallback == null) return;
            AppConfig.FontOutlineWidth = (int)fontOutlineWidth.Value;
            onChangeConfigCallback();
        }
    }
}
