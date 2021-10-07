using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clikinsCalendar.Models
{
    public class Presentation : Appointment
    {
        public string PresentationAppointment { get; set; }
        public Presentation(int aID, int cID, int uID, string startAppointment, string endAppointment, string custName, string typePresentation)
            : base(aID, cID, uID, startAppointment, endAppointment, custName)
        {
            PresentationAppointment = typePresentation;
        }
    }
}
