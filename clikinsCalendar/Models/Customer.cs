using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clikinsCalendar.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int AddressID { get; set; }
        public int Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public Customer (int custID, string custName, int addressID, int isActive, DateTime dateCreated, string whoCreated, DateTime whenUpdated, string whoUpdated)
        {
            CustomerID = custID;
            CustomerName = custName;
            AddressID = addressID;
            Active = isActive;
            CreateDate = dateCreated;
            CreatedBy = whoCreated;
            LastUpdated = whenUpdated;
            UpdatedBy = whoUpdated;
        }
        public Customer ()
        {

        }

    }
}
