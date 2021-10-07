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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            Globals.DeleteAppointment(Globals.CurrentAppointmentID);
            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);

            ConString.Open();

            try
            {
                string SqlString = "SELECT MAX(customer.customerId) as maxCustomerId, MAX(address.addressId) as maxAddressId, MAX(city.cityId) as maxCityId, MAX(country.countryId) as maxCountryId FROM customer JOIN address ON customer.customerId = address.addressId JOIN city ON address.cityId = city.cityId JOIN country ON city.countryId = country.countryId;";
                MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                try
                {
                    Globals.TheMaxCustomerID = Convert.ToInt32(sdr["maxCustomerId"].ToString()) + 1;
                    NewCustomerIdField.Text = Convert.ToString(Globals.TheMaxCustomerID);
                    Globals.TheMaxAddressID = Convert.ToInt32(sdr["maxAddressId"].ToString()) + 1;
                    Globals.TheMaxCityID = Convert.ToInt32(sdr["maxCityId"].ToString()) + 1;
                    Globals.TheMaxCountryID = Convert.ToInt32(sdr["maxCountryId"].ToString()) + 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch
            {
                MessageBox.Show("The sql query failed.");
            }
        }

        private void Button_CancelToCustomerList_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerList CustomerListWindow = new CustomerList();
            CustomerListWindow.Show();
        }

        private void Button_SaveCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewCustomerNameTextBox.Text) ||
                string.IsNullOrEmpty(NewCustomerAddressTextBox.Text) ||
                string.IsNullOrEmpty(NewCustomerPhoneTextBox.Text) ||
                string.IsNullOrEmpty(NewCustomerCityTextBox.Text) ||
                string.IsNullOrEmpty(NewCustomerCountryTextBox.Text))
            {
                MessageBox.Show("Please ensure all fields have values. Thank you.");
            }
            else
            {
                try
                {
                    DateTime SaveUtcNow = DateTime.UtcNow;
                    MySqlConnection ConString = new MySqlConnection(Globals.connectionString);

                    string NewCountry = Convert.ToString(NewCustomerCountryTextBox.Text);
                    string NewCity = Convert.ToString(NewCustomerCityTextBox.Text);
                    string NewAddress = Convert.ToString(NewCustomerAddressTextBox.Text);
                    string NewCustomer = Convert.ToString(NewCustomerNameTextBox.Text);


                    ConString.Open();
                    string SqlString = string.Format("INSERT INTO country(countryId, country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(0, '{0}', '2019-01-01 00:00:00', '{1}', NULL, '{1}');", NewCountry, Globals.CurrentUser.UserName);
                    SqlString += string.Format("INSERT INTO city(cityId, city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(0, '{0}', (SELECT countryId FROM country WHERE country = '{1}' LIMIT 1), '2019-01-01 00:00:00','{2}', NULL, '{2}');", NewCity, NewCountry, Globals.CurrentUser.UserName);
                    SqlString += string.Format("INSERT INTO address(addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES(0, '{0}', '', (SELECT cityId FROM city WHERE city = '{1}' LIMIT 1),'11111','555-1212','2019-01-01 00:00:00','{2}', NULL, '{2}');", NewAddress, NewCity, Globals.CurrentUser.UserName);
                    SqlString += string.Format("INSERT INTO customer (customerId, customerName, addressId , active , createDate , createdBy , lastUpdate , lastUpdateBy ) VALUES(0, '{0}', (SELECT addressId FROM address WHERE address = '{1}' LIMIT 1), 1,'2019-01-01 00:00:00','{2}', NULL, '{2}'); ", NewCustomer, NewAddress, Globals.CurrentUser.UserName);
                    MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                    MySqlDataReader sdr = cmd.ExecuteReader();
                    ConString.Close();

                    this.Hide();
                    CustomerList CustomerListWindow = new CustomerList();
                    CustomerListWindow.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }

        private void NewCustomerPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(NewCustomerPhoneTextBox.Text, out number) && !string.IsNullOrWhiteSpace(NewCustomerPhoneTextBox.Text))
            {
                MessageBox.Show("Please do not use letters or symbols in the phone number field.");
                NewCustomerPhoneTextBox.BackColor = System.Drawing.Color.Salmon;
            }

            else
            {
                NewCustomerPhoneTextBox.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
