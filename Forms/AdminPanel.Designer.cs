namespace StudentHousing
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            tbBuildingAddress = new TextBox();
            BuildingAddress = new Label();
            numUDMaxTenants = new NumericUpDown();
            label1 = new Label();
            numUDRent = new NumericUpDown();
            label2 = new Label();
            btnAddBuilding = new Button();
            cbTenants = new ComboBox();
            btnAddTenant = new Button();
            lbBuildings = new ListBox();
            lbTenants = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnClose4 = new Button();
            label6 = new Label();
            label5 = new Label();
            tabPage2 = new TabPage();
            btnClose = new Button();
            label16 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnCreateUser = new Button();
            cbAdmin = new CheckBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            tabPage3 = new TabPage();
            btnClose2 = new Button();
            label11 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dtpDate = new DateTimePicker();
            cbBuildings = new ComboBox();
            cbUsers = new ComboBox();
            btnCreateChore = new Button();
            cbChoreType = new ComboBox();
            FinesTab = new TabPage();
            btnClose3 = new Button();
            btnCreateFine = new Button();
            label15 = new Label();
            tbReasonFine = new TextBox();
            label14 = new Label();
            label13 = new Label();
            numFineAmount = new NumericUpDown();
            label12 = new Label();
            cbUsersFines = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numUDMaxTenants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDRent).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            FinesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFineAmount).BeginInit();
            SuspendLayout();
            // 
            // tbBuildingAddress
            // 
            resources.ApplyResources(tbBuildingAddress, "tbBuildingAddress");
            tbBuildingAddress.Name = "tbBuildingAddress";
            // 
            // BuildingAddress
            // 
            resources.ApplyResources(BuildingAddress, "BuildingAddress");
            BuildingAddress.BackColor = Color.Transparent;
            BuildingAddress.ForeColor = SystemColors.ActiveCaptionText;
            BuildingAddress.Name = "BuildingAddress";
            // 
            // numUDMaxTenants
            // 
            resources.ApplyResources(numUDMaxTenants, "numUDMaxTenants");
            numUDMaxTenants.Name = "numUDMaxTenants";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Name = "label1";
            // 
            // numUDRent
            // 
            numUDRent.DecimalPlaces = 2;
            numUDRent.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            resources.ApplyResources(numUDRent, "numUDRent");
            numUDRent.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numUDRent.Name = "numUDRent";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Name = "label2";
            // 
            // btnAddBuilding
            // 
            resources.ApplyResources(btnAddBuilding, "btnAddBuilding");
            btnAddBuilding.Name = "btnAddBuilding";
            btnAddBuilding.UseVisualStyleBackColor = true;
            btnAddBuilding.Click += btnAddBuilding_Click;
            // 
            // cbTenants
            // 
            cbTenants.FormattingEnabled = true;
            resources.ApplyResources(cbTenants, "cbTenants");
            cbTenants.Name = "cbTenants";
            // 
            // btnAddTenant
            // 
            resources.ApplyResources(btnAddTenant, "btnAddTenant");
            btnAddTenant.Name = "btnAddTenant";
            btnAddTenant.UseVisualStyleBackColor = true;
            btnAddTenant.Click += btnAddTenant_Click;
            // 
            // lbBuildings
            // 
            lbBuildings.FormattingEnabled = true;
            resources.ApplyResources(lbBuildings, "lbBuildings");
            lbBuildings.Name = "lbBuildings";
            lbBuildings.SelectedIndexChanged += lbBuildings_SelectedIndexChanged;
            // 
            // lbTenants
            // 
            lbTenants.FormattingEnabled = true;
            resources.ApplyResources(lbTenants, "lbTenants");
            lbTenants.Name = "lbTenants";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(FinesTab);
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Controls.Add(btnClose4);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(tbBuildingAddress);
            tabPage1.Controls.Add(lbTenants);
            tabPage1.Controls.Add(BuildingAddress);
            tabPage1.Controls.Add(lbBuildings);
            tabPage1.Controls.Add(numUDMaxTenants);
            tabPage1.Controls.Add(btnAddTenant);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cbTenants);
            tabPage1.Controls.Add(numUDRent);
            tabPage1.Controls.Add(btnAddBuilding);
            tabPage1.Controls.Add(label2);
            tabPage1.Name = "tabPage1";
            // 
            // btnClose4
            // 
            btnClose4.BackColor = Color.Red;
            btnClose4.Cursor = Cursors.Hand;
            btnClose4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnClose4, "btnClose4");
            btnClose4.ForeColor = SystemColors.ButtonHighlight;
            btnClose4.Name = "btnClose4";
            btnClose4.UseVisualStyleBackColor = false;
            btnClose4.Click += btnClose_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.Transparent;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Name = "label5";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Controls.Add(btnClose);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnCreateUser);
            tabPage2.Controls.Add(cbAdmin);
            tabPage2.Controls.Add(tbPassword);
            tabPage2.Controls.Add(tbUsername);
            tabPage2.Name = "tabPage2";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.BackColor = Color.Transparent;
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Name = "label16";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Name = "label3";
            // 
            // btnCreateUser
            // 
            resources.ApplyResources(btnCreateUser, "btnCreateUser");
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // cbAdmin
            // 
            resources.ApplyResources(cbAdmin, "cbAdmin");
            cbAdmin.BackColor = Color.Transparent;
            cbAdmin.ForeColor = SystemColors.ActiveCaptionText;
            cbAdmin.Name = "cbAdmin";
            cbAdmin.UseVisualStyleBackColor = false;
            // 
            // tbPassword
            // 
            resources.ApplyResources(tbPassword, "tbPassword");
            tbPassword.Name = "tbPassword";
            // 
            // tbUsername
            // 
            resources.ApplyResources(tbUsername, "tbUsername");
            tbUsername.Name = "tbUsername";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.Control;
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.Controls.Add(btnClose2);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(dtpDate);
            tabPage3.Controls.Add(cbBuildings);
            tabPage3.Controls.Add(cbUsers);
            tabPage3.Controls.Add(btnCreateChore);
            tabPage3.Controls.Add(cbChoreType);
            tabPage3.Name = "tabPage3";
            // 
            // btnClose2
            // 
            btnClose2.BackColor = Color.Red;
            btnClose2.Cursor = Cursors.Hand;
            btnClose2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnClose2, "btnClose2");
            btnClose2.ForeColor = SystemColors.ButtonHighlight;
            btnClose2.Name = "btnClose2";
            btnClose2.UseVisualStyleBackColor = false;
            btnClose2.Click += btnClose_Click;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.BackColor = Color.Transparent;
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Name = "label11";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.BackColor = Color.Transparent;
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.BackColor = Color.Transparent;
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.BackColor = Color.Transparent;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.BackColor = Color.Transparent;
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Name = "label10";
            // 
            // dtpDate
            // 
            resources.ApplyResources(dtpDate, "dtpDate");
            dtpDate.Name = "dtpDate";
            // 
            // cbBuildings
            // 
            cbBuildings.FormattingEnabled = true;
            resources.ApplyResources(cbBuildings, "cbBuildings");
            cbBuildings.Name = "cbBuildings";
            // 
            // cbUsers
            // 
            cbUsers.FormattingEnabled = true;
            resources.ApplyResources(cbUsers, "cbUsers");
            cbUsers.Name = "cbUsers";
            // 
            // btnCreateChore
            // 
            resources.ApplyResources(btnCreateChore, "btnCreateChore");
            btnCreateChore.Name = "btnCreateChore";
            btnCreateChore.UseVisualStyleBackColor = true;
            btnCreateChore.Click += btnCreateChore_Click;
            // 
            // cbChoreType
            // 
            cbChoreType.FormattingEnabled = true;
            resources.ApplyResources(cbChoreType, "cbChoreType");
            cbChoreType.Name = "cbChoreType";
            // 
            // FinesTab
            // 
            FinesTab.BackColor = SystemColors.Control;
            resources.ApplyResources(FinesTab, "FinesTab");
            FinesTab.Controls.Add(btnClose3);
            FinesTab.Controls.Add(btnCreateFine);
            FinesTab.Controls.Add(label15);
            FinesTab.Controls.Add(tbReasonFine);
            FinesTab.Controls.Add(label14);
            FinesTab.Controls.Add(label13);
            FinesTab.Controls.Add(numFineAmount);
            FinesTab.Controls.Add(label12);
            FinesTab.Controls.Add(cbUsersFines);
            FinesTab.Name = "FinesTab";
            // 
            // btnClose3
            // 
            btnClose3.BackColor = Color.Red;
            btnClose3.Cursor = Cursors.Hand;
            btnClose3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnClose3, "btnClose3");
            btnClose3.ForeColor = SystemColors.ButtonHighlight;
            btnClose3.Name = "btnClose3";
            btnClose3.UseVisualStyleBackColor = false;
            btnClose3.Click += btnClose_Click;
            // 
            // btnCreateFine
            // 
            resources.ApplyResources(btnCreateFine, "btnCreateFine");
            btnCreateFine.Name = "btnCreateFine";
            btnCreateFine.UseVisualStyleBackColor = true;
            btnCreateFine.Click += btnCreateFine_Click;
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.BackColor = Color.Transparent;
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Name = "label15";
            // 
            // tbReasonFine
            // 
            resources.ApplyResources(tbReasonFine, "tbReasonFine");
            tbReasonFine.Name = "tbReasonFine";
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Name = "label13";
            // 
            // numFineAmount
            // 
            numFineAmount.DecimalPlaces = 2;
            numFineAmount.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            resources.ApplyResources(numFineAmount, "numFineAmount");
            numFineAmount.Name = "numFineAmount";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Name = "label12";
            // 
            // cbUsersFines
            // 
            cbUsersFines.FormattingEnabled = true;
            resources.ApplyResources(cbUsersFines, "cbUsersFines");
            cbUsersFines.Name = "cbUsersFines";
            // 
            // AdminPanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)numUDMaxTenants).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDRent).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            FinesTab.ResumeLayout(false);
            FinesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFineAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbBuildingAddress;
        private Label BuildingAddress;
        private NumericUpDown numUDMaxTenants;
        private Label label1;
        private NumericUpDown numUDRent;
        private Label label2;
        private Button btnAddBuilding;
        private ComboBox cbTenants;
        private Button btnAddTenant;
        private ListBox lbBuildings;
        private ListBox lbTenants;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private Button btnCreateUser;
        private CheckBox cbAdmin;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label label5;
        private Label label6;
        private TabPage tabPage3;
        private Label label11;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpDate;
        private ComboBox cbBuildings;
        private ComboBox cbUsers;
        private Button btnCreateChore;
        private ComboBox cbChoreType;
        private TabPage FinesTab;
        private Label label12;
        private ComboBox cbUsersFines;
        private Button btnCreateFine;
        private Label label15;
        private TextBox tbReasonFine;
        private Label label14;
        private Label label13;
        private NumericUpDown numFineAmount;
        private Label label16;
        private Button btnClose;
        private Button btnClose4;
        private Button btnClose2;
        private Button btnClose3;
    }
}