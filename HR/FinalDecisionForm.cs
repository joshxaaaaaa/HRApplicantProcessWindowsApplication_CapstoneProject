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
        public FinalDecisionForm()
        {
            InitializeComponent();
        }


        private int finalSelectedAppId = -1;

        private void LoadPendingDecisions()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT ap.application_id AS 'App ID', CONCAT(a.first_name, ' ', a.last_name) AS 'Name', j.job_title AS 'Position'
                           FROM applicants a 
                           INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                           INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id
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

        private void dgvFinalReview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFinalReview.Rows[e.RowIndex];
            finalSelectedAppId = Convert.ToInt32(row.Cells["App ID"].Value);
            txtDecisionName.Text = row.Cells["Name"].Value.ToString();

            cmbFinalDecision.SelectedIndex = -1;
            txtFinalRemarks.Clear();
        }

        private void FinalDecisionForm_Load(object sender, EventArgs e)
        {
            LoadPendingDecisions();
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


                        cmd.Parameters.AddWithValue("@makerId", 1);

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
    }
}
