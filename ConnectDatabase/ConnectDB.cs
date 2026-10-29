using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDatabase
{
    public class ConnectDB
    {
        public static MySqlConnection GetConnection()
        {

            string sql = "Server=127.0.0.1;Port=3306;Database=personaldb;Uid=root;Pwd=;";

            MySqlConnection conn = new MySqlConnection(sql);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return conn;
        }

        public static void getMaxID()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT MAX(Employee_ID) FROM personal_info", conn);
                    // Execute the command and get the result
                    object result = cmd.ExecuteScalar();

                    // Check if the result is not null and display the maximum personal_ID
                    Instantiate.recordChecker.MaxID = result != DBNull.Value ? Convert.ToInt32(result) + 1 : 2024001;
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                // Handle exceptions related to MySQL
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public static void displayData(DataGridView dataGridView)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM personal_info", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                catch (MySqlException ex) 
                {
                    MessageBox.Show("Error !! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Handle any other exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    conn.Close();
                }
            }
        }

        public static PersonalInfo searchAndGetPersonalInfo(string query, Dictionary<string, object> parameters)
        {
            PersonalInfo personalInfo = null;
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        // Add parameters to the command
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Ensure only one row is retrieved
                            {
                                // Create a new PersonalInfo object and populate its properties
                                personalInfo = new PersonalInfo
                                {
                                    Id = Convert.ToInt32(reader["Employee_ID"]),
                                    FirstName = reader["First_Name"].ToString(),
                                    MiddleName = reader["Middle_Name"].ToString(),
                                    LastName = reader["Last_Name"].ToString(),
                                    Birthdate = reader["BirthDate"] != DBNull.Value ? Convert.ToDateTime(reader["BirthDate"]) : (DateTime?)null
                                };
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error !! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Close the connection
                        conn.Close();
                    }
                }
            }
            return personalInfo;
        }
        public static void saveUpdateDeleteData( string query,Dictionary<string, object> parameters)
        {
            MySqlConnection conn = null;
            bool success = false;

            try
            {
                conn = GetConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    foreach (var param in parameters)
                    {
                        if (param.Key != "@command")
                        {
                            cmd.Parameters.AddWithValue(
                                param.Key,
                                param.Value ?? DBNull.Value
                            );
                        }
                    }

                    success = cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                string key = "@command";

                if (parameters.ContainsKey(key))
                {
                    object value = parameters[key];
                    displayInsertUpdateDelete(value);
                }

                // Close the connection
                conn.Close();
            }
        }


        public static void displayInsertUpdateDelete(object value)
        {
            if (value is string command)
            {
                string message = null;

                if (command.Equals("insert",
                    StringComparison.OrdinalIgnoreCase))
                {
                    message = "Data Inserted!";
                }
                else if (command.Equals("update",
                    StringComparison.OrdinalIgnoreCase))
                {
                    message = "Data Updated!";
                }
                else if (command.Equals("delete",
                    StringComparison.OrdinalIgnoreCase))
                {
                    message = "Data Deleted!";
                }

                if (message != null)
                {
                    MessageBox.Show(
                        message,
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }
    }
}