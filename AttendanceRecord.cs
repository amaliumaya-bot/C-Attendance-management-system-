using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class AttendanceRecord
    {
        private int attendanceId;
        private int enrollmentId;
        private DateTime dateRecorded;
        private string status;

        public int AttendanceID
        {
            get { return attendanceId; }
            set { attendanceId = value; }
        }

        public int EnrollmentID
        {
            get { return enrollmentId; }
            set { enrollmentId = value; }
        }

        public DateTime DateRecorded
        {
            get { return dateRecorded; }
            set { dateRecorded = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public AttendanceRecord()
        {
            this.attendanceId = 0;
            this.enrollmentId = 0;
            this.dateRecorded = DateTime.Today;
            this.status = string.Empty;
        }

        public AttendanceRecord(int attendanceId, int enrollmentId, DateTime dateRecorded, string status)
        {
            this.AttendanceID = attendanceId;
            this.EnrollmentID = enrollmentId;
            this.DateRecorded = dateRecorded;
            this.Status = status;
        }
    }
}
