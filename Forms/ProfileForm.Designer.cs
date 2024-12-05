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
            btnBack = new Button();
            lblHouseName = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(30, 216);
            label2.Name = "label2";
            label2.Size = new Size(94, 35);
            label2.TabIndex = 2;
            label2.Text = "Name :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.Transparent;
            lbName.Font = new Font("Segoe UI", 15F);
            lbName.ForeColor = SystemColors.ControlLightLight;
            lbName.Location = new Point(151, 216);
            lbName.Name = "lbName";
            lbName.Size = new Size(0, 35);
            lbName.TabIndex = 3;
            // 
            // lblTenantBuilding
            // 
            lblTenantBuilding.AutoSize = true;
            lblTenantBuilding.BackColor = Color.Transparent;
            lblTenantBuilding.Font = new Font("Segoe UI", 15F);
            lblTenantBuilding.ForeColor = SystemColors.ControlLightLight;
            lblTenantBuilding.Location = new Point(151, 254);
            lblTenantBuilding.Name = "lblTenantBuilding";
            lblTenantBuilding.Size = new Size(0, 35);
            lblTenantBuilding.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 100);
            panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(137, 128, 245);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F);
            btnBack.Location = new Point(26, 28);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 38);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            pictureBox1.BackColor = Color.FromArgb(100, 0, 0, 0);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(26, 254);
            label1.Name = "label1";
            label1.Size = new Size(98, 35);
            label1.TabIndex = 7;
            label1.Text = "House :";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blob_scene_haikei;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 885);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblTenantBuilding);
            Controls.Add(lbName);
            Controls.Add(label2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            Text = "Profile";
            panel1.ResumeLayout(false);
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
        private Label label1;
        private Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}