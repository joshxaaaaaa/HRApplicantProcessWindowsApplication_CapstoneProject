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

        private int currentAccountId;


        public MyApplicationForm(int accountId)
        {
            InitializeComponent();
            currentAccountId = accountId;
        }


        private void MyApplicationForm_Load(object sender, EventArgs e)
        {
            string fileName = $"draft_{currentAccountId}.txt";

            if (System.IO.File.Exists(fileName))
            {
                try
                {

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
