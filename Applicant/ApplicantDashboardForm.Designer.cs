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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantDashboardForm));
            panel1 = new Panel();
            btnLogout = new Button();
            btnStatusTracking = new Button();
            btnDocuments = new Button();
            btnMyApplication = new Button();
            btnJobVacancies = new Button();
            btnProfile = new Button();
            pictureBox1 = new PictureBox();
            btnDashboard = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnDashboard);
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
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(19, 514);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(323, 73);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStatusTracking
            // 
            btnStatusTracking.Location = new Point(19, 433);
            btnStatusTracking.Margin = new Padding(3, 4, 3, 4);
            btnStatusTracking.Name = "btnStatusTracking";
            btnStatusTracking.Size = new Size(323, 73);
            btnStatusTracking.TabIndex = 4;
            btnStatusTracking.Text = "Applicant Status Tracking";
            btnStatusTracking.UseVisualStyleBackColor = true;
            btnStatusTracking.Click += btnStatusTracking_Click;
            // 
            // btnDocuments
            // 
            btnDocuments.Location = new Point(19, 352);
            btnDocuments.Margin = new Padding(3, 4, 3, 4);
            btnDocuments.Name = "btnDocuments";
            btnDocuments.Size = new Size(323, 73);
            btnDocuments.TabIndex = 3;
            btnDocuments.Text = "Applicant Documents";
            btnDocuments.UseVisualStyleBackColor = true;
            btnDocuments.Click += btnDocuments_Click;
            // 
            // btnMyApplication
            // 
            btnMyApplication.Location = new Point(19, 271);
            btnMyApplication.Margin = new Padding(3, 4, 3, 4);
            btnMyApplication.Name = "btnMyApplication";
            btnMyApplication.Size = new Size(323, 73);
            btnMyApplication.TabIndex = 2;
            btnMyApplication.Text = "My Application";
            btnMyApplication.UseVisualStyleBackColor = true;
            btnMyApplication.Click += btnMyApplication_Click;
            // 
            // btnJobVacancies
            // 
            btnJobVacancies.Location = new Point(19, 190);
            btnJobVacancies.Margin = new Padding(3, 4, 3, 4);
            btnJobVacancies.Name = "btnJobVacancies";
            btnJobVacancies.Size = new Size(323, 73);
            btnJobVacancies.TabIndex = 1;
            btnJobVacancies.Text = "Job Vacancies";
            btnJobVacancies.UseVisualStyleBackColor = true;
            btnJobVacancies.Click += btnJobVacancies_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(19, 109);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(323, 73);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Applicant Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(364, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(549, 595);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(19, 28);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(323, 73);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // ApplicantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ApplicantDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Applicant Dashboard";
            Load += ApplicantDashboardForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button btnDashboard;
    }
}
