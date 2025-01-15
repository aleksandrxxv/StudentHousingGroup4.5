using StudentHousing.Classes;
using StudentHousing.Forms;
using StudentHousing.ObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentHousing.ManagerClasses
{
    public class RuleManager
    {
        private static readonly string filePath = Path.Combine("..", "..", "..", "Database", "rules.json");
        
        public string BuildingId {  get; private set; }

        public static void AddRule(Rule rule)
        {
            List<Rule> rules = new List<Rule>();
            if (File.Exists(filePath))
            {
                string existingData = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(existingData))
                {
                    try
                    {
                        rules = JsonSerializer.Deserialize<List<Rule>>(existingData);
                    }
                    catch (JsonException)
                    {
                        rules = new List<Rule>();
                    }
                }

                rules.Add(rule);
                string jsonData = JsonSerializer.Serialize(rules, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(filePath, jsonData);
            }
        }
        public static List<Rule> GetRulesByBuilding(Building building)
        {
            string filePath = Path.Combine("..", "..", "..", "Database", "rules.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The complaints JSON file does not exist.");
            }

            string jsonString = File.ReadAllText(filePath);

            try
            {
                return JsonSerializer.Deserialize<List<Rule>>(jsonString);
            }
            catch (JsonException)
            {
                Rule singleRule = JsonSerializer.Deserialize<Rule>(jsonString);
                return new List<Rule> { singleRule };
            }
        }
    }

}
