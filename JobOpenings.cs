using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantWindowSystem
{
    public partial class JobOpenings : Form
    {
        private string connectionString = "Server=localhost;Database=db_hrapplicantwindowsystem;User ID=root;Password=abalo_mysql;";
        private int vacancyCounter = 1;
        public JobOpenings()
        {
            InitializeComponent();
        }

        private void JobOpenings_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "Search job title...";
            txtSearch.ForeColor = Color.Gray;

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

        private void SaveJobToDatabase(int departmentId, string jobTitle, string description, string requirements)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = @"INSERT INTO jobvacancies 
                       (department_id, job_title, status, posted_date, description, requirements) 
                       VALUES (@deptId, @title, 'Open', @date, @desc, @req)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@deptId", departmentId);
                    cmd.Parameters.AddWithValue("@title", jobTitle);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@desc", description);
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
                string sql = "SELECT * FROM jobvacancies";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int rowIndex = dgvJobOpenings.Rows.Add(
                            reader["vacancy_id"],
                            reader["job_title"],
                            reader["status"],
                            Convert.ToDateTime(reader["posted_date"]).ToString("MM/dd/yyyy hh:mm tt"),
                            reader["status"].ToString() == "Open" ? "Close Hiring" : "Re-Open Hiring"
                        );

                        dgvJobOpenings.Rows[rowIndex].Cells["ColDescription"].Value = reader["description"];
                        dgvJobOpenings.Rows[rowIndex].Cells["ColRequirements"].Value = reader["requirements"];
                        dgvJobOpenings.Rows[rowIndex].Cells["ColActions"].ReadOnly = false;
                    }
                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search job title...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search job title...";
                txtSearch.ForeColor = Color.Gray;
            }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = txtSearch.Text.Trim();
                MessageBox.Show("You searched for: " + keyword);
                e.SuppressKeyPress = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) 
        {

            string keyword = txtSearch.Text.Trim().ToLower();


            if (keyword == "search job title...")
            {
                keyword = "";
            }


            foreach (DataGridViewRow row in dgvJobOpenings.Rows)
            {
                if (!row.IsNewRow) 
                {
                    bool isMatch = row.Cells["ColJobTitle"].Value != null &&
                                   row.Cells["ColJobTitle"].Value.ToString().ToLower().Contains(keyword);


                    if (row.Visible != isMatch)
                    {
                        dgvJobOpenings.CurrentCell = null;
                        row.Visible = isMatch;
                    }
                }
            }


            foreach (DataGridViewRow row in dgvClosedJobs.Rows)
            {
                if (!row.IsNewRow)
                {

                    bool isMatch = row.Cells["ColJobTitle2"].Value != null &&
                                   row.Cells["ColJobTitle2"].Value.ToString().ToLower().Contains(keyword);

                    if (row.Visible != isMatch)
                    {
                        dgvClosedJobs.CurrentCell = null;
                        row.Visible = isMatch;
                    }
                }
            }
        }


        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            AddVacancyForm addForm = new AddVacancyForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                int rowIndex = dgvJobOpenings.Rows.Add(
                    vacancyCounter++,
                    addForm.JobTitle,
                    "Open",
                    DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"),
                    "Close Hiring"
                );
                dgvJobOpenings.Rows[rowIndex].Cells["ColDescription"].Value = addForm.Description;
                dgvJobOpenings.Rows[rowIndex].Cells["ColRequirements"].Value = addForm.Requirements;

                dgvJobOpenings.Rows[rowIndex].Cells["ColActions"].ReadOnly = false;
                SaveJobToDatabase(addForm.DepartmentId, addForm.JobTitle, addForm.Description, addForm.Requirements);
            }
        }


        private void dgvJobOpenings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvJobOpenings.Columns[e.ColumnIndex].Name != "ColActions") return;

            string action = dgvJobOpenings.Rows[e.RowIndex].Cells["ColActions"].Value?.ToString();

            if (action == "Edit Details")
            {

                string jobId = dgvJobOpenings.Rows[e.RowIndex].Cells["ColID"].Value.ToString();
                int currentDeptId = 0;


                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string getDeptSql = "SELECT department_id FROM jobvacancies WHERE vacancy_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(getDeptSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", jobId);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            currentDeptId = Convert.ToInt32(result);
                        }
                    }
                }

                AddVacancyForm editForm = new AddVacancyForm();


                editForm.SetValues(
                    currentDeptId,
                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColJobTitle"].Value?.ToString(),
                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColDescription"]?.Value?.ToString() ?? "",
                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColRequirements"]?.Value?.ToString() ?? ""
                );

                if (editForm.ShowDialog() == DialogResult.OK)
                {

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = @"UPDATE jobvacancies 
                        SET department_id=@deptId, job_title=@title, description=@desc, requirements=@req 
                        WHERE vacancy_id=@id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {

                            cmd.Parameters.AddWithValue("@deptId", editForm.DepartmentId);
                            cmd.Parameters.AddWithValue("@title", editForm.JobTitle);
                            cmd.Parameters.AddWithValue("@desc", editForm.Description);
                            cmd.Parameters.AddWithValue("@req", editForm.Requirements);
                            cmd.Parameters.AddWithValue("@id", jobId);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColJobTitle"].Value = editForm.JobTitle;
                    dgvJobOpenings.Rows[e.RowIndex].Cells["ColDescription"].Value = editForm.Description;
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
                    string sql = "UPDATE jobvacancies SET status = 'Closed' WHERE vacancy_id = @id;";
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
                dgvClosedJobs.Rows[closedRowIndex].Cells["ColDescription2"].Value = row.Cells["ColDescription"].Value;
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

                dgvClosedJobs.Rows[closedRowIndex].Cells["ColDescription2"].Value = row.Cells["ColDescription"].Value;
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


        private void dgvClosedJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvClosedJobs.Columns[e.ColumnIndex].Name != "ColActions2") return;

            string action = dgvClosedJobs.Rows[e.RowIndex].Cells["ColActions2"].Value?.ToString();

            if (action == "Edit Details")
            {

                string jobId = dgvClosedJobs.Rows[e.RowIndex].Cells["ColID2"].Value.ToString();
                int currentDeptId = 0;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string getDeptSql = "SELECT department_id FROM jobvacancies WHERE vacancy_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(getDeptSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", jobId);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            currentDeptId = Convert.ToInt32(result);
                        }
                    }
                }

                AddVacancyForm editForm = new AddVacancyForm();

                editForm.SetValues(
                    currentDeptId,
                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColJobTitle2"].Value?.ToString(),
                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColDescription2"]?.Value?.ToString() ?? "",
                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColRequirements2"]?.Value?.ToString() ?? ""
                );

                if (editForm.ShowDialog() == DialogResult.OK)
                {

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = @"UPDATE jobvacancies 
                           SET department_id=@deptId, job_title=@title, description=@desc, requirements=@req 
                           WHERE vacancy_id=@id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@deptId", editForm.DepartmentId);
                            cmd.Parameters.AddWithValue("@title", editForm.JobTitle);
                            cmd.Parameters.AddWithValue("@desc", editForm.Description);
                            cmd.Parameters.AddWithValue("@req", editForm.Requirements);
                            cmd.Parameters.AddWithValue("@id", jobId);
                            cmd.ExecuteNonQuery();
                        }
                    }


                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColJobTitle2"].Value = editForm.JobTitle;
                    dgvClosedJobs.Rows[e.RowIndex].Cells["ColDescription2"].Value = editForm.Description;
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
                    string sql = "UPDATE jobvacancies SET status = 'Open' WHERE vacancy_id = @id;";
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

                dgvJobOpenings.Rows[openRowIndex].Cells["ColDescription"].Value = row.Cells["ColDescription2"].Value;
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

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}