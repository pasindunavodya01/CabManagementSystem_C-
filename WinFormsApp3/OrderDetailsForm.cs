using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CabManagementSystem;

namespace WinFormsApp3
{
    public partial class OrderDetailsForm : Form
    {
        private Order order;
        public OrderDetailsForm()
        {
            InitializeComponent();
            LoadOrderDetails(order);
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadOrderDetails(Order order)
        {
            txtOrderId.Text = order.OrderId.ToString();
            txtCustomerName.Text = order.Customer.Name;
            txtCustomerContact.Text = order.Customer.ContactNumber;
            txtDriverName.Text = order.Driver.Name;
            txtDriverContact.Text = order.Driver.ContactNumber;
            txtOrderDate.Text = order.Date.ToString();
            txtCurrentLocation.Text = order.CurrentLocation;
            txtDestination.Text = order.Destination;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
