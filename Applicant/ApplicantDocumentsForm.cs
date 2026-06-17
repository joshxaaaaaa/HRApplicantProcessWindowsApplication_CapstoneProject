using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantWindowSystem
{
    public partial class ApplicantDocumentsForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentApplicationID { get; set; } = 1;

        public class DocumentRecord
        {
            public int DocumentID { get; set; }
            public int RequirementTypeID { get; set; }
            public string DocumentType { get; set; }
            public string Status { get; set; }
            public string FileName { get; set; }
            public string UploadedAt { get; set; }
        }

        public ApplicantDocumentsForm()
        {
            InitializeComponent();

            dgvDocuments.Visible = true;
        }


        private int currentApplicantId = 0;
        private int activeApplicationId = 0;
        private int currentVacancyId = 0;
        private string currentApplicationStatus = string.Empty;

        private void CheckActiveApplication()
        {

            if (CurrentApplicationID <= 0) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT application_id, applicant_id, vacancy_id, status, is_locked FROM Applications WHERE application_id = @AppId LIMIT 1;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppId", CurrentApplicationID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                activeApplicationId = Convert.ToInt32(reader["application_id"]);
                                try { currentApplicantId = reader["applicant_id"] != DBNull.Value ? Convert.ToInt32(reader["applicant_id"]) : 0; } catch { currentApplicantId = 0; }
                                try { currentVacancyId = reader["vacancy_id"] != DBNull.Value ? Convert.ToInt32(reader["vacancy_id"]) : 0; } catch { currentVacancyId = 0; }
                                currentApplicationStatus = reader["status"] != DBNull.Value ? reader["status"].ToString() : string.Empty;
                                bool isLocked = reader["is_locked"] != DBNull.Value && Convert.ToInt32(reader["is_locked"]) == 1;
                                SetLocked(isLocked);
                            }
                            else
                            {
                                activeApplicationId = 0;
                                currentApplicantId = 0;
                                currentVacancyId = 0;
                                currentApplicationStatus = string.Empty;
                            }
                        }
                    }
                }
                catch { }
            }
        }


        public void SetLocked(bool locked)
        {
            try { btnUpload.Enabled = !locked; } catch { }
            try { btnSave.Enabled = !locked; } catch { }
            try { lblRemarks.Text = locked ? "Application locked by HR: uploads disabled." : "Select a requirement to upload"; } catch { }
        }

        private void ApplicantDocumentsForm_Load(object sender, EventArgs e)
        {
            if (CurrentApplicationID <= 1)
            {
                ResolveFallbackLatestApplication();
            }

            RefreshGridFromDatabase();

            try { CheckActiveApplication(); } catch { }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT is_locked FROM Applications WHERE application_id = @AppId LIMIT 1;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppId", CurrentApplicationID);
                        object res = cmd.ExecuteScalar();
                        bool isLocked = res != null && res != DBNull.Value && Convert.ToInt32(res) == 1;
                        SetLocked(isLocked);
                    }
                }
            }
            catch { }
        }

        private void ResolveFallbackLatestApplication()
        {
            string fallbackQuery = "SELECT application_id FROM Applications ORDER BY applied_date DESC LIMIT 1;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(fallbackQuery, conn))
                {
                    try
                    {
                        conn.Open();
                        object res = cmd.ExecuteScalar();
                        if (res != null && res != DBNull.Value)
                        {
                            CurrentApplicationID = Convert.ToInt32(res);
                        }
                    }
                    catch { }
                }
            }
        }

        private void RefreshGridFromDatabase()
        {
            List<DocumentRecord> documentList = new List<DocumentRecord>();

            string query = @"
                SELECT 
                    d.document_id,
                    rt.requirement_type_id,
                    rt.requirement_name AS DocumentType,
                    CASE WHEN d.file_path IS NOT NULL AND d.file_path != '' THEN 'Submitted' ELSE 'Missing' END AS Status,
                    COALESCE(d.file_path, 'None') AS FileName,
                    COALESCE(DATE_FORMAT(d.uploaded_at, '%Y-%m-%d %H:%i:%s'), 'N/A') AS UploadedAt
                FROM RequirementTypes rt
                LEFT JOIN ApplicantDocuments d 
                    ON rt.requirement_type_id = d.requirement_type_id 
                    AND d.application_id = @ApplicationID;";

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
                            while (reader.Read())
                            {
                                string rawFileName = reader["FileName"].ToString();
                                string cleanFileName = (rawFileName == "None" || string.IsNullOrEmpty(rawFileName))
                                    ? "No File Uploaded"
                                    : Path.GetFileName(rawFileName);

                                documentList.Add(new DocumentRecord
                                {
                                    DocumentID = reader["document_id"] != DBNull.Value ? Convert.ToInt32(reader["document_id"]) : 0,
                                    RequirementTypeID = Convert.ToInt32(reader["requirement_type_id"]),
                                    DocumentType = reader["DocumentType"].ToString(),
                                    Status = reader["Status"].ToString(),
                                    FileName = cleanFileName,
                                    UploadedAt = reader["UploadedAt"].ToString()
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading records: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            dgvDocuments.DataSource = null;
            dgvDocuments.AutoGenerateColumns = true;
            dgvDocuments.DataSource = documentList;

            if (dgvDocuments.Columns["DocumentID"] != null) dgvDocuments.Columns["DocumentID"].Visible = false;
            if (dgvDocuments.Columns["RequirementTypeID"] != null) dgvDocuments.Columns["RequirementTypeID"].Visible = false;

            if (dgvDocuments.Columns["DocumentType"] != null) dgvDocuments.Columns["DocumentType"].Width = 180;
            if (dgvDocuments.Columns["FileName"] != null) dgvDocuments.Columns["FileName"].Width = 220;

            dgvDocuments.Refresh();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.CurrentRow == null)
            {
                MessageBox.Show("Please select a criteria row first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvDocuments.CurrentRow.DataBoundItem as DocumentRecord;
            if (selectedRow == null) return;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Document Files (*.pdf, *.docx, *.jpg, *.png)|*.pdf;*.docx;*.jpg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string targetFilePath = openFileDialog.FileName;
                    string saveQuery = selectedRow.DocumentID == 0
                        ? @"INSERT INTO ApplicantDocuments (application_id, requirement_type_id, file_path, uploaded_at) VALUES (@ApplicationID, @RequirementTypeID, @FilePath, NOW());"
                        : @"UPDATE ApplicantDocuments SET file_path = @FilePath, uploaded_at = NOW() WHERE document_id = @DocumentID;";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand(saveQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@ApplicationID", CurrentApplicationID);
                            cmd.Parameters.AddWithValue("@RequirementTypeID", selectedRow.RequirementTypeID);
                            cmd.Parameters.AddWithValue("@FilePath", targetFilePath);
                            cmd.Parameters.AddWithValue("@DocumentID", selectedRow.DocumentID);

                            try
                            {
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Upload successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshGridFromDatabase();

                                try { CheckActiveApplication(); } catch { }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Upload failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string oldStatus = string.IsNullOrEmpty(currentApplicationStatus) ? null : currentApplicationStatus;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            if (activeApplicationId == 0)
                            {

                                string insertAppQuery = "INSERT INTO Applications (applicant_id, vacancy_id, status) VALUES (@ApplicantID, @VacancyID, 'Submitted');";
                                using (MySqlCommand cmd = new MySqlCommand(insertAppQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@ApplicantID", currentApplicantId);
                                    cmd.Parameters.AddWithValue("@VacancyID", currentVacancyId == 0 ? (object)DBNull.Value : currentVacancyId);

                                    cmd.ExecuteNonQuery();
                                    activeApplicationId = (int)cmd.LastInsertedId;
                                }
                            }
                            else
                            {

                                string updateAppQuery = "UPDATE Applications SET vacancy_id = @VacancyID, status = 'Submitted' WHERE application_id = @ApplicationID;";
                                using (MySqlCommand cmd = new MySqlCommand(updateAppQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@VacancyID", currentVacancyId == 0 ? (object)DBNull.Value : currentVacancyId);
                                    cmd.Parameters.AddWithValue("@ApplicationID", activeApplicationId);
                                    cmd.ExecuteNonQuery();
                                }
                            }


                            string historyQuery = @"
                                    INSERT INTO ApplicationStatusHistory (application_id, old_status, new_status) 
                                    VALUES (@AppID, @OldStatus, 'Submitted');";

                            using (MySqlCommand cmdHistory = new MySqlCommand(historyQuery, conn, transaction))
                            {
                                cmdHistory.Parameters.AddWithValue("@AppID", activeApplicationId);
                                cmdHistory.Parameters.AddWithValue("@OldStatus", (object)oldStatus ?? DBNull.Value);


                                cmdHistory.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            LogAuditAction("Document Submission", "applications", activeApplicationId, "Applicant successfully uploaded and submitted required documents.");

                            MessageBox.Show("Your job application details have been successfully saved and dispatched directly to HR recruitment streams!", "Submission Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CheckActiveApplication();

                            try
                            {
                                foreach (Form f in Application.OpenForms)
                                {
                                    if (f is ApplicantProcess hr)
                                    {
                                        hr.RefreshForApplicant(currentApplicantId);
                                    }
                                }
                            }
                            catch { }
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
                    MessageBox.Show("Failed saving details: " + ex.Message, "Execution Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LogAuditAction(string actionType, string tableAffected, int recordId, string details)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    int currentUserId = 0;
                    string getUserSql = "SELECT account_id FROM Applicants WHERE applicant_id = @applicantId LIMIT 1";
                    using (MySqlCommand userCmd = new MySqlCommand(getUserSql, conn))
                    {
                        userCmd.Parameters.AddWithValue("@applicantId", currentApplicantId);
                        object res = userCmd.ExecuteScalar();
                        if (res != null && res != DBNull.Value)
                        {
                            currentUserId = Convert.ToInt32(res);
                        }
                    }


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

        private void dgvDocuments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
