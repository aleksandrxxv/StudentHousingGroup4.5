namespace StudentHousing.Forms
{
    partial class AddComplaint
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
            tbAdditional = new TextBox();
            cbArea = new ComboBox();
            btnCreate = new Button();
            cbPermission = new CheckBox();
            SuspendLayout();
            // 
            // tbAdditional
            // 
            tbAdditional.Location = new Point(236, 147);
            tbAdditional.Multiline = true;
            tbAdditional.Name = "tbAdditional";
            tbAdditional.Size = new Size(280, 126);
            tbAdditional.TabIndex = 0;
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Location = new Point(283, 92);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(182, 33);
            cbArea.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(278, 338);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(187, 34);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create Complaint";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // cbPermission
            // 
            cbPermission.AutoSize = true;
            cbPermission.Location = new Point(94, 292);
            cbPermission.Name = "cbPermission";
            cbPermission.Size = new Size(581, 29);
            cbPermission.TabIndex = 3;
            cbPermission.Text = "I grant permission for the workers to enter my room if I'm not home";
            cbPermission.UseVisualStyleBackColor = true;
            // 
            // AddComplaint
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbPermission);
            Controls.Add(btnCreate);
            Controls.Add(cbArea);
            Controls.Add(tbAdditional);
            Name = "AddComplaint";
            Text = "AddComplaint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAdditional;
        private ComboBox cbArea;
        private Button btnCreate;
        private CheckBox cbPermission;
    }
}