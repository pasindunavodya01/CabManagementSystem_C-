using CabManagementSystem;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;database=cb013343;uid=pasindu;password=123pasindu;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string role = AuthenticateUser(username, password);
            if (role == "admin")
            {
                Admin admin = new Admin(connectionString);
                AdminDashboardForm adminDashboard = new AdminDashboardForm(admin);
                adminDashboard.Show();
                this.Hide();
            }
            else if (role == "customer")
            {
                Customer customer = new Customer(1, "Customer", "1234567890", "Current Location", "Destination", connectionString);
                CustomerDashboardForm customerDashboard = new CustomerDashboardForm(customer);
                customerDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials.");
            }
        }

        private string AuthenticateUser(string username, string password)
        {
            string role = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT role FROM users WHERE username = @username AND password = @password";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        role = result.ToString();
                    }
                }
            }

            return role;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
