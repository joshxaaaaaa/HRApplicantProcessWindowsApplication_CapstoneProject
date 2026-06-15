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

        private string descriptionField = string.Empty;

        public AddVacancyForm()
        {
            InitializeComponent();
        }
        public void SetValues(int deptId, string jobTitle, string description, string requirements)
        {
            cmbDepartment.SelectedValue = deptId;


            try { cmbPosition.Text = jobTitle ?? string.Empty; } catch { }


            descriptionField = description ?? string.Empty;
            


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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string JobTitle
        {
            get
            {
                try { return cmbPosition?.Text ?? string.Empty; } catch { return string.Empty; }
            }
            set
            {
                try { if (cmbPosition != null) cmbPosition.Text = value ?? string.Empty; } catch { }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public string Description
        {
            get => descriptionField ?? string.Empty;
            set => descriptionField = value ?? string.Empty;
        }

        private void AddVacancyForm_Load(object sender, EventArgs e)
        {

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


                    string posQuery = "SELECT position_id, position_name FROM positions";
                    MySqlDataAdapter posAdapter = new MySqlDataAdapter(posQuery, conn);
                    DataTable posDt = new DataTable();
                    posAdapter.Fill(posDt);
                    cmbPosition.DataSource = posDt;
                    cmbPosition.DisplayMember = "position_name";
                    cmbPosition.ValueMember = "position_id";
                    cmbPosition.SelectedIndex = -1;


                    string empQuery = "SELECT employment_type_id, employment_name FROM employment_types";
                    MySqlDataAdapter empAdapter = new MySqlDataAdapter(empQuery, conn);
                    DataTable empDt = new DataTable();
                    empAdapter.Fill(empDt);
                    cmbEmploymentType.DataSource = empDt;
                    cmbEmploymentType.DisplayMember = "employment_name";
                    cmbEmploymentType.ValueMember = "employment_type_id";
                    cmbEmploymentType.SelectedIndex = -1;


                    string assmtQuery = "SELECT assessment_type_id, assessment_name FROM assessment_types";
                    MySqlDataAdapter assmtAdapter = new MySqlDataAdapter(assmtQuery, conn);
                    DataTable assmtDt = new DataTable();
                    assmtAdapter.Fill(assmtDt);
                    cmbAssessmentType.DataSource = assmtDt;
                    cmbAssessmentType.DisplayMember = "assessment_name";
                    cmbAssessmentType.ValueMember = "assessment_type_id";
                    cmbAssessmentType.SelectedIndex = -1;


                    string intQuery = "SELECT interview_type_id, interview_name FROM interview_types";
                    MySqlDataAdapter intAdapter = new MySqlDataAdapter(intQuery, conn);
                    DataTable intDt = new DataTable();
                    intAdapter.Fill(intDt);
                    cmbInterviewType.DataSource = intDt;
                    cmbInterviewType.DisplayMember = "interview_name";
                    cmbInterviewType.ValueMember = "interview_type_id";
                    cmbInterviewType.SelectedIndex = -1;


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
                    MessageBox.Show("Error loading dropdown data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnSaveVacancy_Click_1(object sender, EventArgs e)
        {

            if (cmbDepartment.SelectedIndex == -1 || cmbPosition.SelectedIndex == -1 ||
                cmbEmploymentType.SelectedIndex == -1 || cmbAssessmentType.SelectedIndex == -1 ||
                cmbInterviewType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an option for all dropdown fields.", "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string insertSql = @"INSERT INTO jobvacancies 
                                 (department_id, position_id, employment_type_id, assessment_type_id, interview_type_id, requirements, status, posted_date) 
                                 VALUES 
                                 (@deptId, @posId, @empId, @assmtId, @intId, @reqs, 'Open', @date)";

                    using (MySqlCommand cmd = new MySqlCommand(insertSql, conn))
                    {

                        cmd.Parameters.AddWithValue("@deptId", cmbDepartment.SelectedValue);
                        cmd.Parameters.AddWithValue("@posId", cmbPosition.SelectedValue);
                        cmd.Parameters.AddWithValue("@empId", cmbEmploymentType.SelectedValue);
                        cmd.Parameters.AddWithValue("@assmtId", cmbAssessmentType.SelectedValue);
                        cmd.Parameters.AddWithValue("@intId", cmbInterviewType.SelectedValue);


                        cmd.Parameters.AddWithValue("@reqs", this.Requirements);

                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Job vacancy successfully posted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving vacancy: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
