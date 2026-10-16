using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public class Course
    {
        private int courseId;
        private string courseTitle;
        private int credits;

        public int CourseID
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public string CourseTitle
        {
            get { return courseTitle; }
            set { courseTitle = value; }
        }

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }

        public Course()
        {
            this.courseId = 0;
            this.courseTitle = string.Empty;
            this.credits = 0;
        }

        public Course(int courseId, string courseTitle, int credits)
        {
            this.CourseID = courseId;
            this.CourseTitle = courseTitle;
            this.Credits = credits;
        }
    }
}
