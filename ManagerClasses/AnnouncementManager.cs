using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using StudentHousing.Classes;

namespace StudentHousing.ManagerClasses
{
    public class AnnouncementManager
    {
        private static readonly string filePath = Path.Combine("..", "..", "..", "Database", "announcements.json");
        public static void CreateAnnouncement(Announcement announcement)
        {
            DateTime date = DateTime.Now;
            List<Announcement> announcements = new List<Announcement>();
            if (File.Exists(filePath))
            {
                string existingData = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(existingData))
                {
                    try
                    {
                        announcements = JsonSerializer.Deserialize<List<Announcement>>(existingData);
                    }
                    catch (JsonException)
                    {
                        announcements = new List<Announcement>();
                    }
                }

                announcements.Add(announcement);
                string jsonData = JsonSerializer.Serialize(announcements, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(filePath, jsonData);

            }
        }
        public static List<Announcement> GetAnnouncements()
        {
            if (File.Exists(filePath))
            {
                string existingData = File.ReadAllText(filePath);

                if (!string.IsNullOrEmpty(existingData) && existingData.Trim() != "[]")
                {
                    return JsonSerializer.Deserialize<List<Announcement>>(existingData);
                }

            }
            return new List<Announcement>();
        }
    }
}
