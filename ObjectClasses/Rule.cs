using StudentHousing.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentHousing.ObjectClasses
{
    public class Rule
    {
        public string SubmittedBy {  get; private set; }
        public string Content { get; private set; }
        public string Building { get; private set; }

        [JsonConstructor]
        public Rule(string submittedBy, string content, string building)
        {
            SubmittedBy = submittedBy;
            Content = content;
            Building = building;
        }
        public Rule() { }
    }
}
