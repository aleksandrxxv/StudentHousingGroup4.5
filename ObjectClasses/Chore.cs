﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using StudentHousing.ENUMS;

namespace StudentHousing.ObjectClasses
{
    public class Chore
    {
        public string Id { get; private set; }
        public ChoreType typeOfChore { get; private set; }
        public DateTime TimeToBeExecuted { get; private set; }
        public string BuildingID { get; private set; }
        public string ResponsibleUserID { get; private set; }
        public DateTime? DateCompleted { get; private set; }

        public Chore(ChoreType typeOfChore, DateTime timeToBeExecuted, string buildingID, string responsibleUserID, DateTime? dateCompleted)
        {
            Id = Guid.NewGuid().ToString();
            this.typeOfChore = typeOfChore;  
            TimeToBeExecuted = timeToBeExecuted;
            BuildingID = buildingID;
            ResponsibleUserID = responsibleUserID;
            DateCompleted = dateCompleted;
        }
        public Chore() { }
        [JsonConstructor]
        public Chore(string id, ChoreType typeOfChore, DateTime timeToBeExecuted, string buildingID, string responsibleUserID, DateTime? dateCompleted)
        {
            Id = id;
            this.typeOfChore = typeOfChore;
            TimeToBeExecuted = timeToBeExecuted;
            BuildingID = buildingID;
            ResponsibleUserID = responsibleUserID;
            DateCompleted = dateCompleted;
        }

    }
}
