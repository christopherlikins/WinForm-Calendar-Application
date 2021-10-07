using clikinsCalendar.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clikinsCalendar
{
    delegate bool isconfirmed(bool userConf, bool passConf);
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();

            CultureInfo ci = CultureInfo.CurrentCulture;
            if (ci.Name == "fr-FR")
            {
                Button_ExitProgram.Text = "Démissionner";
                Button_Login.Text = "Connectez-vous";
                UserNameLabel.Text = "Nom d'utilisateur";
                PasswordLabel.Text = "Mot de passe";
                
            }
            else if (ci.Name == "es-ES")
            {
                Button_ExitProgram.Text = "Renunciar";
                Button_Login.Text = "Iniciar sesión";
                UserNameLabel.Text = "Nombre de usuario";
                PasswordLabel.Text = "Contraseña";
            }
            else
            {
                //Its all good;
            }
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            string AttemptedUserName = UserNameTextBox.Text.ToString();
            string AttemptedPassword = PasswordTextBox.Text.ToString();
            bool IsConfirmed = false;
            bool IsUser = false;
            


            void PasswordConfirmed()
            {
                MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
                ConString.Open();
                string SqlString = string.Format("SELECT password FROM user WHERE userName = '{0}';", AttemptedUserName);
                MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (AttemptedPassword == Convert.ToString(sdr["password"].ToString()))
                {
                    IsConfirmed = true;
                }
                else
                {
                    IsConfirmed = false;
                }
                ConString.Close();
            }
            try
            {

                MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
                ConString.Open();
                string SqlString = string.Format("SELECT userName FROM user WHERE userName = '{0}';", AttemptedUserName);
                MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();

                PasswordConfirmed();
                IsUser = true;
                ConString.Close();

            }
            catch
            {
                IsUser = false;


            }
            //
            // LAMBDAS
            // These lambda expressions bring the conditions together and
            // make it easier to modify the conditions for username and password
            // in one place.
            //
            isconfirmed passInvalid = (u, p) => u && !p;
            isconfirmed userPassValid = (u, p) => u && p;

            if (!IsUser)
            {
                MessageBox.Show("Invalid User");

            }
            else if (passInvalid(IsUser, IsConfirmed))
            {
                MessageBox.Show("Invalid Password");
            }
            else if (userPassValid(IsUser, IsConfirmed))
            {
                MySqlConnection ConString = new MySqlConnection(Globals.connectionString);
                ConString.Open();
                string SqlString = string.Format("SELECT userId, userName FROM user WHERE userName = '{0}';", AttemptedUserName);
                MySqlCommand cmd = new MySqlCommand(SqlString, ConString);
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                

                Globals.CurrentUser = new User(Convert.ToInt32(sdr["userId"].ToString()), sdr["userName"].ToString());
                MessageBox.Show(string.Format("Welcome {0}", Globals.CurrentUser.UserName));


                try
                {
                    string fileName = "UserLogs.txt";
                    StreamWriter writer = new StreamWriter(fileName, true);
                    writer.Write("UserId: " + Globals.CurrentUser.UserID + " User Name: " + Globals.CurrentUser.UserName + " Login time: " + DateTime.Now.ToString() + "\n");
                    writer.Close();
                }
                catch
                {
                    MessageBox.Show("Error logging data");
                }

                this.Hide();
                LoggedIn LoggedInWindow = new LoggedIn();
                LoggedInWindow.Show();
            }
        }

        private void Button_ExitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Hello User!\nClicking here doesn't do anything.\nDo you feel like it should?");
        }

        private void UserDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show("Hello User!\nClicking here doesn't do anything.\nDo you feel like it should?");
        }
    }
}
