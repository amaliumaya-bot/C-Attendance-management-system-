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
    public partial class StudentEditorForm : Form
    {
        private bool isEditMode;
        private int editingStudentId;

        public StudentEditorForm()
        {
            InitializeComponent();
            this.isEditMode = false;
            this.labelHeaderTitle.Text = "Add New Student";
        }

        public StudentEditorForm(Student student)
        {
            InitializeComponent();
            this.isEditMode = true;
            this.labelHeaderTitle.Text = "Edit Student";
            this.editingStudentId = student.StudentID;
            this.textBoxFullName.Text = student.FullName;
            this.textBoxEmail.Text = student.Email;
            this.dateTimePickerDateOfBirth.Value = student.DateOfBirth;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string fullName = this.textBoxFullName.Text.Trim();
            string email = this.textBoxEmail.Text.Trim();

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Please enter the student's full name.", "Validation Error", MessageBoxButtons.OK);
                this.textBoxFullName.Focus();
                return;
            }

            int atIndex = email.IndexOf('@');
            if (string.IsNullOrEmpty(email) || atIndex == -1 || email.IndexOf('.', atIndex) == -1)
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK);
                this.textBoxEmail.Focus();
                return;
            }

            DateTime dateOfBirth = this.dateTimePickerDateOfBirth.Value.Date;
            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    if (this.isEditMode)
                    {
                        string updateQuery = "UPDATE Students SET FullName = @FullName, Email = @Email, DateOfBirth = @DateOfBirth WHERE StudentID = @StudentID";
                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@FullName", fullName);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                            command.Parameters.AddWithValue("@StudentID", this.editingStudentId);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Student record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO Students (FullName, Email, DateOfBirth) VALUES (@FullName, @Email, @DateOfBirth)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@FullName", fullName);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Student record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the student: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
