using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Enrollment
    {
        private int enrollmentId;
        private int studentId;
        private int courseId;

        public int EnrollmentID
        {
            get { return enrollmentId; }
            set { enrollmentId = value; }
        }

        public int StudentID
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public int CourseID
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public Enrollment()
        {
            this.enrollmentId = 0;
            this.studentId = 0;
            this.courseId = 0;
        }

        public Enrollment(int enrollmentId, int studentId, int courseId)
        {
            this.EnrollmentID = enrollmentId;
            this.StudentID = studentId;
            this.CourseID = courseId;
        }

        public string GetDisplayInfo()
        {
            return "Enrollment ID: " + this.EnrollmentID + " | Student ID: " + this.StudentID + " | Course ID: " + this.CourseID;
        }
    }
}
