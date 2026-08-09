using MySqlConnector;
using System.Configuration.Provider;
using System.Data;
namespace C969_Project
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

            //string connectionString = "Server=localhost;Port=3306;Database=client_schedule;User Id=sqlUser;Password=Passw0rd!;";;

            //string query = "SELECT * FROM country;";

            //try
            //{
            //    using var connection = new MySqlConnection(connectionString);
            //    connection.Open(); // Blocks until connection opens

            //    using var command = new MySqlCommand(query, connection);
            //    using var adapter = new MySqlDataAdapter(command);

            //    DataTable dataTable = new DataTable();
            //    adapter.Fill(dataTable); // Blocks until query finishes executing

            //    dataGridView1.DataSource = dataTable;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}");
            //}

        }
    }
}
