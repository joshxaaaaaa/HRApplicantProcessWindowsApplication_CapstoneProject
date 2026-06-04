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
            lblWelcome = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            lblPendingApplications = new Label();
            panel4 = new Panel();
            lblOpenJobs = new Label();
            panel3 = new Panel();
            lblTotalApplicants = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Controls.Add(lblWelcome);
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
            // 
            // btnInterviews
            // 
            btnInterviews.Location = new Point(28, 298);
            btnInterviews.Name = "btnInterviews";
            btnInterviews.Size = new Size(228, 62);
            btnInterviews.TabIndex = 4;
            btnInterviews.Text = "Interviews";
            btnInterviews.UseVisualStyleBackColor = true;
            // 
            // btnApplicants
            // 
            btnApplicants.Location = new Point(28, 212);
            btnApplicants.Name = "btnApplicants";
            btnApplicants.Size = new Size(228, 62);
            btnApplicants.TabIndex = 3;
            btnApplicants.Text = "Applicants";
            btnApplicants.UseVisualStyleBackColor = true;
            // 
            // btnJobs
            // 
            btnJobs.Location = new Point(28, 129);
            btnJobs.Name = "btnJobs";
            btnJobs.Size = new Size(228, 62);
            btnJobs.TabIndex = 2;
            btnJobs.Text = "Jobs";
            btnJobs.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(305, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 638);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(596, 530);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 5;
            label4.Text = "Pending Applications";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 534);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Open Jobs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 534);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Total Applicants";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(lblPendingApplications);
            panel5.Location = new Point(548, 118);
            panel5.Name = "panel5";
            panel5.Size = new Size(223, 389);
            panel5.TabIndex = 2;
            // 
            // lblPendingApplications
            // 
            lblPendingApplications.AutoSize = true;
            lblPendingApplications.Location = new Point(124, 22);
            lblPendingApplications.Name = "lblPendingApplications";
            lblPendingApplications.Size = new Size(17, 20);
            lblPendingApplications.TabIndex = 5;
            lblPendingApplications.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(lblOpenJobs);
            panel4.Location = new Point(304, 118);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 389);
            panel4.TabIndex = 2;
            // 
            // lblOpenJobs
            // 
            lblOpenJobs.AutoSize = true;
            lblOpenJobs.Location = new Point(110, 22);
            lblOpenJobs.Name = "lblOpenJobs";
            lblOpenJobs.Size = new Size(17, 20);
            lblOpenJobs.TabIndex = 4;
            lblOpenJobs.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(lblTotalApplicants);
            panel3.Location = new Point(55, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 389);
            panel3.TabIndex = 1;
            // 
            // lblTotalApplicants
            // 
            lblTotalApplicants.AutoSize = true;
            lblTotalApplicants.Location = new Point(89, 22);
            lblTotalApplicants.Name = "lblTotalApplicants";
            lblTotalApplicants.Size = new Size(17, 20);
            lblTotalApplicants.TabIndex = 3;
            lblTotalApplicants.Text = "0";
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
            // HRDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 638);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HRDashboardForm";
            Text = "HR UI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnDashboard;
        private Label lblWelcome;
        private Button btnLogout;
        private Button btnReports;
        private Button btnInterviews;
        private Button btnApplicants;
        private Button btnJobs;
        private Panel panel2;
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
        private Button button1;
        private Button btnAdminPanel;
    }
}