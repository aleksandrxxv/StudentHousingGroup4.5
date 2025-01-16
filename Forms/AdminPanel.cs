using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHousing.Classes;
using StudentHousing.ENUMS;
using StudentHousing.ManagerClasses;
using StudentHousing.ObjectClasses;

namespace StudentHousing
{

    public partial class AdminPanel : Form
    {
        private List<Building> allBuildings = new List<Building>();
        private List<User> selectedUsers = new List<User>();
        private List<User> allUsers = new List<User>();
        public AdminPanel()
        {
            InitializeComponent();
            UpdateBuildingList();

            List<User> users = UserManager.GetAllUsers();
            foreach (User user in users)
            {
                Building userBuilding = BuildingManager.GetBuildingByTenantID(user.Id);
                if (!user.IsAdmin && userBuilding == null)
                {
                    cbTenants.Items.Add(user);
                }
            }
            List<Building> buildings = BuildingManager.GetAllBuildings();
            foreach (ChoreType chore in Enum.GetValues(typeof(ChoreType)))
            {
                cbChoreType.Items.Add(chore);
            }
            foreach (User user in users)
            {
                cbUsersFines.Items.Add(user);
                cbUsersFines.DisplayMember = "Name";
                cbUsers.Items.Add(user);
                cbUsers.DisplayMember = "Name";
            }
            foreach (Building building in buildings)
            {
                cbBuildings.Items.Add(building);
                cbBuildings.DisplayMember = "address";
            }

            cbTenants.DisplayMember = "Name";
        }
        private void UpdateBuildingList()
        {
            lbBuildings.Items.Clear();
            List<Building> buildings = BuildingManager.GetAllBuildings();

            foreach (Building b in buildings)
            {
                lbBuildings.Items.Add(b);
            }
            lbBuildings.DisplayMember = "address";
            lbBuildings.SelectedIndexChanged += lbBuildings_SelectedIndexChanged;
        }




        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            string buildingAddress = tbBuildingAddress.Text;
            int maximumTenants = Convert.ToInt32(numUDMaxTenants.Value);
            decimal rentPerMonth = Convert.ToDecimal(numUDRent.Value);

            if (selectedUsers.Count > maximumTenants)
            {
                MessageBox.Show("Selected tenants exceed the maximum allowed tenants.");
                return;
            }

            List<string> tenantIDs = selectedUsers.Select(user => user.Id).ToList();

            Building newBuilding = new Building(buildingAddress, maximumTenants, rentPerMonth, tenantIDs);

            string filePath = Path.Combine("..", "..", "..", "Database", "buildings.json");
            List<Building> buildings;

            if (File.Exists(filePath))
            {

                string existingData = File.ReadAllText(filePath);
                buildings = JsonSerializer.Deserialize<List<Building>>(existingData);
            }
            else
            {
                buildings = new List<Building>();
            }

            buildings.Add(newBuilding);

            string jsonString = JsonSerializer.Serialize(buildings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);

            MessageBox.Show("Building successfully added and saved to JSON.");
            UpdateBuildingList();

        }


        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            if (cbTenants.SelectedItem is User selectedUser)
            {
                if (!selectedUsers.Contains(selectedUser))
                {
                    lbTenants.Items.Clear();
                    selectedUsers.Add(selectedUser);
                    MessageBox.Show($"Added tenant: {selectedUser.Name}");
                    foreach (User u in selectedUsers)
                    {
                        lbTenants.Items.Add(u.Name);
                    }
                }
                else
                {
                    MessageBox.Show("This tenant is already selected.");
                }
            }
            else
            {
                MessageBox.Show("Please select a tenant.");
            }
        }

        private void lbBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenants.Items.Clear();
            selectedUsers.Clear();
            Building selectedBuilding = lbBuildings.SelectedItem as Building;
            if (selectedBuilding == null)
            {
                MessageBox.Show("No building selected");
                return;
            }

            List<User> allUsers = UserManager.GetAllUsers();
            foreach (string tenantID in selectedBuilding.tenantIDs)
            {
                User tenant = allUsers.FirstOrDefault(u => u.Id == tenantID);
                if (tenant != null)
                {
                    lbTenants.Items.Add(tenant.Name);
                }
                else
                {
                    MessageBox.Show("tuka smee");

                }
            }

        }

        private void btnCreateChore_Click(object sender, EventArgs e)
        {
            User selectedUser = cbUsers.SelectedItem as User;
            Building selectedBuilding = cbBuildings.SelectedItem as Building;
            DateTime selectedDate = dtpDate.Value;
            ChoreType selectedChoreType = (ChoreType)cbChoreType.SelectedItem;

            Chore chore = new Chore(selectedChoreType, selectedDate, Convert.ToString(selectedBuilding.BuildingID), Convert.ToString(selectedUser.Id), new DateTime());
            ChoreManager.CreateChore(chore);
        }

        private void btnCreateFine_Click(object sender, EventArgs e)
        {
            User selectedUser = cbUsersFines.SelectedItem as User;
            decimal amount = numFineAmount.Value;
            string reason = tbReasonFine.Text;
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a tennant to be fined.");
            }
            else if (amount <= 0)
            {
                MessageBox.Show("Please select the amount of the fine that is more than 0.");
            }
            else if (reason.Length < 5)
            {
                MessageBox.Show("Please provide a reason that is more than 5 characters long.");
            }
            else
            {
                Fine fine = new Fine(amount, selectedUser.Id, reason, DateTime.Now);
                FineManager.CreateFine(fine);
                MessageBox.Show("Fine created successfully!");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
