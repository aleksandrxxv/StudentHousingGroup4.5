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
            components = new System.ComponentModel.Container();
            tbAdditional = new TextBox();
            cbArea = new ComboBox();
            btnCreate = new Button();
            cbAnonymous = new CheckBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            label2 = new Label();
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
            // cbAnonymous
            // 
            cbAnonymous.AutoSize = true;
            cbAnonymous.BackColor = Color.Transparent;
            cbAnonymous.ForeColor = SystemColors.ControlLightLight;
            cbAnonymous.Location = new Point(262, 40);
            cbAnonymous.Name = "cbAnonymous";
            cbAnonymous.Size = new Size(216, 29);
            cbAnonymous.TabIndex = 4;
            cbAnonymous.Text = "Submit as anonymous";
            cbAnonymous.UseVisualStyleBackColor = false;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Sumbit as anonymous";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(84, 150);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 5;
            label1.Text = "Additional Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(131, 92);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 6;
            label2.Text = "Category";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddComplaint
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9538280;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbAnonymous);
            Controls.Add(btnCreate);
            Controls.Add(cbArea);
            Controls.Add(tbAdditional);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddComplaint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddComplaint";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAdditional;
        private ComboBox cbArea;
        private Button btnCreate;
        private CheckBox cbAnonymous;
        private ToolTip toolTip1;
        private Label label1;
        private Label label2;
    }
}