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
            label5 = new Label();
            tabPage2 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            btnCreateUser = new Button();
            cbAdmin = new CheckBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUDMaxTenants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDRent).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
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
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // tabPage2
            // 
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
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
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
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // AdminPanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)numUDMaxTenants).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDRent).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
    }
}