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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantSummaryForm));
            lblCurrentStatus = new Label();
            lblInterviewDetails = new Label();
            dgvMissingDocs = new DataGridView();
            dgvRecentUpdates = new DataGridView();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMissingDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentUpdates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.BackColor = Color.LightBlue;
            lblCurrentStatus.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCurrentStatus.Location = new Point(24, 165);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(147, 27);
            lblCurrentStatus.TabIndex = 0;
            lblCurrentStatus.Text = "Current Status";
            // 
            // lblInterviewDetails
            // 
            lblInterviewDetails.AutoSize = true;
            lblInterviewDetails.BackColor = Color.SkyBlue;
            lblInterviewDetails.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInterviewDetails.Location = new Point(509, 166);
            lblInterviewDetails.Name = "lblInterviewDetails";
            lblInterviewDetails.Size = new Size(165, 25);
            lblInterviewDetails.TabIndex = 1;
            lblInterviewDetails.Text = "Interview Details";
            lblInterviewDetails.Click += lblInterviewDetails_Click;
            // 
            // dgvMissingDocs
            // 
            dgvMissingDocs.BackgroundColor = SystemColors.Menu;
            dgvMissingDocs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMissingDocs.Location = new Point(70, 305);
            dgvMissingDocs.Name = "dgvMissingDocs";
            dgvMissingDocs.RowHeadersWidth = 51;
            dgvMissingDocs.Size = new Size(358, 268);
            dgvMissingDocs.TabIndex = 2;
            // 
            // dgvRecentUpdates
            // 
            dgvRecentUpdates.BackgroundColor = SystemColors.Menu;
            dgvRecentUpdates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentUpdates.Location = new Point(502, 299);
            dgvRecentUpdates.Name = "dgvRecentUpdates";
            dgvRecentUpdates.RowHeadersWidth = 51;
            dgvRecentUpdates.Size = new Size(378, 274);
            dgvRecentUpdates.TabIndex = 3;
            dgvRecentUpdates.CellContentClick += dgvRecentUpdates_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(802, 598);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 259);
            label1.Name = "label1";
            label1.Size = new Size(275, 34);
            label1.TabIndex = 5;
            label1.Text = "Missing Documents";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(502, 259);
            label2.Name = "label2";
            label2.Size = new Size(228, 34);
            label2.TabIndex = 6;
            label2.Text = "Recent Updates";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(226, 12);
            label5.Name = "label5";
            label5.Size = new Size(475, 40);
            label5.TabIndex = 10;
            label5.Text = "MY APPLICATION SUMMARY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(319, 64);
            label3.Name = "label3";
            label3.Size = new Size(312, 20);
            label3.TabIndex = 11;
            label3.Text = "You may view your application summary here!";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(963, 90);
            dataGridView1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleTurquoise;
            label4.Location = new Point(169, 110);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 13;
            label4.Text = "Application Status:";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LightBlue;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 98);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(470, 111);
            dataGridView2.TabIndex = 14;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.SkyBlue;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(488, 98);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(455, 111);
            dataGridView3.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DeepSkyBlue;
            label6.Location = new Point(646, 110);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 16;
            label6.Text = "Interview Details:";
            // 
            // ApplicantSummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(950, 650);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgvRecentUpdates);
            Controls.Add(dgvMissingDocs);
            Controls.Add(lblInterviewDetails);
            Controls.Add(lblCurrentStatus);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView3);
            Name = "ApplicantSummaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Applicant Summary";
            Load += ApplicantSummaryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMissingDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentUpdates).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
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
        private PictureBox pictureBox1;
        private Label label5;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label label6;
    }
}