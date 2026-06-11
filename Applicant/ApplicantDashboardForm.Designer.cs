namespace HRApplicantWindowSystem
{
    partial class ApplicantDashboardForm
    {

        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnLogout = new Button();
            btnStatusTracking = new Button();
            btnDocuments = new Button();
            btnMyApplication = new Button();
            btnJobVacancies = new Button();
            btnProfile = new Button();
            panel1.SuspendLayout();
            SuspendLayout();

            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnStatusTracking);
            panel1.Controls.Add(btnDocuments);
            panel1.Controls.Add(btnMyApplication);
            panel1.Controls.Add(btnJobVacancies);
            panel1.Controls.Add(btnProfile);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 613);
            panel1.TabIndex = 0;

            btnLogout.Location = new Point(19, 467);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(323, 73);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;

            btnStatusTracking.Location = new Point(19, 349);
            btnStatusTracking.Margin = new Padding(3, 4, 3, 4);
            btnStatusTracking.Name = "btnStatusTracking";
            btnStatusTracking.Size = new Size(323, 73);
            btnStatusTracking.TabIndex = 4;
            btnStatusTracking.Text = "Applicant Status Tracking";
            btnStatusTracking.UseVisualStyleBackColor = true;
            btnStatusTracking.Click += btnStatusTracking_Click;

            btnDocuments.Location = new Point(19, 268);
            btnDocuments.Margin = new Padding(3, 4, 3, 4);
            btnDocuments.Name = "btnDocuments";
            btnDocuments.Size = new Size(323, 73);
            btnDocuments.TabIndex = 3;
            btnDocuments.Text = "Applicant Documents";
            btnDocuments.UseVisualStyleBackColor = true;
            btnDocuments.Click += btnDocuments_Click;

            btnMyApplication.Location = new Point(19, 187);
            btnMyApplication.Margin = new Padding(3, 4, 3, 4);
            btnMyApplication.Name = "btnMyApplication";
            btnMyApplication.Size = new Size(323, 73);
            btnMyApplication.TabIndex = 2;
            btnMyApplication.Text = "My Application";
            btnMyApplication.UseVisualStyleBackColor = true;
            btnMyApplication.Click += btnMyApplication_Click;

            btnJobVacancies.Location = new Point(19, 105);
            btnJobVacancies.Margin = new Padding(3, 4, 3, 4);
            btnJobVacancies.Name = "btnJobVacancies";
            btnJobVacancies.Size = new Size(323, 73);
            btnJobVacancies.TabIndex = 1;
            btnJobVacancies.Text = "Job Vacancies";
            btnJobVacancies.UseVisualStyleBackColor = true;
            btnJobVacancies.Click += btnJobVacancies_Click;

            btnProfile.Location = new Point(19, 24);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(323, 73);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Applicant Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ApplicantDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Applicant Dashboard";
            Load += ApplicantDashboardForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnProfile;
        private Button btnJobVacancies;
        private Button btnMyApplication;
        private Button btnDocuments;
        private Button btnStatusTracking;
        private Button btnLogout;
    }
}
