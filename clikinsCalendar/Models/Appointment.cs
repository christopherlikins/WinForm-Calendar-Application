using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clikinsCalendar.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string AppointmentStart { get; set; }
        public string AppiontmentEnd { get; set; }
        public string CustomerName { get; set; }

        public Appointment(int aID, int cID, int uID, string startAppointment, string endAppointment, string custName)
        {
            AppointmentID = aID;
            CustomerID = cID;
            UserID = uID;
            AppointmentStart = startAppointment;
            AppiontmentEnd = endAppointment;
            CustomerName = custName;
        }
        public Appointment()
        {

        }
    }

}
