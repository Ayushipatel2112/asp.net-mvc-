using Microsoft.AspNetCore.Mvc;

namespace Layout_changes.Controllers
{
    public class Service : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
