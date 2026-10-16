namespace Student_Management_System
{
    partial class AttendanceEditorForm
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
            this.labelHeaderTitle = new System.Windows.Forms.Label();
            this.labelEnrollment = new System.Windows.Forms.Label();
            this.comboBoxEnrollment = new System.Windows.Forms.ComboBox();
            this.labelDateRecorded = new System.Windows.Forms.Label();
            this.dateTimePickerDateRecorded = new System.Windows.Forms.DateTimePicker();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeaderTitle
            // 
            this.labelHeaderTitle.AutoSize = true;
            this.labelHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.labelHeaderTitle.Location = new System.Drawing.Point(35, 20);
            this.labelHeaderTitle.Name = "labelHeaderTitle";
            this.labelHeaderTitle.Size = new System.Drawing.Size(155, 25);
            this.labelHeaderTitle.TabIndex = 0;
            this.labelHeaderTitle.Text = "Add Attendance";
            // 
            // labelEnrollment
            // 
            this.labelEnrollment.AutoSize = true;
            this.labelEnrollment.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelEnrollment.ForeColor = System.Drawing.Color.Black;
            this.labelEnrollment.Location = new System.Drawing.Point(35, 60);
            this.labelEnrollment.Name = "labelEnrollment";
            this.labelEnrollment.Size = new System.Drawing.Size(73, 17);
            this.labelEnrollment.TabIndex = 1;
            this.labelEnrollment.Text = "Enrollment:";
            // 
            // comboBoxEnrollment
            // 
            this.comboBoxEnrollment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnrollment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEnrollment.FormattingEnabled = true;
            this.comboBoxEnrollment.Location = new System.Drawing.Point(35, 83);
            this.comboBoxEnrollment.Name = "comboBoxEnrollment";
            this.comboBoxEnrollment.Size = new System.Drawing.Size(335, 25);
            this.comboBoxEnrollment.TabIndex = 2;
            // 
            // labelDateRecorded
            // 
            this.labelDateRecorded.AutoSize = true;
            this.labelDateRecorded.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelDateRecorded.ForeColor = System.Drawing.Color.Black;
            this.labelDateRecorded.Location = new System.Drawing.Point(35, 120);
            this.labelDateRecorded.Name = "labelDateRecorded";
            this.labelDateRecorded.Size = new System.Drawing.Size(38, 17);
            this.labelDateRecorded.TabIndex = 3;
            this.labelDateRecorded.Text = "Date:";
            // 
            // dateTimePickerDateRecorded
            // 
            this.dateTimePickerDateRecorded.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDateRecorded.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePickerDateRecorded.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateRecorded.Location = new System.Drawing.Point(35, 143);
            this.dateTimePickerDateRecorded.Name = "dateTimePickerDateRecorded";
            this.dateTimePickerDateRecorded.Size = new System.Drawing.Size(335, 25);
            this.dateTimePickerDateRecorded.TabIndex = 4;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelStatus.ForeColor = System.Drawing.Color.Black;
            this.labelStatus.Location = new System.Drawing.Point(35, 180);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(46, 17);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(35, 203);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(335, 25);
            this.comboBoxStatus.TabIndex = 6;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(230)))));
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(170, 250);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 34);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(275, 250);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 34);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AttendanceEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 310);
            this.Controls.Add(this.labelHeaderTitle);
            this.Controls.Add(this.labelEnrollment);
            this.Controls.Add(this.comboBoxEnrollment);
            this.Controls.Add(this.labelDateRecorded);
            this.Controls.Add(this.dateTimePickerDateRecorded);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttendanceEditorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attendance Details";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelHeaderTitle;
        private System.Windows.Forms.Label labelEnrollment;
        private System.Windows.Forms.ComboBox comboBoxEnrollment;
        private System.Windows.Forms.Label labelDateRecorded;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRecorded;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
