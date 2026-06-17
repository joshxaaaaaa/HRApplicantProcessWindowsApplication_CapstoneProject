using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantWindowSystem.Applicant
{
    public partial class ChangePasswordForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        private int currentAccountId;
        public ChangePasswordForm(int accountId)
        {
            InitializeComponent();
            currentAccountId = accountId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string currentPass = txtCurrent.Text;
            string newPass = txtNew.Text;
            string confirmPass = txtConfirm.Text;

       
            if (string.IsNullOrWhiteSpace(currentPass) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmPass))
            {
                MessageBox.Show("Please fill out all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("New passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

            
                    string checkSql = "SELECT COUNT(*) FROM applicantaccounts WHERE account_id = @id AND password_hash = @currentPass";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", currentAccountId);
                        checkCmd.Parameters.AddWithValue("@currentPass", currentPass);

                        int matchCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (matchCount == 0)
                        {
                            MessageBox.Show("Your current password is incorrect.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }

      
                    string updateSql = "UPDATE applicantaccounts SET password_hash = @newPass WHERE account_id = @id";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateSql, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@newPass", newPass);
                        updateCmd.Parameters.AddWithValue("@id", currentAccountId);
                        updateCmd.ExecuteNonQuery();
                    }

        
                    LogAuditAction(currentAccountId, "Profile Update", "applicantaccounts", currentAccountId, "Applicant changed their password.");

                    MessageBox.Show("Password successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
                    string sql = @"INSERT INTO audittrail (user_id, action_type, table_affected, record_id, details, action_timestamp) 
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
                catch {  }
            }
        }
    }
}
