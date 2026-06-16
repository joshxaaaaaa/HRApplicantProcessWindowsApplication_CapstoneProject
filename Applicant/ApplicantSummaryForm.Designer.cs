namespace HRApplicantWindowSystem
{
    partial class ApplicantSummaryForm
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
            lblCurrentStatus = new Label();
            lblInterviewDetails = new Label();
            dgvMissingDocs = new DataGridView();
            dgvRecentUpdates = new DataGridView();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMissingDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentUpdates).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(118, 66);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(101, 20);
            lblCurrentStatus.TabIndex = 0;
            lblCurrentStatus.Text = "Current Status";
            // 
            // lblInterviewDetails
            // 
            lblInterviewDetails.AutoSize = true;
            lblInterviewDetails.Location = new Point(512, 66);
            lblInterviewDetails.Name = "lblInterviewDetails";
            lblInterviewDetails.Size = new Size(119, 20);
            lblInterviewDetails.TabIndex = 1;
            lblInterviewDetails.Text = "Interview Details";
            // 
            // dgvMissingDocs
            // 
            dgvMissingDocs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMissingDocs.Location = new Point(51, 219);
            dgvMissingDocs.Name = "dgvMissingDocs";
            dgvMissingDocs.RowHeadersWidth = 51;
            dgvMissingDocs.Size = new Size(247, 219);
            dgvMissingDocs.TabIndex = 2;
            // 
            // dgvRecentUpdates
            // 
            dgvRecentUpdates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentUpdates.Location = new Point(314, 219);
            dgvRecentUpdates.Name = "dgvRecentUpdates";
            dgvRecentUpdates.RowHeadersWidth = 51;
            dgvRecentUpdates.Size = new Size(298, 219);
            dgvRecentUpdates.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(662, 385);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 53);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 173);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 5;
            label1.Text = "Missing Documents";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 168);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 6;
            label2.Text = "Recent Updates";
            // 
            // ApplicantSummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 472);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgvRecentUpdates);
            Controls.Add(dgvMissingDocs);
            Controls.Add(lblInterviewDetails);
            Controls.Add(lblCurrentStatus);
            Name = "ApplicantSummaryForm";
            Text = "Applicant Summary";
            Load += ApplicantSummaryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMissingDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentUpdates).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentStatus;
        private Label lblInterviewDetails;
        private DataGridView dgvMissingDocs;
        private DataGridView dgvRecentUpdates;
        private Button btnBack;
        private Label label1;
        private Label label2;
    }
}