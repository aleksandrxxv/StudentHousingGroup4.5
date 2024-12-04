namespace StudentHousing.Forms
{
    partial class AddChore
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
            cbChoreType = new ComboBox();
            btnCreateChore = new Button();
            cbUsers = new ComboBox();
            cbBuildings = new ComboBox();
            dtpDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cbChoreType
            // 
            cbChoreType.FormattingEnabled = true;
            cbChoreType.Location = new Point(235, 87);
            cbChoreType.Name = "cbChoreType";
            cbChoreType.Size = new Size(300, 33);
            cbChoreType.TabIndex = 0;
            // 
            // btnCreateChore
            // 
            btnCreateChore.Location = new Point(316, 331);
            btnCreateChore.Name = "btnCreateChore";
            btnCreateChore.Size = new Size(133, 49);
            btnCreateChore.TabIndex = 1;
            btnCreateChore.Text = "Create Chore";
            btnCreateChore.UseVisualStyleBackColor = true;
            btnCreateChore.Click += btnCreateChore_Click;
            // 
            // cbUsers
            // 
            cbUsers.FormattingEnabled = true;
            cbUsers.Location = new Point(235, 134);
            cbUsers.Name = "cbUsers";
            cbUsers.Size = new Size(300, 33);
            cbUsers.TabIndex = 2;
            // 
            // cbBuildings
            // 
            cbBuildings.FormattingEnabled = true;
            cbBuildings.Location = new Point(235, 187);
            cbBuildings.Name = "cbBuildings";
            cbBuildings.Size = new Size(300, 33);
            cbBuildings.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(235, 242);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(300, 31);
            dtpDate.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 90);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 5;
            label1.Text = "Type Of Chore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 137);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 6;
            label2.Text = "Person To Execute";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 195);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 7;
            label3.Text = "Building";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 247);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 8;
            label4.Text = "Date To Be Executed";
            // 
            // AddChore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Controls.Add(cbBuildings);
            Controls.Add(cbUsers);
            Controls.Add(btnCreateChore);
            Controls.Add(cbChoreType);
            Name = "AddChore";
            Text = "AddChore";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbChoreType;
        private Button btnCreateChore;
        private ComboBox cbUsers;
        private ComboBox cbBuildings;
        private DateTimePicker dtpDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}