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
            RefreshGridFromDatabase();
        }

        private void RefreshGridFromDatabase()
        {
            List<DocumentRecord> documentList = new List<DocumentRecord>();

            string query = @"
                SELECT 
                    d.document_id,
                    rt.requirement_type_id,
                    rt.requirement_name AS DocumentType,
                    CASE WHEN d.file_path IS NOT NULL THEN 'Submitted' ELSE 'Missing' END AS Status,
                    COALESCE(d.file_path, 'None') AS FileName,
                    COALESCE(CAST(d.uploaded_at AS CHAR), 'N/A') AS UploadedAt
                FROM RequirementTypes rt
                LEFT JOIN ApplicantDocuments d 
                    ON rt.requirement_type_id = d.requirement_type_id 
                    AND d.application_id = @ApplicationID";

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
                                documentList.Add(new DocumentRecord
                                {
                                    DocumentID = reader["document_id"] != DBNull.Value ? Convert.ToInt32(reader["document_id"]) : 0,
                                    RequirementTypeID = Convert.ToInt32(reader["requirement_type_id"]),
                                    DocumentType = reader["DocumentType"].ToString(),
                                    Status = reader["Status"].ToString(),
                                    FileName = Path.GetFileName(reader["FileName"].ToString()), 
                                    UploadedAt = reader["UploadedAt"].ToString()
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading records from database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            dgvDocuments.DataSource = null;
            dgvDocuments.DataSource = documentList;

            if (dgvDocuments.Columns["DocumentID"] != null) dgvDocuments.Columns["DocumentID"].Visible = false;
            if (dgvDocuments.Columns["RequirementTypeID"] != null) dgvDocuments.Columns["RequirementTypeID"].Visible = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (dgvDocuments.CurrentRow == null)
            {
                MessageBox.Show("Please select a document criteria row from the table list first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvDocuments.CurrentRow.DataBoundItem as DocumentRecord;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Document Files (*.pdf, *.docx, *.jpg, *.png)|*.pdf;*.docx;*.jpg;*.png";
                openFileDialog.Title = $"Select your file for: {selectedRow.DocumentType}";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string targetFilePath = openFileDialog.FileName; 

                    string saveQuery;
                    if (selectedRow.DocumentID == 0)
                    {
                        saveQuery = @"INSERT INTO ApplicantDocuments (application_id, requirement_type_id, file_path, uploaded_at) 
                                      VALUES (@ApplicationID, @RequirementTypeID, @FilePath, NOW())";
                    }
                    else
                    {
                        saveQuery = @"UPDATE ApplicantDocuments 
                                      SET file_path = @FilePath, uploaded_at = NOW() 
                                      WHERE document_id = @DocumentID";
                    }

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


                                RefreshGridFromDatabase();
                                MessageBox.Show($"{selectedRow.DocumentType} successfully processed and recorded in the system!", "Upload Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Database submission failed: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnAddNewType_Click(object sender, EventArgs e)
        {
            string newDocName = txtNewDocName.Text.Trim();

            if (string.IsNullOrEmpty(newDocName))
            {
                MessageBox.Show("Please enter a label for your custom requirement slot first.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = "INSERT INTO RequirementTypes (requirement_name, description) VALUES (@ReqName, 'Custom User Upload Slot')";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ReqName", newDocName);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        RefreshGridFromDatabase();
                        txtNewDocName.Clear();
                        MessageBox.Show($"'{newDocName}' requirement rule established globally. You can now select it to process your upload file.", "Requirement Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to save new slot type: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
