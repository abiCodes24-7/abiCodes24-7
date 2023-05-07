using asp_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
               
            }
            return View();


        }
    }
}