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
    public partial class EnrollmentForm : Form
    {
        private Student currentStudent;

        public EnrollmentForm(Student student)
        {
            InitializeComponent();
            this.currentStudent = student;
            this.labelHeaderTitle.Text = "Enroll Student";
            this.textBoxStudentName.Text = student.FullName;
            LoadAvailableCourses();
        }

        private void LoadAvailableCourses()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;
            string query = "SELECT c.CourseID, c.CourseTitle FROM Courses c WHERE c.CourseID NOT IN (SELECT e.CourseID FROM Enrollments e WHERE e.StudentID = @StudentID) ORDER BY c.CourseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", this.currentStudent.StudentID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<Course> availableCourses = new List<Course>();
                            while (reader.Read())
                            {
                                Course course = new Course(
                                    Convert.ToInt32(reader["CourseID"]),
                                    reader["CourseTitle"].ToString(),
                                    0
                                );
                                availableCourses.Add(course);
                            }

                            this.comboBoxCourse.DataSource = availableCourses;
                            this.comboBoxCourse.DisplayMember = "CourseTitle";
                            this.comboBoxCourse.ValueMember = "CourseID";

                            if (availableCourses.Count == 0)
                            {
                                this.comboBoxCourse.Enabled = false;
                                this.buttonEnroll.Enabled = false;
                                MessageBox.Show("This student is already enrolled in all available courses.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            if (this.comboBoxCourse.SelectedIndex == -1 || this.comboBoxCourse.SelectedValue == null)
            {
                MessageBox.Show("Please select a course to enroll in.", "Validation Error", MessageBoxButtons.OK);
                return;
            }

            int courseId = Convert.ToInt32(this.comboBoxCourse.SelectedValue);
            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Enrollments (StudentID, CourseID) VALUES (@StudentID, @CourseID)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", this.currentStudent.StudentID);
                        command.Parameters.AddWithValue("@CourseID", courseId);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Student enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("The student is already enrolled in this course.", "Duplicate Enrollment", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("A database error occurred: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while enrolling the student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
