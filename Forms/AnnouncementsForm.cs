using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using StudentHousing.Classes;
using StudentHousing.Forms;
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

        private void btnReply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AddAnnouncement frm = new AddAnnouncement(this.CurrentUser, button.Tag.ToString());
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void lbSeeReplies_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            string announcementId = (string)lb.Tag;
            List<Announcement> replies = AnnouncementManager.GetReplies(announcementId);
            Announcement mainAnnouncement = AnnouncementManager.GetAnnouncementById(announcementId);
            if(replies.Count > 0)
            {
                RepliesForm frm = new RepliesForm(CurrentUser, replies, mainAnnouncement);
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = this.Location;
                frm.Show();
                this.Hide();
                frm.FormClosed += (s, args) => this.Close();
                return;
            }
            else
            {
                MessageBox.Show("No replies");
                return;
            }
            
        }

        private void LoadAnnouncements()
        {
            panelAnnouncements.Controls.Clear();    
            string userBuildingId = BuildingManager.GetBuildingByTenantID(CurrentUser.Id).BuildingID;
            List<Announcement> announcements = AnnouncementManager.GetMainAnnouncementsForHouse(userBuildingId);
            List<Announcement> allAnnouncements = AnnouncementManager.GetAnnouncements();
            announcements.Reverse();
            
            int yPosition = 10;
            foreach (Announcement announcement in announcements)
            {
                Label lbAuthor = new Label()
                {
                    Text = UserManager.GetUserById(announcement.CreatedBy).UserName,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(10, yPosition),
                    BackColor = Color.Transparent,
                    ForeColor = Color.AntiqueWhite,
                };
                panelAnnouncements.Controls.Add(lbAuthor);

                Label lbDate = new Label()
                {
                    Text = announcement.CreationDate.ToShortDateString(),
                    Font = new Font("Arial", 8, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(10, yPosition + lbAuthor.Height + 10),
                    BackColor = Color.Transparent
                };
                panelAnnouncements.Controls.Add(lbDate);

                Label lblAnnouncement = new Label
                {
                    Text = $"{announcement.Content}",
                    AutoSize = true,
                    Location = new Point(10, yPosition + lbAuthor.Height + lbDate.Height + 10),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    MaximumSize = new Size(400, 0),
                    BackColor = Color.Transparent,
                    ForeColor = Color.AntiqueWhite

                };

                panelAnnouncements.Controls.Add(lblAnnouncement);
                
                Button btnReply = new Button
                {
                    Text = "Reply",
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(137, 128, 245),
                    Size = new Size(75, 30),
                    Location = new Point(10, yPosition + lbAuthor.Height+ +lbDate.Height + lblAnnouncement.Height + 15),
                    Tag = announcement.Id
                };
                panelAnnouncements.Controls.Add(btnReply);

                int repliesCount = 0;
                foreach (Announcement a in allAnnouncements)
                {
                    if(a.ReplyToAnnouncement == announcement.Id)
                    {
                        repliesCount++;
                    }
                }

                Label lbSeeReplies = new Label
                {
                    Text = "See replies (" + repliesCount + ")",
                    Tag = announcement.Id,
                    ForeColor = Color.LightGray,
                    BackColor = Color.Transparent,
                    Width = 200,
                    Cursor = Cursors.Hand,
                    Location = new Point(90, yPosition + lbAuthor.Height + +lbDate.Height + lblAnnouncement.Height + 15),
                };
                lbSeeReplies.Click += lbSeeReplies_Click;
                panelAnnouncements.Controls.Add(lbSeeReplies);


                yPosition += lblAnnouncement.Height + btnReply.Height + lbAuthor.Height + 55;

                btnReply.Click += btnReply_Click;
            }
        }
    }
}
