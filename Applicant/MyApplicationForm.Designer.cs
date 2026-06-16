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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyApplicationForm));
            lblStatusText = new Label();
            lblLockState = new Label();
            lblLockNotice = new Label();
            btnDeleteDraft = new Button();
            btnCancel = new Button();
            dgvRequirements = new DataGridView();
            btnMyProfile = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblJobTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblStatusText
            // 
            lblStatusText.AutoSize = true;
            lblStatusText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatusText.ForeColor = Color.FromArgb(0, 102, 204);
            lblStatusText.Location = new Point(43, 519);
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
            lblLockState.Location = new Point(67, 548);
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
            lblLockNotice.Location = new Point(58, 573);
            lblLockNotice.Name = "lblLockNotice";
            lblLockNotice.Size = new Size(316, 20);
            lblLockNotice.TabIndex = 3;
            lblLockNotice.Text = "Checking database tracking permissions status...";
            // 
            // btnDeleteDraft
            // 
            btnDeleteDraft.Font = new Font("Segoe UI", 9F);
            btnDeleteDraft.Location = new Point(58, 613);
            btnDeleteDraft.Name = "btnDeleteDraft";
            btnDeleteDraft.Size = new Size(139, 40);
            btnDeleteDraft.TabIndex = 1;
            btnDeleteDraft.Text = "Retract Submission";
            btnDeleteDraft.UseVisualStyleBackColor = true;
            btnDeleteDraft.Click += btnDeleteDraft_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(650, 573);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 40);
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
            dgvRequirements.Location = new Point(43, 195);
            dgvRequirements.Name = "dgvRequirements";
            dgvRequirements.ReadOnly = true;
            dgvRequirements.RowHeadersWidth = 51;
            dgvRequirements.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequirements.Size = new Size(746, 297);
            dgvRequirements.TabIndex = 11;
            // 
            // btnMyProfile
            // 
            btnMyProfile.Location = new Point(650, 511);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(139, 45);
            btnMyProfile.TabIndex = 12;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20F);
            label4.Location = new Point(43, 128);
            label4.Name = "label4";
            label4.Size = new Size(417, 40);
            label4.TabIndex = 13;
            label4.Text = "Manage My Application";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 67);
            label3.Name = "label3";
            label3.Size = new Size(179, 20);
            label3.TabIndex = 16;
            label3.Text = "Network and Systems, Co.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(352, 27);
            label2.Name = "label2";
            label2.Size = new Size(214, 40);
            label2.TabIndex = 15;
            label2.Text = "PENTANODE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(254, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Location = new Point(662, 146);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(0, 20);
            lblJobTitle.TabIndex = 17;
            // 
            // MyApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(846, 683);
            Controls.Add(lblJobTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnMyProfile);
            Controls.Add(dgvRequirements);
            Controls.Add(btnCancel);
            Controls.Add(btnDeleteDraft);
            Controls.Add(lblLockNotice);
            Controls.Add(lblLockState);
            Controls.Add(lblStatusText);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MyApplicationForm";
            Text = "Job Application Portal";
            Load += MyApplicationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRequirements).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblStatusText;
            private System.Windows.Forms.Label lblLockState;
            private System.Windows.Forms.Label lblLockNotice;
            private System.Windows.Forms.Button btnDeleteDraft;
            private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvRequirements;
        private Button btnMyProfile;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblJobTitle;
    }
    }
