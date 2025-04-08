using demo.Detail;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class Detail : Controller
    {
        private readonly Employedetail _edetail;

        public Detail(Employedetail edetail)
        {
            _edetail = edetail;
        }
        public IActionResult Index()
        {
            var Employe = _edetail.GetDetails();
            return View(Employe);
        }
    }
}
