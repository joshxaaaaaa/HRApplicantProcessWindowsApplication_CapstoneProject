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
    public partial class ApplicantStatusForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentApplicationID { get; set; } = 0;

        public ApplicantStatusForm()
        {
            InitializeComponent();
        }

        

        private void ApplicantStatusForm_Load(object sender, EventArgs e)
        {
            LoadApplicantProgress();
        }

        private void LoadApplicantProgress()
        {
            string query = @"
                        SELECT 
                            a.status AS MainStatus,
                            p.position_name AS JobTitle, 
                            COALESCE(sr.remarks, 'No screening remarks available yet.') AS ScreeningRemarks,
                            COALESCE(CAST(isch.interview_date AS CHAR), 'Not yet scheduled') AS InterviewDate, 
                            COALESCE(isch.location, 'TBD') AS InterviewLocation,
                            COALESCE(ie.recommendation, 'No recommendation.') AS InterviewRecommendation,
                            COALESCE(ie.remarks, 'No remarks.') AS InterviewRemarks,
                            COALESCE(hd.final_decision, 'Pending') AS FinalDecision,
                            COALESCE(hd.remarks, 'Final evaluation pending.') AS FinalRemarks,  
                            COALESCE(ie.pass_fail, 'Pending') AS InterviewStatus
                            FROM Applications a
                        INNER JOIN JobVacancies j ON a.vacancy_id = j.vacancy_id
                        INNER JOIN positions p ON j.position_id = p.position_id 
                        LEFT JOIN ScreeningResults sr ON a.application_id = sr.application_id
                        LEFT JOIN InterviewSchedules isch ON a.application_id = isch.application_id
                        LEFT JOIN HiringDecisions hd ON a.application_id = hd.application_id
                        LEFT JOIN interviewevaluations ie ON a.application_id = ie.application_id
                        WHERE a.application_id = @ApplicationID
                        ORDER BY sr.screened_at DESC, isch.interview_date DESC
                        LIMIT 1;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicationID", CurrentApplicationID);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblJobTitle.Text = $"Applying For: {reader["JobTitle"]}";
                                lblCurrentStage.Text = $"Current Pipeline Stage: {reader["MainStatus"]}";
                                txtHRRemarks.Text = $"[Screening Remarks]\r\n{reader["ScreeningRemarks"]}\r\n\r\n" +
                                                    $"[Interview Recommendation]\r\n{reader["InterviewRecommendation"]}\r\n\r\n" +
                                                    $"[Interview Remarks]\r\n{reader["InterviewRemarks"]}\r\n\r\n" +
                                                    $"[Final Decision Remarks]\r\n{reader["FinalRemarks"]}\r\n\r\n";
                                string interviewStatus = reader["InterviewStatus"].ToString();


                                if (interviewStatus == "Pass" || interviewStatus == "Passed")
                                {
                                    lblInterviewSchedule.Text = "Interview Schedule: Interview Passed";
                                }
                                else
                                {

                                    lblInterviewSchedule.Text = $"Interview Schedule: {reader["InterviewDate"]} ({reader["InterviewLocation"]})";
                                }

                                lblFinalResult.Text = $"Final Decision: {reader["FinalDecision"]}";

                                StyleStatusLabel(reader["MainStatus"].ToString(), reader["FinalDecision"].ToString());
                            }
                            else
                            {
                                MessageBox.Show("No application records found for the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to pull timeline data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void StyleStatusLabel(string mainStatus, string finalDecision)
        {
            if (finalDecision == "Hired" || mainStatus == "Offered" || mainStatus == "Hired")
            {
                lblFinalResult.ForeColor = Color.Green;
            }
            else if (finalDecision == "Rejected" || mainStatus == "Rejected")
            {
                lblFinalResult.ForeColor = Color.Red;
            }
            else
            {
                lblFinalResult.ForeColor = Color.DarkOrange;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadApplicantProgress();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
