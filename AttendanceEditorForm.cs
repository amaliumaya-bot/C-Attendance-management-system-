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
    public partial class AttendanceEditorForm : Form
    {
        private bool isEditMode;
        private int editingAttendanceId;

        private class EnrollmentOption
        {
            public int EnrollmentID { get; set; }
            public string DisplayText { get; set; }
        }

        public AttendanceEditorForm()
        {
            InitializeComponent();
            this.isEditMode = false;
            this.editingAttendanceId = 0;
            this.labelHeaderTitle.Text = "Add Attendance";

            InitializeStatusComboBox();
            LoadEnrollments();
            this.dateTimePickerDateRecorded.Value = DateTime.Today;
        }

        public AttendanceEditorForm(AttendanceRecord record)
        {
            InitializeComponent();
            this.isEditMode = true;
            this.editingAttendanceId = record.AttendanceID;
            this.labelHeaderTitle.Text = "Edit Attendance";

            InitializeStatusComboBox();
            LoadEnrollments();

            this.comboBoxEnrollment.SelectedValue = record.EnrollmentID;
            this.dateTimePickerDateRecorded.Value = record.DateRecorded;
            this.comboBoxStatus.SelectedItem = record.Status;
        }

        private void InitializeStatusComboBox()
        {
            this.comboBoxStatus.Items.Clear();
            this.comboBoxStatus.Items.Add("Present");
            this.comboBoxStatus.Items.Add("Absent");
            this.comboBoxStatus.Items.Add("Late");
            this.comboBoxStatus.SelectedIndex = 0;
        }

        private void LoadEnrollments()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;
            string query = @"
                SELECT e.EnrollmentID, s.FullName, c.CourseTitle
                FROM Enrollments e
                INNER JOIN Students s ON e.StudentID = s.StudentID
                INNER JOIN Courses c ON e.CourseID = c.CourseID
                ORDER BY e.EnrollmentID";

            List<EnrollmentOption> enrollmentOptions = new List<EnrollmentOption>();
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
                                int enrollmentId = Convert.ToInt32(reader["EnrollmentID"]);
                                string fullName = reader["FullName"].ToString();
                                string courseTitle = reader["CourseTitle"].ToString();
                                EnrollmentOption option = new EnrollmentOption();
                                option.EnrollmentID = enrollmentId;
                                option.DisplayText = fullName + " - " + courseTitle;
                                enrollmentOptions.Add(option);
                            }
                        }
                    }
                }
                this.comboBoxEnrollment.DataSource = null;
                this.comboBoxEnrollment.DataSource = enrollmentOptions;
                this.comboBoxEnrollment.DisplayMember = "DisplayText";
                this.comboBoxEnrollment.ValueMember = "EnrollmentID";
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
                MessageBox.Show("Please select an enrollment for the attendance record.", "Validation Error", MessageBoxButtons.OK);
                this.comboBoxEnrollment.Focus();
                return;
            }

            if (this.comboBoxStatus.SelectedIndex == -1 || this.comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select an attendance status.", "Validation Error", MessageBoxButtons.OK);
                this.comboBoxStatus.Focus();
                return;
            }

            int enrollmentId = Convert.ToInt32(this.comboBoxEnrollment.SelectedValue);
            DateTime dateRecorded = this.dateTimePickerDateRecorded.Value.Date;
            string status = this.comboBoxStatus.SelectedItem.ToString();
            string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementSystemDB"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string duplicateCheckQuery = "SELECT COUNT(*) FROM Attendance WHERE EnrollmentID = @EnrollmentID AND DateRecorded = @DateRecorded";
                    if (this.isEditMode)
                    {
                        duplicateCheckQuery += " AND AttendanceID <> @AttendanceID";
                    }

                    using (SqlCommand checkCommand = new SqlCommand(duplicateCheckQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@EnrollmentID", enrollmentId);
                        checkCommand.Parameters.AddWithValue("@DateRecorded", dateRecorded);
                        if (this.isEditMode)
                        {
                            checkCommand.Parameters.AddWithValue("@AttendanceID", this.editingAttendanceId);
                        }

                        int duplicateCount = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (duplicateCount > 0)
                        {
                            MessageBox.Show("Attendance has already been recorded for this student and course on this date.", "Duplicate Attendance", MessageBoxButtons.OK);
                            return;
                        }
                    }

                    if (this.isEditMode)
                    {
                        string updateQuery = "UPDATE Attendance SET EnrollmentID = @EnrollmentID, DateRecorded = @DateRecorded, Status = @Status WHERE AttendanceID = @AttendanceID";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@EnrollmentID", enrollmentId);
                            updateCommand.Parameters.AddWithValue("@DateRecorded", dateRecorded);
                            updateCommand.Parameters.AddWithValue("@Status", status);
                            updateCommand.Parameters.AddWithValue("@AttendanceID", this.editingAttendanceId);
                            updateCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show("Attendance record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO Attendance (EnrollmentID, DateRecorded, Status) VALUES (@EnrollmentID, @DateRecorded, @Status)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@EnrollmentID", enrollmentId);
                            insertCommand.Parameters.AddWithValue("@DateRecorded", dateRecorded);
                            insertCommand.Parameters.AddWithValue("@Status", status);
                            insertCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show("Attendance record recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the attendance record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
