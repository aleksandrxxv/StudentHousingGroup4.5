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
    public class FineManager
    {
        private static readonly string filePath = Path.Combine("..", "..", "..", "Database", "fines.json");
        public static void CreateFine(Fine fine)
        {
            List<Fine> fines = new List<Fine>();

            if (File.Exists(filePath))
            {
                string existingData = File.ReadAllText(filePath);

                if (!string.IsNullOrEmpty(existingData))
                {
                    try
                    {
                        fines = JsonSerializer.Deserialize<List<Fine>>(existingData);
                    }
                    catch (JsonException)
                    {
                        fines = new List<Fine>();
                    }
                }
            }


            fines.Add(fine);
            string jsonData = JsonSerializer.Serialize(fines, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonData);
        }

        public static List<Fine> GetFinesForUser(string userId)
        {
            string jsonContent = File.ReadAllText(filePath);
            List<Fine> allFines = JsonSerializer.Deserialize<List<Fine>>(jsonContent);
            List<Fine> finesForUser = new List<Fine>();
            foreach(Fine fine in allFines)
            {
                if(fine.TennantId == userId)
                {
                    finesForUser.Add(fine);
                }
            }
            return finesForUser;
        }
        public static void PayFine(Fine fine)
        {
            if (File.Exists(filePath))
            {
                string existingData = File.ReadAllText(filePath);
                List<Fine> fines = JsonSerializer.Deserialize<List<Fine>>(existingData);

                Fine fineToRemove = fines.FirstOrDefault(f => f.Id == fine.Id);
                if (fineToRemove != null)
                {
                    fines.Remove(fineToRemove);
                    string jsonData = JsonSerializer.Serialize(fines, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, jsonData);
                }
            }
        }
    }
}
