namespace Student_Management_System
{
    partial class ReportsForm
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

            this.panelTotalStudents = new System.Windows.Forms.Panel();
            this.lblTitleStudents = new System.Windows.Forms.Label();
            this.lblValueStudents = new System.Windows.Forms.Label();

            this.panelTotalCourses = new System.Windows.Forms.Panel();
            this.lblTitleCourses = new System.Windows.Forms.Label();
            this.lblValueCourses = new System.Windows.Forms.Label();

            this.panelTotalEnrollments = new System.Windows.Forms.Panel();
            this.lblTitleEnrollments = new System.Windows.Forms.Label();
            this.lblValueEnrollments = new System.Windows.Forms.Label();

            this.panelTotalGrades = new System.Windows.Forms.Panel();
            this.lblTitleGrades = new System.Windows.Forms.Label();
            this.lblValueGrades = new System.Windows.Forms.Label();

            this.panelAvgExam = new System.Windows.Forms.Panel();
            this.lblTitleAvgExam = new System.Windows.Forms.Label();
            this.lblValueAvgExam = new System.Windows.Forms.Label();

            this.panelAvgCoursework = new System.Windows.Forms.Panel();
            this.lblTitleAvgCW = new System.Windows.Forms.Label();
            this.lblValueAvgCW = new System.Windows.Forms.Label();

            this.panelAttendanceRecords = new System.Windows.Forms.Panel();
            this.lblTitleAttendance = new System.Windows.Forms.Label();
            this.lblValueAttendance = new System.Windows.Forms.Label();

            this.panelAttendanceRate = new System.Windows.Forms.Panel();
            this.lblTitleAttRate = new System.Windows.Forms.Label();
            this.lblValueAttRate = new System.Windows.Forms.Label();

