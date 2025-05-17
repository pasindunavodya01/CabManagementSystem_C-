using CabManagementSystem;
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

namespace WinFormsApp3
{
    public partial class AdminRegisterForm : Form

    {
        private Admin admin;
        private string connectionString = "server=localhost;database=cb013343;uid=pasindu;password=123pasindu;";
        public AdminRegisterForm()
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void AdminRegisterForm_Load(object sender, EventArgs e)
        {

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
                // Insert admin details into the admins table
                InsertAdmin(name, contactNumber);

                // Insert login details into the users table
                InsertUser(username, hashedPassword, "admin");

                MessageBox.Show("Registration successful.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

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

        private void InsertAdmin(string name, string contactNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO admins (Name, ContactNumber) " +
                               "VALUES (@name, @contactNumber)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@contactNumber", contactNumber);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertUser(string username, string password, string role)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO users (username, password, role) " +
                               "VALUES (@username, @password, @role)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@role", role);

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

        private void txtContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

