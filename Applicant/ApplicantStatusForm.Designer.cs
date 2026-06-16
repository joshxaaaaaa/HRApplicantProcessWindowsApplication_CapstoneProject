namespace HRApplicantWindowSystem
{
    partial class ApplicantStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantStatusForm));
            lblJobTitle = new Label();
            txtHRRemarks = new TextBox();
            btnRefresh = new Button();
            btnClose = new Button();
            lblRemarksHeader = new Label();
            lblFinalResult = new Label();
            lblInterviewSchedule = new Label();
            lblCurrentStage = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblJobTitle.ForeColor = Color.FromArgb(45, 52, 71);
            lblJobTitle.Location = new Point(19, 58);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new Size(241, 25);
            lblJobTitle.TabIndex = 0;
            lblJobTitle.Text = "Applying For: [Loading...]";
            // 
            // txtHRRemarks
            // 
            txtHRRemarks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHRRemarks.BackColor = SystemColors.ControlLightLight;
            txtHRRemarks.Font = new Font("Segoe UI", 9.5F);
            txtHRRemarks.Location = new Point(19, 205);
            txtHRRemarks.Margin = new Padding(3, 2, 3, 2);
            txtHRRemarks.Multiline = true;
            txtHRRemarks.Name = "txtHRRemarks";
            txtHRRemarks.ReadOnly = true;
            txtHRRemarks.ScrollBars = ScrollBars.Vertical;
            txtHRRemarks.Size = new Size(770, 216);
            txtHRRemarks.TabIndex = 4;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.Location = new Point(19, 431);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 26);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh Status";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.Location = new Point(684, 431);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(105, 26);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close View";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblRemarksHeader
            // 
            lblRemarksHeader.AutoSize = true;
            lblRemarksHeader.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRemarksHeader.ForeColor = Color.FromArgb(45, 52, 71);
            lblRemarksHeader.Location = new Point(19, 178);
            lblRemarksHeader.Name = "lblRemarksHeader";
            lblRemarksHeader.Size = new Size(182, 17);
            lblRemarksHeader.TabIndex = 8;
            lblRemarksHeader.Text = "HR Evaluation Feed / Notes:";
            // 
            // lblFinalResult
            // 
            lblFinalResult.AutoSize = true;
            lblFinalResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFinalResult.ForeColor = Color.DarkOrange;
            lblFinalResult.Location = new Point(19, 150);
            lblFinalResult.Name = "lblFinalResult";
            lblFinalResult.Size = new Size(170, 20);
            lblFinalResult.TabIndex = 3;
            lblFinalResult.Text = "Final Decision: Pending";
            // 
            // lblInterviewSchedule
            // 
            lblInterviewSchedule.AutoSize = true;
            lblInterviewSchedule.Font = new Font("Segoe UI", 10F);
            lblInterviewSchedule.Location = new Point(19, 121);
            lblInterviewSchedule.Name = "lblInterviewSchedule";
            lblInterviewSchedule.Size = new Size(191, 19);
            lblInterviewSchedule.TabIndex = 2;
            lblInterviewSchedule.Text = "Interview Schedule: Fetching...";
            // 
            // lblCurrentStage
            // 
            lblCurrentStage.AutoSize = true;
            lblCurrentStage.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCurrentStage.ForeColor = Color.FromArgb(0, 102, 204);
            lblCurrentStage.Location = new Point(19, 92);
            lblCurrentStage.Name = "lblCurrentStage";
            lblCurrentStage.Size = new Size(245, 20);
            lblCurrentStage.TabIndex = 1;
            lblCurrentStage.Text = "Current Pipeline Stage: Submitted";
            lblCurrentStage.Click += lblCurrentStage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(628, 41);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 19;
            label3.Text = "Network and Systems, Co.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(628, 11);
            label2.Name = "label2";
            label2.Size = new Size(172, 33);
            label2.TabIndex = 18;
            label2.Text = "PENTANODE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(542, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20F);
            label4.Location = new Point(19, 11);
            label4.Name = "label4";
            label4.Size = new Size(366, 33);
            label4.TabIndex = 20;
            label4.Text = "Application Status Tracking";
            // 
            // ApplicantStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(808, 470);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(lblFinalResult);
            Controls.Add(lblInterviewSchedule);
            Controls.Add(lblCurrentStage);
            Controls.Add(lblRemarksHeader);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(txtHRRemarks);
            Controls.Add(lblJobTitle);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(440, 347);
            Name = "ApplicantStatusForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Application Status Tracking";
            Load += ApplicantStatusForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.TextBox txtHRRemarks;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRemarksHeader;
        private Label lblFinalResult;
        private Label lblInterviewSchedule;
        private Label lblCurrentStage;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
