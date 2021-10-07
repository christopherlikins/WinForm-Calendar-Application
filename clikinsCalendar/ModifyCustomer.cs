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
    public partial class ModifyCustomer : Form
    {
        public ModifyCustomer()
        {
            InitializeComponent();
            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
            ConString.Open();
            try
            {
                string SqlString = "SELECT customer.customerId, customer.customerName, address.addressId, address.address, address.phone, city.cityId, city.city, country.countryId, country.country FROM customer LEFT JOIN address ON customer.addressId = address.addressId JOIN city ON address.cityId = city.cityId JOIN country ON city.countryId = country.countryId WHERE customerId = " + Globals.CurrentCustomerID;
                MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                cmd.CommandType = CommandType.Text;
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                try
                {

                    Globals.TheCustomerID = Convert.ToInt32(sdr["customerId"].ToString());
                    Globals.TheAddressID = Convert.ToInt32(sdr["addressId"].ToString());
                    Globals.TheCityID = Convert.ToInt32(sdr["cityId"].ToString());
                    Globals.TheCountryID = Convert.ToInt32(sdr["countryId"].ToString());
                    CurrentCustomerIdField.Text = sdr["customerId"].ToString();
                    CurrentCustomerNameTextBox.Text = sdr["customerName"].ToString();
                    CurrentCustomerAddressTextBox.Text = sdr["address"].ToString();
                    CurrentCustomerPhoneTextBox.Text = sdr["phone"].ToString();
                    CurrentCustomerCityTextBox.Text = sdr["city"].ToString();
                    CurrentCustomerCountryTextBox.Text = sdr["country"].ToString();
                }
                catch
                {
                    MessageBox.Show("Please select a customer to modify.");
                }
                ConString.Close();
            }
            catch
            {
                MessageBox.Show("The request failed");
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

            if (string.IsNullOrEmpty(CurrentCustomerNameTextBox.Text) ||
                string.IsNullOrEmpty(CurrentCustomerAddressTextBox.Text) ||
                string.IsNullOrEmpty(CurrentCustomerPhoneTextBox.Text) ||
                string.IsNullOrEmpty(CurrentCustomerCityTextBox.Text) ||
                string.IsNullOrEmpty(CurrentCustomerCountryTextBox.Text))
            {
                MessageBox.Show("Please ensure all fields have values. Thank you.");
            }
            else
            {
                try
                {
                    MySqlConnection ConString = new MySqlConnection(Globals.connectionString);

                    ConString.Open();
                    string SqlString =
                    "UPDATE customer SET customerName = '" + Convert.ToString(CurrentCustomerNameTextBox.Text) + "' WHERE customerId = " + Globals.TheCustomerID + ";" +
                    "UPDATE address SET address = '" + Convert.ToString(CurrentCustomerAddressTextBox.Text) + "'" + "WHERE addressId = " + Globals.TheAddressID + ";" +
                    "UPDATE address SET phone = '" + Convert.ToString(CurrentCustomerPhoneTextBox.Text) + "' WHERE addressId = " + Globals.TheAddressID +";" +
                    "UPDATE city SET city = '" + Convert.ToString(CurrentCustomerCityTextBox.Text) + "' WHERE cityId = " + Globals.TheCityID + ";" +
                    "UPDATE country SET country = '" + Convert.ToString(CurrentCustomerCountryTextBox.Text) + "' WHERE countryId = " +Globals.TheCountryID + ";";
                    MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                    MySqlDataReader sdr = cmd.ExecuteReader();
                    ConString.Close();
                    this.Hide();
                    CustomerList CustomerListWindow = new CustomerList();
                    CustomerListWindow.Show();
                    MessageBox.Show("This customer record has been updated.");
                }
                catch
                {
                    MessageBox.Show("An error has occurred.");
                }
            }
        }

        private void CurrentCustomerPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!Int32.TryParse(CurrentCustomerPhoneTextBox.Text, out number) && !string.IsNullOrWhiteSpace(CurrentCustomerPhoneTextBox.Text))
            {
                MessageBox.Show("Please do not use letters or symbols in the phone number field.");
                CurrentCustomerPhoneTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                CurrentCustomerPhoneTextBox.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
