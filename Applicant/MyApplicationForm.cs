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
        private string currentApplicationStatus = "";

        public MyApplicationForm(int accountId)
        {
            InitializeComponent();
            this.currentAccountId = accountId;
        }

        private void MyApplicationForm_Load(object sender, EventArgs e)
        {
            ResolveApplicantId();
            LoadJobVacanciesComboBox();
            CheckActiveApplication();
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
            string query = "SELECT vacancy_id, job_title FROM JobVacancies WHERE status = 'Open';";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    try
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboVacancies.DataSource = dt;
                        cboVacancies.DisplayMember = "job_title";
                        cboVacancies.ValueMember = "vacancy_id";
                        cboVacancies.SelectedIndex = -1; // Default to unselected
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading job postings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CheckActiveApplication()
        {
            if (currentApplicantId == 0) return;

            string query = @"
                SELECT application_id, vacancy_id, status 
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
                                activeApplicationId = Convert.ToInt32(reader["application_id"]);
                                cboVacancies.SelectedValue = Convert.ToInt32(reader["vacancy_id"]);
                                currentApplicationStatus = reader["status"].ToString();

                                lblStatusText.Text = $"Status: {currentApplicationStatus}";
                                EvaluateFormPermissions();
                            }
                            else
                            {
                                activeApplicationId = 0;
                                currentApplicationStatus = "";
                                lblStatusText.Text = "Status: Draft (Unsubmitted)";
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
            // If there's no submitted application, allow edits
            if (string.IsNullOrEmpty(currentApplicationStatus))
            {
                cboVacancies.Enabled = true;
                btnSubmit.Enabled = true;
                btnDeleteDraft.Enabled = false;
                lblLockNotice.Text = "📝 Ready: Select an open vacancy and hit submit to launch your candidacy.";
                lblLockNotice.ForeColor = System.Drawing.Color.Blue;
                return;
            }

            if (currentApplicationStatus != "Submitted")
            {
                cboVacancies.Enabled = false;
                btnSubmit.Enabled = false;
                btnDeleteDraft.Enabled = false;
                lblLockNotice.Text = "🔒 Enforced Lock: HR has begun processing this application. Modifications are disabled.";
                lblLockNotice.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                cboVacancies.Enabled = true;
                btnSubmit.Enabled = true;
                btnDeleteDraft.Enabled = true;
                lblLockNotice.Text = "🔓 Editable: You can modify or retract your choice until HR changes your status.";
                lblLockNotice.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboVacancies.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a target job position from the dropdown menu first.", "Selection Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedVacancyId = Convert.ToInt32(cboVacancies.SelectedValue);
            string oldStatus = string.IsNullOrEmpty(currentApplicationStatus) ? null : currentApplicationStatus;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Wrap inside a Database Transaction to protect multi-table integrity
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            if (activeApplicationId == 0)
                            {
                                // 1. Insert new application record
                                string insertAppQuery = "INSERT INTO Applications (applicant_id, vacancy_id, status) VALUES (@ApplicantID, @VacancyID, 'Submitted');";
                                using (MySqlCommand cmd = new MySqlCommand(insertAppQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@ApplicantID", currentApplicantId);
                                    cmd.Parameters.AddWithValue("@VacancyID", selectedVacancyId);
                                    cmd.ExecuteNonQuery();
                                    activeApplicationId = (int)cmd.LastInsertedId;
                                }
                            }
                            else
                            {
                                // Update existing application record
                                string updateAppQuery = "UPDATE Applications SET vacancy_id = @VacancyID, status = 'Submitted' WHERE application_id = @ApplicationID;";
                                using (MySqlCommand cmd = new MySqlCommand(updateAppQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@VacancyID", selectedVacancyId);
                                    cmd.Parameters.AddWithValue("@ApplicationID", activeApplicationId);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // 2. Reflect on HR side by inserting into ApplicationStatusHistory
                            string historyQuery = @"
                                INSERT INTO ApplicationStatusHistory (application_id, old_status, new_status, changed_by) 
                                VALUES (@AppID, @OldStatus, 'Submitted', NULL);"; // NULL changed_by indicates applicant action

                            using (MySqlCommand cmdHistory = new MySqlCommand(historyQuery, conn, transaction))
                            {
                                cmdHistory.Parameters.AddWithValue("@AppID", activeApplicationId);
                                cmdHistory.Parameters.AddWithValue("@OldStatus", (object)oldStatus ?? DBNull.Value);
                                cmdHistory.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Your job application details have been successfully saved and dispatched directly to HR recruitment streams!", "Submission Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CheckActiveApplication();
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
                                // 1. Log structural history drop before cascade triggers drop it
                                string historyQuery = @"
                                    INSERT INTO ApplicationStatusHistory (application_id, old_status, new_status, changed_by) 
                                    VALUES (@AppID, @OldStatus, 'Retracted', NULL);";

                                using (MySqlCommand cmdHistory = new MySqlCommand(historyQuery, conn, transaction))
                                {
                                    cmdHistory.Parameters.AddWithValue("@AppID", activeApplicationId);
                                    cmdHistory.Parameters.AddWithValue("@OldStatus", currentApplicationStatus);
                                    cmdHistory.ExecuteNonQuery();
                                }

                                // 2. Perform the application deletion (Cascades down to document links natively)
                                string deleteQuery = "DELETE FROM Applications WHERE application_id = @ApplicationID;";
                                using (MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, conn, transaction))
                                {
                                    cmdDelete.Parameters.AddWithValue("@ApplicationID", activeApplicationId);
                                    cmdDelete.ExecuteNonQuery();
                                }

                                transaction.Commit();

                                activeApplicationId = 0;
                                currentApplicationStatus = "";
                                cboVacancies.SelectedIndex = -1;

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
    }
}
