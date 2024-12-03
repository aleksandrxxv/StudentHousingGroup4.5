namespace StudentHousing
{
    partial class ProfileForm
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
            lbId = new Label();
            label2 = new Label();
            lbName = new Label();
            lblTenantBuilding = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 65);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "Id: ";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(72, 65);
            lbId.Name = "lbId";
            lbId.Size = new Size(43, 15);
            lbId.TabIndex = 1;
            lbId.Text = "UserId ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 91);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Name :";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(72, 91);
            lbName.Name = "lbName";
            lbName.Size = new Size(0, 15);
            lbName.TabIndex = 3;
            // 
            // lblTenantBuilding
            // 
            lblTenantBuilding.AutoSize = true;
            lblTenantBuilding.Location = new Point(15, 122);
            lblTenantBuilding.Name = "lblTenantBuilding";
            lblTenantBuilding.Size = new Size(38, 15);
            lblTenantBuilding.TabIndex = 4;
            lblTenantBuilding.Text = "label3";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 445);
            Controls.Add(lblTenantBuilding);
            Controls.Add(lbName);
            Controls.Add(label2);
            Controls.Add(lbId);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProfileForm";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbId;
        private Label label2;
        private Label lbName;
        private Label lblTenantBuilding;
    }
}