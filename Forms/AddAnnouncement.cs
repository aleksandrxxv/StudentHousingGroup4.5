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
    public partial class AddAnnouncement : Form
    {
        private User CurrentUser;
        private string replyTo = "";
        public AddAnnouncement(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }
        public AddAnnouncement(User currentUser, string replyTo)
        {
            InitializeComponent();
            this.replyTo = replyTo;
            CurrentUser = currentUser;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string userId = CurrentUser.Id;
            Building userBuilding = BuildingManager.GetBuildingByTenantID(userId);
            string buildingId = userBuilding.BuildingID;
            string content = tbContent.Text;
            Announcement announcement;
            if (content != "")
            {
                announcement = new Announcement(userId, buildingId, replyTo, content, date);
                AnnouncementManager.CreateAnnouncement(announcement);
                AnnouncementsForm af = new AnnouncementsForm(this.CurrentUser);
                af.Show();
                this.Hide();
                af.FormClosed += (s, args) => this.Close();
            } else { 
                MessageBox.Show("Please don't leave any of the fields empty!");
            }  
        }
    }
}
