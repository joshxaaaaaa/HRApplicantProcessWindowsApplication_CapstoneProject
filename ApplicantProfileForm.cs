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
        private int loggedInAccountId;

        // 1. Update Plain constructor
        public ApplicantProfileForm(int accountId)
        {
            InitializeComponent();
            loggedInAccountId = accountId;
        }

        // 2. Update Data constructor 
        public ApplicantProfileForm(string firstName, string lastName, string email, string address, int accountId)
        {
            InitializeComponent();
            loggedInAccountId = accountId;

            label1.Text = $"{firstName.ToUpper()} {lastName.ToUpper()}'S PROFILE";
            textBox1.Text = $"{firstName} {lastName}";
            textBox2.Text = email;
            textBox3.Text = address;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog.FileName);

                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if (pictureBox2.Image == null)
            {
                MessageBox.Show("You need to upload a profile picture before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e) // add/change picture click
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog.FileName);

                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e) // Back click - direct to Applicant Dashboard
        {
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(loggedInAccountId);

            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e) // Save Click - direct to My Appplication page
        {
            // 1. Validate Full Name (textBox1)
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Full Name")
            {
                MessageBox.Show("Please enter your Full Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            // 2. Validate Email (textBox2)
            if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "Email")
            {
                MessageBox.Show("Please enter your Email Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            // 3. Validate Contact Number (textBox3) - Check if empty
            if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "Contact No.")
            {
                MessageBox.Show("Please enter your Contact Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            // 4. Validate Contact Number (textBox3) - Check if numeric digits only
            if (!long.TryParse(textBox3.Text, out long dummy))
            {
                MessageBox.Show("Contact Number must contain numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            // 5. Validate Address (richTextBox2)
            if (string.IsNullOrWhiteSpace(richTextBox2.Text) || richTextBox2.Text == "Address")
            {
                MessageBox.Show("Please enter your Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                richTextBox2.Focus();
                return;
            }

            // 6. Validate Profile Picture Box Selection
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("You need to upload a profile picture before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string fullName = textBox1.Text;
                string email = textBox3.Text;
                string contact = textBox2.Text;
                string address = richTextBox2.Text;

                string updatedData = $"{fullName}|{email}|{contact}|{address}";
                string fileName = $"draft_{loggedInAccountId}.txt";
                System.IO.File.WriteAllText(fileName, updatedData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Profile updated and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open MyApplication window layout by passing the account ID
            MyApplicationForm myApp = new MyApplicationForm(loggedInAccountId);
            myApp.StartPosition = FormStartPosition.CenterScreen;
            myApp.Show();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Capture data even if incomplete
                string fullName = textBox1.Text;
                string email = textBox3.Text;
                string contact = textBox2.Text;
                string address = richTextBox2.Text;

                string draftLine = $"{fullName}|{email}|{contact}|{address}";
                string fileName = $"draft_{loggedInAccountId}.txt";

                // Save to file
                System.IO.File.WriteAllText(fileName, draftLine);

                MessageBox.Show("Progress saved as a draft!", "Draft Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to Dashboard
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

        private void ApplicantProfileForm_Load(object sender, EventArgs e) // empty load event handler to prevent errors when loading the form
        {
            string fileName = $"draft_{loggedInAccountId}.txt";

            // Check if a draft file exists for this logged-in user
            if (System.IO.File.Exists(fileName))
            {
                try
                {
                    // 1. Read the hidden line 
                    string draftData = System.IO.File.ReadAllText(fileName);

                    // 2. Split the text line 
                    string[] pieces = draftData.Split('|');

                    // 3. Put the pieces back 
                    if (pieces.Length >= 4)
                    {
                        textBox1.Text = pieces[0];      // Full Name
                        textBox3.Text = pieces[1];      // Email
                        textBox2.Text = pieces[2];      // Contact No.
                        richTextBox2.Text = pieces[3];  // Address
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading draft: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
       
    }
}
