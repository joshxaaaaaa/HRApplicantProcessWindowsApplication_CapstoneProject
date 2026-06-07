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

        private void button1_Click(object sender, EventArgs e) 
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog.FileName);

                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(loggedInAccountId);

            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
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


            if (string.IsNullOrWhiteSpace(richTextBox2.Text) || richTextBox2.Text == "Address")
            {
                MessageBox.Show("Please enter your Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                richTextBox2.Focus();
                return;
            }


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


            MyApplicationForm myApp = new MyApplicationForm(loggedInAccountId);
            myApp.StartPosition = FormStartPosition.CenterScreen;
            myApp.Show();
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string fullName = textBox1.Text;
                string email = textBox3.Text;
                string contact = textBox2.Text;
                string address = richTextBox2.Text;

                string draftLine = $"{fullName}|{email}|{contact}|{address}";
                string fileName = $"draft_{loggedInAccountId}.txt";


                System.IO.File.WriteAllText(fileName, draftLine);

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

        private void ApplicantProfileForm_Load(object sender, EventArgs e) 
        {
            string fileName = $"draft_{loggedInAccountId}.txt";

       
            if (System.IO.File.Exists(fileName))
            {
                try
                {

                    string draftData = System.IO.File.ReadAllText(fileName);

                    string[] pieces = draftData.Split('|');

                    if (pieces.Length >= 4)
                    {
                        textBox1.Text = pieces[0];      
                        textBox3.Text = pieces[1];      
                        textBox2.Text = pieces[2];    
                        richTextBox2.Text = pieces[3];  
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
