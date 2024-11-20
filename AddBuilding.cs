using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class AddBuilding : Form
    {
        public AddBuilding()
        {
            InitializeComponent();
        }

        private void getAllTenants()
        {
            UserManager.
        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            string buildingAddress = tbBuildingAddress.Text;
            int maximumTenants = Convert.ToInt32(numUDMaxTenants.Value);
            decimal rentPerMonth = Convert.ToDecimal(numUDRent.Value);

        }
    }
}
