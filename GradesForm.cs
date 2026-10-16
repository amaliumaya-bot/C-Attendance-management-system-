using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class GradesForm : Form
    {
        private List<GradeRecord> gradesList = new List<GradeRecord>();
        private bool isNavigating = false;

        public GradesForm()
        {
            InitializeComponent();
            LoadGrades();
        }

        private void LoadGrades()
        {
            this.gradesList.Clear();
            this.listBoxGrades.Items.Clear();

            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;

            string query = @"
                SELECT
                    g.GradeID,
                    g.EnrollmentID,
                    g.ExamMarks,
                    g.CourseworkMarks,
                    s.FullName,
                    c.CourseTitle
                FROM Grades g
                INNER JOIN Enrollments e ON g.EnrollmentID = e.EnrollmentID
                INNER JOIN Students s ON e.StudentID = s.StudentID
                INNER JOIN Courses c ON e.CourseID = c.CourseID
                ORDER BY g.GradeID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int gradeId = Convert.ToInt32(reader["GradeID"]);
                                int enrollmentId = Convert.ToInt32(reader["EnrollmentID"]);
                                double examMarks = Convert.ToDouble(reader["ExamMarks"]);
                                double courseworkMarks = Convert.ToDouble(reader["CourseworkMarks"]);
                                string fullName = reader["FullName"].ToString();
                                string courseTitle = reader["CourseTitle"].ToString();

                                GradeRecord grade = new GradeRecord(gradeId, enrollmentId, examMarks, courseworkMarks);
                                this.gradesList.Add(grade);

                                string displayText = $"ID: {gradeId} | {fullName} | {courseTitle} | Exam: {examMarks} | CW: {courseworkMarks} | Total: {grade.CalculateTotalMarks()}";
                                this.listBoxGrades.Items.Add(displayText);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading grades: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (GradeEditorForm editor = new GradeEditorForm())
            {
                DialogResult result = editor.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    LoadGrades();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.listBoxGrades.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a grade record to edit.", "Selection Required", MessageBoxButtons.OK);
                return;
            }

            int selectedIndex = this.listBoxGrades.SelectedIndex;
            GradeRecord selectedGrade = this.gradesList[selectedIndex];

            using (GradeEditorForm editor = new GradeEditorForm(selectedGrade))
            {
                DialogResult result = editor.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    LoadGrades();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listBoxGrades.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a grade record to delete.", "Selection Required", MessageBoxButtons.OK);
                return;
            }

            int selectedIndex = this.listBoxGrades.SelectedIndex;
            GradeRecord selectedGrade = this.gradesList[selectedIndex];

            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this grade record?", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;
                string deleteQuery = "DELETE FROM Grades WHERE GradeID = @GradeID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@GradeID", selectedGrade.GradeID);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Grade record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadGrades();
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    if (sqlEx.Number == 547)
                    {
                        MessageBox.Show("Cannot delete this grade record because related records exist.", "Deletion Prevented", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("A database error occurred: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonNavDashboard_Click(object sender, EventArgs e)
        {
            this.isNavigating = true;
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
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

        private void buttonNavAttendance_Click(object sender, EventArgs e)
        {
            this.isNavigating = true;
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.Show();
            this.Close();
        }

        private void buttonNavReports_Click(object sender, EventArgs e)
        {
            this.isNavigating = true;
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
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
