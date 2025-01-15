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
    public partial class Rules : Form
    {
        private User currentUser;
        private Building currentBuilding;

        public Rules(Building userBuilding, User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.currentBuilding = userBuilding;
            if (currentUser.IsAdmin == true)
            {
                btnAddRule.Visible = true;
                tbText.Visible = true;
                cbBuildings.Visible = true;
            }
            else
            {
                label1.Text = $"Rules for {currentBuilding.address}";
            }
            List<ObjectClasses.Rule> rules = RuleManager.GetRulesByBuilding(userBuilding);
            foreach (ObjectClasses.Rule rule in rules)
            {
                lbRules.Items.Add(rule.Content);
            }
            List<Building> buildings = BuildingManager.GetAllBuildings();
            foreach (Building building in buildings)
            {
                cbBuildings.Items.Add(building);
            }
            cbBuildings.DisplayMember = "address";

        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            string ruleText = tbText.Text;
            Building selectedBuilding = cbBuildings.SelectedItem as Building;
            if (selectedBuilding != null | ruleText != "")
            {
                ObjectClasses.Rule newRule = new ObjectClasses.Rule(this.currentUser.Id, ruleText, selectedBuilding.BuildingID);
                RuleManager.AddRule(newRule);
                MessageBox.Show("Rule added.");
                
            }
            else
            {
                MessageBox.Show("Please select a building and write the rule!");
            }
        }
    }
}
