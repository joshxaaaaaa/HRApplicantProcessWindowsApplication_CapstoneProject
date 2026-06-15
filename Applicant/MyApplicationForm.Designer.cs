namespace HRApplicantWindowSystem
{
    partial class MyApplicationForm
    {
            private System.ComponentModel.IContainer components = null;
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
            lblTitle = new Label();
            lblStatusText = new Label();
            lblLockState = new Label();
            lblLockNotice = new Label();
            btnDeleteDraft = new Button();
            btnCancel = new Button();
            dgvRequirements = new DataGridView();
            lblJobTitle = new Label();
            btnMyProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 52, 71);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 32);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Manage My Application";
            // 
            // lblStatusText
            // 
            lblStatusText.AutoSize = true;
            lblStatusText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatusText.ForeColor = Color.FromArgb(0, 102, 204);
            lblStatusText.Location = new Point(12, 373);
            lblStatusText.Name = "lblStatusText";
            lblStatusText.Size = new Size(258, 25);
            lblStatusText.TabIndex = 4;
            lblStatusText.Text = "Status: Draft (Unsubmitted)";
            // 
            // lblLockState
            // 
            lblLockState.AutoSize = true;
            lblLockState.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLockState.ForeColor = Color.DarkGreen;
            lblLockState.Location = new Point(35, 403);
            lblLockState.Name = "lblLockState";
            lblLockState.Size = new Size(74, 20);
            lblLockState.TabIndex = 5;
            lblLockState.Text = "Unlocked";
            // 
            // lblLockNotice
            // 
            lblLockNotice.AutoSize = true;
            lblLockNotice.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblLockNotice.ForeColor = Color.Gray;
            lblLockNotice.Location = new Point(26, 428);
            lblLockNotice.Name = "lblLockNotice";
            lblLockNotice.Size = new Size(316, 20);
            lblLockNotice.TabIndex = 3;
            lblLockNotice.Text = "Checking database tracking permissions status...";
            // 
            // btnDeleteDraft
            // 
            btnDeleteDraft.Font = new Font("Segoe UI", 9F);
            btnDeleteDraft.Location = new Point(278, 451);
            btnDeleteDraft.Name = "btnDeleteDraft";
            btnDeleteDraft.Size = new Size(140, 40);
            btnDeleteDraft.TabIndex = 1;
            btnDeleteDraft.Text = "Retract Submission";
            btnDeleteDraft.UseVisualStyleBackColor = true;
            btnDeleteDraft.Click += btnDeleteDraft_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(581, 438);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Close Windows";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvRequirements
            // 
            dgvRequirements.AllowUserToAddRows = false;
            dgvRequirements.AllowUserToDeleteRows = false;
            dgvRequirements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequirements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequirements.Location = new Point(12, 57);
            dgvRequirements.Name = "dgvRequirements";
            dgvRequirements.ReadOnly = true;
            dgvRequirements.RowHeadersWidth = 51;
            dgvRequirements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequirements.Size = new Size(710, 297);
            dgvRequirements.TabIndex = 11;
            // 
            // lblJobTitle
            // 
            lblJobTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblJobTitle.Location = new Point(464, 13);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(258, 28);
            lblJobTitle.TabIndex = 10;
            lblJobTitle.Click += lblJobTitle_Click;
            // 
            // btnMyProfile
            // 
            btnMyProfile.Location = new Point(546, 378);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(175, 45);
            btnMyProfile.TabIndex = 12;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.UseVisualStyleBackColor = true;
            // 
            // MyApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(742, 510);
            Controls.Add(btnMyProfile);
            Controls.Add(lblJobTitle);
            Controls.Add(dgvRequirements);
            Controls.Add(btnCancel);
            Controls.Add(btnDeleteDraft);
            Controls.Add(lblLockNotice);
            Controls.Add(lblLockState);
            Controls.Add(lblStatusText);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MyApplicationForm";
            Text = "Job Application Portal";
            Load += MyApplicationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblStatusText;
            private System.Windows.Forms.Label lblLockState;
            private System.Windows.Forms.Label lblLockNotice;
            private System.Windows.Forms.Button btnDeleteDraft;
            private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvRequirements;
        private Label lblJobTitle;
        private Button btnMyProfile;
    }
    }
