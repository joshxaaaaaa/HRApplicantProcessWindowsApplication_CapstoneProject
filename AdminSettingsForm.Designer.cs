namespace HRApplicantWindowSystem
{
    partial class AdminSettingsForm
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
            AdminSettings = new TabControl();
            tabUserManagement = new TabPage();
            groupBox1 = new GroupBox();
            btnDeleteUser = new Button();
            btnSaveUser = new Button();
            cmbNewRole = new ComboBox();
            txtNewPassword = new TextBox();
            txtNewEmail = new TextBox();
            txtNewUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvUsers = new DataGridView();
            tabMaintenance = new TabPage();
            btnAddRecord = new Button();
            txtNewValue = new TextBox();
            dgvMaintenanceValues = new DataGridView();
            cmbMaintenanceCategory = new ComboBox();
            AdminSettings.SuspendLayout();
            tabUserManagement.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceValues).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 34);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 0;
            label1.Text = "Manager/Admin Configuration Panel";
            // 
            // AdminSettings
            // 
            AdminSettings.Controls.Add(tabUserManagement);
            AdminSettings.Controls.Add(tabMaintenance);
            AdminSettings.Dock = DockStyle.Fill;
            AdminSettings.Location = new Point(0, 0);
            AdminSettings.Name = "AdminSettings";
            AdminSettings.SelectedIndex = 0;
            AdminSettings.Size = new Size(800, 450);
            AdminSettings.TabIndex = 1;
            // 
            // tabUserManagement
            // 
            tabUserManagement.AccessibleDescription = "";
            tabUserManagement.AccessibleName = "tabUserManagement";
            tabUserManagement.Controls.Add(groupBox1);
            tabUserManagement.Controls.Add(dgvUsers);
            tabUserManagement.Location = new Point(4, 29);
            tabUserManagement.Name = "tabUserManagement";
            tabUserManagement.Padding = new Padding(3);
            tabUserManagement.Size = new Size(792, 417);
            tabUserManagement.TabIndex = 0;
            tabUserManagement.Text = "User Management";
            tabUserManagement.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteUser);
            groupBox1.Controls.Add(btnSaveUser);
            groupBox1.Controls.Add(cmbNewRole);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(txtNewEmail);
            groupBox1.Controls.Add(txtNewUsername);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(529, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 411);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add/Edit User";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(146, 357);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(108, 34);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(21, 357);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(108, 34);
            btnSaveUser.TabIndex = 8;
            btnSaveUser.Text = "Save User";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // cmbNewRole
            // 
            cmbNewRole.FormattingEnabled = true;
            cmbNewRole.Items.AddRange(new object[] { "HR Staff", "HR Manager" });
            cmbNewRole.Location = new Point(21, 310);
            cmbNewRole.Name = "cmbNewRole";
            cmbNewRole.Size = new Size(190, 28);
            cmbNewRole.TabIndex = 7;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(21, 225);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(190, 27);
            txtNewPassword.TabIndex = 6;
            // 
            // txtNewEmail
            // 
            txtNewEmail.Location = new Point(21, 143);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(190, 27);
            txtNewEmail.TabIndex = 5;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(21, 71);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(190, 27);
            txtNewUsername.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 273);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 3;
            label5.Text = "Role: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 202);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 2;
            label4.Text = "Password: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 1;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 48);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Username: ";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Left;
            dgvUsers.Location = new Point(3, 3);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(520, 411);
            dgvUsers.TabIndex = 0;
            // 
            // tabMaintenance
            // 
            tabMaintenance.AccessibleDescription = "";
            tabMaintenance.AccessibleName = "";
            tabMaintenance.Controls.Add(btnAddRecord);
            tabMaintenance.Controls.Add(txtNewValue);
            tabMaintenance.Controls.Add(dgvMaintenanceValues);
            tabMaintenance.Controls.Add(cmbMaintenanceCategory);
            tabMaintenance.Location = new Point(4, 29);
            tabMaintenance.Name = "tabMaintenance";
            tabMaintenance.Padding = new Padding(3);
            tabMaintenance.Size = new Size(792, 417);
            tabMaintenance.TabIndex = 1;
            tabMaintenance.Text = "System Maintenance";
            tabMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnAddRecord
            // 
            btnAddRecord.Location = new Point(630, 376);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(141, 27);
            btnAddRecord.TabIndex = 3;
            btnAddRecord.Text = "Add New Record";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // txtNewValue
            // 
            txtNewValue.Location = new Point(8, 376);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.Size = new Size(616, 27);
            txtNewValue.TabIndex = 2;
            // 
            // dgvMaintenanceValues
            // 
            dgvMaintenanceValues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaintenanceValues.Location = new Point(8, 44);
            dgvMaintenanceValues.Name = "dgvMaintenanceValues";
            dgvMaintenanceValues.RowHeadersWidth = 51;
            dgvMaintenanceValues.Size = new Size(776, 326);
            dgvMaintenanceValues.TabIndex = 1;
            // 
            // cmbMaintenanceCategory
            // 
            cmbMaintenanceCategory.FormattingEnabled = true;
            cmbMaintenanceCategory.Items.AddRange(new object[] { "Departments", "Requirement Types" });
            cmbMaintenanceCategory.Location = new Point(3, 2);
            cmbMaintenanceCategory.Name = "cmbMaintenanceCategory";
            cmbMaintenanceCategory.Size = new Size(280, 28);
            cmbMaintenanceCategory.TabIndex = 0;
            cmbMaintenanceCategory.SelectedIndexChanged += cmbMaintenanceCategory_SelectedIndexChanged;
            // 
            // AdminSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AdminSettings);
            Controls.Add(label1);
            Name = "AdminSettingsForm";
            Text = "Manager/Admin Panel";
            Load += AdminSettingsForm_Load;
            AdminSettings.ResumeLayout(false);
            tabUserManagement.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabMaintenance.ResumeLayout(false);
            tabMaintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceValues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl AdminSettings;
        private TabPage tabUserManagement;
        private TabPage tabMaintenance;
        private GroupBox groupBox1;
        private DataGridView dgvUsers;
        private TextBox txtNewPassword;
        private TextBox txtNewEmail;
        private TextBox txtNewUsername;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDeleteUser;
        private Button btnSaveUser;
        private ComboBox cmbNewRole;
        private ComboBox cmbMaintenanceCategory;
        private Button btnAddRecord;
        private TextBox txtNewValue;
        private DataGridView dgvMaintenanceValues;
    }
}