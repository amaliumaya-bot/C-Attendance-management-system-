using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Student : Person
    {
        private int studentId;

        public int StudentID
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public Student() : base()
        {
            this.studentId = 0;
        }

        public Student(int studentId, string fullName, string email, DateTime dateOfBirth)
            : base(fullName, email, dateOfBirth)
        {
            this.StudentID = studentId;
        }

        public override string GetDisplayInfo()
        {
            return "ID: " + this.StudentID + " | " + this.FullName + " | " + this.Email;
        }
    }
}
