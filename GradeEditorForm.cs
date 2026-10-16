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
    public partial class GradeEditorForm : Form
    {
        private bool isEditMode;
        private int editingGradeId;

        private class EnrollmentItem
        {
            public int EnrollmentID { get; set; }
            public string DisplayText { get; set; }
        }

        public GradeEditorForm()
        {
            InitializeComponent();
            this.isEditMode = false;
            this.labelHeaderTitle.Text = "Add New Grade";
            LoadComboBoxes();
        }

        public GradeEditorForm(GradeRecord grade)
        {
            InitializeComponent();
            this.isEditMode = true;
            this.labelHeaderTitle.Text = "Edit Grade";
            this.editingGradeId = grade.GradeID;

            LoadComboBoxes();

            this.comboBoxEnrollment.SelectedValue = grade.EnrollmentID;
            this.textBoxExamMarks.Text = grade.ExamMarks.ToString();
            this.textBoxCourseworkMarks.Text = grade.CourseworkMarks.ToString();
        }

        private void LoadComboBoxes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;

            string query = @"
                SELECT
                    e.EnrollmentID,
                    s.FullName,
                    c.CourseTitle
                FROM Enrollments e
                INNER JOIN Students s ON e.StudentID = s.StudentID
                INNER JOIN Courses c ON e.CourseID = c.CourseID
                ORDER BY e.EnrollmentID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<EnrollmentItem> enrollments = new List<EnrollmentItem>();
                            while (reader.Read())
                            {
                                int enrollmentId = Convert.ToInt32(reader["EnrollmentID"]);
                                string fullName = reader["FullName"].ToString();
                                string courseTitle = reader["CourseTitle"].ToString();

                                enrollments.Add(new EnrollmentItem
                                {
                                    EnrollmentID = enrollmentId,
                                    DisplayText = $"{fullName} - {courseTitle}"
                                });
                            }
                            this.comboBoxEnrollment.DataSource = enrollments;
                            this.comboBoxEnrollment.DisplayMember = "DisplayText";
                            this.comboBoxEnrollment.ValueMember = "EnrollmentID";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading enrollments: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.comboBoxEnrollment.SelectedIndex == -1 || this.comboBoxEnrollment.SelectedValue == null)
            {
                MessageBox.Show("Please select an enrollment.", "Validation Error", MessageBoxButtons.OK);
                this.comboBoxEnrollment.Focus();
                return;
            }

            double examMarks;
            if (!double.TryParse(this.textBoxExamMarks.Text.Trim(), out examMarks) || examMarks < 0 || examMarks > 100)
            {
                MessageBox.Show("Please enter valid exam marks between 0 and 100.", "Validation Error", MessageBoxButtons.OK);
                this.textBoxExamMarks.Focus();
                return;
            }

            double courseworkMarks;
            if (!double.TryParse(this.textBoxCourseworkMarks.Text.Trim(), out courseworkMarks) || courseworkMarks < 0 || courseworkMarks > 100)
            {
                MessageBox.Show("Please enter valid coursework marks between 0 and 100.", "Validation Error", MessageBoxButtons.OK);
                this.textBoxCourseworkMarks.Focus();
                return;
            }

            int enrollmentId = Convert.ToInt32(this.comboBoxEnrollment.SelectedValue);
            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkQuery = this.isEditMode ?
                        "SELECT COUNT(*) FROM Grades WHERE EnrollmentID = @EnrollmentID AND GradeID <> @GradeID" :
                        "SELECT COUNT(*) FROM Grades WHERE EnrollmentID = @EnrollmentID";

                    int existingGradeCount = 0;
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@EnrollmentID", enrollmentId);
                        if (this.isEditMode)
                        {
                            checkCmd.Parameters.AddWithValue("@GradeID", this.editingGradeId);
                        }
                        existingGradeCount = (int)checkCmd.ExecuteScalar();
                    }

                    if (existingGradeCount > 0)
                    {
                        MessageBox.Show("A grade already exists for this student and course.", "Duplicate Grade", MessageBoxButtons.OK);
                        return;
                    }

                    if (this.isEditMode)
                    {
                        string updateQuery = "UPDATE Grades SET EnrollmentID = @EnrollmentID, ExamMarks = @ExamMarks, CourseworkMarks = @CourseworkMarks WHERE GradeID = @GradeID";
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@EnrollmentID", enrollmentId);
                            command.Parameters.AddWithValue("@ExamMarks", examMarks);
                            command.Parameters.AddWithValue("@CourseworkMarks", courseworkMarks);
                            command.Parameters.AddWithValue("@GradeID", this.editingGradeId);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Grade record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO Grades (EnrollmentID, ExamMarks, CourseworkMarks) VALUES (@EnrollmentID, @ExamMarks, @CourseworkMarks)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@EnrollmentID", enrollmentId);
                            command.Parameters.AddWithValue("@ExamMarks", examMarks);
                            command.Parameters.AddWithValue("@CourseworkMarks", courseworkMarks);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Grade record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the grade: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
