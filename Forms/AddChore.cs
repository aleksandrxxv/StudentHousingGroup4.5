using StudentHousing.Classes;
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
    public partial class AddChore : Form
    {
        public AddChore()
        {
            List<User> users = UserManager.GetAllUsers();
            List<Building> buildings = BuildingManager.GetAllBuildings();
            InitializeComponent();
            foreach (ChoreType chore in Enum.GetValues(typeof(ChoreType)))
            {
                cbChoreType.Items.Add(chore);
            }
            foreach (User user in users)
            {
                cbUsers.Items.Add(user);
                cbUsers.DisplayMember = "Name";
            }
            foreach (Building building in buildings)
            {
                cbBuildings.Items.Add(building);
                cbBuildings.DisplayMember = "address";
            }
            List<Chore> currentChores = ChoreManager.GetChoresByType(ChoreType.Cleaning);
            foreach (Chore c in currentChores)
            {
                lbTest.Items.Add(c);
                lbTest.DisplayMember = "Id";
            }
        }

        private void btnCreateChore_Click(object sender, EventArgs e)
        {
            User selectedUser = cbUsers.SelectedItem as User;
            Building selectedBuilding = cbBuildings.SelectedItem as Building;
            DateTime selectedDate = dtpDate.Value;
            ChoreType selectedChoreType = (ChoreType)cbChoreType.SelectedItem;

            Chore chore = new Chore(selectedChoreType, selectedDate, Convert.ToString(selectedBuilding.BuildingID), Convert.ToString(selectedUser.Id), new DateTime());
            ChoreManager.CreateChore( chore );

        }
    }
}
