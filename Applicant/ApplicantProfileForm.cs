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
    public partial class ApplicantProfileForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        private int loggedInAccountId;
        private string selectedImagePath = ""; 

        public ApplicantProfileForm(int accountId)
        {
            InitializeComponent();
            loggedInAccountId = accountId;
        }

        public ApplicantProfileForm(string firstName, string lastName, string email, string address, int accountId)
        {
            InitializeComponent();
            loggedInAccountId = accountId;

            label1.Text = $"{firstName.ToUpper()} {lastName.ToUpper()}'S PROFILE";
            textBox1.Text = $"{firstName} {lastName}";
            textBox2.Text = email;
            textBox4.Text = address;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                pictureBox2.Image = new Bitmap(selectedImagePath);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                pictureBox2.Image = new Bitmap(selectedImagePath);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // BACK BUTTON (Triggers Auto-Draft Save)
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsProfileFormCompletelyEmpty())
                {
                    SaveDraftToFile();
                }
            }
            catch (Exception)
            {
               
            }

            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(loggedInAccountId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }

        // SAVE / SUBMIT FINAL PROFILE BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Full Name")
            {
                MessageBox.Show("Please enter your Full Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "Email")
            {
                MessageBox.Show("Please enter your Email Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "Contact No.")
            {
                MessageBox.Show("Please enter your Contact Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            if (!long.TryParse(textBox3.Text, out long dummy))
            {
                MessageBox.Show("Contact Number must contain numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            if (pictureBox2.Image == null)
            {
                MessageBox.Show("You need to upload a profile picture before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveDraftToFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Profile updated and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MyApplicationForm myApp = new MyApplicationForm(loggedInAccountId);
            myApp.StartPosition = FormStartPosition.CenterScreen;
            myApp.Show();
            this.Close();
        }

        // MANUAL DRAFT BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            if (IsProfileFormCompletelyEmpty())
            {
                MessageBox.Show("Nothing has changed or edited yet.", "Draft Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                SaveDraftToFile();
                MessageBox.Show("Progress saved as a draft!", "Draft Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ApplicantDashboardForm dashboard = new ApplicantDashboardForm(loggedInAccountId);
                dashboard.StartPosition = FormStartPosition.CenterScreen;
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving draft: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method 
        private bool IsProfileFormCompletelyEmpty()
        {
            return string.IsNullOrWhiteSpace(textBox1.Text) &&
                   string.IsNullOrWhiteSpace(textBox2.Text) &&
                   string.IsNullOrWhiteSpace(textBox3.Text) &&
                   string.IsNullOrWhiteSpace(textBox4.Text) &&
                   string.IsNullOrWhiteSpace(richTextBox1.Text) &&
                   string.IsNullOrWhiteSpace(richTextBox2.Text) &&
                   string.IsNullOrWhiteSpace(richTextBox3.Text) &&
                   pictureBox2.Image == null;
        }

        // CENTRALIZED SAVE METHOD
        private void SaveDraftToFile()
        {
            string fullName = textBox1.Text;
            string email = textBox2.Text;
            string contact = textBox3.Text;
            string address = textBox4.Text;             
            string education = richTextBox1.Text;       
            string otherDetails = richTextBox2.Text;     
            string workExperiences = richTextBox3.Text;  

           
            address = address.Replace("\r\n", " ").Replace("\n", " ");
            education = education.Replace("\r\n", " ").Replace("\n", " ");
            otherDetails = otherDetails.Replace("\r\n", " ").Replace("\n", " ");
            workExperiences = workExperiences.Replace("\r\n", " ").Replace("\n", " ");

            string draftLine = $"{fullName}|{email}|{contact}|{address}|{education}|{otherDetails}|{workExperiences}|{selectedImagePath}";
            string fileName = $"draft_{loggedInAccountId}.txt";

            System.IO.File.WriteAllText(fileName, draftLine);
        }

        // FORM LOAD EVENT
        private void ApplicantProfileForm_Load(object sender, EventArgs e)
        {
            string fileName = $"draft_{loggedInAccountId}.txt";
            bool successfullyLoadedFromDraft = false;

            if (System.IO.File.Exists(fileName))
            {
                try
                {
                    string draftData = System.IO.File.ReadAllText(fileName);

                    if (!string.IsNullOrWhiteSpace(draftData) && draftData.Replace("|", "").Trim().Length > 0)
                    {
                        string[] pieces = draftData.Split('|');

                        if (pieces.Length >= 7)
                        {
                            textBox1.Text = pieces[0];         // Full Name
                            textBox2.Text = pieces[1];         // Email
                            textBox3.Text = pieces[2];         // Contact No.
                            textBox4.Text = pieces[3];         // Address Field
                            richTextBox1.Text = pieces[4];     // Educational Attainments
                            richTextBox2.Text = pieces[5];     // Other Important Details Box
                            richTextBox3.Text = pieces[6];     // Work Experiences Box

                          
                            if (pieces.Length > 7 && !string.IsNullOrEmpty(pieces[7]) && System.IO.File.Exists(pieces[7]))
                            {
                                selectedImagePath = pieces[7];
                                pictureBox2.Image = new Bitmap(selectedImagePath);
                                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                            }

                            successfullyLoadedFromDraft = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading draft file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //No draft file exists
            if (!successfullyLoadedFromDraft)
            {
                string query = @"
                    SELECT a.first_name, a.last_name, a.contact_number, a.address, acc.email 
                    FROM Applicants a
                    INNER JOIN ApplicantAccounts acc ON a.account_id = acc.account_id
                    WHERE a.account_id = @accId";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@accId", loggedInAccountId);

                        try
                        {
                            conn.Open();
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string fName = reader["first_name"].ToString();
                                    string lName = reader["last_name"].ToString();

                                    textBox1.Text = $"{fName} {lName}";                 // Full Name Setup
                                    textBox3.Text = reader["contact_number"].ToString(); // Contact No. Setup
                                    textBox2.Text = reader["email"].ToString();          // Email Setup
                                    textBox4.Text = reader["address"].ToString();        // Address Field Setup

                                    label1.Text = $"{fName.ToUpper()} {lName.ToUpper()}'S PROFILE";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error pulling system registration records: {ex.Message}", "Database Sync Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // Unused layout stubs 
        private void label2_Click_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void richTextBox3_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
    }
}