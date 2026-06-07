
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace HRApplicantWindowSystem
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=#Sheena003;";

        private string selectedRole = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            pnlRoleSelection.Visible = true;
            pnlLoginInputs.Visible = false;
        }

        private void btnRoleApplicant_Click(object sender, EventArgs e)
        {
            selectedRole = "Applicant";
            SwitchToLoginView(true);
        }

        private void btnRoleHR_Click(object sender, EventArgs e)
        {
            selectedRole = "HR/Admin";
            SwitchToLoginView(false);
        }

        private void SwitchToLoginView(bool allowRegistration)
        {
            pnlRoleSelection.Visible = false;
            pnlLoginInputs.Visible = true;


            btnCreateAccount.Visible = allowRegistration;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            txtUsername.Clear();
            txtPassword.Clear();
            pnlRoleSelection.Visible = true;
            pnlLoginInputs.Visible = false;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
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


                    if (selectedRole == "HR/Admin")
                    {
                        query = @"SELECT u.user_id, r.role_name 
                                  FROM Users u 
                                  INNER JOIN Roles r ON u.role_id = r.role_id 
                                  WHERE u.username = @username AND u.password_hash = @password";
                    }
                    else if (selectedRole == "Applicant")
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
                                if (selectedRole == "HR/Admin")
                                {
                                    int userId = reader.GetInt32("user_id");
                                    string roleName = reader.GetString("role_name");

                                    this.Hide();
                                    HRDashboardForm dashboard = new HRDashboardForm(userId, roleName);
                                    dashboard.ShowDialog();
                                    this.Show();

                                    btnBack_Click(null, null);
                                }
                                else if (selectedRole == "Applicant")
                                {
                                    int accountId = reader.GetInt32("account_id");
                                    string status = reader.GetString("account_status");

                                    if (status == "Active")
                                    {
                                        this.Hide();
                                        ApplicantDashboardForm appDashboard = new ApplicantDashboardForm(accountId);
                                        appDashboard.ShowDialog();
                                        this.Show();
                                        btnBack_Click(null, null);
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

        private void pnlRoleSelection_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
