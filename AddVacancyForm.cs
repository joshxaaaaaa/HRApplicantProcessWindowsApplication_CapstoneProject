using MySql.Data.MySqlClient; 
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
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";

        public AddVacancyForm()
        {
            InitializeComponent();
        }
        public void SetValues(int deptId, string jobTitle, string description, string requirements)
        {
            cmbDepartment.SelectedValue = deptId;
            EntJobtitle.Text = jobTitle;
            EntJobtitle.ForeColor = Color.Black;
            EntDescription.Text = description;


            for (int i = 0; i < clbRequirements.Items.Count; i++)
            {
                clbRequirements.SetItemChecked(i, false);
            }

            if (!string.IsNullOrWhiteSpace(requirements))
            {
                string[] savedReqs = requirements.Split(new string[] { ", " }, StringSplitOptions.None);
                for (int i = 0; i < clbRequirements.Items.Count; i++)
                {
                    DataRowView item = (DataRowView)clbRequirements.Items[i];
                    if (Array.Exists(savedReqs, r => r == item["requirement_name"].ToString()))
                    {
                        clbRequirements.SetItemChecked(i, true);
                    }
                }
            }
        }
        public string JobTitle => EntJobtitle.Text;
        public string Description => EntDescription.Text;
        public string Requirements
        {
            get
            {
                System.Collections.Generic.List<string> checkedList = new System.Collections.Generic.List<string>();


                foreach (DataRowView item in clbRequirements.CheckedItems)
                {
                    checkedList.Add(item["requirement_name"].ToString());
                }


                return string.Join(", ", checkedList);
            }
        }
        public int DepartmentId => Convert.ToInt32(cmbDepartment.SelectedValue);

        private void AddVacancyForm_Load(object sender, EventArgs e)
        {

            EntJobtitle.Text = "Enter job title...";
            EntJobtitle.ForeColor = Color.Gray;
            EntDescription.Text = "Enter description...";
            EntDescription.ForeColor = Color.Gray;


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string deptQuery = "SELECT department_id, department_name FROM departments";
                    MySqlDataAdapter deptAdapter = new MySqlDataAdapter(deptQuery, conn);
                    DataTable deptDt = new DataTable();
                    deptAdapter.Fill(deptDt);

                    cmbDepartment.DataSource = deptDt;
                    cmbDepartment.DisplayMember = "department_name";
                    cmbDepartment.ValueMember = "department_id";
                    cmbDepartment.SelectedIndex = -1;


                    string reqQuery = "SELECT requirement_type_id, requirement_name FROM requirementtypes";
                    MySqlDataAdapter reqAdapter = new MySqlDataAdapter(reqQuery, conn);
                    DataTable reqDt = new DataTable();
                    reqAdapter.Fill(reqDt);


                    ((ListBox)clbRequirements).DataSource = reqDt;
                    ((ListBox)clbRequirements).DisplayMember = "requirement_name";
                    ((ListBox)clbRequirements).ValueMember = "requirement_type_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading departments: " + ex.Message);
                }
            }
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

                    MessageBox.Show("Job Title added: " + jobTitle);
                }

                e.SuppressKeyPress = true;
                btnSaveVacancy.Focus();
            }
        }

        private void EntDescription_Enter(object sender, EventArgs e)
        {
            if (EntDescription.Text == "Enter description...")
            {
                EntDescription.Text = "";
                EntDescription.ForeColor = Color.Black;
            }
        }

        
        private void EntDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntJobtitle.Text))
            {
                EntDescription.Text = "Enter description...";
                EntDescription.ForeColor = Color.Gray;
            }
        }
        

        private void EntDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string description = EntDescription.Text.Trim();

                if (description == "Enter description..." || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please enter a valid description.");
                }
                else
                {

                    MessageBox.Show("Description added: " + description);

                }

                e.SuppressKeyPress = true;
                btnSaveVacancy.Focus();
            }
        }
        

        private void btnSaveVacancy_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(EntJobtitle.Text) || EntJobtitle.Text == "Enter job title..." || cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a valid job title and select a department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void clbRequirements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
