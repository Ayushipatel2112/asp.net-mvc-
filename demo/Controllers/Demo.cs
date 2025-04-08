using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class Demo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }
    }
}
