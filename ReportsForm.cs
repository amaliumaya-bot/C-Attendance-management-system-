using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class ReportsForm : Form
    {
        private bool isNavigating = false;

        public ReportsForm()
        {
            InitializeComponent();
            LoadReportStatistics();
            this.Activated += ReportsForm_Activated;
        }

        private void ReportsForm_Activated(object sender, EventArgs e)
        {
            LoadReportStatistics();
        }

        private void LoadReportStatistics()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Students", connection))
                    {
                        int totalStudents = Convert.ToInt32(cmd.ExecuteScalar());
                        this.lblValueStudents.Text = totalStudents.ToString();
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Courses", connection))
                    {
                        int totalCourses = Convert.ToInt32(cmd.ExecuteScalar());
                        this.lblValueCourses.Text = totalCourses.ToString();
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Enrollments", connection))
                    {
                        int totalEnrollments = Convert.ToInt32(cmd.ExecuteScalar());
                        this.lblValueEnrollments.Text = totalEnrollments.ToString();
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Grades", connection))
                    {
                        int totalGrades = Convert.ToInt32(cmd.ExecuteScalar());
                        this.lblValueGrades.Text = totalGrades.ToString();

                        if (totalGrades > 0)
                        {
                            using (SqlCommand avgExamCmd = new SqlCommand("SELECT AVG(ExamMarks) FROM Grades", connection))
                            {
                                double avgExam = Convert.ToDouble(avgExamCmd.ExecuteScalar());
                                this.lblValueAvgExam.Text = avgExam.ToString("0.0");
                            }

                            using (SqlCommand avgCwCmd = new SqlCommand("SELECT AVG(CourseworkMarks) FROM Grades", connection))
                            {
                                double avgCw = Convert.ToDouble(avgCwCmd.ExecuteScalar());
                                this.lblValueAvgCW.Text = avgCw.ToString("0.0");
                            }
                        }
                        else
                        {
                            this.lblValueAvgExam.Text = "N/A";
                            this.lblValueAvgCW.Text = "N/A";
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Attendance", connection))
                    {
                        int totalAttendance = Convert.ToInt32(cmd.ExecuteScalar());
                        this.lblValueAttendance.Text = totalAttendance.ToString();

                        if (totalAttendance > 0)
                        {
                            using (SqlCommand presentCmd = new SqlCommand("SELECT COUNT(*) FROM Attendance WHERE Status = 'Present'", connection))
                            {
                                int presentCount = Convert.ToInt32(presentCmd.ExecuteScalar());
                                double attendanceRate = ((double)presentCount / totalAttendance) * 100;
                                this.lblValueAttRate.Text = attendanceRate.ToString("0.0") + "%";
                            }
                        }
                        else
                        {
                            this.lblValueAttRate.Text = "N/A";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading statistics: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNavDashboard_Click(object sender, EventArgs e)
        {
            this.isNavigating = true;
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Close();
        }

        private void buttonNavStudents_Click(object sender, EventArgs e)
        {
            this.isNavigating = true;
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show();
            this.Close();
        }

        private void buttonNavCourses_Click(object sender, EventArgs e)
        {
            this.isNavigating = true;
            CoursesForm coursesForm = new CoursesForm();
            coursesForm.Show();
            this.Close();
        }

        private void buttonNavGrades_Click(object sender, EventArgs e)
        {
            this.isNavigating = true;
            GradesForm gradesForm = new GradesForm();
            gradesForm.Show();
            this.Close();
        }

        private void buttonNavAttendance_Click(object sender, EventArgs e)
        {
            this.isNavigating = true;
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.Show();
            this.Close();
        }

        private void buttonNavLogout_Click(object sender, EventArgs e)
        {
            this.isNavigating = true;
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing && !this.isNavigating)
            {
                Application.Exit();
            }
        }
    }
}
