using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentHousing
{
    
    public class Announcement
    {
        public string Id { get; private set; }
        public string CreatedBy { get; private set; }
        public string BuildingId { get; private set; }
        public string? ReplyToAnnouncement {  get; private set; }
        public string Content { get; private set; }
        public DateTime CreationDate { get; private set; }

        public Announcement(string createdBy, string buildingId, string? replyToAnnouncement, string content, DateTime creationDate)
        {
            Id = Guid.NewGuid().ToString();
            CreatedBy = createdBy;
            BuildingId = buildingId;
            ReplyToAnnouncement = replyToAnnouncement;
            Content = content;
            CreationDate = creationDate;
        }
        public Announcement() { }
        [JsonConstructor]
        public Announcement(string id,string createdBy, string buildingId, string? replyToAnnouncement, string content, DateTime creationDate)
        {
            Id = id;
            CreatedBy = createdBy;
            BuildingId = buildingId;
            ReplyToAnnouncement = replyToAnnouncement;
            Content = content;
            CreationDate = creationDate;
        }

    }
}
