using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantWindowSystem
{
    public partial class Form1 : Form
    {
        private string connString = "server=127.0.0.1;port=3306;uid=root;pwd=abalo_mysql;database=your_database_name;";
        private int selectedApplicantId = -1;

        public Form1()
        {
            InitializeComponent();
            RefreshApplicantGrid();
            UpdateMetricSummaryCards();
        }

        private void RefreshApplicantGrid()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT a.applicant_id AS 'ID', CONCAT(a.first_name, ' ', a.last_name) AS 'Full Name', j.job_title AS 'Applied Position', ap.status AS 'Status' FROM applicants a INNER JOIN applications ap ON a.applicant_id = ap.applicant_id INNER JOIN jobvacancies j ON ap.job_vacancy_id = j.vacancy_id ORDER BY ap.application_date DESC;";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedApplicantId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                LoadApplicantSummary(selectedApplicantId);
            }
        }

        private void LoadApplicantSummary(int id)
        {
            // This loads all data into Summary, Checklist, and Notes
            using (MySqlConnection conn = new MySqlConnection(connString))
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
                            // Add other field mappings here...
                        }
                    }
                }
            }
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            if (selectedApplicantId == -1) return;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE interviewevaluations SET comments = @notes WHERE application_id = (SELECT application_id FROM applications WHERE applicant_id = @id LIMIT 1)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@notes", txtHRNotes.Text);
                    cmd.Parameters.AddWithValue("@id", selectedApplicantId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Notes saved successfully!");
                }
            }
        }

        private void btnSaveChecklist_Click(object sender, EventArgs e)
        {
            if (selectedApplicantId == -1) return;
            // Add your UPDATE query for your screening_checklist table here
            MessageBox.Show("Checklist progress saved!");
        }

        private void UpdateApplicantStatus(string newStatus)
        {
            if (selectedApplicantId == -1) return;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE applications SET status = @status WHERE applicant_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", selectedApplicantId);
                    cmd.ExecuteNonQuery();
                }
            }
            RefreshApplicantGrid();
        }

        // Helper methods to prevent crashes if UI names change
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

        private void UpdateMetricSummaryCards() { /* Logic for your top cards */ }
    }
}