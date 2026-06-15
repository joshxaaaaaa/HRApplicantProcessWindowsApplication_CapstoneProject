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
    public partial class MyApplicationForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        private int currentAccountId;
        private int currentApplicantId = 0;
        private int activeApplicationId = 0;
        private int currentVacancyId = 0;
        private string currentApplicationStatus = "";
        private bool currentApplicationLocked = false;

        public MyApplicationForm(int accountId)
        {
            InitializeComponent();
            this.currentAccountId = accountId;

            try { btnMyProfile.Click += btnMyProfile_Click; } catch { }

            try { this.Activated += MyApplicationForm_Activated; } catch { }
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            try
            {

                try { CheckActiveApplication(); } catch { }
                ApplicantProfileForm profilePage = new ApplicantProfileForm(currentAccountId);
                profilePage.StartPosition = FormStartPosition.CenterScreen;

                try { profilePage.SetLocked(currentApplicationLocked); } catch { }
                profilePage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyApplicationForm_Activated(object? sender, EventArgs e)
        {

            try { CheckActiveApplication(); } catch { }
        }

        private string GetJobTitle(int vacancyId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"
                SELECT p.position_name 
                FROM jobvacancies v 
                INNER JOIN positions p ON v.position_id = p.position_id 
                WHERE v.vacancy_id = @id LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", vacancyId);
                        object res = cmd.ExecuteScalar();
                        return res != null && res != DBNull.Value ? res.ToString() : string.Empty;
                    }
                }
            }
            catch { return string.Empty; }
        }

        private void LoadRequirementsGrid(int vacancyId, int applicationId)
        {

            string sql = @"
                SELECT rt.requirement_name AS 'Requirement',
                       CASE WHEN ad.document_id IS NOT NULL THEN 'Uploaded' ELSE 'Not Uploaded' END AS 'Status',
                       COALESCE(ad.file_path, '') AS 'FilePath'
                FROM RequirementTypes rt
                LEFT JOIN ApplicantDocuments ad ON rt.requirement_type_id = ad.requirement_type_id AND ad.application_id = @AppId
                WHERE rt.requirement_type_id IS NOT NULL";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppId", applicationId);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvRequirements.DataSource = dt;
                        // adjust columns
                        if (dgvRequirements.Columns["Requirement"] != null) dgvRequirements.Columns["Requirement"].Width = 300;
                        if (dgvRequirements.Columns["Status"] != null) dgvRequirements.Columns["Status"].Width = 120;
                        if (dgvRequirements.Columns["FilePath"] != null) dgvRequirements.Columns["FilePath"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load requirements: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyApplicationForm_Load(object sender, EventArgs e)
        {
            ResolveApplicantId();

            CheckActiveApplication();
            LoadJobVacanciesComboBox();
        }

        private void ResolveApplicantId()
        {
            string query = "SELECT applicant_id FROM Applicants WHERE account_id = @AccountID LIMIT 1;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountID", currentAccountId);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null) currentApplicantId = Convert.ToInt32(result);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Profile linkage error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadJobVacanciesComboBox()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    if (activeApplicationId != 0)
                    {

                        string singleQuery = @"
                    SELECT j.vacancy_id, p.position_name AS job_title 
                    FROM JobVacancies j
                    INNER JOIN Applications a ON j.vacancy_id = a.vacancy_id
                    INNER JOIN positions p ON j.position_id = p.position_id
                    WHERE a.application_id = @AppId LIMIT 1;";

                        using (MySqlCommand cmd = new MySqlCommand(singleQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@AppId", activeApplicationId);
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                        }
                    }
                    else
                    {

                        string query = @"
                    SELECT v.vacancy_id, p.position_name AS job_title 
                    FROM JobVacancies v 
                    INNER JOIN positions p ON v.position_id = p.position_id 
                    WHERE v.status = 'Open';";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading job postings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckActiveApplication()
        {
            if (currentApplicantId == 0) return;

            string query = @"
                SELECT application_id, vacancy_id, status, is_locked 
                FROM Applications 
                WHERE applicant_id = @ApplicantID 
                ORDER BY applied_date DESC LIMIT 1;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicantID", currentApplicantId);
                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                try { currentVacancyId = Convert.ToInt32(reader["vacancy_id"]); } catch { currentVacancyId = 0; }
                                activeApplicationId = Convert.ToInt32(reader["application_id"]);
                                
                                currentApplicationStatus = reader["status"].ToString();

                                var lockedObj = reader["is_locked"];
                                try { currentApplicationLocked = lockedObj != null && lockedObj != DBNull.Value && Convert.ToInt32(lockedObj) == 1; } catch { currentApplicationLocked = false; }

                                lblStatusText.Text = $"Status: {MapStatusForDisplay(currentApplicationStatus)}";
                                EvaluateFormPermissions();

                                lblLockState.Text = currentApplicationLocked ? "Locked by HR" : "Unlocked";
                                lblLockState.ForeColor = currentApplicationLocked ? Color.Red : Color.DarkGreen;

                                try
                                {
                                    int vacId = Convert.ToInt32(reader["vacancy_id"]);
                                    lblJobTitle.Text = GetJobTitle(vacId);
                                }
                                catch { lblJobTitle.Text = string.Empty; }

                                LoadRequirementsGrid(currentVacancyId, activeApplicationId);
                            }
                            else
                            {
                                activeApplicationId = 0;
                                currentVacancyId = 0;
                                currentApplicationStatus = "";
                                currentApplicationLocked = false;
                                lblStatusText.Text = "Status: Draft (Unsubmitted)";
                                lblJobTitle.Text = string.Empty;
                                dgvRequirements.DataSource = null;
                                EvaluateFormPermissions();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error reviewing application status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EvaluateFormPermissions()
        {

            if (currentApplicationLocked)
            {

                btnDeleteDraft.Enabled = false;
                lblLockNotice.Text = "🔒 Locked by HR: Modifications are disabled.";
                lblLockNotice.ForeColor = System.Drawing.Color.Red;
                return;
            }

 
            btnDeleteDraft.Enabled = (activeApplicationId != 0);
            lblLockNotice.Text = "📝 Unlocked: You may modify or submit your application.";
            lblLockNotice.ForeColor = System.Drawing.Color.DarkGreen;
            return;
        }

        private string MapStatusForDisplay(string status)
        {
            if (string.IsNullOrEmpty(status)) return "Draft (Unsubmitted)";
            switch (status)
            {
                case "Screening":
                    return "Under Review";
                case "Interviewing":
                    return "For Interview";
                case "Offered":
                    return "For Final Review";
                case "Hired":
                    return "Accepted";
                case "Rejected":
                    return "Rejected";
                case "Shortlisted":
                    return "Shortlisted";
                case "Submitted":
                    return "Submitted";
                case "Withdrawn":
                    return "Withdrawn";
                default:
                    return status;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteDraft_Click(object sender, EventArgs e)
        {
            if (activeApplicationId == 0) return;

            var result = MessageBox.Show("Are you sure you want to retract and completely delete your current job application?", "Confirm Retraction", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {

                                string historyQuery = @"
                                    INSERT INTO ApplicationStatusHistory (application_id, old_status, new_status, changed_by) 
                                    VALUES (@AppID, @OldStatus, 'Retracted', NULL);";

                                using (MySqlCommand cmdHistory = new MySqlCommand(historyQuery, conn, transaction))
                                {
                                    cmdHistory.Parameters.AddWithValue("@AppID", activeApplicationId);
                                    cmdHistory.Parameters.AddWithValue("@OldStatus", currentApplicationStatus);
                                    cmdHistory.ExecuteNonQuery();
                                }


                                string deleteQuery = "DELETE FROM Applications WHERE application_id = @ApplicationID;";
                                using (MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, conn, transaction))
                                {
                                    cmdDelete.Parameters.AddWithValue("@ApplicationID", activeApplicationId);
                                    cmdDelete.ExecuteNonQuery();
                                }

                                transaction.Commit();

                                activeApplicationId = 0;
                                currentApplicationStatus = "";
                               

                                lblStatusText.Text = "Status: Draft (Unsubmitted)";
                                EvaluateFormPermissions();
                                MessageBox.Show("Application successfully retracted and database records updated.", "Retracted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception transEx)
                            {
                                transaction.Rollback();
                                throw transEx;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to retract records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblJobTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
