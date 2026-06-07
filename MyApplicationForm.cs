using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantWindowSystem
{
    public partial class MyApplicationForm : Form
    {
        // 1. Create a class variable to store the passed Account ID
        private int currentAccountId;

        // 2. UPDATE THE CONSTRUCTOR TO ACCEPT JUST THE INT ID
        public MyApplicationForm(int accountId)
        {
            InitializeComponent();
            currentAccountId = accountId;
        }

        // 3. THE LOAD EVENT: Reads the updated profile text file whenever this form opens
        private void MyApplicationForm_Load(object sender, EventArgs e)
        {
            string fileName = $"draft_{currentAccountId}.txt";

            if (System.IO.File.Exists(fileName))
            {
                try
                {
                    // Read the data string directly from the draft file
                    string profileData = System.IO.File.ReadAllText(fileName);
                    string[] pieces = profileData.Split('|');

                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading updated application details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
