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
            btn = new Button();
            panel1 = new Panel();
            btnAdmin = new Button();
            lblHouseName = new Label();
            btnLogIn = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn
            // 
            btn.BackColor = Color.FromArgb(137, 128, 245);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 12F);
            btn.Location = new Point(48, 69);
            btn.Margin = new Padding(2);
            btn.Name = "btn";
            btn.Size = new Size(298, 166);
            btn.TabIndex = 0;
            btn.Text = "Clean the kitchen(Alexander Stoyanov)\r\nThrow out the trash(Jessie Chen)\r\n";
            btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(lblHouseName);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 45);
            panel1.TabIndex = 1;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(137, 128, 245);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.Dock = DockStyle.Right;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Location = new Point(898, 0);
            btnAdmin.Margin = new Padding(2);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(65, 45);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Visible = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // lblHouseName
            // 
            lblHouseName.AutoSize = true;
            lblHouseName.BackColor = Color.FromArgb(0, 2, 24, 158);
            lblHouseName.Font = new Font("Segoe UI", 20F);
            lblHouseName.ForeColor = SystemColors.Control;
            lblHouseName.Location = new Point(386, 4);
            lblHouseName.Margin = new Padding(2, 0, 2, 0);
            lblHouseName.Name = "lblHouseName";
            lblHouseName.Size = new Size(322, 37);
            lblHouseName.TabIndex = 3;
            lblHouseName.Text = "Student Housing Platform";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(137, 128, 245);
            btnLogIn.Cursor = Cursors.Hand;
            btnLogIn.Dock = DockStyle.Right;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Location = new Point(963, 0);
            btnLogIn.Margin = new Padding(2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(65, 45);
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
            btnExit.Location = new Point(1028, 0);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(66, 45);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 2, 24, 158);
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(6, 4);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 37);
            label1.TabIndex = 0;
            label1.Text = "Student Housing Platform";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 17F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(167, 362);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(247, 31);
            label2.TabIndex = 7;
            label2.Text = "Latest Announcements";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(137, 128, 245);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(8, 398);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(524, 77);
            listBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(137, 128, 245);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(413, 69);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(282, 166);
            button1.TabIndex = 9;
            button1.Text = "Groceries list";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(137, 128, 245);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(764, 69);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(278, 166);
            button2.TabIndex = 10;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1094, 523);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btn);
            Margin = new Padding(2);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private Panel panel1;
        private Label label1;
        private Button btnExit;
        private Label label2;
        private ListBox listBox1;
        private Button btnLogIn;
        private Button button1;
        private Button button2;
        private Label lblHouseName;
        private Button btnAdmin;
    }
}