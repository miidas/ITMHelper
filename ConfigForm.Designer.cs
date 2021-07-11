
namespace ITMHelper
{
    partial class ConfigForm
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
            this.fontColorPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontOutlineColorPic = new System.Windows.Forms.PictureBox();
            this.fontSelectButton = new System.Windows.Forms.Button();
            this.fontOutlineWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fontColorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineColorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // fontColorPic
            // 
            this.fontColorPic.Location = new System.Drawing.Point(12, 25);
            this.fontColorPic.Name = "fontColorPic";
            this.fontColorPic.Size = new System.Drawing.Size(25, 25);
            this.fontColorPic.TabIndex = 0;
            this.fontColorPic.TabStop = false;
            this.fontColorPic.Click += new System.EventHandler(this.fontColorPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font Outline Color";
            // 
            // fontOutlineColorPic
            // 
            this.fontOutlineColorPic.Location = new System.Drawing.Point(73, 25);
            this.fontOutlineColorPic.Name = "fontOutlineColorPic";
            this.fontOutlineColorPic.Size = new System.Drawing.Size(25, 25);
            this.fontOutlineColorPic.TabIndex = 3;
            this.fontOutlineColorPic.TabStop = false;
            this.fontOutlineColorPic.Click += new System.EventHandler(this.fontOutlineColorPic_Click);
            // 
            // fontSelectButton
            // 
            this.fontSelectButton.Location = new System.Drawing.Point(280, 25);
            this.fontSelectButton.Name = "fontSelectButton";
            this.fontSelectButton.Size = new System.Drawing.Size(86, 23);
            this.fontSelectButton.TabIndex = 4;
            this.fontSelectButton.Text = "Font Select";
            this.fontSelectButton.UseVisualStyleBackColor = true;
            this.fontSelectButton.Click += new System.EventHandler(this.fontSelectButton_Click);
            // 
            // fontOutlineWidth
            // 
            this.fontOutlineWidth.DecimalPlaces = 1;
            this.fontOutlineWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fontOutlineWidth.Location = new System.Drawing.Point(170, 27);
            this.fontOutlineWidth.Name = "fontOutlineWidth";
            this.fontOutlineWidth.Size = new System.Drawing.Size(45, 20);
            this.fontOutlineWidth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Font Outline Width";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 68);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fontOutlineWidth);
            this.Controls.Add(this.fontSelectButton);
            this.Controls.Add(this.fontOutlineColorPic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fontColorPic);
            this.Name = "ConfigForm";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fontColorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineColorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fontColorPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox fontOutlineColorPic;
        private System.Windows.Forms.Button fontSelectButton;
        private System.Windows.Forms.NumericUpDown fontOutlineWidth;
        private System.Windows.Forms.Label label3;
    }
}