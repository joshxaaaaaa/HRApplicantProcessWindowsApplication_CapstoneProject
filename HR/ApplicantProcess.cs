using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantWindowSystem
{
    public partial class ApplicantProcess : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        private int selectedApplicantId = -1;

        public ApplicantProcess()
        {
            InitializeComponent();
            RefreshApplicantGrid();
            UpdateMetricSummaryCards();
        }

        private void RefreshApplicantGrid()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT a.applicant_id AS 'ID', CONCAT(a.first_name, ' ', a.last_name) AS 'Full Name', j.job_title AS 'Applied Position', ap.status AS 'Status' FROM applicants a INNER JOIN applications ap ON a.applicant_id = ap.applicant_id INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id;";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dgvApplicantList.DataSource = table;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedApplicantId = Convert.ToInt32(dgvApplicantList.Rows[e.RowIndex].Cells["ID"].Value);
                LoadApplicantSummary(selectedApplicantId);
            }
        }

        private void LoadApplicantSummary(int id)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT a.*, ap.status, ie.comments FROM applicants a LEFT JOIN applications ap ON a.applicant_id = ap.applicant_id LEFT JOIN interviewevaluations ie ON ap.application_id = ie.application_id WHERE a.applicant_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UpdateControlText<Label>("lblSummaryName", "Name: " + reader["first_name"] + " " + reader["last_name"]);
                            UpdateControlText<TextBox>("txtHRNotes", reader["comments"].ToString());

                        }
                    }
                }
            }
        }


        private T FindControl<T>(string name) where T : Control
        {
            Control[] match = this.Controls.Find(name, true);
            return match.Length > 0 ? match[0] as T : null;
        }

        private void UpdateControlText<T>(string controlName, string text) where T : Control
        {
            T ctrl = FindControl<T>(controlName);
            if (ctrl != null) ctrl.Text = text;
        }

        private void UpdateMetricSummaryCards() { }

        private void txtSearchApplicant_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchApplicant.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvApplicantList.Rows)
            {
                if (!row.IsNewRow)
                {
                    bool isMatch = row.Cells["Full Name"].Value != null &&
                                   row.Cells["Full Name"].Value.ToString().ToLower().Contains(keyword);

                    if (row.Visible != isMatch)
                    {
                        dgvApplicantList.CurrentCell = null;
                        row.Visible = isMatch;
                    }
                }
            }
        }

        private void btnLockReview_Click(object sender, EventArgs e)
        {

            if (selectedApplicantId == -1)
            {
                MessageBox.Show("Please select an applicant from the list first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "UPDATE applications SET is_locked = 1, status = 'Under Review' WHERE applicant_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedApplicantId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Application successfully locked for review.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    btnLockReview.Enabled = false;
                    btnLockReview.Text = "Locked";
                    btnLockReview.BackColor = Color.Gray;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error locking application: " + ex.Message);
                }
            }
        }

        private void ApplicantProcess_Load(object sender, EventArgs e)
        {
            LoadDashboardMetrics();
            LoadApplicantGrid();
        }

        private void dgvApplicantList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {

                selectedApplicantId = Convert.ToInt32(dgvApplicantList.Rows[e.RowIndex].Cells["ID"].Value);


                LoadApplicantDetails(selectedApplicantId);
            }
        }

        private void LoadDashboardMetrics()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmdTotal = new MySqlCommand("SELECT COUNT(*) FROM applications", conn);
                    lblTotalApps.Text = cmdTotal.ExecuteScalar().ToString();


                    MySqlCommand cmdPending = new MySqlCommand("SELECT COUNT(*) FROM applications WHERE status IN ('Pending', 'Under Review')", conn);
                    lblPending.Text = cmdPending.ExecuteScalar().ToString();


                    MySqlCommand cmdShort = new MySqlCommand("SELECT COUNT(*) FROM applications WHERE status = 'Shortlisted'", conn);
                    lblShortlisted.Text = cmdShort.ExecuteScalar().ToString();


                    MySqlCommand cmdInt = new MySqlCommand("SELECT COUNT(*) FROM applications WHERE status = 'Interviewing'", conn);
                    lblInterviewing.Text = cmdInt.ExecuteScalar().ToString();


                    MySqlCommand cmdHired = new MySqlCommand("SELECT COUNT(*) FROM applications WHERE status = 'Hired'", conn);
                    lblHired.Text = cmdHired.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Metrics Error: " + ex.Message);
                }
            }
        }
        private void LoadApplicantGrid()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT a.applicant_id AS 'ID', 
                                  CONCAT(a.first_name, ' ', a.last_name) AS 'Name', 
                                  j.job_title AS 'Position', 
                                  ap.status AS 'Status' 
                           FROM applicants a 
                           INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                           INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvApplicantList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Grid Error: " + ex.Message);
                }
            }
        }
        private void LoadApplicantDetails(int applicantId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string summarySql = @"SELECT CONCAT(a.first_name, ' ', a.last_name) AS FullName, a.email, a.phone, j.job_title, ap.status 
                                  FROM applicants a 
                                  INNER JOIN applications ap ON a.applicant_id = ap.applicant_id 
                                  INNER JOIN jobvacancies j ON ap.vacancy_id = j.vacancy_id 
                                  WHERE a.applicant_id = @id LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(summarySql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", applicantId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtProfileName.Text = reader["FullName"].ToString();
                                txtProfileEmail.Text = reader["email"].ToString();
                                txtProfilePhone.Text = reader["phone"].ToString();
                                txtProfilePosition.Text = reader["job_title"].ToString();
                                txtProfileStatus.Text = reader["status"].ToString();
                            }
                        }
                    }


                    string docSql = "SELECT document_name AS 'Document Type', file_path AS 'File Route' FROM applicantdocuments WHERE applicant_id = @id";
                    MySqlDataAdapter docAdapter = new MySqlDataAdapter(docSql, conn);
                    docAdapter.SelectCommand.Parameters.AddWithValue("@id", applicantId);
                    DataTable docDt = new DataTable();
                    docAdapter.Fill(docDt);
                    dgvDocuments.DataSource = docDt; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Details Error: " + ex.Message);
                }
            }
        }
    }
}