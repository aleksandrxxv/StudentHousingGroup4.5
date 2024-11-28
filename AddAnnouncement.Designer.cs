namespace StudentHousing
{
    partial class AddAnnouncement
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
            tbContent = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(218, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 48);
            label1.TabIndex = 0;
            label1.Text = "Add Announcements";
            // 
            // tbContent
            // 
            tbContent.Location = new Point(96, 71);
            tbContent.Multiline = true;
            tbContent.Name = "tbContent";
            tbContent.Size = new Size(260, 120);
            tbContent.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(177, 236);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddAnnouncement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(tbContent);
            Controls.Add(label1);
            Name = "AddAnnouncement";
            Text = "AddAnnouncement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbContent;
        private Button btnSubmit;
    }
}