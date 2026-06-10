namespace HRApplicantWindowSystem
{
    partial class Interviews
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
            label1 = new Label();
            panel1 = new Panel();
            btnScreening = new Button();
            btnInterviewScheduling = new Button();
            btnInterviewEvaluation = new Button();
            btnBack = new Button();
            lblWelcome = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtRemarks = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnQualified = new Button();
            btnNotQualified = new Button();
            txtAppID = new TextBox();
            txtAppName = new TextBox();
            txtAppPos = new TextBox();
            dgvPendingApplicants = new DataGridView();
            dgvDocs = new DataGridView();
            label8 = new Label();
            pnlScreening = new Panel();
            pnlScheduling = new Panel();
            btnSaveSchedule = new Button();
            txtLocation = new TextBox();
            cmbInterviewType = new ComboBox();
            cmbInterviewer = new ComboBox();
            dtpSchedTime = new DateTimePicker();
            dtpSchedDate = new DateTimePicker();
            txtSchedName = new TextBox();
            dgvShortlisted = new DataGridView();
            label9 = new Label();
            pnlEvaluation = new Panel();
            btnSaveEvaluation = new Button();
            txtEvalRemarks = new TextBox();
            txtRecommendation = new TextBox();
            cmbPassFail = new ComboBox();
            nudScore = new NumericUpDown();
            txtEvalName = new TextBox();
            dgvInterviewees = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingApplicants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocs).BeginInit();
            pnlScheduling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShortlisted).BeginInit();
            pnlEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInterviewees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 31);
            label1.Name = "label1";
            label1.Size = new Size(212, 28);
            label1.TabIndex = 3;
            label1.Text = "SCREENING MODULE";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnScreening);
            panel1.Controls.Add(btnInterviewScheduling);
            panel1.Controls.Add(btnInterviewEvaluation);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblWelcome);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(138, 649);
            panel1.TabIndex = 4;
            // 
            // btnScreening
            // 
            btnScreening.Location = new Point(12, 221);
            btnScreening.Name = "btnScreening";
            btnScreening.Size = new Size(99, 60);
            btnScreening.TabIndex = 10;
            btnScreening.Text = "Screening";
            btnScreening.UseVisualStyleBackColor = true;
            btnScreening.Click += btnScreening_Click;
            // 
            // btnInterviewScheduling
            // 
            btnInterviewScheduling.Location = new Point(12, 287);
            btnInterviewScheduling.Name = "btnInterviewScheduling";
            btnInterviewScheduling.Size = new Size(99, 60);
            btnInterviewScheduling.TabIndex = 9;
            btnInterviewScheduling.Text = "Interview Scheduling";
            btnInterviewScheduling.UseVisualStyleBackColor = true;
            btnInterviewScheduling.Click += btnInterviewScheduling_Click;
            // 
            // btnInterviewEvaluation
            // 
            btnInterviewEvaluation.Location = new Point(12, 353);
            btnInterviewEvaluation.Name = "btnInterviewEvaluation";
            btnInterviewEvaluation.Size = new Size(99, 60);
            btnInterviewEvaluation.TabIndex = 8;
            btnInterviewEvaluation.Text = "Interview Evaluation";
            btnInterviewEvaluation.UseVisualStyleBackColor = true;
            btnInterviewEvaluation.Click += btnInterviewEvaluation_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(30, 585);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(81, 41);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = SystemColors.HighlightText;
            lblWelcome.Location = new Point(12, 31);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(99, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome HR!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(144, 74);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 8;
            label3.Text = "Applicant Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 245);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 9;
            label2.Text = "Submitted Documents";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(154, 433);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 10;
            label4.Text = "Screening Remarks";
            // 
            // txtRemarks
            // 
            txtRemarks.ForeColor = SystemColors.WindowFrame;
            txtRemarks.Location = new Point(154, 473);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(444, 118);
            txtRemarks.TabIndex = 12;
            txtRemarks.Text = "Enter Remarks...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(144, 119);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 13;
            label5.Text = "Applicant ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(145, 162);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 14;
            label6.Text = "Applicant Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(145, 204);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 15;
            label7.Text = "Position Applied:";
            // 
            // btnQualified
            // 
            btnQualified.BackColor = SystemColors.Highlight;
            btnQualified.FlatStyle = FlatStyle.Flat;
            btnQualified.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQualified.ForeColor = SystemColors.ButtonHighlight;
            btnQualified.Location = new Point(154, 597);
            btnQualified.Name = "btnQualified";
            btnQualified.Size = new Size(148, 29);
            btnQualified.TabIndex = 16;
            btnQualified.Text = "Qualified";
            btnQualified.UseVisualStyleBackColor = false;
            btnQualified.Click += btnQualified_Click;
            // 
            // btnNotQualified
            // 
            btnNotQualified.BackColor = SystemColors.ScrollBar;
            btnNotQualified.FlatStyle = FlatStyle.Flat;
            btnNotQualified.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNotQualified.ForeColor = SystemColors.Desktop;
            btnNotQualified.Location = new Point(339, 597);
            btnNotQualified.Name = "btnNotQualified";
            btnNotQualified.Size = new Size(148, 29);
            btnNotQualified.TabIndex = 17;
            btnNotQualified.Text = "Not Qualified";
            btnNotQualified.UseVisualStyleBackColor = false;
            btnNotQualified.Click += btnNotQualified_Click;
            // 
            // txtAppID
            // 
            txtAppID.ForeColor = SystemColors.WindowFrame;
            txtAppID.Location = new Point(272, 119);
            txtAppID.Name = "txtAppID";
            txtAppID.Size = new Size(326, 27);
            txtAppID.TabIndex = 18;
            // 
            // txtAppName
            // 
            txtAppName.ForeColor = SystemColors.WindowFrame;
            txtAppName.Location = new Point(271, 155);
            txtAppName.Name = "txtAppName";
            txtAppName.Size = new Size(326, 27);
            txtAppName.TabIndex = 19;
            // 
            // txtAppPos
            // 
            txtAppPos.ForeColor = SystemColors.WindowFrame;
            txtAppPos.Location = new Point(272, 197);
            txtAppPos.Name = "txtAppPos";
            txtAppPos.Size = new Size(326, 27);
            txtAppPos.TabIndex = 20;
            // 
            // dgvPendingApplicants
            // 
            dgvPendingApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendingApplicants.Location = new Point(603, 31);
            dgvPendingApplicants.Name = "dgvPendingApplicants";
            dgvPendingApplicants.RowHeadersWidth = 51;
            dgvPendingApplicants.Size = new Size(248, 618);
            dgvPendingApplicants.TabIndex = 7;
            // 
            // dgvDocs
            // 
            dgvDocs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocs.Location = new Point(144, 273);
            dgvDocs.Name = "dgvDocs";
            dgvDocs.RowHeadersWidth = 51;
            dgvDocs.Size = new Size(453, 140);
            dgvDocs.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(603, 8);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 22;
            label8.Text = "Pending Applicants";
            // 
            // pnlScreening
            // 
            pnlScreening.Location = new Point(145, 0);
            pnlScreening.Name = "pnlScreening";
            pnlScreening.Size = new Size(707, 649);
            pnlScreening.TabIndex = 23;
            // 
            // pnlScheduling
            // 
            pnlScheduling.BackColor = SystemColors.AppWorkspace;
            pnlScheduling.Controls.Add(btnSaveSchedule);
            pnlScheduling.Controls.Add(txtLocation);
            pnlScheduling.Controls.Add(cmbInterviewType);
            pnlScheduling.Controls.Add(cmbInterviewer);
            pnlScheduling.Controls.Add(dtpSchedTime);
            pnlScheduling.Controls.Add(dtpSchedDate);
            pnlScheduling.Controls.Add(txtSchedName);
            pnlScheduling.Controls.Add(dgvShortlisted);
            pnlScheduling.Controls.Add(label9);
            pnlScheduling.Location = new Point(142, 0);
            pnlScheduling.Name = "pnlScheduling";
            pnlScheduling.Size = new Size(709, 649);
            pnlScheduling.TabIndex = 0;
            // 
            // btnSaveSchedule
            // 
            btnSaveSchedule.Location = new Point(103, 487);
            btnSaveSchedule.Name = "btnSaveSchedule";
            btnSaveSchedule.Size = new Size(137, 42);
            btnSaveSchedule.TabIndex = 8;
            btnSaveSchedule.Text = "Save Schedule";
            btnSaveSchedule.UseVisualStyleBackColor = true;
            btnSaveSchedule.Click += btnSaveSchedule_Click;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(26, 403);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(303, 27);
            txtLocation.TabIndex = 7;
            // 
            // cmbInterviewType
            // 
            cmbInterviewType.FormattingEnabled = true;
            cmbInterviewType.Location = new Point(26, 353);
            cmbInterviewType.Name = "cmbInterviewType";
            cmbInterviewType.Size = new Size(303, 28);
            cmbInterviewType.TabIndex = 6;
            // 
            // cmbInterviewer
            // 
            cmbInterviewer.FormattingEnabled = true;
            cmbInterviewer.Location = new Point(26, 304);
            cmbInterviewer.Name = "cmbInterviewer";
            cmbInterviewer.Size = new Size(303, 28);
            cmbInterviewer.TabIndex = 5;
            // 
            // dtpSchedTime
            // 
            dtpSchedTime.Format = DateTimePickerFormat.Time;
            dtpSchedTime.Location = new Point(26, 254);
            dtpSchedTime.Name = "dtpSchedTime";
            dtpSchedTime.ShowUpDown = true;
            dtpSchedTime.Size = new Size(303, 27);
            dtpSchedTime.TabIndex = 4;
            // 
            // dtpSchedDate
            // 
            dtpSchedDate.Location = new Point(26, 204);
            dtpSchedDate.Name = "dtpSchedDate";
            dtpSchedDate.Size = new Size(303, 27);
            dtpSchedDate.TabIndex = 3;
            // 
            // txtSchedName
            // 
            txtSchedName.Location = new Point(26, 159);
            txtSchedName.Name = "txtSchedName";
            txtSchedName.ReadOnly = true;
            txtSchedName.Size = new Size(303, 27);
            txtSchedName.TabIndex = 2;
            // 
            // dgvShortlisted
            // 
            dgvShortlisted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShortlisted.Location = new Point(363, 31);
            dgvShortlisted.Name = "dgvShortlisted";
            dgvShortlisted.RowHeadersWidth = 51;
            dgvShortlisted.Size = new Size(347, 618);
            dgvShortlisted.TabIndex = 1;
            dgvShortlisted.CellContentClick += dgvShortlisted_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 11);
            label9.Name = "label9";
            label9.Size = new Size(146, 20);
            label9.TabIndex = 0;
            label9.Text = "Interview Scheduling";
            // 
            // pnlEvaluation
            // 
            pnlEvaluation.BackColor = SystemColors.ActiveCaption;
            pnlEvaluation.Controls.Add(btnSaveEvaluation);
            pnlEvaluation.Controls.Add(txtEvalRemarks);
            pnlEvaluation.Controls.Add(txtRecommendation);
            pnlEvaluation.Controls.Add(cmbPassFail);
            pnlEvaluation.Controls.Add(nudScore);
            pnlEvaluation.Controls.Add(txtEvalName);
            pnlEvaluation.Controls.Add(dgvInterviewees);
            pnlEvaluation.Location = new Point(142, 0);
            pnlEvaluation.Name = "pnlEvaluation";
            pnlEvaluation.Size = new Size(709, 649);
            pnlEvaluation.TabIndex = 9;
            // 
            // btnSaveEvaluation
            // 
            btnSaveEvaluation.Location = new Point(420, 566);
            btnSaveEvaluation.Name = "btnSaveEvaluation";
            btnSaveEvaluation.Size = new Size(181, 60);
            btnSaveEvaluation.TabIndex = 6;
            btnSaveEvaluation.Text = "Submit Evaluation";
            btnSaveEvaluation.UseVisualStyleBackColor = true;
            btnSaveEvaluation.Click += btnSaveEvaluation_Click;
            // 
            // txtEvalRemarks
            // 
            txtEvalRemarks.Location = new Point(349, 444);
            txtEvalRemarks.Multiline = true;
            txtEvalRemarks.Name = "txtEvalRemarks";
            txtEvalRemarks.Size = new Size(330, 96);
            txtEvalRemarks.TabIndex = 5;
            // 
            // txtRecommendation
            // 
            txtRecommendation.Location = new Point(361, 385);
            txtRecommendation.Name = "txtRecommendation";
            txtRecommendation.Size = new Size(293, 27);
            txtRecommendation.TabIndex = 4;
            // 
            // cmbPassFail
            // 
            cmbPassFail.FormattingEnabled = true;
            cmbPassFail.Items.AddRange(new object[] { "Pass", "Fail" });
            cmbPassFail.Location = new Point(333, 306);
            cmbPassFail.Name = "cmbPassFail";
            cmbPassFail.Size = new Size(346, 28);
            cmbPassFail.TabIndex = 3;
            // 
            // nudScore
            // 
            nudScore.Location = new Point(363, 239);
            nudScore.Name = "nudScore";
            nudScore.Size = new Size(291, 27);
            nudScore.TabIndex = 2;
            // 
            // txtEvalName
            // 
            txtEvalName.Location = new Point(376, 164);
            txtEvalName.Name = "txtEvalName";
            txtEvalName.ReadOnly = true;
            txtEvalName.Size = new Size(278, 27);
            txtEvalName.TabIndex = 1;
            // 
            // dgvInterviewees
            // 
            dgvInterviewees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInterviewees.Location = new Point(0, 0);
            dgvInterviewees.Name = "dgvInterviewees";
            dgvInterviewees.RowHeadersWidth = 51;
            dgvInterviewees.Size = new Size(264, 649);
            dgvInterviewees.TabIndex = 0;
            dgvInterviewees.CellContentClick += dgvInterviewees_CellContentClick;
            // 
            // Interviews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 649);
            Controls.Add(panel1);
            Controls.Add(pnlEvaluation);
            Controls.Add(pnlScheduling);
            Controls.Add(dgvPendingApplicants);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtAppID);
            Controls.Add(txtAppName);
            Controls.Add(txtAppPos);
            Controls.Add(dgvDocs);
            Controls.Add(btnNotQualified);
            Controls.Add(btnQualified);
            Controls.Add(label7);
            Controls.Add(txtRemarks);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(pnlScreening);
            Name = "Interviews";
            Text = "Interviews Module";
            Load += Interviews_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingApplicants).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocs).EndInit();
            pnlScheduling.ResumeLayout(false);
            pnlScheduling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShortlisted).EndInit();
            pnlEvaluation.ResumeLayout(false);
            pnlEvaluation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInterviewees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnBack;
        private Label lblWelcome;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtRemarks;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnQualified;
        private Button btnNotQualified;
        private TextBox txtAppID;
        private TextBox txtAppName;
        private TextBox txtAppPos;
        private DataGridView dgvPendingApplicants;
        private DataGridView dgvDocs;
        private Button btnInterviewScheduling;
        private Button btnInterviewEvaluation;
        private Label label8;
        private Panel pnlScreening;
        private Panel pnlScheduling;
        private DataGridView dgvShortlisted;
        private Label label9;
        private ComboBox cmbInterviewType;
        private ComboBox cmbInterviewer;
        private DateTimePicker dtpSchedTime;
        private DateTimePicker dtpSchedDate;
        private TextBox txtSchedName;
        private Button btnScreening;
        private Button btnSaveSchedule;
        private TextBox txtLocation;
        private Panel pnlEvaluation;
        private TextBox txtEvalName;
        private DataGridView dgvInterviewees;
        private Button btnSaveEvaluation;
        private TextBox txtEvalRemarks;
        private TextBox txtRecommendation;
        private ComboBox cmbPassFail;
        private NumericUpDown nudScore;
    }
}