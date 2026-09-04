using C969_Project.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C969_Project
{
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
            addIdTextBox.ReadOnly = true;
            addCustomerComboBox.DataSource = DBManager.GetCustomers();

        }

        private void addSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
