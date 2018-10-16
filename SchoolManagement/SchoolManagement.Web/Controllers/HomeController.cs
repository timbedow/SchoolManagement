using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Data;
using SchoolManagement.Web.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISchoolRepository _schoolRepository;

        public HomeController(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var students = _schoolRepository.GetAllStudents().OrderBy(s => s.LastName);
            //TODO: var students = _schoolRepository.GetAllStudents().OrderBy(s => new { s.LastName, s.FirstName });
            //requires implementing IComparable interface
            var homeViewModel = new HomeViewModel()
            {
                Title = "School Management MVVM",
                Students = students.ToList()
            };
            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var student = _schoolRepository.GetStudentById(id);
            if (student == null)
                return NotFound();

            return View(student);
        }
    }
}
