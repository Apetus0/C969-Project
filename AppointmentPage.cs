using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C969_Project
{
    public partial class AppointmentPage : Form
    {
        public AppointmentPage()
        {
            InitializeComponent();
            // Set user label
            currentUserLabel.Text = $"Appointments for {DBManager.CurrentUser.UserName}";
            currentUserLabel.Left = (this.ClientSize.Width - currentUserLabel.Width) / 2;

            appointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentDataGridView.DataSource = DBManager.GetAppointments();

            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";


        }

        //removes auto selection of first row
        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            appointmentDataGridView.ClearSelection();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new();
            mainPage.ShowDialog();
            this.Close();
        }

        private void searchAppointmentButton_Click(object sender, EventArgs e)
        {
            appointmentDataGridView.DataSource = DBManager.GetAppointments().Where(app => app.Start >= startDateTimePicker.Value && app.End <= endDateTimePicker.Value).ToList();
            //var results = from app in DBManager.GetAppointments()
            //              where app.Start >= startDateTimePicker.Value && app.End <= endDateTimePicker.Value


            appointmentDataGridView.Refresh();
        }
    }
}
