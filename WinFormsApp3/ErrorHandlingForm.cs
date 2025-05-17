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
    public partial class ErrorHandlingForm : Form
    {
        private string errorMessage;
        public ErrorHandlingForm()
        {
            InitializeComponent();
            lblErrorMessage.Text = errorMessage;
        }

        private void ErrorHandlingForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
