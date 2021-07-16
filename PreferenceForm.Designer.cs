
namespace ITMHelper
{
    partial class PreferenceForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.displayIndex = new System.Windows.Forms.NumericUpDown();
            this.displayYPos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.displayXPos = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timeOffset = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fontColorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineColorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayYPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayXPos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // fontColorPic
            // 
            this.fontColorPic.Location = new System.Drawing.Point(9, 36);
            this.fontColorPic.Name = "fontColorPic";
            this.fontColorPic.Size = new System.Drawing.Size(25, 25);
            this.fontColorPic.TabIndex = 0;
            this.fontColorPic.TabStop = false;
            this.fontColorPic.Click += new System.EventHandler(this.fontColorPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Outline color";
            // 
            // fontOutlineColorPic
            // 
            this.fontOutlineColorPic.Location = new System.Drawing.Point(50, 36);
            this.fontOutlineColorPic.Name = "fontOutlineColorPic";
            this.fontOutlineColorPic.Size = new System.Drawing.Size(25, 25);
            this.fontOutlineColorPic.TabIndex = 3;
            this.fontOutlineColorPic.TabStop = false;
            this.fontOutlineColorPic.Click += new System.EventHandler(this.fontOutlineColorPic_Click);
            // 
            // fontSelectButton
            // 
            this.fontSelectButton.Location = new System.Drawing.Point(202, 36);
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
            this.fontOutlineWidth.Location = new System.Drawing.Point(120, 38);
            this.fontOutlineWidth.Name = "fontOutlineWidth";
            this.fontOutlineWidth.Size = new System.Drawing.Size(45, 20);
            this.fontOutlineWidth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Outline width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fontColorPic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fontOutlineWidth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fontSelectButton);
            this.groupBox1.Controls.Add(this.fontOutlineColorPic);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.displayIndex);
            this.groupBox2.Controls.Add(this.displayYPos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.displayXPos);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 50);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position";
            // 
            // displayIndex
            // 
            this.displayIndex.Location = new System.Drawing.Point(47, 19);
            this.displayIndex.Name = "displayIndex";
            this.displayIndex.Size = new System.Drawing.Size(39, 20);
            this.displayIndex.TabIndex = 13;
            // 
            // displayYPos
            // 
            this.displayYPos.DecimalPlaces = 3;
            this.displayYPos.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.displayYPos.Location = new System.Drawing.Point(194, 19);
            this.displayYPos.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.displayYPos.Name = "displayYPos";
            this.displayYPos.Size = new System.Drawing.Size(51, 20);
            this.displayYPos.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Display";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // displayXPos
            // 
            this.displayXPos.DecimalPlaces = 3;
            this.displayXPos.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.displayXPos.Location = new System.Drawing.Point(117, 19);
            this.displayXPos.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.displayXPos.Name = "displayXPos";
            this.displayXPos.Size = new System.Drawing.Size(51, 20);
            this.displayXPos.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.openButton);
            this.groupBox3.Controls.Add(this.timeOffset);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 49);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lyrics";
            // 
            // timeOffset
            // 
            this.timeOffset.DecimalPlaces = 2;
            this.timeOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.timeOffset.Location = new System.Drawing.Point(64, 19);
            this.timeOffset.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timeOffset.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.timeOffset.Name = "timeOffset";
            this.timeOffset.Size = new System.Drawing.Size(55, 20);
            this.timeOffset.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Time offset";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(175, 16);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(111, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open Lyrics Folder";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // PreferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 209);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PreferenceForm";
            this.Text = "Preference";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PreferenceForm_FormClosed);
            this.Load += new System.EventHandler(this.PreferenceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fontColorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineColorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontOutlineWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayYPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayXPos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeOffset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fontColorPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox fontOutlineColorPic;
        private System.Windows.Forms.Button fontSelectButton;
        private System.Windows.Forms.NumericUpDown fontOutlineWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown displayYPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown displayXPos;
        private System.Windows.Forms.NumericUpDown displayIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown timeOffset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button openButton;
    }
}