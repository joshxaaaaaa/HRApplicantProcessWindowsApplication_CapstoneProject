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
            label3 = new Label();
            EntJobtitle = new TextBox();
            label4 = new Label();
            EntQualifications = new TextBox();
            label5 = new Label();
            EntRequirements = new TextBox();
            btnSaveVacancy = new Button();
            btnCancel = new Button();
            cmbDepartment = new ComboBox();
            label6 = new Label();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 159);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Job title";
            // 
            // EntJobtitle
            // 
            EntJobtitle.ForeColor = SystemColors.WindowFrame;
            EntJobtitle.Location = new Point(20, 182);
            EntJobtitle.Name = "EntJobtitle";
            EntJobtitle.Size = new Size(515, 27);
            EntJobtitle.TabIndex = 9;
            EntJobtitle.Text = "Enter job title...";
            EntJobtitle.Enter += EntJobtitle_Enter;
            EntJobtitle.KeyDown += EntJobtitle_KeyDown;
            EntJobtitle.Leave += EntJobtitle_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 212);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 10;
            label4.Text = "Qualifications";
            // 
            // EntQualifications
            // 
            EntQualifications.ForeColor = SystemColors.WindowFrame;
            EntQualifications.Location = new Point(22, 235);
            EntQualifications.Multiline = true;
            EntQualifications.Name = "EntQualifications";
            EntQualifications.Size = new Size(515, 118);
            EntQualifications.TabIndex = 11;
            EntQualifications.Text = "Enter qualifications...";
            EntQualifications.Enter += EntQualifications_Enter;
            EntQualifications.KeyDown += EntQualifications_KeyDown;
            EntQualifications.Leave += EntQualifications_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 356);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 12;
            label5.Text = "Requirements";
            // 
            // EntRequirements
            // 
            EntRequirements.ForeColor = SystemColors.WindowFrame;
            EntRequirements.Location = new Point(22, 379);
            EntRequirements.Multiline = true;
            EntRequirements.Name = "EntRequirements";
            EntRequirements.Size = new Size(515, 118);
            EntRequirements.TabIndex = 13;
            EntRequirements.Text = "Enter requirements...";
            EntRequirements.Enter += EntRequirements_Enter;
            EntRequirements.KeyDown += EntRequirements_KeyDown;
            EntRequirements.Leave += EntRequirements_Leave;
            // 
            // btnSaveVacancy
            // 
            btnSaveVacancy.BackColor = SystemColors.Highlight;
            btnSaveVacancy.FlatStyle = FlatStyle.Flat;
            btnSaveVacancy.ForeColor = SystemColors.ButtonHighlight;
            btnSaveVacancy.Location = new Point(22, 503);
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
            btnCancel.Location = new Point(22, 538);
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
            cmbDepartment.Location = new Point(22, 128);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(513, 28);
            cmbDepartment.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 87);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 17;
            label6.Text = "Department";
            // 
            // AddVacancyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 629);
            Controls.Add(label6);
            Controls.Add(cmbDepartment);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveVacancy);
            Controls.Add(EntRequirements);
            Controls.Add(label5);
            Controls.Add(EntQualifications);
            Controls.Add(label4);
            Controls.Add(EntJobtitle);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox EntJobtitle;
        private Label label4;
        private TextBox EntQualifications;
        private Label label5;
        private TextBox EntRequirements;
        private Button btnSaveVacancy;
        private Button btnCancel;
        private ComboBox cmbDepartment;
        private Label label6;
    }
}