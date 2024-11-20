namespace StudentHousing
{
    partial class AddBuilding
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
            ((System.ComponentModel.ISupportInitialize)numUDMaxTenants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDRent).BeginInit();
            SuspendLayout();
            // 
            // tbBuildingAddress
            // 
            tbBuildingAddress.Location = new Point(171, 32);
            tbBuildingAddress.Name = "tbBuildingAddress";
            tbBuildingAddress.Size = new Size(150, 31);
            tbBuildingAddress.TabIndex = 0;
            // 
            // BuildingAddress
            // 
            BuildingAddress.AutoSize = true;
            BuildingAddress.Location = new Point(10, 35);
            BuildingAddress.Name = "BuildingAddress";
            BuildingAddress.Size = new Size(146, 25);
            BuildingAddress.TabIndex = 1;
            BuildingAddress.Text = "Building Address";
            // 
            // numUDMaxTenants
            // 
            numUDMaxTenants.Location = new Point(171, 91);
            numUDMaxTenants.Name = "numUDMaxTenants";
            numUDMaxTenants.Size = new Size(180, 31);
            numUDMaxTenants.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 93);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 3;
            label1.Text = "Maximum Tenants";
            // 
            // numUDRent
            // 
            numUDRent.DecimalPlaces = 2;
            numUDRent.Location = new Point(171, 150);
            numUDRent.Name = "numUDRent";
            numUDRent.Size = new Size(180, 31);
            numUDRent.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 152);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 5;
            label2.Text = "Rent Per Month";
            // 
            // btnAddBuilding
            // 
            btnAddBuilding.Location = new Point(171, 239);
            btnAddBuilding.Name = "btnAddBuilding";
            btnAddBuilding.Size = new Size(168, 34);
            btnAddBuilding.TabIndex = 6;
            btnAddBuilding.Text = "Add Building";
            btnAddBuilding.UseVisualStyleBackColor = true;
            btnAddBuilding.Click += btnAddBuilding_Click;
            // 
            // cbTenants
            // 
            cbTenants.FormattingEnabled = true;
            cbTenants.Location = new Point(169, 200);
            cbTenants.Name = "cbTenants";
            cbTenants.Size = new Size(182, 33);
            cbTenants.TabIndex = 7;
            // 
            // btnAddTenant
            // 
            btnAddTenant.Location = new Point(51, 198);
            btnAddTenant.Name = "btnAddTenant";
            btnAddTenant.Size = new Size(112, 34);
            btnAddTenant.TabIndex = 8;
            btnAddTenant.Text = "Add Tenant";
            btnAddTenant.UseVisualStyleBackColor = true;
            // 
            // lbBuildings
            // 
            lbBuildings.FormattingEnabled = true;
            lbBuildings.ItemHeight = 25;
            lbBuildings.Location = new Point(411, 26);
            lbBuildings.Name = "lbBuildings";
            lbBuildings.Size = new Size(366, 404);
            lbBuildings.TabIndex = 9;
            // 
            // AddBuilding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbBuildings);
            Controls.Add(btnAddTenant);
            Controls.Add(cbTenants);
            Controls.Add(btnAddBuilding);
            Controls.Add(label2);
            Controls.Add(numUDRent);
            Controls.Add(label1);
            Controls.Add(numUDMaxTenants);
            Controls.Add(BuildingAddress);
            Controls.Add(tbBuildingAddress);
            Name = "AddBuilding";
            Text = "AddBuilding";
            ((System.ComponentModel.ISupportInitialize)numUDMaxTenants).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDRent).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}