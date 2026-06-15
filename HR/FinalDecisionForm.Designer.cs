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
            dgvFinalReview = new DataGridView();
            txtDecisionName = new TextBox();
            txtFinalRemarks = new TextBox();
            btnSubmitDecision = new Button();
            btnBack = new Button();
            label1 = new Label();
            cmbFinalDecision = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFinalReview).BeginInit();
            SuspendLayout();
            // 
            // dgvFinalReview
            // 
            dgvFinalReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinalReview.Location = new Point(51, 48);
            dgvFinalReview.Name = "dgvFinalReview";
            dgvFinalReview.RowHeadersWidth = 51;
            dgvFinalReview.Size = new Size(689, 230);
            dgvFinalReview.TabIndex = 0;
            dgvFinalReview.CellClick += dgvFinalReview_CellClick;
            dgvFinalReview.CellContentClick += dgvFinalReview_CellClick;
            // 
            // txtDecisionName
            // 
            txtDecisionName.Location = new Point(51, 304);
            txtDecisionName.Name = "txtDecisionName";
            txtDecisionName.ReadOnly = true;
            txtDecisionName.Size = new Size(356, 27);
            txtDecisionName.TabIndex = 1;
            // 
            // txtFinalRemarks
            // 
            txtFinalRemarks.Location = new Point(413, 304);
            txtFinalRemarks.Multiline = true;
            txtFinalRemarks.Name = "txtFinalRemarks";
            txtFinalRemarks.Size = new Size(234, 129);
            txtFinalRemarks.TabIndex = 3;
            // 
            // btnSubmitDecision
            // 
            btnSubmitDecision.Location = new Point(664, 304);
            btnSubmitDecision.Name = "btnSubmitDecision";
            btnSubmitDecision.Size = new Size(124, 49);
            btnSubmitDecision.TabIndex = 4;
            btnSubmitDecision.Text = "Submit Final Decision";
            btnSubmitDecision.UseVisualStyleBackColor = true;
            btnSubmitDecision.Click += btnSubmitDecision_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(664, 384);
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
            label1.Location = new Point(46, 281);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 6;
            label1.Text = "Applicant Name";
            // 
            // cmbFinalDecision
            // 
            cmbFinalDecision.FormattingEnabled = true;
            cmbFinalDecision.Items.AddRange(new object[] { "Hired", "Rejected" });
            cmbFinalDecision.Location = new Point(51, 384);
            cmbFinalDecision.Name = "cmbFinalDecision";
            cmbFinalDecision.Size = new Size(356, 28);
            cmbFinalDecision.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 346);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 8;
            label2.Text = "Final Decision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 281);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 9;
            label3.Text = "Final Remarks";
            // 
            // FinalDecisionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}