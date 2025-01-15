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
        private Announcement mainAnnouncement;
        public RepliesForm(User currentUser, List<Announcement> replies, Announcement mainAnnouncement)
        {
            this.currentUser = currentUser;
            this.replies = replies;
            this.mainAnnouncement = mainAnnouncement;
            InitializeComponent();
            LoadLabel();
            LoadReplies();
        }

        private void LoadLabel()
        {
            string content = mainAnnouncement.Content;
            if (content.Length > 40)
            {
                content = content.Substring(0, 40);
                content += "...";
            }
            string labelText = "Reply to: " + content;
            lbReplies.Text = labelText;
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
                    Location = new Point(10, 10),
                    BackColor = Color.Transparent,
                    ForeColor = Color.AntiqueWhite,
                };

                Label lbDate = new Label()
                {
                    Text = reply.CreationDate.ToShortDateString(),
                    Font = new Font("Arial", 8, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(10, lbAuthor.Height + 10),
                    BackColor = Color.Transparent
                };

                Label lblAnnouncement = new Label
                {
                    Text = $"{reply.Content}",
                    AutoSize = true,
                    Location = new Point(10, lbAuthor.Height + lbDate.Height + 20),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    MaximumSize = new Size(400, 0),
                    BackColor = Color.Transparent,
                    ForeColor = Color.AntiqueWhite
                };

                Panel replyPanel = new Panel
                {
                    BackColor = Color.FromArgb(100, 0, 0, 0),
                    Location = new Point(5, yPosition),
                    Size = new Size(panelReplies.Width - 10, 0),
                    BorderStyle = BorderStyle.None
                };

                replyPanel.Controls.Add(lbAuthor);
                replyPanel.Controls.Add(lbDate);
                replyPanel.Controls.Add(lblAnnouncement);

                panelReplies.Controls.Add(replyPanel);
                replyPanel.Height = lblAnnouncement.Location.Y + lblAnnouncement.Height + 10;
                yPosition += replyPanel.Height + 10;
            }
        }

    }
}
