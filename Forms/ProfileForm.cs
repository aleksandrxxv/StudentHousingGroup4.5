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
using StudentHousing.ManagerClasses;
using StudentHousing.ObjectClasses;

namespace StudentHousing
{
    public partial class ProfileForm : Form
    {
        private User user;
        private List<Fine> fines;

        public ProfileForm(User currentUser)
        {
            InitializeComponent();
            
            this.user = currentUser;

            lbName.Text = user.Name;
            Building tenantBuilding = BuildingManager.GetBuildingByTenantID(user.Id);
            lblTenantBuilding.Text = tenantBuilding.address;
            updateFinesPanel();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateFinesPanel()
        {
            fines = FineManager.GetFinesForUser(user.Id);
            int yPosition = 10;
            foreach (Fine fine in fines)
            {
                Label lbl = new Label()
                {
                    Text = fine.Amount + "€ for '" + fine.Reason + "'",
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    Location = new Point(10, yPosition),
                    AutoSize = true,
                    ForeColor = Color.WhiteSmoke,
                    MaximumSize = new Size(panelFines.Width - 10, 0),
                };
                Button button = new Button()
                {
                    Text = "Pay now",
                    Location = new Point(10, yPosition+lbl.Height+30),
                    TabIndex = 1,
                    BackColor = Color.FromArgb(137, 128, 245),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 12F),
                    Margin = new Padding(2),
                    Size = new Size(111, 38),
                    UseVisualStyleBackColor = false
                };
                panelFines.Controls.Add(lbl);
                panelFines.Controls.Add(button);
                yPosition += lbl.Height + button.Height + 30;

            }
        }
    }
}
