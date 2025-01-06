using Hotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class NewsletterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Newsletter(Newsletter newsletter)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", newsletter);
            }
            else { return View("Index", newsletter); }
        }
        [HttpPost]
        public IActionResult Wynik(Newsletter newsletter)
        {
            return View(newsletter);
        }
    }
}
