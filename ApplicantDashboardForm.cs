using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantWindowSystem
{
    public partial class ApplicantDashboardForm : Form
    {
        // Add a variable to store the logged-in applicant's ID
        private int currentAccountId;

        // Modify the constructor to accept the ID
        public ApplicantDashboardForm(int accountId)
        {
            InitializeComponent();
            currentAccountId = accountId; 
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ApplicantProfileForm profilePage = new ApplicantProfileForm(currentAccountId);

            profilePage.StartPosition = FormStartPosition.CenterScreen;
            profilePage.Show();
            this.Hide();
        }

        private void btnJobVacancies_Click(object sender, EventArgs e)
        {

        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {

        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {

        }

        private void btnStatusTracking_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplicantDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
