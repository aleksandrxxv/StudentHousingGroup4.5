using StudentHousing.Classes;
using StudentHousing.ENUMS;
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
    public partial class AddComplaint : Form
    {
        private User currentUser;
        private Complaints complaintsForm;
        public AddComplaint(User user, Complaints complaintsForm)
        {
            InitializeComponent();
            currentUser = user;
            this.complaintsForm = complaintsForm;
            cbArea.DataSource = Enum.GetValues(typeof(ComplaintArea));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string additionalInfo = tbAdditional.Text;
            string userId = currentUser.Id;
            string buildingId = BuildingManager.GetBuildingByTenantID(userId).BuildingID;
            ComplaintArea area = (ComplaintArea)cbArea.SelectedItem;
            DateTime date = DateTime.Now;
            bool anonymous = cbAnonymous.Checked;

            if (anonymous == false)
            {
                Complaint complaint = new Complaint(userId, buildingId, area, additionalInfo, date);
                ComplaintsManager.CreateComplaint(complaint);
                MessageBox.Show("Complaint created succesfully.");
                complaintsForm.RefreshComplaints();

            } else
            {
                Complaint complaint = new Complaint("-1", buildingId, area, additionalInfo, date);
                ComplaintsManager.CreateComplaint(complaint);
                MessageBox.Show("Anonymous complaint created succesfully.");
                complaintsForm.RefreshComplaints();
            }



        }
    }
}
