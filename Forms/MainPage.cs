using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C969_Project
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentPage appointmentPage = new();
            appointmentPage.ShowDialog();
            this.Close();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPage customerPage = new();
            customerPage.ShowDialog();
            this.Close();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportPage reportPage = new();
            reportPage.ShowDialog();
            this.Close();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
