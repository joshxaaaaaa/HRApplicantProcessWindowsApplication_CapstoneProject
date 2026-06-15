using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FinalDecisionForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        private int currentUserId;
        public FinalDecisionForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }


        private int finalSelectedAppId = -1;
        

        private void dgvFinalReview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFinalReview.Rows[e.RowIndex];
                finalSelectedAppId = Convert.ToInt32(row.Cells["App ID"].Value);
                txtDecisionName.Text = row.Cells["Name"].Value.ToString(); 

            }
        }

        private void LoadOfferedApplicants()
        {



            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string sql = @"SELECT ap.application_id AS 'App ID', 
                                    CONCAT(a.first_name, ' ', a.last_name) AS 'Name', 
                                    p.position_name AS 'Position'
                            FROM applicants a 
                            INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                            INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id
                            INNER JOIN positions p ON j.position_id = p.position_id -- Added this line!
                            WHERE ap.status = 'Offered'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    dgvFinalReview.DataSource = dt;

                    dgvFinalReview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading offered applicants: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadPendingDecisions()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT ap.application_id AS 'App ID', 
                                CONCAT(a.first_name, ' ', a.last_name) AS 'Name', 
                                p.position_name AS 'Position'
                        FROM applicants a 
                        INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                        INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id
                        INNER JOIN positions p ON j.position_id = p.position_id -- Added this line!
                        WHERE ap.status = 'Interviewing'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvFinalReview.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }



        private void FinalDecisionForm_Load(object sender, EventArgs e)
        {
            LoadOfferedApplicants();
        }

        private void btnSubmitDecision_Click(object sender, EventArgs e)
        {
            if (finalSelectedAppId == -1 || cmbFinalDecision.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an applicant and a final decision.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sqlInsert = @"INSERT INTO hiringdecisions 
                                 (application_id, decision_maker_id, final_decision, remarks, decision_date) 
                                 VALUES (@appId, @makerId, @decision, @remarks, @date)";

                    using (MySqlCommand cmd = new MySqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@appId", finalSelectedAppId);


                        cmd.Parameters.AddWithValue("@makerId", currentUserId); 

                        cmd.Parameters.AddWithValue("@decision", cmbFinalDecision.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@remarks", txtFinalRemarks.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }


                    string newStatus = cmbFinalDecision.SelectedItem.ToString();
                    string sqlUpdate = "UPDATE applications SET status = @status WHERE application_id = @appId";

                    using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@status", newStatus);
                        cmdUpdate.Parameters.AddWithValue("@appId", finalSelectedAppId);
                        cmdUpdate.ExecuteNonQuery();
                    }
                    LogAuditAction(currentUserId, "Final Hiring Decision", "hiringdecisions", finalSelectedAppId, $"Applicant marked as {newStatus}. Remarks: {txtFinalRemarks.Text.Trim()}");
                    MessageBox.Show($"Final decision saved! Applicant has been {newStatus}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtDecisionName.Clear();
                    txtFinalRemarks.Clear();
                    cmbFinalDecision.SelectedIndex = -1;
                    finalSelectedAppId = -1;
                    LoadPendingDecisions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving final decision: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LogAuditAction(int userId, string actionType, string tableAffected, int recordId, string details)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = @"INSERT INTO audittrail 
                           (user_id, action_type, table_affected, record_id, details, action_timestamp) 
                           VALUES (@userId, @actionType, @tableAffected, @recordId, @details, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@actionType", actionType);
                        cmd.Parameters.AddWithValue("@tableAffected", tableAffected);
                        cmd.Parameters.AddWithValue("@recordId", recordId);
                        cmd.Parameters.AddWithValue("@details", details);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Audit Log Error: " + ex.Message);
                }
            }
        }

    }
}
