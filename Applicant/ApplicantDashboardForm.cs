using HRApplicantWindowSystem.Applicant;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantWindowSystem
{
    public partial class ApplicantDashboardForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";

        private int currentAccountId;


        public ApplicantDashboardForm(int accountId)
        {
            InitializeComponent();
            currentAccountId = accountId;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ApplicantProfileForm profilePage = new ApplicantProfileForm(currentAccountId);


            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT COUNT(*) FROM Applications a INNER JOIN Applicants ap ON a.applicant_id = ap.applicant_id WHERE ap.account_id = @accId AND a.is_locked = 1";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@accId", currentAccountId);
                        object res = cmd.ExecuteScalar();
                        bool anyLocked = res != null && res != DBNull.Value && Convert.ToInt32(res) > 0;
                        try { profilePage.SetLocked(anyLocked); } catch { }
                    }
                }
            }
            catch { }

            profilePage.StartPosition = FormStartPosition.CenterScreen;

            this.Hide(); 
            profilePage.ShowDialog(); 
            this.Show();
        }

        private void btnJobVacancies_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            JobVacanciesForm vacanciesPage = new JobVacanciesForm(currentAccountId);
            vacanciesPage.StartPosition = FormStartPosition.CenterScreen;
            vacanciesPage.ShowDialog(); 
            this.Show();
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            MyApplicationForm appForm = new MyApplicationForm(currentAccountId);
            appForm.StartPosition = FormStartPosition.CenterScreen;
            appForm.ShowDialog();
            this.Show();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {

            int applicantId = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT applicant_id FROM Applicants WHERE account_id = @AccountID LIMIT 1;", conn))
                {
                    cmd.Parameters.AddWithValue("@AccountID", currentAccountId);
                    try
                    {
                        conn.Open();
                        object res = cmd.ExecuteScalar();
                        if (res != null && res != DBNull.Value) applicantId = Convert.ToInt32(res);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to find applicant record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (applicantId == 0)
            {
                MessageBox.Show("No applicant profile found for this account. Please complete your profile before uploading documents.", "Profile Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int activeApplicationId = 0;
            string query = "SELECT application_id FROM Applications WHERE applicant_id = @ApplicantID ORDER BY applied_date DESC LIMIT 1;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicantID", applicantId);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            activeApplicationId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving application track: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (activeApplicationId > 0)
            {
                this.Hide(); 
                ApplicantDocumentsForm docsForm = new ApplicantDocumentsForm();
                docsForm.CurrentApplicationID = activeApplicationId;
                docsForm.ShowDialog();
                this.Show(); 
            }
            else
            {
                MessageBox.Show("No active job application found for this account. Please submit an application before uploading documents.", "Application Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStatusTracking_Click(object sender, EventArgs e)
        {
            int activeApplicationId = 0;

            string query = @"
                SELECT app.application_id 
                FROM Applications app
                INNER JOIN Applicants a ON app.applicant_id = a.applicant_id
                WHERE a.account_id = @AccountID 
                ORDER BY app.applied_date DESC 
                LIMIT 1;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountID", currentAccountId);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            activeApplicationId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving application track: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (activeApplicationId > 0)
            {
                this.Hide(); 
                ApplicantStatusForm statusForm = new ApplicantStatusForm();
                statusForm.CurrentApplicationID = activeApplicationId;
                statusForm.ShowDialog();
                this.Show(); 
            }
            else
            {
                MessageBox.Show("You haven't submitted any job applications yet. You can track your progress once you have applied.", "No Progress Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplicantDashboardForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Close();

            LoadUserGreeting();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            ApplicantSummaryForm summaryForm = new ApplicantSummaryForm(currentAccountId);
            summaryForm.ShowDialog();
            this.Show();
        }

        private void LoadUserGreeting()
        {
            string query = "SELECT first_name FROM Applicants WHERE account_id = @AccountID LIMIT 1;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountID", currentAccountId);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            string firstName = result.ToString();
                            lblGreeting.Text = $"Welcome, {firstName}!"; 
                        }
                        else
                        {
                            lblGreeting.Text = "Welcome, Applicant!";
                        }
                    }
                    catch (Exception ex)
                    {
                        lblGreeting.Text = "Welcome!";
                        MessageBox.Show("Error loading greeting: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {

        }
    }
}
