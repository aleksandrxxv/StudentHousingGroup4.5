namespace StudentHousing.Forms
{
    partial class PaymentForm
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lbPrice = new Label();
            rbCard1 = new RadioButton();
            linkLabel1 = new LinkLabel();
            rbCard2 = new RadioButton();
            linkLabel2 = new LinkLabel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnPay = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Mastercard_Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(89, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 65);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.Visa_Logo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(89, 192);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 70);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(lbPrice);
            panel1.Controls.Add(rbCard1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(rbCard2);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(42, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 388);
            panel1.TabIndex = 2;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.BackColor = Color.Transparent;
            lbPrice.Font = new Font("Segoe UI", 18F);
            lbPrice.ForeColor = SystemColors.Control;
            lbPrice.Location = new Point(237, 30);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(259, 41);
            lbPrice.TabIndex = 9;
            lbPrice.Text = "Payment : XX.XX €";
            // 
            // rbCard1
            // 
            rbCard1.AutoSize = true;
            rbCard1.BackColor = Color.Transparent;
            rbCard1.Font = new Font("Segoe UI", 12F);
            rbCard1.ForeColor = SystemColors.Control;
            rbCard1.Location = new Point(55, 119);
            rbCard1.Name = "rbCard1";
            rbCard1.Size = new Size(17, 16);
            rbCard1.TabIndex = 8;
            rbCard1.TabStop = true;
            rbCard1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(566, 120);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Remove Card";
            // 
            // rbCard2
            // 
            rbCard2.AutoSize = true;
            rbCard2.BackColor = Color.Transparent;
            rbCard2.Font = new Font("Segoe UI", 12F);
            rbCard2.ForeColor = SystemColors.Control;
            rbCard2.Location = new Point(55, 219);
            rbCard2.Name = "rbCard2";
            rbCard2.Size = new Size(17, 16);
            rbCard2.TabIndex = 7;
            rbCard2.TabStop = true;
            rbCard2.UseVisualStyleBackColor = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkColor = Color.Red;
            linkLabel2.Location = new Point(566, 215);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(98, 20);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Remove Card";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 25F);
            textBox2.Location = new Point(170, 192);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(377, 63);
            textBox2.TabIndex = 3;
            textBox2.Text = "**** **** **** 1314";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 25F);
            textBox1.Location = new Point(170, 96);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(377, 63);
            textBox1.TabIndex = 2;
            textBox1.Text = "**** **** **** 5214";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(137, 128, 245);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 12F);
            btnPay.Location = new Point(262, 333);
            btnPay.Margin = new Padding(2, 3, 2, 3);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(277, 40);
            btnPay.TabIndex = 3;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9538280;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPay);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox textBox1;
        private RadioButton rbCard2;
        private LinkLabel linkLabel2;
        private TextBox textBox2;
        private Label lbPrice;
        private RadioButton rbCard1;
        private LinkLabel linkLabel1;
        private Button btnPay;
    }
}