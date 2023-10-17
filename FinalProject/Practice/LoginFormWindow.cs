using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;

namespace LoginForm
{
    public partial class LoginFormWindow : Form
    {
        public LoginFormWindow()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=192.168.1.41,1433;Database=LOGIN;User=YshikageOne;Password=clydelovejerra";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string username = txtUsername.Text;
                string password = txtPassword.Text;

                string query = "SELECT FirstName, LastName FROM loginForm WHERE Username = @username AND Password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();

                            //Login successful, display first and last name
                            MessageBox.Show($"Login successful! Welcome, {firstName} {lastName}.");
                        }
                        else
                        {
                            //Login failed
                            MessageBox.Show("Invalid username or password.");
                        }
                    }

                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
        }
    }
}
