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
        private int currentUserId;
        public Interviews(int userId)
        {
            InitializeComponent();
            currentUserId = userId;

        }
        private int screeningSelectedAppId = -1;

        private void Interviews_Load(object sender, EventArgs e)
        {

            pnlScreening.Visible = true;
            pnlScheduling.Visible = false;
            pnlEvaluation.Visible = false;

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
                                    p.position_name AS 'Position'
                            FROM applicants a 
                            INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                            INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id
                            INNER JOIN positions p ON j.position_id = p.position_id
                            WHERE ap.status = 'Screening'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPendingApplicants.DataSource = dt;


                    dgvPendingApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                    string appLookup = "SELECT application_id FROM applications WHERE applicant_id = @id ORDER BY applied_date DESC LIMIT 1";
                    screeningSelectedAppId = 0; 

                    using (MySqlCommand appCmd = new MySqlCommand(appLookup, conn))
                    {
                        appCmd.Parameters.AddWithValue("@id", txtAppID.Text);
                        object resApp = appCmd.ExecuteScalar();
                        if (resApp != null && resApp != DBNull.Value)
                        {
                            screeningSelectedAppId = Convert.ToInt32(resApp);
                        }
                    }

                    if (screeningSelectedAppId == 0)
                    {
                        dgvDocs.DataSource = null;
                    }
                    else
                    {

             
                        string docSql = @"SELECT rt.requirement_name AS 'Document', ad.file_path AS 'File' 
                                          FROM RequirementTypes rt 
                                          LEFT JOIN ApplicantDocuments ad ON rt.requirement_type_id = ad.requirement_type_id AND ad.application_id = @appId";
                        MySqlDataAdapter docAdapter = new MySqlDataAdapter(docSql, conn);
                        docAdapter.SelectCommand.Parameters.AddWithValue("@appId", screeningSelectedAppId); 
                        DataTable docDt = new DataTable();
                        docAdapter.Fill(docDt);
                        dgvDocs.DataSource = docDt;
                    }
                }
            }
        }
        private void SaveScreeningDecision(string decisionStatus)
        {
            if (screeningSelectedAppId <= 0)
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

                    string newStatus = decisionStatus == "Qualified" ? "Shortlisted" : "Rejected";

      
                    string updateStatusSql = "UPDATE applications SET status = @status WHERE application_id = @appId";
                    using (MySqlCommand cmdStatus = new MySqlCommand(updateStatusSql, conn))
                    {
                        cmdStatus.Parameters.AddWithValue("@status", newStatus);
                        cmdStatus.Parameters.AddWithValue("@appId", screeningSelectedAppId);
                        cmdStatus.ExecuteNonQuery();
                    }

       
                    string historySql = "INSERT INTO applicationstatushistory (application_id, old_status, new_status) VALUES (@appId, 'Screening', @newStatus)";
                    using (MySqlCommand cmdHist = new MySqlCommand(historySql, conn))
                    {
                        cmdHist.Parameters.AddWithValue("@appId", screeningSelectedAppId);
                        cmdHist.Parameters.AddWithValue("@newStatus", newStatus);
                        cmdHist.ExecuteNonQuery();
                    }

         
                    string insertRemarksSql = @"INSERT INTO screeningresults (application_id, screened_by, remarks, result) 
                                        VALUES (@appId, @screenedBy, @remarks, @result)";
                    using (MySqlCommand cmdRemarks = new MySqlCommand(insertRemarksSql, conn))
                    {
                        cmdRemarks.Parameters.AddWithValue("@appId", screeningSelectedAppId);
                        cmdRemarks.Parameters.AddWithValue("@screenedBy", currentUserId);
                        cmdRemarks.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());
                        cmdRemarks.Parameters.AddWithValue("@result", decisionStatus);
                        cmdRemarks.ExecuteNonQuery();
                    }

                    LogAuditAction(currentUserId, "Screening", "screeningresults", screeningSelectedAppId, $"Applicant screening completed. Decision: {decisionStatus}. Remarks: {txtRemarks.Text.Trim()}");
                    MessageBox.Show($"Applicant successfully marked as {decisionStatus}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
                    txtAppID.Clear();
                    txtAppName.Clear();
                    txtAppPos.Clear();
                    txtRemarks.Clear();
                    dgvDocs.DataSource = null;
                    screeningSelectedAppId = -1; 

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
            pnlEvaluation.Visible = false;

            LoadPendingApplicants();
        }

        private void btnInterviewScheduling_Click(object sender, EventArgs e)
        {
            pnlScreening.Visible = false;
            pnlScheduling.Visible = true;
            pnlEvaluation.Visible = false;

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


                    string sqlApps = @"SELECT ap.application_id AS 'App ID', 
                                    CONCAT(a.first_name, ' ', a.last_name) AS 'Name', 
                                    p.position_name AS 'Position'
                            FROM applicants a 
                            INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                            INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id
                            INNER JOIN positions p ON j.position_id = p.position_id
                            WHERE ap.status = 'Shortlisted'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlApps, conn);
                    DataTable dtApps = new DataTable();
                    adapter.Fill(dtApps);
                    dgvShortlisted.DataSource = dtApps;


                    string sqlUsers = "SELECT user_id, username FROM users WHERE role_id IN (1, 2)";
                    MySqlDataAdapter userAdapter = new MySqlDataAdapter(sqlUsers, conn);
                    DataTable dtUsers = new DataTable();
                    userAdapter.Fill(dtUsers);
                    
                    cmbInterviewer.DisplayMember = "username";
                    cmbInterviewer.ValueMember = "user_id";
                    cmbInterviewer.DataSource = dtUsers;

                    string sqlTypes = "SELECT interview_type_id, interview_name FROM interview_types";
                    MySqlDataAdapter typeAdapter = new MySqlDataAdapter(sqlTypes, conn);
                    DataTable dtTypes = new DataTable();
                    typeAdapter.Fill(dtTypes);
                    
                    cmbInterviewType.DisplayMember = "interview_name";
                    cmbInterviewType.ValueMember = "interview_type_id";
                    cmbInterviewType.DataSource = dtTypes;
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

            DateTime scheduledDateTime = dtpSchedDate.Value.Date + dtpSchedTime.Value.TimeOfDay;

            if (scheduledDateTime < DateTime.Now)
            {
                MessageBox.Show("You cannot schedule an interview in the past. Please select a valid future date and time.", "Invalid Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpSchedDate.Value = DateTime.Now;
                return; 
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {

                    if (cmbInterviewer.SelectedValue == null || cmbInterviewType.SelectedValue == null)
                    {
                        MessageBox.Show("Please ensure both an Interviewer and an Interview Type are selected.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    conn.Open();


                    string sqlInsert = @"INSERT INTO interviewschedules 
                        (application_id, interview_date, interview_time, interviewer_id, interview_type_id, location, status) 
                        VALUES (@appId, @date, @time, @interviewer, @type, @location, 'Scheduled')";

                    using (MySqlCommand cmd = new MySqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@appId", schedSelectedApplicationId);
                        cmd.Parameters.AddWithValue("@date", dtpSchedDate.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@time", dtpSchedTime.Value.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@interviewer", Convert.ToInt32(cmbInterviewer.SelectedValue));
                        cmd.Parameters.AddWithValue("@type", Convert.ToInt32(cmbInterviewType.SelectedValue));
                        cmd.Parameters.AddWithValue("@location", txtLocation.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }


                    string sqlUpdate = "UPDATE applications SET status = 'Interviewing' WHERE application_id = @appId";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@appId", schedSelectedApplicationId);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    string sqlHistory = "INSERT INTO applicationstatushistory (application_id, old_status, new_status) VALUES (@appId, 'Shortlisted', 'Interviewing')";
                    using (MySqlCommand cmdHist = new MySqlCommand(sqlHistory, conn))
                    {
                        cmdHist.Parameters.AddWithValue("@appId", schedSelectedApplicationId);
                        cmdHist.ExecuteNonQuery();
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

        private void btnInterviewEvaluation_Click(object sender, EventArgs e)
        {

            pnlScreening.Visible = false;
            pnlScheduling.Visible = false;
            pnlEvaluation.Visible = true;

            LoadEvaluationData();
        }
        private int evalSelectedApplicationId = -1;

        private void LoadEvaluationData()
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
                        INNER JOIN positions p ON j.position_id = p.position_id
                        WHERE ap.status = 'Interviewing'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvInterviewees.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading evaluation data: " + ex.Message);
                }
            }
        }

        private void dgvInterviewees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInterviewees.Rows[e.RowIndex];
                evalSelectedApplicationId = Convert.ToInt32(row.Cells["App ID"].Value);


                txtEvalName.Text = row.Cells["Name"].Value.ToString();


                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string getInterviewerSql = @"SELECT u.username 
                                             FROM interviewschedules i
                                             INNER JOIN users u ON i.interviewer_id = u.user_id
                                             WHERE i.application_id = @appId
                                             ORDER BY i.interview_date DESC LIMIT 1";

                        using (MySqlCommand cmd = new MySqlCommand(getInterviewerSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@appId", evalSelectedApplicationId);
                            object result = cmd.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {

                                txtInterviewer.Text = result.ToString();
                            }
                            else
                            {
                                txtInterviewer.Text = "Not Assigned";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching interviewer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                nudScore.Value = 0;
                cmbPassFail.SelectedIndex = -1;
                txtRecommendation.Clear();
                txtEvalRemarks.Clear();
            }
        }

        private void btnSaveEvaluation_Click(object sender, EventArgs e)
        {
            if (evalSelectedApplicationId == -1 || cmbPassFail.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an applicant and choose Pass/Fail.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    int matchingScheduleId = 0;
                    string getSchedSql = "SELECT schedule_id FROM interviewschedules WHERE application_id = @appId ORDER BY interview_date DESC LIMIT 1";
                    using (MySqlCommand cmdSched = new MySqlCommand(getSchedSql, conn))
                    {
                        cmdSched.Parameters.AddWithValue("@appId", evalSelectedApplicationId);
                        object res = cmdSched.ExecuteScalar();
                        if (res != null && res != DBNull.Value) matchingScheduleId = Convert.ToInt32(res);
                    }

                    string sqlInsert = @"INSERT INTO interviewevaluations 
                                 (application_id, schedule_id, score, pass_fail, recommendation, remarks) 
                                 VALUES (@appId, @schedId, @score, @passFail, @recommendation, @remarks)";

                    using (MySqlCommand cmd = new MySqlCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@appId", evalSelectedApplicationId);
                        cmd.Parameters.AddWithValue("@schedId", matchingScheduleId);
                        cmd.Parameters.AddWithValue("@score", nudScore.Value);
                        cmd.Parameters.AddWithValue("@passFail", cmbPassFail.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@recommendation", txtRecommendation.Text.Trim());
                        cmd.Parameters.AddWithValue("@remarks", txtEvalRemarks.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    string newStatus = cmbPassFail.SelectedItem.ToString() == "Pass" ? "Offered" : "Rejected";
                    string sqlUpdate = "UPDATE applications SET status = @status WHERE application_id = @appId";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@status", newStatus);
                        cmdUpdate.Parameters.AddWithValue("@appId", evalSelectedApplicationId);
                        cmdUpdate.ExecuteNonQuery();
                    }
                    string sqlHistory = "INSERT INTO applicationstatushistory (application_id, old_status, new_status) VALUES (@appId, 'Interviewing', @newStatus)";
                    using (MySqlCommand cmdHist = new MySqlCommand(sqlHistory, conn))
                    {
                        cmdHist.Parameters.AddWithValue("@appId", evalSelectedApplicationId);
                        cmdHist.Parameters.AddWithValue("@newStatus", newStatus); 
                        cmdHist.ExecuteNonQuery();
                    }
                    LogAuditAction(currentUserId, "Interview Evaluation", "interviewevaluations", evalSelectedApplicationId, "Applicant passed/failed interview.");

                    MessageBox.Show($"Evaluation saved! Applicant status updated to: {newStatus}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtEvalName.Clear();
                    txtRecommendation.Clear();
                    txtEvalRemarks.Clear();
                    evalSelectedApplicationId = -1;
                    LoadEvaluationData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving evaluation: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewApplicantProfile_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAppID.Text))
            {
                MessageBox.Show("Please select an applicant from the Pending list first.", "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedAppId = Convert.ToInt32(txtAppID.Text);


            ApplicantProfileForm profileForm = new ApplicantProfileForm(selectedAppId, true);

            this.Hide();                
            profileForm.ShowDialog();  
            this.Show();
        }

        private void dgvDocs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                string filePath = dgvDocs.Rows[e.RowIndex].Cells["File"].Value.ToString();

                try
                {

                    if (System.IO.File.Exists(filePath))
                    {

                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        });
                    }
                    else
                    {
                        MessageBox.Show("Cannot open file. The file path might be incorrect or the file was moved.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                        cmd.Parameters.AddWithValue("@userId", currentUserId);
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
