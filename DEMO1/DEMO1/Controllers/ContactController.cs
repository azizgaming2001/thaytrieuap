using DEMO1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DEMO1.Controllers
{
    public class ContactController : Controller
    {
        static List<Students> studentList = new List<Students>
        {
            new Students { StudentId = 1, StudentName = "Khanh", StudentAge = 21 },
            new Students { StudentId = 2, StudentName = "Cat", StudentAge = 22 },
            new Students { StudentId = 3, StudentName = "Phucs", StudentAge = 20 },
            new Students { StudentId = 4, StudentName = "Phong", StudentAge = 23 }
        };

        public IActionResult Money(int id, string name)
        {
            ViewData["id"] = id;
            ViewData["name"] = name;

            return View();
        }

        public IActionResult Index()
        {
            return View(studentList);
        }
    }
}
