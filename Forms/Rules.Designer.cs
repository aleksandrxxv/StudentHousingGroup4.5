namespace StudentHousing.Forms
{
    partial class Rules
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
            lbRules = new ListBox();
            btnAddRule = new Button();
            tbText = new TextBox();
            cbBuildings = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbRules
            // 
            lbRules.BackColor = Color.Snow;
            lbRules.Font = new Font("Segoe UI", 12F);
            lbRules.FormattingEnabled = true;
            lbRules.ItemHeight = 32;
            lbRules.Location = new Point(267, 90);
            lbRules.Name = "lbRules";
            lbRules.RightToLeft = RightToLeft.No;
            lbRules.Size = new Size(446, 452);
            lbRules.TabIndex = 0;
            // 
            // btnAddRule
            // 
            btnAddRule.Location = new Point(772, 233);
            btnAddRule.Name = "btnAddRule";
            btnAddRule.Size = new Size(171, 34);
            btnAddRule.TabIndex = 1;
            btnAddRule.Text = "Add Rule to this building";
            btnAddRule.UseVisualStyleBackColor = true;
            btnAddRule.Visible = false;
            btnAddRule.Click += btnAddRule_Click;
            // 
            // tbText
            // 
            tbText.Location = new Point(727, 104);
            tbText.Multiline = true;
            tbText.Name = "tbText";
            tbText.PlaceholderText = "Rule text...";
            tbText.Size = new Size(266, 123);
            tbText.TabIndex = 2;
            tbText.Visible = false;
            // 
            // cbBuildings
            // 
            cbBuildings.FormattingEnabled = true;
            cbBuildings.Location = new Point(772, 49);
            cbBuildings.Name = "cbBuildings";
            cbBuildings.Size = new Size(182, 33);
            cbBuildings.TabIndex = 3;
            cbBuildings.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(350, 41);
            label1.Name = "label1";
            label1.Size = new Size(299, 38);
            label1.TabIndex = 4;
            label1.Text = "Rules for Sunny House";
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9538280;
            ClientSize = new Size(1005, 563);
            Controls.Add(label1);
            Controls.Add(cbBuildings);
            Controls.Add(tbText);
            Controls.Add(btnAddRule);
            Controls.Add(lbRules);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Rules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbRules;
        private Button btnAddRule;
        private TextBox tbText;
        private ComboBox cbBuildings;
        private Label label1;
    }
}