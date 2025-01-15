namespace StudentHousing.Forms
{
    partial class Complaints
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
            lbxComplaints = new ListBox();
            btnAdd = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbxComplaints
            // 
            lbxComplaints.FormattingEnabled = true;
            lbxComplaints.ItemHeight = 25;
            lbxComplaints.Location = new Point(43, 89);
            lbxComplaints.Name = "lbxComplaints";
            lbxComplaints.Size = new Size(667, 429);
            lbxComplaints.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(772, 221);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(378, 22);
            label1.Name = "label1";
            label1.Size = new Size(189, 45);
            label1.TabIndex = 2;
            label1.Text = "Complaints";
            // 
            // Complaints
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9538280;
            ClientSize = new Size(937, 552);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(lbxComplaints);
            Name = "Complaints";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Complaints";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxComplaints;
        private Button btnAdd;
        private Label label1;
    }
}