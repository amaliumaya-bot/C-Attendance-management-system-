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
    public partial class CoursesForm : Form
    {
        private List<Course> coursesList = new List<Course>();
        private bool isNavigating = false;

        public CoursesForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            this.coursesList.Clear();
            this.listBoxCourses.Items.Clear();

            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;
            string query = "SELECT CourseID, CourseTitle, Credits FROM Courses ORDER BY CourseID";

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
                                int courseId = Convert.ToInt32(reader["CourseID"]);
                                string courseTitle = reader["CourseTitle"].ToString();
                                int credits = Convert.ToInt32(reader["Credits"]);

                                Course course = new Course(courseId, courseTitle, credits);
                                this.coursesList.Add(course);
                                string displayText = "ID: " + course.CourseID + " | " + course.CourseTitle + " | Credits: " + course.Credits;
                                this.listBoxCourses.Items.Add(displayText);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading courses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (CourseEditorForm editor = new CourseEditorForm())
            {
                DialogResult result = editor.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    LoadCourses();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.listBoxCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course from the list to edit.", "Selection Required", MessageBoxButtons.OK);
                return;
            }

            int selectedIndex = this.listBoxCourses.SelectedIndex;
            Course selectedCourse = this.coursesList[selectedIndex];

            using (CourseEditorForm editor = new CourseEditorForm(selectedCourse))
            {
                DialogResult result = editor.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    LoadCourses();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listBoxCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course from the list to delete.", "Selection Required", MessageBoxButtons.OK);
                return;
            }

            int selectedIndex = this.listBoxCourses.SelectedIndex;
            Course selectedCourse = this.coursesList[selectedIndex];

            DialogResult confirmation = MessageBox.Show(
                "Are you sure you want to delete this course?\n\nCourse ID: " + selectedCourse.CourseID + "\nTitle: " + selectedCourse.CourseTitle,
                "Confirm Deletion",
                MessageBoxButtons.YesNo);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;
            string deleteQuery = "DELETE FROM Courses WHERE CourseID = @CourseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", selectedCourse.CourseID);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Course record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCourses();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547)
                {
                    MessageBox.Show("Cannot delete this course because students or related academic records are associated with it.\nPlease reassign or remove related records first.", "Deletion Prevented", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("A database error occurred while deleting the course: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
