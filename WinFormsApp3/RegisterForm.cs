using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class RegisterForm : Form
    {
        private string connectionString = "server=localhost;database=cb013343;uid=pasindu;password=123pasindu;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string contactNumber = txtContactNumber.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contactNumber) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if username already exists
            if (UsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different one.");
                return;
            }

            // Hash the password
            string hashedPassword = HashPassword(password);

            try
            {
                // Insert customer details into the customers table and retrieve the customerId
                int customerId = InsertCustomer(name, contactNumber);

                // Insert login details into the users table along with the customerId
                InsertUser(username, hashedPassword, "customer", customerId);

                MessageBox.Show("Registration successful.");
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private bool UsernameExists(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private int InsertCustomer(string name, string contactNumber)
        {
            int customerId = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO customers (Name, ContactNumber) VALUES (@name, @contactNumber); SELECT LAST_INSERT_ID();";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@contactNumber", contactNumber);

                    connection.Open();
                    customerId = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            return customerId;
        }

        private void InsertUser(string username, string password, string role, int customerId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO users (username, password, role, customerId) VALUES (@username, @password, @role, @customerId)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@customerId", customerId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private string HashPassword(string password)
        {
            // Implement password hashing algorithm (e.g., using SHA256)
            // For simplicity, you can use libraries like BCrypt or built-in .NET methods for hashing.
            // Example: return BCrypt.HashPassword(password);
            return password; // For demonstration purposes (replace with actual hashing implementation)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
