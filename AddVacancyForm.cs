using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRApplicantWindowSystem
{
    public partial class AddVacancyForm : Form
    {

        public AddVacancyForm()
        {
            InitializeComponent();
        }
        public void SetValues(string jobTitle, string qualifications, string requirements)
        {
            EntJobtitle.Text = jobTitle;
            EntQualifications.Text = qualifications;
            EntRequirements.Text = requirements;
        }
        public string JobTitle => EntJobtitle.Text;
        public string Qualifications => EntQualifications.Text;
        public string Requirements => EntRequirements.Text;

        private void AddVacancyForm_Load(object sender, EventArgs e)
        {
            EntJobtitle.Text = "Enter job title...";
            EntJobtitle.ForeColor = Color.Gray;
        }

        private void EntJobtitle_Enter(object sender, EventArgs e)
        {
            if (EntJobtitle.Text == "Enter job title...")
            {
                EntJobtitle.Text = "";
                EntJobtitle.ForeColor = Color.Black;
            }
        }

        private void EntJobtitle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntJobtitle.Text))
            {
                EntJobtitle.Text = "Enter job title...";
                EntJobtitle.ForeColor = Color.Gray;
            }
        }

        private void EntJobtitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string jobTitle = EntJobtitle.Text.Trim();

                if (jobTitle == "Enter job title..." || string.IsNullOrWhiteSpace(jobTitle))
                {
                    MessageBox.Show("Please enter a valid job title.");
                }
                else
                {
                    // Example: show confirmation
                    MessageBox.Show("Job Title added: " + jobTitle);
                }

                e.SuppressKeyPress = true; // para walang beep sound
                btnSaveVacancy.Focus();
            }
        }

        private void EntQualifications_Enter(object sender, EventArgs e)
        {
            if (EntQualifications.Text == "Enter qualifications...")
            {
                EntQualifications.Text = "";
                EntQualifications.ForeColor = Color.Black;
            }
        }

        private void EntQualifications_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntJobtitle.Text))
            {
                EntQualifications.Text = "Enter qualifications...";
                EntQualifications.ForeColor = Color.Gray;
            }
        }

        private void EntQualifications_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string qualification = EntQualifications.Text.Trim();

                if (qualification == "Enter qualification..." || string.IsNullOrWhiteSpace(qualification))
                {
                    MessageBox.Show("Please enter a valid qualification.");
                }
                else
                {
                    // Example: show confirmation
                    MessageBox.Show("Qualification added: " + qualification);

                }

                e.SuppressKeyPress = true; // para walang beep sound
                btnSaveVacancy.Focus();
            }
        }

        private void EntRequirements_Enter(object sender, EventArgs e)
        {
            if (EntRequirements.Text == "Enter requirements...")
            {
                EntRequirements.Text = "";
                EntRequirements.ForeColor = Color.Black;
            }
        }

        private void EntRequirements_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntRequirements.Text))
            {
                EntRequirements.Text = "Enter requirements...";
                EntRequirements.ForeColor = Color.Gray;
            }
        }

        private void EntRequirements_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string requirements = EntRequirements.Text.Trim();

                if (requirements == "Enter requirements..." || string.IsNullOrWhiteSpace(requirements))
                {
                    MessageBox.Show("Please enter a valid requirement.");
                }
                else
                {
                    // Example: show confirmation
                    MessageBox.Show("Requirements added: " + requirements);
                }

                e.SuppressKeyPress = true; // para walang beep sound
                btnSaveVacancy.Focus();
            }
        }
        private void btnSaveVacancy_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntJobtitle.Text) || EntJobtitle.Text == "Enter job title...")
            {
                MessageBox.Show("Please enter a valid job title.");
                return;
            }

            this.DialogResult = DialogResult.OK; // signal na may valid data
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
