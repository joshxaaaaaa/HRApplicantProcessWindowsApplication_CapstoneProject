namespace HRApplicantWindowSystem.Applicant
{
    partial class ChangePasswordForm
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
            txtCurrent = new TextBox();
            txtNew = new TextBox();
            txtConfirm = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtCurrent
            // 
            txtCurrent.Location = new Point(83, 206);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(277, 27);
            txtCurrent.TabIndex = 0;
            // 
            // txtNew
            // 
            txtNew.Location = new Point(83, 288);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(277, 27);
            txtNew.TabIndex = 1;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(83, 368);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(277, 27);
            txtConfirm.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(83, 430);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 53);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 53);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 183);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 5;
            label1.Text = "Current Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 265);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 6;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 345);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 605);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtConfirm);
            Controls.Add(txtNew);
            Controls.Add(txtCurrent);
            Name = "ChangePasswordForm";
            Text = "Change Paassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCurrent;
        private TextBox txtNew;
        private TextBox txtConfirm;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}