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
            tbItemName.Location = new Point(212, 44);
            tbItemName.Margin = new Padding(2);
            tbItemName.Name = "tbItemName";
            tbItemName.Size = new Size(182, 41);
            tbItemName.TabIndex = 0;
            // 
            // numUDAmount
            // 
            numUDAmount.Font = new Font("Segoe UI", 15F);
            numUDAmount.Location = new Point(212, 139);
            numUDAmount.Margin = new Padding(2);
            numUDAmount.Name = "numUDAmount";
            numUDAmount.Size = new Size(181, 41);
            numUDAmount.TabIndex = 2;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(122, 202);
            btnAddItem.Margin = new Padding(2);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(173, 60);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "AddItem";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // tbItemPrice
            // 
            tbItemPrice.DecimalPlaces = 2;
            tbItemPrice.Font = new Font("Segoe UI", 15F);
            tbItemPrice.Location = new Point(212, 91);
            tbItemPrice.Margin = new Padding(2);
            tbItemPrice.Name = "tbItemPrice";
            tbItemPrice.Size = new Size(181, 41);
            tbItemPrice.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 35);
            label1.TabIndex = 5;
            label1.Text = "Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 35);
            label2.TabIndex = 6;
            label2.Text = "ItemPrice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 141);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 35);
            label3.TabIndex = 7;
            label3.Text = "ItemAmount";
            // 
            // lbShoppingList
            // 
            lbShoppingList.BackColor = Color.FromArgb(137, 128, 245);
            lbShoppingList.BorderStyle = BorderStyle.FixedSingle;
            lbShoppingList.Font = new Font("Segoe UI", 15F);
            lbShoppingList.FormattingEnabled = true;
            lbShoppingList.ItemHeight = 35;
            lbShoppingList.Location = new Point(421, 6);
            lbShoppingList.Margin = new Padding(2);
            lbShoppingList.Name = "lbShoppingList";
            lbShoppingList.Size = new Size(401, 457);
            lbShoppingList.TabIndex = 8;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.BackColor = Color.FromArgb(137, 128, 245);
            lblTotalPrice.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(435, 419);
            lblTotalPrice.Margin = new Padding(2, 0, 2, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(88, 35);
            lblTotalPrice.TabIndex = 9;
            lblTotalPrice.Text = "label4";
            // 
            // Shopping
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9538280;
            ClientSize = new Size(846, 531);
            Controls.Add(lblTotalPrice);
            Controls.Add(lbShoppingList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbItemPrice);
            Controls.Add(btnAddItem);
            Controls.Add(numUDAmount);
            Controls.Add(tbItemName);
            Margin = new Padding(2);
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