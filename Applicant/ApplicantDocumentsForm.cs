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
        }

        private void ApplicantDocumentsForm_Load(object sender, EventArgs e)
        {
            if (CurrentApplicationID <= 1)
            {
                ResolveFallbackLatestApplication();
            }
            RefreshGridFromDatabase();
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
                    catch { /* Fallback fails silently */ }
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

        private void btnAddNewType_Click(object sender, EventArgs e)
        {
            string newDocName = txtNewDocName.Text.Trim();
            if (string.IsNullOrEmpty(newDocName)) return;

            string insertQuery = "INSERT INTO RequirementTypes (requirement_name, description) VALUES (@ReqName, 'Custom User Upload Slot');";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ReqName", newDocName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        txtNewDocName.Clear();
                        RefreshGridFromDatabase();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to add type: " + ex.Message);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
