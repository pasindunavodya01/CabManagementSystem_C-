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
    public partial class AdminDashboardForm : Form
    {
        private Admin admin;

        public AdminDashboardForm(Admin admin)
        {

            InitializeComponent();
            this.admin = admin;
        }





        private void button3_Click(object sender, EventArgs e)
        {
            CarManagementForm carManagementForm = new CarManagementForm(admin);
            carManagementForm.Show();
            this.Close();
        }





        private void dgvDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminRegisterForm adminRegisterForm = new AdminRegisterForm();
            adminRegisterForm.ShowDialog();
            this.Hide();
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadCars();
            LoadDrivers();

        }
        private void LoadCars()
        {
            List<Car> cars = admin.ViewAvailableCars();
            dgvCars.DataSource = cars;
        }

        private void LoadDrivers()
        {
            List<Driver> drivers = admin.ViewAvailableDrivers();
            dgvDrivers.DataSource = drivers;
        }





        private void button4_Click(object sender, EventArgs e)
        {
            DriverManagementForm driverManagementForm = new DriverManagementForm(admin);
            driverManagementForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewOrderForm viewOrderForm = new ViewOrderForm(admin);
            viewOrderForm.Show();
            this.Close();
        }
    }
}
