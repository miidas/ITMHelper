
namespace ITMHelper
{
    partial class LyricsEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lrcTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lrcTextBox
            // 
            this.lrcTextBox.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrcTextBox.Location = new System.Drawing.Point(13, 13);
            this.lrcTextBox.Name = "lrcTextBox";
            this.lrcTextBox.Size = new System.Drawing.Size(775, 396);
            this.lrcTextBox.TabIndex = 0;
            this.lrcTextBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(713, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // LyricsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lrcTextBox);
            this.Name = "LyricsEditForm";
            this.Text = "LyricsEditForm";
            this.Load += new System.EventHandler(this.LyricsEditForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox lrcTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}