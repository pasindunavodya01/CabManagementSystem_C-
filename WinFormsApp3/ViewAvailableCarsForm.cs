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
    public partial class ViewAvailableCarsForm : Form
    {
        private Customer customer;
        public ViewAvailableCarsForm()
        {

            InitializeComponent();
            this.customer = customer;
        }

        private void ViewAvailableCarsForm_Load(object sender, EventArgs e)
        {
            List<Car> cars = customer.ViewAvailableCars();
            dgvAvailableCars.DataSource = cars;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
