using HRApplicantWindowSystem.Applicant;
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
        private int currentApplicantId = 0;
        private string selectedImagePath = "";

        public bool isHRView = false;
        public int hrApplicantId = 0;

        public static string draftEdu = null;
        public static string draftWork = null;
        public static string draftOther = null;

        public ApplicantProfileForm(int accountId)
        {
            InitializeComponent();
            loggedInAccountId = accountId;
            isHRView = false;
            btnChangePassword.Visible = true;
            SetEditable(false);
        }

        public ApplicantProfileForm(int applicantId, bool fromHR)
        {
            InitializeComponent();
            hrApplicantId = applicantId;
            isHRView = fromHR;
            SetEditable(false);
        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SetEditable(true);
        }

        private void SetEditable(bool editable)
        {

            textBox1.ReadOnly = !editable;
            textBox2.ReadOnly = !editable;
            textBox3.ReadOnly = !editable;
            textBox4.ReadOnly = !editable;


            txtEducation.ReadOnly = !editable;
            txtWorkExp.ReadOnly = !editable;
            txtOtherDetails.ReadOnly = !editable;


            button1.Enabled = editable;


            button3.Enabled = editable;


        }


        public void SetLocked(bool locked)
        {
            if (locked)
            {

                try { SetEditable(false); } catch { }
            }


            try { buttonEdit.Visible = !locked; } catch { }
            try { button1.Enabled = !locked; } catch { }
            try { button3.Enabled = !locked; } catch { }


            try { textBox1.ReadOnly = locked; textBox1.Enabled = !locked; } catch { }
            try { textBox2.ReadOnly = locked; textBox2.Enabled = !locked; } catch { }
            try { textBox3.ReadOnly = locked; textBox3.Enabled = !locked; } catch { }
            try { textBox4.ReadOnly = locked; textBox4.Enabled = !locked; } catch { }
            try { txtEducation.ReadOnly = locked; txtEducation.Enabled = !locked; } catch { }
            try { txtWorkExp.ReadOnly = locked; txtWorkExp.Enabled = !locked; } catch { }
            try { txtOtherDetails.ReadOnly = locked; txtOtherDetails.Enabled = !locked; } catch { }
            try { pictureBox2.Enabled = !locked; } catch { }
        }

        private Image LoadImageSafely(string path)
        {
            try
            {

                using (var fs = System.IO.File.OpenRead(path))
                {
                    Image img = Image.FromStream(fs);
                    return new Bitmap(img);
                }
            }
            catch
            {
                return null;
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                var img = LoadImageSafely(selectedImagePath);
                if (pictureBox2.Image != null) { pictureBox2.Image.Dispose(); }
                pictureBox2.Image = img;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }


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

            this.Close();
        }


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
                SaveProfileToDatabase();
                SaveExtendedProfileToDatabase();
                LogAuditAction(loggedInAccountId, "Profile Update", "applicants", currentApplicantId, "Applicant successfully updated their personal profile and requirements.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Profile updated and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            try
            {
                SetEditable(false);
            }
            catch { }


        }

        private void SaveProfileToDatabase()
        {
            string fullName = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string contact = textBox3.Text.Trim();
            string address = textBox4.Text.Trim();


            string firstName = fullName, lastName = "";
            if (!string.IsNullOrWhiteSpace(fullName))
            {
                var parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length >= 2)
                {
                    firstName = parts[0];
                    lastName = string.Join(' ', parts, 1, parts.Length - 1);
                }
                else
                {
                    firstName = fullName;
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlTransaction tx = conn.BeginTransaction())
                {
                    try
                    {

                        string updAcc = "UPDATE ApplicantAccounts SET email = @email WHERE account_id = @accId";
                        using (MySqlCommand cmdAcc = new MySqlCommand(updAcc, conn, tx))
                        {
                            cmdAcc.Parameters.AddWithValue("@email", email);
                            cmdAcc.Parameters.AddWithValue("@accId", loggedInAccountId);
                            cmdAcc.ExecuteNonQuery();
                        }


                        string checkSql = "SELECT COUNT(*) FROM Applicants WHERE account_id = @accId";
                        int count = 0;
                        using (MySqlCommand cmdCheck = new MySqlCommand(checkSql, conn, tx))
                        {
                            cmdCheck.Parameters.AddWithValue("@accId", loggedInAccountId);
                            count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                        }

                        if (count > 0)
                        {
                            string upd = @"UPDATE Applicants SET first_name = @firstName, last_name = @lastName, contact_number = @contact, address = @address, resume_url = @resume WHERE account_id = @accId";
                            using (MySqlCommand cmd = new MySqlCommand(upd, conn, tx))
                            {
                                cmd.Parameters.AddWithValue("@firstName", firstName);
                                cmd.Parameters.AddWithValue("@lastName", lastName);
                                cmd.Parameters.AddWithValue("@contact", contact);
                                cmd.Parameters.AddWithValue("@address", address);
                                cmd.Parameters.AddWithValue("@resume", selectedImagePath ?? string.Empty);
                                cmd.Parameters.AddWithValue("@accId", loggedInAccountId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string ins = @"INSERT INTO Applicants (account_id, first_name, last_name, contact_number, address, resume_url) VALUES (@accId, @firstName, @lastName, @contact, @address, @resume)";
                            using (MySqlCommand cmd = new MySqlCommand(ins, conn, tx))
                            {
                                cmd.Parameters.AddWithValue("@accId", loggedInAccountId);
                                cmd.Parameters.AddWithValue("@firstName", firstName);
                                cmd.Parameters.AddWithValue("@lastName", lastName);
                                cmd.Parameters.AddWithValue("@contact", contact);
                                cmd.Parameters.AddWithValue("@address", address);
                                cmd.Parameters.AddWithValue("@resume", selectedImagePath ?? string.Empty);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tx.Commit();


                        try
                        {
                            string getApplicantIdSql = "SELECT applicant_id FROM Applicants WHERE account_id = @accId LIMIT 1";
                            using (MySqlCommand gcmd = new MySqlCommand(getApplicantIdSql, conn))
                            {
                                gcmd.Parameters.AddWithValue("@accId", loggedInAccountId);
                                var result = gcmd.ExecuteScalar();
                                if (result != null && int.TryParse(result.ToString(), out int aid))
                                {
                                    currentApplicantId = aid;
                                }
                            }
                        }
                        catch { }


                        try
                        {
                            string fileName = System.IO.Path.Combine(Application.StartupPath, $"draft_{loggedInAccountId}.txt");
                            if (System.IO.File.Exists(fileName)) System.IO.File.Delete(fileName);
                        }
                        catch { }
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }


        private void SaveExtendedProfileToDatabase()
        {
            if (currentApplicantId <= 0)
            {

                SaveProfileToDatabase();
                if (currentApplicantId <= 0) return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string upsert = @"
                        INSERT INTO applicant_profiles (applicant_id, educational_attainments, work_experiences, other_details)
                        VALUES (@aid, @edu, @work, @other)
                        ON DUPLICATE KEY UPDATE educational_attainments = VALUES(educational_attainments), work_experiences = VALUES(work_experiences), other_details = VALUES(other_details);
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(upsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@aid", currentApplicantId);
                        cmd.Parameters.AddWithValue("@edu", txtEducation.Text.Trim());
                        cmd.Parameters.AddWithValue("@work", txtWorkExp.Text.Trim());
                        cmd.Parameters.AddWithValue("@other", txtOtherDetails.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving extended profile: " + ex.Message);
                }
            }
        }




        private bool IsProfileFormCompletelyEmpty()
        {
            return string.IsNullOrWhiteSpace(textBox1.Text) &&
                   string.IsNullOrWhiteSpace(textBox2.Text) &&
                   string.IsNullOrWhiteSpace(textBox3.Text) &&
                   string.IsNullOrWhiteSpace(textBox4.Text) &&
                   string.IsNullOrWhiteSpace(txtEducation.Text) &&
                   string.IsNullOrWhiteSpace(txtOtherDetails.Text) &&
                   string.IsNullOrWhiteSpace(txtWorkExp.Text) &&
                   pictureBox2.Image == null;
        }


        private void SaveDraftToFile()
        {
            try
            {
                string fileName = System.IO.Path.Combine(Application.StartupPath, $"draft_{loggedInAccountId}.txt");

                string fullName = textBox1.Text.Trim();
                string email = textBox2.Text.Trim();
                string contact = textBox3.Text.Trim();
                string address = textBox4.Text.Trim();
                string education = txtEducation.Text.Trim();
                string otherDetails = txtOtherDetails.Text.Trim();
                string workExperiences = txtWorkExp.Text.Trim();

                address = address.Replace("\r\n", " ").Replace("\n", " ");
                education = education.Replace("\r\n", " ").Replace("\n", " ");
                otherDetails = otherDetails.Replace("\r\n", " ").Replace("\n", " ");
                workExperiences = workExperiences.Replace("\r\n", " ").Replace("\n", " ");

                string data = string.Join("|", new string[] {
                    fullName,
                    email,
                    contact,
                    address,
                    education,
                    otherDetails,
                    workExperiences,
                    selectedImagePath ?? string.Empty
                });

                System.IO.File.WriteAllText(fileName, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving draft file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ApplicantProfileForm_Load(object sender, EventArgs e)
        {

            if (isHRView)
            {

                try { buttonEdit.Visible = false; } catch { }
                try { button3.Visible = false; } catch { }
                try { button1.Visible = false; } catch { }
                try { btnChangePassword.Visible = false; } catch { }
            }
            else
            {
                if (draftEdu != null || draftWork != null || draftOther != null)
                {
                    txtEducation.Text = draftEdu;
                    txtWorkExp.Text = draftWork;
                    txtOtherDetails.Text = draftOther;
                }
            }

            string fileName = $"draft_{loggedInAccountId}.txt";
            bool successfullyLoadedFromDraft = false;
            bool loadedFromDb = false;


            string query = isHRView
                ? @"SELECT a.applicant_id, a.first_name, a.last_name, a.contact_number, a.address, acc.email, COALESCE(a.resume_url, '') AS resume_url 
                        FROM Applicants a 
                        INNER JOIN ApplicantAccounts acc ON a.account_id = acc.account_id 
                        WHERE a.applicant_id = @searchId"

                            : @"SELECT a.applicant_id, a.first_name, a.last_name, a.contact_number, a.address, acc.email, COALESCE(a.resume_url, '') AS resume_url 
                        FROM Applicants a 
                        INNER JOIN ApplicantAccounts acc ON a.account_id = acc.account_id 
                        WHERE a.account_id = @searchId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@searchId", isHRView ? hrApplicantId : loggedInAccountId);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fName = reader["first_name"].ToString();
                                string lName = reader["last_name"].ToString();

                                textBox1.Text = $"{fName} {lName}";
                                textBox3.Text = reader["contact_number"].ToString();
                                textBox2.Text = reader["email"].ToString();
                                textBox4.Text = reader["address"].ToString();

                                currentApplicantId = reader.GetInt32("applicant_id");
                                string resumePath = reader["resume_url"].ToString();

                                if (!string.IsNullOrWhiteSpace(resumePath) && System.IO.File.Exists(resumePath))
                                {
                                    selectedImagePath = resumePath;
                                    try
                                    {
                                        var img = LoadImageSafely(selectedImagePath);
                                        if (pictureBox2.Image != null) { pictureBox2.Image.Dispose(); }
                                        pictureBox2.Image = img;
                                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                                    }
                                    catch { }
                                }

                                loadedFromDb = true;


                                LoadProfileFromDatabase(currentApplicantId);
                                successfullyLoadedFromDraft = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error pulling system registration records: {ex.Message}", "Database Sync Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    SetEditable(false);
                }
            }


            if (!isHRView && !loadedFromDb && System.IO.File.Exists(fileName))
            {
                try
                {
                    string draftData = System.IO.File.ReadAllText(fileName);

                    if (!string.IsNullOrWhiteSpace(draftData) && draftData.Replace("|", "").Trim().Length > 0)
                    {
                        string[] pieces = draftData.Split('|');

                        if (pieces.Length >= 7)
                        {
                            textBox1.Text = pieces[0];
                            textBox2.Text = pieces[1];
                            textBox3.Text = pieces[2];
                            textBox4.Text = pieces[3];
                            txtEducation.Text = pieces[4];
                            txtOtherDetails.Text = pieces[5];
                            txtWorkExp.Text = pieces[6];

                            if (pieces.Length > 7 && !string.IsNullOrEmpty(pieces[7]) && System.IO.File.Exists(pieces[7]))
                            {
                                selectedImagePath = pieces[7];
                                try
                                {
                                    var img = LoadImageSafely(selectedImagePath);
                                    if (pictureBox2.Image != null) { pictureBox2.Image.Dispose(); }
                                    pictureBox2.Image = img;
                                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                                catch { }
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
        }
        private void LoadProfileFromDatabase(int applicantId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT educational_attainments, work_experiences, other_details FROM applicant_profiles WHERE applicant_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", applicantId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtEducation.Text = reader["educational_attainments"].ToString();
                                txtWorkExp.Text = reader["work_experiences"].ToString();
                                txtOtherDetails.Text = reader["other_details"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile: " + ex.Message);
                }
            }
        }
        private void LogAuditAction(int userId, string actionType, string tableAffected, int recordId, string details)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO audittrail 
                           (user_id, action_type, table_affected, record_id, details, action_timestamp) 
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
                catch (Exception ex)
                {

                    Console.WriteLine("Audit Log Error: " + ex.Message);
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm passForm = new ChangePasswordForm(loggedInAccountId);
            passForm.StartPosition = FormStartPosition.CenterScreen;

            this.Hide();
            passForm.ShowDialog();
            this.Show();
        }
    }
}