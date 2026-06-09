using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantWindowSystem
{
    public partial class MyApplicationForm : Form
    {

        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql ;";
        private int loggedInAccountId;

        public MyApplicationForm(int accountId)
        {
            InitializeComponent();
            loggedInAccountId = accountId;
        }

        private void MyApplicationForm_Load(object sender, EventArgs e)
        {
            LoadApplicationDraftData();
        }


        private void LoadApplicationDraftData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT job_applied, work_location, application_letter 
                        FROM applicants 
                        WHERE account_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", loggedInAccountId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                if (reader["job_applied"] != DBNull.Value)
                                    textBox1.Text = reader["job_applied"].ToString();

                                if (reader["work_location"] != DBNull.Value)
                                    textBox2.Text = reader["work_location"].ToString();

                                if (reader["application_letter"] != DBNull.Value)
                                    richTextBox1.Text = reader["application_letter"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching historical application inputs: {ex.Message}", "Sync Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- BACK BUTTON: SAVES ACTIVE INPUTS AS A DRAFT AND RETURNS TO DASHBOARD ---
        private void button_Back_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateApplicationInDatabase(isFinalSubmit: false);


                ApplicantDashboardForm dashboard = new ApplicantDashboardForm(loggedInAccountId);
                dashboard.StartPosition = FormStartPosition.CenterScreen;
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Navigation error trying to log data values: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- SAVE/SUBMIT BUTTON: VALIDATES INPUTS AND COMMITS FINAL RECORD ---
        private void button_SaveSubmit_Click(object sender, EventArgs e)
        {
            // Front-end Input Integrity Validation Routines
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the Job Position you are applying for.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please provide your preferred Work Location details.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show("Please complete the Application Letter explanation box.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                richTextBox1.Focus();
                return;
            }

            try
            {

                UpdateApplicationInDatabase(isFinalSubmit: true);

                MessageBox.Show("Your application metrics have been securely submitted to HR Review!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Home Dashboard
                ApplicantDashboardForm dashboard = new ApplicantDashboardForm(loggedInAccountId);
                dashboard.StartPosition = FormStartPosition.CenterScreen;
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database execution pipeline error: {ex.Message}", "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateApplicationInDatabase(bool isFinalSubmit)
        {
            string jobApplied = textBox1.Text.Trim();
            string workLocation = textBox2.Text.Trim();
            string applicationLetter = richTextBox1.Text.Trim();
            string applicationStatus = isFinalSubmit ? "Pending Review" : "Draft";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                //database table: 'applicants'
                string query = @"
                    UPDATE applicants 
                    SET job_applied = @job, 
                        work_location = @location, 
                        application_letter = @letter,
                        application_status = @status
                    WHERE account_id = @accId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@job", jobApplied);
                    cmd.Parameters.AddWithValue("@location", workLocation);
                    cmd.Parameters.AddWithValue("@letter", applicationLetter);
                    cmd.Parameters.AddWithValue("@status", applicationStatus);
                    cmd.Parameters.AddWithValue("@accId", loggedInAccountId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}