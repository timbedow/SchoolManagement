using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SchoolManagement.Entities;

namespace SchoolManagement.Data
{
    public class SchoolRepositoryDb : ISchoolRepository
    {
        private readonly SchoolManagementContext _dbContext;
        public SchoolRepositoryDb(SchoolManagementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _dbContext.Students;
        }

        public Student GetStudentById(int studentId)
        {
            return _dbContext.Students.FirstOrDefault(s => s.Id == studentId);
        }
    }
}
