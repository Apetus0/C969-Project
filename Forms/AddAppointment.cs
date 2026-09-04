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
            addCustomerComboBox.SelectedIndex = -1;

            addStartDateTimePicker.Format = DateTimePickerFormat.Time;
            addEndDateTimePicker.Format = DateTimePickerFormat.Time;
            
        }

        private int GetCustomerId(object customer)
        {
            Models.Customer cuustomer = (Models.Customer)addCustomerComboBox.SelectedValue;
            return cuustomer.CustomerId;

        }

        private void addSaveButton_Click(object sender, EventArgs e)
        {
            DBManager.AddAppointment(
                GetCustomerId(addCustomerComboBox.SelectedValue),
                DBManager.CurrentUser.UserId,
                addTypeComboBox.Text.ToString(),
                addStartDateTimePicker.Value,
                addEndDateTimePicker.Value,
                DateTime.UtcNow,
                DBManager.CurrentUser.UserName,
                DateTime.UtcNow,
                DBManager.CurrentUser.UserName
                );
            //MessageBox.Show(GetCustomerId(addCustomerComboBox.SelectedValue).ToString());
        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
