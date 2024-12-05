using StudentHousing.Classes;
using StudentHousing.ENUMS;
using StudentHousing.ObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentHousing.ManagerClasses
{
    public class ChoreManager
    {
        private static readonly string filePath = Path.Combine("..", "..", "..", "Database", "chores.json");

        public static void CreateChore(Chore chore)
        {
            List<Chore> chores = new List<Chore>();
            if (File.Exists(filePath))
            {
                string existingData = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(existingData))
                {
                    try
                    {
                        chores = JsonSerializer.Deserialize<List<Chore>>(existingData);
                    }
                    catch (JsonException)
                    {
                        chores = new List<Chore>();
                    }
                }

                chores.Add(chore);
                string jsonData = JsonSerializer.Serialize(chores, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(filePath, jsonData);

            }
        }
        public static List<Chore> GetChoresByType(ChoreType choreType)
        {
            string jsonContent = File.ReadAllText(filePath);
            List<Chore> chores = JsonSerializer.Deserialize<List<Chore>>(jsonContent);

            return chores.Where(chore => chore.typeOfChore == choreType).ToList();
        }

    }
    
}
