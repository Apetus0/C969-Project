namespace C969_Project
{
    partial class AppointmentPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            currentUserLabel = new Label();
            appointmentDataGridView = new DataGridView();
            addAppointmentButton = new Button();
            updateAppointmentButton = new Button();
            deleteAppointmentButton = new Button();
            searchAppointmentButton = new Button();
            exitButton = new Button();
            endDateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            startDateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)appointmentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // currentUserLabel
            // 
            currentUserLabel.AutoSize = true;
            currentUserLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currentUserLabel.Location = new Point(257, 9);
            currentUserLabel.Name = "currentUserLabel";
            currentUserLabel.Size = new Size(284, 32);
            currentUserLabel.TabIndex = 0;
            currentUserLabel.Text = "Appointments for USER";
            // 
            // appointmentDataGridView
            // 
            appointmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentDataGridView.Location = new Point(27, 67);
            appointmentDataGridView.Name = "appointmentDataGridView";
            appointmentDataGridView.Size = new Size(746, 144);
            appointmentDataGridView.TabIndex = 1;
            appointmentDataGridView.DataBindingComplete += myBindingComplete;
            // 
            // addAppointmentButton
            // 
            addAppointmentButton.Location = new Point(27, 230);
            addAppointmentButton.Name = "addAppointmentButton";
            addAppointmentButton.Size = new Size(111, 23);
            addAppointmentButton.TabIndex = 2;
            addAppointmentButton.Text = "Add";
            addAppointmentButton.UseVisualStyleBackColor = true;
            addAppointmentButton.Click += addAppointmentButton_Click;
            // 
            // updateAppointmentButton
            // 
            updateAppointmentButton.Location = new Point(238, 230);
            updateAppointmentButton.Name = "updateAppointmentButton";
            updateAppointmentButton.Size = new Size(111, 23);
            updateAppointmentButton.TabIndex = 3;
            updateAppointmentButton.Text = "Update";
            updateAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // deleteAppointmentButton
            // 
            deleteAppointmentButton.Location = new Point(449, 230);
            deleteAppointmentButton.Name = "deleteAppointmentButton";
            deleteAppointmentButton.Size = new Size(111, 23);
            deleteAppointmentButton.TabIndex = 4;
            deleteAppointmentButton.Text = "Delete";
            deleteAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // searchAppointmentButton
            // 
            searchAppointmentButton.Location = new Point(660, 230);
            searchAppointmentButton.Name = "searchAppointmentButton";
            searchAppointmentButton.Size = new Size(111, 23);
            searchAppointmentButton.TabIndex = 5;
            searchAppointmentButton.Text = "Search";
            searchAppointmentButton.UseVisualStyleBackColor = true;
            searchAppointmentButton.Click += searchAppointmentButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(660, 415);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(111, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(573, 354);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(200, 23);
            endDateTimePicker.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(573, 336);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 8;
            label1.Text = "End Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 292);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "Start Date";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(573, 310);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(198, 23);
            startDateTimePicker.TabIndex = 9;
            // 
            // AppointmentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(startDateTimePicker);
            Controls.Add(label1);
            Controls.Add(endDateTimePicker);
            Controls.Add(exitButton);
            Controls.Add(searchAppointmentButton);
            Controls.Add(deleteAppointmentButton);
            Controls.Add(updateAppointmentButton);
            Controls.Add(addAppointmentButton);
            Controls.Add(appointmentDataGridView);
            Controls.Add(currentUserLabel);
            Name = "AppointmentPage";
            Text = "ApointmentForm";
            ((System.ComponentModel.ISupportInitialize)appointmentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label currentUserLabel;
        private DataGridView appointmentDataGridView;
        private Button addAppointmentButton;
        private Button updateAppointmentButton;
        private Button deleteAppointmentButton;
        private Button searchAppointmentButton;
        private Button exitButton;
        private DateTimePicker endDateTimePicker;
        private Label label1;
        private Label label2;
        private DateTimePicker startDateTimePicker;
    }
}