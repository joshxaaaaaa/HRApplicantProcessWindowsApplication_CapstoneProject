namespace HRApplicantWindowSystem
{
    partial class JobOpenings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnBack = new Button();
            txtSearch = new TextBox();
            btnAddVacancy = new Button();
            lblWelcome = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvJobOpenings = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColJobTitle = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            ColPostedDate = new DataGridViewTextBoxColumn();
            ColActions = new DataGridViewComboBoxColumn();
            ColDescription = new DataGridViewTextBoxColumn();
            ColRequirements = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            dgvClosedJobs = new DataGridView();
            ColID2 = new DataGridViewTextBoxColumn();
            ColJobTitle2 = new DataGridViewTextBoxColumn();
            ColStatus2 = new DataGridViewTextBoxColumn();
            ColPostedDate2 = new DataGridViewTextBoxColumn();
            ColActions2 = new DataGridViewComboBoxColumn();
            ColDescription2 = new DataGridViewTextBoxColumn();
            ColRequirements2 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobOpenings).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClosedJobs).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnAddVacancy);
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 654);
            panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 552);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(228, 62);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnLogout_Click;
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = SystemColors.WindowFrame;
            txtSearch.Location = new Point(805, 109);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(318, 27);
            txtSearch.TabIndex = 8;
            txtSearch.Text = "Search job title...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.KeyDown += txtSearch_KeyDown;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btnAddVacancy
            // 
            btnAddVacancy.BackColor = SystemColors.Highlight;
            btnAddVacancy.FlatStyle = FlatStyle.Flat;
            btnAddVacancy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddVacancy.ForeColor = SystemColors.ButtonHighlight;
            btnAddVacancy.Location = new Point(12, 463);
            btnAddVacancy.Name = "btnAddVacancy";
            btnAddVacancy.Size = new Size(228, 72);
            btnAddVacancy.TabIndex = 9;
            btnAddVacancy.Text = "Add New Vacancy";
            btnAddVacancy.UseVisualStyleBackColor = false;
            btnAddVacancy.Click += btnAddVacancy_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = SystemColors.HighlightText;
            lblWelcome.Location = new Point(51, 13);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(99, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome HR!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 23);
            label1.Name = "label1";
            label1.Size = new Size(308, 28);
            label1.TabIndex = 2;
            label1.Text = "JOB OPENINGS MANAGEMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(323, 51);
            label2.Name = "label2";
            label2.Size = new Size(269, 20);
            label2.TabIndex = 3;
            label2.Text = "Manage job vacancies and hiring status";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(323, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 1);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dgvJobOpenings);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(323, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(817, 233);
            panel3.TabIndex = 6;
            // 
            // dgvJobOpenings
            // 
            dgvJobOpenings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobOpenings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvJobOpenings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobOpenings.Columns.AddRange(new DataGridViewColumn[] { ColID, ColJobTitle, ColStatus, ColPostedDate, ColActions, ColDescription, ColRequirements });
            dgvJobOpenings.Location = new Point(14, 44);
            dgvJobOpenings.Name = "dgvJobOpenings";
            dgvJobOpenings.RowHeadersVisible = false;
            dgvJobOpenings.RowHeadersWidth = 51;
            dgvJobOpenings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobOpenings.Size = new Size(785, 176);
            dgvJobOpenings.TabIndex = 11;
            dgvJobOpenings.CellContentClick += dgvJobOpenings_CellContentClick;
            dgvJobOpenings.CellValueChanged += dgvJobOpenings_CellValueChanged;
            dgvJobOpenings.CurrentCellDirtyStateChanged += dgvJobOpenings_CurrentCellDirtyStateChanged_1;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            // 
            // ColJobTitle
            // 
            ColJobTitle.HeaderText = "Job Title";
            ColJobTitle.MinimumWidth = 6;
            ColJobTitle.Name = "ColJobTitle";
            ColJobTitle.ReadOnly = true;
            // 
            // ColStatus
            // 
            ColStatus.HeaderText = "Status";
            ColStatus.MinimumWidth = 6;
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            // 
            // ColPostedDate
            // 
            ColPostedDate.HeaderText = "Posted Date";
            ColPostedDate.MinimumWidth = 6;
            ColPostedDate.Name = "ColPostedDate";
            ColPostedDate.ReadOnly = true;
            // 
            // ColActions
            // 
            ColActions.HeaderText = "Actions";
            ColActions.Items.AddRange(new object[] { "Close Hiring", "Edit Details" });
            ColActions.MinimumWidth = 6;
            ColActions.Name = "ColActions";
            ColActions.Resizable = DataGridViewTriState.True;
            ColActions.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColDescription
            // 
            ColDescription.HeaderText = "Description";
            ColDescription.MinimumWidth = 6;
            ColDescription.Name = "ColDescription";
            ColDescription.Visible = false;
            // 
            // ColRequirements
            // 
            ColRequirements.HeaderText = "Requirements";
            ColRequirements.MinimumWidth = 6;
            ColRequirements.Name = "ColRequirements";
            ColRequirements.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 18);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 10;
            label4.Text = "OPEN JOBS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(323, 109);
            label3.Name = "label3";
            label3.Size = new Size(230, 28);
            label3.TabIndex = 7;
            label3.Text = "Job openings overview";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dgvClosedJobs);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(323, 393);
            panel4.Name = "panel4";
            panel4.Size = new Size(817, 233);
            panel4.TabIndex = 10;
            // 
            // dgvClosedJobs
            // 
            dgvClosedJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClosedJobs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClosedJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClosedJobs.Columns.AddRange(new DataGridViewColumn[] { ColID2, ColJobTitle2, ColStatus2, ColPostedDate2, ColActions2, ColDescription2, ColRequirements2 });
            dgvClosedJobs.Location = new Point(14, 44);
            dgvClosedJobs.Name = "dgvClosedJobs";
            dgvClosedJobs.RowHeadersVisible = false;
            dgvClosedJobs.RowHeadersWidth = 51;
            dgvClosedJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClosedJobs.Size = new Size(785, 176);
            dgvClosedJobs.TabIndex = 11;
            dgvClosedJobs.CellContentClick += dgvClosedJobs_CellContentClick;
            dgvClosedJobs.CellValueChanged += dgvClosedJobs_CellValueChanged_1;
            dgvClosedJobs.CurrentCellDirtyStateChanged += dgvClosedJobs_CurrentCellDirtyStateChanged_1;
            // 
            // ColID2
            // 
            ColID2.HeaderText = "ID";
            ColID2.MinimumWidth = 6;
            ColID2.Name = "ColID2";
            ColID2.ReadOnly = true;
            // 
            // ColJobTitle2
            // 
            ColJobTitle2.HeaderText = "Job Title";
            ColJobTitle2.MinimumWidth = 6;
            ColJobTitle2.Name = "ColJobTitle2";
            ColJobTitle2.ReadOnly = true;
            // 
            // ColStatus2
            // 
            ColStatus2.HeaderText = "Status";
            ColStatus2.MinimumWidth = 6;
            ColStatus2.Name = "ColStatus2";
            ColStatus2.ReadOnly = true;
            // 
            // ColPostedDate2
            // 
            ColPostedDate2.HeaderText = "Posted Date";
            ColPostedDate2.MinimumWidth = 6;
            ColPostedDate2.Name = "ColPostedDate2";
            ColPostedDate2.ReadOnly = true;
            // 
            // ColActions2
            // 
            ColActions2.HeaderText = "Actions";
            ColActions2.Items.AddRange(new object[] { "Re-Open Hiring", "Edit Details" });
            ColActions2.MinimumWidth = 6;
            ColActions2.Name = "ColActions2";
            ColActions2.Resizable = DataGridViewTriState.True;
            ColActions2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColDescription2
            // 
            ColDescription2.HeaderText = "Description";
            ColDescription2.MinimumWidth = 6;
            ColDescription2.Name = "ColDescription2";
            ColDescription2.Visible = false;
            // 
            // ColRequirements2
            // 
            ColRequirements2.HeaderText = "Requirements";
            ColRequirements2.MinimumWidth = 6;
            ColRequirements2.Name = "ColRequirements2";
            ColRequirements2.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 18);
            label5.Name = "label5";
            label5.Size = new Size(122, 23);
            label5.TabIndex = 10;
            label5.Text = "CLOSED JOBS";
            // 
            // JobOpenings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 654);
            Controls.Add(panel4);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "JobOpenings";
            Text = "Job Openings";
            Load += JobOpenings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobOpenings).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClosedJobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private Label lblWelcome;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private TextBox txtSearch;
        private Button btnAddVacancy;
        private Label label4;
        private DataGridView dgvJobOpenings;
        private Panel panel4;
        private DataGridView dgvClosedJobs;
        private Label label5;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColJobTitle;
        private DataGridViewTextBoxColumn ColStatus;
        private DataGridViewTextBoxColumn ColPostedDate;
        private DataGridViewComboBoxColumn ColActions;
        private DataGridViewTextBoxColumn ColDescription;
        private DataGridViewTextBoxColumn ColRequirements;
        private DataGridViewTextBoxColumn ColID2;
        private DataGridViewTextBoxColumn ColJobTitle2;
        private DataGridViewTextBoxColumn ColStatus2;
        private DataGridViewTextBoxColumn ColPostedDate2;
        private DataGridViewComboBoxColumn ColActions2;
        private DataGridViewTextBoxColumn ColDescription2;
        private DataGridViewTextBoxColumn ColRequirements2;
    }
}