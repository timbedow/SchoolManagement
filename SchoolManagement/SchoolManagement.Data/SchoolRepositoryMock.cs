using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement.Data
{
    public class SchoolRepositoryMock: ISchoolRepository
    {
        private List<Student> _students;
        public SchoolRepositoryMock()
        {
            if (_students == null)
            {
                InitializeStudents();
            }
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _students;            
        }

        public Student GetStudentById(int studentId)
        {
            return _students.FirstOrDefault(s => s.Id == studentId);
        }

        private void InitializeStudents()
        {
            _students = new List<Student>
            {
                //https://www.randomlists.com/random-celebrities?qty=25
                new Student { Id = 1, FirstName = "Harrison", LastName = "Ford", DateOfBirth = new DateTime(1942, 07, 13), ImageUrl="https://www.randomlists.com/img/people/harrison_ford.jpg" },  
                new Student { Id = 2, FirstName = "Carrie", LastName = "Underwood", DateOfBirth = new DateTime(1983, 03, 10), ImageUrl="https://www.randomlists.com/img/people/carrie_underwood.jpg"},  
                new Student { Id = 3, FirstName = "Ben", LastName = "Affleck", DateOfBirth = new DateTime(1972, 08, 15), ImageUrl="https://www.randomlists.com/img/people/ben_affleck.jpg" }, 
                new Student { Id = 4, FirstName = "Johnny", LastName = "Depp", DateOfBirth = new DateTime(1963, 06, 09), ImageUrl="https://www.randomlists.com/img/people/johnny_depp.jpg" }, //
                new Student { Id = 5, FirstName = "Natalie", LastName = "Portman", DateOfBirth = new DateTime(1981, 06, 09), ImageUrl="https://www.randomlists.com/img/people/natalie_portman.jpg" }, //
                new Student { Id = 6, FirstName = "Adam", LastName = "Sandler", DateOfBirth = new DateTime(1966, 09, 09), ImageUrl="https://www.randomlists.com/img/people/adam_sandler.jpg" }
            };
        }
    }
}
