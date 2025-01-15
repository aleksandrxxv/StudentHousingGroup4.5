using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public static List<Announcement> GetMainAnnouncementsForHouse(string buildingId)
        {
            List<Announcement> announcements = GetAnnouncements();
            List<Announcement> mainAnnouncementsForBuilding = new List<Announcement>();
            if (announcements.Count > 0)
            {
                foreach (Announcement announcement in announcements)
                {
                    Debug.WriteLine("opaa");
                    Debug.WriteLine(announcement.Content);
                    Debug.WriteLine(announcement.ReplyToAnnouncement);
                    Debug.WriteLine("-------------------------");
                    if (announcement.BuildingId == buildingId && announcement.ReplyToAnnouncement == "")
                    {
                        mainAnnouncementsForBuilding.Add(announcement);
                    }
                }
            }

            return mainAnnouncementsForBuilding;
        }

        public static List<Announcement> GetReplies(string announcementId)
        {
            List<Announcement> replies = new List<Announcement>();

            foreach (Announcement announcement in GetAnnouncements())
            {
                if(announcement.ReplyToAnnouncement == announcementId)
                {
                    replies.Add(announcement);
                }
            }
            return replies;
        }
        public static Announcement GetAnnouncementById(string id)
        {
            List<Announcement> announcements = GetAnnouncements();
            foreach (Announcement announcement in announcements)
            {
                if (announcement.Id == id)
                {
                    return announcement;
                }
            }
            return null;
        }
    }
}
