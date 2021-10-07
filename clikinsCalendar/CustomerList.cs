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
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();

            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
            ConString.Open();
            string SqlString = "SELECT * FROM customer";
            MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable CustomerDataTable = new DataTable();
            adp.Fill(CustomerDataTable);
            CustomerDataGridView.DataSource = CustomerDataTable;

            CustomerDataGridView.MultiSelect = false;
            CustomerDataGridView.ReadOnly = true;
            CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDataGridView.AllowUserToAddRows = false;
        }

        private void Button_ToAddCustomerScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer AddCustomerWindow = new AddCustomer();
            AddCustomerWindow.Show();
        }

        private void Button_ModifySelectedCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyCustomer ModifyCustomerWindow = new ModifyCustomer();
            ModifyCustomerWindow.Show();
        }
        
        private void Button_DeleteSelectedCustomer_Click(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count > 0)
            {

                try
                {
                    Globals.DeleteCustomer(Globals.CurrentCustomerID);
                    MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
                    ConString.Open();
                    string SqlString = "SELECT * FROM customer";
                    MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable CustomerDataTable = new DataTable();
                    adp.Fill(CustomerDataTable);
                    CustomerDataGridView.DataSource = CustomerDataTable;
                }
                catch
                {
                    MessageBox.Show("This Customer has an appointment scheduled and cannot be deleted at this time.");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer.");
            }
        }

        private void Button_ReturnToLoggedInScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoggedIn LoggedInWindow = new LoggedIn();
            LoggedInWindow.Show();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            CustomerDataGridView.ClearSelection();
            CustomerDataGridView.Columns["addressId"].Visible = false;
            CustomerDataGridView.Columns["customerId"].Visible = false;
        }

        private void CustomerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                int SelectedIndex = CustomerDataGridView.SelectedRows[0].Index;
                Globals.CurrentCustomerID = Convert.ToInt32(CustomerDataGridView[0, SelectedIndex].Value.ToString());
            }
            else
            {
                //This doesn't need to do anything :)
            }


        }

        private void SearchCustomerTextBox_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
            ConString.Open();
            string SqlString = "SELECT * FROM customer";
            MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable CustomerDataTable = new DataTable();
            adp.Fill(CustomerDataTable);
            CustomerDataGridView.DataSource = CustomerDataTable;

            CustomerDataTable.DefaultView.RowFilter = "customerName LIKE '%" + SearchCustomerTextBox.Text + "%' OR createdBy LIKE '%" + SearchCustomerTextBox.Text + "%'";
            CustomerDataGridView.DataSource = CustomerDataTable.DefaultView;

            ConString.Close();
        }

        private void CustomerDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Hello User!\nClicking here doesn't do anything.\nDo you feel like it should?");
        }

        private void CustomerDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Hello User!\nClicking here doesn't do anything.\nDo you feel like it should?");
        }
    }
}
