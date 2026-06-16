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
            label7 = new Label();
            label13 = new Label();
            label6 = new Label();
            label8 = new Label();
            btnRoleHR = new Button();
            pictureBox2 = new PictureBox();
            btnRoleApplicant = new Button();
            label5 = new Label();
            pnlLoginInputs = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            pnlRoleSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlLoginInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(24, 287);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 41);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(24, 173);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 2;
            label1.Text = "Username/Email:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(24, 223);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(24, 190);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(24, 240);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 23);
            txtPassword.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(116, 240);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.Click += LoginForm_Load;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(153, 290);
            btnCreateAccount.Margin = new Padding(3, 2, 3, 2);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(86, 39);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Register";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // pnlRoleSelection
            // 
            pnlRoleSelection.BackColor = SystemColors.GradientActiveCaption;
            pnlRoleSelection.Controls.Add(label7);
            pnlRoleSelection.Controls.Add(label13);
            pnlRoleSelection.Controls.Add(label6);
            pnlRoleSelection.Controls.Add(label8);
            pnlRoleSelection.Controls.Add(btnRoleHR);
            pnlRoleSelection.Controls.Add(pictureBox2);
            pnlRoleSelection.Controls.Add(btnRoleApplicant);
            pnlRoleSelection.Dock = DockStyle.Right;
            pnlRoleSelection.Location = new Point(371, 0);
            pnlRoleSelection.Margin = new Padding(3, 2, 3, 2);
            pnlRoleSelection.Name = "pnlRoleSelection";
            pnlRoleSelection.Size = new Size(269, 488);
            pnlRoleSelection.TabIndex = 9;
            pnlRoleSelection.Paint += pnlRoleSelection_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(51, 112);
            label7.Name = "label7";
            label7.Size = new Size(136, 26);
            label7.TabIndex = 24;
            label7.Text = "PENTANODE";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(68, 137);
            label13.Name = "label13";
            label13.Size = new Size(127, 20);
            label13.TabIndex = 23;
            label13.Text = "Window System!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 89);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 18;
            label6.Text = "Welcome to";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 190);
            label8.Name = "label8";
            label8.Size = new Size(250, 20);
            label8.TabIndex = 17;
            label8.Text = "↓ Please click or tap your destination";
            label8.Click += label8_Click;
            // 
            // btnRoleHR
            // 
            btnRoleHR.Location = new Point(24, 290);
            btnRoleHR.Margin = new Padding(3, 2, 3, 2);
            btnRoleHR.Name = "btnRoleHR";
            btnRoleHR.Size = new Size(203, 45);
            btnRoleHR.TabIndex = 1;
            btnRoleHR.Text = "HR Staff / Manager";
            btnRoleHR.UseVisualStyleBackColor = true;
            btnRoleHR.Click += btnRoleHR_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(101, 20);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnRoleApplicant
            // 
            btnRoleApplicant.Location = new Point(24, 227);
            btnRoleApplicant.Margin = new Padding(3, 2, 3, 2);
            btnRoleApplicant.Name = "btnRoleApplicant";
            btnRoleApplicant.Size = new Size(203, 45);
            btnRoleApplicant.TabIndex = 0;
            btnRoleApplicant.Text = "Applicant";
            btnRoleApplicant.UseVisualStyleBackColor = true;
            btnRoleApplicant.Click += btnRoleApplicant_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 274);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 10;
            // 
            // pnlLoginInputs
            // 
            pnlLoginInputs.BackColor = SystemColors.GradientActiveCaption;
            pnlLoginInputs.Controls.Add(label12);
            pnlLoginInputs.Controls.Add(label11);
            pnlLoginInputs.Controls.Add(label10);
            pnlLoginInputs.Controls.Add(pictureBox3);
            pnlLoginInputs.Controls.Add(label9);
            pnlLoginInputs.Controls.Add(btnBack);
            pnlLoginInputs.Controls.Add(label1);
            pnlLoginInputs.Controls.Add(label5);
            pnlLoginInputs.Controls.Add(txtUsername);
            pnlLoginInputs.Controls.Add(btnCreateAccount);
            pnlLoginInputs.Controls.Add(label2);
            pnlLoginInputs.Controls.Add(btnLogin);
            pnlLoginInputs.Controls.Add(txtPassword);
            pnlLoginInputs.Dock = DockStyle.Right;
            pnlLoginInputs.Location = new Point(93, 0);
            pnlLoginInputs.Margin = new Padding(3, 2, 3, 2);
            pnlLoginInputs.Name = "pnlLoginInputs";
            pnlLoginInputs.Size = new Size(278, 488);
            pnlLoginInputs.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(13, 341);
            label12.Name = "label12";
            label12.Size = new Size(227, 15);
            label12.TabIndex = 23;
            label12.Text = "Don't have an account yet? Click Register!";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(36, 123);
            label11.Name = "label11";
            label11.Size = new Size(189, 20);
            label11.TabIndex = 22;
            label11.Text = "Sign in to start your session";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(124, 98);
            label10.Name = "label10";
            label10.Size = new Size(139, 23);
            label10.TabIndex = 21;
            label10.Text = "Log In Module";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(102, 20);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 98);
            label9.Name = "label9";
            label9.Size = new Size(121, 23);
            label9.TabIndex = 19;
            label9.Text = "Pentanode  ";
            label9.Click += label9_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(153, 393);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 40);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(396, 485);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(640, 488);
            Controls.Add(pnlLoginInputs);
            Controls.Add(pnlRoleSelection);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            pnlRoleSelection.ResumeLayout(false);
            pnlRoleSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlLoginInputs.ResumeLayout(false);
            pnlLoginInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox1;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label12;
        private Label label6;
        private Label label13;
        private Label label7;
    }
}
