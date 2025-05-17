using CabManagementSystem;
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
    public partial class DriverManagementForm : Form
    {
        private Admin admin;
        public DriverManagementForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Driver newDriver = new Driver(0, txtDriverName.Text, txtDriverContact.Text, true);
            admin.AddDriver(newDriver);
            MessageBox.Show("Driver added successfully.");
            LoadDrivers(); // Refresh the list
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DriverManagementForm_Load(object sender, EventArgs e)
        {
            LoadDrivers();
        }
        private void LoadDrivers()
        {
            List<Driver> drivers = admin.GetAllDrivers(); // Use the new method to get all drivers
            dgvDrivers.DataSource = drivers;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int driverId = Convert.ToInt32(txtDriverId.Text);
            admin.RemoveDriver(driverId);
            MessageBox.Show("Driver removed successfully.");
            LoadDrivers(); // Refresh the list
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int driverId = Convert.ToInt32(txtDriverId.Text);
            bool availability = admin.CheckDriverAvailability(driverId);
            MessageBox.Show($"Car availability: {(availability ? "Available" : "Not Available")}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int driverId = Convert.ToInt32(txtDriverId.Text);
            bool availability = admin.ToggleDriverAvailability(driverId);
            MessageBox.Show($"Car availability toggled to {(availability ? "Available" : "Not Available")}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int driverId = Convert.ToInt32(txtDriverId.Text);
            bool availability = admin.GetDriverAvailability(driverId); // Get the current availability status
            admin.UpdateCarAvailability(driverId, availability); // Save the current availability status
            MessageBox.Show("Changes saved successfully.");
            LoadDrivers();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm(admin);
            adminDashboardForm.ShowDialog();
            this.Close();
        }
    }
}

