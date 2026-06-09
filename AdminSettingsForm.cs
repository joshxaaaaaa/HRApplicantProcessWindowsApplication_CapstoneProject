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
    public partial class AdminSettingsForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        public AdminSettingsForm()
        {
            InitializeComponent();
        }


        private void AdminSettingsForm_Load(object sender, EventArgs e)
        {
            LoadUsersList();
            cmbMaintenanceCategory.SelectedIndex = 0;
        }
        private void LoadUsersList()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT u.user_id AS 'User ID', 
                                            u.username AS 'Username', 
                                            u.email AS 'Email Address', 
                                            r.role_name AS 'Role'
                                     FROM Users u 
                                     INNER JOIN Roles r ON u.role_id = r.role_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbMaintenanceCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMaintenanceGrid();
            LoadMaintenanceData();
        }

        private void LoadMaintenanceData()
        {
            if (cmbMaintenanceCategory.SelectedItem == null) return;

            string category = cmbMaintenanceCategory.SelectedItem.ToString();
            string query = "";


            if (category == "Departments")
            {
                query = "SELECT department_id AS 'ID', department_name AS 'Department Name', description AS 'Description' FROM Departments";
            }
            else if (category == "Requirement Types")
            {
                query = "SELECT requirement_type_id AS 'ID', requirement_name AS 'Requirement Name', description AS 'Description' FROM RequirementTypes";
            }

            if (string.IsNullOrEmpty(query)) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMaintenanceValues.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text.Trim();
            string email = txtNewEmail.Text.Trim();
            string password = txtNewPassword.Text;


            if (cmbNewRole.SelectedItem == null || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields and select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRole = cmbNewRole.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string roleQuery = "SELECT role_id FROM Roles WHERE role_name = @roleName";
                    int roleId = 0;

                    using (MySqlCommand roleCmd = new MySqlCommand(roleQuery, conn))
                    {
                        roleCmd.Parameters.AddWithValue("@roleName", selectedRole);
                        object result = roleCmd.ExecuteScalar();

                        if (result != null)
                        {
                            roleId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Role not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }


                    string insertQuery = @"INSERT INTO Users (username, password_hash, email, role_id) 
                                           VALUES (@username, @password, @email, @roleId)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@roleId", roleId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    LoadUsersList();
                    ClearInputFields();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        MessageBox.Show("Username or Email is already taken.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            if (dgvUsers.SelectedRows.Count > 0)
            {

                int selectedUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["User ID"].Value);
                string selectedUsername = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete user '{selectedUsername}'?",
                                                            "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM Users WHERE user_id = @userId";

                            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@userId", selectedUserId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsersList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting user: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user from the list to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearInputFields()
        {
            txtNewUsername.Clear();
            txtNewEmail.Clear();
            txtNewPassword.Clear();
            cmbNewRole.SelectedIndex = -1;
        }

        private (string Table, string IdCol, string NameCol, string DescCol) GetDbMap()
        {
            string selection = cmbMaintenanceCategory.SelectedItem?.ToString() ?? "";

            switch (selection)
            {
                case "Departments":
                    return ("departments", "department_id", "department_name", "description");
                case "Requirement Types":
                    return ("requirementtypes", "requirement_type_id", "requirement_name", "description");
                case "Positions":
                    return ("positions", "position_id", "position_name", "description");
                case "Employment Types":
                    return ("employment_types", "employment_type_id", "employment_name", "description");
                case "Interview Types":
                    return ("interview_types", "interview_type_id", "interview_name", "description");
                case "Assessment Types":
                    return ("assessment_types", "assessment_type_id", "assessment_name", "description");
                default:
                    return ("", "", "", "");
            }
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            var map = GetDbMap();
            if (string.IsNullOrEmpty(map.Table)) return;

            if (string.IsNullOrWhiteSpace(txtRecordName.Text))
            {
                MessageBox.Show("Please enter a name for the record.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = $"INSERT INTO {map.Table} ({map.NameCol}, {map.DescCol}) VALUES (@name, @desc)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtRecordName.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", txtRecordDesc.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record added successfully!");
            txtRecordName.Clear();
            txtRecordDesc.Clear();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            var map = GetDbMap();
            if (string.IsNullOrEmpty(map.Table) || dgvMaintenanceValues.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an entire row to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string selectedId = dgvMaintenanceValues.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"DELETE FROM {map.Table} WHERE {map.IdCol} = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record deleted successfully!");

            }
        }
        private void LoadMaintenanceGrid()
        {
            var map = GetDbMap();
            if (string.IsNullOrEmpty(map.Table)) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = $"SELECT {map.IdCol} AS 'ID', {map.NameCol} AS 'Name', {map.DescCol} AS 'Description' FROM {map.Table}";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    dgvMaintenanceValues.Columns.Clear();


                    dgvMaintenanceValues.DataSource = dt;


                    if (dgvMaintenanceValues.Columns["Description"] != null)
                    {
                        dgvMaintenanceValues.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
