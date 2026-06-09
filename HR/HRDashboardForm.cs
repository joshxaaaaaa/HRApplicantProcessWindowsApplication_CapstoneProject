using System.IO;
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
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
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

        private void LoadDashboardDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string queryApplicants = @"SELECT CONCAT(first_name, ' ', last_name) AS 'Name' 
                                       FROM Applicants 
                                       ORDER BY applicant_id DESC";
                    using (MySqlDataAdapter adapterApp = new MySqlDataAdapter(queryApplicants, conn))
                    {
                        DataTable dtApp = new DataTable();
                        adapterApp.Fill(dtApp);
                        dgvRecentApplicants.DataSource = dtApp;
                    }

                    string queryJobs = @"SELECT job_title AS 'Title' 
                                 FROM JobVacancies 
                                 WHERE status = 'Open' 
                                 ORDER BY posted_date DESC";
                    using (MySqlDataAdapter adapterJobs = new MySqlDataAdapter(queryJobs, conn))
                    {
                        DataTable dtJobs = new DataTable();
                        adapterJobs.Fill(dtJobs);
                        dgvRecentJobs.DataSource = dtJobs;
                    }


                    string queryPending = @"SELECT CONCAT('App #', application_id, ' - ', status) AS 'Details' 
                                    FROM Applications 
                                    WHERE status IN ('Submitted', 'Screening') 
                                    ORDER BY applied_date ASC";
                    using (MySqlDataAdapter adapterPending = new MySqlDataAdapter(queryPending, conn))
                    {
                        DataTable dtPending = new DataTable();
                        adapterPending.Fill(dtPending);
                        dgvPendingActions.DataSource = dtPending;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading grid details: " + ex.Message);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlWelcome.Visible = false;

            pnlDashboardSummary.Visible = true;

            LoadDashboardStatistics();



            LoadDashboardDetails();
            pnlReports.Visible = false;
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {

            if (currentUserRole == "HR Manager")
            {
                AdminSettingsForm adminForm = new AdminSettingsForm();
                adminForm.ShowDialog();
            }

        }

        private void HRDashboardForm_Load(object sender, EventArgs e)
        {

            pnlWelcome.Visible = true;
            pnlDashboardSummary.Visible = false;
            pnlReports.Visible = false;

            LoadDashboardStatistics();
            LoadDashboardDetails();


            if (currentUserRole == "HR Manager")
            {
                btnJobs.Visible = true;
                btnReports.Visible = true;
                btnAdminPanel.Visible = true;
            }
            else
            {

                btnJobs.Visible = false;
                btnReports.Visible = false;
                btnAdminPanel.Visible = false;
            }


        }

        private void txtSearchApplicants_TextChanged(object sender, EventArgs e)
        {

            if (dgvRecentApplicants.DataSource is DataTable dt)
            {

                dt.DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", txtSearchApplicants.Text.Trim());
            }
        }

        private void txtSearchJobs_TextChanged(object sender, EventArgs e)
        {
            if (dgvRecentJobs.DataSource is DataTable dt)
            {

                dt.DefaultView.RowFilter = string.Format("Title LIKE '%{0}%'", txtSearchJobs.Text.Trim());
            }
        }

        private void txtSearchPending_TextChanged(object sender, EventArgs e)
        {
            if (dgvPendingActions.DataSource is DataTable dt)
            {

                dt.DefaultView.RowFilter = string.Format("Details LIKE '%{0}%'", txtSearchPending.Text.Trim());
            }
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedItem == null) return;

            string selectedReport = cmbReportType.SelectedItem.ToString();
            string query = "";


            switch (selectedReport)
            {
                case "Applicant List":
                    query = @"SELECT a.applicant_id AS 'Applicant ID', 
                             CONCAT(a.first_name, ' ', a.last_name) AS 'Full Name', 
                             a.contact_number AS 'Contact', 
                             acc.email AS 'Email'
                      FROM Applicants a
                      INNER JOIN ApplicantAccounts acc ON a.account_id = acc.account_id";
                    break;

                case "Pending Applications":
                    query = @"SELECT app.application_id AS 'App ID', 
                             CONCAT(a.first_name, ' ', a.last_name) AS 'Applicant Name', 
                             jv.job_title AS 'Job Title', 
                             app.status AS 'Current Status', 
                             app.applied_date AS 'Date Applied'
                      FROM Applications app
                      INNER JOIN Applicants a ON app.applicant_id = a.applicant_id
                      INNER JOIN JobVacancies jv ON app.vacancy_id = jv.vacancy_id
                      WHERE app.status IN ('Submitted', 'Screening')";
                    break;

                case "Interview Schedules":
                    query = @"SELECT i.schedule_id AS 'Schedule ID', 
                             CONCAT(a.first_name, ' ', a.last_name) AS 'Applicant', 
                             i.interview_date AS 'Date & Time', 
                             i.location_mode AS 'Location/Mode'
                      FROM InterviewSchedules i
                      INNER JOIN Applications app ON i.application_id = app.application_id
                      INNER JOIN Applicants a ON app.applicant_id = a.applicant_id";
                    break;

                case "Accepted/Rejected Applicants":
                    query = @"SELECT hd.decision_id AS 'Decision ID', 
                             CONCAT(a.first_name, ' ', a.last_name) AS 'Applicant', 
                             hd.final_decision AS 'Decision', 
                             hd.remarks AS 'Remarks', 
                             hd.decision_date AS 'Date'
                      FROM HiringDecisions hd
                      INNER JOIN Applications app ON hd.application_id = app.application_id
                      INNER JOIN Applicants a ON app.applicant_id = a.applicant_id";
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvReportPreview.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generating report: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            if (dgvReportPreview.Rows.Count == 0 || dgvReportPreview.DataSource == null)
            {
                MessageBox.Show("There is no data to export. Please generate a report first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = "HR_Report_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {

                        for (int i = 0; i < dgvReportPreview.Columns.Count; i++)
                        {
                            sw.Write(dgvReportPreview.Columns[i].HeaderText);
                            if (i < dgvReportPreview.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow row in dgvReportPreview.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgvReportPreview.Columns.Count; i++)
                                {
                                    string cellValue = row.Cells[i].Value?.ToString().Replace(",", " ") ?? "";
                                    sw.Write(cellValue);

                                    if (i < dgvReportPreview.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                    }
                    MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting file: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {


            JobOpenings jobsForm = new JobOpenings();


            jobsForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

            pnlWelcome.Visible = false;
            pnlDashboardSummary.Visible = false;


            pnlReports.Visible = true;
            pnlReports.BringToFront();
        }



        private void pnlReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {

            ApplicantProcess applicantForm = new ApplicantProcess();
            applicantForm.ShowDialog();
        }

        private void btnInterviews_Click(object sender, EventArgs e)
        {
            Interviews interviewForm = new Interviews();
            interviewForm.ShowDialog();
        }
    }
}