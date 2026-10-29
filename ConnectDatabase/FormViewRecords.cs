using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDatabase
{
    public partial class FormViewRecords : Form
    {
        public FormViewRecords()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormViewRecords_Load(object sender, EventArgs e)
        {
            ConnectDB.displayData(dgvDisplay);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM personal_info WHERE Employee_ID=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", txtSearchID.Text}
            };
            PersonalInfo personalInfo = ConnectDB.searchAndGetPersonalInfo(query, parameters);

            if (personalInfo != null)
            {
                // Display data in the controls
                lblIDNumber.Text = personalInfo.Id.ToString();
                txtFirstName.Text = personalInfo.FirstName;
                txtMiddleName.Text = personalInfo.MiddleName;
                txtLastName.Text = personalInfo.LastName;
                dtpBirthDate.Value = personalInfo.Birthdate.Value;
            }
            else
            {
                MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE personal_info SET " +
                   "First_Name = @firstname, " +
                   "Middle_Name = @middlename, " +
                   "Last_Name = @lastname, " +
                   "BirthDate = @birthdate " +
                   "WHERE Employee_ID = @id";

            Dictionary<string, object> parameters = new Dictionary<string, object>
             {
                     { "@id", lblIDNumber.Text },
                     { "@firstname", txtFirstName.Text.Trim() },
                     { "@middlename", txtMiddleName.Text.Trim() },
                     { "@lastname", txtLastName.Text.Trim() },
                     { "@birthdate", dtpBirthDate.Value.Date },
                     { "@command", "UPDATE" }
            };

            ConnectDB.saveUpdateDeleteData(query, parameters);
            ConnectDB.displayData(dgvDisplay);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM personal_info WHERE Employee_ID=@id";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"@id", lblIDNumber. Text},
                    { "@command", "delete"}
                };
                ConnectDB.saveUpdateDeleteData(query, parameters);
                ConnectDB.displayData(dgvDisplay);
            }
        }

        private void addRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }
    }
}
