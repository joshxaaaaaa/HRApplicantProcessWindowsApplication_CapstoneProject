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

            profilePage.StartPosition = FormStartPosition.CenterScreen;
            profilePage.Show();
            this.Hide();
        }

        private void btnJobVacancies_Click(object sender, EventArgs e)
        {
            JobVacanciesForm vacanciesPage = new JobVacanciesForm();

            vacanciesPage.StartPosition = FormStartPosition.CenterScreen;
            vacanciesPage.Show();

            this.Hide();
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            MyApplicationForm appForm = new MyApplicationForm(currentAccountId);
            appForm.StartPosition = FormStartPosition.CenterScreen;
            appForm.ShowDialog();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            int applicantId = 1; 

            int activeApplicationId = 0;
            string connString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";

            string query = "SELECT application_id FROM Applications WHERE applicant_id = @ApplicantID ORDER BY applied_date DESC LIMIT 1;";

            using (MySqlConnection conn = new MySqlConnection(connString))
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
                ApplicantDocumentsForm docsForm = new ApplicantDocumentsForm();
                docsForm.CurrentApplicationID = activeApplicationId; 
                docsForm.ShowDialog();
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
                ApplicantStatusForm statusForm = new ApplicantStatusForm();
                statusForm.CurrentApplicationID = activeApplicationId;
                statusForm.ShowDialog();
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

        }
    }
}
