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
    public partial class HRDashboardForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=#Sheena003;";
        private int currentUserId;
        private string currentUserRole;

        public HRDashboardForm(int userId, string role)
        {
            InitializeComponent();
            currentUserId = userId;
            currentUserRole = role;
        }

        private void LoadDashboardStatistics()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string queryApplicants = "SELECT COUNT(*) FROM Applicants";
                    using (MySqlCommand cmd = new MySqlCommand(queryApplicants, conn))
                    {
                        lblTotalApplicants.Text = cmd.ExecuteScalar().ToString();
                    }


                    string queryJobs = "SELECT COUNT(*) FROM JobVacancies WHERE status = 'Open'";
                    using (MySqlCommand cmd = new MySqlCommand(queryJobs, conn))
                    {
                        lblOpenJobs.Text = cmd.ExecuteScalar().ToString();
                    }


                    string queryPending = "SELECT COUNT(*) FROM Applications WHERE status IN ('Submitted', 'Screening')";
                    using (MySqlCommand cmd = new MySqlCommand(queryPending, conn))
                    {
                        lblPendingApplications.Text = cmd.ExecuteScalar().ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dashboard data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            lblWelcome.Text = $"Welcome, {currentUserRole}!";


            LoadDashboardStatistics();


            btnAdminPanel.Visible = true;
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {

            if (currentUserRole == "HR Manager")
            {
                AdminSettingsForm adminForm = new AdminSettingsForm();
                adminForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Access Denied: This feature is restricted to HR Managers and Administrators only.",
                                "Restricted Area",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
            }
        }
    }
}