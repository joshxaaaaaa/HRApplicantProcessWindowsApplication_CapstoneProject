namespace HRApplicantWindowSystem
{
    partial class ApplicantProcess
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
            pnlHeader = new Panel();
            lblDashboard = new Label();
            lblHRApplicant = new Label();
            pnlHead = new PictureBox();
            pnlCardHired = new Panel();
            label8 = new Label();
            lblHiredCount = new Label();
            lblHired = new Label();
            pnlCardInterview = new Panel();
            label7 = new Label();
            lblInterviewCount = new Label();
            lblInterviewing = new Label();
            pnlCardShortlist = new Panel();
            label6 = new Label();
            lblShortlistCount = new Label();
            lblShortlisted = new Label();
            pnlCardPending = new Panel();
            label5 = new Label();
            lblPendingCount = new Label();
            lblPending = new Label();
            pnlCardTotal = new Panel();
            label4 = new Label();
            lblTotalCount = new Label();
            lblTotalApps = new Label();
            panel1 = new Panel();
            txtSearchApplicant = new TextBox();
            lblApplicantList = new Label();
            dgvApplicantList = new DataGridView();
            panel2 = new Panel();
            btnLockReview = new Button();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtProfileName = new TextBox();
            txtProfileEmail = new TextBox();
            txtProfilePhone = new TextBox();
            txtProfilePosition = new TextBox();
            txtProfileStatus = new TextBox();
            lblSummaryStatus = new Label();
            lblSummaryPosition = new Label();
            lblSummaryPhone = new Label();
            lblSummaryEmail = new Label();
            lblSummaryName = new Label();
            tabPage2 = new TabPage();
            dgvDocuments = new DataGridView();
            label1 = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHead).BeginInit();
            pnlCardHired.SuspendLayout();
            pnlCardInterview.SuspendLayout();
            pnlCardShortlist.SuspendLayout();
            pnlCardPending.SuspendLayout();
            pnlCardTotal.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicantList).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblDashboard);
            pnlHeader.Controls.Add(lblHRApplicant);
            pnlHeader.Controls.Add(pnlHead);
            pnlHeader.Controls.Add(pnlCardHired);
            pnlHeader.Controls.Add(pnlCardInterview);
            pnlHeader.Controls.Add(pnlCardShortlist);
            pnlHeader.Controls.Add(pnlCardPending);
            pnlHeader.Controls.Add(pnlCardTotal);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(982, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.DimGray;
            lblDashboard.Location = new Point(114, 33);
            lblDashboard.Margin = new Padding(2, 0, 2, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(115, 25);
            lblDashboard.TabIndex = 8;
            lblDashboard.Text = "Dashboard";
            // 
            // lblHRApplicant
            // 
            lblHRApplicant.AutoSize = true;
            lblHRApplicant.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHRApplicant.ForeColor = Color.DimGray;
            lblHRApplicant.Location = new Point(117, 9);
            lblHRApplicant.Margin = new Padding(2, 0, 2, 0);
            lblHRApplicant.Name = "lblHRApplicant";
            lblHRApplicant.Size = new Size(210, 25);
            lblHRApplicant.TabIndex = 2;
            lblHRApplicant.Text = "HR Applicant Process";
            // 
            // pnlHead
            // 
            pnlHead.Image = Properties.Resources._714323130_2215697265832471_2008652124694261117_n_removebg_preview;
            pnlHead.Location = new Point(10, -5);
            pnlHead.Margin = new Padding(2);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(102, 85);
            pnlHead.SizeMode = PictureBoxSizeMode.Zoom;
            pnlHead.TabIndex = 7;
            pnlHead.TabStop = false;
            // 
            // pnlCardHired
            // 
            pnlCardHired.BackColor = Color.MintCream;
            pnlCardHired.BorderStyle = BorderStyle.FixedSingle;
            pnlCardHired.Controls.Add(label8);
            pnlCardHired.Controls.Add(lblHiredCount);
            pnlCardHired.Controls.Add(lblHired);
            pnlCardHired.Location = new Point(832, 16);
            pnlCardHired.Margin = new Padding(2);
            pnlCardHired.Name = "pnlCardHired";
            pnlCardHired.Size = new Size(112, 48);
            pnlCardHired.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6F);
            label8.Location = new Point(3, 3);
            label8.Name = "label8";
            label8.Size = new Size(28, 12);
            label8.TabIndex = 8;
            label8.Text = "Hired";
            // 
            // lblHiredCount
            // 
            lblHiredCount.AutoSize = true;
            lblHiredCount.Location = new Point(4, 20);
            lblHiredCount.Margin = new Padding(2, 0, 2, 0);
            lblHiredCount.Name = "lblHiredCount";
            lblHiredCount.Size = new Size(0, 20);
            lblHiredCount.TabIndex = 5;
            // 
            // lblHired
            // 
            lblHired.AutoSize = true;
            lblHired.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblHired.ForeColor = Color.DarkCyan;
            lblHired.Location = new Point(49, 19);
            lblHired.Margin = new Padding(2, 0, 2, 0);
            lblHired.Name = "lblHired";
            lblHired.Size = new Size(20, 20);
            lblHired.TabIndex = 4;
            lblHired.Text = "A";
            // 
            // pnlCardInterview
            // 
            pnlCardInterview.BackColor = Color.Azure;
            pnlCardInterview.BorderStyle = BorderStyle.FixedSingle;
            pnlCardInterview.Controls.Add(label7);
            pnlCardInterview.Controls.Add(lblInterviewCount);
            pnlCardInterview.Controls.Add(lblInterviewing);
            pnlCardInterview.Location = new Point(708, 16);
            pnlCardInterview.Margin = new Padding(2);
            pnlCardInterview.Name = "pnlCardInterview";
            pnlCardInterview.Size = new Size(112, 48);
            pnlCardInterview.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6F);
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(58, 12);
            label7.TabIndex = 7;
            label7.Text = "Interviewing";
            // 
            // lblInterviewCount
            // 
            lblInterviewCount.AutoSize = true;
            lblInterviewCount.Location = new Point(4, 20);
            lblInterviewCount.Margin = new Padding(2, 0, 2, 0);
            lblInterviewCount.Name = "lblInterviewCount";
            lblInterviewCount.Size = new Size(0, 20);
            lblInterviewCount.TabIndex = 5;
            // 
            // lblInterviewing
            // 
            lblInterviewing.AutoSize = true;
            lblInterviewing.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblInterviewing.ForeColor = Color.SteelBlue;
            lblInterviewing.Location = new Point(45, 20);
            lblInterviewing.Margin = new Padding(2, 0, 2, 0);
            lblInterviewing.Name = "lblInterviewing";
            lblInterviewing.Size = new Size(20, 20);
            lblInterviewing.TabIndex = 4;
            lblInterviewing.Text = "A";
            // 
            // pnlCardShortlist
            // 
            pnlCardShortlist.BackColor = Color.Honeydew;
            pnlCardShortlist.BorderStyle = BorderStyle.FixedSingle;
            pnlCardShortlist.Controls.Add(label6);
            pnlCardShortlist.Controls.Add(lblShortlistCount);
            pnlCardShortlist.Controls.Add(lblShortlisted);
            pnlCardShortlist.Location = new Point(584, 16);
            pnlCardShortlist.Margin = new Padding(2);
            pnlCardShortlist.Name = "pnlCardShortlist";
            pnlCardShortlist.Size = new Size(112, 48);
            pnlCardShortlist.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 6F);
            label6.Location = new Point(4, 3);
            label6.Name = "label6";
            label6.Size = new Size(50, 12);
            label6.TabIndex = 6;
            label6.Text = "Shortlisted";
            // 
            // lblShortlistCount
            // 
            lblShortlistCount.AutoSize = true;
            lblShortlistCount.Location = new Point(4, 20);
            lblShortlistCount.Margin = new Padding(2, 0, 2, 0);
            lblShortlistCount.Name = "lblShortlistCount";
            lblShortlistCount.Size = new Size(0, 20);
            lblShortlistCount.TabIndex = 5;
            // 
            // lblShortlisted
            // 
            lblShortlisted.AutoSize = true;
            lblShortlisted.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblShortlisted.ForeColor = Color.MediumAquamarine;
            lblShortlisted.Location = new Point(46, 21);
            lblShortlisted.Margin = new Padding(2, 0, 2, 0);
            lblShortlisted.Name = "lblShortlisted";
            lblShortlisted.Size = new Size(20, 20);
            lblShortlisted.TabIndex = 4;
            lblShortlisted.Text = "A";
            // 
            // pnlCardPending
            // 
            pnlCardPending.BackColor = Color.Moccasin;
            pnlCardPending.BorderStyle = BorderStyle.FixedSingle;
            pnlCardPending.Controls.Add(label5);
            pnlCardPending.Controls.Add(lblPendingCount);
            pnlCardPending.Controls.Add(lblPending);
            pnlCardPending.Location = new Point(460, 16);
            pnlCardPending.Margin = new Padding(2);
            pnlCardPending.Name = "pnlCardPending";
            pnlCardPending.Size = new Size(112, 48);
            pnlCardPending.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 6F);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(75, 12);
            label5.TabIndex = 6;
            label5.Text = "Pending Review";
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Location = new Point(4, 20);
            lblPendingCount.Margin = new Padding(2, 0, 2, 0);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(0, 20);
            lblPendingCount.TabIndex = 5;
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblPending.ForeColor = Color.DarkGoldenrod;
            lblPending.Location = new Point(42, 21);
            lblPending.Margin = new Padding(2, 0, 2, 0);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(20, 20);
            lblPending.TabIndex = 4;
            lblPending.Text = "A";
            // 
            // pnlCardTotal
            // 
            pnlCardTotal.BackColor = Color.AliceBlue;
            pnlCardTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlCardTotal.Controls.Add(label4);
            pnlCardTotal.Controls.Add(lblTotalCount);
            pnlCardTotal.Controls.Add(lblTotalApps);
            pnlCardTotal.Location = new Point(336, 16);
            pnlCardTotal.Margin = new Padding(2);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Size = new Size(112, 48);
            pnlCardTotal.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6F);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(73, 12);
            label4.TabIndex = 6;
            label4.Text = "Total Applicants";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Location = new Point(9, 19);
            lblTotalCount.Margin = new Padding(2, 0, 2, 0);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(0, 20);
            lblTotalCount.TabIndex = 5;
            lblTotalCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalApps
            // 
            lblTotalApps.AutoSize = true;
            lblTotalApps.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblTotalApps.ForeColor = Color.DeepSkyBlue;
            lblTotalApps.Location = new Point(39, 21);
            lblTotalApps.Margin = new Padding(2, 0, 2, 0);
            lblTotalApps.Name = "lblTotalApps";
            lblTotalApps.Size = new Size(20, 20);
            lblTotalApps.TabIndex = 4;
            lblTotalApps.Text = "A";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearchApplicant);
            panel1.Controls.Add(lblApplicantList);
            panel1.Controls.Add(dgvApplicantList);
            panel1.Location = new Point(0, 84);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8);
            panel1.Size = new Size(465, 471);
            panel1.TabIndex = 0;
            // 
            // txtSearchApplicant
            // 
            txtSearchApplicant.Location = new Point(7, 39);
            txtSearchApplicant.Name = "txtSearchApplicant";
            txtSearchApplicant.Size = new Size(450, 27);
            txtSearchApplicant.TabIndex = 2;
            txtSearchApplicant.TextChanged += txtSearchApplicant_TextChanged;
            // 
            // lblApplicantList
            // 
            lblApplicantList.AutoSize = true;
            lblApplicantList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApplicantList.ForeColor = Color.DimGray;
            lblApplicantList.Location = new Point(7, 8);
            lblApplicantList.Margin = new Padding(2, 0, 2, 0);
            lblApplicantList.Name = "lblApplicantList";
            lblApplicantList.Size = new Size(165, 28);
            lblApplicantList.TabIndex = 0;
            lblApplicantList.Text = "APPLICANT LIST";
            // 
            // dgvApplicantList
            // 
            dgvApplicantList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicantList.Dock = DockStyle.Bottom;
            dgvApplicantList.Location = new Point(8, 71);
            dgvApplicantList.Margin = new Padding(2);
            dgvApplicantList.Name = "dgvApplicantList";
            dgvApplicantList.RowHeadersWidth = 62;
            dgvApplicantList.Size = new Size(449, 392);
            dgvApplicantList.TabIndex = 1;
            dgvApplicantList.CellContentClick += dgvApplicantList_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnLockReview);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tabControl1);
            panel2.Location = new Point(469, 84);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8);
            panel2.Size = new Size(513, 471);
            panel2.TabIndex = 1;
            // 
            // btnLockReview
            // 
            btnLockReview.BackColor = Color.FromArgb(128, 255, 255);
            btnLockReview.Location = new Point(375, 25);
            btnLockReview.Name = "btnLockReview";
            btnLockReview.Size = new Size(123, 36);
            btnLockReview.TabIndex = 8;
            btnLockReview.Text = "Lock for Review";
            btnLockReview.UseVisualStyleBackColor = false;
            btnLockReview.Click += btnLockReview_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(5, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 28);
            label2.TabIndex = 2;
            label2.Text = "APPLICANT REVIEW";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(8, 37);
            tabControl1.Margin = new Padding(2);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(497, 426);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtProfileName);
            tabPage1.Controls.Add(txtProfileEmail);
            tabPage1.Controls.Add(txtProfilePhone);
            tabPage1.Controls.Add(txtProfilePosition);
            tabPage1.Controls.Add(txtProfileStatus);
            tabPage1.Controls.Add(lblSummaryStatus);
            tabPage1.Controls.Add(lblSummaryPosition);
            tabPage1.Controls.Add(lblSummaryPhone);
            tabPage1.Controls.Add(lblSummaryEmail);
            tabPage1.Controls.Add(lblSummaryName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(489, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Profile Summary";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtProfileName
            // 
            txtProfileName.Location = new Point(73, 25);
            txtProfileName.Margin = new Padding(2);
            txtProfileName.Multiline = true;
            txtProfileName.Name = "txtProfileName";
            txtProfileName.Size = new Size(412, 26);
            txtProfileName.TabIndex = 9;
            // 
            // txtProfileEmail
            // 
            txtProfileEmail.Location = new Point(73, 68);
            txtProfileEmail.Margin = new Padding(2);
            txtProfileEmail.Multiline = true;
            txtProfileEmail.Name = "txtProfileEmail";
            txtProfileEmail.Size = new Size(412, 26);
            txtProfileEmail.TabIndex = 8;
            // 
            // txtProfilePhone
            // 
            txtProfilePhone.Location = new Point(73, 112);
            txtProfilePhone.Margin = new Padding(2);
            txtProfilePhone.Multiline = true;
            txtProfilePhone.Name = "txtProfilePhone";
            txtProfilePhone.Size = new Size(412, 26);
            txtProfilePhone.TabIndex = 7;
            // 
            // txtProfilePosition
            // 
            txtProfilePosition.Location = new Point(73, 158);
            txtProfilePosition.Margin = new Padding(2);
            txtProfilePosition.Multiline = true;
            txtProfilePosition.Name = "txtProfilePosition";
            txtProfilePosition.Size = new Size(412, 26);
            txtProfilePosition.TabIndex = 6;
            // 
            // txtProfileStatus
            // 
            txtProfileStatus.Location = new Point(73, 213);
            txtProfileStatus.Margin = new Padding(2);
            txtProfileStatus.Multiline = true;
            txtProfileStatus.Name = "txtProfileStatus";
            txtProfileStatus.Size = new Size(412, 26);
            txtProfileStatus.TabIndex = 5;
            // 
            // lblSummaryStatus
            // 
            lblSummaryStatus.AutoSize = true;
            lblSummaryStatus.ForeColor = Color.Black;
            lblSummaryStatus.Location = new Point(5, 213);
            lblSummaryStatus.Margin = new Padding(2, 0, 2, 0);
            lblSummaryStatus.Name = "lblSummaryStatus";
            lblSummaryStatus.Size = new Size(52, 20);
            lblSummaryStatus.TabIndex = 4;
            lblSummaryStatus.Text = "Status:";
            // 
            // lblSummaryPosition
            // 
            lblSummaryPosition.AutoSize = true;
            lblSummaryPosition.ForeColor = Color.Black;
            lblSummaryPosition.Location = new Point(5, 163);
            lblSummaryPosition.Margin = new Padding(2, 0, 2, 0);
            lblSummaryPosition.Name = "lblSummaryPosition";
            lblSummaryPosition.Size = new Size(64, 20);
            lblSummaryPosition.TabIndex = 3;
            lblSummaryPosition.Text = "Position:";
            // 
            // lblSummaryPhone
            // 
            lblSummaryPhone.AutoSize = true;
            lblSummaryPhone.ForeColor = Color.Black;
            lblSummaryPhone.Location = new Point(5, 114);
            lblSummaryPhone.Margin = new Padding(2, 0, 2, 0);
            lblSummaryPhone.Name = "lblSummaryPhone";
            lblSummaryPhone.Size = new Size(53, 20);
            lblSummaryPhone.TabIndex = 2;
            lblSummaryPhone.Text = "Phone:";
            // 
            // lblSummaryEmail
            // 
            lblSummaryEmail.AutoSize = true;
            lblSummaryEmail.ForeColor = Color.Black;
            lblSummaryEmail.Location = new Point(5, 68);
            lblSummaryEmail.Margin = new Padding(2, 0, 2, 0);
            lblSummaryEmail.Name = "lblSummaryEmail";
            lblSummaryEmail.Size = new Size(49, 20);
            lblSummaryEmail.TabIndex = 1;
            lblSummaryEmail.Text = "Email:";
            // 
            // lblSummaryName
            // 
            lblSummaryName.AutoSize = true;
            lblSummaryName.ForeColor = Color.Black;
            lblSummaryName.Location = new Point(5, 25);
            lblSummaryName.Margin = new Padding(2, 0, 2, 0);
            lblSummaryName.Name = "lblSummaryName";
            lblSummaryName.Size = new Size(52, 20);
            lblSummaryName.TabIndex = 0;
            lblSummaryName.Text = "Name:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvDocuments);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(489, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Documents";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDocuments
            // 
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Location = new Point(5, 52);
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.RowHeadersWidth = 51;
            dgvDocuments.Size = new Size(479, 336);
            dgvDocuments.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(119, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 23);
            label1.TabIndex = 4;
            label1.Text = "Document Information";
            // 
            // ApplicantProcess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(982, 555);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlHeader);
            ForeColor = Color.Gray;
            Margin = new Padding(2);
            Name = "ApplicantProcess";
            Text = "HR Applicant Process System - Dashboard";
            Load += ApplicantProcess_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHead).EndInit();
            pnlCardHired.ResumeLayout(false);
            pnlCardHired.PerformLayout();
            pnlCardInterview.ResumeLayout(false);
            pnlCardInterview.PerformLayout();
            pnlCardShortlist.ResumeLayout(false);
            pnlCardShortlist.PerformLayout();
            pnlCardPending.ResumeLayout(false);
            pnlCardPending.PerformLayout();
            pnlCardTotal.ResumeLayout(false);
            pnlCardTotal.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicantList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel panel1;
        private Label lblApplicantList;
        private DataGridView dgvApplicantList;
        private Panel panel2;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel pnlCardTotal;
        private Label lblTotalApps;
        private Panel pnlCardHired;
        private Label lblHired;
        private Panel pnlCardInterview;
        private Label lblInterviewing;
        private Panel pnlCardShortlist;
        private Label lblShortlisted;
        private Panel pnlCardPending;
        private Label lblPending;
        private PictureBox pnlHead;
        private Label lblHRApplicant;
        private Label lblDashboard;
        private Label lblSummaryEmail;
        private Label lblSummaryName;
        private Label lblSummaryPhone;
        private TextBox txtProfileStatus;
        private Label lblSummaryStatus;
        private Label lblSummaryPosition;
        private Label lblTotalCount;
        private Label lblHiredCount;
        private Label lblInterviewCount;
        private Label lblShortlistCount;
        private Label lblPendingCount;
        private TabPage tabPage2;
        private Label label1;
        private TextBox txtProfileName;
        private TextBox txtProfileEmail;
        private TextBox txtProfilePhone;
        private TextBox txtProfilePosition;
        private TextBox txtSearchApplicant;
        private Button btnLockReview;
        private DataGridView dgvDocuments;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}