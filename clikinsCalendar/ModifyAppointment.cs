using clikinsCalendar.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clikinsCalendar
{

    public partial class ModifyAppointment : Form
    {
        public static int idx = 0;
        DataTable dt = new DataTable();

        void overlapp()
        {
            for (idx = 0; idx < dt.Rows.Count; idx++)
            {
                Globals.OldAppointmentStartTime = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local);
                Globals.OldAppointmentEndTime = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local);
                DateTime NewStartDateTime = AppointmentStartDatePicker.Value.Date.Add(AppointmentStartTimePicker.Value.TimeOfDay);
                DateTime NewEndDateTime = AppointmentEndDatePicker.Value.Date.Add(AppointmentEndTimePicker.Value.TimeOfDay);
                if (Globals.IsOverlap(NewStartDateTime, NewEndDateTime, Globals.OldAppointmentStartTime, Globals.OldAppointmentEndTime))
                {
                    Globals.Overlapping = true;
                    break;
                }
                else
                {
                    Globals.Overlapping = false;
                }
            }

        }
        public ModifyAppointment()
        {
            InitializeComponent();
            CurrentUserIdTextArea.Text = Globals.CurrentAppointment.UserID.ToString();
            CurrentAppointmentStartTimeLabel.Text = Globals.CurrentAppointment.AppointmentStart;
            CurrentAppointmentEndTimeLabel.Text = Globals.CurrentAppointment.AppiontmentEnd;
            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
            ConString.Open();
            try
            {
                string SqlString = "SELECT customerName FROM customer";
                MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader sdr = cmd.ExecuteReader(); 
                while (sdr.Read())
                {
                   CustomerSelectComboBox.Items.Add(sdr["customerName"]);
                }
                ConString.Close();                   
            }
            catch
            {
                MessageBox.Show("Sql error");
            }
            CustomerSelectComboBox.Text = Globals.CurrentAppointment.CustomerName;
            string[] AppointmentTypes = new string[] { "Scrum", "Presentation" };
            AppointmentTypeComboBox.Items.AddRange(AppointmentTypes);
            if (Globals.CurrentAppointment.GetType() == typeof(Scrum))
            {
                Scrum a = (Scrum)Globals.CurrentAppointment;
                AppointmentTypeComboBox.Text = a.ScrumAppointment.ToString();
            }
            else if (Globals.CurrentAppointment.GetType() == typeof(Presentation))
            {
                Presentation a = (Presentation)Globals.CurrentAppointment;
                AppointmentTypeComboBox.Text = a.PresentationAppointment.ToString();
            }
            else
            {
                MessageBox.Show("This type of appointment has not been discussed. Please contact your database administrator");
            }


            
        }
        private void Button_CancelToAppointmentList_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentList AppointmentListWindow = new AppointmentList();
            AppointmentListWindow.Show();
        }

        private void Button_SaveAppointment_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerSelectComboBox.Text) ||
                string.IsNullOrEmpty(AppointmentTypeComboBox.Text))
            {
                MessageBox.Show("Please ensure all fields have values. Thank you.");
            }
            else
            {
                DateTime NewStartTime = AppointmentStartTimePicker.Value;
                DateTime NewEndTime = AppointmentEndTimePicker.Value;
                DateTime BusinessStart = Convert.ToDateTime("12/12/2012 08:00:00 AM");
                DateTime BusinessEnd = Convert.ToDateTime("12/12/2012 05:00:00 PM");
                int StartAfterOpen = TimeSpan.Compare(NewStartTime.TimeOfDay, BusinessStart.TimeOfDay);
                int StartBeforeClose = TimeSpan.Compare(NewStartTime.TimeOfDay, BusinessEnd.TimeOfDay);
                int EndAfterOpen = TimeSpan.Compare(NewEndTime.TimeOfDay, BusinessStart.TimeOfDay);
                int EndBeforeClose = TimeSpan.Compare(NewEndTime.TimeOfDay, BusinessEnd.TimeOfDay);
                if ((StartAfterOpen == 1 && StartBeforeClose == -1) && (EndAfterOpen == 1 && EndBeforeClose == -1))
                {
                    overlapp();
                    if (!Globals.Overlapping)
                    {
                        try
                        {
                            DateTime NewStartDateTime = AppointmentStartDatePicker.Value.Date.Add(AppointmentStartTimePicker.Value.TimeOfDay);
                            DateTime NewEndDateTime = AppointmentEndDatePicker.Value.Date.Add(AppointmentEndTimePicker.Value.TimeOfDay);
                            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);

                            ConString.Open();
                            string SqlString = string.Format("UPDATE appointment SET customerId = (SELECT customerId FROM customer WHERE customerName = '{0}') WHERE appointmentId = {1};", CustomerSelectComboBox.Text, Globals.CurrentAppointment.AppointmentID);
                            SqlString += string.Format("UPDATE appointment SET type = '{0}' WHERE appointmentId = {1};", AppointmentTypeComboBox.Text, Globals.CurrentAppointment.AppointmentID);
                            SqlString += string.Format("UPDATE appointment SET start = '{0}' WHERE appointmentId = {1};", NewStartDateTime.ToString("yyyy'-'MM'-'dd HH:mm:ss"), Globals.CurrentAppointment.AppointmentID);
                            SqlString += string.Format("UPDATE appointment SET end = '{0}' WHERE appointmentId = {1};", NewEndDateTime.ToString("yyyy'-'MM'-'dd HH:mm:ss"), Globals.CurrentAppointment.AppointmentID);
                            MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                            MySqlDataReader sdr = cmd.ExecuteReader();
                            ConString.Close();
                            MessageBox.Show("The Appointment record has been updated");
                            this.Hide();
                            AppointmentList AppointmentListWindow = new AppointmentList();
                            AppointmentListWindow.Show();
                        }
                        catch
                        {
                            MessageBox.Show("An error has occurred.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There is a conflicting appointment from: \n" + Convert.ToString(Globals.OldAppointmentStartTime) + " to " + Convert.ToString(Globals.OldAppointmentEndTime) +
                            "\nPlease adjust your new appointment to avoid this conflict.\nThank you.");
                    }

                }
                else { MessageBox.Show("Please ensure that your appointment\nbegins and ends between 8AM and 5PM.\nThank you."); }
                
            }
        }

        private void ModifyAppointment_Load(object sender, EventArgs e)
        {
            AppointmentStartTimePicker.Value = DateTime.Now;
            AppointmentEndTimePicker.Value = DateTime.Now.AddMinutes(30);
            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
            ConString.Open();
            try
            {
                string SqlString = "SELECT start, end FROM appointment";
                MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                ConString.Close();
            }
            catch
            {
                MessageBox.Show("Sql error");
            }
        }
    }
}
