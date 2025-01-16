namespace StudentHousing.Forms
{
    partial class AdminHomeForm
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
            pictureBox1 = new PictureBox();
            lblHouseName = new Label();
            btnLogOut = new Button();
            btnBuildings = new Button();
            btnUsers = new Button();
            btnComplaints = new Button();
            btnRules = new Button();
            btnChores = new Button();
            btnFines = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblHouseName);
            panel1.Controls.Add(btnLogOut);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 80);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_removebg_preview__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(18, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 65);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblHouseName
            // 
            lblHouseName.AutoSize = true;
            lblHouseName.BackColor = Color.FromArgb(0, 2, 24, 158);
            lblHouseName.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHouseName.ForeColor = SystemColors.Control;
            lblHouseName.Location = new Point(120, 21);
            lblHouseName.Margin = new Padding(2, 0, 2, 0);
            lblHouseName.Name = "lblHouseName";
            lblHouseName.Size = new Size(486, 45);
            lblHouseName.TabIndex = 4;
            lblHouseName.Text = "StudentNest Admin Dashboard";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(100, 0, 0, 0);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Dock = DockStyle.Right;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ForeColor = Color.WhiteSmoke;
            btnLogOut.Location = new Point(1313, 0);
            btnLogOut.Margin = new Padding(2, 3, 2, 3);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(98, 80);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnBuildings
            // 
            btnBuildings.BackColor = Color.FromArgb(157, 153, 204);
            btnBuildings.FlatStyle = FlatStyle.Flat;
            btnBuildings.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold);
            btnBuildings.Location = new Point(80, 102);
            btnBuildings.Margin = new Padding(2, 3, 2, 3);
            btnBuildings.Name = "btnBuildings";
            btnBuildings.Size = new Size(277, 307);
            btnBuildings.TabIndex = 13;
            btnBuildings.Text = "Manage Buildings";
            btnBuildings.UseVisualStyleBackColor = false;
            btnBuildings.Click += btnBuildings_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(157, 153, 204);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold);
            btnUsers.Location = new Point(570, 102);
            btnUsers.Margin = new Padding(2, 3, 2, 3);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(277, 307);
            btnUsers.TabIndex = 15;
            btnUsers.Text = "Manage Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnComplaints
            // 
            btnComplaints.BackColor = Color.FromArgb(157, 153, 204);
            btnComplaints.FlatStyle = FlatStyle.Flat;
            btnComplaints.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold);
            btnComplaints.Location = new Point(1043, 102);
            btnComplaints.Margin = new Padding(2, 3, 2, 3);
            btnComplaints.Name = "btnComplaints";
            btnComplaints.Size = new Size(277, 307);
            btnComplaints.TabIndex = 16;
            btnComplaints.Text = "View Complaints";
            btnComplaints.UseVisualStyleBackColor = false;
            btnComplaints.Click += btnComplaints_Click;
            // 
            // btnRules
            // 
            btnRules.BackColor = Color.FromArgb(157, 153, 204);
            btnRules.FlatStyle = FlatStyle.Flat;
            btnRules.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold);
            btnRules.Location = new Point(1043, 472);
            btnRules.Margin = new Padding(2, 3, 2, 3);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(277, 307);
            btnRules.TabIndex = 19;
            btnRules.Text = "Manage Rules";
            btnRules.UseVisualStyleBackColor = false;
            btnRules.Click += btnRules_Click;
            // 
            // btnChores
            // 
            btnChores.BackColor = Color.FromArgb(157, 153, 204);
            btnChores.FlatStyle = FlatStyle.Flat;
            btnChores.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold);
            btnChores.Location = new Point(570, 472);
            btnChores.Margin = new Padding(2, 3, 2, 3);
            btnChores.Name = "btnChores";
            btnChores.Size = new Size(277, 307);
            btnChores.TabIndex = 18;
            btnChores.Text = "Manage Chores";
            btnChores.UseVisualStyleBackColor = false;
            btnChores.Click += btnChores_Click;
            // 
            // btnFines
            // 
            btnFines.BackColor = Color.FromArgb(157, 153, 204);
            btnFines.FlatStyle = FlatStyle.Flat;
            btnFines.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold);
            btnFines.Location = new Point(80, 472);
            btnFines.Margin = new Padding(2, 3, 2, 3);
            btnFines.Name = "btnFines";
            btnFines.Size = new Size(277, 307);
            btnFines.TabIndex = 17;
            btnFines.Text = "Manage Fines";
            btnFines.UseVisualStyleBackColor = false;
            btnFines.Click += btnFines_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(157, 153, 204);
            pictureBox2.BackgroundImage = Properties.Resources.gear;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Enabled = false;
            pictureBox2.Location = new Point(706, 653);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 117);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(157, 153, 204);
            pictureBox3.BackgroundImage = Properties.Resources.skyline;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Enabled = false;
            pictureBox3.Location = new Point(232, 292);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 105);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(157, 153, 204);
            pictureBox4.BackgroundImage = Properties.Resources.group;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Enabled = false;
            pictureBox4.Location = new Point(714, 280);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 117);
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(157, 153, 204);
            pictureBox5.BackgroundImage = Properties.Resources.complain;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Enabled = false;
            pictureBox5.Location = new Point(1185, 280);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(125, 120);
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(157, 153, 204);
            pictureBox6.BackgroundImage = Properties.Resources.book;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Enabled = false;
            pictureBox6.Location = new Point(1185, 656);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(125, 114);
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(157, 153, 204);
            pictureBox7.BackgroundImage = Properties.Resources.administrative_fine;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Enabled = false;
            pictureBox7.Location = new Point(227, 659);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(125, 111);
            pictureBox7.TabIndex = 25;
            pictureBox7.TabStop = false;
            // 
            // AdminHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AdminBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1411, 838);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnRules);
            Controls.Add(btnChores);
            Controls.Add(btnFines);
            Controls.Add(btnComplaints);
            Controls.Add(btnUsers);
            Controls.Add(btnBuildings);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminHomeForm";
            Text = "AdminHomeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblHouseName;
        private Button btnLogOut;
        private Button btnBuildings;
        private Button btnUsers;
        private Button btnComplaints;
        private Button btnRules;
        private Button btnChores;
        private Button btnFines;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}