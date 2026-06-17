namespace HRApplicantWindowSystem
{
    partial class FinalDecisionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalDecisionForm));
            dgvFinalReview = new DataGridView();
            txtDecisionName = new TextBox();
            txtFinalRemarks = new TextBox();
            btnSubmitDecision = new Button();
            btnBack = new Button();
            label1 = new Label();
            cmbFinalDecision = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvFinalReview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvFinalReview
            // 
            dgvFinalReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinalReview.Location = new Point(52, 154);
            dgvFinalReview.Name = "dgvFinalReview";
            dgvFinalReview.RowHeadersWidth = 51;
            dgvFinalReview.Size = new Size(834, 203);
            dgvFinalReview.TabIndex = 0;
            dgvFinalReview.CellClick += dgvFinalReview_CellClick;
            dgvFinalReview.CellContentClick += dgvFinalReview_CellClick;
            // 
            // txtDecisionName
            // 
            txtDecisionName.Location = new Point(52, 419);
            txtDecisionName.Name = "txtDecisionName";
            txtDecisionName.ReadOnly = true;
            txtDecisionName.Size = new Size(356, 27);
            txtDecisionName.TabIndex = 1;
            // 
            // txtFinalRemarks
            // 
            txtFinalRemarks.Location = new Point(457, 419);
            txtFinalRemarks.Multiline = true;
            txtFinalRemarks.Name = "txtFinalRemarks";
            txtFinalRemarks.Size = new Size(429, 108);
            txtFinalRemarks.TabIndex = 3;
            // 
            // btnSubmitDecision
            // 
            btnSubmitDecision.BackColor = SystemColors.HotTrack;
            btnSubmitDecision.FlatStyle = FlatStyle.Flat;
            btnSubmitDecision.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitDecision.ForeColor = SystemColors.Control;
            btnSubmitDecision.Location = new Point(543, 553);
            btnSubmitDecision.Name = "btnSubmitDecision";
            btnSubmitDecision.Size = new Size(182, 49);
            btnSubmitDecision.TabIndex = 4;
            btnSubmitDecision.Text = "Submit Final Decision";
            btnSubmitDecision.UseVisualStyleBackColor = false;
            btnSubmitDecision.Click += btnSubmitDecision_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(762, 553);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(124, 49);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 396);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 6;
            label1.Text = "Applicant Name";
            // 
            // cmbFinalDecision
            // 
            cmbFinalDecision.FormattingEnabled = true;
            cmbFinalDecision.Items.AddRange(new object[] { "Hired", "Rejected" });
            cmbFinalDecision.Location = new Point(52, 499);
            cmbFinalDecision.Name = "cmbFinalDecision";
            cmbFinalDecision.Size = new Size(356, 28);
            cmbFinalDecision.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 476);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 8;
            label2.Text = "Final Decision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(457, 396);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 9;
            label3.Text = "Final Remarks";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 68);
            label6.Name = "label6";
            label6.Size = new Size(179, 20);
            label6.TabIndex = 16;
            label6.Text = "Network and Systems, Co.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(115, 28);
            label7.Name = "label7";
            label7.Size = new Size(214, 40);
            label7.TabIndex = 15;
            label7.Text = "PENTANODE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(651, 43);
            label4.Name = "label4";
            label4.Size = new Size(241, 23);
            label4.TabIndex = 17;
            label4.Text = "FINAL HIRING DECISION";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(52, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 1);
            panel2.TabIndex = 18;
            // 
            // FinalDecisionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(950, 650);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSubmitDecision);
            Controls.Add(txtFinalRemarks);
            Controls.Add(cmbFinalDecision);
            Controls.Add(txtDecisionName);
            Controls.Add(dgvFinalReview);
            Name = "FinalDecisionForm";
            Text = "Final Hiring Decision";
            Load += FinalDecisionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFinalReview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFinalReview;
        private TextBox txtDecisionName;
        private TextBox txtFinalRemarks;
        private Button btnSubmitDecision;
        private Button btnBack;
        private Label label1;
        private ComboBox cmbFinalDecision;
        private Label label2;
        private Label label3;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label4;
        private Panel panel2;
    }
}