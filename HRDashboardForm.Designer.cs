namespace HRApplicantWindowSystem
{
    partial class HRDashboardForm
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
            btnAdminPanel = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            btnInterviews = new Button();
            btnApplicants = new Button();
            btnJobs = new Button();
            btnDashboard = new Button();
            pnlDashboardSummary = new Panel();
            panel3 = new Panel();
            dgvRecentApplicants = new DataGridView();
            label2 = new Label();
            txtSearchApplicants = new TextBox();
            lblTotalApplicants = new Label();
            panel4 = new Panel();
            dgvRecentJobs = new DataGridView();
            txtSearchJobs = new TextBox();
            label3 = new Label();
            lblOpenJobs = new Label();
            panel5 = new Panel();
            txtSearchPending = new TextBox();
            dgvPendingActions = new DataGridView();
            lblPendingApplications = new Label();
            label4 = new Label();
            label1 = new Label();
            pnlWelcome = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pnlReports = new Panel();
            dgvReportPreview = new DataGridView();
            btnExportReport = new Button();
            cmbReportType = new ComboBox();
            label6 = new Label();
            panel1.SuspendLayout();
            pnlDashboardSummary.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentApplicants).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentJobs).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingActions).BeginInit();
            pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportPreview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnAdminPanel);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnInterviews);
            panel1.Controls.Add(btnApplicants);
            panel1.Controls.Add(btnJobs);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 638);
            panel1.TabIndex = 0;
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.Location = new Point(28, 477);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(228, 62);
            btnAdminPanel.TabIndex = 7;
            btnAdminPanel.Text = "Admin Settings";
            btnAdminPanel.UseVisualStyleBackColor = true;
            btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(28, 564);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(228, 62);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(28, 388);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(228, 62);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnInterviews
            // 
            btnInterviews.Location = new Point(28, 210);
            btnInterviews.Name = "btnInterviews";
            btnInterviews.Size = new Size(228, 62);
            btnInterviews.TabIndex = 4;
            btnInterviews.Text = "Interviews";
            btnInterviews.UseVisualStyleBackColor = true;
            // 
            // btnApplicants
            // 
            btnApplicants.Location = new Point(28, 129);
            btnApplicants.Name = "btnApplicants";
            btnApplicants.Size = new Size(228, 62);
            btnApplicants.TabIndex = 3;
            btnApplicants.Text = "Applicants";
            btnApplicants.UseVisualStyleBackColor = true;
            // 
            // btnJobs
            // 
            btnJobs.Location = new Point(28, 299);
            btnJobs.Name = "btnJobs";
            btnJobs.Size = new Size(228, 62);
            btnJobs.TabIndex = 2;
            btnJobs.Text = "Jobs Vacancy Management";
            btnJobs.UseVisualStyleBackColor = true;
            btnJobs.Click += btnJobs_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(28, 46);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(228, 62);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlDashboardSummary
            // 
            pnlDashboardSummary.BackColor = SystemColors.Info;
            pnlDashboardSummary.Controls.Add(panel3);
            pnlDashboardSummary.Controls.Add(panel4);
            pnlDashboardSummary.Controls.Add(panel5);
            pnlDashboardSummary.Controls.Add(label1);
            pnlDashboardSummary.Dock = DockStyle.Fill;
            pnlDashboardSummary.Location = new Point(305, 0);
            pnlDashboardSummary.Name = "pnlDashboardSummary";
            pnlDashboardSummary.Size = new Size(847, 638);
            pnlDashboardSummary.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(dgvRecentApplicants);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtSearchApplicants);
            panel3.Controls.Add(lblTotalApplicants);
            panel3.Location = new Point(55, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 389);
            panel3.TabIndex = 1;
            // 
            // dgvRecentApplicants
            // 
            dgvRecentApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentApplicants.BackgroundColor = SystemColors.ActiveCaption;
            dgvRecentApplicants.BorderStyle = BorderStyle.None;
            dgvRecentApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentApplicants.ColumnHeadersVisible = false;
            dgvRecentApplicants.Location = new Point(3, 76);
            dgvRecentApplicants.Name = "dgvRecentApplicants";
            dgvRecentApplicants.RowHeadersVisible = false;
            dgvRecentApplicants.RowHeadersWidth = 51;
            dgvRecentApplicants.Size = new Size(217, 310);
            dgvRecentApplicants.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 20);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Total Applicants";
            // 
            // txtSearchApplicants
            // 
            txtSearchApplicants.Location = new Point(-3, 43);
            txtSearchApplicants.Name = "txtSearchApplicants";
            txtSearchApplicants.Size = new Size(223, 27);
            txtSearchApplicants.TabIndex = 9;
            txtSearchApplicants.Tag = "Search Applicants...";
            txtSearchApplicants.TextChanged += txtSearchApplicants_TextChanged;
            // 
            // lblTotalApplicants
            // 
            lblTotalApplicants.AutoSize = true;
            lblTotalApplicants.Location = new Point(192, 20);
            lblTotalApplicants.Name = "lblTotalApplicants";
            lblTotalApplicants.Size = new Size(17, 20);
            lblTotalApplicants.TabIndex = 3;
            lblTotalApplicants.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(dgvRecentJobs);
            panel4.Controls.Add(txtSearchJobs);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(lblOpenJobs);
            panel4.Location = new Point(304, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 389);
            panel4.TabIndex = 2;
            // 
            // dgvRecentJobs
            // 
            dgvRecentJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentJobs.BackgroundColor = SystemColors.ActiveCaption;
            dgvRecentJobs.BorderStyle = BorderStyle.None;
            dgvRecentJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentJobs.ColumnHeadersVisible = false;
            dgvRecentJobs.Location = new Point(3, 76);
            dgvRecentJobs.Name = "dgvRecentJobs";
            dgvRecentJobs.RowHeadersVisible = false;
            dgvRecentJobs.RowHeadersWidth = 51;
            dgvRecentJobs.Size = new Size(217, 310);
            dgvRecentJobs.TabIndex = 5;
            // 
            // txtSearchJobs
            // 
            txtSearchJobs.Location = new Point(0, 46);
            txtSearchJobs.Name = "txtSearchJobs";
            txtSearchJobs.Size = new Size(223, 27);
            txtSearchJobs.TabIndex = 10;
            txtSearchJobs.Tag = "Search Jobs...";
            txtSearchJobs.TextChanged += txtSearchJobs_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 20);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Open Jobs";
            // 
            // lblOpenJobs
            // 
            lblOpenJobs.AutoSize = true;
            lblOpenJobs.Location = new Point(177, 20);
            lblOpenJobs.Name = "lblOpenJobs";
            lblOpenJobs.Size = new Size(17, 20);
            lblOpenJobs.TabIndex = 4;
            lblOpenJobs.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(txtSearchPending);
            panel5.Controls.Add(dgvPendingActions);
            panel5.Controls.Add(lblPendingApplications);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(548, 118);
            panel5.Name = "panel5";
            panel5.Size = new Size(223, 389);
            panel5.TabIndex = 2;
            // 
            // txtSearchPending
            // 
            txtSearchPending.Location = new Point(0, 43);
            txtSearchPending.Name = "txtSearchPending";
            txtSearchPending.Size = new Size(223, 27);
            txtSearchPending.TabIndex = 11;
            txtSearchPending.Tag = "Search Pendings...";
            txtSearchPending.TextChanged += txtSearchPending_TextChanged;
            // 
            // dgvPendingActions
            // 
            dgvPendingActions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPendingActions.BackgroundColor = SystemColors.ActiveCaption;
            dgvPendingActions.BorderStyle = BorderStyle.None;
            dgvPendingActions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendingActions.ColumnHeadersVisible = false;
            dgvPendingActions.Location = new Point(3, 76);
            dgvPendingActions.Name = "dgvPendingActions";
            dgvPendingActions.RowHeadersVisible = false;
            dgvPendingActions.RowHeadersWidth = 51;
            dgvPendingActions.Size = new Size(217, 310);
            dgvPendingActions.TabIndex = 6;
            // 
            // lblPendingApplications
            // 
            lblPendingApplications.AutoSize = true;
            lblPendingApplications.Location = new Point(191, 20);
            lblPendingApplications.Name = "lblPendingApplications";
            lblPendingApplications.Size = new Size(17, 20);
            lblPendingApplications.TabIndex = 5;
            lblPendingApplications.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 20);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 5;
            label4.Text = "Pending Applications";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 46);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "Dashboard Summary";
            // 
            // pnlWelcome
            // 
            pnlWelcome.Controls.Add(label5);
            pnlWelcome.Controls.Add(pictureBox1);
            pnlWelcome.Dock = DockStyle.Fill;
            pnlWelcome.Location = new Point(305, 0);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(847, 638);
            pnlWelcome.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 30);
            label5.Name = "label5";
            label5.Size = new Size(553, 20);
            label5.TabIndex = 8;
            label5.Text = "Welcome to the HR Management Portal! Select an option from the menu to begin.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._669691451_26325044287151514_249119427592236573_n;
            pictureBox1.Location = new Point(20, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 564);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlReports
            // 
            pnlReports.Controls.Add(dgvReportPreview);
            pnlReports.Controls.Add(btnExportReport);
            pnlReports.Controls.Add(cmbReportType);
            pnlReports.Controls.Add(label6);
            pnlReports.Dock = DockStyle.Fill;
            pnlReports.Location = new Point(305, 0);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(847, 638);
            pnlReports.TabIndex = 8;
            pnlReports.Paint += pnlReports_Paint;
            // 
            // dgvReportPreview
            // 
            dgvReportPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportPreview.Location = new Point(38, 99);
            dgvReportPreview.Name = "dgvReportPreview";
            dgvReportPreview.RowHeadersWidth = 51;
            dgvReportPreview.Size = new Size(773, 440);
            dgvReportPreview.TabIndex = 13;
            // 
            // btnExportReport
            // 
            btnExportReport.Location = new Point(688, 564);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(123, 51);
            btnExportReport.TabIndex = 12;
            btnExportReport.Text = "Export to Excel (CSV)";
            btnExportReport.UseVisualStyleBackColor = true;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Applicant List", "Pending Applications", "Interview Schedules", "Accepted/Rejected Applicants" });
            cmbReportType.Location = new Point(38, 64);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(212, 28);
            cmbReportType.TabIndex = 11;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 30);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 10;
            label6.Text = "Select Report Type: ";
            // 
            // HRDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 638);
            Controls.Add(pnlWelcome);
            Controls.Add(pnlReports);
            Controls.Add(pnlDashboardSummary);
            Controls.Add(panel1);
            Name = "HRDashboardForm";
            Text = "HR UI";
            Load += HRDashboardForm_Load;
            panel1.ResumeLayout(false);
            pnlDashboardSummary.ResumeLayout(false);
            pnlDashboardSummary.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentApplicants).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentJobs).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingActions).EndInit();
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnReports;
        private Button btnInterviews;
        private Button btnApplicants;
        private Button btnJobs;
        private Panel pnlDashboardSummary;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel5;
        private Label lblPendingApplications;
        private Panel panel4;
        private Label lblOpenJobs;
        private Panel panel3;
        private Label lblTotalApplicants;
        private Button button7;
        private Button btnAdminPanel;
        private Panel pnlWelcome;
        private PictureBox pictureBox1;
        private Label label5;
        private DataGridView dgvPendingActions;
        private DataGridView dgvRecentJobs;
        private DataGridView dgvRecentApplicants;
        private TextBox txtSearchPending;
        private TextBox txtSearchJobs;
        private TextBox txtSearchApplicants;
        private Panel pnlReports;
        private DataGridView dgvReportPreview;
        private Button btnExportReport;
        private ComboBox cmbReportType;
        private Label label6;
    }
}