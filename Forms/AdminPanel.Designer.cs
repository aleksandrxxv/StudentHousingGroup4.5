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
            label6 = new Label();
            label5 = new Label();
            tabPage2 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            btnCreateUser = new Button();
            cbAdmin = new CheckBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            tabPage3 = new TabPage();
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
            BuildingAddress.ForeColor = SystemColors.ButtonHighlight;
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
            label1.ForeColor = SystemColors.ButtonHighlight;
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
            label2.ForeColor = SystemColors.ButtonHighlight;
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
            tabPage1.BackgroundImage = Properties.Resources._9538280;
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
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Name = "label5";
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources._9538280;
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnCreateUser);
            tabPage2.Controls.Add(cbAdmin);
            tabPage2.Controls.Add(tbPassword);
            tabPage2.Controls.Add(tbUsername);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.ButtonHighlight;
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
            cbAdmin.ForeColor = SystemColors.ButtonHighlight;
            cbAdmin.Name = "cbAdmin";
            cbAdmin.UseVisualStyleBackColor = true;
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
            tabPage3.BackgroundImage = Properties.Resources._9538280;
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
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.Name = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Name = "label11";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.ForeColor = SystemColors.ButtonHighlight;
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
            FinesTab.BackgroundImage = Properties.Resources._9538280;
            FinesTab.Controls.Add(btnCreateFine);
            FinesTab.Controls.Add(label15);
            FinesTab.Controls.Add(tbReasonFine);
            FinesTab.Controls.Add(label14);
            FinesTab.Controls.Add(label13);
            FinesTab.Controls.Add(numFineAmount);
            FinesTab.Controls.Add(label12);
            FinesTab.Controls.Add(cbUsersFines);
            resources.ApplyResources(FinesTab, "FinesTab");
            FinesTab.Name = "FinesTab";
            FinesTab.UseVisualStyleBackColor = true;
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
            label15.ForeColor = SystemColors.ButtonHighlight;
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
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.ForeColor = SystemColors.ButtonHighlight;
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
            label12.ForeColor = SystemColors.ButtonHighlight;
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
            BackgroundImage = Properties.Resources._9538280;
            Controls.Add(tabControl1);
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
    }
}