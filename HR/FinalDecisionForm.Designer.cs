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
            cmbFinalDecision = new ComboBox();
            txtFinalRemarks = new TextBox();
            btnSubmitDecision = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFinalReview).BeginInit();
            SuspendLayout();
            // 
            // dgvFinalReview
            // 
            dgvFinalReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinalReview.Location = new Point(59, 45);
            dgvFinalReview.Name = "dgvFinalReview";
            dgvFinalReview.RowHeadersWidth = 51;
            dgvFinalReview.Size = new Size(689, 217);
            dgvFinalReview.TabIndex = 0;
            dgvFinalReview.CellContentClick += dgvFinalReview_CellContentClick;
            // 
            // txtDecisionName
            // 
            txtDecisionName.Location = new Point(59, 268);
            txtDecisionName.Name = "txtDecisionName";
            txtDecisionName.ReadOnly = true;
            txtDecisionName.Size = new Size(469, 27);
            txtDecisionName.TabIndex = 1;
            // 
            // cmbFinalDecision
            // 
            cmbFinalDecision.FormattingEnabled = true;
            cmbFinalDecision.Items.AddRange(new object[] { "Hired", "Rejected" });
            cmbFinalDecision.Location = new Point(59, 301);
            cmbFinalDecision.Name = "cmbFinalDecision";
            cmbFinalDecision.Size = new Size(469, 28);
            cmbFinalDecision.TabIndex = 2;
            // 
            // txtFinalRemarks
            // 
            txtFinalRemarks.Location = new Point(59, 335);
            txtFinalRemarks.Multiline = true;
            txtFinalRemarks.Name = "txtFinalRemarks";
            txtFinalRemarks.Size = new Size(469, 98);
            txtFinalRemarks.TabIndex = 3;
            // 
            // btnSubmitDecision
            // 
            btnSubmitDecision.Location = new Point(534, 384);
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
            // FinalDecisionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ComboBox cmbFinalDecision;
        private TextBox txtFinalRemarks;
        private Button btnSubmitDecision;
        private Button btnBack;
    }
}