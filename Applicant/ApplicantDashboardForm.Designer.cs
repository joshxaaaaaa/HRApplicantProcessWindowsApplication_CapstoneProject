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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDashboard = new Button();
            btnLogout = new Button();
            btnStatusTracking = new Button();
            btnDocuments = new Button();
            btnMyApplication = new Button();
            btnJobVacancies = new Button();
            btnProfile = new Button();
            lblGreeting = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 23);
            label3.Name = "label3";
            label3.Size = new Size(248, 20);
            label3.TabIndex = 8;
            label3.Text = "Welcome to PENTANODE Windows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 103);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 7;
            label2.Text = "NAVIGATE YOUR PATH HERE!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 44);
            label1.Name = "label1";
            label1.Size = new Size(241, 40);
            label1.TabIndex = 3;
            label1.Text = "⌂ Home Page";
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(50, 136);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(266, 53);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(121, 541);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(129, 50);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnStatusTracking
            // 
            btnStatusTracking.Location = new Point(50, 460);
            btnStatusTracking.Margin = new Padding(3, 4, 3, 4);
            btnStatusTracking.Name = "btnStatusTracking";
            btnStatusTracking.Size = new Size(266, 61);
            btnStatusTracking.TabIndex = 4;
            btnStatusTracking.Text = "Applicant Status Tracking";
            btnStatusTracking.UseVisualStyleBackColor = true;
            btnStatusTracking.Click += btnStatusTracking_Click;
            // 
            // btnDocuments
            // 
            btnDocuments.Location = new Point(50, 394);
            btnDocuments.Margin = new Padding(3, 4, 3, 4);
            btnDocuments.Name = "btnDocuments";
            btnDocuments.Size = new Size(266, 58);
            btnDocuments.TabIndex = 3;
            btnDocuments.Text = "Applicant Documents";
            btnDocuments.UseVisualStyleBackColor = true;
            btnDocuments.Click += btnDocuments_Click;
            // 
            // btnMyApplication
            // 
            btnMyApplication.Location = new Point(50, 328);
            btnMyApplication.Margin = new Padding(3, 4, 3, 4);
            btnMyApplication.Name = "btnMyApplication";
            btnMyApplication.Size = new Size(266, 58);
            btnMyApplication.TabIndex = 2;
            btnMyApplication.Text = "My Application";
            btnMyApplication.UseVisualStyleBackColor = true;
            btnMyApplication.Click += btnMyApplication_Click;
            // 
            // btnJobVacancies
            // 
            btnJobVacancies.Location = new Point(50, 263);
            btnJobVacancies.Margin = new Padding(3, 4, 3, 4);
            btnJobVacancies.Name = "btnJobVacancies";
            btnJobVacancies.Size = new Size(266, 57);
            btnJobVacancies.TabIndex = 1;
            btnJobVacancies.Text = "Job Vacancies";
            btnJobVacancies.UseVisualStyleBackColor = true;
            btnJobVacancies.Click += btnJobVacancies_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(50, 197);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(266, 58);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Applicant Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.BackColor = SystemColors.GradientInactiveCaption;
            lblGreeting.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGreeting.Location = new Point(501, 9);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(285, 38);
            lblGreeting.TabIndex = 2;
            lblGreeting.Text = "Loading Greeting..";
            lblGreeting.Click += lblGreeting_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(168, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(940, 551);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(413, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.AppWorkspace;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(529, 445);
            label4.Name = "label4";
            label4.Size = new Size(217, 20);
            label4.TabIndex = 9;
            label4.Text = "Good luck to your application!";
            label4.Click += label4_Click;
            // 
            // ApplicantDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(label4);
            Controls.Add(lblGreeting);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ApplicantDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Applicant Home Page";
            Load += ApplicantDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblGreeting;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}
