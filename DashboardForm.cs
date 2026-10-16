using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.Load += DashboardForm_Load;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        public void LoadDashboardStats()
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM Students", connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && Convert.ToInt32(result) > 0)
                        {
                            labelCardStudentsCount.Text = result.ToString();
                        }
                    }

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM Courses", connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && Convert.ToInt32(result) > 0)
                        {
                            labelCardCoursesCount.Text = result.ToString();
                        }
                    }

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM Grades", connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && Convert.ToInt32(result) > 0)
                        {
                            labelCardGradesCount.Text = result.ToString();
                        }
                    }

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("SELECT AVG(ExamMarks + CourseworkMarks) FROM Grades", connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            decimal avg = Convert.ToDecimal(result) / 2m;
                            labelCardPerfCount.Text = Math.Round(avg, 0) + "%";
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void buttonNavStudents_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show();
            this.Hide();
        }

        private void buttonNavCourses_Click(object sender, EventArgs e)
        {
            CoursesForm coursesForm = new CoursesForm();
            coursesForm.Show();
            this.Hide();
        }

        private void buttonNavGrades_Click(object sender, EventArgs e)
        {
            GradesForm gradesForm = new GradesForm();
            gradesForm.Show();
            this.Hide();
        }

        private void buttonNavAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.Show();
            this.Hide();
        }

        private void buttonNavReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
            this.Hide();
        }

        private void buttonNavLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing && this.Visible)
            {
                Application.Exit();
            }
        }
    }
}
