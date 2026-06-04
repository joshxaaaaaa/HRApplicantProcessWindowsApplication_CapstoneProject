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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 36);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 36);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 54);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 2;
            label3.Text = "Contact Number";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(58, 71);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(267, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(501, 71);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(280, 27);
            txtLastName.TabIndex = 4;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(58, 77);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(267, 27);
            txtContact.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 54);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 33);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 7;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(501, 33);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 8;
            label6.Text = "Password";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(501, 77);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(280, 27);
            txtAddress.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(58, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(501, 67);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 27);
            txtPassword.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(860, 586);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 53);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(998, 586);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 53);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 140);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtLastName);
            panel2.Location = new Point(1, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(1131, 140);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(1, 294);
            panel3.Name = "panel3";
            panel3.Size = new Size(1131, 140);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtPassword);
            panel4.Location = new Point(1, 440);
            panel4.Name = "panel4";
            panel4.Size = new Size(1131, 140);
            panel4.TabIndex = 15;
            // 
            // ApplicantRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 649);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Name = "ApplicantRegisterForm";
            Text = "Applicant Registration";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}