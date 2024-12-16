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
        public PaymentForm(Fine fine)
        {
            InitializeComponent();
            lbPrice.Text = String.Format("{0:0.00}", fine.Amount.ToString());
        }
    }
}
