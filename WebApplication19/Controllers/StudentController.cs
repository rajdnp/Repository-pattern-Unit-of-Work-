using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication19.Interfaces;
using WebApplication19.ViewModels;

namespace WebApplication19.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _student;

        public StudentController(IStudent student)
        {
            _student = student;
        }
        [HttpGet]
        [Route("employee")]
        public IActionResult Employee()
        {
            return View("AddEmployee");
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(StudentViewModel model)
        {
            if (await _student.AddStudent(model))
            {
                return View();
            }
            return View();
        }
    }
}