            this.panelSidebar.SuspendLayout();
            this.panelTotalStudents.SuspendLayout();
            this.panelTotalCourses.SuspendLayout();
            this.panelTotalEnrollments.SuspendLayout();
            this.panelTotalGrades.SuspendLayout();
            this.panelAvgExam.SuspendLayout();
            this.panelAvgCoursework.SuspendLayout();
            this.panelAttendanceRecords.SuspendLayout();
            this.panelAttendanceRate.SuspendLayout();
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
            this.buttonNavDashboard.Location = new System.Drawing.Point(18, 110);
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
            this.buttonNavCourses.Location = new System.Drawing.Point(18, 200);
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
            this.buttonNavGrades.Location = new System.Drawing.Point(18, 245);
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
            this.buttonNavAttendance.Location = new System.Drawing.Point(18, 290);
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
            this.buttonNavReports.Location = new System.Drawing.Point(18, 335);
            this.buttonNavReports.Name = "buttonNavReports";
            this.buttonNavReports.Size = new System.Drawing.Size(164, 38);
            this.buttonNavReports.TabIndex = 6;
            this.buttonNavReports.Text = "Reports";
            this.buttonNavReports.UseVisualStyleBackColor = false;
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
            this.labelTitle.Size = new System.Drawing.Size(104, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Reports";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.Color.Black;
            this.labelSubtitle.Location = new System.Drawing.Point(237, 65);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(235, 17);
            this.labelSubtitle.TabIndex = 2;
            this.labelSubtitle.Text = "System reports and analytics overview";
            // 
            // labelSectionTitle
            // 
            this.labelSectionTitle.AutoSize = true;
            this.labelSectionTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectionTitle.ForeColor = System.Drawing.Color.Black;
            this.labelSectionTitle.Location = new System.Drawing.Point(235, 100);
            this.labelSectionTitle.Name = "labelSectionTitle";
            this.labelSectionTitle.Size = new System.Drawing.Size(199, 19);
            this.labelSectionTitle.TabIndex = 4;
            this.labelSectionTitle.Text = "Key Performance Indicators:";

            System.Drawing.Size cardSize = new System.Drawing.Size(205, 125);
            System.Drawing.Color cardColor = System.Drawing.Color.White;
            System.Drawing.Color titleColor = System.Drawing.Color.Black;
            System.Drawing.Color valueColor = System.Drawing.Color.FromArgb(0, 102, 204);
            System.Drawing.Font titleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font valueFont = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            System.Drawing.Point titlePoint = new System.Drawing.Point(16, 16);
            System.Drawing.Point valuePoint = new System.Drawing.Point(14, 52);

            // 
            // panelTotalStudents
            // 
            this.panelTotalStudents.BackColor = cardColor;
            this.panelTotalStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalStudents.Controls.Add(this.lblTitleStudents);
            this.panelTotalStudents.Controls.Add(this.lblValueStudents);
            this.panelTotalStudents.Location = new System.Drawing.Point(235, 135);
            this.panelTotalStudents.Name = "panelTotalStudents";
            this.panelTotalStudents.Size = cardSize;
            this.panelTotalStudents.TabIndex = 5;

            this.lblTitleStudents.AutoSize = true;
            this.lblTitleStudents.Font = titleFont;
            this.lblTitleStudents.ForeColor = titleColor;
            this.lblTitleStudents.Location = titlePoint;
            this.lblTitleStudents.Name = "lblTitleStudents";
            this.lblTitleStudents.Text = "TOTAL STUDENTS";

            this.lblValueStudents.AutoSize = true;
            this.lblValueStudents.Font = valueFont;
            this.lblValueStudents.ForeColor = valueColor;
            this.lblValueStudents.Location = valuePoint;
            this.lblValueStudents.Name = "lblValueStudents";
            this.lblValueStudents.Text = "0";

            // 
            // panelTotalCourses
            // 
            this.panelTotalCourses.BackColor = cardColor;
            this.panelTotalCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalCourses.Controls.Add(this.lblTitleCourses);
            this.panelTotalCourses.Controls.Add(this.lblValueCourses);
            this.panelTotalCourses.Location = new System.Drawing.Point(460, 135);
            this.panelTotalCourses.Name = "panelTotalCourses";
            this.panelTotalCourses.Size = cardSize;
            this.panelTotalCourses.TabIndex = 6;

            this.lblTitleCourses.AutoSize = true;
            this.lblTitleCourses.Font = titleFont;
            this.lblTitleCourses.ForeColor = titleColor;
            this.lblTitleCourses.Location = titlePoint;
            this.lblTitleCourses.Name = "lblTitleCourses";
            this.lblTitleCourses.Text = "TOTAL COURSES";

            this.lblValueCourses.AutoSize = true;
            this.lblValueCourses.Font = valueFont;
            this.lblValueCourses.ForeColor = valueColor;
            this.lblValueCourses.Location = valuePoint;
            this.lblValueCourses.Name = "lblValueCourses";
            this.lblValueCourses.Text = "0";

            // 
            // panelTotalEnrollments
            // 
            this.panelTotalEnrollments.BackColor = cardColor;
            this.panelTotalEnrollments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalEnrollments.Controls.Add(this.lblTitleEnrollments);
            this.panelTotalEnrollments.Controls.Add(this.lblValueEnrollments);
            this.panelTotalEnrollments.Location = new System.Drawing.Point(685, 135);
            this.panelTotalEnrollments.Name = "panelTotalEnrollments";
            this.panelTotalEnrollments.Size = cardSize;
            this.panelTotalEnrollments.TabIndex = 7;

            this.lblTitleEnrollments.AutoSize = true;
            this.lblTitleEnrollments.Font = titleFont;
            this.lblTitleEnrollments.ForeColor = titleColor;
            this.lblTitleEnrollments.Location = titlePoint;
            this.lblTitleEnrollments.Name = "lblTitleEnrollments";
            this.lblTitleEnrollments.Text = "TOTAL ENROLLMENTS";

            this.lblValueEnrollments.AutoSize = true;
            this.lblValueEnrollments.Font = valueFont;
            this.lblValueEnrollments.ForeColor = valueColor;
            this.lblValueEnrollments.Location = valuePoint;
            this.lblValueEnrollments.Name = "lblValueEnrollments";
            this.lblValueEnrollments.Text = "0";

            // 
            // panelTotalGrades
            // 
            this.panelTotalGrades.BackColor = cardColor;
            this.panelTotalGrades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalGrades.Controls.Add(this.lblTitleGrades);
            this.panelTotalGrades.Controls.Add(this.lblValueGrades);
            this.panelTotalGrades.Location = new System.Drawing.Point(910, 135);
            this.panelTotalGrades.Name = "panelTotalGrades";
            this.panelTotalGrades.Size = cardSize;
            this.panelTotalGrades.TabIndex = 8;

            this.lblTitleGrades.AutoSize = true;
            this.lblTitleGrades.Font = titleFont;
            this.lblTitleGrades.ForeColor = titleColor;
            this.lblTitleGrades.Location = titlePoint;
            this.lblTitleGrades.Name = "lblTitleGrades";
            this.lblTitleGrades.Text = "TOTAL GRADES";

            this.lblValueGrades.AutoSize = true;
            this.lblValueGrades.Font = valueFont;
            this.lblValueGrades.ForeColor = valueColor;
            this.lblValueGrades.Location = valuePoint;
            this.lblValueGrades.Name = "lblValueGrades";
            this.lblValueGrades.Text = "0";

            // 
            // panelAvgExam
            // 
            this.panelAvgExam.BackColor = cardColor;
            this.panelAvgExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAvgExam.Controls.Add(this.lblTitleAvgExam);
            this.panelAvgExam.Controls.Add(this.lblValueAvgExam);
            this.panelAvgExam.Location = new System.Drawing.Point(235, 285);
            this.panelAvgExam.Name = "panelAvgExam";
            this.panelAvgExam.Size = cardSize;
            this.panelAvgExam.TabIndex = 9;

            this.lblTitleAvgExam.AutoSize = true;
            this.lblTitleAvgExam.Font = titleFont;
            this.lblTitleAvgExam.ForeColor = titleColor;
            this.lblTitleAvgExam.Location = titlePoint;
            this.lblTitleAvgExam.Name = "lblTitleAvgExam";
            this.lblTitleAvgExam.Text = "AVG EXAM SCORE";

            this.lblValueAvgExam.AutoSize = true;
            this.lblValueAvgExam.Font = valueFont;
            this.lblValueAvgExam.ForeColor = valueColor;
            this.lblValueAvgExam.Location = valuePoint;
            this.lblValueAvgExam.Name = "lblValueAvgExam";
            this.lblValueAvgExam.Text = "0%";

            // 
            // panelAvgCoursework
            // 
            this.panelAvgCoursework.BackColor = cardColor;
            this.panelAvgCoursework.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAvgCoursework.Controls.Add(this.lblTitleAvgCW);
            this.panelAvgCoursework.Controls.Add(this.lblValueAvgCW);
            this.panelAvgCoursework.Location = new System.Drawing.Point(460, 285);
            this.panelAvgCoursework.Name = "panelAvgCoursework";
            this.panelAvgCoursework.Size = cardSize;
            this.panelAvgCoursework.TabIndex = 10;

            this.lblTitleAvgCW.AutoSize = true;
            this.lblTitleAvgCW.Font = titleFont;
            this.lblTitleAvgCW.ForeColor = titleColor;
            this.lblTitleAvgCW.Location = titlePoint;
            this.lblTitleAvgCW.Name = "lblTitleAvgCW";
            this.lblTitleAvgCW.Text = "AVG COURSEWORK";

            this.lblValueAvgCW.AutoSize = true;
            this.lblValueAvgCW.Font = valueFont;
            this.lblValueAvgCW.ForeColor = valueColor;
            this.lblValueAvgCW.Location = valuePoint;
            this.lblValueAvgCW.Name = "lblValueAvgCW";
            this.lblValueAvgCW.Text = "0%";

            // 
            // panelAttendanceRecords
            // 
            this.panelAttendanceRecords.BackColor = cardColor;
            this.panelAttendanceRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAttendanceRecords.Controls.Add(this.lblTitleAttendance);
            this.panelAttendanceRecords.Controls.Add(this.lblValueAttendance);
            this.panelAttendanceRecords.Location = new System.Drawing.Point(685, 285);
            this.panelAttendanceRecords.Name = "panelAttendanceRecords";
            this.panelAttendanceRecords.Size = cardSize;
            this.panelAttendanceRecords.TabIndex = 11;

            this.lblTitleAttendance.AutoSize = true;
            this.lblTitleAttendance.Font = titleFont;
            this.lblTitleAttendance.ForeColor = titleColor;
            this.lblTitleAttendance.Location = titlePoint;
            this.lblTitleAttendance.Name = "lblTitleAttendance";
            this.lblTitleAttendance.Text = "ATTENDANCE RECS";

            this.lblValueAttendance.AutoSize = true;
            this.lblValueAttendance.Font = valueFont;
            this.lblValueAttendance.ForeColor = valueColor;
            this.lblValueAttendance.Location = valuePoint;
            this.lblValueAttendance.Name = "lblValueAttendance";
            this.lblValueAttendance.Text = "0";

            // 
            // panelAttendanceRate
            // 
            this.panelAttendanceRate.BackColor = cardColor;
            this.panelAttendanceRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAttendanceRate.Controls.Add(this.lblTitleAttRate);
            this.panelAttendanceRate.Controls.Add(this.lblValueAttRate);
            this.panelAttendanceRate.Location = new System.Drawing.Point(910, 285);
            this.panelAttendanceRate.Name = "panelAttendanceRate";
            this.panelAttendanceRate.Size = cardSize;
            this.panelAttendanceRate.TabIndex = 12;

            this.lblTitleAttRate.AutoSize = true;
            this.lblTitleAttRate.Font = titleFont;
            this.lblTitleAttRate.ForeColor = titleColor;
            this.lblTitleAttRate.Location = titlePoint;
            this.lblTitleAttRate.Name = "lblTitleAttRate";
            this.lblTitleAttRate.Text = "ATTENDANCE RATE";

            this.lblValueAttRate.AutoSize = true;
            this.lblValueAttRate.Font = valueFont;
            this.lblValueAttRate.ForeColor = valueColor;
            this.lblValueAttRate.Location = valuePoint;
            this.lblValueAttRate.Name = "lblValueAttRate";
            this.lblValueAttRate.Text = "0%";

            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelSectionTitle);
            this.Controls.Add(this.panelTotalStudents);
            this.Controls.Add(this.panelTotalCourses);
            this.Controls.Add(this.panelTotalEnrollments);
            this.Controls.Add(this.panelTotalGrades);
            this.Controls.Add(this.panelAvgExam);
            this.Controls.Add(this.panelAvgCoursework);
            this.Controls.Add(this.panelAttendanceRecords);
            this.Controls.Add(this.panelAttendanceRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";

            this.panelSidebar.ResumeLayout(false);
            this.panelTotalStudents.ResumeLayout(false);
            this.panelTotalStudents.PerformLayout();
            this.panelTotalCourses.ResumeLayout(false);
            this.panelTotalCourses.PerformLayout();
            this.panelTotalEnrollments.ResumeLayout(false);
            this.panelTotalEnrollments.PerformLayout();
            this.panelTotalGrades.ResumeLayout(false);
            this.panelTotalGrades.PerformLayout();
            this.panelAvgExam.ResumeLayout(false);
            this.panelAvgExam.PerformLayout();
            this.panelAvgCoursework.ResumeLayout(false);
            this.panelAvgCoursework.PerformLayout();
            this.panelAttendanceRecords.ResumeLayout(false);
            this.panelAttendanceRecords.PerformLayout();
            this.panelAttendanceRate.ResumeLayout(false);
            this.panelAttendanceRate.PerformLayout();

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

        private System.Windows.Forms.Panel panelTotalStudents;
        private System.Windows.Forms.Label lblTitleStudents;
        private System.Windows.Forms.Label lblValueStudents;

        private System.Windows.Forms.Panel panelTotalCourses;
        private System.Windows.Forms.Label lblTitleCourses;
        private System.Windows.Forms.Label lblValueCourses;

        private System.Windows.Forms.Panel panelTotalEnrollments;
        private System.Windows.Forms.Label lblTitleEnrollments;
        private System.Windows.Forms.Label lblValueEnrollments;

        private System.Windows.Forms.Panel panelTotalGrades;
        private System.Windows.Forms.Label lblTitleGrades;
        private System.Windows.Forms.Label lblValueGrades;

        private System.Windows.Forms.Panel panelAttendanceRecords;
        private System.Windows.Forms.Label lblTitleAttendance;
        private System.Windows.Forms.Label lblValueAttendance;

        private System.Windows.Forms.Panel panelAvgExam;
        private System.Windows.Forms.Label lblTitleAvgExam;
        private System.Windows.Forms.Label lblValueAvgExam;

        private System.Windows.Forms.Panel panelAvgCoursework;
        private System.Windows.Forms.Label lblTitleAvgCW;
        private System.Windows.Forms.Label lblValueAvgCW;

        private System.Windows.Forms.Panel panelAttendanceRate;
        private System.Windows.Forms.Label lblTitleAttRate;
        private System.Windows.Forms.Label lblValueAttRate;
    }
}
