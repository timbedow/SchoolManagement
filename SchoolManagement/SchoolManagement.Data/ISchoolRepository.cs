﻿using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagement.Entities;

namespace SchoolManagement.Data
{
    public interface ISchoolRepository
    {
        IEnumerable<Student> GetAllStudents();

        Student GetStudentById(int studentId);
    }
}
