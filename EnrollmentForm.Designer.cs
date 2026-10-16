namespace Student_Management_System
{
    partial class EnrollmentForm
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
            this.labelStudent = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.buttonEnroll = new System.Windows.Forms.Button();
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
            this.labelHeaderTitle.Size = new System.Drawing.Size(139, 25);
            this.labelHeaderTitle.TabIndex = 0;
            this.labelHeaderTitle.Text = "Enroll Student";
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelStudent.ForeColor = System.Drawing.Color.Black;
            this.labelStudent.Location = new System.Drawing.Point(35, 65);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(52, 17);
            this.labelStudent.TabIndex = 1;
            this.labelStudent.Text = "Student";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStudentName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxStudentName.Location = new System.Drawing.Point(35, 88);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.ReadOnly = true;
            this.textBoxStudentName.Size = new System.Drawing.Size(335, 25);
            this.textBoxStudentName.TabIndex = 2;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelCourse.ForeColor = System.Drawing.Color.Black;
            this.labelCourse.Location = new System.Drawing.Point(35, 130);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(49, 17);
            this.labelCourse.TabIndex = 3;
            this.labelCourse.Text = "Course";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(35, 153);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(335, 25);
            this.comboBoxCourse.TabIndex = 4;
            // 
            // buttonEnroll
            // 
            this.buttonEnroll.BackColor = System.Drawing.Color.White;
            this.buttonEnroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(230)))));
            this.buttonEnroll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonEnroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnroll.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonEnroll.ForeColor = System.Drawing.Color.Black;
            this.buttonEnroll.Location = new System.Drawing.Point(170, 205);
            this.buttonEnroll.Name = "buttonEnroll";
            this.buttonEnroll.Size = new System.Drawing.Size(95, 34);
            this.buttonEnroll.TabIndex = 5;
            this.buttonEnroll.Text = "Enroll";
            this.buttonEnroll.UseVisualStyleBackColor = false;
            this.buttonEnroll.Click += new System.EventHandler(this.buttonEnroll_Click);
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
            this.buttonCancel.Location = new System.Drawing.Point(275, 205);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 265);
            this.Controls.Add(this.labelHeaderTitle);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.buttonEnroll);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnrollmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enroll Student";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelHeaderTitle;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Button buttonEnroll;
        private System.Windows.Forms.Button buttonCancel;
    }
}
