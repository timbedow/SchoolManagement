using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string ImageUrl { get; set; }

    }
}
