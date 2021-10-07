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
    public partial class AppointmentList : Form
    {
        public AppointmentList()
        {
            InitializeComponent();

            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
            ConString.Open();
            string SqlString = "SELECT appointment.appointmentId, customer.customerName, `user`.userName, appointment.`type`, appointment.`start`, appointment.`end` FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN `user` ON appointment.userId = `user`.userId;";
            MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable AppointmentDataTable = new DataTable();
            adp.Fill(AppointmentDataTable);
            AppointmentDataGridView.DataSource = AppointmentDataTable;
            AppointmentDataGridView.MultiSelect = false;
            AppointmentDataGridView.ReadOnly = true;
            AppointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AppointmentDataGridView.AllowUserToAddRows = false;
            

            for (int i = 0; i < AppointmentDataTable.Rows.Count; i++)
            {
                AppointmentDataTable.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppointmentDataTable.Rows[i]["end"], TimeZoneInfo.Local).ToString();
            }
            for (int i = 0; i < AppointmentDataTable.Rows.Count; i++)
            {
                AppointmentDataTable.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppointmentDataTable.Rows[i]["start"], TimeZoneInfo.Local).ToString();
            }
            ConString.Close();

            Globals.MonthlyReport = "Report: Number of each type, by month\r\n\r\n";
            string[] Months = new string[] { "January", "Februrary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach (string month in Months)
            {
                Globals.MonthlyReport += Globals.MonthlyReport = month + "\r\n";
                int numScrum = 0;
                int numPresentation = 0;
                foreach (DataRow row in AppointmentDataTable.Rows)
                {
                    if (month == Months[((DateTime)row["start"]).Month - 1])
                    {
                        if (row["type"].ToString() == "Scrum")
                        {
                            numScrum++;
                        }
                        if (row["type"].ToString() == "Presentation")
                        {
                            numPresentation++;
                        }
                    }
                }
                Globals.MonthlyReport +=
                  "\tScrum\t\t\t" + numScrum + "\r\n" +
                  "\tPresentation\t\t" + numPresentation + "\r\n";
            }
            Globals.NumberOfAppointments = AppointmentDataTable.Rows.Count;
        }

        private void Button_ToAddAppointmentScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment AddAppointmentWindow = new AddAppointment();
            AddAppointmentWindow.Show();
        }

        private void Button_ModifySelectedAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection ConString = new MySqlConnection(Globals.connectionString);

                ConString.Open();
                string SqlString = string.Format("SELECT appointment.appointmentId, appointment.customerId, appointment.userId, customer.customerName, appointment.`type` , appointment.`start` , appointment.`end` FROM appointment JOIN customer ON appointment.customerId = customer.customerId WHERE appointmentId = {0}; ", Globals.CurrentAppointmentID);
                MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr["type"].ToString() == "Scrum")
                {
                    Globals.CurrentAppointment = new Scrum(
                    Convert.ToInt32(sdr["appointmentId"].ToString()),
                    Convert.ToInt32(sdr["customerId"].ToString()),
                    Convert.ToInt32(sdr["userId"].ToString()),
                    sdr["start"].ToString(),
                    sdr["end"].ToString(),
                    sdr["customerName"].ToString(),
                    sdr["type"].ToString());
                }
                else if (sdr["type"].ToString() == "Presentation")
                {
                    Globals.CurrentAppointment = new Presentation(
                    Convert.ToInt32(sdr["appointmentId"].ToString()),
                    Convert.ToInt32(sdr["customerId"].ToString()),
                    Convert.ToInt32(sdr["userId"].ToString()),
                    sdr["start"].ToString(),
                    sdr["end"].ToString(),
                    sdr["customerName"].ToString(),
                    sdr["type"].ToString());
                }
                else
                {
                    MessageBox.Show("The appointment has an invalid type. Please contact your databse administrator");
                }

                ConString.Close();
                this.Hide();
                ModifyAppointment ModifyAppointmentWindow = new ModifyAppointment();
                ModifyAppointmentWindow.Show();
            }
            catch
            {
                MessageBox.Show("Please select an Appointment to modify.");
            }
            

        }

        private void Button_ReturnToLoggedInScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoggedIn LoggedInWindow = new LoggedIn();
            LoggedInWindow.Show();
        }

        private void AppointmentList_Load(object sender, EventArgs e)
        {
            AppointmentDataGridView.ClearSelection();
            try
            {
                MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
                ConString.Open();
                string SqlString = "SELECT customerName FROM customer";
                MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader sdr = cmd.ExecuteReader();
                CustomerAppointmentListComboBox.Items.Add("All Customers");
                while (sdr.Read())

                {
                    CustomerAppointmentListComboBox.Items.Add(sdr["customerName"]);
                }
                ConString.Close();
            }
            catch
            {
                MessageBox.Show("Sql error");
            }
            string[] AppointmentsBy = new string[] {"All Appointments", "This Week", "This Month" };
            CalendarByWeekMonthAllComboBox.Items.AddRange(AppointmentsBy);
        }

        private void AppointmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                int SelectedIndex = AppointmentDataGridView.SelectedRows[0].Index;
                Globals.CurrentAppointmentID = int.Parse(AppointmentDataGridView[0, SelectedIndex].Value.ToString());
            }
            else
            {
                //This doesn't need to do anything :)
            }
        }

        private void Button_DeleteSelectedAppointment_Click(object sender, EventArgs e)
        {
            if (AppointmentDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    Globals.DeleteAppointment(Globals.CurrentAppointmentID);
                    MySqlConnection ConString = new MySqlConnection(Globals.connectionString);

                    ConString.Open();
                    string SqlString = "SELECT appointment.appointmentId, customer.customerName, `user`.userName, appointment.`type`, appointment.`start`, appointment.`end` AS appointment_list FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN `user` ON appointment.userId = `user`.userId;";
                    MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable AppointmentDataTable = new DataTable();
                    adp.Fill(AppointmentDataTable);
                    AppointmentDataGridView.DataSource = AppointmentDataTable;
                    ConString.Close();
                }
                catch
                {
                    MessageBox.Show("An error has occurred");
                }
            }
            else
            {
                MessageBox.Show("Please click on an appointment.");
            }
        }

        private void SearchAppointment_Click(object sender, EventArgs e)
        {
 
        }

        private void SearchAppointmentTextBox_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
            ConString.Open();
            string SqlString = "SELECT appointment.appointmentId, customer.customerName, `user`.userName, appointment.`type`, appointment.`start`, appointment.`end` AS appointment_list FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN `user` ON appointment.userId = `user`.userId;";
            MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable AppointmentDataTable = new DataTable();
            adp.Fill(AppointmentDataTable);
            AppointmentDataGridView.DataSource = AppointmentDataTable;


            AppointmentDataTable.DefaultView.RowFilter = "customerName LIKE '%" + SearchAppointmentTextBox.Text + "%' OR type LIKE '%" + SearchAppointmentTextBox.Text + "%' OR userName LIKE '%" + SearchAppointmentTextBox.Text + "%'";
            AppointmentDataGridView.DataSource = AppointmentDataTable.DefaultView;

            ConString.Close();
            
        }

        private void CustomerAppointmentListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (CustomerAppointmentListComboBox.Text == "All Customers")
                {
                    MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
                    ConString.Open();
                    string SqlString = "SELECT appointment.appointmentId, customer.customerName, `user`.userName, appointment.`type`, appointment.`start`, appointment.`end` AS appointment_list FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN `user` ON appointment.userId = `user`.userId;";
                    MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable AppointmentDataTable = new DataTable();
                    adp.Fill(AppointmentDataTable);
                    AppointmentDataGridView.DataSource = AppointmentDataTable;
                    AppointmentDataGridView.MultiSelect = false;
                    AppointmentDataGridView.ReadOnly = true;
                    AppointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    AppointmentDataGridView.AllowUserToAddRows = false;
                    AppointmentDataGridView.ClearSelection();
                    ConString.Close();
                }
                else
                {
                    MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
                    ConString.Open();
                    string SqlString = "SELECT appointment.appointmentId, customer.customerName, `user`.userName, appointment.`type`, appointment.`start`, appointment.`end` AS appointment_list FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN `user` ON appointment.userId = `user`.userId WHERE customerName = '" + Convert.ToString(CustomerAppointmentListComboBox.Text) + "';";
                    MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable AppointmentDataTable = new DataTable();
                    adp.Fill(AppointmentDataTable);
                    AppointmentDataGridView.DataSource = AppointmentDataTable;
                    AppointmentDataGridView.MultiSelect = false;
                    AppointmentDataGridView.ReadOnly = true;
                    AppointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    AppointmentDataGridView.AllowUserToAddRows = false;
                    AppointmentDataGridView.ClearSelection();
                    ConString.Close();
                }
            }
            catch
            {
                MessageBox.Show("There was an error filing the report.");
            }
        }

        private void MonthlyReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Globals.MonthlyReport);
        }

        private void NumberOfAppointmentsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("There are {0} appointments on the schedule.", Globals.NumberOfAppointments));
        }

        private void CalendarByWeekMonthAllComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ThisMonth = DateTime.Now.ToString("MM");
            int ThisDay = Convert.ToInt32(DateTime.Now.ToString("dd"));

            try
            {
                if (CalendarByWeekMonthAllComboBox.Text == "All Appointments")
                {
                    MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
                    ConString.Open();
                    string SqlString = "SELECT appointment.appointmentId, customer.customerName, `user`.userName, appointment.`type`, appointment.`start`, appointment.`end` AS appointment_list FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN `user` ON appointment.userId = `user`.userId;";
                    MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable AppointmentDataTable = new DataTable();
                    adp.Fill(AppointmentDataTable);
                    AppointmentDataGridView.DataSource = AppointmentDataTable;
                    AppointmentDataGridView.MultiSelect = false;
                    AppointmentDataGridView.ReadOnly = true;
                    AppointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    AppointmentDataGridView.AllowUserToAddRows = false;
                    AppointmentDataGridView.ClearSelection();
                    ConString.Close();
                    
                }
                else if (CalendarByWeekMonthAllComboBox.Text == "This Week")
                {
                    MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
                    ConString.Open();
                    string SqlString = "SELECT appointment.appointmentId, customer.customerName, `user`.userName, appointment.`type`, appointment.`start`, appointment.`end` AS appointment_list FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN `user` ON appointment.userId = `user`.userId WHERE DAY(start) BETWEEN " + ThisDay + " AND " + (ThisDay + 7) +";";
                    MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable AppointmentDataTable = new DataTable();
                    adp.Fill(AppointmentDataTable);
                    AppointmentDataGridView.DataSource = AppointmentDataTable;
                    AppointmentDataGridView.MultiSelect = false;
                    AppointmentDataGridView.ReadOnly = true;
                    AppointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    AppointmentDataGridView.AllowUserToAddRows = false;
                    AppointmentDataGridView.ClearSelection();
                    ConString.Close();
                }
                else if (CalendarByWeekMonthAllComboBox.Text == "This Month")
                {
                    MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
                    ConString.Open();
                    string SqlString = "SELECT appointment.appointmentId, customer.customerName, `user`.userName, appointment.`type`, appointment.`start`, appointment.`end` AS appointment_list FROM appointment JOIN customer ON appointment.customerId = customer.customerId JOIN `user` ON appointment.userId = `user`.userId WHERE DAy(start) BETWEEN " + ThisDay + " AND " + (ThisDay + 30) + ";";
                    MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable AppointmentDataTable = new DataTable();
                    adp.Fill(AppointmentDataTable);
                    AppointmentDataGridView.DataSource = AppointmentDataTable;
                    AppointmentDataGridView.MultiSelect = false;
                    AppointmentDataGridView.ReadOnly = true;
                    AppointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    AppointmentDataGridView.AllowUserToAddRows = false;
                    AppointmentDataGridView.ClearSelection();
                    ConString.Close();
                }
            }
            catch
            {
                MessageBox.Show("There was an error filing the report.");
            }
        }

        private void AppointmentDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Hello User!\nClicking here doesn't do anything.\nDo you feel like it should?");
        }

        private void AppointmentDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Hello User!\nClicking here doesn't do anything.\nDo you feel like it should?");
        }
    }
}
