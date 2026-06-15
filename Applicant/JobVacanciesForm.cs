using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HRApplicantWindowSystem.Applicant
{
    public partial class JobVacanciesForm : Form
    {
        private string connectionString =
            "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";

        private int currentAccountId;
        private int currentApplicantId = 0;
        private Button button2;
        private Label label4;
        private Label label13;
        private Label label1;
        private Button btnJobVacancies;
        private Button button1;
        private DataGridView dgvJobVacancies;

        public JobVacanciesForm(int accountId)
        {
            InitializeComponent();
            currentAccountId = accountId;
        }

        private Label lblTotalCount;
        private object applicantId;

        private void InitializeComponent()
        {
            button2 = new Button();
            label4 = new Label();
            label13 = new Label();
            label1 = new Label();
            dgvJobVacancies = new DataGridView();
            lblTotalCount = new Label();
            btnJobVacancies = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJobVacancies).BeginInit();
            SuspendLayout();
            

            button2.Location = new Point(942, 385);
            button2.Name = "button2";
            button2.Size = new Size(180, 50);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.Click += button2_Click;
            

            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20F);
            label4.Location = new Point(26, 9);
            label4.Name = "label4";
            label4.Size = new Size(263, 40);
            label4.TabIndex = 5;
            label4.Text = "Job Vacancies";
            

            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 8.25F);
            label13.Location = new Point(30, 55);
            label13.Name = "label13";
            label13.Size = new Size(276, 19);
            label13.TabIndex = 4;
            label13.Text = "Browse and apply for vacant positions:";
            

            label1.AutoSize = true;
            label1.Location = new Point(30, 395);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 3;
            label1.Text = "Total Vacancies:";
            

            dgvJobVacancies.AllowUserToAddRows = false;
            dgvJobVacancies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobVacancies.ColumnHeadersHeight = 29;
            dgvJobVacancies.Location = new Point(30, 90);
            dgvJobVacancies.Name = "dgvJobVacancies";
            dgvJobVacancies.ReadOnly = true;
            dgvJobVacancies.RowHeadersWidth = 51;
            dgvJobVacancies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobVacancies.Size = new Size(1092, 280);
            dgvJobVacancies.TabIndex = 0;
            

            lblTotalCount.AutoSize = true;
            lblTotalCount.Location = new Point(150, 395);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(17, 20);
            lblTotalCount.TabIndex = 1;
            lblTotalCount.Text = "0";
            

            btnJobVacancies.Location = new Point(832, 13);
            btnJobVacancies.Margin = new Padding(3, 4, 3, 4);
            btnJobVacancies.Name = "btnJobVacancies";
            btnJobVacancies.Size = new Size(290, 61);
            btnJobVacancies.TabIndex = 7;
            btnJobVacancies.Text = "View Details";
            btnJobVacancies.UseVisualStyleBackColor = true;
            btnJobVacancies.Click += btnJobVacancies_Click_1;
            

            button1.Location = new Point(747, 385);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(189, 50);
            button1.TabIndex = 8;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 475);
            Controls.Add(button1);
            Controls.Add(btnJobVacancies);
            Controls.Add(dgvJobVacancies);
            Controls.Add(lblTotalCount);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(label4);
            Controls.Add(button2);
            Name = "JobVacanciesForm";
            Text = "Job Vacancies";
            Load += JobVacanciesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJobVacancies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void JobVacanciesForm_Load(object sender, EventArgs e)
        {
            ResolveApplicantId();
            LoadJobVacancies();
            CheckApplicantApplicationExists();
        }

        private void ResolveApplicantId()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string lookupApplicant = "SELECT applicant_id FROM Applicants WHERE account_id = @accountId LIMIT 1";
                    using (MySqlCommand lookupCmd = new MySqlCommand(lookupApplicant, conn))
                    {
                        lookupCmd.Parameters.AddWithValue("@accountId", currentAccountId);
                        object appRes = lookupCmd.ExecuteScalar();
                        if (appRes != null && appRes != DBNull.Value)
                        {
                            currentApplicantId = Convert.ToInt32(appRes);
                        }
                        else
                        {
                            currentApplicantId = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resolving applicant: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentApplicantId = 0;
            }
        }

        private void CheckApplicantApplicationExists()
        {
     
            if (currentApplicantId == 0)
            {
  
                button1.Enabled = true;
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string existsQuery = "SELECT COUNT(*) FROM Applications WHERE applicant_id = @applicantId";
                    using (MySqlCommand cmd = new MySqlCommand(existsQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@applicantId", currentApplicantId);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            button1.Enabled = false;
                            button1.Text = "Already Applied (Retract to apply)";
                        }
                        else
                        {
                            button1.Enabled = true;
                            button1.Text = "Apply";
                        }
                    }
                }
            }
            catch
            {
          
                button1.Enabled = true;
            }
        }

        private void LoadJobVacancies()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

       
                    string query = @"
                            SELECT
                                v.vacancy_id AS 'Vacancy ID',
                                p.position_name AS 'Job Title',
                                d.department_name AS 'Department',
                                et.employment_name AS 'Employment Type',
                                at.assessment_name AS 'Assessment Type',
                                it.interview_name AS 'Interview Type',
                                v.requirements AS 'Requirements',
                                p.description AS 'Description',
                                v.status AS 'Status'
                            FROM jobvacancies v
                            INNER JOIN positions p ON v.position_id = p.position_id
                            INNER JOIN departments d ON v.department_id = d.department_id
                            INNER JOIN employment_types et ON v.employment_type_id = et.employment_type_id
                            INNER JOIN assessment_types at ON v.assessment_type_id = at.assessment_type_id
                            INNER JOIN interview_types it ON v.interview_type_id = it.interview_type_id
                            WHERE v.status = 'Open'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvJobVacancies.DataSource = dt;


                    dgvJobVacancies.Columns["Description"].Visible = false;
                    dgvJobVacancies.Columns["Requirements"].Visible = false;
                    dgvJobVacancies.Columns["Assessment Type"].Visible = false;
                    dgvJobVacancies.Columns["Interview Type"].Visible = false;

                    lblTotalCount.Text = dt.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

       

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicantDashboardForm dashboard = new ApplicantDashboardForm(currentAccountId);
            dashboard.Show();
            this.Close();
        }

        

        private void btnJobVacancies_Click_1(object sender, EventArgs e)
        {
            if (dgvJobVacancies.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dgvJobVacancies.SelectedRows[0];

                string jobTitle = row.Cells["Job Title"].Value?.ToString() ?? "N/A";
                string department = row.Cells["Department"].Value?.ToString() ?? "N/A";
                string empType = row.Cells["Employment Type"].Value?.ToString() ?? "N/A";
                string interviewType = row.Cells["Interview Type"].Value?.ToString() ?? "N/A";
                string assessmentType = row.Cells["Assessment Type"].Value?.ToString() ?? "N/A";
                string requirements = row.Cells["Requirements"].Value?.ToString() ?? "None listed.";
                string description = row.Cells["Description"].Value?.ToString() ?? "No description available.";


                string detailsMessage =
                    $"POSITION DETAILS\n" +
                    $"------------------------------------------\n" +
                    $"Job Title: {jobTitle}\n" +
                    $"Department: {department}\n" +
                    $"Employment Type: {empType}\n\n" +

                    $"EVALUATION PROCESS\n" +
                    $"------------------------------------------\n" +
                    $"Interview Type: {interviewType}\n" +
                    $"Assessment: {assessmentType}\n\n" +

                    $"JOB DESCRIPTION\n" +
                    $"------------------------------------------\n" +
                    $"{description}\n\n" +

                    $"REQUIREMENTS\n" +
                    $"------------------------------------------\n" +
                    $"{requirements}";


                MessageBox.Show(detailsMessage, "Complete Job Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a job vacancy first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvJobVacancies.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a job vacancy first.",
                    "No Vacancy Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                int vacancyId = Convert.ToInt32(
                    dgvJobVacancies.SelectedRows[0]
                    .Cells["Vacancy ID"].Value);
 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();


                    int applicantId = 0;
                    string lookupApplicant = "SELECT applicant_id FROM Applicants WHERE account_id = @accountId LIMIT 1";
                    using (MySqlCommand lookupCmd = new MySqlCommand(lookupApplicant, conn))
                    {
                        lookupCmd.Parameters.AddWithValue("@accountId", currentAccountId);
                        object appRes = lookupCmd.ExecuteScalar();
                        if (appRes == null || appRes == DBNull.Value)
                        {
                            MessageBox.Show("No applicant profile found for this account. Please complete your profile before applying.", "Missing Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        applicantId = Convert.ToInt32(appRes);
                    }

                    string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM Applications 
                    WHERE applicant_id = @applicantId 
                    AND vacancy_id = @vacancyId";

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@applicantId", applicantId);
                        checkCmd.Parameters.AddWithValue("@vacancyId", vacancyId);

                        int existingApplications = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingApplications > 0)
                        {
                            MessageBox.Show("You have already applied for this position.", "Application Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    string insertQuery = @"
                    INSERT INTO Applications (
                        applicant_id, 
                        vacancy_id, 
                        status
                    ) 
                    VALUES (
                        @applicantId, 
                        @vacancyId, 
                        'Submitted'
                    )";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@applicantId", applicantId);
                        cmd.Parameters.AddWithValue("@vacancyId", vacancyId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error submitting application:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}