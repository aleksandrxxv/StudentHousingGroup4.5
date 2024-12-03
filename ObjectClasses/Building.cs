using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using StudentHousing.ManagerClasses;

namespace StudentHousing.Classes
{
    public class Building
    {

        public string BuildingID { get; set; }
        public int capacity { get; set; }
        public string address { get; set; }
        public decimal rentPerMonth { get; set; }
        public List<string> tenantIDs { get; set; } = new List<string>();

        public Building(string address, int capacity, decimal rentPerMonth, List<string> tenantIDs)
        {
            BuildingID = Guid.NewGuid().ToString();
            this.address = address;
            this.capacity = capacity;
            this.rentPerMonth = rentPerMonth;
            this.tenantIDs = tenantIDs;
        }
        private Building GetBuildingByTenantId(string tenantId)
        {
            // Load all buildings from the JSON file
            List<Building> allBuildings = BuildingManager.GetAllBuildings();

            // Find the building that contains the tenant ID
            foreach (Building building in allBuildings)
            {
                if (building.tenantIDs.Contains(tenantId))
                {
                    return building;
                }
            }

            // Return null if no building is found
            return null;
        }

        public Building() { }

        [JsonConstructor]
        public Building(string BuildingID, string address, int capacity, decimal rentPerMonth, List<string> tenantIDs)
        {
            this.BuildingID = BuildingID;
            this.address = address;
            this.capacity = capacity;
            this.rentPerMonth = rentPerMonth;
            this.tenantIDs = tenantIDs;
        }

    }
}
