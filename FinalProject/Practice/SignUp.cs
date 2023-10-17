using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Check if any of the text fields is empty
            if (string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return; //Don't proceed further
            }

            //Check if the checkbox is checked
            if (!chkBox.Checked)
            {
                MessageBox.Show("You must agree to the terms.");
                return; //Don't proceed further
            }

            //If all validations pass, proceed to insert data into the database
            InsertDataIntoDatabase();

        }

        private void InsertDataIntoDatabase()
        {
            string connectionString = "Server=192.168.1.41,1433;Database=LOGIN;User=YshikageOne;Password=clydelovejerra";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //Define your SQL query to insert data
                string query = "INSERT INTO loginForm (FirstName, LastName, Username, Password) " +
                               "VALUES (@FirstName, @LastName, @Username, @Password)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //Replace parameter values with actual values from the textboxes
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);

                    //Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful.");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
