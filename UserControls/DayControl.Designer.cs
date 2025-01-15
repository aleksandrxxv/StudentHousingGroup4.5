namespace StudentHousing
{
    partial class DayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbDay = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbDay
            // 
            lbDay.AutoSize = true;
            lbDay.Enabled = false;
            lbDay.Location = new Point(3, 0);
            lbDay.Name = "lbDay";
            lbDay.Size = new Size(17, 20);
            lbDay.TabIndex = 0;
            lbDay.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.cleaning;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = Properties.Resources.cleaning;
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 126);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DayControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbDay);
            Controls.Add(pictureBox1);
            Name = "DayControl";
            Size = new Size(148, 148);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDay;
        private PictureBox pictureBox1;
    }
}
