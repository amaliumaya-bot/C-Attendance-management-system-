using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    public abstract class Person
    {
        private string fullName;
        private string email;
        private DateTime dateOfBirth;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public Person()
        {
            this.fullName = string.Empty;
            this.email = string.Empty;
            this.dateOfBirth = DateTime.Now;
        }

        public Person(string fullName, string email, DateTime dateOfBirth)
        {
            this.FullName = fullName;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
        }

        public virtual string GetDisplayInfo()
        {
            return "Name: " + this.FullName + ", Email: " + this.Email;
        }
    }
}
