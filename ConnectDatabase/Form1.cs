using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConnectDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblIDNumber_Click(object sender, EventArgs e)
        {
            ConnectDB.getMaxID();
            lblIDNumber.Text = Instantiate.recordChecker.MaxID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Connection string targeting your 'personaldb'
            string connectionString = "Server=127.0.0.1;Port=3306;Database=personaldb;Uid=root;Pwd=;";

            // 2. SQL Query to INSERT data and immediately SELECT the new auto-incremented ID
            string query = "INSERT INTO personal_info (First_Name, Middle_Name, Last_Name, BirthDate) " +
                           "VALUES (@FirstName, @MiddleName, @LastName, @BirthDate); " +
                           "SELECT LAST_INSERT_ID();";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // 3. Bind the fields from your form UI to the database parameters
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    command.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim());
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());

                    // Passing the selected date value from your DateTimePicker control
                    command.Parameters.AddWithValue("@BirthDate", dtpBirthDate.Value.Date);

                    try
                    {
                        connection.Open();

                        // 4. ExecuteScalar runs the query and returns the first column of the first row (the ID)
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string newId = result.ToString();

                            // 5. Update your label text with the new ID number
                            // Replace 'lblIDNumber' with the actual design name of your label
                            lblIDNumber.Text = "Employee ID: " + newId;

                            MessageBox.Show($"Employee record added successfully!\nGenerated Employee ID: {newId}",
                                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFormExceptID();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("MySQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("General Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearFormExceptID()
        {
            // Clears textboxes so you are ready for the next entry
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            dtpBirthDate.Value = DateTime.Now; // Resets date picker to today

            // Note: We leave the ID label alone so the user can still read it after saving!
        }

        private void viewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewRecords viewForm = new FormViewRecords();
            viewForm.Show();
            this.Hide();
        }
    }
}
