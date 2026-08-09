using MySqlConnector;
using System.Configuration.Provider;
using System.Data;
namespace C969_Project
{
    public partial class LoginPage : Form
    {
        public readonly string ConnectionString = "Server=localhost;Port=3306;Database=client_schedule;User Id=sqlUser;Password=Passw0rd!;";
        public LoginPage()
        {
            InitializeComponent();

        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Fix 1: Use .Text instead of .ToString()
            string username = userNameTB.Text.Trim();
            string password = passwordTB.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both a username and password.");
                return;
            }

            string query = @"SELECT userId, userName FROM user 
                            WHERE userName = @User AND password = @Pass;";

            // Fix 2: Create and open connection locally inside using block
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
                                int userId = reader.GetInt32("userId");
                                string user = reader.GetString("userName");

                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // TODO: Proceed to Main Dashboard Form
                            }
                            else
                            {
                                MessageBox.Show("The username and password do not match.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    
}

