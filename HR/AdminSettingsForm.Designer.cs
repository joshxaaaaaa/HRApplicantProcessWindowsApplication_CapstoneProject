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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            AdminSettings = new TabControl();
            tabUserManagement = new TabPage();
            groupBox1 = new GroupBox();
            label8 = new Label();
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
            btnDeleteRecord = new Button();
            btnSaveRecord = new Button();
            txtRecordDesc = new TextBox();
            label7 = new Label();
            txtRecordName = new TextBox();
            label6 = new Label();
            dgvMaintenanceValues = new DataGridView();
            cmbMaintenanceCategory = new ComboBox();
            tabAuditTrail = new TabPage();
            dgvAuditTrail = new DataGridView();
            btnBack = new Button();
            label9 = new Label();
            AdminSettings.SuspendLayout();
            tabUserManagement.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceValues).BeginInit();
            tabAuditTrail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditTrail).BeginInit();
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
            AdminSettings.Controls.Add(tabAuditTrail);
            AdminSettings.Location = new Point(0, 0);
            AdminSettings.Name = "AdminSettings";
            AdminSettings.SelectedIndex = 0;
            AdminSettings.Size = new Size(800, 410);
            AdminSettings.TabIndex = 1;
            AdminSettings.SelectedIndexChanged += AdminSettings_SelectedIndexChanged;
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
            tabUserManagement.Size = new Size(792, 377);
            tabUserManagement.TabIndex = 0;
            tabUserManagement.Text = "User Management";
            tabUserManagement.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
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
            groupBox1.Location = new Point(503, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 378);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add/Edit User";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 30);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 10;
            label8.Text = "Select User to Delete";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(172, 26);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(108, 29);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(172, 328);
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
            cmbNewRole.Location = new Point(90, 135);
            cmbNewRole.Name = "cmbNewRole";
            cmbNewRole.Size = new Size(190, 28);
            cmbNewRole.TabIndex = 7;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(90, 295);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(190, 27);
            txtNewPassword.TabIndex = 6;
            // 
            // txtNewEmail
            // 
            txtNewEmail.Location = new Point(90, 242);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(190, 27);
            txtNewEmail.TabIndex = 5;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(90, 189);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(190, 27);
            txtNewUsername.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 112);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 3;
            label5.Text = "Role: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 272);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 2;
            label4.Text = "Password: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 219);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 1;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 166);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Username: ";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(3, 3);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(494, 378);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // tabMaintenance
            // 
            tabMaintenance.AccessibleDescription = "";
            tabMaintenance.AccessibleName = "";
            tabMaintenance.Controls.Add(btnDeleteRecord);
            tabMaintenance.Controls.Add(btnSaveRecord);
            tabMaintenance.Controls.Add(txtRecordDesc);
            tabMaintenance.Controls.Add(label7);
            tabMaintenance.Controls.Add(txtRecordName);
            tabMaintenance.Controls.Add(label6);
            tabMaintenance.Controls.Add(dgvMaintenanceValues);
            tabMaintenance.Controls.Add(cmbMaintenanceCategory);
            tabMaintenance.Location = new Point(4, 29);
            tabMaintenance.Name = "tabMaintenance";
            tabMaintenance.Padding = new Padding(3);
            tabMaintenance.Size = new Size(792, 377);
            tabMaintenance.TabIndex = 1;
            tabMaintenance.Text = "System Maintenance";
            tabMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Location = new Point(700, 315);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(83, 50);
            btnDeleteRecord.TabIndex = 7;
            btnDeleteRecord.Text = "Delete Selected";
            btnDeleteRecord.UseVisualStyleBackColor = true;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Location = new Point(580, 315);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(102, 50);
            btnSaveRecord.TabIndex = 6;
            btnSaveRecord.Text = "Save Record";
            btnSaveRecord.UseVisualStyleBackColor = true;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // txtRecordDesc
            // 
            txtRecordDesc.Location = new Point(183, 338);
            txtRecordDesc.Multiline = true;
            txtRecordDesc.Name = "txtRecordDesc";
            txtRecordDesc.Size = new Size(391, 24);
            txtRecordDesc.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(183, 312);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 4;
            label7.Text = "Description";
            // 
            // txtRecordName
            // 
            txtRecordName.Location = new Point(7, 335);
            txtRecordName.Name = "txtRecordName";
            txtRecordName.Size = new Size(170, 27);
            txtRecordName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 312);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 2;
            label6.Text = "Name";
            // 
            // dgvMaintenanceValues
            // 
            dgvMaintenanceValues.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMaintenanceValues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMaintenanceValues.DefaultCellStyle = dataGridViewCellStyle1;
            dgvMaintenanceValues.Location = new Point(7, 40);
            dgvMaintenanceValues.Name = "dgvMaintenanceValues";
            dgvMaintenanceValues.RowHeadersWidth = 51;
            dgvMaintenanceValues.Size = new Size(776, 269);
            dgvMaintenanceValues.TabIndex = 1;
            // 
            // cmbMaintenanceCategory
            // 
            cmbMaintenanceCategory.FormattingEnabled = true;
            cmbMaintenanceCategory.Items.AddRange(new object[] { "Departments", "Requirement Types", "Employment Types", "Positions", "Interview Types", "Assessment Types" });
            cmbMaintenanceCategory.Location = new Point(8, 6);
            cmbMaintenanceCategory.Name = "cmbMaintenanceCategory";
            cmbMaintenanceCategory.Size = new Size(280, 28);
            cmbMaintenanceCategory.TabIndex = 0;
            cmbMaintenanceCategory.SelectedIndexChanged += cmbMaintenanceCategory_SelectedIndexChanged;
            // 
            // tabAuditTrail
            // 
            tabAuditTrail.Controls.Add(dgvAuditTrail);
            tabAuditTrail.Location = new Point(4, 29);
            tabAuditTrail.Name = "tabAuditTrail";
            tabAuditTrail.Size = new Size(792, 377);
            tabAuditTrail.TabIndex = 2;
            tabAuditTrail.Text = "Audit Trail";
            tabAuditTrail.UseVisualStyleBackColor = true;
            // 
            // dgvAuditTrail
            // 
            dgvAuditTrail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditTrail.Location = new Point(36, 45);
            dgvAuditTrail.Name = "dgvAuditTrail";
            dgvAuditTrail.RowHeadersWidth = 51;
            dgvAuditTrail.Size = new Size(701, 311);
            dgvAuditTrail.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(679, 416);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(108, 33);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(90, 83);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 11;
            label9.Text = "For HR Only";
            // 
            // AdminSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
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
            tabAuditTrail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAuditTrail).EndInit();
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
        private DataGridView dgvMaintenanceValues;
        private TextBox txtRecordDesc;
        private Label label7;
        private TextBox txtRecordName;
        private Label label6;
        private Button btnDeleteRecord;
        private Button btnSaveRecord;
        private Label label8;
        private Button btnBack;
        private TabPage tabAuditTrail;
        private DataGridView dgvAuditTrail;
        private Label label9;
    }
}