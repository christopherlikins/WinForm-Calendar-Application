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
    public partial class LoggedIn : Form
    {
        public LoggedIn()
        {
            InitializeComponent();
        }

        private void Button_ExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_ToAppointmentListScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentList AppointmentListWindow = new AppointmentList();
            AppointmentListWindow.Show();
        }

        private void Button_ToCustomerListScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerList CustomerListWindow = new CustomerList();
            CustomerListWindow.Show();
        }

        private void LoggedIn_Load(object sender, EventArgs e)
        {
            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
            ConString.Open();
            string SqlString = string.Format("SELECT start FROM appointment");
            MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable AppointmentDataTable = new DataTable();
            adp.Fill(AppointmentDataTable);
            ConString.Close();
            for (int i = 0; i < AppointmentDataTable.Rows.Count; i++)
            {
                DateTime TimeOfLogin = DateTime.Now;
                DateTime AppointmentTimeHolder = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppointmentDataTable.Rows[i]["start"], TimeZoneInfo.Local);

                if (AppointmentTimeHolder > TimeOfLogin && AppointmentTimeHolder < TimeOfLogin.AddMinutes(15))
                {
                    MessageBox.Show(string.Format("Heads up there is an appointment scheduled within the next 15 minutes at {0}", AppointmentTimeHolder.TimeOfDay));
                }
            }
        }
    }
}
