namespace StudentHousing
{
    partial class Home
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
            btnChores = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblHouseName = new Label();
            btnAdmin = new Button();
            btnLogIn = new Button();
            btnExit = new Button();
            label2 = new Label();
            btnShoppingPanel = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnRules = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            announcementsPanel = new Panel();
            lbDate = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnChores
            // 
            btnChores.BackColor = Color.FromArgb(137, 128, 245);
            btnChores.FlatStyle = FlatStyle.Flat;
            btnChores.Font = new Font("Segoe UI", 12F);
            btnChores.Location = new Point(856, 156);
            btnChores.Margin = new Padding(2, 4, 2, 4);
            btnChores.Name = "btnChores";
            btnChores.Size = new Size(346, 384);
            btnChores.TabIndex = 0;
            btnChores.Text = "Clean the kitchen(Alexander Stoyanov)\r\nThrow out the trash(Jessie Chen)\r\n";
            btnChores.UseVisualStyleBackColor = false;
            btnChores.Click += btnChores_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblHouseName);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1786, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_removebg_preview__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 14);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 81);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblHouseName
            // 
            lblHouseName.AutoSize = true;
            lblHouseName.BackColor = Color.FromArgb(0, 2, 24, 158);
            lblHouseName.Font = new Font("Segoe UI", 19F, FontStyle.Bold | FontStyle.Italic);
            lblHouseName.ForeColor = SystemColors.Control;
            lblHouseName.Location = new Point(150, 26);
            lblHouseName.Margin = new Padding(2, 0, 2, 0);
            lblHouseName.Name = "lblHouseName";
            lblHouseName.Size = new Size(487, 51);
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
            btnAdmin.Location = new Point(1508, 0);
            btnAdmin.Margin = new Padding(2, 4, 2, 4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(92, 100);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Visible = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(137, 128, 245);
            btnLogIn.Cursor = Cursors.Hand;
            btnLogIn.Dock = DockStyle.Right;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Location = new Point(1600, 0);
            btnLogIn.Margin = new Padding(2, 4, 2, 4);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(92, 100);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Profile";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(137, 128, 245);
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(1692, 0);
            btnExit.Margin = new Padding(2, 4, 2, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 100);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(176, 404);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(373, 46);
            label2.TabIndex = 7;
            label2.Text = "Latest Announcements";
            label2.Click += label2_Click;
            // 
            // btnShoppingPanel
            // 
            btnShoppingPanel.BackColor = Color.FromArgb(137, 128, 245);
            btnShoppingPanel.FlatStyle = FlatStyle.Flat;
            btnShoppingPanel.Location = new Point(856, 630);
            btnShoppingPanel.Margin = new Padding(2, 4, 2, 4);
            btnShoppingPanel.Name = "btnShoppingPanel";
            btnShoppingPanel.Size = new Size(346, 368);
            btnShoppingPanel.TabIndex = 9;
            btnShoppingPanel.Text = "1kg Tomatoes\r\n1L  milk\r\n500g Chicken breasts\r\n";
            btnShoppingPanel.UseVisualStyleBackColor = false;
            btnShoppingPanel.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(137, 128, 245);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1371, 156);
            button2.Margin = new Padding(2, 4, 2, 4);
            button2.Name = "button2";
            button2.Size = new Size(339, 384);
            button2.TabIndex = 10;
            button2.Text = "Complaints this week: 1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 544);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(951, 544);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 46);
            label4.TabIndex = 12;
            label4.Text = "Chores";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(899, 1004);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(230, 46);
            label5.TabIndex = 13;
            label5.Text = "Shopping List";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1446, 544);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(194, 46);
            label6.TabIndex = 14;
            label6.Text = "Complaints";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1491, 1004);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 46);
            label7.TabIndex = 16;
            label7.Text = "Rules";
            // 
            // btnRules
            // 
            btnRules.BackColor = Color.FromArgb(137, 128, 245);
            btnRules.FlatStyle = FlatStyle.Flat;
            btnRules.Location = new Point(1371, 630);
            btnRules.Margin = new Padding(2, 4, 2, 4);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(339, 370);
            btnRules.TabIndex = 15;
            btnRules.Text = "Time untill rent payment : 7d\r\nAmount: 800€\r\n";
            btnRules.UseVisualStyleBackColor = false;
            btnRules.Click += btnRules_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.Location = new Point(43, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 728);
            panel2.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.Controls.Add(announcementsPanel);
            panel3.Controls.Add(lbDate);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(18, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(728, 919);
            panel3.TabIndex = 17;
            // 
            // announcementsPanel
            // 
            announcementsPanel.BackColor = Color.FromArgb(137, 128, 245);
            announcementsPanel.Location = new Point(23, 366);
            announcementsPanel.Name = "announcementsPanel";
            announcementsPanel.Size = new Size(537, 352);
            announcementsPanel.TabIndex = 18;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.BackColor = Color.Transparent;
            lbDate.Font = new Font("Segoe UI", 63F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbDate.ForeColor = Color.FromArgb(137, 128, 245);
            lbDate.Location = new Point(162, 34);
            lbDate.Margin = new Padding(4, 0, 4, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(396, 334);
            lbDate.TabIndex = 17;
            lbDate.Text = "16.12\n2024";
            lbDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources._9538280;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1786, 1106);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(btnRules);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnShoppingPanel);
            Controls.Add(panel1);
            Controls.Add(btnChores);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChores;
        private Panel panel1;
        private Button btnExit;
        private Label label2;
        private Button btnLogIn;
        private Button btnShoppingPanel;
        private Button button2;
        private Button btnAdmin;
        private Label lblHouseName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnRules;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label lbDate;
        private Panel announcementsPanel;
    }
}