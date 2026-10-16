using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class GradeRecord
    {
        private int gradeId;
        private int enrollmentId;
        private double examMarks;
        private double courseworkMarks;

        public int GradeID
        {
            get { return gradeId; }
            set { gradeId = value; }
        }

        public int EnrollmentID
        {
            get { return enrollmentId; }
            set { enrollmentId = value; }
        }

        public double ExamMarks
        {
            get { return examMarks; }
            set { examMarks = value; }
        }

        public double CourseworkMarks
        {
            get { return courseworkMarks; }
            set { courseworkMarks = value; }
        }

        public GradeRecord()
        {
            this.gradeId = 0;
            this.enrollmentId = 0;
            this.examMarks = 0.0;
            this.courseworkMarks = 0.0;
        }

        public GradeRecord(int gradeId, int enrollmentId, double examMarks, double courseworkMarks)
        {
            this.GradeID = gradeId;
            this.EnrollmentID = enrollmentId;
            this.ExamMarks = examMarks;
            this.CourseworkMarks = courseworkMarks;
        }

        public double CalculateTotalMarks()
        {
            return this.ExamMarks + this.CourseworkMarks;
        }
    }
}
