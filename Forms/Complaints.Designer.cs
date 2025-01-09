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
            components = new System.ComponentModel.Container();
            lbxComplaints = new ListBox();
            btnAdd = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbxComplaints
            // 
            lbxComplaints.FormattingEnabled = true;
            lbxComplaints.ItemHeight = 25;
            lbxComplaints.Location = new Point(268, 29);
            lbxComplaints.Name = "lbxComplaints";
            lbxComplaints.Size = new Size(338, 354);
            lbxComplaints.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(638, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Complaints
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(lbxComplaints);
            Name = "Complaints";
            Text = "Complaints";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbxComplaints;
        private Button btnAdd;
        private System.Windows.Forms.Timer timer1;
    }
}