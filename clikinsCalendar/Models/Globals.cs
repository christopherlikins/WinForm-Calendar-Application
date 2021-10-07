using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clikinsCalendar.Models
{
    public class Globals
    {
        public static User CurrentUser { get; set; }
        public static Customer CurrentCustomer { get; set; }
        public static Appointment CurrentAppointment { get; set; }
        public static string MonthlyReport { get; set; }
        public static int NumberOfAppointments { get; set; }

        public static int CurrentAppointmentID { get; set; }
        public static int CurrentCustomerID { get; set; }
        public static int CurrentUserID { get; set; }
        public static int TheCustomerID { get; set; }
        public static int TheAddressID { get; set; }
        public static int TheCityID { get; set; }
        public static int TheCountryID { get; set; }
        public static int TheMaxCustomerID { get; set; }
        public static int TheMaxAddressID { get; set; }
        public static int TheMaxCityID { get; set; }
        public static int TheMaxCountryID { get; set; }
        delegate bool isconfirmed(string attemptedPassword, string storedPassword);        
        public static bool Overlapping { get; set; }
        public static bool IsOverlap(DateTime st, DateTime e, DateTime ast, DateTime ae)
        {
            return (st < ast) ? (e < ast) ? false : true : (st > ae) ? false : true;
        }
        public static DateTime OldAppointmentStartTime { get; set; }
        public static DateTime OldAppointmentEndTime { get; set; }

        public static string connectionString = @"";

        public static void DeleteCustomer (int CustomerID)
        {
            MySqlConnection ConString = new MySqlConnection(connectionString);
            ConString.Open();
            string SqlDeleteCustomerIDString = "DELETE FROM customer WHERE customerId = " + CustomerID;
            MySqlCommand DeleteCustomerIDcmd = new MySqlCommand(SqlDeleteCustomerIDString, ConString);
            DeleteCustomerIDcmd.ExecuteNonQuery();
        }
        public static void DeleteAppointment (int AppointmentID)
        {
            MySqlConnection ConString = new MySqlConnection(connectionString);
            ConString.Open();
            string SqlDeleteAppointmentIDString = "DELETE FROM appointment WHERE appointmentId = " + AppointmentID;
            MySqlCommand DeleteAppointmentIDcmd = new MySqlCommand(SqlDeleteAppointmentIDString, ConString);
            DeleteAppointmentIDcmd.ExecuteNonQuery();
        }
    }
}
