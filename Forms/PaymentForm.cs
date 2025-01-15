using StudentHousing.ManagerClasses;
using StudentHousing.ObjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing.Forms
{
    public partial class PaymentForm : Form
    {
        private Fine fine;
        public PaymentForm(Fine fine)
        {
            InitializeComponent();
            this.fine = fine;
            lbPrice.Text = "Price of the fine: " + String.Format("{0:0.00}", fine.Amount.ToString()) + " €";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FineManager.PayFine(fine);
            MessageBox.Show("Payed successfully!");
            this.Close();
        }
    }
}
