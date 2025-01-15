using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHousing.Classes;
using StudentHousing.Forms;
using StudentHousing.ManagerClasses;
using StudentHousing.ObjectClasses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace StudentHousing
{
    public partial class Home : Form
    {
        public User currentUser { get; private set; }

        public Home(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            Building tenantBuilding = BuildingManager.GetBuildingByTenantID(currentUser.Id);
            if (currentUser.IsAdmin == true)
            {
                lblHouseName.Text = "Admin Account";
                btnAdmin.Visible = true;

            }
            else
            {
                lblHouseName.Text = tenantBuilding.address;

                LoadAnnouncements();



                //lbAnnouncements.Items.Clear();
                List<Announcement> mainAnnouncements = AnnouncementManager.GetMainAnnouncementsForHouse(tenantBuilding.BuildingID);

                if(mainAnnouncements.Count > 0)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (mainAnnouncements[i] != null)
                        {
                            //lbAnnouncements.Items.Add(mainAnnouncements[i].Content);
                        }
                    }
                }
                
            }
        }
        private void LoadAnnouncements()
        {
            announcementsPanel.Controls.Clear();
            string userBuildingId = BuildingManager.GetBuildingByTenantID(currentUser.Id).BuildingID;
            List<Announcement> announcements = AnnouncementManager.GetMainAnnouncementsForHouse(userBuildingId);
            int yPosition = 10;
            int i = 0;
            foreach (Announcement reply in announcements)
            {
                i++;
                if(i > 2)
                {
                    break;
                }
                Label lbAuthor = new Label()
                {
                    Text = UserManager.GetUserById(reply.CreatedBy).UserName,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(10, 10),
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                };

                Label lbDate = new Label()
                {
                    Text = reply.CreationDate.ToShortDateString(),
                    Font = new Font("Arial", 8, FontStyle.Regular),
                    ForeColor = Color.DarkSlateGray,
                    Location = new Point(10, lbAuthor.Height + 10),
                    BackColor = Color.Transparent
                };

                Label lblAnnouncement = new Label
                {
                    Text = $"{reply.Content}",
                    AutoSize = true,
                    Location = new Point(10, lbAuthor.Height + lbDate.Height + 10),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    MaximumSize = new Size(400, 0),
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                };

                Panel replyPanel = new Panel
                {
                    BackColor = Color.Transparent,
                    Location = new Point(5, yPosition),
                    Size = new Size(announcementsPanel.Width - 10, 0),
                    BorderStyle = BorderStyle.None
                };

                replyPanel.Controls.Add(lbAuthor);
                replyPanel.Controls.Add(lbDate);
                replyPanel.Controls.Add(lblAnnouncement);

                announcementsPanel.Controls.Add(replyPanel);
                replyPanel.Height = lblAnnouncement.Location.Y + lblAnnouncement.Height + 10;
                yPosition += replyPanel.Height + 10;
            }
        }
        private void ShoppingButton()
        {
            List<Product> products = new List<Product>();
            List<string> topThreeItems = products.Take(3).Select(product => product.Name).ToList();
            string buttonText = string.Join(", ", topThreeItems);
            btnShoppingPanel.Text = buttonText;
        }

        public Home()
        {
            InitializeComponent();

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(currentUser);
            profile.StartPosition = FormStartPosition.Manual;
            profile.Location = this.Location;
            profile.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPanel addBuilding = new AdminPanel();
            addBuilding.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AnnouncementsForm af = new AnnouncementsForm(this.currentUser);
            af.Show();
            this.Hide();
            af.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shopping shopping = new Shopping();
            shopping.Show();
        }

        private void btnChores_Click(object sender, EventArgs e)
        {
            ChoresCalendar choresCalendar = new ChoresCalendar(currentUser);
            choresCalendar.StartPosition = FormStartPosition.CenterScreen;
            choresCalendar.Show();
            this.Hide();
            choresCalendar.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Complaints complaints = new Complaints(currentUser);
            complaints.Show();
        }
    }
}
