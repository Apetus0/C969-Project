using C969_Project.Models;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Policy;
using System.Text;


namespace C969_Project.Database
{
    internal class DBManager
    {
       public static Models.User CurrentUser;

       public static readonly string ConnectionString = "Server=localhost;Port=3306;Database=client_schedule;User Id=sqlUser;Password=Passw0rd!;";
       
        internal static List<Appointment> GetAppointments()
        {
            List<Appointment> appointments = new();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM client_schedule.appointment";
                using (MySqlCommand cmd = new(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var appointment = new Appointment(
                            reader.GetInt32("appointmentId"),
                            reader.GetInt32("customerId"),
                            reader.GetInt32("userId"),
                            reader.GetString("title"),

                            // Inline IsDBNull checks:
                            reader.IsDBNull("description") ? string.Empty : reader.GetString("description"),
                            reader.IsDBNull("location") ? string.Empty : reader.GetString("location"),
                            reader.IsDBNull("contact") ? string.Empty : reader.GetString("contact"),

                            reader.GetString("type"),
                            reader.IsDBNull("url") ? string.Empty : reader.GetString("url"),

                            // Dates converted to Local
                            DateTime.SpecifyKind(reader.GetDateTime("start"), DateTimeKind.Utc).ToLocalTime(),
                            DateTime.SpecifyKind(reader.GetDateTime("end"), DateTimeKind.Utc).ToLocalTime(),
                            DateTime.SpecifyKind(reader.GetDateTime("createDate"), DateTimeKind.Utc).ToLocalTime(),

                            reader.IsDBNull("createdBy") ? string.Empty : reader.GetString("createdBy"),
                            DateTime.SpecifyKind(reader.GetDateTime("lastUpdate"), DateTimeKind.Utc).ToLocalTime(),
                            reader.IsDBNull("lastUpdateBy") ? string.Empty : reader.GetString("lastUpdateBy")
                        );

                        appointments.Add(appointment);
                    }
                }
            }

            return appointments;
        }

        internal static List<Customer> GetCustomers()
        {
            List<Customer> customers = new();

            using (MySqlConnection conn = new(ConnectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM client_schedule.customer";
                using (MySqlCommand cmd = new(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var customer = new Customer
                            (
                                reader.GetInt32("customerId"),
                                reader.IsDBNull("customerName") ? string.Empty : reader.GetString("customerName"),
                                reader.GetInt32("addressId"),
                                reader.GetBoolean("active"),
                                DateTime.SpecifyKind(reader.GetDateTime("createDate"), DateTimeKind.Utc).ToLocalTime(),
                                reader.IsDBNull("createdBy") ? string.Empty : reader.GetString("createdBy"),
                                DateTime.SpecifyKind(reader.GetDateTime("lastUpdate"), DateTimeKind.Utc).ToLocalTime(),
                                reader.IsDBNull("lastUpdateBy") ? string.Empty : reader.GetString("lastUpdateBy")
                            );
                        customers.Add(customer);
                    }
                }
            }

                return customers;
        }

        internal static int AddAppointment(int customerId, int userId, string type,
            DateTime start, DateTime end, DateTime createDate, string createdBy,
            DateTime lastUpdate, string lastUpdateBy)
        {
            try
           { 
                using (MySqlConnection conn = new(ConnectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO appointment 
                    (customerId, userId, title, description, location, contact, type, url,
                    start, end, createDate, createdBy, lastUpdate, lastUpdateBy)
                    VALUES 
                        (@customerId, @userId, 'Not Needed', 'Not Needed', 'Not Needed', 
                        'Not Needed', @type, 'Not Needed', @start, @end, @createDate, @createdBy, 
                        @lastUpdate, @lastUpdateBy)";

                    using (MySqlCommand cmd = new(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@start", start);
                        cmd.Parameters.AddWithValue("@end", end);
                        cmd.Parameters.AddWithValue("@createDate", createDate);
                        cmd.Parameters.AddWithValue("@createdBy", createdBy);
                        cmd.Parameters.AddWithValue("@lastUpdate", lastUpdate);
                        cmd.Parameters.AddWithValue("@lastUpdateBy", lastUpdateBy);

                        cmd.ExecuteNonQuery();

                        // Retrieves the auto-incremented ID created by mysql
                        return (int)cmd.LastInsertedId;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Log error or rethrow with custom message for UI layer
                throw new Exception($"Database error saving appointment (Error Code {ex.Number}): {ex.Message}", ex);
            }
        }
    }
}

