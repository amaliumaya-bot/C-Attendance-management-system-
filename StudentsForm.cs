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
    public partial class StudentsForm : Form
    {
        private List<Student> studentsList = new List<Student>();
        private bool isNavigating = false;

        public StudentsForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            this.studentsList.Clear();
            this.listBoxStudents.Items.Clear();

            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;
            string query = "SELECT StudentID, FullName, Email, DateOfBirth FROM Students ORDER BY StudentID";

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
                                int studentId = Convert.ToInt32(reader["StudentID"]);
                                string fullName = reader["FullName"].ToString();
                                string email = reader["Email"].ToString();
                                DateTime dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

                                Student student = new Student(studentId, fullName, email, dateOfBirth);
                                this.studentsList.Add(student);
                                this.listBoxStudents.Items.Add(student.GetDisplayInfo());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading students: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (StudentEditorForm editor = new StudentEditorForm())
            {
                DialogResult result = editor.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    LoadStudents();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.listBoxStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student from the list to edit.", "Selection Required", MessageBoxButtons.OK);
                return;
            }

            int selectedIndex = this.listBoxStudents.SelectedIndex;
            Student selectedStudent = this.studentsList[selectedIndex];

            using (StudentEditorForm editor = new StudentEditorForm(selectedStudent))
            {
                DialogResult result = editor.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    LoadStudents();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listBoxStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student from the list to delete.", "Selection Required", MessageBoxButtons.OK);
                return;
            }

            int selectedIndex = this.listBoxStudents.SelectedIndex;
            Student selectedStudent = this.studentsList[selectedIndex];

            DialogResult confirmation = MessageBox.Show(
                "Are you sure you want to delete this student?\n\nStudent ID: " + selectedStudent.StudentID + "\nName: " + selectedStudent.FullName,
                "Confirm Deletion",
                MessageBoxButtons.YesNo);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;
            string deleteQuery = "DELETE FROM Students WHERE StudentID = @StudentID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", selectedStudent.StudentID);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Student record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudents();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547)
                {
                    MessageBox.Show("Cannot delete this student because related Grade or Attendance records exist.\nPlease delete related records first.", "Deletion Prevented", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("A database error occurred while deleting the student: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            if (this.listBoxStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student from the list to enroll.", "Selection Required", MessageBoxButtons.OK);
                return;
            }

            Student selectedStudent = this.studentsList[this.listBoxStudents.SelectedIndex];

            using (EnrollmentForm enrollmentForm = new EnrollmentForm(selectedStudent))
            {
                enrollmentForm.ShowDialog(this);
            }
        }

        private void buttonNavDashboard_Click(object sender, EventArgs e)
        {
            this.isNavigating = true;
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
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
