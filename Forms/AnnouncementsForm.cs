using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StudentHousing.Classes;
using StudentHousing.ManagerClasses;

namespace StudentHousing
{
    public partial class AnnouncementsForm : Form
    {
        public User CurrentUser { get; private set; }

        public AnnouncementsForm(User currentUser)
        {
            InitializeComponent();
            this.CurrentUser = currentUser;

            LoadAnnouncements();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home frm = new Home(this.CurrentUser);
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void btnAddAnnouncement_Click(object sender, EventArgs e)
        {
            AddAnnouncement frm = new AddAnnouncement(this.CurrentUser);
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void LoadAnnouncements()
        {
            panelAnnouncements.Controls.Clear();    
            List<Announcement> announcements = AnnouncementManager.GetAnnouncements();

            
            int yPosition = 10;
            foreach (var announcement in announcements)
            {
                Label lbAuthor = new Label()
                {
                    Text = UserManager.GetUserById(announcement.CreatedBy).UserName,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(10, yPosition),

                };
                panelAnnouncements.Controls.Add(lbAuthor);

                Label lblAnnouncement = new Label
                {
                    Text = $"{announcement.Content}",
                    AutoSize = true,
                    Location = new Point(10, yPosition + lbAuthor.Height),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    MaximumSize = new Size(400, 0)

                };

                panelAnnouncements.Controls.Add(lblAnnouncement);

                Button btnReply = new Button
                {
                    Text = "Reply",
                    Size = new Size(75, 30),
                    Location = new Point(10, yPosition + lbAuthor.Height+ lblAnnouncement.Height + 5),
                    Tag = announcement.Id
                };
                panelAnnouncements.Controls.Add(btnReply);

                yPosition += lblAnnouncement.Height + btnReply.Height + lbAuthor.Height + 15;

                btnReply.Click += (s, e) => MessageBox.Show("Reply functionality not implemented yet.");
            }
        }
    }
}
