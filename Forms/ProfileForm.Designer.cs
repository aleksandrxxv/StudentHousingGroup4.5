namespace StudentHousing
{
    partial class ProfileForm
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
            label2 = new Label();
            lbName = new Label();
            lblTenantBuilding = new Label();
            panel1 = new Panel();
            lblHouseName = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 244);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Name :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(83, 244);
            lbName.Name = "lbName";
            lbName.Size = new Size(0, 20);
            lbName.TabIndex = 3;
            // 
            // lblTenantBuilding
            // 
            lblTenantBuilding.AutoSize = true;
            lblTenantBuilding.Location = new Point(18, 286);
            lblTenantBuilding.Name = "lblTenantBuilding";
            lblTenantBuilding.Size = new Size(50, 20);
            lblTenantBuilding.TabIndex = 4;
            lblTenantBuilding.Text = "label3";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(lblHouseName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 61);
            panel1.TabIndex = 5;
            // 
            // lblHouseName
            // 
            lblHouseName.AutoSize = true;
            lblHouseName.BackColor = Color.FromArgb(0, 2, 24, 158);
            lblHouseName.Font = new Font("Segoe UI", 20F);
            lblHouseName.ForeColor = SystemColors.Control;
            lblHouseName.Location = new Point(528, 7);
            lblHouseName.Margin = new Padding(2, 0, 2, 0);
            lblHouseName.Name = "lblHouseName";
            lblHouseName.Size = new Size(407, 46);
            lblHouseName.TabIndex = 4;
            lblHouseName.Text = "Student Housing Platform";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MediumPurple;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(198, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Location = new Point(126, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 5;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 593);
            Controls.Add(pictureBox1);
            Controls.Add(lblTenantBuilding);
            Controls.Add(lbName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ProfileForm";
            Text = "Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lbName;
        private Label lblTenantBuilding;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblHouseName;
        private Panel panel2;
    }
}