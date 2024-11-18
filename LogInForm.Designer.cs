namespace StudentHousing
{
    partial class LogInForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            button1 = new Button();
            lbError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20F);
            label1.Location = new Point(321, 73);
            label1.Name = "label1";
            label1.Size = new Size(113, 46);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14F);
            label2.Location = new Point(227, 132);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14F);
            label3.Location = new Point(236, 184);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.None;
            tbUsername.Location = new Point(359, 138);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Provided username";
            tbUsername.Size = new Size(181, 27);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.None;
            tbPassword.Location = new Point(359, 189);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Provided password";
            tbPassword.Size = new Size(181, 27);
            tbPassword.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Yu Gothic UI", 18F);
            button1.Location = new Point(299, 259);
            button1.Name = "button1";
            button1.Size = new Size(151, 57);
            button1.TabIndex = 5;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbError
            // 
            lbError.Anchor = AnchorStyles.None;
            lbError.AutoSize = true;
            lbError.Font = new Font("Yu Gothic UI", 10F);
            lbError.ForeColor = Color.Red;
            lbError.Location = new Point(209, 233);
            lbError.Name = "lbError";
            lbError.Size = new Size(0, 23);
            lbError.TabIndex = 6;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbError);
            Controls.Add(button1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogInForm";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button button1;
        private Label lbError;
    }
}