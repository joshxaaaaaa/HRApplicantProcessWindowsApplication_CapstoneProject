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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSettingsForm));
            label1 = new Label();
            AdminSettings = new TabControl();
            tabUserManagement = new TabPage();
            groupBox1 = new GroupBox();
            label9 = new Label();
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
            label10 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            AdminSettings.SuspendLayout();
            tabUserManagement.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenanceValues).BeginInit();
            tabAuditTrail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditTrail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(710, 43);
            label1.Name = "label1";
            label1.Size = new Size(189, 23);
            label1.TabIndex = 0;
            label1.Text = "MANAGER/ADMIN";
            // 
            // AdminSettings
            // 
            AdminSettings.Controls.Add(tabUserManagement);
            AdminSettings.Controls.Add(tabMaintenance);
            AdminSettings.Controls.Add(tabAuditTrail);
            AdminSettings.Location = new Point(55, 135);
            AdminSettings.Name = "AdminSettings";
            AdminSettings.SelectedIndex = 0;
            AdminSettings.Size = new Size(841, 421);
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
            tabUserManagement.Size = new Size(833, 388);
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
            groupBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(503, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 378);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add/Edit User";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 72);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 11;
            label9.Text = "For HR Only";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 34);
            label8.Name = "label8";
            label8.Size = new Size(162, 20);
            label8.TabIndex = 10;
            label8.Text = "Select User to Delete";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(33, 331);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(108, 29);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(186, 328);
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
            cmbNewRole.Location = new Point(34, 127);
            cmbNewRole.Name = "cmbNewRole";
            cmbNewRole.Size = new Size(261, 28);
            cmbNewRole.TabIndex = 7;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(34, 287);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(261, 26);
            txtNewPassword.TabIndex = 6;
            // 
            // txtNewEmail
            // 
            txtNewEmail.Location = new Point(34, 234);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(261, 26);
            txtNewEmail.TabIndex = 5;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(34, 181);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(261, 26);
            txtNewUsername.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 104);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 3;
            label5.Text = "Role: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 264);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 2;
            label4.Text = "Password: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 211);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 1;
            label3.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 158);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
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
            tabMaintenance.Size = new Size(833, 388);
            tabMaintenance.TabIndex = 1;
            tabMaintenance.Text = "System Maintenance";
            tabMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Location = new Point(729, 323);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(83, 50);
            btnDeleteRecord.TabIndex = 7;
            btnDeleteRecord.Text = "Delete Selected";
            btnDeleteRecord.UseVisualStyleBackColor = true;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Location = new Point(610, 323);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(102, 50);
            btnSaveRecord.TabIndex = 6;
            btnSaveRecord.Text = "Save Record";
            btnSaveRecord.UseVisualStyleBackColor = true;
            btnSaveRecord.Click += btnSaveRecord_Click;
            // 
            // txtRecordDesc
            // 
            txtRecordDesc.Location = new Point(213, 349);
            txtRecordDesc.Multiline = true;
            txtRecordDesc.Name = "txtRecordDesc";
            txtRecordDesc.Size = new Size(369, 24);
            txtRecordDesc.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 323);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 4;
            label7.Text = "Description";
            // 
            // txtRecordName
            // 
            txtRecordName.Location = new Point(18, 346);
            txtRecordName.Name = "txtRecordName";
            txtRecordName.Size = new Size(170, 27);
            txtRecordName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 323);
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
            dgvMaintenanceValues.Location = new Point(18, 40);
            dgvMaintenanceValues.Name = "dgvMaintenanceValues";
            dgvMaintenanceValues.RowHeadersWidth = 51;
            dgvMaintenanceValues.Size = new Size(794, 255);
            dgvMaintenanceValues.TabIndex = 1;
            // 
            // cmbMaintenanceCategory
            // 
            cmbMaintenanceCategory.FormattingEnabled = true;
            cmbMaintenanceCategory.Items.AddRange(new object[] { "Departments", "Requirement Types", "Employment Types", "Positions", "Interview Types", "Assessment Types" });
            cmbMaintenanceCategory.Location = new Point(18, 6);
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
            tabAuditTrail.Size = new Size(833, 388);
            tabAuditTrail.TabIndex = 2;
            tabAuditTrail.Text = "Audit Trail";
            tabAuditTrail.UseVisualStyleBackColor = true;
            // 
            // dgvAuditTrail
            // 
            dgvAuditTrail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditTrail.Location = new Point(23, 36);
            dgvAuditTrail.Name = "dgvAuditTrail";
            dgvAuditTrail.RowHeadersWidth = 51;
            dgvAuditTrail.Size = new Size(777, 320);
            dgvAuditTrail.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(766, 582);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(126, 46);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(123, 66);
            label10.Name = "label10";
            label10.Size = new Size(179, 20);
            label10.TabIndex = 19;
            label10.Text = "Network and Systems, Co.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(118, 26);
            label11.Name = "label11";
            label11.Size = new Size(214, 40);
            label11.TabIndex = 18;
            label11.Text = "PENTANODE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(656, 66);
            label12.Name = "label12";
            label12.Size = new Size(243, 23);
            label12.TabIndex = 20;
            label12.Text = "CONFIGURATION PANEL";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(55, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 1);
            panel2.TabIndex = 21;
            // 
            // AdminSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(950, 650);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label10;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label12;
        private Panel panel2;
    }
}