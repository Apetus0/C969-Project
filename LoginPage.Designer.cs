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
            label1 = new Label();
            label2 = new Label();
            userNameTB = new TextBox();
            Password = new Label();
            passwordTB = new TextBox();
            loginButton = new Button();
            exitButton = new Button();
            spanishButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 124);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Scheduling App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 171);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // userNameTB
            // 
            userNameTB.Location = new Point(369, 168);
            userNameTB.Name = "userNameTB";
            userNameTB.Size = new Size(100, 23);
            userNameTB.TabIndex = 2;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(286, 205);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(369, 202);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(100, 23);
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
            Controls.Add(Password);
            Controls.Add(userNameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userNameTB;
        private Label Password;
        private TextBox passwordTB;
        private Button loginButton;
        private Button exitButton;
        private Button spanishButton;
    }
}
