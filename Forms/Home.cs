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

            }
            else
            {
                lblHouseName.Text = tenantBuilding.address;

            }
            if (currentUser.IsAdmin)
            {
                btnAdmin.Visible = true;
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
