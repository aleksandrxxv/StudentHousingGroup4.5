using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing
{
    public class Building
    {
        public string BuildingID;
        private string address;
        private int capacity;
        private decimal rentPerMonth;
        List<string> tenantIDs;

        public Building(string BuildingID, string address, int capacity, decimal rentPerMonth, List<string> tenantIDs)
        {
            this.BuildingID = BuildingID;
            this.address = address;
            this.capacity = capacity;
            this.rentPerMonth = rentPerMonth;
            this.tenantIDs = tenantIDs;
        }
    }
}
