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
            btnViewApplicantProfile = new Button();
            pnlScheduling = new Panel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
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
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            txtInterviewer = new TextBox();
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
            pnlScreening.SuspendLayout();
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
            label1.Location = new Point(9, 31);
            label1.Name = "label1";
            label1.Size = new Size(212, 28);
            label1.TabIndex = 3;
            label1.Text = "SCREENING MODULE";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
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
            label3.Location = new Point(9, 70);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 8;
            label3.Text = "Applicant Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 306);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 9;
            label2.Text = "Submitted Documents";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 485);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 10;
            label4.Text = "Screening Remarks";
            // 
            // txtRemarks
            // 
            txtRemarks.ForeColor = SystemColors.WindowFrame;
            txtRemarks.Location = new Point(154, 513);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(444, 78);
            txtRemarks.TabIndex = 12;
            txtRemarks.Text = "Enter Remarks...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 228);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 13;
            label5.Text = "Applicant ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 254);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 14;
            label6.Text = "Applicant Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 281);
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
            txtAppID.Location = new Point(130, 221);
            txtAppID.Name = "txtAppID";
            txtAppID.ReadOnly = true;
            txtAppID.Size = new Size(326, 27);
            txtAppID.TabIndex = 18;
            // 
            // txtAppName
            // 
            txtAppName.ForeColor = SystemColors.WindowFrame;
            txtAppName.Location = new Point(130, 251);
            txtAppName.Name = "txtAppName";
            txtAppName.ReadOnly = true;
            txtAppName.Size = new Size(326, 27);
            txtAppName.TabIndex = 19;
            // 
            // txtAppPos
            // 
            txtAppPos.ForeColor = SystemColors.WindowFrame;
            txtAppPos.Location = new Point(130, 278);
            txtAppPos.Name = "txtAppPos";
            txtAppPos.ReadOnly = true;
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
            dgvPendingApplicants.CellClick += dgvPendingApplicants_CellClick;
            dgvPendingApplicants.CellContentClick += dgvPendingApplicants_CellClick;
            // 
            // dgvDocs
            // 
            dgvDocs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocs.Location = new Point(3, 342);
            dgvDocs.Name = "dgvDocs";
            dgvDocs.RowHeadersWidth = 51;
            dgvDocs.Size = new Size(453, 140);
            dgvDocs.TabIndex = 21;
            dgvDocs.CellContentDoubleClick += dgvDocs_CellContentDoubleClick;
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
            pnlScreening.BackColor = SystemColors.InactiveCaption;
            pnlScreening.Controls.Add(btnViewApplicantProfile);
            pnlScreening.Controls.Add(label4);
            pnlScreening.Controls.Add(dgvDocs);
            pnlScreening.Controls.Add(label2);
            pnlScreening.Controls.Add(label1);
            pnlScreening.Controls.Add(label7);
            pnlScreening.Controls.Add(label3);
            pnlScreening.Controls.Add(label6);
            pnlScreening.Controls.Add(txtAppID);
            pnlScreening.Controls.Add(label5);
            pnlScreening.Controls.Add(txtAppName);
            pnlScreening.Controls.Add(txtAppPos);
            pnlScreening.Location = new Point(145, 0);
            pnlScreening.Name = "pnlScreening";
            pnlScreening.Size = new Size(707, 649);
            pnlScreening.TabIndex = 23;
            // 
            // btnViewApplicantProfile
            // 
            btnViewApplicantProfile.Location = new Point(3, 164);
            btnViewApplicantProfile.Name = "btnViewApplicantProfile";
            btnViewApplicantProfile.Size = new Size(453, 36);
            btnViewApplicantProfile.TabIndex = 22;
            btnViewApplicantProfile.Text = "View Applicant Profile";
            btnViewApplicantProfile.UseVisualStyleBackColor = true;
            btnViewApplicantProfile.Click += btnViewApplicantProfile_Click;
            // 
            // pnlScheduling
            // 
            pnlScheduling.BackColor = SystemColors.InactiveCaption;
            pnlScheduling.Controls.Add(label15);
            pnlScheduling.Controls.Add(label14);
            pnlScheduling.Controls.Add(label13);
            pnlScheduling.Controls.Add(label12);
            pnlScheduling.Controls.Add(label11);
            pnlScheduling.Controls.Add(label10);
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(27, 507);
            label15.Name = "label15";
            label15.Size = new Size(130, 20);
            label15.TabIndex = 14;
            label15.Text = "Interview Location";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(26, 430);
            label14.Name = "label14";
            label14.Size = new Size(104, 20);
            label14.TabIndex = 13;
            label14.Text = "Interview Type";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(26, 342);
            label13.Name = "label13";
            label13.Size = new Size(126, 20);
            label13.TabIndex = 12;
            label13.Text = "Interviewer Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 254);
            label12.Name = "label12";
            label12.Size = new Size(106, 20);
            label12.TabIndex = 11;
            label12.Text = "Interview Time";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 155);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 10;
            label11.Text = "Interview Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 75);
            label10.Name = "label10";
            label10.Size = new Size(129, 20);
            label10.TabIndex = 9;
            label10.Text = "Interviewee Name";
            // 
            // btnSaveSchedule
            // 
            btnSaveSchedule.Location = new Point(105, 585);
            btnSaveSchedule.Name = "btnSaveSchedule";
            btnSaveSchedule.Size = new Size(137, 42);
            btnSaveSchedule.TabIndex = 8;
            btnSaveSchedule.Text = "Save Schedule";
            btnSaveSchedule.UseVisualStyleBackColor = true;
            btnSaveSchedule.Click += btnSaveSchedule_Click;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(26, 530);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(303, 27);
            txtLocation.TabIndex = 7;
            // 
            // cmbInterviewType
            // 
            cmbInterviewType.FormattingEnabled = true;
            cmbInterviewType.Location = new Point(26, 463);
            cmbInterviewType.Name = "cmbInterviewType";
            cmbInterviewType.Size = new Size(303, 28);
            cmbInterviewType.TabIndex = 6;
            // 
            // cmbInterviewer
            // 
            cmbInterviewer.FormattingEnabled = true;
            cmbInterviewer.Location = new Point(26, 370);
            cmbInterviewer.Name = "cmbInterviewer";
            cmbInterviewer.Size = new Size(303, 28);
            cmbInterviewer.TabIndex = 5;
            // 
            // dtpSchedTime
            // 
            dtpSchedTime.Format = DateTimePickerFormat.Time;
            dtpSchedTime.Location = new Point(26, 287);
            dtpSchedTime.Name = "dtpSchedTime";
            dtpSchedTime.ShowUpDown = true;
            dtpSchedTime.Size = new Size(303, 27);
            dtpSchedTime.TabIndex = 4;
            // 
            // dtpSchedDate
            // 
            dtpSchedDate.Location = new Point(26, 188);
            dtpSchedDate.Name = "dtpSchedDate";
            dtpSchedDate.Size = new Size(303, 27);
            dtpSchedDate.TabIndex = 3;
            // 
            // txtSchedName
            // 
            txtSchedName.Location = new Point(26, 107);
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
            dgvShortlisted.CellClick += dgvShortlisted_CellClick;
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
            pnlEvaluation.Controls.Add(label21);
            pnlEvaluation.Controls.Add(label20);
            pnlEvaluation.Controls.Add(label19);
            pnlEvaluation.Controls.Add(label18);
            pnlEvaluation.Controls.Add(label17);
            pnlEvaluation.Controls.Add(label16);
            pnlEvaluation.Controls.Add(txtInterviewer);
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
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(313, 373);
            label21.Name = "label21";
            label21.Size = new Size(138, 20);
            label21.TabIndex = 13;
            label21.Text = "Evaluation Remarks";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(313, 306);
            label20.Name = "label20";
            label20.Size = new Size(127, 20);
            label20.TabIndex = 12;
            label20.Text = "Recommendation";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(301, 250);
            label19.Name = "label19";
            label19.Size = new Size(130, 20);
            label19.TabIndex = 11;
            label19.Text = "Interview Decision";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(313, 188);
            label18.Name = "label18";
            label18.Size = new Size(110, 20);
            label18.TabIndex = 10;
            label18.Text = "Interview Score";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(313, 114);
            label17.Name = "label17";
            label17.Size = new Size(85, 20);
            label17.TabIndex = 9;
            label17.Text = "Interviewee";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(313, 31);
            label16.Name = "label16";
            label16.Size = new Size(82, 20);
            label16.TabIndex = 8;
            label16.Text = "Interviewer";
            // 
            // txtInterviewer
            // 
            txtInterviewer.Location = new Point(349, 71);
            txtInterviewer.Name = "txtInterviewer";
            txtInterviewer.ReadOnly = true;
            txtInterviewer.Size = new Size(278, 27);
            txtInterviewer.TabIndex = 7;
            // 
            // btnSaveEvaluation
            // 
            btnSaveEvaluation.Location = new Point(405, 549);
            btnSaveEvaluation.Name = "btnSaveEvaluation";
            btnSaveEvaluation.Size = new Size(181, 60);
            btnSaveEvaluation.TabIndex = 6;
            btnSaveEvaluation.Text = "Submit Evaluation";
            btnSaveEvaluation.UseVisualStyleBackColor = true;
            btnSaveEvaluation.Click += btnSaveEvaluation_Click;
            // 
            // txtEvalRemarks
            // 
            txtEvalRemarks.Location = new Point(323, 411);
            txtEvalRemarks.Multiline = true;
            txtEvalRemarks.Name = "txtEvalRemarks";
            txtEvalRemarks.Size = new Size(330, 96);
            txtEvalRemarks.TabIndex = 5;
            // 
            // txtRecommendation
            // 
            txtRecommendation.Location = new Point(349, 335);
            txtRecommendation.Name = "txtRecommendation";
            txtRecommendation.Size = new Size(278, 27);
            txtRecommendation.TabIndex = 4;
            // 
            // cmbPassFail
            // 
            cmbPassFail.FormattingEnabled = true;
            cmbPassFail.Items.AddRange(new object[] { "Pass", "Fail" });
            cmbPassFail.Location = new Point(349, 273);
            cmbPassFail.Name = "cmbPassFail";
            cmbPassFail.Size = new Size(278, 28);
            cmbPassFail.TabIndex = 3;
            // 
            // nudScore
            // 
            nudScore.Location = new Point(349, 218);
            nudScore.Name = "nudScore";
            nudScore.Size = new Size(278, 27);
            nudScore.TabIndex = 2;
            // 
            // txtEvalName
            // 
            txtEvalName.Location = new Point(349, 148);
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
            dgvInterviewees.CellClick += dgvInterviewees_CellContentClick;
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
            Controls.Add(btnNotQualified);
            Controls.Add(btnQualified);
            Controls.Add(txtRemarks);
            Controls.Add(pnlScreening);
            Name = "Interviews";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interviews Module";
            Load += Interviews_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendingApplicants).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocs).EndInit();
            pnlScreening.ResumeLayout(false);
            pnlScreening.PerformLayout();
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
        private Button btnViewApplicantProfile;
        private Label label11;
        private Label label10;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private TextBox txtInterviewer;
    }
}