using C969_Project.Database;
using C969_Project.Models;
using C969_Project.Services;
using MySqlConnector;
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
            try
            {
                //  Input Parsing Validation
                if (addCustomerComboBox.SelectedValue is null)
                {
                    MessageBox.Show("Please select a valid customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (addTypeComboBox.Text is null)
                {
                    MessageBox.Show("Appointment type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime startLocal = addStartDateTimePicker.Value;
                DateTime endLocal = addEndDateTimePicker.Value;
                int customerId = GetCustomerId(addCustomerComboBox.SelectedValue);

                //  Business Logic Validation
                if (!ScheduleValidationServices.AreBothWithinBusinessHours(startLocal, endLocal))
                {
                    MessageBox.Show("Appointments must take place between 9:00 AM and 5:00 PM EST on weekdays.", "Business Hours Violation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Appointment> existingAppointments = DBManager.GetAppointments();

                // Pass 'null' for currentAppointmentId because this is a new record
                if (ScheduleValidationServices.HasOverlap(startLocal, endLocal, existingAppointments, currentAppointmentId: null))
                {
                    MessageBox.Show("The selected time slot overlaps with an existing appointment.", "Schedule Overlap Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //  Database Operations
                int newId = DBManager.AddAppointment(
                    customerId: customerId,
                    userId: DBManager.CurrentUser.UserId,
                    type: addTypeComboBox.Text.ToString(),
                    start: startLocal.ToUniversalTime(),
                    end: endLocal.ToUniversalTime(),
                    createDate: DateTime.UtcNow,
                    createdBy: DBManager.CurrentUser.UserName,
                    lastUpdate: DateTime.UtcNow,
                    lastUpdateBy: DBManager.CurrentUser.UserName
                );

                MessageBox.Show("Appointment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Unable to connect to MySQL database.\nDetails: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid input format: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while saving:\n{ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
