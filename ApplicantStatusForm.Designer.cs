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
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblCurrentStage = new System.Windows.Forms.Label();
            this.lblInterviewSchedule = new System.Windows.Forms.Label();
            this.lblFinalResult = new System.Windows.Forms.Label();
            this.txtHRRemarks = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpTimeline = new System.Windows.Forms.GroupBox();
            this.lblRemarksHeader = new System.Windows.Forms.Label();
            this.grpTimeline.SuspendLayout();
            this.SuspendLayout();

            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJobTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.lblJobTitle.Location = new System.Drawing.Point(16, 15);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(258, 32);
            this.lblJobTitle.TabIndex = 0;
            this.lblJobTitle.Text = "Applying For: [Loading...]";

            this.lblCurrentStage.AutoSize = true;
            this.lblCurrentStage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentStage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblCurrentStage.Location = new System.Drawing.Point(16, 35);
            this.lblCurrentStage.Name = "lblCurrentStage";
            this.lblCurrentStage.Size = new System.Drawing.Size(320, 25);
            this.lblCurrentStage.TabIndex = 1;
            this.lblCurrentStage.Text = "Current Pipeline Stage: Submitted";

            this.lblInterviewSchedule.AutoSize = true;
            this.lblInterviewSchedule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInterviewSchedule.Location = new System.Drawing.Point(16, 75);
            this.lblInterviewSchedule.Name = "lblInterviewSchedule";
            this.lblInterviewSchedule.Size = new System.Drawing.Size(242, 23);
            this.lblInterviewSchedule.TabIndex = 2;
            this.lblInterviewSchedule.Text = "Interview Schedule: Fetching...";

            this.lblFinalResult.AutoSize = true;
            this.lblFinalResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalResult.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFinalResult.Location = new System.Drawing.Point(16, 115);
            this.lblFinalResult.Name = "lblFinalResult";
            this.lblFinalResult.Size = new System.Drawing.Size(215, 25);
            this.lblFinalResult.TabIndex = 3;
            this.lblFinalResult.Text = "Final Decision: Pending";

            this.txtHRRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHRRemarks.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHRRemarks.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHRRemarks.Location = new System.Drawing.Point(22, 250);
            this.txtHRRemarks.Multiline = true;
            this.txtHRRemarks.Name = "txtHRRemarks";
            this.txtHRRemarks.ReadOnly = true;
            this.txtHRRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHRRemarks.Size = new System.Drawing.Size(640, 200);
            this.txtHRRemarks.TabIndex = 4;

            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(22, 465);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 35);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh Status";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(542, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close View";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.grpTimeline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimeline.Controls.Add(this.lblCurrentStage);
            this.grpTimeline.Controls.Add(this.lblInterviewSchedule);
            this.grpTimeline.Controls.Add(this.lblFinalResult);
            this.grpTimeline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpTimeline.Location = new System.Drawing.Point(22, 60);
            this.grpTimeline.Name = "grpTimeline";
            this.grpTimeline.Size = new System.Drawing.Size(640, 155);
            this.grpTimeline.TabIndex = 7;
            this.grpTimeline.TabStop = false;
            this.grpTimeline.Text = "Application Progress Timeline";

            this.lblRemarksHeader.AutoSize = true;
            this.lblRemarksHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemarksHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.lblRemarksHeader.Location = new System.Drawing.Point(22, 225);
            this.lblRemarksHeader.Name = "lblRemarksHeader";
            this.lblRemarksHeader.Size = new System.Drawing.Size(216, 21);
            this.lblRemarksHeader.TabIndex = 8;
            this.lblRemarksHeader.Text = "HR Evaluation Feed / Notes:";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(684, 517);
            this.Controls.Add(this.lblRemarksHeader);
            this.Controls.Add(this.grpTimeline);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtHRRemarks);
            this.Controls.Add(this.lblJobTitle);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "ApplicantStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Status Tracking";
            this.Load += new System.EventHandler(this.ApplicantStatusForm_Load);
            this.grpTimeline.ResumeLayout(false);
            this.grpTimeline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblCurrentStage;
        private System.Windows.Forms.Label lblInterviewSchedule;
        private System.Windows.Forms.Label lblFinalResult;
        private System.Windows.Forms.TextBox txtHRRemarks;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpTimeline;
        private System.Windows.Forms.Label lblRemarksHeader;
    }
}