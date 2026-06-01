
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace HRApplicantWindowSystem
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (cmbLoginType.SelectedItem == null)
            {
                MessageBox.Show("Please select a Login Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loginType = cmbLoginType.SelectedItem.ToString();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your credentials.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "";

                    if (loginType == "HR / Admin")
                    {
                        query = @"SELECT u.user_id, r.role_name 
                          FROM Users u 
                          INNER JOIN Roles r ON u.role_id = r.role_id 
                          WHERE u.username = @username AND u.password_hash = @password";
                    }
                    else if (loginType == "Applicant")
                    {
                        query = @"SELECT account_id, account_status 
                          FROM ApplicantAccounts 
                          WHERE email = @username AND password_hash = @password";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {

                                if (loginType == "HR / Admin")
                                {
                                    int userId = reader.GetInt32("user_id");
                                    string roleName = reader.GetString("role_name");


                                    this.Hide();


                                    HRDashboardForm dashboard = new HRDashboardForm(userId, roleName);
                                    dashboard.ShowDialog();


                                    this.Show();
                                }
                                else if (loginType == "Applicant")
                                {
                                    int accountId = reader.GetInt32("account_id");
                                    string status = reader.GetString("account_status");

                                    if (status == "Active")
                                    {
                                        MessageBox.Show($"Welcome Applicant! (ID: {accountId})", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();


            ApplicantRegisterForm registerForm = new ApplicantRegisterForm();
            registerForm.ShowDialog();

            this.Show();
        }
    }
}