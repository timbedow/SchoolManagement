using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Data;

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
            ViewBag.Title = "Students";
            //var students = _schoolRepository.Students().OrderBy(s => new { s.LastName, s.FirstName });
            var students = _schoolRepository.Students().OrderBy(s => s.LastName);
            return View(students);
        }
    }
}
