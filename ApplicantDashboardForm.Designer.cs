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
            btnProfile = new Button();
            btnJobVacancies = new Button();
            btnMyApplication = new Button();
            btnDocuments = new Button();
            btnStatusTracking = new Button();
            btnLogout = new Button();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 460);
            panel1.TabIndex = 0;
           
            btnProfile.Location = new Point(17, 18);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(283, 55);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Applicant Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            
            btnJobVacancies.Location = new Point(17, 79);
            btnJobVacancies.Name = "btnJobVacancies";
            btnJobVacancies.Size = new Size(283, 55);
            btnJobVacancies.TabIndex = 1;
            btnJobVacancies.Text = "Job Vacancies";
            btnJobVacancies.UseVisualStyleBackColor = true;
            btnJobVacancies.Click += btnJobVacancies_Click;
           
            btnMyApplication.Location = new Point(17, 140);
            btnMyApplication.Name = "btnMyApplication";
            btnMyApplication.Size = new Size(283, 55);
            btnMyApplication.TabIndex = 2;
            btnMyApplication.Text = "My Application";
            btnMyApplication.UseVisualStyleBackColor = true;
            btnMyApplication.Click += btnMyApplication_Click;
            
            btnDocuments.Location = new Point(17, 201);
            btnDocuments.Name = "btnDocuments";
            btnDocuments.Size = new Size(283, 55);
            btnDocuments.TabIndex = 3;
            btnDocuments.Text = "Applicant Documents";
            btnDocuments.UseVisualStyleBackColor = true;
            btnDocuments.Click += btnDocuments_Click;
            
            btnStatusTracking.Location = new Point(17, 262);
            btnStatusTracking.Name = "btnStatusTracking";
            btnStatusTracking.Size = new Size(283, 55);
            btnStatusTracking.TabIndex = 4;
            btnStatusTracking.Text = "Applicant Status Tracking";
            btnStatusTracking.UseVisualStyleBackColor = true;
            btnStatusTracking.Click += btnStatusTracking_Click;
           
            btnLogout.Location = new Point(17, 350);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(283, 55);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ApplicantDashboardForm";
            Text = "Applicant Dashboard";
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