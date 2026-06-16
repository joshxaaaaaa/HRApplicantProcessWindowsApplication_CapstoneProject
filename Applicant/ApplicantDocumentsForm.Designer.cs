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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantDocumentsForm));
            dgvDocuments = new DataGridView();
            btnUpload = new Button();
            lblRemarks = new Label();
            btnSave = new Button();
            btnBack = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvDocuments
            // 
            dgvDocuments.AllowUserToAddRows = false;
            dgvDocuments.AllowUserToDeleteRows = false;
            dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Location = new Point(24, 147);
            dgvDocuments.MultiSelect = false;
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.ReadOnly = true;
            dgvDocuments.RowHeadersWidth = 51;
            dgvDocuments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocuments.Size = new Size(649, 257);
            dgvDocuments.TabIndex = 0;
            dgvDocuments.CellContentClick += dgvDocuments_CellContentClick;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI", 9F);
            btnUpload.Location = new Point(443, 414);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(120, 33);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "Upload File...";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 9F);
            lblRemarks.Location = new Point(24, 420);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(169, 15);
            lblRemarks.TabIndex = 3;
            lblRemarks.Text = "Select a requirement to upload\r\n";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(569, 414);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = "Submit All";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.Location = new Point(569, 460);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 28);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 98);
            label1.Name = "label1";
            label1.Size = new Size(378, 33);
            label1.TabIndex = 7;
            label1.Text = "Applicant Documents Page";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 49);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 14;
            label3.Text = "Network and Systems, Co.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(290, 19);
            label2.Name = "label2";
            label2.Size = new Size(172, 33);
            label2.TabIndex = 13;
            label2.Text = "PENTANODE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(204, 19);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // ApplicantDocumentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(708, 535);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(lblRemarks);
            Controls.Add(btnUpload);
            Controls.Add(dgvDocuments);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ApplicantDocumentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Required Documents";
            Load += ApplicantDocumentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnSave;
        private Button btnBack;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}