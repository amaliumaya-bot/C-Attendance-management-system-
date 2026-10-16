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
    public partial class CourseEditorForm : Form
    {
        private bool isEditMode = false;
        private int editingCourseId = 0;

        public CourseEditorForm()
        {
            InitializeComponent();
            this.isEditMode = false;
            this.Text = "Add New Course";
            this.labelHeaderTitle.Text = "Add New Course";
        }

        public CourseEditorForm(Course course)
        {
            InitializeComponent();
            this.isEditMode = true;
            this.editingCourseId = course.CourseID;
            this.Text = "Edit Course";
            this.labelHeaderTitle.Text = "Edit Course";
            PopulateCourseData(course);
        }

        private void PopulateCourseData(Course course)
        {
            this.textBoxCourseTitle.Text = course.CourseTitle;
            this.numericUpDownCredits.Value = course.Credits;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string courseTitle = this.textBoxCourseTitle.Text.Trim();

            if (string.IsNullOrEmpty(courseTitle))
            {
                MessageBox.Show("Please enter the course title.", "Validation Error", MessageBoxButtons.OK);
                this.textBoxCourseTitle.Focus();
                return;
            }

            int credits = Convert.ToInt32(this.numericUpDownCredits.Value);

            if (credits <= 0)
            {
                MessageBox.Show("Please enter a valid credit value greater than zero.", "Validation Error", MessageBoxButtons.OK);
                this.numericUpDownCredits.Focus();
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (this.isEditMode)
                    {
                        string updateQuery = "UPDATE Courses SET CourseTitle = @CourseTitle, Credits = @Credits WHERE CourseID = @CourseID";
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@CourseTitle", courseTitle);
                            command.Parameters.AddWithValue("@Credits", credits);
                            command.Parameters.AddWithValue("@CourseID", this.editingCourseId);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Course record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO Courses (CourseTitle, Credits) VALUES (@CourseTitle, @Credits)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@CourseTitle", courseTitle);
                            command.Parameters.AddWithValue("@Credits", credits);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Course record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the course: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
