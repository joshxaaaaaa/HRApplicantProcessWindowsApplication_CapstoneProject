using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantWindowSystem
{
    public partial class ApplicantProcess : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        private int selectedApplicantId = -1;
        private int currentUserId;
        public ApplicantProcess(int userId)
        {
            InitializeComponent();
            RefreshApplicantGrid();
            UpdateMetricSummaryCards();
            currentUserId = userId;
        }


        public void RefreshForApplicant(int applicantId)
        {
            try
            {
                LoadApplicantGrid();
                LoadApplicantDetails(applicantId);
                UpdateMetricSummaryCards();
            }
            catch { }
        }
   


        private void RefreshApplicantGrid()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT a.applicant_id AS 'ID', 
                       CONCAT(a.first_name, ' ', a.last_name) AS 'Full Name', 
                       p.position_name AS 'Applied Position', 
                       ap.status AS 'Status' 
                FROM applicants a 
                INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id
                INNER JOIN positions p ON j.position_id = p.position_id;";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvApplicantList.DataSource = table;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        

        private void UpdateMetricSummaryCards()
        {

            try { LoadDashboardMetrics(); } catch { }
        }

        private void txtSearchApplicant_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchApplicant.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvApplicantList.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool isMatch = row.Cells["Full Name"].Value != null &&
                                   row.Cells["Full Name"].Value.ToString().ToLower().Contains(keyword);

                    if (row.Visible != isMatch)
                    {
                        dgvApplicantList.CurrentCell = null;
                        row.Visible = isMatch;
                    }
                }
            }
        }

        private void btnLockReview_Click(object sender, EventArgs e)
        {

            if (selectedApplicantId == -1)
            {
                MessageBox.Show("Please select an applicant from the list first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            if (string.IsNullOrWhiteSpace(txtProfileName.Text) ||
                string.IsNullOrWhiteSpace(txtProfileEmail.Text) ||
                string.IsNullOrWhiteSpace(txtProfilePhone.Text) ||
                string.IsNullOrWhiteSpace(txtEducation.Text) ||
                string.IsNullOrWhiteSpace(txtWorkExp.Text) ||
                string.IsNullOrWhiteSpace(txtOtherDeteails.Text)) 
            {
                MessageBox.Show("Cannot lock this application. The applicant has not completed their Profile Summary (Missing Education, Work Experience, Other Details, or Contact Info).",
                                "Incomplete Profile", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            if (dgvDocuments.DataSource == null || dgvDocuments.Rows.Count == 0)
            {
                MessageBox.Show("Cannot lock this application. No documents have been found for this applicant.",
                                "Missing Documents", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            foreach (DataGridViewRow row in dgvDocuments.Rows)
            {
                if (!row.IsNewRow)
                {
                    string filePath = row.Cells["File Route"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(filePath))
                    {
                        MessageBox.Show("Cannot lock this application. The applicant still has missing document requirements. Please wait for them to upload all files.",
                                        "Incomplete Documents", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }



            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "UPDATE applications SET is_locked = 1, status = 'Screening' WHERE applicant_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedApplicantId);
                        cmd.ExecuteNonQuery();
                    }

                    LogAuditAction(currentUserId, "Lock", "applications", selectedApplicantId, "HR locked application for screening.");
                    MessageBox.Show("Application successfully locked for review.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateMetricSummaryCards();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error locking application: " + ex.Message);
                }
            }
        }



        private void ApplicantProcess_Load(object sender, EventArgs e)
        {
            LoadDashboardMetrics();
            LoadApplicantGrid();
        }

        

        private void dgvApplicantList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (dgvApplicantList.Columns.Contains("ID"))
                    {
                        selectedApplicantId = Convert.ToInt32(dgvApplicantList.Rows[e.RowIndex].Cells["ID"].Value);
                    }
                    else
                    {
                        selectedApplicantId = Convert.ToInt32(dgvApplicantList.Rows[e.RowIndex].Cells[0].Value);
                    }

                    LoadApplicantDetails(selectedApplicantId);
                }
                catch { }
            }
        }

        private void LoadDashboardMetrics()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmdTotal = new MySqlCommand("SELECT COUNT(*) FROM applications", conn);
                    lblTotalApps.Text = cmdTotal.ExecuteScalar().ToString();



                    MySqlCommand cmdPending = new MySqlCommand("SELECT COUNT(*) FROM applications WHERE status IN ('Pending', 'Under Review', 'Screening')", conn);
                    lblPending.Text = cmdPending.ExecuteScalar().ToString();


                    MySqlCommand cmdShort = new MySqlCommand("SELECT COUNT(*) FROM applications WHERE status = 'Shortlisted'", conn);
                    lblShortlisted.Text = cmdShort.ExecuteScalar().ToString();


                    MySqlCommand cmdInt = new MySqlCommand("SELECT COUNT(*) FROM applications WHERE status = 'Interviewing'", conn);
                    lblInterviewing.Text = cmdInt.ExecuteScalar().ToString();


                    MySqlCommand cmdHired = new MySqlCommand("SELECT COUNT(*) FROM applications WHERE status = 'Hired'", conn);
                    lblHired.Text = cmdHired.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Metrics Error: " + ex.Message);
                }
            }
        }
        private void LoadApplicantGrid()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
 
                    string sql = @"
                SELECT a.applicant_id AS 'ID', 
                       CONCAT(a.first_name, ' ', a.last_name) AS 'Name', 
                       p.position_name AS 'Position', 
                       ap.status AS 'Status' 
                FROM applicants a 
                INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id
                INNER JOIN positions p ON j.position_id = p.position_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvApplicantList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Grid Error: " + ex.Message);
                }
            }
        }
        private void LoadApplicantDetails(int applicantId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string summarySql = @"
                        SELECT CONCAT(a.first_name, ' ', a.last_name) AS FullName, 
                            acc.email AS email, 
                            a.contact_number AS phone, 
                            p.position_name AS job_title, 
                            ap.status 
                        FROM applicants a 
                        INNER JOIN applicantaccounts acc ON a.account_id = acc.account_id
                        INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                        INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id 
                        INNER JOIN positions p ON j.position_id = p.position_id
                        WHERE a.applicant_id = @id LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(summarySql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", applicantId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtProfileName.Text = reader["FullName"].ToString();
                                txtProfileEmail.Text = reader["email"].ToString();
                                txtProfilePhone.Text = reader["phone"].ToString();
                                txtProfilePosition.Text = reader["job_title"].ToString();
                                txtProfileStatus.Text = reader["status"].ToString();
                            }
                        } 
                    }


                    string profSql = "SELECT educational_attainments, work_experiences, other_details FROM applicant_profiles WHERE applicant_id = @id LIMIT 1";
                    using (MySqlCommand profCmd = new MySqlCommand(profSql, conn))
                    {
                        profCmd.Parameters.AddWithValue("@id", applicantId);


                        using (MySqlDataReader pread = profCmd.ExecuteReader())
                        {
                            if (pread.Read())
                            {
                                txtEducation.Text = pread["educational_attainments"].ToString();
                                txtWorkExp.Text = pread["work_experiences"].ToString();
                                txtOtherDeteails.Text = pread["other_details"].ToString();
                            }
                            else
                            {

                                txtEducation.Clear();
                                txtWorkExp.Clear();
                                txtOtherDeteails.Clear();
                            }
                        }
                    }



                    int appId = 0;
                    string appLookup = "SELECT application_id FROM Applications WHERE applicant_id = @id ORDER BY applied_date DESC LIMIT 1";
                    using (MySqlCommand appCmd = new MySqlCommand(appLookup, conn))
                    {
                        appCmd.Parameters.AddWithValue("@id", applicantId);
                        object appRes = appCmd.ExecuteScalar();
                        if (appRes != null && appRes != DBNull.Value)
                        {
                            appId = Convert.ToInt32(appRes);
                        }
                    }

                    if (appId == 0)
                    {

                        dgvDocuments.DataSource = null;
                        try { btnLockReview.Enabled = true; btnLockReview.Text = "Lock for Review"; btnLockReview.BackColor = Color.FromArgb(128, 255, 255); } catch { }
                    }
                    else
                    {

                        string docSql = @"SELECT rt.requirement_name AS 'Document Type', ad.file_path AS 'File Route' 
                                  FROM RequirementTypes rt 
                                  LEFT JOIN ApplicantDocuments ad ON rt.requirement_type_id = ad.requirement_type_id AND ad.application_id = @appId";

                        MySqlDataAdapter docAdapter = new MySqlDataAdapter(docSql, conn);
                        docAdapter.SelectCommand.Parameters.AddWithValue("@appId", appId);
                        DataTable docDt = new DataTable();
                        docAdapter.Fill(docDt);
                        dgvDocuments.DataSource = docDt;


                        string lockQuery = "SELECT COUNT(*) FROM Applications WHERE applicant_id = @id AND is_locked = 1";
                        using (MySqlCommand lockCmd = new MySqlCommand(lockQuery, conn))
                        {
                            lockCmd.Parameters.AddWithValue("@id", applicantId);
                            object lockRes = lockCmd.ExecuteScalar();
                            bool anyLocked = lockRes != null && lockRes != DBNull.Value && Convert.ToInt32(lockRes) > 0;

                            if (anyLocked)
                            {

                                try { btnLockReview.Click -= btnLockReview_Click; } catch { }
                                btnLockReview.Enabled = false;
                                btnLockReview.Text = "Locked";
                                btnLockReview.BackColor = Color.LightSalmon;
                            }
                            else
                            {
                                try { btnLockReview.Click -= btnLockReview_Click; } catch { }
                                btnLockReview.Click += btnLockReview_Click;
                                btnLockReview.Enabled = true;
                                btnLockReview.Text = "Lock for Review";
                                btnLockReview.BackColor = Color.FromArgb(128, 255, 255);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Details Error: " + ex.Message);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}