using Layout_changes.student;
using Microsoft.AspNetCore.Mvc;

namespace Layout_changes.Controllers
{
    public class Sdetail : Controller
    {
        private readonly Studentdetail _sdetail;

        public Sdetail(Studentdetail sdetail)
        {
            _sdetail = sdetail;
        }
        public IActionResult Index()
        {
            var student = _sdetail.Getstudent();
            return View(student);
        }
    }
}
