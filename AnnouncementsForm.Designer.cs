namespace StudentHousing
{
    partial class AnnouncementsForm
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
            panel1 = new Panel();
            lblHouseName = new Label();
            btnAdmin = new Button();
            btnLogIn = new Button();
            btnExit = new Button();
            label1 = new Label();
            btnBack = new Button();
            btnAddAnnouncement = new Button();
            panelAnnouncements = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(lblHouseName);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 64);
            panel1.TabIndex = 2;
            // 
            // lblHouseName
            // 
            lblHouseName.AutoSize = true;
            lblHouseName.BackColor = Color.FromArgb(0, 2, 24, 158);
            lblHouseName.Font = new Font("Segoe UI", 20F);
            lblHouseName.ForeColor = SystemColors.Control;
            lblHouseName.Location = new Point(422, 8);
            lblHouseName.Margin = new Padding(2, 0, 2, 0);
            lblHouseName.Name = "lblHouseName";
            lblHouseName.Size = new Size(407, 46);
            lblHouseName.TabIndex = 4;
            lblHouseName.Text = "Student Housing Platform";
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(137, 128, 245);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.Dock = DockStyle.Right;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Location = new Point(965, 0);
            btnAdmin.Margin = new Padding(2);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(59, 64);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Visible = false;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(137, 128, 245);
            btnLogIn.Cursor = Cursors.Hand;
            btnLogIn.Dock = DockStyle.Right;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Location = new Point(1024, 0);
            btnLogIn.Margin = new Padding(2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(59, 64);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Profile";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(137, 128, 245);
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1083, 0);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(60, 64);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 2, 24, 158);
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(9, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(407, 46);
            label1.TabIndex = 0;
            label1.Text = "Student Housing Platform";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(137, 128, 245);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F);
            btnBack.Location = new Point(9, 69);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 38);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAddAnnouncement
            // 
            btnAddAnnouncement.BackColor = Color.FromArgb(137, 128, 245);
            btnAddAnnouncement.FlatStyle = FlatStyle.Flat;
            btnAddAnnouncement.Font = new Font("Segoe UI", 12F);
            btnAddAnnouncement.Location = new Point(442, 116);
            btnAddAnnouncement.Margin = new Padding(2);
            btnAddAnnouncement.Name = "btnAddAnnouncement";
            btnAddAnnouncement.Size = new Size(274, 77);
            btnAddAnnouncement.TabIndex = 4;
            btnAddAnnouncement.Text = "Add new Announcement";
            btnAddAnnouncement.UseVisualStyleBackColor = false;
            btnAddAnnouncement.Click += btnAddAnnouncement_Click;
            // 
            // panelAnnouncements
            // 
            panelAnnouncements.AutoScroll = true;
            panelAnnouncements.Location = new Point(219, 207);
            panelAnnouncements.Name = "panelAnnouncements";
            panelAnnouncements.Size = new Size(695, 416);
            panelAnnouncements.TabIndex = 5;
            // 
            // AnnouncementsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9538280;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 743);
            Controls.Add(panelAnnouncements);
            Controls.Add(btnAddAnnouncement);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AnnouncementsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnnouncementsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblHouseName;
        private Button btnAdmin;
        private Button btnLogIn;
        private Button btnExit;
        private Label label1;
        private Button btnBack;
        private Button btnAddAnnouncement;
        private Panel panelAnnouncements;
    }
}