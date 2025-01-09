using StudentHousing.Classes;
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
    public partial class Complaints : Form
    {
        User currentUser;
        public Complaints(User user)
        {
            InitializeComponent();
            currentUser = user;
            List<Complaint> complaints = ComplaintsManager.GetAllBuildings();
            foreach (Complaint complaint in complaints)
            {
                lbxComplaints.Items.Add(complaint.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddComplaint addComplaint = new AddComplaint(currentUser);
            addComplaint.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbxComplaints.Items.Clear();
            List<Complaint> complaints = ComplaintsManager.GetAllBuildings();
            foreach (Complaint complaint in complaints)
            {
                lbxComplaints.Items.Add(complaint.ToString());
            }
        }
    }
}
