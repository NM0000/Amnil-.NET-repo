using Assignment_27_StudentInfo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Assignment_27_StudentInfo.Controllers
{
    public class StudentController : Controller
    {
        // Temporary in-memory student list
        private static List<Student> students = new()
        {
            new Student { Id = 1, Name = "Nishil Maharjan", Age = 22, Course = "Computer Science" },
            new Student { Id = 2, Name = "Yaju Shrestha", Age = 21, Course = "Information Technology" }
        };

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Details(int id)
        {
            var student = students.Find(s => s.Id == id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
            return RedirectToAction("Index");
        }
    }
}
