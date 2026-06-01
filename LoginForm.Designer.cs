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
            cmbLoginType = new ComboBox();
            linkLabel1 = new LinkLabel();
            btnCreateAccount = new Button();
            LoginPanel = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(76, 250);
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
            label1.Location = new Point(18, 141);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 2;
            label1.Text = "Username/Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 194);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(18, 164);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(18, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 27);
            txtPassword.TabIndex = 5;
            // 
            // cmbLoginType
            // 
            cmbLoginType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoginType.FormattingEnabled = true;
            cmbLoginType.Items.AddRange(new object[] { "Applicant", "HR / Admin" });
            cmbLoginType.Location = new Point(15, 60);
            cmbLoginType.Name = "cmbLoginType";
            cmbLoginType.Size = new Size(220, 28);
            cmbLoginType.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(132, 320);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 7;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(76, 386);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(116, 52);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Register as Applicant";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = SystemColors.Info;
            LoginPanel.Controls.Add(label5);
            LoginPanel.Controls.Add(label4);
            LoginPanel.Controls.Add(cmbLoginType);
            LoginPanel.Controls.Add(btnCreateAccount);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(txtUsername);
            LoginPanel.Controls.Add(btnLogin);
            LoginPanel.Controls.Add(txtPassword);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Dock = DockStyle.Right;
            LoginPanel.Location = new Point(550, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(250, 450);
            LoginPanel.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 46);
            label3.Name = "label3";
            label3.Size = new Size(194, 20);
            label3.TabIndex = 10;
            label3.Text = "Welcome to Big 5 Company";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 37);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 9;
            label4.Text = "Choose your role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 352);
            label5.Name = "label5";
            label5.Size = new Size(212, 20);
            label5.TabIndex = 10;
            label5.Text = "No account? Register here first";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(LoginPanel);
            Controls.Add(linkLabel1);
            Name = "LoginForm";
            Text = "Login";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbLoginType;
        private LinkLabel linkLabel1;
        private Button btnCreateAccount;
        private Panel LoginPanel;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
