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
    public partial class AddAnnouncement : Form
    {
        User currentUser;
        public AddAnnouncement(User currentUser)
        {
            InitializeComponent();
            currentUser = currentUser;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string userId = currentUser.Id;
            Building userBuilding = BuildingManager.GetBuildingByTenantID(userId);
            string buildingId = userBuilding.BuildingID;
            string content = tbContent.Text;
            if (content != "")
            {
                Announcement announcement = new Announcement(userId, buildingId, "", content, date);
                AnnouncementManager.CreateAnnouncement(announcement);
            } else { 
                MessageBox.Show("Please don't leave any of the fields empty!");
            }  
        }
    }
}
