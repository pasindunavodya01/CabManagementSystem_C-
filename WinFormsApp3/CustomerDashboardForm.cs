using CabManagementSystem;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class CustomerDashboardForm : Form
    {
        private Customer customer;

        public CustomerDashboardForm(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            LoadAvailableCars();
            LoadAvailableDrivers();
        }

        private void LoadAvailableCars()
        {
            List<Car> cars = customer.ShowAvailableCars();



            cboAvailableCars.DataSource = cars;
            cboAvailableCars.DisplayMember = "Model";
            cboAvailableCars.ValueMember = "CarId";
        }

        private void LoadAvailableDrivers()
        {
            List<Driver> drivers = customer.ShowAvailableDrivers();



            cboAvailableDrivers.DataSource = drivers;
            cboAvailableDrivers.DisplayMember = "Name";
            cboAvailableDrivers.ValueMember = "DriverId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car selectedCar = cboAvailableCars.SelectedItem as Car;
            Driver selectedDriver = cboAvailableDrivers.SelectedItem as Driver;
            string currentLocation = txtCurrentLocation.Text;
            string destination = txtDestination.Text;

            if (selectedCar != null && selectedDriver != null && !string.IsNullOrWhiteSpace(currentLocation) && !string.IsNullOrWhiteSpace(destination))
            {
                try
                {
                    customer.PlaceOrder(customer.CustomerId, selectedCar.CarId, selectedDriver.DriverId, currentLocation, destination);
                    MessageBox.Show("Order placed successfully.");
                    LoadAvailableCars(); // Refresh the available cars list
                    LoadAvailableDrivers(); // Refresh the available drivers list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a car, a driver, and provide the current location and destination.");
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void CustomerDashboardForm_Load_1(object sender, EventArgs e)
        {
            LoadAvailableCars();
            LoadAvailableDrivers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
