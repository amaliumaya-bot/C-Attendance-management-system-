namespace Student_Management_System
{
    partial class AttendanceForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelBrand = new System.Windows.Forms.Label();
            this.buttonNavDashboard = new System.Windows.Forms.Button();
            this.buttonNavStudents = new System.Windows.Forms.Button();
            this.buttonNavCourses = new System.Windows.Forms.Button();
            this.buttonNavGrades = new System.Windows.Forms.Button();
            this.buttonNavAttendance = new System.Windows.Forms.Button();
            this.buttonNavReports = new System.Windows.Forms.Button();
            this.buttonNavLogout = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelSectionTitle = new System.Windows.Forms.Label();
            this.listBoxAttendance = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(240)))));
            this.panelSidebar.Controls.Add(this.labelBrand);
            this.panelSidebar.Controls.Add(this.buttonNavDashboard);
            this.panelSidebar.Controls.Add(this.buttonNavStudents);
            this.panelSidebar.Controls.Add(this.buttonNavCourses);
            this.panelSidebar.Controls.Add(this.buttonNavGrades);
            this.panelSidebar.Controls.Add(this.buttonNavAttendance);
            this.panelSidebar.Controls.Add(this.buttonNavReports);
            this.panelSidebar.Controls.Add(this.buttonNavLogout);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 650);
            this.panelSidebar.TabIndex = 0;
            // 
            // labelBrand
            // 
            this.labelBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.ForeColor = System.Drawing.Color.Black;
            this.labelBrand.Location = new System.Drawing.Point(16, 22);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(168, 48);
            this.labelBrand.TabIndex = 0;
            this.labelBrand.Text = "Student Management\r\nSystem";
            // 
            // buttonNavDashboard
            // 
            this.buttonNavDashboard.BackColor = System.Drawing.Color.White;
            this.buttonNavDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(195)))), ((int)(((byte)(225)))));
            this.buttonNavDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNavDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavDashboard.ForeColor = System.Drawing.Color.Black;
            this.buttonNavDashboard.Location = new System.Drawing.Point(18, 105);
            this.buttonNavDashboard.Name = "buttonNavDashboard";
            this.buttonNavDashboard.Size = new System.Drawing.Size(164, 38);
            this.buttonNavDashboard.TabIndex = 1;
            this.buttonNavDashboard.Text = "Dashboard";
            this.buttonNavDashboard.UseVisualStyleBackColor = false;
            this.buttonNavDashboard.Click += new System.EventHandler(this.buttonNavDashboard_Click);
            // 
            // buttonNavStudents
            // 
            this.buttonNavStudents.BackColor = System.Drawing.Color.White;
            this.buttonNavStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(195)))), ((int)(((byte)(225)))));
            this.buttonNavStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNavStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonNavStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavStudents.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavStudents.ForeColor = System.Drawing.Color.Black;
            this.buttonNavStudents.Location = new System.Drawing.Point(18, 155);
            this.buttonNavStudents.Name = "buttonNavStudents";
            this.buttonNavStudents.Size = new System.Drawing.Size(164, 38);
            this.buttonNavStudents.TabIndex = 2;
            this.buttonNavStudents.Text = "Students";
            this.buttonNavStudents.UseVisualStyleBackColor = false;
            this.buttonNavStudents.Click += new System.EventHandler(this.buttonNavStudents_Click);
            // 
            // buttonNavCourses
            // 
            this.buttonNavCourses.BackColor = System.Drawing.Color.White;
            this.buttonNavCourses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(195)))), ((int)(((byte)(225)))));
            this.buttonNavCourses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNavCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonNavCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavCourses.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavCourses.ForeColor = System.Drawing.Color.Black;
            this.buttonNavCourses.Location = new System.Drawing.Point(18, 205);
            this.buttonNavCourses.Name = "buttonNavCourses";
            this.buttonNavCourses.Size = new System.Drawing.Size(164, 38);
            this.buttonNavCourses.TabIndex = 3;
            this.buttonNavCourses.Text = "Courses";
            this.buttonNavCourses.UseVisualStyleBackColor = false;
            this.buttonNavCourses.Click += new System.EventHandler(this.buttonNavCourses_Click);
            // 
            // buttonNavGrades
            // 
            this.buttonNavGrades.BackColor = System.Drawing.Color.White;
            this.buttonNavGrades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(195)))), ((int)(((byte)(225)))));
            this.buttonNavGrades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNavGrades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonNavGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavGrades.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavGrades.ForeColor = System.Drawing.Color.Black;
            this.buttonNavGrades.Location = new System.Drawing.Point(18, 255);
            this.buttonNavGrades.Name = "buttonNavGrades";
            this.buttonNavGrades.Size = new System.Drawing.Size(164, 38);
            this.buttonNavGrades.TabIndex = 4;
            this.buttonNavGrades.Text = "Grades";
            this.buttonNavGrades.UseVisualStyleBackColor = false;
            this.buttonNavGrades.Click += new System.EventHandler(this.buttonNavGrades_Click);
            // 
            // buttonNavAttendance
            // 
            this.buttonNavAttendance.BackColor = System.Drawing.Color.White;
            this.buttonNavAttendance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(195)))), ((int)(((byte)(225)))));
            this.buttonNavAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNavAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonNavAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavAttendance.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavAttendance.ForeColor = System.Drawing.Color.Black;
            this.buttonNavAttendance.Location = new System.Drawing.Point(18, 305);
            this.buttonNavAttendance.Name = "buttonNavAttendance";
            this.buttonNavAttendance.Size = new System.Drawing.Size(164, 38);
            this.buttonNavAttendance.TabIndex = 5;
            this.buttonNavAttendance.Text = "Attendance";
            this.buttonNavAttendance.UseVisualStyleBackColor = false;
            // 
            // buttonNavReports
            // 
            this.buttonNavReports.BackColor = System.Drawing.Color.White;
            this.buttonNavReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(195)))), ((int)(((byte)(225)))));
            this.buttonNavReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNavReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavReports.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavReports.ForeColor = System.Drawing.Color.Black;
            this.buttonNavReports.Location = new System.Drawing.Point(18, 355);
            this.buttonNavReports.Name = "buttonNavReports";
            this.buttonNavReports.Size = new System.Drawing.Size(164, 38);
            this.buttonNavReports.TabIndex = 6;
            this.buttonNavReports.Text = "Reports";
            this.buttonNavReports.UseVisualStyleBackColor = false;
            this.buttonNavReports.Click += new System.EventHandler(this.buttonNavReports_Click);
            // 
            // buttonNavLogout
            // 
            this.buttonNavLogout.BackColor = System.Drawing.Color.White;
            this.buttonNavLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(195)))), ((int)(((byte)(225)))));
            this.buttonNavLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonNavLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonNavLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonNavLogout.Location = new System.Drawing.Point(18, 575);
            this.buttonNavLogout.Name = "buttonNavLogout";
            this.buttonNavLogout.Size = new System.Drawing.Size(164, 38);
            this.buttonNavLogout.TabIndex = 7;
            this.buttonNavLogout.Text = "Logout";
            this.buttonNavLogout.UseVisualStyleBackColor = false;
            this.buttonNavLogout.Click += new System.EventHandler(this.buttonNavLogout_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.labelTitle.Location = new System.Drawing.Point(235, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(145, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Attendance";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.Black;
            this.labelSubtitle.Location = new System.Drawing.Point(237, 65);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(217, 17);
            this.labelSubtitle.TabIndex = 2;
            this.labelSubtitle.Text = "Manage student attendance records";
            // 
            // labelSectionTitle
            // 
            this.labelSectionTitle.AutoSize = true;
            this.labelSectionTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionTitle.ForeColor = System.Drawing.Color.Black;
            this.labelSectionTitle.Location = new System.Drawing.Point(235, 95);
            this.labelSectionTitle.Name = "labelSectionTitle";
            this.labelSectionTitle.Size = new System.Drawing.Size(148, 19);
            this.labelSectionTitle.TabIndex = 3;
            this.labelSectionTitle.Text = "Attendance Records:";
            // 
            // listBoxAttendance
            // 
            this.listBoxAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxAttendance.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAttendance.FormattingEnabled = true;
            this.listBoxAttendance.ItemHeight = 17;
            this.listBoxAttendance.Location = new System.Drawing.Point(235, 120);
            this.listBoxAttendance.Name = "listBoxAttendance";
            this.listBoxAttendance.Size = new System.Drawing.Size(700, 490);
            this.listBoxAttendance.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(230)))));
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(955, 120);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(165, 40);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add Attendance";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(230)))));
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(955, 175);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(165, 40);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit Attendance";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(230)))));
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(955, 230);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(165, 40);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete Attendance";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelSectionTitle);
            this.Controls.Add(this.listBoxAttendance);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Button buttonNavDashboard;
        private System.Windows.Forms.Button buttonNavStudents;
        private System.Windows.Forms.Button buttonNavCourses;
        private System.Windows.Forms.Button buttonNavGrades;
        private System.Windows.Forms.Button buttonNavAttendance;
        private System.Windows.Forms.Button buttonNavReports;
        private System.Windows.Forms.Button buttonNavLogout;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelSectionTitle;
        private System.Windows.Forms.ListBox listBoxAttendance;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}
