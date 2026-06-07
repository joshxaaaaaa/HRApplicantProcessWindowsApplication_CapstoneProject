using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantWindowSystem
{
    public partial class JobOpenings : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=#Sheena003;";
        private int vacancyCounter = 1;
        public JobOpenings()
        {
            InitializeComponent();
        }

        private void JobOpenings_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Search job title...";
            textBox1.ForeColor = Color.Gray;

            // Attach handlers
            dgvJobOpenings.CellValueChanged += dgvJobOpenings_CellValueChanged;
            dgvJobOpenings.CurrentCellDirtyStateChanged += dgvJobOpenings_CurrentCellDirtyStateChanged_1;
            dgvJobOpenings.DataError += dgvJobOpenings_DataError;

            dgvClosedJobs.CellValueChanged += dgvClosedJobs_CellValueChanged_1;
            dgvClosedJobs.CurrentCellDirtyStateChanged += dgvClosedJobs_CurrentCellDirtyStateChanged_1;
            dgvClosedJobs.DataError += dgvClosedJobs_DataError;
            dgvClosedJobs.EditingControlShowing += dgvClosedJobs_EditingControlShowing;

            dgvJobOpenings.Columns["ColActions"].ReadOnly = true;
            dgvClosedJobs.Columns["ColActions2"].ReadOnly = true;

            LoadJobsFromDatabase();
        }

        private void SaveJobToDatabase(string jobTitle, string qualifications, string requirements)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO jobs 
                               (JobTitle, Status, PostedDate, Qualifications, Requirements) 
                               VALUES (@title, 'Open', @date, @qual, @req)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@title", jobTitle);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@qual", qualifications);
                    cmd.Parameters.AddWithValue("@req", requirements);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadJobsFromDatabase()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM jobs";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int rowIndex = dgvJobOpenings.Rows.Add(
                            reader["JobID"],
                            reader["JobTitle"],
                            reader["Status"],
                            Convert.ToDateTime(reader["PostedDate"]).ToString("MM/dd/yyyy hh:mm tt"),
                            reader["Status"].ToString() == "Open" ? "Close Hiring" : "Re-Open Hiring"
                        );

                        dgvJobOpenings.Rows[rowIndex].Cells["ColQualifications"].Value = reader["Qualifications"];
                        dgvJobOpenings.Rows[rowIndex].Cells["ColRequirements"].Value = reader["Requirements"];
                        dgvJobOpenings.Rows[rowIndex].Cells["ColActions"].ReadOnly = false;
                    }
                }
            }
        }

        //Search bar
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search job title...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Search job title...";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = textBox1.Text.Trim();
                MessageBox.Show("You searched for: " + keyword);
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        //Add Vacancy
        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            AddVacancyForm addForm = new AddVacancyForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                int rowIndex = dgvJobOpenings.Rows.Add(
                    vacancyCounter++,                  // ColID
                    addForm.JobTitle,                  // ColJobTitle
                    "Open",                            // ColStatus
                    DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"), // ColPostedDate
                    "Close Hiring"                     // ColActions
                );
                dgvJobOpenings.Rows[rowIndex].Cells["ColQualifications"].Value = addForm.Qualifications;
                dgvJobOpenings.Rows[rowIndex].Cells["ColRequirements"].Value = addForm.Requirements;
                
                dgvJobOpenings.Rows[rowIndex].Cells["ColActions"].ReadOnly = false;
                SaveJobToDatabase(addForm.JobTitle, addForm.Qualifications, addForm.Requirements);
            }
        }

        //Open Jobs
        private void dgvJobOpenings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvJobOpenings.Columns[e.ColumnIndex].Name != "ColActions") return;

            string action = dgvJobOpenings.Rows[e.RowIndex].Cells["ColActions"].Value?.ToString();

            if (action == "Edit Details")
            {
                AddVacancyForm editForm = new AddVacancyForm();

                editForm.SetValues(
                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColJobTitle"].Value?.ToString(),
                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColQualifications"]?.Value?.ToString() ?? "",
                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColRequirements"]?.Value?.ToString() ?? ""
                );

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    string jobId = dgvJobOpenings.Rows[e.RowIndex].Cells["ColID"].Value.ToString();

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = @"UPDATE jobs 
                       SET JobTitle=@title, Qualifications=@qual, Requirements=@req 
                       WHERE JobID=@id";
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@title", editForm.JobTitle);
                            cmd.Parameters.AddWithValue("@qual", editForm.Qualifications);
                            cmd.Parameters.AddWithValue("@req", editForm.Requirements);
                            cmd.Parameters.AddWithValue("@id", jobId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColJobTitle"].Value = editForm.JobTitle;
                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColQualifications"].Value = editForm.Qualifications;
                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColRequirements"].Value = editForm.Requirements;

                    dgvJobOpenings.EndEdit();
                    dgvJobOpenings.Refresh();
                    MessageBox.Show("Updated successfully!");
                }
            }
            else if (action == "Close Hiring")
            {
                DataGridViewRow row = dgvJobOpenings.Rows[e.RowIndex];
                string jobId = row.Cells["ColID"].Value.ToString();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE jobs SET Status = 'Closed' WHERE JobID = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", jobId);
                        cmd.ExecuteNonQuery();
                    }
                }
                int closedRowIndex = dgvClosedJobs.Rows.Add(
                    row.Cells["ColID"].Value,
                    row.Cells["ColJobTitle"].Value,
                    "Closed",
                    row.Cells["ColPostedDate"].Value,
                    "Re-Open Hiring"
                );
                dgvClosedJobs.Rows[closedRowIndex].Cells["ColQualifications2"].Value = row.Cells["ColQualifications"].Value;
                dgvClosedJobs.Rows[closedRowIndex].Cells["ColRequirements2"].Value = row.Cells["ColRequirements"].Value;

                dgvJobOpenings.Rows.RemoveAt(e.RowIndex);
                dgvClosedJobs.Rows[closedRowIndex].Cells["ColActions2"].ReadOnly = false;
            }
        }

        private void dgvJobOpenings_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvJobOpenings.Columns[e.ColumnIndex].Name != "ColActions") return;

            string action = dgvJobOpenings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            if (action == "Close Hiring")
            {
                DataGridViewRow row = dgvJobOpenings.Rows[e.RowIndex];
                int closedRowIndex = dgvClosedJobs.Rows.Add(
                    row.Cells["ColID"].Value,
                    row.Cells["ColJobTitle"].Value,
                    "Closed",
                    row.Cells["ColPostedDate"].Value,
                    "Re-Open Hiring"
                );

                dgvClosedJobs.Rows[closedRowIndex].Cells["ColQualifications2"].Value = row.Cells["ColQualifications"].Value;
                dgvClosedJobs.Rows[closedRowIndex].Cells["ColRequirements2"].Value = row.Cells["ColRequirements"].Value;

                dgvJobOpenings.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvJobOpenings_DataError(object sender, DataGridViewDataErrorEventArgs e) => e.ThrowException = false;

        private void dgvJobOpenings_CurrentCellDirtyStateChanged_1(object sender, EventArgs e)
        {
            if (dgvJobOpenings.IsCurrentCellDirty)
                dgvJobOpenings.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        //Closed Jobs
        private void dgvClosedJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvClosedJobs.Columns[e.ColumnIndex].Name != "ColActions2") return;

            string action = dgvClosedJobs.Rows[e.RowIndex].Cells["ColActions2"].Value?.ToString();

            if (action == "Edit Details")
            {
                AddVacancyForm editForm = new AddVacancyForm();

                editForm.SetValues(
                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColJobTitle2"].Value?.ToString(),
                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColQualifications2"].Value?.ToString() ?? "",
                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColRequirements2"].Value?.ToString() ?? ""
                );

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColJobTitle2"].Value = editForm.JobTitle;
                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColQualifications2"].Value = editForm.Qualifications;
                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColRequirements2"].Value = editForm.Requirements;

                    dgvClosedJobs.EndEdit();
                    dgvClosedJobs.Refresh();
                    MessageBox.Show("Closed job updated successfully!");
                }
            }
            else if (action == "Re-Open Hiring")
            {
                DataGridViewRow row = dgvClosedJobs.Rows[e.RowIndex];
                string jobId = row.Cells["ColID2"].Value.ToString();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE jobs SET Status = 'Open' WHERE JobID = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", jobId);
                        cmd.ExecuteNonQuery();
                    }
                }
                int openRowIndex = dgvJobOpenings.Rows.Add(
                    row.Cells["ColID2"].Value,
                    row.Cells["ColJobTitle2"].Value,
                    "Open",
                    row.Cells["ColPostedDate2"].Value,
                    "Edit Details"
                );

                dgvJobOpenings.Rows[openRowIndex].Cells["ColQualifications"].Value = row.Cells["ColQualifications2"].Value;
                dgvJobOpenings.Rows[openRowIndex].Cells["ColRequirements"].Value = row.Cells["ColRequirements2"].Value;

                dgvClosedJobs.Rows.RemoveAt(e.RowIndex);
                dgvJobOpenings.Rows[openRowIndex].Cells["ColActions"].ReadOnly = false;
            }
        }

        private void dgvClosedJobs_CellValueChanged_1(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvClosedJobs.Columns[e.ColumnIndex].Name != "ColActions2") return;

            string action = dgvClosedJobs.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            if (action == "Re-Open Hiring")
            {
                string id = dgvClosedJobs.Rows[e.RowIndex].Cells["ColID2"].Value?.ToString();
                string jobTitle = dgvClosedJobs.Rows[e.RowIndex].Cells["ColJobTitle2"].Value?.ToString();
                string postedDate = dgvClosedJobs.Rows[e.RowIndex].Cells["ColPostedDate2"].Value?.ToString();

                dgvJobOpenings.Rows.Add(id, jobTitle, "Open", postedDate, "Close Hiring");
                dgvClosedJobs.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvClosedJobs_DataError(object sender, DataGridViewDataErrorEventArgs e) => e.ThrowException = false;

        private void dgvClosedJobs_CurrentCellDirtyStateChanged_1(object sender, EventArgs e)
        {
            if (dgvClosedJobs.IsCurrentCellDirty)
                dgvClosedJobs.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvClosedJobs_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvClosedJobs.CurrentCell.ColumnIndex == dgvClosedJobs.Columns["ColActions2"].Index && e.Control is ComboBox combo)
            {
                combo.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                combo.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvClosedJobs.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}