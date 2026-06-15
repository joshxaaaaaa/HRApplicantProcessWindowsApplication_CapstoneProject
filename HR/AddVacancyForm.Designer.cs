namespace HRApplicantWindowSystem
{
    partial class AddVacancyForm
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
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            btnSaveVacancy = new Button();
            btnCancel = new Button();
            cmbDepartment = new ComboBox();
            label6 = new Label();
            clbRequirements = new CheckedListBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbPosition = new ComboBox();
            cmbEmploymentType = new ComboBox();
            cmbAssessmentType = new ComboBox();
            cmbInterviewType = new ComboBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 3;
            label1.Text = "ADD JOB VACANCY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 45);
            label2.Name = "label2";
            label2.Size = new Size(365, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter the job details,  qualifications, and requirements";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(22, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 1);
            panel2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 417);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 12;
            label5.Text = "Requirements";
            // 
            // btnSaveVacancy
            // 
            btnSaveVacancy.BackColor = SystemColors.Highlight;
            btnSaveVacancy.FlatStyle = FlatStyle.Flat;
            btnSaveVacancy.ForeColor = SystemColors.ButtonHighlight;
            btnSaveVacancy.Location = new Point(22, 553);
            btnSaveVacancy.Name = "btnSaveVacancy";
            btnSaveVacancy.Size = new Size(515, 29);
            btnSaveVacancy.TabIndex = 14;
            btnSaveVacancy.Text = "Save and Post Vacancy";
            btnSaveVacancy.UseVisualStyleBackColor = false;
            btnSaveVacancy.Click += btnSaveVacancy_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(22, 588);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(515, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(24, 132);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(513, 28);
            cmbDepartment.TabIndex = 16;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 93);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 17;
            label6.Text = "Department";
            // 
            // clbRequirements
            // 
            clbRequirements.CheckOnClick = true;
            clbRequirements.FormattingEnabled = true;
            clbRequirements.Location = new Point(23, 440);
            clbRequirements.Name = "clbRequirements";
            clbRequirements.Size = new Size(515, 92);
            clbRequirements.TabIndex = 29;
            clbRequirements.SelectedIndexChanged += clbRequirements_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 163);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 19;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 230);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 20;
            label4.Text = "Employment Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 297);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 21;
            label7.Text = "Assessment Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 351);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 22;
            label8.Text = "Interview Type";
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(22, 199);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(512, 28);
            cmbPosition.TabIndex = 23;
            // 
            // cmbEmploymentType
            // 
            cmbEmploymentType.FormattingEnabled = true;
            cmbEmploymentType.Location = new Point(22, 253);
            cmbEmploymentType.Name = "cmbEmploymentType";
            cmbEmploymentType.Size = new Size(512, 28);
            cmbEmploymentType.TabIndex = 24;
            // 
            // cmbAssessmentType
            // 
            cmbAssessmentType.FormattingEnabled = true;
            cmbAssessmentType.Location = new Point(25, 320);
            cmbAssessmentType.Name = "cmbAssessmentType";
            cmbAssessmentType.Size = new Size(512, 28);
            cmbAssessmentType.TabIndex = 25;
            // 
            // cmbInterviewType
            // 
            cmbInterviewType.FormattingEnabled = true;
            cmbInterviewType.Location = new Point(25, 374);
            cmbInterviewType.Name = "cmbInterviewType";
            cmbInterviewType.Size = new Size(512, 28);
            cmbInterviewType.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 375);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 27;
            label9.Text = "Description";
            // 
            // AddVacancyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 629);
            Controls.Add(cmbInterviewType);
            Controls.Add(cmbAssessmentType);
            Controls.Add(cmbEmploymentType);
            Controls.Add(cmbPosition);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(clbRequirements);
            Controls.Add(label6);
            Controls.Add(cmbDepartment);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveVacancy);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddVacancyForm";
            Text = "AddVacancyForm";
            Load += AddVacancyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private Button btnSaveVacancy;
        private Button btnCancel;
        private ComboBox cmbDepartment;
        private Label label6;
        private CheckedListBox clbRequirements;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private ComboBox cmbPosition;
        private ComboBox cmbEmploymentType;
        private ComboBox cmbAssessmentType;
        private ComboBox cmbInterviewType;
        private Label label9;
    }
}