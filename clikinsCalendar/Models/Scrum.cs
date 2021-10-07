using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clikinsCalendar.Models
{
    public class Scrum : Appointment
    {
        public string ScrumAppointment { get; set; }
        public Scrum(int aID, int cID, int uID, string startAppointment, string endAppointment,string custName, string typeScrum) 
            :base(aID, cID, uID, startAppointment, endAppointment, custName)
        {
            ScrumAppointment = typeScrum;
        }
    }
}
