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
            label5 = new Label();
            label3 = new Label();
            pnlLoginInputs = new Panel();
            btnBack = new Button();
            pnlRoleSelection.SuspendLayout();
            pnlLoginInputs.SuspendLayout();
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
            label1.Location = new Point(29, 258);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 2;
            label1.Text = "Username/Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
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
            pnlRoleSelection.Dock = DockStyle.Right;
            pnlRoleSelection.Location = new Point(862, 0);
            pnlRoleSelection.Name = "pnlRoleSelection";
            pnlRoleSelection.Size = new Size(307, 622);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 365);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 126);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 10;
            label3.Text = "Welcome to Big 5 Company";
            // 
            // pnlLoginInputs
            // 
            pnlLoginInputs.BackColor = SystemColors.Info;
            pnlLoginInputs.Controls.Add(btnBack);
            pnlLoginInputs.Controls.Add(label1);
            pnlLoginInputs.Controls.Add(label5);
            pnlLoginInputs.Controls.Add(txtUsername);
            pnlLoginInputs.Controls.Add(btnCreateAccount);
            pnlLoginInputs.Controls.Add(label2);
            pnlLoginInputs.Controls.Add(btnLogin);
            pnlLoginInputs.Controls.Add(txtPassword);
            pnlLoginInputs.Dock = DockStyle.Right;
            pnlLoginInputs.Location = new Point(531, 0);
            pnlLoginInputs.Name = "pnlLoginInputs";
            pnlLoginInputs.Size = new Size(331, 622);
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 622);
            Controls.Add(pnlLoginInputs);
            Controls.Add(label3);
            Controls.Add(pnlRoleSelection);
            Controls.Add(linkLabel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            pnlRoleSelection.ResumeLayout(false);
            pnlLoginInputs.ResumeLayout(false);
            pnlLoginInputs.PerformLayout();
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
        private Label label3;
        private Panel pnlLoginInputs;
        private Button btnBack;
        private Button btnRoleHR;
        private Button btnRoleApplicant;
    }
}
