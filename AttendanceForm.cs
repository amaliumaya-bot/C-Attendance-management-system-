using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class AttendanceForm : Form
    {
        private List<AttendanceRecord> attendanceList = new List<AttendanceRecord>();
        private bool isNavigating = false;

        public AttendanceForm()
        {
            InitializeComponent();
            LoadAttendance();
        }

        private void LoadAttendance()
        {
            this.attendanceList.Clear();
            this.listBoxAttendance.Items.Clear();

            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;
            string query = "SELECT a.AttendanceID, a.EnrollmentID, a.DateRecorded, a.Status, s.FullName, c.CourseTitle " +
                           "FROM Attendance a " +
                           "INNER JOIN Enrollments e ON a.EnrollmentID = e.EnrollmentID " +
                           "INNER JOIN Students s ON e.StudentID = s.StudentID " +
                           "INNER JOIN Courses c ON e.CourseID = c.CourseID " +
                           "ORDER BY a.AttendanceID";

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
                                int attendanceId = Convert.ToInt32(reader["AttendanceID"]);
                                int enrollmentId = Convert.ToInt32(reader["EnrollmentID"]);
                                DateTime dateRecorded = Convert.ToDateTime(reader["DateRecorded"]);
                                string status = reader["Status"].ToString();
                                string fullName = reader["FullName"].ToString();
                                string courseTitle = reader["CourseTitle"].ToString();

                                AttendanceRecord record = new AttendanceRecord(attendanceId, enrollmentId, dateRecorded, status);
                                this.attendanceList.Add(record);

                                string displayText = "ID: " + attendanceId + " | " + fullName + " | " + courseTitle + " | " + dateRecorded.ToString("dd/MM/yyyy") + " | " + status;
                                this.listBoxAttendance.Items.Add(displayText);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading attendance records: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (AttendanceEditorForm editorForm = new AttendanceEditorForm())
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadAttendance();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.listBoxAttendance.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an attendance record from the list to edit.", "Selection Required", MessageBoxButtons.OK);
                return;
            }

            int selectedIndex = this.listBoxAttendance.SelectedIndex;
            AttendanceRecord selectedRecord = this.attendanceList[selectedIndex];

            using (AttendanceEditorForm editorForm = new AttendanceEditorForm(selectedRecord))
            {
                if (editorForm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadAttendance();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (this.listBoxAttendance.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an attendance record from the list to delete.", "Selection Required", MessageBoxButtons.OK);
                return;
            }

            int selectedIndex = this.listBoxAttendance.SelectedIndex;
            AttendanceRecord selectedRecord = this.attendanceList[selectedIndex];

            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this attendance record?", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (confirmation == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;
                string deleteQuery = "DELETE FROM Attendance WHERE AttendanceID = @AttendanceID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@AttendanceID", selectedRecord.AttendanceID);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Attendance record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAttendance();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the attendance record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
