
using MySql.Data.MySqlClient; 
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantWindowSystem
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";

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

                                    txtUsername.Clear();
                                    txtPassword.Clear();
                                    this.Show();
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

                                        txtUsername.Clear();
                                        txtPassword.Clear();
                                        this.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            button2.Visible = false;       
            button3.Visible = true;         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            button3.Visible = false;        
            button2.Visible = true;          
        }

        private void pnlRoleSelection_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }


    }
}
