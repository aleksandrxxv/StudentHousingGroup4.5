﻿using StudentHousing.Classes;
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
        User currentUser;
        public AddComplaint(User user)
        {
            InitializeComponent();
            currentUser = user;
            cbArea.DataSource = Enum.GetValues(typeof(ComplaintArea));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string additionalInfo = tbAdditional.Text;
            string userId = currentUser.Id;
            string buildingId = BuildingManager.GetBuildingByTenantID(userId).BuildingID;
            ComplaintArea area = (ComplaintArea)cbArea.SelectedItem;
            DateTime date = DateTime.Now;
            bool permissionToEnter = cbPermission.Checked;

            Complaint complaint = new Complaint(userId, buildingId, area, additionalInfo, date, permissionToEnter);
            ComplaintsManager.CreateComplaint(complaint);


        }
    }
}
