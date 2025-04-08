using Microsoft.AspNetCore.Mvc;

namespace Layout_changes.Controllers
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
