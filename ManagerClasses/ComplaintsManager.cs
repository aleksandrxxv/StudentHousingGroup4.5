using StudentHousing.Classes;
using StudentHousing.ObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentHousing.ManagerClasses
{
    public class ComplaintsManager
    {
        private static readonly string filePath = Path.Combine("..", "..", "..", "Database", "complaints.json");
        public static void CreateComplaint(Complaint complaint)
        {
            List<Complaint> complaints = new List<Complaint>();
            if (File.Exists(filePath))
            {
                string existingData = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(existingData))
                {
                    try
                    {
                        complaints = JsonSerializer.Deserialize<List<Complaint>>(existingData);
                    }
                    catch (JsonException)
                    {
                        complaints = new List<Complaint>();
                    }
                }

                complaints.Add(complaint);
                string jsonData = JsonSerializer.Serialize(complaints, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(filePath, jsonData);

            }
        }
        public static List<Complaint> GetAllBuildings()
        {
            string filePath = Path.Combine("..", "..", "..", "Database", "complaints.json");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The complaints JSON file does not exist.");
            }

            string jsonString = File.ReadAllText(filePath);

            try
            {
                return JsonSerializer.Deserialize<List<Complaint>>(jsonString);
            }
            catch (JsonException)
            {
                Complaint singleComplaint = JsonSerializer.Deserialize<Complaint>(jsonString);
                return new List<Complaint> { singleComplaint };
            }
        }
    }
}
