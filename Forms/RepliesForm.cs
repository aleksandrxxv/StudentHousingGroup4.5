using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StudentHousing.Classes;
using StudentHousing.Forms;
using StudentHousing.ManagerClasses;

namespace StudentHousing.Forms
{
    public partial class RepliesForm : Form
    {
        private User currentUser;
        private List<Announcement> replies;
        public RepliesForm(User currentUser, List<Announcement> replies)
        {
            this.currentUser = currentUser;
            this.replies = replies;
            InitializeComponent();
            LoadReplies();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AnnouncementsForm frm = new AnnouncementsForm(this.currentUser);
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void LoadReplies()
        {
            panelReplies.Controls.Clear();
            string userBuildingId = BuildingManager.GetBuildingByTenantID(currentUser.Id).BuildingID;

            int yPosition = 10;
            foreach (Announcement reply in replies)
            {
                Label lbAuthor = new Label()
                {
                    Text = UserManager.GetUserById(reply.CreatedBy).UserName,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(10, yPosition),
                    BackColor = Color.Transparent,
                    ForeColor = Color.AntiqueWhite,
                };
                panelReplies.Controls.Add(lbAuthor);

                Label lbDate = new Label()
                {
                    Text = reply.CreationDate.ToShortDateString(),
                    Font = new Font("Arial", 8, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(10, yPosition + lbAuthor.Height + 10),
                    BackColor = Color.Transparent
                };
                panelReplies.Controls.Add(lbDate);

                Label lblAnnouncement = new Label
                {
                    Text = $"{reply.Content}",
                    AutoSize = true,
                    Location = new Point(10, yPosition + lbAuthor.Height + lbDate.Height + 10),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    MaximumSize = new Size(400, 0),
                    BackColor = Color.Transparent,
                    ForeColor = Color.AntiqueWhite

                };

                panelReplies.Controls.Add(lblAnnouncement);



                yPosition += lblAnnouncement.Height + lbAuthor.Height + 85;
            }
        }
    }
}
