namespace HRApplicantWindowSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            linkLabel1 = new LinkLabel();
            btnCreateAccount = new Button();
            pnlRoleSelection = new Panel();
            btnRoleHR = new Button();
            btnRoleApplicant = new Button();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pnlLoginInputs = new Panel();
            btnBack = new Button();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pnlRoleSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlLoginInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(29, 378);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 52);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(29, 258);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 2;
            label1.Text = "Username/Email:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(29, 311);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(29, 281);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(278, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(29, 334);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 27);
            txtPassword.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(132, 320);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.Click += LoginForm_Load;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(191, 378);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(116, 52);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Register";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // pnlRoleSelection
            // 
            pnlRoleSelection.BackColor = SystemColors.Info;
            pnlRoleSelection.Controls.Add(btnRoleHR);
            pnlRoleSelection.Controls.Add(btnRoleApplicant);
            pnlRoleSelection.Controls.Add(pictureBox3);
            pnlRoleSelection.Dock = DockStyle.Right;
            pnlRoleSelection.Location = new Point(441, 0);
            pnlRoleSelection.Name = "pnlRoleSelection";
            pnlRoleSelection.Size = new Size(307, 650);
            pnlRoleSelection.TabIndex = 9;
            pnlRoleSelection.Paint += pnlRoleSelection_Paint;
            // 
            // btnRoleHR
            // 
            btnRoleHR.Location = new Point(28, 345);
            btnRoleHR.Name = "btnRoleHR";
            btnRoleHR.Size = new Size(232, 60);
            btnRoleHR.TabIndex = 1;
            btnRoleHR.Text = "HR Staff / Manager";
            btnRoleHR.UseVisualStyleBackColor = true;
            btnRoleHR.Click += btnRoleHR_Click;
            // 
            // btnRoleApplicant
            // 
            btnRoleApplicant.Location = new Point(28, 255);
            btnRoleApplicant.Name = "btnRoleApplicant";
            btnRoleApplicant.Size = new Size(232, 60);
            btnRoleApplicant.TabIndex = 0;
            btnRoleApplicant.Text = "Applicant";
            btnRoleApplicant.UseVisualStyleBackColor = true;
            btnRoleApplicant.Click += btnRoleApplicant_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.GradientActiveCaption;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-10, -28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(335, 716);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 365);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            // 
            // pnlLoginInputs
            // 
            pnlLoginInputs.BackColor = SystemColors.GradientActiveCaption;
            pnlLoginInputs.Controls.Add(btnBack);
            pnlLoginInputs.Controls.Add(label1);
            pnlLoginInputs.Controls.Add(label5);
            pnlLoginInputs.Controls.Add(txtUsername);
            pnlLoginInputs.Controls.Add(btnCreateAccount);
            pnlLoginInputs.Controls.Add(label2);
            pnlLoginInputs.Controls.Add(btnLogin);
            pnlLoginInputs.Controls.Add(txtPassword);
            pnlLoginInputs.Controls.Add(pictureBox4);
            pnlLoginInputs.Dock = DockStyle.Right;
            pnlLoginInputs.Location = new Point(123, 0);
            pnlLoginInputs.Name = "pnlLoginInputs";
            pnlLoginInputs.Size = new Size(318, 650);
            pnlLoginInputs.TabIndex = 11;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(191, 456);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(122, 36);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-15, -28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(333, 716);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(141, 9);
            label3.Name = "label3";
            label3.Size = new Size(284, 55);
            label3.TabIndex = 14;
            label3.Text = "PENTANODE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(151, 67);
            label4.Name = "label4";
            label4.Size = new Size(179, 20);
            label4.TabIndex = 15;
            label4.Text = "Network and Systems, Co.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 571);
            label6.Name = "label6";
            label6.Size = new Size(357, 25);
            label6.TabIndex = 16;
            label6.Text = "Welcome to Pentanode Window System!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 647);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(748, 650);
            Controls.Add(pnlLoginInputs);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pnlRoleSelection);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            pnlRoleSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlLoginInputs.ResumeLayout(false);
            pnlLoginInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private LinkLabel linkLabel1;
        private Button btnCreateAccount;
        private Panel pnlRoleSelection;
        private Label label5;
        private Panel pnlLoginInputs;
        private Button btnBack;
        private Button btnRoleHR;
        private Button btnRoleApplicant;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
