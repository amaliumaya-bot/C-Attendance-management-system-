namespace Student_Management_System
{
    partial class GradeEditorForm
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
            this.labelExamMarks = new System.Windows.Forms.Label();
            this.textBoxExamMarks = new System.Windows.Forms.TextBox();
            this.labelCourseworkMarks = new System.Windows.Forms.Label();
            this.textBoxCourseworkMarks = new System.Windows.Forms.TextBox();
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
            this.labelHeaderTitle.Text = "Add New Grade";
            // 
            // labelEnrollment
            // 
            this.labelEnrollment.AutoSize = true;
            this.labelEnrollment.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelEnrollment.ForeColor = System.Drawing.Color.Black;
            this.labelEnrollment.Location = new System.Drawing.Point(35, 60);
            this.labelEnrollment.Name = "labelEnrollment";
            this.labelEnrollment.Size = new System.Drawing.Size(70, 17);
            this.labelEnrollment.TabIndex = 1;
            this.labelEnrollment.Text = "Enrollment";
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
            // labelExamMarks
            // 
            this.labelExamMarks.AutoSize = true;
            this.labelExamMarks.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelExamMarks.ForeColor = System.Drawing.Color.Black;
            this.labelExamMarks.Location = new System.Drawing.Point(35, 120);
            this.labelExamMarks.Name = "labelExamMarks";
            this.labelExamMarks.Size = new System.Drawing.Size(78, 17);
            this.labelExamMarks.TabIndex = 3;
            this.labelExamMarks.Text = "Exam Marks";
            // 
            // textBoxExamMarks
            // 
            this.textBoxExamMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExamMarks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxExamMarks.Location = new System.Drawing.Point(35, 143);
            this.textBoxExamMarks.Name = "textBoxExamMarks";
            this.textBoxExamMarks.Size = new System.Drawing.Size(335, 25);
            this.textBoxExamMarks.TabIndex = 4;
            // 
            // labelCourseworkMarks
            // 
            this.labelCourseworkMarks.AutoSize = true;
            this.labelCourseworkMarks.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelCourseworkMarks.ForeColor = System.Drawing.Color.Black;
            this.labelCourseworkMarks.Location = new System.Drawing.Point(35, 180);
            this.labelCourseworkMarks.Name = "labelCourseworkMarks";
            this.labelCourseworkMarks.Size = new System.Drawing.Size(115, 17);
            this.labelCourseworkMarks.TabIndex = 5;
            this.labelCourseworkMarks.Text = "Coursework Marks";
            // 
            // textBoxCourseworkMarks
            // 
            this.textBoxCourseworkMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCourseworkMarks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxCourseworkMarks.Location = new System.Drawing.Point(35, 203);
            this.textBoxCourseworkMarks.Name = "textBoxCourseworkMarks";
            this.textBoxCourseworkMarks.Size = new System.Drawing.Size(335, 25);
            this.textBoxCourseworkMarks.TabIndex = 6;
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
            // GradeEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 310);
            this.Controls.Add(this.labelHeaderTitle);
            this.Controls.Add(this.labelEnrollment);
            this.Controls.Add(this.comboBoxEnrollment);
            this.Controls.Add(this.labelExamMarks);
            this.Controls.Add(this.textBoxExamMarks);
            this.Controls.Add(this.labelCourseworkMarks);
            this.Controls.Add(this.textBoxCourseworkMarks);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GradeEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grade Details";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelHeaderTitle;
        private System.Windows.Forms.Label labelEnrollment;
        private System.Windows.Forms.ComboBox comboBoxEnrollment;
        private System.Windows.Forms.Label labelExamMarks;
        private System.Windows.Forms.TextBox textBoxExamMarks;
        private System.Windows.Forms.Label labelCourseworkMarks;
        private System.Windows.Forms.TextBox textBoxCourseworkMarks;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
