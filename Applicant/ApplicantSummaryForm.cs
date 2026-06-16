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
    public partial class ApplicantSummaryForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        private int loggedInAccountId;
        public ApplicantSummaryForm(int accountId)
        {
            InitializeComponent();
            loggedInAccountId = accountId;
        }

        private void ApplicantSummaryForm_Load(object sender, EventArgs e)
        {
            LoadDashboardSummary();
        }
        private void LoadDashboardSummary()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    int activeAppId = 0;
                    string getAppSql = @"
                        SELECT application_id, status 
                        FROM Applications a
                        INNER JOIN Applicants app ON a.applicant_id = app.applicant_id
                        WHERE app.account_id = @accId 
                        ORDER BY applied_date DESC LIMIT 1";

                    using (MySqlCommand cmdApp = new MySqlCommand(getAppSql, conn))
                    {
                        cmdApp.Parameters.AddWithValue("@accId", loggedInAccountId);
                        using (MySqlDataReader reader = cmdApp.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                activeAppId = Convert.ToInt32(reader["application_id"]);
                                lblCurrentStatus.Text = $"Current Status: {reader["status"]}";
                            }
                            else
                            {
                                lblCurrentStatus.Text = "Current Status: No Active Application";
                                lblInterviewDetails.Text = "Not scheduled.";
                                return;
                            }
                        }
                    }


                    string docsSql = @"
                        SELECT rt.requirement_name AS 'Missing Documents'
                        FROM RequirementTypes rt
                        LEFT JOIN ApplicantDocuments ad 
                            ON rt.requirement_type_id = ad.requirement_type_id AND ad.application_id = @appId
                        WHERE ad.file_path IS NULL OR ad.file_path = ''";

                    using (MySqlDataAdapter daDocs = new MySqlDataAdapter(docsSql, conn))
                    {
                        daDocs.SelectCommand.Parameters.AddWithValue("@appId", activeAppId);
                        DataTable dtDocs = new DataTable();
                        daDocs.Fill(dtDocs);
                        dgvMissingDocs.DataSource = dtDocs;
                        dgvMissingDocs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }


                    string intSql = @"
                        SELECT interview_date, interview_time, location 
                        FROM interviewschedules 
                        WHERE application_id = @appId 
                        ORDER BY interview_date DESC LIMIT 1";

                    using (MySqlCommand cmdInt = new MySqlCommand(intSql, conn))
                    {
                        cmdInt.Parameters.AddWithValue("@appId", activeAppId);
                        using (MySqlDataReader reader = cmdInt.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                DateTime iDate = Convert.ToDateTime(reader["interview_date"]);
                                string iTime = reader["interview_time"].ToString();
                                string iLoc = reader["location"].ToString();

                                lblInterviewDetails.Text = $"Interview: {iDate.ToShortDateString()} at {iTime} ({iLoc})";
                            }
                            else
                            {
                                lblInterviewDetails.Text = "Interview: Not yet scheduled.";
                            }
                        }
                    }


                    string histSql = @"
                        SELECT old_status AS 'Previous', new_status AS 'New Update', changed_at AS 'Date/Time'
                        FROM applicationstatushistory 
                        WHERE application_id = @appId 
                        ORDER BY changed_at DESC";

                    using (MySqlDataAdapter daHist = new MySqlDataAdapter(histSql, conn))
                    {
                        daHist.SelectCommand.Parameters.AddWithValue("@appId", activeAppId);
                        DataTable dtHist = new DataTable();
                        daHist.Fill(dtHist);
                        dgvRecentUpdates.DataSource = dtHist;
                        dgvRecentUpdates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCurrentStatus_Click(object sender, EventArgs e)
        {

        }

        private void dgvRecentUpdates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblInterviewDetails_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
