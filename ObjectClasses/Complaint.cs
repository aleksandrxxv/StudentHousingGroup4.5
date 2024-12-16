using StudentHousing.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentHousing.ObjectClasses
{
    public class Complaint
    {
        public string Id { get; private set; }
        public string UserId { get; private set; }
        public string BuildingId { get; private set; }
        public ComplaintArea Area { get; private set; }
        public string AdditionalNotes { get; private set; }
        public DateTime Date {  get; private set; }
        public bool PermissionToEnter { get; private set; }

        public Complaint(string userId, string buildingId, ComplaintArea area, string additionalNotes, DateTime date, bool permissionToEnter)
        {
            Id = Guid.NewGuid().ToString();
            UserId = userId;
            BuildingId = buildingId;
            Area = area;
            AdditionalNotes = additionalNotes;
            Date = date;
            PermissionToEnter = permissionToEnter;
        }

        public Complaint() { }

        [JsonConstructor]
        public Complaint(string Id, string userId, string buildingId, ComplaintArea area, string additionalNotes, DateTime date, bool permissionToEnter)
        {
            this.Id = Id;
            this.UserId = userId;
            this.BuildingId = buildingId;
            this.Area = area;
            this.AdditionalNotes = additionalNotes;
            this.Date = date;
            this.PermissionToEnter = permissionToEnter;
        }
    }
}
