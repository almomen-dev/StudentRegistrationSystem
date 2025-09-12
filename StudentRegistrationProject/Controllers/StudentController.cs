using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;
using System.Collections.Generic;

namespace YourNamespace.Controllers
{
    [Route("student")]
    public class StudentController : Controller
    {
        // In-memory list to store students
        private static List<Student> students = new List<Student>();

        // GET: student/register
        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }

        // POST: student/register
        [HttpPost("register")]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                students.Add(student);
                TempData["SuccessMessage"] = "Student registered successfully!";
                return RedirectToAction("List");
            }
            TempData["ErrorMessage"] = "Please correct the errors!";
            return View(student);
        }

        // GET: student/list
        [Route("list")]
        public IActionResult List()
        {
            return View(students);
        }

        // GET: student/json
        [Route("json")]
        public IActionResult GetJson()
        {
            return Json(students);
        }
    }
}
