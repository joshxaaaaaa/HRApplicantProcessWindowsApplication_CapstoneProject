using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Exceptions;

// iText7 Core Component Namespaces
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantWindowSystem
{
    public partial class ApplicantProfileForm : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql ;";
        private int loggedInAccountId;
        private const string SplitDelimiter = "===PENTANODE_SPLIT===";

        // Tracks fields 
        private string originalFullName = "";
        private string originalEmail = "";
        private string originalContact = "";
        private string originalAddress = "";
        private string originalEducation = "";
        private string originalWorkExp = "";
        private string originalOther = "";
        private string originalPhoto = "";


        public ApplicantProfileForm(int accountId)
        {
            InitializeComponent();
            loggedInAccountId = accountId;
        }

        private void ApplicantProfileForm_Load(object sender, EventArgs e)
        {
            LoadRegistrationDataFromDatabase();
            LoadExistingDraft();
        }

        private void LoadRegistrationDataFromDatabase()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT a.first_name, a.last_name, a.contact_number, a.address, acc.email 
                        FROM applicants a
                        INNER JOIN applicantaccounts acc ON a.account_id = acc.account_id
                        WHERE a.account_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", loggedInAccountId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["first_name"].ToString();
                                string lastName = reader["last_name"].ToString();

                                // UI Controls
                                textBox1.Text = $"{firstName} {lastName}";
                                textBox3.Text = reader["email"].ToString();
                                textBox2.Text = reader["contact_number"].ToString();
                                textBox4.Text = reader["address"].ToString();

                                TrackOriginalValues();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading database profiles: {ex.Message}", "Database Sync Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TrackOriginalValues()
        {
            originalFullName = textBox1.Text.Trim();
            originalEmail = textBox3.Text.Trim();
            originalContact = textBox2.Text.Trim();
            originalAddress = textBox4.Text.Trim();
            originalEducation = richTextBox1.Text.Trim();
            originalWorkExp = richTextBox3.Text.Trim();
            originalOther = richTextBox2.Text.Trim();
            originalPhoto = pictureBox2.ImageLocation ?? "";
        }

        private void LoadExistingDraft()
        {
            string fileName = $"draft_{loggedInAccountId}.txt";

            if (System.IO.File.Exists(fileName))
            {
                try
                {
                    string draftData = System.IO.File.ReadAllText(fileName);

                    if (draftData.Contains(SplitDelimiter))
                    {
                        string[] pieces = draftData.Split(new string[] { SplitDelimiter }, StringSplitOptions.None);

                        if (pieces.Length >= 8)
                        {
                            if (!string.IsNullOrEmpty(pieces[0])) textBox1.Text = pieces[0];
                            if (!string.IsNullOrEmpty(pieces[1])) textBox3.Text = pieces[1];
                            if (!string.IsNullOrEmpty(pieces[2])) textBox2.Text = pieces[2];
                            if (!string.IsNullOrEmpty(pieces[3])) textBox4.Text = pieces[3];
                            richTextBox1.Text = pieces[4];
                            richTextBox3.Text = pieces[5];
                            richTextBox2.Text = pieces[6];

                            string savedPhotoPath = pieces[7];
                            if (!string.IsNullOrEmpty(savedPhotoPath) && System.IO.File.Exists(savedPhotoPath))
                            {
                                pictureBox2.ImageLocation = savedPhotoPath;
                                pictureBox2.Load(savedPhotoPath);
                                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                            }

                            TrackOriginalValues();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading draft file elements: {ex.Message}", "Draft Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void HandleImageUpload()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.ImageLocation = openFileDialog.FileName;
                    pictureBox2.Load(openFileDialog.FileName);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) => HandleImageUpload();
        private void button1_Click(object sender, EventArgs e) => HandleImageUpload();

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(loggedInAccountId);
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();
        }

        // --- BUTTON 3: SUBMIT / SAVE TO PROFILE (MySQL & PDF Export) ---
        private void button3_Click(object sender, EventArgs e)
        {
            // Form Validations
            if (string.IsNullOrWhiteSpace(textBox1.Text)) { MessageBox.Show("Please enter your Full Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); textBox1.Focus(); return; }
            if (string.IsNullOrWhiteSpace(textBox3.Text)) { MessageBox.Show("Please enter your Email Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); textBox3.Focus(); return; }
            if (string.IsNullOrWhiteSpace(textBox2.Text)) { MessageBox.Show("Please enter your Contact Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); textBox2.Focus(); return; }
            if (!long.TryParse(textBox2.Text, out _)) { MessageBox.Show("Contact Number must contain numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); textBox2.Focus(); return; }
            if (string.IsNullOrWhiteSpace(textBox4.Text)) { MessageBox.Show("Please enter your Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); textBox4.Focus(); return; }
            if (string.IsNullOrEmpty(pictureBox2.ImageLocation)) { MessageBox.Show("You need to upload a profile picture before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string fullName = textBox1.Text.Trim();
            string email = textBox3.Text.Trim();
            string contact = textBox2.Text.Trim();
            string address = textBox4.Text.Trim();
            string education = richTextBox1.Text.Trim();
            string workExperience = richTextBox3.Text.Trim();
            string otherDetails = richTextBox2.Text.Trim();
            string photoPath = pictureBox2.ImageLocation;

            // FILE PATH 
            
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string resumeDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resumes");
            if (!Directory.Exists(resumeDir)) Directory.CreateDirectory(resumeDir);

            string cleanNameForFile = fullName.Replace(" ", "_");
            string pdfPath = Path.Combine(resumeDir, $"Resume_{cleanNameForFile}_{timestamp}.pdf");

            try
            {
                GenerateResumePDF(pdfPath, fullName, email, contact, address, education, workExperience, otherDetails, photoPath);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        UPDATE applicants 
                        SET resume_url = @pdf 
                        WHERE account_id = @accId;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pdf", pdfPath);
                        cmd.Parameters.AddWithValue("@accId", loggedInAccountId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Profile successfully processed and PDF Resume created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MyApplicationForm myApp = new MyApplicationForm(loggedInAccountId);
                myApp.StartPosition = FormStartPosition.CenterScreen;
                myApp.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Submission execution failure: {ex.Message}", "Database/PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- BUTTON 4: SAVE DRAFT (With Evolution Logic Checks) ---
        private void button4_Click(object sender, EventArgs e)
        {
            string currentFullName = textBox1.Text.Trim();
            string currentEmail = textBox3.Text.Trim();
            string currentContact = textBox2.Text.Trim();
            string currentAddress = textBox4.Text.Trim();
            string currentEducation = richTextBox1.Text.Trim();
            string currentWorkExp = richTextBox3.Text.Trim();
            string currentOther = richTextBox2.Text.Trim();
            string currentPhoto = pictureBox2.ImageLocation ?? "";

            
            if (currentFullName == originalFullName &&
                currentEmail == originalEmail &&
                currentContact == originalContact &&
                currentAddress == originalAddress &&
                currentEducation == originalEducation &&
                currentWorkExp == originalWorkExp &&
                currentOther == originalOther &&
                currentPhoto == originalPhoto)
            {
                MessageBox.Show("No new updates detected from your loaded profile parameters.", "No Changes Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ApplicantDashboardForm exitDashboard = new ApplicantDashboardForm(loggedInAccountId);
                exitDashboard.StartPosition = FormStartPosition.CenterScreen;
                exitDashboard.Show();
                this.Close();
                return;
            }

            try
            {
                string[] draftData = new string[] { currentFullName, currentEmail, currentContact, currentAddress, currentEducation, currentWorkExp, currentOther, currentPhoto };
                string draftContent = string.Join(SplitDelimiter, draftData);
                string fileName = $"draft_{loggedInAccountId}.txt";

                System.IO.File.WriteAllText(fileName, draftContent);
                MessageBox.Show("All changes saved safely to your local draft folder!", "Draft Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ApplicantDashboardForm dashboard = new ApplicantDashboardForm(loggedInAccountId);
                dashboard.StartPosition = FormStartPosition.CenterScreen;
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving draft configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- CORE ENGINE: iTEXT7 PDF RESUME GENERATOR ---
        private void GenerateResumePDF(string filePath, string name, string email, string contact, string address, string edu, string work, string details, string imgPath)
        {
            try
            {
                // SAVE DIRECTORY 
                string directory = System.IO.Path.GetDirectoryName(filePath);
                if (!string.IsNullOrEmpty(directory) && !System.IO.Directory.Exists(directory))
                {
                    System.IO.Directory.CreateDirectory(directory);
                }

                // INITIALIZE iTEXT7 WRITERS AND DOCUMENT LAYER
                using (iText.Kernel.Pdf.PdfWriter writer = new iText.Kernel.Pdf.PdfWriter(filePath))
                using (iText.Kernel.Pdf.PdfDocument pdf = new iText.Kernel.Pdf.PdfDocument(writer))
                using (iText.Layout.Document document = new iText.Layout.Document(pdf))
                {
                    
                    iText.Layout.Element.Paragraph companyHeader = new iText.Layout.Element.Paragraph("PENTANODE NETWORK AND SYSTEMS CO.")
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetFontSize(18)
                        .SetFontColor(iText.Kernel.Colors.ColorConstants.DARK_GRAY);
                    document.Add(companyHeader);

                    iText.Layout.Element.Paragraph docTitle = new iText.Layout.Element.Paragraph("JOB APPLICANT RESUME")
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetFontSize(14)
                        .SetMarginBottom(20);
                    document.Add(docTitle);

                   
                    iText.Layout.Element.Table mainLayoutTable = new iText.Layout.Element.Table(iText.Layout.Properties.UnitValue.CreatePercentArray(new float[] { 75, 25 }))
                        .SetWidth(iText.Layout.Properties.UnitValue.CreatePercentValue(100));

                
                    iText.Layout.Element.Cell textCell = new iText.Layout.Element.Cell().SetBorder(iText.Layout.Borders.Border.NO_BORDER);
                    textCell.Add(new iText.Layout.Element.Paragraph($"Full Name: {name}").SetFontSize(12));
                    textCell.Add(new iText.Layout.Element.Paragraph($"Email: {email}").SetFontSize(11));
                    textCell.Add(new iText.Layout.Element.Paragraph($"Contact No.: {contact}").SetFontSize(11));
                    textCell.Add(new iText.Layout.Element.Paragraph($"Address: {address}").SetFontSize(11));
                    mainLayoutTable.AddCell(textCell);

                
                    iText.Layout.Element.Cell imageCell = new iText.Layout.Element.Cell().SetBorder(iText.Layout.Borders.Border.NO_BORDER);

                    
                    if (!string.IsNullOrEmpty(imgPath) && System.IO.File.Exists(imgPath))
                    {
                        try
                        {
                            iText.IO.Image.ImageData imageData = iText.IO.Image.ImageDataFactory.Create(imgPath);
                            iText.Layout.Element.Image profileImg = new iText.Layout.Element.Image(imageData);
                            profileImg.SetWidth(90);
                            profileImg.SetHeight(90);
                            profileImg.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT);
                            imageCell.Add(profileImg);
                        }
                        catch (Exception)
                        {
                            imageCell.Add(new iText.Layout.Element.Paragraph("[Image Error]").SetFontSize(10));
                        }
                    }
                    else
                    {
                        imageCell.Add(new iText.Layout.Element.Paragraph("[No Photo]").SetFontSize(10));
                    }

                    mainLayoutTable.AddCell(imageCell);
                    document.Add(mainLayoutTable);

                    // --- SEPARATOR BREAK ---
                    document.Add(new iText.Layout.Element.Paragraph("\n").SetFontSize(5));

                    // --- WORK EXPERIENCE SECTION ---
                    document.Add(new iText.Layout.Element.Paragraph("WORK EXPERIENCES").SetFontSize(12).SetUnderline());
                    document.Add(new iText.Layout.Element.Paragraph(string.IsNullOrEmpty(work) ? "No experience provided." : work).SetFontSize(11).SetMarginBottom(15));

                    // --- OTHER ADDITIONAL DETAILS ---
                    document.Add(new iText.Layout.Element.Paragraph("OTHER IMPORTANT DETAILS").SetFontSize(12).SetUnderline());
                    document.Add(new iText.Layout.Element.Paragraph(string.IsNullOrEmpty(details) ? "None." : details).SetFontSize(11));
                }
            }
            catch (iText.Kernel.Exceptions.PdfException pdfEx)
            {
                MessageBox.Show($"iText PDF Engine Error: {pdfEx.Message}\nMake sure the target file isn't open in another program.", "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Submission execution failure: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void richTextBox3_TextChanged(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
    }
}