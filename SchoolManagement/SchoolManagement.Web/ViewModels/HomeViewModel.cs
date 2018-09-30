using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Web.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Student> Students { get; set; }

    }
}
