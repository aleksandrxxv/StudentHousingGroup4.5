namespace StudentHousing.Forms
{
    partial class RepliesForm
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
            btnBack = new Button();
            panel1 = new Panel();
            lblHouseName = new Label();
            panelReplies = new Panel();
            lbReplies = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = Properties.Resources.back;
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(46, 71);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 45);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(lblHouseName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 64);
            panel1.TabIndex = 5;
            // 
            // lblHouseName
            // 
            lblHouseName.AutoSize = true;
            lblHouseName.BackColor = Color.FromArgb(0, 2, 24, 158);
            lblHouseName.Font = new Font("Segoe UI", 20F);
            lblHouseName.ForeColor = SystemColors.Control;
            lblHouseName.Location = new Point(498, 9);
            lblHouseName.Margin = new Padding(2, 0, 2, 0);
            lblHouseName.Name = "lblHouseName";
            lblHouseName.Size = new Size(125, 46);
            lblHouseName.TabIndex = 4;
            lblHouseName.Text = "Replies";
            // 
            // panelReplies
            // 
            panelReplies.AutoScroll = true;
            panelReplies.BackColor = Color.FromArgb(100, 0, 0, 0);
            panelReplies.Location = new Point(46, 125);
            panelReplies.Name = "panelReplies";
            panelReplies.Size = new Size(1031, 534);
            panelReplies.TabIndex = 7;
            // 
            // lbReplies
            // 
            lbReplies.AutoSize = true;
            lbReplies.BackColor = Color.FromArgb(0, 2, 24, 158);
            lbReplies.Font = new Font("Segoe UI", 20F);
            lbReplies.ForeColor = SystemColors.Control;
            lbReplies.Location = new Point(106, 66);
            lbReplies.Margin = new Padding(2, 0, 2, 0);
            lbReplies.Name = "lbReplies";
            lbReplies.Size = new Size(182, 46);
            lbReplies.TabIndex = 8;
            lbReplies.Text = "Replies to :";
            // 
            // RepliesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1125, 696);
            Controls.Add(lbReplies);
            Controls.Add(btnBack);
            Controls.Add(panelReplies);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RepliesForm";
            Text = "RepliesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Panel panel1;
        private Label lblHouseName;
        private Panel panelReplies;
        private Label lbReplies;
    }
}