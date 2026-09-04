namespace C969_Project
{
    partial class AddAppointment
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
            label1 = new Label();
            label2 = new Label();
            addIdTextBox = new TextBox();
            addStartDateTimePicker = new DateTimePicker();
            addEndDateTimePicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            addSaveButton = new Button();
            addCancelButton = new Button();
            addTypeComboBox = new ComboBox();
            addCustomerComboBox = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Appointment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 82);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // addIdTextBox
            // 
            addIdTextBox.Location = new Point(151, 79);
            addIdTextBox.Name = "addIdTextBox";
            addIdTextBox.Size = new Size(200, 23);
            addIdTextBox.TabIndex = 2;
            // 
            // addStartDateTimePicker
            // 
            addStartDateTimePicker.Location = new Point(151, 195);
            addStartDateTimePicker.Name = "addStartDateTimePicker";
            addStartDateTimePicker.Size = new Size(200, 23);
            addStartDateTimePicker.TabIndex = 4;
            // 
            // addEndDateTimePicker
            // 
            addEndDateTimePicker.Location = new Point(151, 240);
            addEndDateTimePicker.Name = "addEndDateTimePicker";
            addEndDateTimePicker.Size = new Size(200, 23);
            addEndDateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 123);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 201);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "Start Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 246);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "End Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 163);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 10;
            label6.Text = "Type";
            // 
            // addSaveButton
            // 
            addSaveButton.Location = new Point(84, 328);
            addSaveButton.Name = "addSaveButton";
            addSaveButton.Size = new Size(124, 54);
            addSaveButton.TabIndex = 11;
            addSaveButton.Text = "Save";
            addSaveButton.UseVisualStyleBackColor = true;
            addSaveButton.Click += addSaveButton_Click;
            // 
            // addCancelButton
            // 
            addCancelButton.Location = new Point(227, 328);
            addCancelButton.Name = "addCancelButton";
            addCancelButton.Size = new Size(124, 54);
            addCancelButton.TabIndex = 12;
            addCancelButton.Text = "Cancel";
            addCancelButton.UseVisualStyleBackColor = true;
            addCancelButton.Click += addCancelButton_Click;
            // 
            // addTypeComboBox
            // 
            addTypeComboBox.DisplayMember = "Type";
            addTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addTypeComboBox.FormattingEnabled = true;
            addTypeComboBox.Items.AddRange(new object[] { "Consulation", "Interview", "Presentation", "Lunch", "Scrum" });
            addTypeComboBox.Location = new Point(151, 160);
            addTypeComboBox.Name = "addTypeComboBox";
            addTypeComboBox.Size = new Size(200, 23);
            addTypeComboBox.TabIndex = 9;
            // 
            // addCustomerComboBox
            // 
            addCustomerComboBox.DisplayMember = "CustomerName";
            addCustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addCustomerComboBox.FormattingEnabled = true;
            addCustomerComboBox.Location = new Point(151, 120);
            addCustomerComboBox.Name = "addCustomerComboBox";
            addCustomerComboBox.Size = new Size(200, 23);
            addCustomerComboBox.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 295);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 13;
            // 
            // AddAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 450);
            Controls.Add(label7);
            Controls.Add(addCancelButton);
            Controls.Add(addSaveButton);
            Controls.Add(label6);
            Controls.Add(addTypeComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(addEndDateTimePicker);
            Controls.Add(addStartDateTimePicker);
            Controls.Add(addCustomerComboBox);
            Controls.Add(addIdTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddAppointment";
            Text = "AddAppointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox addIdTextBox;
        private DateTimePicker addStartDateTimePicker;
        private DateTimePicker addEndDateTimePicker;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button addSaveButton;
        private Button addCancelButton;
        private ComboBox addTypeComboBox;
        private ComboBox addCustomerComboBox;
        private Label label7;
    }
}