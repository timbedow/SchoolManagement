using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Data;

namespace SchoolManagement.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly ISchoolRepository _schoolRepository;

        public StudentController(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Students";
            //var students = _schoolRepository.Students().OrderBy(s => new { s.LastName, s.FirstName });
            var students = _schoolRepository.GetAllStudents().OrderBy(s => s.LastName);
            return View(students);
        }

        public ViewResult List()
        {
            return View(_schoolRepository.GetAllStudents());
        }
    }
}