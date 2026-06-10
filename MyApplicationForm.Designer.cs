namespace HRApplicantWindowSystem
{
    partial class MyApplicationForm
    {
            private System.ComponentModel.IContainer components = null;
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
                this.lblTitle = new System.Windows.Forms.Label();
                this.lblJobSelect = new System.Windows.Forms.Label();
                this.cboVacancies = new System.Windows.Forms.ComboBox();
                this.lblStatusText = new System.Windows.Forms.Label();
                this.lblLockNotice = new System.Windows.Forms.Label();
                this.btnSubmit = new System.Windows.Forms.Button();
                this.btnDeleteDraft = new System.Windows.Forms.Button();
                this.btnCancel = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // lblTitle
                // 
                this.lblTitle.AutoSize = true;
                this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
                this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
                this.lblTitle.Location = new System.Drawing.Point(20, 20);
                this.lblTitle.Name = "lblTitle";
                this.lblTitle.Size = new System.Drawing.Size(262, 32);
                this.lblTitle.Text = "Manage My Application";
                // 
                // lblJobSelect
                // 
                this.lblJobSelect.AutoSize = true;
                this.lblJobSelect.Font = new System.Drawing.Font("Segoe UI", 10F);
                this.lblJobSelect.Location = new System.Drawing.Point(22, 75);
                this.lblJobSelect.Name = "lblJobSelect";
                this.lblJobSelect.Size = new System.Drawing.Size(206, 23);
                this.lblJobSelect.Text = "Select Target Open Vacancy:";
                // 
                // cboVacancies
                // 
                this.cboVacancies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.cboVacancies.Font = new System.Drawing.Font("Segoe UI", 10F);
                this.cboVacancies.FormattingEnabled = true;
                this.cboVacancies.Location = new System.Drawing.Point(22, 105);
                this.cboVacancies.Name = "cboVacancies";
                this.cboVacancies.Size = new System.Drawing.Size(440, 31);
                // 
                // lblStatusText
                // 
                this.lblStatusText.AutoSize = true;
                this.lblStatusText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
                this.lblStatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
                this.lblStatusText.Location = new System.Drawing.Point(22, 160);
                this.lblStatusText.Name = "lblStatusText";
                this.lblStatusText.Size = new System.Drawing.Size(227, 25);
                this.lblStatusText.Text = "Status: Draft (Unsubmitted)";
                // 
                // lblLockNotice
                // 
                this.lblLockNotice.AutoSize = true;
                this.lblLockNotice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
                this.lblLockNotice.ForeColor = System.Drawing.Color.Gray;
                this.lblLockNotice.Location = new System.Drawing.Point(22, 200);
                this.lblLockNotice.Name = "lblLockNotice";
                this.lblLockNotice.Size = new System.Drawing.Size(350, 20);
                this.lblLockNotice.Text = "Checking database tracking permissions status...";
                // 
                // btnSubmit
                // 
                this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
                this.btnSubmit.Location = new System.Drawing.Point(22, 250);
                this.btnSubmit.Name = "btnSubmit";
                this.btnSubmit.Size = new System.Drawing.Size(140, 40);
                this.btnSubmit.Text = "Save & Submit";
                this.btnSubmit.UseVisualStyleBackColor = true;
                this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
                // 
                // btnDeleteDraft
                // 
                this.btnDeleteDraft.Font = new System.Drawing.Font("Segoe UI", 9F);
                this.btnDeleteDraft.Location = new System.Drawing.Point(175, 250);
                this.btnDeleteDraft.Name = "btnDeleteDraft";
                this.btnDeleteDraft.Size = new System.Drawing.Size(140, 40);
                this.btnDeleteDraft.Text = "Retract Submission";
                this.btnDeleteDraft.UseVisualStyleBackColor = true;
                this.btnDeleteDraft.Click += new System.EventHandler(this.btnDeleteDraft_Click);
                // 
                // btnCancel
                // 
                this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
                this.btnCancel.Location = new System.Drawing.Point(322, 250);
                this.btnCancel.Name = "btnCancel";
                this.btnCancel.Size = new System.Drawing.Size(140, 40);
                this.btnCancel.Text = "Close Windows";
                this.btnCancel.UseVisualStyleBackColor = true;
                this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
                // 
                // MyApplicationForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
                this.ClientSize = new System.Drawing.Size(489, 317);
                this.Controls.Add(this.btnCancel);
                this.Controls.Add(this.btnDeleteDraft);
                this.Controls.Add(this.btnSubmit);
                this.Controls.Add(this.lblLockNotice);
                this.Controls.Add(this.lblStatusText);
                this.Controls.Add(this.cboVacancies);
                this.Controls.Add(this.lblJobSelect);
                this.Controls.Add(this.lblTitle);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "MyApplicationForm";
                this.Text = "Job Application Portal";
                this.Load += new System.EventHandler(this.MyApplicationForm_Load);
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            #endregion

            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblJobSelect;
            private System.Windows.Forms.ComboBox cboVacancies;
            private System.Windows.Forms.Label lblStatusText;
            private System.Windows.Forms.Label lblLockNotice;
            private System.Windows.Forms.Button btnSubmit;
            private System.Windows.Forms.Button btnDeleteDraft;
            private System.Windows.Forms.Button btnCancel;
        }
    }