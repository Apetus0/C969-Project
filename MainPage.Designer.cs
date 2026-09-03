namespace C969_Project
{
    partial class MainPage
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
            appointmentButton = new Button();
            customersButton = new Button();
            reportsButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // appointmentButton
            // 
            appointmentButton.Location = new Point(315, 76);
            appointmentButton.Name = "appointmentButton";
            appointmentButton.Size = new Size(171, 52);
            appointmentButton.TabIndex = 0;
            appointmentButton.Text = "Appointments";
            appointmentButton.UseVisualStyleBackColor = true;
            appointmentButton.Click += appointmentButton_Click;
            // 
            // customersButton
            // 
            customersButton.Location = new Point(315, 158);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(171, 52);
            customersButton.TabIndex = 1;
            customersButton.Text = "Customers";
            customersButton.UseVisualStyleBackColor = true;
            customersButton.Click += customersButton_Click;
            // 
            // reportsButton
            // 
            reportsButton.Location = new Point(315, 240);
            reportsButton.Name = "reportsButton";
            reportsButton.Size = new Size(171, 52);
            reportsButton.TabIndex = 2;
            reportsButton.Text = "Reports";
            reportsButton.UseVisualStyleBackColor = true;
            reportsButton.Click += reportsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(315, 322);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(171, 52);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(reportsButton);
            Controls.Add(customersButton);
            Controls.Add(appointmentButton);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
        }

        #endregion

        private Button appointmentButton;
        private Button customersButton;
        private Button reportsButton;
        private Button exitButton;
    }
}