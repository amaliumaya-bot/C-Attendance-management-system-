namespace Student_Management_System
{
    partial class CourseEditorForm
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
            this.labelCourseTitle = new System.Windows.Forms.Label();
            this.textBoxCourseTitle = new System.Windows.Forms.TextBox();
            this.labelCredits = new System.Windows.Forms.Label();
            this.numericUpDownCredits = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeaderTitle
            // 
            this.labelHeaderTitle.AutoSize = true;
            this.labelHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.labelHeaderTitle.Location = new System.Drawing.Point(35, 20);
            this.labelHeaderTitle.Name = "labelHeaderTitle";
            this.labelHeaderTitle.Size = new System.Drawing.Size(161, 25);
            this.labelHeaderTitle.TabIndex = 0;
            this.labelHeaderTitle.Text = "Add New Course";
            // 
            // labelCourseTitle
            // 
            this.labelCourseTitle.AutoSize = true;
            this.labelCourseTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelCourseTitle.ForeColor = System.Drawing.Color.Black;
            this.labelCourseTitle.Location = new System.Drawing.Point(35, 65);
            this.labelCourseTitle.Name = "labelCourseTitle";
            this.labelCourseTitle.Size = new System.Drawing.Size(76, 17);
            this.labelCourseTitle.TabIndex = 1;
            this.labelCourseTitle.Text = "Course Title";
            // 
            // textBoxCourseTitle
            // 
            this.textBoxCourseTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCourseTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxCourseTitle.Location = new System.Drawing.Point(35, 88);
            this.textBoxCourseTitle.Name = "textBoxCourseTitle";
            this.textBoxCourseTitle.Size = new System.Drawing.Size(335, 25);
            this.textBoxCourseTitle.TabIndex = 2;
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.labelCredits.ForeColor = System.Drawing.Color.Black;
            this.labelCredits.Location = new System.Drawing.Point(35, 130);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(49, 17);
            this.labelCredits.TabIndex = 3;
            this.labelCredits.Text = "Credits";
            // 
            // numericUpDownCredits
            // 
            this.numericUpDownCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownCredits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericUpDownCredits.Location = new System.Drawing.Point(35, 153);
            this.numericUpDownCredits.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownCredits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCredits.Name = "numericUpDownCredits";
            this.numericUpDownCredits.Size = new System.Drawing.Size(335, 25);
            this.numericUpDownCredits.TabIndex = 4;
            this.numericUpDownCredits.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
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
            this.buttonSave.Location = new System.Drawing.Point(170, 205);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 34);
            this.buttonSave.TabIndex = 5;
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
            this.buttonCancel.Location = new System.Drawing.Point(275, 205);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CourseEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 265);
            this.Controls.Add(this.labelHeaderTitle);
            this.Controls.Add(this.labelCourseTitle);
            this.Controls.Add(this.textBoxCourseTitle);
            this.Controls.Add(this.labelCredits);
            this.Controls.Add(this.numericUpDownCredits);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Course Details";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelHeaderTitle;
        private System.Windows.Forms.Label labelCourseTitle;
        private System.Windows.Forms.TextBox textBoxCourseTitle;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.NumericUpDown numericUpDownCredits;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
