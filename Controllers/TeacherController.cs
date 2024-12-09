using Microsoft.AspNetCore.Mvc;

using mvc.Models;

namespace mvc.Controllers
{
    public class TeacherController : Controller
    {
        private static List<Teacher> teachers = new()
        {
            new() { Firstname = "abababa", Id = 53,},
            new() { Firstname = "abababa", Id = 53,},
        };
        public ActionResult Index()
        {
            return View(teachers);
        }
    }
}