namespace C969_Project
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            appLabel = new Label();
            userNameTB = new TextBox();
            passwordTB = new TextBox();
            loginButton = new Button();
            exitButton = new Button();
            spanishButton = new Button();
            SuspendLayout();
            // 
            // appLabel
            // 
            appLabel.AutoSize = true;
            appLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appLabel.Location = new Point(312, 124);
            appLabel.Name = "appLabel";
            appLabel.Size = new Size(145, 25);
            appLabel.TabIndex = 0;
            appLabel.Text = "Scheduling App";
            // 
            // userNameTB
            // 
            userNameTB.Location = new Point(312, 161);
            userNameTB.Name = "userNameTB";
            userNameTB.PlaceholderText = "Username...";
            userNameTB.Size = new Size(145, 23);
            userNameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(312, 190);
            passwordTB.Name = "passwordTB";
            passwordTB.PlaceholderText = "Password...";
            passwordTB.Size = new Size(145, 23);
            passwordTB.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(271, 294);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(415, 294);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // spanishButton
            // 
            spanishButton.Location = new Point(12, 415);
            spanishButton.Name = "spanishButton";
            spanishButton.Size = new Size(75, 23);
            spanishButton.TabIndex = 7;
            spanishButton.Text = "Español";
            spanishButton.UseVisualStyleBackColor = true;
            spanishButton.Click += spanishButton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(spanishButton);
            Controls.Add(exitButton);
            Controls.Add(loginButton);
            Controls.Add(passwordTB);
            Controls.Add(userNameTB);
            Controls.Add(appLabel);
            Name = "LoginPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appLabel;
        private TextBox userNameTB;
        private TextBox passwordTB;
        private Button loginButton;
        private Button exitButton;
        private Button spanishButton;
    }
}
