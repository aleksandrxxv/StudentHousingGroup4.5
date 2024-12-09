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
            lblHouseName = new Label();
            btnAdmin = new Button();
            btnLogIn = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            btnShoppingPanel = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnChores
            // 
            btnChores.BackColor = Color.FromArgb(137, 128, 245);
            btnChores.FlatStyle = FlatStyle.Flat;
            btnChores.Font = new Font("Segoe UI", 12F);
            btnChores.Location = new Point(685, 125);
            btnChores.Margin = new Padding(2, 3, 2, 3);
            btnChores.Name = "btnChores";
            btnChores.Size = new Size(277, 181);
            btnChores.TabIndex = 0;
            btnChores.Text = "Clean the kitchen(Alexander Stoyanov)\r\nThrow out the trash(Jessie Chen)\r\n";
            btnChores.UseVisualStyleBackColor = false;
            btnChores.Click += btnChores_Click;
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
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1429, 80);
            panel1.TabIndex = 1;
            // 
            // lblHouseName
            // 
            lblHouseName.AutoSize = true;
            lblHouseName.BackColor = Color.FromArgb(0, 2, 24, 158);
            lblHouseName.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHouseName.ForeColor = SystemColors.Control;
            lblHouseName.Location = new Point(528, 7);
            lblHouseName.Margin = new Padding(2, 0, 2, 0);
            lblHouseName.Name = "lblHouseName";
            lblHouseName.Size = new Size(422, 46);
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
            btnAdmin.Location = new Point(1206, 0);
            btnAdmin.Margin = new Padding(2, 3, 2, 3);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(74, 80);
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
            btnLogIn.Location = new Point(1280, 0);
            btnLogIn.Margin = new Padding(2, 3, 2, 3);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(74, 80);
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
            btnExit.Location = new Point(1354, 0);
            btnExit.Margin = new Padding(2, 3, 2, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 80);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 2, 24, 158);
            label1.Font = new Font("Yu Gothic UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(422, 46);
            label1.TabIndex = 0;
            label1.Text = "Student Housing Platform";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(693, 691);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(316, 40);
            label2.TabIndex = 7;
            label2.Text = "Latest Announcements";
            label2.Click += label2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(137, 128, 245);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(693, 734);
            listBox1.Margin = new Padding(2, 3, 2, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(661, 122);
            listBox1.TabIndex = 8;
            // 
            // btnShoppingPanel
            // 
            btnShoppingPanel.BackColor = Color.FromArgb(137, 128, 245);
            btnShoppingPanel.FlatStyle = FlatStyle.Flat;
            btnShoppingPanel.Location = new Point(685, 407);
            btnShoppingPanel.Margin = new Padding(2, 3, 2, 3);
            btnShoppingPanel.Name = "btnShoppingPanel";
            btnShoppingPanel.Size = new Size(271, 192);
            btnShoppingPanel.TabIndex = 9;
            btnShoppingPanel.Text = "1kg Tomatoes\r\n1L  milk\r\n500g Chicken breasts\r\n";
            btnShoppingPanel.UseVisualStyleBackColor = false;
            btnShoppingPanel.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(137, 128, 245);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1097, 125);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(271, 181);
            button2.TabIndex = 10;
            button2.Text = "Complaints this week: 1";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 435);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(772, 309);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 40);
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
            label5.Location = new Point(731, 602);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(196, 40);
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
            label6.Location = new Point(1157, 309);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(166, 40);
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
            label7.Location = new Point(1189, 602);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 40);
            label7.TabIndex = 16;
            label7.Text = "Rent";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(137, 128, 245);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1097, 407);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(271, 192);
            button3.TabIndex = 15;
            button3.Text = "Time untill rent payment : 7d\r\nAmount: 800€\r\n";
            button3.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources._9538280;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1429, 885);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnShoppingPanel);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnChores);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChores;
        private Panel panel1;
        private Label label1;
        private Button btnExit;
        private Label label2;
        private ListBox listBox1;
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
        private Button button3;
    }
}