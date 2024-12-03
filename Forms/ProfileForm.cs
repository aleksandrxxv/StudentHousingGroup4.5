using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHousing.Classes;
using StudentHousing.ManagerClasses;

namespace StudentHousing
{
    public partial class ProfileForm : Form
    {
        private User user;

        public ProfileForm(User currentUser)
        {
            InitializeComponent();
            this.user = currentUser;

            lbId.Text = user.Id;
            lbName.Text = user.Name;
            Building tenantBuilding = BuildingManager.GetBuildingByTenantID(user.Id);
            lblTenantBuilding.Text = tenantBuilding.address;

        }


    }
}
