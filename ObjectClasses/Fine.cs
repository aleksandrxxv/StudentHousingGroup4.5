using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentHousing.ObjectClasses
{
    public class Fine
    {
        public string Id { get; private set; }
        public decimal Amount { get; private set; }
        public string TennantId { get; private set; }
        public string Reason { get; private set; }
        public DateTime Date { get; private set; }

        public Fine(decimal amount, string tennantId, string reason, DateTime date)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Amount should be more than 0 €");
            }
            Id = Guid.NewGuid().ToString();
            Amount = amount;
            TennantId = tennantId;
            Reason = reason;
            Date = date;
        }

        [JsonConstructor]
        public Fine(string id, decimal amount, string tennantId, string reason, DateTime date) {
            Id = id;
            Amount = amount;
            TennantId = tennantId;
            Reason = reason;
            Date = date;
        }
    }
}
