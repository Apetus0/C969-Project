using MySqlConnector;
using System.Configuration.Provider;
using System.Data;
using System.Globalization;
using System.IO;
namespace C969_Project
{
    public partial class LoginPage : Form
    {
        bool IsSpanish;
        public LoginPage()
        {
            InitializeComponent();
            this.Text = "Scheduling App";
            this.Select();
            Culture();
            
            //MessageBox.Show($"The current culture is: {culture.TwoLetterISOLanguageName}");
        }

        private void Culture()
        {
            DateTime dateTime = DateTime.Now;
            DateTime utcTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now);
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            CultureInfo culture = CultureInfo.CurrentCulture;
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "es")
            {
                IsSpanish = !IsSpanish;
                UpdateLanguageUI();

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            int maxLength = 50;
            string username = userNameTB.Text.Trim();
            string password = passwordTB.Text.Trim();
            int id;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(GetLocalizedMessage("BlankFields"));
                return;
            }
            if (username.Length > maxLength || password.Length > maxLength)
            {
                MessageBox.Show(GetLocalizedMessage("InputLength"), GetLocalizedMessage("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"SELECT userId, userName FROM user 
                            WHERE userName = @User AND password = @Pass;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBManager.ConnectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", username);
                        cmd.Parameters.AddWithValue("@Pass", password);
                        

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows && reader.Read())
                            {
                                string user = reader.GetString("userName");
                                id = reader.GetInt32("userId");

                                MessageBox.Show(GetLocalizedMessage("SuccessLogin"), GetLocalizedMessage("SuccessMBName"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                                DBManager.CurrentUser = new User(id, username, password);
                                //MessageBox.Show(DBManager.CurrentUser.UserName);

                                this.Hide();
                                MainPage mainPage = new();
                                mainPage.ShowDialog();
                                this.Close();

                               

                                string loginHistory = "Login_History.txt";
                                if(!File.Exists(loginHistory))
                                {
                                    File.WriteAllText(loginHistory, "Login History file.");
                                }
                                File.AppendAllText(loginHistory, $"\nLogin Successful! Username: {username}, Timestamp: {DateTime.UtcNow}");
                            }
                            else
                            {
                                MessageBox.Show(GetLocalizedMessage("InvalidCredentials"), GetLocalizedMessage("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                string loginHistory = "Login_History.txt";
                                if (!File.Exists(loginHistory))
                                {
                                    File.WriteAllText(loginHistory, "Login History file.");
                                }
                                File.AppendAllText(loginHistory, $"\nLogin Unsuccessful! Username: {username}, Timestamp: {DateTime.UtcNow}");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"{GetLocalizedMessage("Error")}: {ex.Message}", GetLocalizedMessage("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            IsSpanish = !IsSpanish;
            UpdateLanguageUI();


        }

        private void UpdateLanguageUI()
        {
            if (IsSpanish)
            {
                appLabel.Text = "Aplicación de Programación";
                appLabel.Location = new Point(259, 124);
                userNameTB.PlaceholderText = "Nombre de Usuario...";
                passwordTB.PlaceholderText = "Contraseña...";
                loginButton.Text = "Acceso";
                exitButton.Text = "Salida";
                spanishButton.Text = "English";
            }
            else
            {
                appLabel.Text = "Scheduling App";
                appLabel.Location = new Point(312, 124);
                userNameTB.PlaceholderText = "Username...";
                passwordTB.PlaceholderText = "Password...";
                loginButton.Text = "Login";
                exitButton.Text = "Exit";
                spanishButton.Text = "Español";
            }
        }

        private string GetLocalizedMessage(string key)
        {
            if (IsSpanish)
            {
                return key switch
                {
                    "InvalidCredentials" => "El nombre de usuario y la contraseña proporcionados no coinciden.",
                    "InputLength" => "Los campos obligatorios no pueden superar los 50 caracteres.",
                    "BlankFields" => "Por favor, introduzca tanto un nombre de usuario como una contraseña.",
                    "SuccessLogin" => "Inicio de sesión exitosa!",
                    "SuccessMBName" => "Éxito",
                    "Error" => "Error",
                    _ => "Error"
                };
            }

            return key switch
            {
                "InvalidCredentials" => "The username and password provided do not match.",
                "InputLength" => "The required fields can not be over 50 characters.",
                "BlankFields" => "Pease enter a username and password.",
                "SuccessLogin" => "Login successful!",
                "SuccessMBName" => "Success",
                "Error" => "Error",
                _ => "Error"
            };

        }
    }

}

