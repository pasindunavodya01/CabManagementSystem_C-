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
    public partial class CarManagementForm : Form
    {
        private Admin admin;
        public CarManagementForm(Admin admin)
        {

            InitializeComponent();
            this.admin = admin;
        }

        private void CarManagementForm_Load(object sender, EventArgs e)
        {
            LoadCars();
        }




        private void LoadCars()
        {
            List<Car> cars = admin.GetAllCars(); // Use the new method to get all cars
            dgvCars.DataSource = cars;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Car newCar = new Car(0, txtModel.Text, txtPlateNumber.Text, true);
            admin.AddCar(newCar);
            MessageBox.Show("Car added successfully.");
            LoadCars();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                int carId = Convert.ToInt32(txtCarId.Text);
                admin.RemoveCar(carId);
                MessageBox.Show("Car removed successfully.");
                LoadCars();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void CarManagementForm_Load_1(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int carId = Convert.ToInt32(txtCarId.Text);
            bool availability = admin.CheckCarAvailability(carId);
            MessageBox.Show($"Car availability: {(availability ? "Available" : "Not Available")}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int carId = Convert.ToInt32(txtCarId.Text);
            bool availability = admin.ToggleCarAvailability(carId);
            MessageBox.Show($"Car availability toggled to {(availability ? "Available" : "Not Available")}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int carId = Convert.ToInt32(txtCarId.Text);
            bool availability = admin.GetCarAvailability(carId); // Get the current availability status
            admin.UpdateCarAvailability(carId, availability); // Save the current availability status
            MessageBox.Show("Changes saved successfully.");
            LoadCars();
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm(admin);
            adminDashboardForm.ShowDialog();
            this.Close();
        }
    }
}
