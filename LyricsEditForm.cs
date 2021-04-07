using System;
using System.IO;
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
    public partial class LyricsEditForm : Form
    {
        private string lrcFilePath;

        public LyricsEditForm(string lrcFilePath)
        {
            this.lrcFilePath = lrcFilePath;

            InitializeComponent();
        }

        private void LyricsEditForm_Load(object sender, EventArgs e)
        {
            this.Text = this.lrcFilePath;

            try
            {
                this.lrcTextBox.Text = System.IO.File.ReadAllText(this.lrcFilePath);
            }
            catch (Exception ex)
            {
                // do nothing
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(this.lrcFilePath, this.lrcTextBox.Text);
            this.Close();

            var form = this.Owner as Main;
            form.Main_ReloadLyrics();
        }
    }
}
