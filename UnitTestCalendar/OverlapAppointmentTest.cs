using Microsoft.VisualStudio.TestTools.UnitTesting;
using clikinsCalendar.Models;
using System;
using clikinsCalendar;

namespace UnitTestCalendar
{
    [TestClass]
    public class OverlapAppointmentTest
    {
        [TestMethod]
        public void AppointmentsDontOverlap()
        {
            //Arrange
            Appointment OldAppointment = new Appointment(1, 1, 1, "12/01/1999 08:00:00", "12/01/1999 08:30:00", "Mary");
            Appointment NewAppointment = new Appointment(2, 2, 2, "12/01/1999 09:00:00", "12/01/1999 09:30:00", "Mary");
            DateTime NewStart = DateTime.Parse(NewAppointment.AppointmentStart);
            DateTime NewEnd = DateTime.Parse(NewAppointment.AppiontmentEnd);
            DateTime OldStart = DateTime.Parse(OldAppointment.AppointmentStart);
            DateTime OldEnd = DateTime.Parse(OldAppointment.AppiontmentEnd);

            //Act
            //Call IsOverlap
            Globals.IsOverlap(NewStart, NewEnd, OldStart, OldEnd);

            //Assert
            //
            Assert.IsFalse(false, "There is not an overlap with these appointments.");
        }
        [TestMethod]
        public void AppointmentsOverlapAtEnd()
        {
            //Arrange
            Appointment OldAppointment = new Appointment(1, 1, 1, "12/01/1999 08:00:00", "12/01/1999 08:30:00", "Mary");
            Appointment NewAppointment = new Appointment(2, 2, 2, "12/01/1999 07:45:00", "12/01/1999 08:15:00", "Mary");
            DateTime NewStart = DateTime.Parse(NewAppointment.AppointmentStart);
            DateTime NewEnd = DateTime.Parse(NewAppointment.AppiontmentEnd);
            DateTime OldStart = DateTime.Parse(OldAppointment.AppointmentStart);
            DateTime OldEnd = DateTime.Parse(OldAppointment.AppiontmentEnd);

            //Act
            //Call IsOverlap
            Globals.IsOverlap(NewStart, NewEnd, OldStart, OldEnd);

            //Assert
            //
            Assert.IsTrue(true, "There is an overlap at the New Appointment End Time.");
        }
        [TestMethod]
        public void AppointmentsOverlapAtBeginning()
        {
            //Arrange
            Appointment OldAppointment = new Appointment(1, 1, 1, "12/01/1999 08:00:00", "12/01/1999 08:30:00", "Mary");
            Appointment NewAppointment = new Appointment(2, 2, 2, "12/01/1999 08:15:00", "12/01/1999 08:45:00", "Mary");
            DateTime NewStart = DateTime.Parse(NewAppointment.AppointmentStart);
            DateTime NewEnd = DateTime.Parse(NewAppointment.AppiontmentEnd);
            DateTime OldStart = DateTime.Parse(OldAppointment.AppointmentStart);
            DateTime OldEnd = DateTime.Parse(OldAppointment.AppiontmentEnd);

            //Act
            //Call IsOverlap
            Globals.IsOverlap(NewStart, NewEnd, OldStart, OldEnd);

            //Assert
            //
            Assert.IsTrue(true, "There is an overlap at the New Appointment Start Time.");
        }
        [TestMethod]
        public void AppointmentsOverlapAtBeginningAndEnd()
        {
            //Arrange
            Appointment OldAppointment = new Appointment(1, 1, 1, "12/01/1999 08:00:00", "12/01/1999 08:30:00", "Mary");
            Appointment NewAppointment = new Appointment(2, 2, 2, "12/01/1999 07:45:00", "12/01/1999 08:45:00", "Mary");
            DateTime NewStart = DateTime.Parse(NewAppointment.AppointmentStart);
            DateTime NewEnd = DateTime.Parse(NewAppointment.AppiontmentEnd);
            DateTime OldStart = DateTime.Parse(OldAppointment.AppointmentStart);
            DateTime OldEnd = DateTime.Parse(OldAppointment.AppiontmentEnd);

            //Act
            //Call IsOverlap
            Globals.IsOverlap(NewStart, NewEnd, OldStart, OldEnd);

            //Assert
            //
            Assert.IsFalse(false, "The new appointment completely overlaps the old appointment.");
        }
        [TestMethod]
        public void AppointmentsOverlapInTheMiddle()
        {
            //Arrange
            Appointment OldAppointment = new Appointment(1, 1, 1, "12/01/1999 08:00:00", "12/01/1999 08:30:00", "Mary");
            Appointment NewAppointment = new Appointment(2, 2, 2, "12/01/1999 08:15:00", "12/01/1999 08:25:00", "Mary");
            DateTime NewStart = DateTime.Parse(NewAppointment.AppointmentStart);
            DateTime NewEnd = DateTime.Parse(NewAppointment.AppiontmentEnd);
            DateTime OldStart = DateTime.Parse(OldAppointment.AppointmentStart);
            DateTime OldEnd = DateTime.Parse(OldAppointment.AppiontmentEnd);

            //Act
            //Call IsOverlap
            Globals.IsOverlap(NewStart, NewEnd, OldStart, OldEnd);

            //Assert
            //
            Assert.IsFalse(false, "The new appointment sits within the old appointment.");
        }
    }
}
