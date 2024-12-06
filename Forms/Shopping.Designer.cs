namespace StudentHousing.Forms
{
    partial class Shopping
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
            tbItemName = new TextBox();
            numUDAmount = new NumericUpDown();
            btnAddItem = new Button();
            tbItemPrice = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbShoppingList = new ListBox();
            lblTotalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)numUDAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbItemPrice).BeginInit();
            SuspendLayout();
            // 
            // tbItemName
            // 
            tbItemName.Font = new Font("Segoe UI", 15F);
            tbItemName.Location = new Point(265, 55);
            tbItemName.Name = "tbItemName";
            tbItemName.Size = new Size(226, 47);
            tbItemName.TabIndex = 0;
            // 
            // numUDAmount
            // 
            numUDAmount.Font = new Font("Segoe UI", 15F);
            numUDAmount.Location = new Point(265, 174);
            numUDAmount.Name = "numUDAmount";
            numUDAmount.Size = new Size(226, 47);
            numUDAmount.TabIndex = 2;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(153, 252);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(216, 75);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "AddItem";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // tbItemPrice
            // 
            tbItemPrice.DecimalPlaces = 2;
            tbItemPrice.Font = new Font("Segoe UI", 15F);
            tbItemPrice.Location = new Point(265, 114);
            tbItemPrice.Name = "tbItemPrice";
            tbItemPrice.Size = new Size(226, 47);
            tbItemPrice.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Indigo;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 55);
            label1.Name = "label1";
            label1.Size = new Size(165, 41);
            label1.TabIndex = 5;
            label1.Text = "Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(96, 120);
            label2.Name = "label2";
            label2.Size = new Size(142, 41);
            label2.TabIndex = 6;
            label2.Text = "ItemPrice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(53, 176);
            label3.Name = "label3";
            label3.Size = new Size(185, 41);
            label3.TabIndex = 7;
            label3.Text = "ItemAmount";
            // 
            // lbShoppingList
            // 
            lbShoppingList.BackColor = Color.PapayaWhip;
            lbShoppingList.Font = new Font("Yu Gothic UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbShoppingList.FormattingEnabled = true;
            lbShoppingList.ItemHeight = 41;
            lbShoppingList.Location = new Point(526, 8);
            lbShoppingList.Name = "lbShoppingList";
            lbShoppingList.Size = new Size(500, 578);
            lbShoppingList.TabIndex = 8;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.PapayaWhip;
            lblTotalPrice.Font = new Font("Yu Gothic UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(544, 524);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(101, 41);
            lblTotalPrice.TabIndex = 9;
            lblTotalPrice.Text = "label4";
            // 
            // Shopping
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9538280;
            ClientSize = new Size(1058, 664);
            Controls.Add(lblTotalPrice);
            Controls.Add(lbShoppingList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbItemPrice);
            Controls.Add(btnAddItem);
            Controls.Add(numUDAmount);
            Controls.Add(tbItemName);
            Name = "Shopping";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shopping";
            ((System.ComponentModel.ISupportInitialize)numUDAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbItemPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbItemName;
        private NumericUpDown numUDAmount;
        private Button btnAddItem;
        private NumericUpDown tbItemPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lbShoppingList;
        private Label lblTotalPrice;
    }
}