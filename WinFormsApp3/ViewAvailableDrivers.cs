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
    public partial class ViewAvailableDrivers : Form
    {
        private Customer customer;
        public ViewAvailableDrivers()
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void ViewAvailableDrivers_Load(object sender, EventArgs e)
        {
            List<Driver> drivers = customer.ViewAvailableDrivers();
            dgvAvailableDrivers.DataSource = drivers;
        }

        private void dgvAvailableDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
