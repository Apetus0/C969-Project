using MySqlConnector;
using System.Configuration.Provider;
using System.Data;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace C969_Project
{
    public partial class LoginPage : Form
    {
        public readonly string ConnectionString = "Server=localhost;Port=3306;Database=client_schedule;User Id=sqlUser;Password=Passw0rd!;";
        bool LanguageSpanish;
        public LoginPage()
        {
            InitializeComponent();
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
                LanguageSpanish = !LanguageSpanish;
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
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
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

                                MessageBox.Show(GetLocalizedMessage("SuccessLogin"), GetLocalizedMessage("SuccessMBName"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // TODO: Proceed to Main Dashboard Form
                            }
                            else
                            {
                                MessageBox.Show(GetLocalizedMessage("InvalidCredentials"), GetLocalizedMessage("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LanguageSpanish = !LanguageSpanish;
            UpdateLanguageUI();


        }

        private void UpdateLanguageUI()
        {
            if (LanguageSpanish)
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
            if (LanguageSpanish)
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
                "BlankFields" => "The username and password do not match.",
                "SuccessLogin" => "Login successful!",
                "SuccessMBName" => "Success",
                "Error" => "Error",
                _ => "Error"
            };

        }
    }

}

