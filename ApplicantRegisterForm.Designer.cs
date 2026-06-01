namespace HRApplicantWindowSystem
{
    partial class ApplicantRegisterForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtContact = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 71);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 151);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Contact Number";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(120, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(267, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(120, 106);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 27);
            txtLastName.TabIndex = 4;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(120, 191);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(309, 27);
            txtContact.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 236);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 312);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 375);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 269);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(179, 27);
            txtAddress.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 345);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 411);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 27);
            txtPassword.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(457, 329);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(134, 58);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += this.btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(614, 327);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 63);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ApplicantRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtContact);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ApplicantRegisterForm";
            Text = "Applicant Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtContact;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnCancel;
    }
}