namespace HRApplicantWindowSystem
{
    partial class Form1
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
            lblHiredCount = new Label();
            label8 = new Label();
            pnlCardInterview = new Panel();
            lblInterviewCount = new Label();
            label7 = new Label();
            pnlCardShortlist = new Panel();
            lblShortlistCount = new Label();
            label6 = new Label();
            pnlCardPending = new Panel();
            lblPendingCount = new Label();
            label5 = new Label();
            pnlCardTotal = new Panel();
            lblTotalCount = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lblApplicantList = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtNotesBox = new TextBox();
            lblSummaryStatus = new Label();
            lblSummaryPosition = new Label();
            lblSummaryPhone = new Label();
            lblSummaryEmail = new Label();
            lblSummaryName = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            tabPage2 = new TabPage();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtDocSummary = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            grpEligibility = new GroupBox();
            lblChecklistHeader = new Label();
            chkResumeVerified = new CheckBox();
            chkInterviewScheduled = new CheckBox();
            chkReferenceCheck = new CheckBox();
            chkBackgroundClearance = new CheckBox();
            btnSaveChecklist = new Button();
            lblNotesHeader = new Label();
            txtHRNotes = new TextBox();
            btnSaveNotes = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHead).BeginInit();
            pnlCardHired.SuspendLayout();
            pnlCardInterview.SuspendLayout();
            pnlCardShortlist.SuspendLayout();
            pnlCardPending.SuspendLayout();
            pnlCardTotal.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            grpEligibility.SuspendLayout();
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
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1228, 100);
            pnlHeader.TabIndex = 0;
            
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = Color.DimGray;
            lblDashboard.Location = new Point(142, 41);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(133, 30);
            lblDashboard.TabIndex = 8;
            lblDashboard.Text = "Dashboard";
            
            // 
            // lblHRApplicant
            // 
            lblHRApplicant.AutoSize = true;
            lblHRApplicant.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHRApplicant.ForeColor = Color.DimGray;
            lblHRApplicant.Location = new Point(146, 11);
            lblHRApplicant.Name = "lblHRApplicant";
            lblHRApplicant.Size = new Size(244, 30);
            lblHRApplicant.TabIndex = 2;
            lblHRApplicant.Text = "HR Applicant Process";
            
            // 
            // pnlHead
            // 
            pnlHead.Image = Properties.Resources._714323130_2215697265832471_2008652124694261117_n_removebg_preview;
            pnlHead.Location = new Point(13, -6);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(127, 106);
            pnlHead.SizeMode = PictureBoxSizeMode.Zoom;
            pnlHead.TabIndex = 7;
            pnlHead.TabStop = false;
            // 
            // pnlCardHired
            // 
            pnlCardHired.BackColor = Color.MintCream;
            pnlCardHired.BorderStyle = BorderStyle.FixedSingle;
            pnlCardHired.Controls.Add(lblHiredCount);
            pnlCardHired.Controls.Add(label8);
            pnlCardHired.Location = new Point(1040, 20);
            pnlCardHired.Name = "pnlCardHired";
            pnlCardHired.Size = new Size(140, 60);
            pnlCardHired.TabIndex = 6;
            // 
            // lblHiredCount
            // 
            lblHiredCount.AutoSize = true;
            lblHiredCount.Location = new Point(5, 25);
            lblHiredCount.Name = "lblHiredCount";
            lblHiredCount.Size = new Size(0, 25);
            lblHiredCount.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(5, 4);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 4;
            label8.Text = "Hired";
            
            // 
            // pnlCardInterview
            // 
            pnlCardInterview.BackColor = Color.Azure;
            pnlCardInterview.BorderStyle = BorderStyle.FixedSingle;
            pnlCardInterview.Controls.Add(lblInterviewCount);
            pnlCardInterview.Controls.Add(label7);
            pnlCardInterview.Location = new Point(885, 20);
            pnlCardInterview.Name = "pnlCardInterview";
            pnlCardInterview.Size = new Size(140, 60);
            pnlCardInterview.TabIndex = 5;
            // 
            // lblInterviewCount
            // 
            lblInterviewCount.AutoSize = true;
            lblInterviewCount.Location = new Point(5, 25);
            lblInterviewCount.Name = "lblInterviewCount";
            lblInterviewCount.Size = new Size(0, 25);
            lblInterviewCount.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(5, 4);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 4;
            label7.Text = "Interviewing";
            // 
            // pnlCardShortlist
            // 
            pnlCardShortlist.BackColor = Color.Honeydew;
            pnlCardShortlist.BorderStyle = BorderStyle.FixedSingle;
            pnlCardShortlist.Controls.Add(lblShortlistCount);
            pnlCardShortlist.Controls.Add(label6);
            pnlCardShortlist.Location = new Point(730, 20);
            pnlCardShortlist.Name = "pnlCardShortlist";
            pnlCardShortlist.Size = new Size(140, 60);
            pnlCardShortlist.TabIndex = 5;
            // 
            // lblShortlistCount
            // 
            lblShortlistCount.AutoSize = true;
            lblShortlistCount.Location = new Point(5, 25);
            lblShortlistCount.Name = "lblShortlistCount";
            lblShortlistCount.Size = new Size(0, 25);
            lblShortlistCount.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 6F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.MediumAquamarine;
            label6.Location = new Point(5, 4);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 4;
            label6.Text = "Shortlisted";
            // 
            // pnlCardPending
            // 
            pnlCardPending.BackColor = Color.Moccasin;
            pnlCardPending.BorderStyle = BorderStyle.FixedSingle;
            pnlCardPending.Controls.Add(lblPendingCount);
            pnlCardPending.Controls.Add(label5);
            pnlCardPending.Location = new Point(575, 20);
            pnlCardPending.Name = "pnlCardPending";
            pnlCardPending.Size = new Size(140, 60);
            pnlCardPending.TabIndex = 5;
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Location = new Point(5, 25);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(0, 25);
            lblPendingCount.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 6F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.DarkGoldenrod;
            label5.Location = new Point(5, 4);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 4;
            label5.Text = "Pending Review";
            // 
            // pnlCardTotal
            // 
            pnlCardTotal.BackColor = Color.AliceBlue;
            pnlCardTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlCardTotal.Controls.Add(lblTotalCount);
            pnlCardTotal.Controls.Add(label4);
            pnlCardTotal.Location = new Point(420, 20);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Size = new Size(140, 60);
            pnlCardTotal.TabIndex = 0;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Location = new Point(11, 24);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(0, 25);
            lblTotalCount.TabIndex = 5;
            lblTotalCount.TextAlign = ContentAlignment.MiddleLeft;
            
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(5, 4);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 4;
            label4.Text = "Total Applicants";
            
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1228, 594);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblApplicantList);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(423, 588);
            panel1.TabIndex = 0;
            // 
            // lblApplicantList
            // 
            lblApplicantList.AutoSize = true;
            lblApplicantList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApplicantList.ForeColor = Color.DimGray;
            lblApplicantList.Location = new Point(9, 10);
            lblApplicantList.Name = "lblApplicantList";
            lblApplicantList.Size = new Size(200, 32);
            lblApplicantList.TabIndex = 0;
            lblApplicantList.Text = "APPLICANT LIST";
            
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(10, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(403, 533);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(432, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(546, 588);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 11);
            label2.Name = "label2";
            label2.Size = new Size(243, 32);
            label2.TabIndex = 2;
            label2.Text = "APPLICANT REVIEW";
            
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(10, 45);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(526, 533);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(txtNotesBox);
            tabPage1.Controls.Add(lblSummaryStatus);
            tabPage1.Controls.Add(lblSummaryPosition);
            tabPage1.Controls.Add(lblSummaryPhone);
            tabPage1.Controls.Add(lblSummaryEmail);
            tabPage1.Controls.Add(lblSummaryName);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(518, 495);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Summary";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNotesBox
            // 
            txtNotesBox.Location = new Point(91, 266);
            txtNotesBox.Multiline = true;
            txtNotesBox.Name = "txtNotesBox";
            txtNotesBox.Size = new Size(253, 32);
            txtNotesBox.TabIndex = 5;
            // 
            // lblSummaryStatus
            // 
            lblSummaryStatus.AutoSize = true;
            lblSummaryStatus.ForeColor = Color.Black;
            lblSummaryStatus.Location = new Point(6, 266);
            lblSummaryStatus.Name = "lblSummaryStatus";
            lblSummaryStatus.Size = new Size(64, 25);
            lblSummaryStatus.TabIndex = 4;
            lblSummaryStatus.Text = "Status:";
            // 
            // lblSummaryPosition
            // 
            lblSummaryPosition.AutoSize = true;
            lblSummaryPosition.ForeColor = Color.Black;
            lblSummaryPosition.Location = new Point(6, 204);
            lblSummaryPosition.Name = "lblSummaryPosition";
            lblSummaryPosition.Size = new Size(79, 25);
            lblSummaryPosition.TabIndex = 3;
            lblSummaryPosition.Text = "Position:";
            // 
            // lblSummaryPhone
            // 
            lblSummaryPhone.AutoSize = true;
            lblSummaryPhone.ForeColor = Color.Black;
            lblSummaryPhone.Location = new Point(6, 143);
            lblSummaryPhone.Name = "lblSummaryPhone";
            lblSummaryPhone.Size = new Size(66, 25);
            lblSummaryPhone.TabIndex = 2;
            lblSummaryPhone.Text = "Phone:";
            
            // 
            // lblSummaryEmail
            // 
            lblSummaryEmail.AutoSize = true;
            lblSummaryEmail.ForeColor = Color.Black;
            lblSummaryEmail.Location = new Point(6, 85);
            lblSummaryEmail.Name = "lblSummaryEmail";
            lblSummaryEmail.Size = new Size(58, 25);
            lblSummaryEmail.TabIndex = 1;
            lblSummaryEmail.Text = "Email:";
            
            // 
            // lblSummaryName
            // 
            lblSummaryName.AutoSize = true;
            lblSummaryName.ForeColor = Color.Black;
            lblSummaryName.Location = new Point(6, 31);
            lblSummaryName.Name = "lblSummaryName";
            lblSummaryName.Size = new Size(63, 25);
            lblSummaryName.TabIndex = 0;
            lblSummaryName.Text = "Name:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblChecklistHeader);
            tabPage3.Controls.Add(grpEligibility);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(518, 495);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Screening Checklist";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnSaveNotes);
            tabPage4.Controls.Add(txtHRNotes);
            tabPage4.Controls.Add(lblNotesHeader);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(518, 495);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Notes";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(984, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(241, 588);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Bodoni MT", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(13, 222);
            button3.Name = "button3";
            button3.Size = new Size(215, 56);
            button3.TabIndex = 7;
            button3.Text = "Reject";
            button3.UseVisualStyleBackColor = false;
            
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Bodoni MT", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(13, 150);
            button2.Name = "button2";
            button2.Size = new Size(215, 56);
            button2.TabIndex = 6;
            button2.Text = "Put On Hold";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Bodoni MT", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(13, 79);
            button1.Name = "button1";
            button1.Size = new Size(215, 56);
            button1.TabIndex = 5;
            button1.Text = "Shortlist/Advance";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(62, 11);
            label3.Name = "label3";
            label3.Size = new Size(118, 32);
            label3.TabIndex = 4;
            label3.Text = "ACTIONS";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(txtDocSummary);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(518, 495);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Documents";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(149, 28);
            label1.Name = "label1";
            label1.Size = new Size(229, 28);
            label1.TabIndex = 4;
            label1.Text = "Document Information";
            
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(20, 99);
            label9.Name = "label9";
            label9.Size = new Size(60, 28);
            label9.TabIndex = 5;
            label9.Text = "Title:";
            
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(20, 188);
            label10.Name = "label10";
            label10.Size = new Size(76, 28);
            label10.TabIndex = 6;
            label10.Text = "Status:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(20, 274);
            label11.Name = "label11";
            label11.Size = new Size(62, 28);
            label11.TabIndex = 7;
            label11.Text = "Date:";
            
            // 
            // txtDocSummary
            // 
            txtDocSummary.Location = new Point(86, 102);
            txtDocSummary.Multiline = true;
            txtDocSummary.Name = "txtDocSummary";
            txtDocSummary.Size = new Size(357, 25);
            txtDocSummary.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 191);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 25);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 277);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(355, 25);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 197);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 32);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(91, 140);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(253, 32);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(91, 85);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(253, 32);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(91, 31);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(253, 32);
            textBox6.TabIndex = 9;
            // 
            // grpEligibility
            // 
            grpEligibility.Controls.Add(btnSaveChecklist);
            grpEligibility.Controls.Add(chkBackgroundClearance);
            grpEligibility.Controls.Add(chkReferenceCheck);
            grpEligibility.Controls.Add(chkInterviewScheduled);
            grpEligibility.Controls.Add(chkResumeVerified);
            grpEligibility.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEligibility.ForeColor = Color.DimGray;
            grpEligibility.Location = new Point(24, 71);
            grpEligibility.Name = "grpEligibility";
            grpEligibility.Size = new Size(469, 393);
            grpEligibility.TabIndex = 0;
            grpEligibility.TabStop = false;
            grpEligibility.Text = "CHECKLIST";
            // 
            // lblChecklistHeader
            // 
            lblChecklistHeader.AutoSize = true;
            lblChecklistHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblChecklistHeader.Location = new Point(109, 31);
            lblChecklistHeader.Name = "lblChecklistHeader";
            lblChecklistHeader.Size = new Size(315, 25);
            lblChecklistHeader.TabIndex = 4;
            lblChecklistHeader.Text = "APPLICANT SCREENING CHECKLIST";
            // 
            // chkResumeVerified
            // 
            chkResumeVerified.AutoSize = true;
            chkResumeVerified.Location = new Point(18, 56);
            chkResumeVerified.Name = "chkResumeVerified";
            chkResumeVerified.Size = new Size(176, 29);
            chkResumeVerified.TabIndex = 0;
            chkResumeVerified.Text = "Resume Verified";
            chkResumeVerified.UseVisualStyleBackColor = true;
            // 
            // chkInterviewScheduled
            // 
            chkInterviewScheduled.AutoSize = true;
            chkInterviewScheduled.Location = new Point(18, 99);
            chkInterviewScheduled.Name = "chkInterviewScheduled";
            chkInterviewScheduled.Size = new Size(266, 29);
            chkInterviewScheduled.TabIndex = 1;
            chkInterviewScheduled.Text = "Initial Interview Scheduled";
            chkInterviewScheduled.UseVisualStyleBackColor = true;
            // 
            // chkReferenceCheck
            // 
            chkReferenceCheck.AutoSize = true;
            chkReferenceCheck.Location = new Point(18, 145);
            chkReferenceCheck.Name = "chkReferenceCheck";
            chkReferenceCheck.Size = new Size(209, 29);
            chkReferenceCheck.TabIndex = 2;
            chkReferenceCheck.Text = "References Checked";
            chkReferenceCheck.UseVisualStyleBackColor = true;
            // 
            // chkBackgroundClearance
            // 
            chkBackgroundClearance.AutoSize = true;
            chkBackgroundClearance.Location = new Point(18, 189);
            chkBackgroundClearance.Name = "chkBackgroundClearance";
            chkBackgroundClearance.Size = new Size(229, 29);
            chkBackgroundClearance.TabIndex = 3;
            chkBackgroundClearance.Text = "Background Clearance";
            chkBackgroundClearance.UseVisualStyleBackColor = true;
            // 
            // btnSaveChecklist
            // 
            btnSaveChecklist.BackColor = Color.PaleGreen;
            btnSaveChecklist.ForeColor = Color.DarkGreen;
            btnSaveChecklist.Location = new Point(18, 249);
            btnSaveChecklist.Name = "btnSaveChecklist";
            btnSaveChecklist.Size = new Size(227, 37);
            btnSaveChecklist.TabIndex = 4;
            btnSaveChecklist.Text = "Save Checklist Progress";
            btnSaveChecklist.UseVisualStyleBackColor = false;
            // 
            // lblNotesHeader
            // 
            lblNotesHeader.AutoSize = true;
            lblNotesHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotesHeader.Location = new Point(162, 31);
            lblNotesHeader.Name = "lblNotesHeader";
            lblNotesHeader.Size = new Size(196, 25);
            lblNotesHeader.TabIndex = 0;
            lblNotesHeader.Text = "HR Interviewer Notes";
            // 
            // txtHRNotes
            // 
            txtHRNotes.Location = new Point(61, 76);
            txtHRNotes.Multiline = true;
            txtHRNotes.Name = "txtHRNotes";
            txtHRNotes.ScrollBars = ScrollBars.Vertical;
            txtHRNotes.Size = new Size(393, 302);
            txtHRNotes.TabIndex = 1;
            // 
            // btnSaveNotes
            // 
            btnSaveNotes.BackColor = Color.PaleGreen;
            btnSaveNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSaveNotes.ForeColor = Color.DarkGreen;
            btnSaveNotes.Location = new Point(183, 410);
            btnSaveNotes.Name = "btnSaveNotes";
            btnSaveNotes.Size = new Size(154, 34);
            btnSaveNotes.TabIndex = 2;
            btnSaveNotes.Text = "Save Notes";
            btnSaveNotes.UseVisualStyleBackColor = false;
            btnSaveNotes.Click += btnSaveNotes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1228, 694);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlHeader);
            ForeColor = Color.Gray;
            Name = "Form1";
            Text = "HR Applicant Process System - Dashboard";
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
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            grpEligibility.ResumeLayout(false);
            grpEligibility.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lblApplicantList;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel3;
        private Label label3;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel pnlCardTotal;
        private Label label4;
        private Panel pnlCardHired;
        private Label label8;
        private Panel pnlCardInterview;
        private Label label7;
        private Panel pnlCardShortlist;
        private Label label6;
        private Panel pnlCardPending;
        private Label label5;
        private PictureBox pnlHead;
        private Label lblHRApplicant;
        private Label lblDashboard;
        private Label lblSummaryEmail;
        private Label lblSummaryName;
        private Label lblSummaryPhone;
        private TextBox txtNotesBox;
        private Label lblSummaryStatus;
        private Label lblSummaryPosition;
        private Label lblTotalCount;
        private Label lblHiredCount;
        private Label lblInterviewCount;
        private Label lblShortlistCount;
        private Label lblPendingCount;
        private TabPage tabPage2;
        private Label label1;
        private TextBox txtDocSummary;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private GroupBox grpEligibility;
        private Label lblChecklistHeader;
        private CheckBox chkResumeVerified;
        private Button btnSaveChecklist;
        private CheckBox chkBackgroundClearance;
        private CheckBox chkReferenceCheck;
        private CheckBox chkInterviewScheduled;
        private Label lblNotesHeader;
        private TextBox txtHRNotes;
        private Button btnSaveNotes;
    }
}