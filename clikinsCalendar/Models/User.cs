using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clikinsCalendar.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }
        public string CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public User (int uID, string uName)
        {
            UserID = uID;
            UserName = uName;
        }
        public User()
        {

        }
    }
}
