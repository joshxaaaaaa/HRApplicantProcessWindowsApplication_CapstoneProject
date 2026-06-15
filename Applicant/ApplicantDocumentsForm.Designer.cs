namespace HRApplicantWindowSystem
{
    partial class ApplicantDocumentsForm
    {

        private System.ComponentModel.IContainer components = null;


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

        private void InitializeComponent()
        {
            dgvDocuments = new DataGridView();
            btnUpload = new Button();
            lblRemarks = new Label();
            btnSave = new Button();
            btnBack = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            SuspendLayout();
            // 
            // dgvDocuments
            // 
            dgvDocuments.AllowUserToAddRows = false;
            dgvDocuments.AllowUserToDeleteRows = false;
            dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Location = new Point(27, 87);
            dgvDocuments.Margin = new Padding(3, 4, 3, 4);
            dgvDocuments.MultiSelect = false;
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.ReadOnly = true;
            dgvDocuments.RowHeadersWidth = 51;
            dgvDocuments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocuments.Size = new Size(686, 458);
            dgvDocuments.TabIndex = 0;
            dgvDocuments.CellContentClick += dgvDocuments_CellContentClick;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI", 9F);
            btnUpload.Location = new Point(417, 563);
            btnUpload.Margin = new Padding(3, 4, 3, 4);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(137, 40);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "Upload File...";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 9F);
            lblRemarks.Location = new Point(27, 573);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(215, 20);
            lblRemarks.TabIndex = 3;
            lblRemarks.Text = "Select a requirement to upload\r\n";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(576, 560);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 47);
            btnSave.TabIndex = 4;
            btnSave.Text = "Submit All";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.Location = new Point(594, 637);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 37);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(23, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(363, 37);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Applicant Documents Page";
            // 
            // ApplicantDocumentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 687);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(lblRemarks);
            Controls.Add(btnUpload);
            Controls.Add(dgvDocuments);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ApplicantDocumentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Required Documents";
            Load += ApplicantDocumentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnSave;
        private Button btnBack;
        private Label lblTitle;
    }
}