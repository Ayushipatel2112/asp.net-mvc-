using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using migration.Data;
using migration.Models;

namespace migration.Controllers
{
    public class ProductController(AppDBcontact dBcontact) : Controller
    {
        private readonly AppDBcontact _dBcontact = dBcontact;

        public IActionResult Index()
        {
            var product = new List<Product>(_dBcontact.Product);
            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _dBcontact.Product.Add(product);
                _dBcontact.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult Edit(int? id)
        {
            
            var product = _dBcontact.Product.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]

        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _dBcontact.Product.Update(product);
                _dBcontact.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet] // Allow GET request for Delete (⚠️ Not Recommended for security reasons)
        public IActionResult Delete(int id)
        {
            var product = _dBcontact.Product.Find(id);
            if (product == null)
            {
                return NotFound(); // This causes "Page Not Found" if ID is invalid
            }

            _dBcontact.Product.Remove(product);
            _dBcontact.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
