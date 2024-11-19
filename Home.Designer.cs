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
            btnLogIn = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new Point(12, 81);
            btn.Margin = new Padding(2);
            btn.Name = "btn";
            btn.Size = new Size(451, 336);
            btn.TabIndex = 0;
            btn.Text = "button1";
            btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 137, 126);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 75);
            panel1.TabIndex = 1;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(137, 128, 245);
            btnLogIn.Cursor = Cursors.Hand;
            btnLogIn.Dock = DockStyle.Right;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Location = new Point(773, 0);
            btnLogIn.Margin = new Padding(2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(91, 75);
            btnLogIn.TabIndex = 1;
            btnLogIn.Text = "Profile";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 2, 24, 158);
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(9, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(492, 54);
            label1.TabIndex = 0;
            label1.Text = "Student Housing Platform";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Location = new Point(506, 81);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(465, 336);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(12, 429);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(362, 46);
            label2.TabIndex = 7;
            label2.Text = "Latest Announcements";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(24, 489);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(746, 129);
            listBox1.TabIndex = 8;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(btn);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnLogIn;
        private Button button2;
        private Label label2;
        private ListBox listBox1;
    }
}