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
    public partial class Interviews : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        public Interviews()
        {
            InitializeComponent();
        }

        private void Interviews_Load(object sender, EventArgs e)
        {
            LoadPendingApplicants();

        }

        private void LoadPendingApplicants()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT a.applicant_id AS 'ID', 
                                  CONCAT(a.first_name, ' ', a.last_name) AS 'Name', 
                                  j.job_title AS 'Position'
                           FROM applicants a 
                           INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                           INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id
                           WHERE ap.status IN ('Pending', 'Under Review')";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPendingApplicants.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading pending applicants: " + ex.Message);
                }
            }
        }


        private void dgvPendingApplicants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPendingApplicants.Rows[e.RowIndex];

 
                txtAppID.Text = row.Cells["ID"].Value.ToString();
                txtAppName.Text = row.Cells["Name"].Value.ToString();
                txtAppPos.Text = row.Cells["Position"].Value.ToString();


                txtRemarks.Clear();


                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string docSql = "SELECT document_name AS 'Document', file_path AS 'File' FROM applicantdocuments WHERE applicant_id = @id";
                    MySqlDataAdapter docAdapter = new MySqlDataAdapter(docSql, conn);
                    docAdapter.SelectCommand.Parameters.AddWithValue("@id", txtAppID.Text);
                    DataTable docDt = new DataTable();
                    docAdapter.Fill(docDt);
                    dgvDocs.DataSource = docDt;
                }
            }
        }
        private void SaveScreeningDecision(string decisionStatus)
        {
            if (string.IsNullOrWhiteSpace(txtAppID.Text))
            {
                MessageBox.Show("Please select an applicant from the list first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRemarks.Text))
            {
                MessageBox.Show("Please enter screening remarks before submitting.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string updateStatusSql = "UPDATE applications SET status = @status WHERE applicant_id = @id";
                    using (MySqlCommand cmdStatus = new MySqlCommand(updateStatusSql, conn))
                    {
                        cmdStatus.Parameters.AddWithValue("@status", decisionStatus == "Qualified" ? "Shortlisted" : "Rejected");
                        cmdStatus.Parameters.AddWithValue("@id", txtAppID.Text);
                        cmdStatus.ExecuteNonQuery();
                    }


                    string insertRemarksSql = @"INSERT INTO screeningresults (application_id, remarks, result) 
                                        VALUES ((SELECT application_id FROM applications WHERE applicant_id = @id LIMIT 1), @remarks, @result)";
                    using (MySqlCommand cmdRemarks = new MySqlCommand(insertRemarksSql, conn))
                    {
                        cmdRemarks.Parameters.AddWithValue("@id", txtAppID.Text);
                        cmdRemarks.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());
                        cmdRemarks.Parameters.AddWithValue("@result", decisionStatus);
                        cmdRemarks.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Applicant successfully marked as {decisionStatus}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtAppID.Clear();
                    txtAppName.Clear();
                    txtAppPos.Clear();
                    txtRemarks.Clear();
                    dgvDocs.DataSource = null;
                    LoadPendingApplicants();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving decision: " + ex.Message);
                }
            }
        }

        private void btnQualified_Click(object sender, EventArgs e)
        {
            SaveScreeningDecision("Qualified");
        }

        private void btnNotQualified_Click(object sender, EventArgs e)
        {
            SaveScreeningDecision("Not Qualified");
        }

        private void btnScreening_Click(object sender, EventArgs e)
        {
            pnlScheduling.Visible = false;
            pnlScreening.Visible = true;

            LoadPendingApplicants();
        }

        private void btnInterviewScheduling_Click(object sender, EventArgs e)
        {
            pnlScreening.Visible = false;
            pnlScheduling.Visible = true;

            LoadSchedulingData();
        }
      
        private int schedSelectedApplicationId = -1;

        private void LoadSchedulingData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

          
                    string sqlApps = @"SELECT ap.application_id AS 'App ID', CONCAT(a.first_name, ' ', a.last_name) AS 'Name', j.job_title AS 'Position'
                               FROM applicants a 
                               INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                               INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id
                               WHERE ap.status = 'Shortlisted'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlApps, conn);
                    DataTable dtApps = new DataTable();
                    adapter.Fill(dtApps);
                    dgvShortlisted.DataSource = dtApps;

         
                    string sqlUsers = "SELECT user_id, username FROM users WHERE role IN ('HR Manager', 'Admin')";
                    MySqlDataAdapter userAdapter = new MySqlDataAdapter(sqlUsers, conn);
                    DataTable dtUsers = new DataTable();
                    userAdapter.Fill(dtUsers);
                    cmbInterviewer.DataSource = dtUsers;
                    cmbInterviewer.DisplayMember = "username";
                    cmbInterviewer.ValueMember = "user_id";

            
                    string sqlTypes = "SELECT interview_type_id, interview_name FROM interview_types";
                    MySqlDataAdapter typeAdapter = new MySqlDataAdapter(sqlTypes, conn);
                    DataTable dtTypes = new DataTable();
                    typeAdapter.Fill(dtTypes);
                    cmbInterviewType.DataSource = dtTypes;
                    cmbInterviewType.DisplayMember = "interview_name";
                    cmbInterviewType.ValueMember = "interview_type_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading scheduling data: " + ex.Message);
                }
            }
        }


        private void dgvShortlisted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvShortlisted.Rows[e.RowIndex];
                schedSelectedApplicationId = Convert.ToInt32(row.Cells["App ID"].Value);
                txtSchedName.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            if (schedSelectedApplicationId == -1)
            {
                MessageBox.Show("Please select a shortlisted applicant to schedule.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string sqlInsert = @"INSERT INTO interviewschedules 
                                 (application_id, interview_date, interview_time, interviewer_id, interview_type_id, location, status) 
                                 VALUES (@appId, @date, @time, @interviewer, @type, @location, 'Scheduled')";

                    using (MySqlCommand cmd = new MySqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@appId", schedSelectedApplicationId);
                        cmd.Parameters.AddWithValue("@date", dtpSchedDate.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@time", dtpSchedTime.Value.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@interviewer", cmbInterviewer.SelectedValue);
                        cmd.Parameters.AddWithValue("@type", cmbInterviewType.SelectedValue);
                        cmd.Parameters.AddWithValue("@location", txtLocation.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }


                    string sqlUpdate = "UPDATE applications SET status = 'Interviewing' WHERE application_id = @appId";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@appId", schedSelectedApplicationId);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Interview scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSchedName.Clear();
                    txtLocation.Clear();
                    schedSelectedApplicationId = -1;
                    LoadSchedulingData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving schedule: " + ex.Message);
                }
            }
        }
    }
}
