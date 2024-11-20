using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class Home : Form
    {
        public User currentUser { get; private set; }

        public Home(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            Building tenantBuilding = BuildingManager.GetBuildingByTenantID(currentUser.Id);
            lblHouseName.Text = tenantBuilding.address;
            if (currentUser.IsAdmin)
            {
                btnAdmin.Visible = true;
            }
        }

        public Home()
        {
            InitializeComponent();

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(currentUser);
            profile.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
