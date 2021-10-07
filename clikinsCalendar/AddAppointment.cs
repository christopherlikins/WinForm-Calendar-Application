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
    public partial class AddAppointment : Form
    {
        public static int idx = 0;
        DataTable dt = new DataTable();
        public bool IsOverlap(DateTime st, DateTime e, DateTime ast, DateTime ae)
        {
            return (st < ast) ? (e < ast) ? false : true : (st > ae) ? false : true;
        }
        void overlapp()
        {
            for (idx = 0; idx < dt.Rows.Count; idx++)
            {
                Globals.OldAppointmentStartTime = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local);
                Globals.OldAppointmentEndTime = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local);
                DateTime NewStartDateTime = AppointmentStartDatePicker.Value.Date.Add(AppointmentStartTimePicker.Value.TimeOfDay);
                DateTime NewEndDateTime = AppointmentEndDatePicker.Value.Date.Add(AppointmentEndTimePicker.Value.TimeOfDay);
                if (IsOverlap(NewStartDateTime, NewEndDateTime, Globals.OldAppointmentStartTime, Globals.OldAppointmentEndTime))
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

        public AddAppointment()
        {
            InitializeComponent();
            CurrentUserIdTextArea.Text = Globals.CurrentUser.UserID.ToString();
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
            
            string[] AppointmentTypes = new string[] { "Scrum", "Presentation" };
            AppointmentTypeComboBox.Items.AddRange(AppointmentTypes);
        }

        private void Button_SaveAppointment_Click(object sender, EventArgs e)
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
                            DateTime NewStartDateTime = AppointmentStartDatePicker.Value.Date.Add(AppointmentStartTimePicker.Value.TimeOfDay).ToUniversalTime();
                            DateTime NewEndDateTime = AppointmentEndDatePicker.Value.Date.Add(AppointmentEndTimePicker.Value.TimeOfDay).ToUniversalTime();
                            string CustomerForAppointment = Convert.ToString(CustomerSelectComboBox.Text);
                            string TypeOfNewAppoinment = Convert.ToString(AppointmentTypeComboBox.Text);

                            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);

                            ConString.Open();
                            string SqlString = string.Format("INSERT INTO appointment VALUES (0,(SELECT customerId FROM customer WHERE customerName = '{0}'),{1},'not needed','not needed','not needed','not needed','{2}','not needed','{3}','{4}','{5}','{6}','{7}','{8}');", CustomerForAppointment, Globals.CurrentUser.UserID, TypeOfNewAppoinment, NewStartDateTime.ToString("yyyy'-'MM'-'dd HH:mm:ss"), NewEndDateTime.ToString("yyyy'-'MM'-'dd HH:mm:ss"), DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss"), Convert.ToString(Globals.CurrentUser.UserName), DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss"), Convert.ToString(Globals.CurrentUser.UserName));
                            MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                            MySqlDataReader sdr = cmd.ExecuteReader();
                            ConString.Close();
                            MessageBox.Show("The Appointment record has been set");
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

        private void Button_CancelToAppointmentList_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentList AppointmentListWindow = new AppointmentList();
            AppointmentListWindow.Show();
        }
        private void AddAppointment_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
