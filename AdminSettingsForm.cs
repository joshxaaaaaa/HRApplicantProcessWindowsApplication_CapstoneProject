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
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql ;";
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

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (cmbMaintenanceCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category from the dropdown first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string category = cmbMaintenanceCategory.SelectedItem.ToString();
            string newValue = txtNewValue.Text.Trim();

            if (string.IsNullOrEmpty(newValue))
            {
                MessageBox.Show("Please enter a value to add.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "";

                    if (category == "Departments")
                    {
                        query = "INSERT INTO Departments (department_name, description) VALUES (@val, 'Added via Admin Configuration Panel')";
                    }
                    else if (category == "Requirement Types")
                    {
                        query = "INSERT INTO RequirementTypes (requirement_name, description) VALUES (@val, 'Added via Admin Configuration Panel')";
                    }
                    else
                    {
                        MessageBox.Show("Table setup for this category is currently pending.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@val", newValue);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"'{newValue}' was successfully added to {category}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtNewValue.Clear();
                    LoadMaintenanceData();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) 
                        MessageBox.Show("This exact record already exists in the system.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
