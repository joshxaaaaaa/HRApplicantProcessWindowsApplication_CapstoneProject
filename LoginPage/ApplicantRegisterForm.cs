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
    public partial class ApplicantRegisterForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        public ApplicantRegisterForm()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("First Name, Last Name, Email, and Password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertAccountQuery = @"
                                INSERT INTO ApplicantAccounts (email, password_hash, account_status) 
                                VALUES (@email, @password, 'Active');
                                SELECT LAST_INSERT_ID();";

                            int newAccountId = 0;
                            using (MySqlCommand cmdAcc = new MySqlCommand(insertAccountQuery, conn, transaction))
                            {
                                cmdAcc.Parameters.AddWithValue("@email", email);
                                cmdAcc.Parameters.AddWithValue("@password", password);


                                newAccountId = Convert.ToInt32(cmdAcc.ExecuteScalar());
                            }

                            string insertProfileQuery = @"
                                INSERT INTO Applicants (account_id, first_name, last_name, contact_number, address) 
                                VALUES (@accountId, @firstName, @lastName, @contact, @address);";

                            using (MySqlCommand cmdProf = new MySqlCommand(insertProfileQuery, conn, transaction))
                            {
                                cmdProf.Parameters.AddWithValue("@accountId", newAccountId);
                                cmdProf.Parameters.AddWithValue("@firstName", firstName);
                                cmdProf.Parameters.AddWithValue("@lastName", lastName);
                                cmdProf.Parameters.AddWithValue("@contact", contact);
                                cmdProf.Parameters.AddWithValue("@address", address);

                                cmdProf.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {

                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
                catch (MySqlException sqlEx)
                {

                    if (sqlEx.Number == 1062)
                    {
                        MessageBox.Show("This email is already registered. Please log in or use a different email.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Database error: " + sqlEx.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
