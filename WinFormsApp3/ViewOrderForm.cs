using CabManagementSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class ViewOrderForm : Form
    {
        private Admin admin;

        public ViewOrderForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void ViewOrderForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            List<Order> orders = admin.ViewOrders();
            DataTable dataTable = new DataTable();

            // Define columns
            dataTable.Columns.Add("OrderId", typeof(int));
            dataTable.Columns.Add("OrderDate", typeof(DateTime));
            dataTable.Columns.Add("CustomerId", typeof(int));
            dataTable.Columns.Add("CustomerName", typeof(string));
            dataTable.Columns.Add("CustomerContact", typeof(string));
            dataTable.Columns.Add("DriverId", typeof(int));
            dataTable.Columns.Add("DriverName", typeof(string));
            dataTable.Columns.Add("DriverContact", typeof(string));
            dataTable.Columns.Add("CurrentLocation", typeof(string));
            dataTable.Columns.Add("Destination", typeof(string));

            // Populate the DataTable
            foreach (var order in orders)
            {
                DataRow row = dataTable.NewRow();
                row["OrderId"] = order.OrderId;
                row["OrderDate"] = order.Date;
                row["CustomerId"] = order.Customer.CustomerId;
                row["CustomerName"] = order.Customer.Name;
                row["CustomerContact"] = order.Customer.ContactNumber;
                row["DriverId"] = order.Driver.DriverId;
                row["DriverName"] = order.Driver.Name;
                row["DriverContact"] = order.Driver.ContactNumber;
                row["CurrentLocation"] = order.CurrentLocation;
                row["Destination"] = order.Destination;
                dataTable.Rows.Add(row);
            }

            dgvOrders.DataSource = dataTable;


        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event here
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm(admin);
            adminDashboardForm.ShowDialog();
            this.Close();
        }
    }
}
