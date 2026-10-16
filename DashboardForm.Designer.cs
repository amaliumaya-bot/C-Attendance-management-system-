namespace Student_Management_System
{
    partial class DashboardForm
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
            this.panelCardStudents = new System.Windows.Forms.Panel();
            this.labelCardStudentsTitle = new System.Windows.Forms.Label();
            this.labelCardStudentsSub = new System.Windows.Forms.Label();
            this.labelCardStudentsCount = new System.Windows.Forms.Label();
            this.panelCardCourses = new System.Windows.Forms.Panel();
            this.labelCardCoursesTitle = new System.Windows.Forms.Label();
            this.labelCardCoursesSub = new System.Windows.Forms.Label();
            this.labelCardCoursesCount = new System.Windows.Forms.Label();
            this.panelCardGrades = new System.Windows.Forms.Panel();
            this.labelCardGradesTitle = new System.Windows.Forms.Label();
            this.labelCardGradesSub = new System.Windows.Forms.Label();
            this.labelCardGradesCount = new System.Windows.Forms.Label();
            this.panelCardPerf = new System.Windows.Forms.Panel();
            this.labelCardPerfTitle = new System.Windows.Forms.Label();
            this.labelCardPerfSub = new System.Windows.Forms.Label();
            this.labelCardPerfCount = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelCardStudents.SuspendLayout();
            this.panelCardCourses.SuspendLayout();
            this.panelCardGrades.SuspendLayout();
            this.panelCardPerf.SuspendLayout();
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
            this.labelBrand.Location = new System.Drawing.Point(18, 25);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(164, 48);
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
            this.buttonNavAttendance.Click += new System.EventHandler(this.buttonNavAttendance_Click);
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
            this.labelTitle.Size = new System.Drawing.Size(125, 30);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Dashboard";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.Black;
            this.labelSubtitle.Location = new System.Drawing.Point(237, 65);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(252, 17);
            this.labelSubtitle.TabIndex = 2;
            this.labelSubtitle.Text = "Welcome to the Student Management System";
            // 
            // panelCardStudents
            // 
            this.panelCardStudents.BackColor = System.Drawing.Color.White;
            this.panelCardStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardStudents.Controls.Add(this.labelCardStudentsTitle);
            this.panelCardStudents.Controls.Add(this.labelCardStudentsSub);
            this.panelCardStudents.Controls.Add(this.labelCardStudentsCount);
            this.panelCardStudents.Location = new System.Drawing.Point(235, 110);
            this.panelCardStudents.Name = "panelCardStudents";
            this.panelCardStudents.Size = new System.Drawing.Size(205, 135);
            this.panelCardStudents.TabIndex = 3;
            // 
            // labelCardStudentsTitle
            // 
            this.labelCardStudentsTitle.AutoSize = true;
            this.labelCardStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardStudentsTitle.ForeColor = System.Drawing.Color.Black;
            this.labelCardStudentsTitle.Location = new System.Drawing.Point(16, 16);
            this.labelCardStudentsTitle.Name = "labelCardStudentsTitle";
            this.labelCardStudentsTitle.Size = new System.Drawing.Size(71, 20);
            this.labelCardStudentsTitle.TabIndex = 0;
            this.labelCardStudentsTitle.Text = "Students";
            // 
            // labelCardStudentsSub
            // 
            this.labelCardStudentsSub.AutoSize = true;
            this.labelCardStudentsSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardStudentsSub.ForeColor = System.Drawing.Color.Black;
            this.labelCardStudentsSub.Location = new System.Drawing.Point(16, 42);
            this.labelCardStudentsSub.Name = "labelCardStudentsSub";
            this.labelCardStudentsSub.Size = new System.Drawing.Size(82, 15);
            this.labelCardStudentsSub.TabIndex = 1;
            this.labelCardStudentsSub.Text = "Active Records";
            // 
            // labelCardStudentsCount
            // 
            this.labelCardStudentsCount.AutoSize = true;
            this.labelCardStudentsCount.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardStudentsCount.ForeColor = System.Drawing.Color.Black;
            this.labelCardStudentsCount.Location = new System.Drawing.Point(14, 68);
            this.labelCardStudentsCount.Name = "labelCardStudentsCount";
            this.labelCardStudentsCount.Size = new System.Drawing.Size(74, 47);
            this.labelCardStudentsCount.TabIndex = 2;
            this.labelCardStudentsCount.Text = "120";
            // 
            // panelCardCourses
            // 
            this.panelCardCourses.BackColor = System.Drawing.Color.White;
            this.panelCardCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardCourses.Controls.Add(this.labelCardCoursesTitle);
            this.panelCardCourses.Controls.Add(this.labelCardCoursesSub);
            this.panelCardCourses.Controls.Add(this.labelCardCoursesCount);
            this.panelCardCourses.Location = new System.Drawing.Point(460, 110);
            this.panelCardCourses.Name = "panelCardCourses";
            this.panelCardCourses.Size = new System.Drawing.Size(205, 135);
            this.panelCardCourses.TabIndex = 4;
            // 
            // labelCardCoursesTitle
            // 
            this.labelCardCoursesTitle.AutoSize = true;
            this.labelCardCoursesTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardCoursesTitle.ForeColor = System.Drawing.Color.Black;
            this.labelCardCoursesTitle.Location = new System.Drawing.Point(16, 16);
            this.labelCardCoursesTitle.Name = "labelCardCoursesTitle";
            this.labelCardCoursesTitle.Size = new System.Drawing.Size(64, 20);
            this.labelCardCoursesTitle.TabIndex = 0;
            this.labelCardCoursesTitle.Text = "Courses";
            // 
            // labelCardCoursesSub
            // 
            this.labelCardCoursesSub.AutoSize = true;
            this.labelCardCoursesSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardCoursesSub.ForeColor = System.Drawing.Color.Black;
            this.labelCardCoursesSub.Location = new System.Drawing.Point(16, 42);
            this.labelCardCoursesSub.Name = "labelCardCoursesSub";
            this.labelCardCoursesSub.Size = new System.Drawing.Size(101, 15);
            this.labelCardCoursesSub.TabIndex = 1;
            this.labelCardCoursesSub.Text = "Available Courses";
            // 
            // labelCardCoursesCount
            // 
            this.labelCardCoursesCount.AutoSize = true;
            this.labelCardCoursesCount.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardCoursesCount.ForeColor = System.Drawing.Color.Black;
            this.labelCardCoursesCount.Location = new System.Drawing.Point(14, 68);
            this.labelCardCoursesCount.Name = "labelCardCoursesCount";
            this.labelCardCoursesCount.Size = new System.Drawing.Size(58, 47);
            this.labelCardCoursesCount.TabIndex = 2;
            this.labelCardCoursesCount.Text = "18";
            // 
            // panelCardGrades
            // 
            this.panelCardGrades.BackColor = System.Drawing.Color.White;
            this.panelCardGrades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardGrades.Controls.Add(this.labelCardGradesTitle);
            this.panelCardGrades.Controls.Add(this.labelCardGradesSub);
            this.panelCardGrades.Controls.Add(this.labelCardGradesCount);
            this.panelCardGrades.Location = new System.Drawing.Point(685, 110);
            this.panelCardGrades.Name = "panelCardGrades";
            this.panelCardGrades.Size = new System.Drawing.Size(205, 135);
            this.panelCardGrades.TabIndex = 5;
            // 
            // labelCardGradesTitle
            // 
            this.labelCardGradesTitle.AutoSize = true;
            this.labelCardGradesTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardGradesTitle.ForeColor = System.Drawing.Color.Black;
            this.labelCardGradesTitle.Location = new System.Drawing.Point(16, 16);
            this.labelCardGradesTitle.Name = "labelCardGradesTitle";
            this.labelCardGradesTitle.Size = new System.Drawing.Size(58, 20);
            this.labelCardGradesTitle.TabIndex = 0;
            this.labelCardGradesTitle.Text = "Grades";
            // 
            // labelCardGradesSub
            // 
            this.labelCardGradesSub.AutoSize = true;
            this.labelCardGradesSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardGradesSub.ForeColor = System.Drawing.Color.Black;
            this.labelCardGradesSub.Location = new System.Drawing.Point(16, 42);
            this.labelCardGradesSub.Name = "labelCardGradesSub";
            this.labelCardGradesSub.Size = new System.Drawing.Size(98, 15);
            this.labelCardGradesSub.TabIndex = 1;
            this.labelCardGradesSub.Text = "Recorded Results";
            // 
            // labelCardGradesCount
            // 
            this.labelCardGradesCount.AutoSize = true;
            this.labelCardGradesCount.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardGradesCount.ForeColor = System.Drawing.Color.Black;
            this.labelCardGradesCount.Location = new System.Drawing.Point(14, 68);
            this.labelCardGradesCount.Name = "labelCardGradesCount";
            this.labelCardGradesCount.Size = new System.Drawing.Size(74, 47);
            this.labelCardGradesCount.TabIndex = 2;
            this.labelCardGradesCount.Text = "342";
            // 
            // panelCardPerf
            // 
            this.panelCardPerf.BackColor = System.Drawing.Color.White;
            this.panelCardPerf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardPerf.Controls.Add(this.labelCardPerfTitle);
            this.panelCardPerf.Controls.Add(this.labelCardPerfSub);
            this.panelCardPerf.Controls.Add(this.labelCardPerfCount);
            this.panelCardPerf.Location = new System.Drawing.Point(910, 110);
            this.panelCardPerf.Name = "panelCardPerf";
            this.panelCardPerf.Size = new System.Drawing.Size(205, 135);
            this.panelCardPerf.TabIndex = 6;
            // 
            // labelCardPerfTitle
            // 
            this.labelCardPerfTitle.AutoSize = true;
            this.labelCardPerfTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardPerfTitle.ForeColor = System.Drawing.Color.Black;
            this.labelCardPerfTitle.Location = new System.Drawing.Point(16, 16);
            this.labelCardPerfTitle.Name = "labelCardPerfTitle";
            this.labelCardPerfTitle.Size = new System.Drawing.Size(100, 20);
            this.labelCardPerfTitle.TabIndex = 0;
            this.labelCardPerfTitle.Text = "Performance";
            // 
            // labelCardPerfSub
            // 
            this.labelCardPerfSub.AutoSize = true;
            this.labelCardPerfSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardPerfSub.ForeColor = System.Drawing.Color.Black;
            this.labelCardPerfSub.Location = new System.Drawing.Point(16, 42);
            this.labelCardPerfSub.Name = "labelCardPerfSub";
            this.labelCardPerfSub.Size = new System.Drawing.Size(92, 15);
            this.labelCardPerfSub.TabIndex = 1;
            this.labelCardPerfSub.Text = "Current average";
            // 
            // labelCardPerfCount
            // 
            this.labelCardPerfCount.AutoSize = true;
            this.labelCardPerfCount.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardPerfCount.ForeColor = System.Drawing.Color.Black;
            this.labelCardPerfCount.Location = new System.Drawing.Point(14, 68);
            this.labelCardPerfCount.Name = "labelCardPerfCount";
            this.labelCardPerfCount.Size = new System.Drawing.Size(83, 47);
            this.labelCardPerfCount.TabIndex = 2;
            this.labelCardPerfCount.Text = "94%";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.panelCardStudents);
            this.Controls.Add(this.panelCardCourses);
            this.Controls.Add(this.panelCardGrades);
            this.Controls.Add(this.panelCardPerf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelSidebar.ResumeLayout(false);
            this.panelCardStudents.ResumeLayout(false);
            this.panelCardStudents.PerformLayout();
            this.panelCardCourses.ResumeLayout(false);
            this.panelCardCourses.PerformLayout();
            this.panelCardGrades.ResumeLayout(false);
            this.panelCardGrades.PerformLayout();
            this.panelCardPerf.ResumeLayout(false);
            this.panelCardPerf.PerformLayout();
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
        private System.Windows.Forms.Panel panelCardStudents;
        private System.Windows.Forms.Label labelCardStudentsTitle;
        private System.Windows.Forms.Label labelCardStudentsSub;
        private System.Windows.Forms.Label labelCardStudentsCount;
        private System.Windows.Forms.Panel panelCardCourses;
        private System.Windows.Forms.Label labelCardCoursesTitle;
        private System.Windows.Forms.Label labelCardCoursesSub;
        private System.Windows.Forms.Label labelCardCoursesCount;
        private System.Windows.Forms.Panel panelCardGrades;
        private System.Windows.Forms.Label labelCardGradesTitle;
        private System.Windows.Forms.Label labelCardGradesSub;
        private System.Windows.Forms.Label labelCardGradesCount;
        private System.Windows.Forms.Panel panelCardPerf;
        private System.Windows.Forms.Label labelCardPerfTitle;
        private System.Windows.Forms.Label labelCardPerfSub;
        private System.Windows.Forms.Label labelCardPerfCount;
    }
}
