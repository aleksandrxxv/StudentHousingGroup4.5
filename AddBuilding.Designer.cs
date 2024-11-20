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
            lbTenants = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numUDMaxTenants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDRent).BeginInit();
            SuspendLayout();
            // 
            // tbBuildingAddress
            // 
            tbBuildingAddress.Location = new Point(120, 19);
            tbBuildingAddress.Margin = new Padding(2, 2, 2, 2);
            tbBuildingAddress.Name = "tbBuildingAddress";
            tbBuildingAddress.Size = new Size(106, 23);
            tbBuildingAddress.TabIndex = 0;
            // 
            // BuildingAddress
            // 
            BuildingAddress.AutoSize = true;
            BuildingAddress.Location = new Point(7, 21);
            BuildingAddress.Margin = new Padding(2, 0, 2, 0);
            BuildingAddress.Name = "BuildingAddress";
            BuildingAddress.Size = new Size(96, 15);
            BuildingAddress.TabIndex = 1;
            BuildingAddress.Text = "Building Address";
            // 
            // numUDMaxTenants
            // 
            numUDMaxTenants.Location = new Point(120, 55);
            numUDMaxTenants.Margin = new Padding(2, 2, 2, 2);
            numUDMaxTenants.Name = "numUDMaxTenants";
            numUDMaxTenants.Size = new Size(126, 23);
            numUDMaxTenants.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 56);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "Maximum Tenants";
            // 
            // numUDRent
            // 
            numUDRent.DecimalPlaces = 2;
            numUDRent.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numUDRent.Location = new Point(120, 90);
            numUDRent.Margin = new Padding(2, 2, 2, 2);
            numUDRent.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numUDRent.Name = "numUDRent";
            numUDRent.Size = new Size(126, 23);
            numUDRent.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 91);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 5;
            label2.Text = "Rent Per Month";
            // 
            // btnAddBuilding
            // 
            btnAddBuilding.Location = new Point(8, 230);
            btnAddBuilding.Margin = new Padding(2, 2, 2, 2);
            btnAddBuilding.Name = "btnAddBuilding";
            btnAddBuilding.Size = new Size(245, 28);
            btnAddBuilding.TabIndex = 6;
            btnAddBuilding.Text = "Add Building";
            btnAddBuilding.UseVisualStyleBackColor = true;
            btnAddBuilding.Click += btnAddBuilding_Click;
            // 
            // cbTenants
            // 
            cbTenants.FormattingEnabled = true;
            cbTenants.Location = new Point(118, 120);
            cbTenants.Margin = new Padding(2, 2, 2, 2);
            cbTenants.Name = "cbTenants";
            cbTenants.Size = new Size(129, 23);
            cbTenants.TabIndex = 7;
            // 
            // btnAddTenant
            // 
            btnAddTenant.Location = new Point(36, 119);
            btnAddTenant.Margin = new Padding(2, 2, 2, 2);
            btnAddTenant.Name = "btnAddTenant";
            btnAddTenant.Size = new Size(78, 20);
            btnAddTenant.TabIndex = 8;
            btnAddTenant.Text = "Add Tenant";
            btnAddTenant.UseVisualStyleBackColor = true;
            btnAddTenant.Click += btnAddTenant_Click;
            // 
            // lbBuildings
            // 
            lbBuildings.FormattingEnabled = true;
            lbBuildings.ItemHeight = 15;
            lbBuildings.Location = new Point(288, 16);
            lbBuildings.Margin = new Padding(2, 2, 2, 2);
            lbBuildings.Name = "lbBuildings";
            lbBuildings.Size = new Size(257, 244);
            lbBuildings.TabIndex = 9;
            lbBuildings.SelectedIndexChanged += lbBuildings_SelectedIndexChanged;
            // 
            // lbTenants
            // 
            lbTenants.FormattingEnabled = true;
            lbTenants.ItemHeight = 15;
            lbTenants.Location = new Point(8, 149);
            lbTenants.Margin = new Padding(2, 2, 2, 2);
            lbTenants.Name = "lbTenants";
            lbTenants.Size = new Size(246, 79);
            lbTenants.TabIndex = 10;
            // 
            // AddBuilding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lbTenants);
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
            Margin = new Padding(2, 2, 2, 2);
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
        private ListBox lbTenants;
    }
}