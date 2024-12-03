using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using StudentHousing.Classes;

namespace StudentHousing.ManagerClasses
{
    public class BuildingManager
    {
        public static List<Building> GetAllBuildings()
        {
            string filePath = Path.Combine("..", "..", "..", "Database", "buildings.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The buildings JSON file does not exist.");
            }

            string jsonString = File.ReadAllText(filePath);

            try
            {
                return JsonSerializer.Deserialize<List<Building>>(jsonString);
            }
            catch (JsonException)
            {
                Building singleBuilding = JsonSerializer.Deserialize<Building>(jsonString);
                return new List<Building> { singleBuilding };
            }
        }
        public static Building GetBuildingByTenantID(string tenantID)
        {
            List<Building> allBuildings = GetAllBuildings();
            foreach (Building building in allBuildings)
            {
                if (building.tenantIDs.Contains(tenantID))
                {
                    return building;
                }
            }
            return null;

        }
    }
}
